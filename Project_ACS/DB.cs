using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Collections;

namespace Project_ACS
{
    class DB
    {
        private static OracleConnection conn;
        private static OracleCommand cmd;
        private static Dictionary<string, OracleDbType> oracle_type = new Dictionary<string, OracleDbType>();

        public static string init()
        {
            string result = "";
            conn = new OracleConnection(env.oracle_connection_string());
            try
            {
                conn.Open();
                conn.Close();
                oracle_type.Add("varchar", OracleDbType.Varchar2);
                oracle_type.Add("int32", OracleDbType.Int32);
                oracle_type.Add("date", OracleDbType.Date);
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }

        public static void executeDataSet(DataSet ds, string query, List<object[]> param, string namaTabel)
        {
            conn.Open();
            //
            cmd = new OracleCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;

            if(param != null)
            {
                addCmdParamList(cmd, param);
            }

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(ds,namaTabel);
            //
            conn.Close();
        }

        public static void executeQuery(string query, List<object[]> param)
        {
            conn.Open();
            //
            cmd = new OracleCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;

            if(param != null)
            {
                addCmdParamList(cmd, param);
            }

            cmd.ExecuteNonQuery();
            //
            conn.Close();
        }

        private static void addCmdParamList(OracleCommand cmd, List<object[]> param)
        {
            for (int i = 0; i < param.Count; i++)
            {
                OracleParameter pm = new OracleParameter(i.ToString(), oracle_type[param[i][1].ToString()]);
                pm.Value = param[i][0];
                cmd.Parameters.Add(pm);
            }
        }

        public static object executeScalar(string query, List<object[]> param)
        {
            conn.Open();
            //
            object r = null;
            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            
            if(param != null)
            {
                addCmdParamList(cmd, param);
            }

            r = cmd.ExecuteScalar();
            //
            conn.Close();
            return r;
        }
        public static DataTable get(string query)
        {

            OracleCommand cmd = new OracleCommand(query, DB.conn);
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }
        public static String getScalar(string query)
        {
            OracleCommand cmd = new OracleCommand(query, DB.conn);
            conn.Open();
            string res = cmd.ExecuteScalar().ToString();
            conn.Close();
            return res;
        }
        public static List<String> getList(string query, string rowname)
        {
            //ini buat dapetin ke list 
            DataTable d = DB.get(query);
            List<String> data = new List<string>();
            for (int i = 0; i < d.Rows.Count; i++)
            {
                DataRow dr = d.Rows[i];
                data.Add(dr.Field<string>(rowname));
            }
            return data;
        }
        public static List<String> convertDataTableToList(DataTable table, string rowname, string datatype)
        { 
            List<String> data = new List<String>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow dr = table.Rows[i];
                if (datatype == "decimal")
                {
                    data.Add(dr.Field<Decimal>(rowname).ToString()); 
                }
                else if (datatype == "int")
                {
                    data.Add(dr.Field<int>(rowname).ToString());
                }
                else
                {
                    data.Add(dr.Field<string>(rowname).ToString()); 
                }
            }
            return data;
        }
    }
}

// CONTOH PENGGUNAAN

// EXECUTE SCALAR //
// ====================== //
// List<object[]> listParam = new List<object[]>();
// listParam.Add(new object[] { "10000", "varchar" });

// string query = "select count(*) from roti where harga > :0";
// int a = DB.executeScalar(query, listParam);

// Catatan : Untuk select bisa dipukul rata varchar , tapi kalo insert & update rasanya nggak (harus spesifik tipe data nya apa. Lihat dictionary atas).


// INSERT //
// ====================== //
// List<object[]> listParam = new List<object[]>();
// listParam.Add(new object[] { "90", "int32" });
// listParam.Add(new object[] { "CHSI0001", "varchar" });
// listParam.Add(new object[] { "user_c", "varchar" });
// listParam.Add(new object[] { "pass_c", "varchar" });
// listParam.Add(new object[] { "Chrisanto Sinatra", "varchar" });
// listParam.Add(new object[] { "L", "varchar" });
// listParam.Add(new object[] { "Jl Jl", "varchar" });
// listParam.Add(new object[] { "c@g.com", "varchar" });
// listParam.Add(new object[] { "081234", "varchar" });
// listParam.Add(new object[] { System.DateTime.Now, "date" });
// listParam.Add(new object[] { 2, "int32" });
// listParam.Add(new object[] { System.DateTime.Now.AddDays(90), "date" });
// listParam.Add(new object[] { 2, "int32" });
// (1, 'RATR00001', 'RaymondT', 'RaymondT', 'Raymond Tranatung', 'L', 'Jalan Penampungan No. 6', 'raymondt@gmail.com', '08345671222', TO_DATE('13/06/2001', 'dd/mm/yyyy'), 2, TO_DATE('14/01/2022', 'dd/mm/yyyy'), 1);
// string query = "INSERT INTO PELANGGAN VALUES(:0, :1, :2, :3, :4, :5, :6, :7, :8, :9, :10, :11, :12)";

// SELECT (executeDataSet) //
// ====================== //
// List<object[]> listParam = new List<object[]>();
// listParam.Add(new object[] { "bread", "varchar" });
// DB.executeDataSet(ds, "select * from roti where LOWER(nama) like '%' || :0 || '%'", listParam, "rt");

// List<object[]> listParam = new List<object[]>();
// listParam.Add(new object[] { "15000", "int32" });
// listParam.Add(new object[] { "75000", "int32" });
// DB.executeDataSet(ds, "select * from roti where harga > :0 and harga < :1", listParam, "rt");

// List<object[]> listParam = new List<object[]>();
// listParam.Add(new object[] { "10000", "varchar" });
// DB.executeDataSet(ds, "select * from roti where harga > 15000", listParam, "rt");