DROP TABLE KATEGORI CASCADE CONSTRAINTS PURGE;
DROP TABLE MERK CASCADE CONSTRAINTS PURGE;
DROP TABLE BARANG CASCADE CONSTRAINTS PURGE;
DROP TABLE JABATAN CASCADE CONSTRAINTS PURGE;
DROP TABLE USERS CASCADE CONSTRAINTS PURGE;
DROP TABLE BUSINESS_PARTNER CASCADE CONSTRAINTS PURGE;
DROP TABLE WAREHOUSE CASCADE CONSTRAINTS PURGE;
DROP TABLE BARANG_WAREHOUSE CASCADE CONSTRAINTS PURGE;
DROP TABLE ADJUSTMENT CASCADE CONSTRAINTS PURGE;
DROP TABLE HISTORY_BARANG_KELUAR_MASUK CASCADE CONSTRAINTS PURGE;
DROP TABLE H_KELUAR_BARANG CASCADE CONSTRAINTS PURGE;
DROP TABLE D_KELUAR_BARANG CASCADE CONSTRAINTS PURGE;
DROP TABLE H_PINDAH CASCADE CONSTRAINTS PURGE;
DROP TABLE D_PINDAH CASCADE CONSTRAINTS PURGE;
DROP TABLE H_ORDER_SUPPLIER CASCADE CONSTRAINTS PURGE;
DROP TABLE D_ORDER_SUPPLIER CASCADE CONSTRAINTS PURGE;

CREATE TABLE KATEGORI(
    ID NUMBER PRIMARY KEY,
    NAMA VARCHAR2(30) NOT NULL
);

CREATE TABLE MERK(
    ID NUMBER PRIMARY KEY,
    NAMA VARCHAR2(30) NOT NULL
);

CREATE TABLE BARANG(
    ID NUMBER PRIMARY KEY,
    KODE VARCHAR2(7) NOT NULL,
    NAMA VARCHAR2(70) NOT NULL,
    DESKRIPSI VARCHAR2(100),
    HARGA NUMBER NOT NULL,
    ID_KATEGORI NUMBER REFERENCES KATEGORI(ID) NOT NULL,
    ID_MERK NUMBER REFERENCES MERK(ID) NOT NULL,
    MULTIPLIER NUMBER NOT NULL,
    QTY NUMBER NOT NULL,
    STATUS NUMBER CHECK(STATUS = 1 OR STATUS = 0)
);

CREATE TABLE JABATAN(
    ID NUMBER PRIMARY KEY,
    NAMA VARCHAR2(30) NOT NULL
);

CREATE TABLE USERS(
    ID NUMBER PRIMARY KEY,
    NAMA VARCHAR2(50) NOT NULL,
    USERNAME VARCHAR2(50) NOT NULL,
    PASSWORD VARCHAR2(50) NOT NULL,
    ID_JABATAN NUMBER REFERENCES JABATAN(ID) NOT NULL,
    ALAMAT VARCHAR2(70) NOT NULL,
    EMAIL VARCHAR2(50) NOT NULL,
    STATUS NUMBER CHECK(STATUS = 1 OR STATUS = 0)
);

CREATE TABLE BUSINESS_PARTNER(
    ID NUMBER PRIMARY KEY,
    KODE VARCHAR2(6) NOT NULL,
    NAMA VARCHAR2(70) NOT NULL,
    TELEPON VARCHAR2(15) NOT NULL,
    ALAMAT VARCHAR2(70) NOT NULL
);

CREATE TABLE WAREHOUSE(
    ID NUMBER PRIMARY KEY,
    NAMA VARCHAR2(40) NOT NULL,
    ALAMAT VARCHAR2(70) NOT NULL,
    TELEPON VARCHAR2(15) NOT NULL,
    ID_USER NUMBER,
    STATUS NUMBER CHECK(STATUS = 1 OR STATUS = 0)
);

-- CREATE TABLE RAK_WAREHOUSE(
--     ID NUMBER PRIMARY KEY,
--     KODE VARCHAR2(8) NOT NULL,
--     ID_WAREHOUSE NUMBER REFERENCES WAREHOUSE(ID) NOT NULL,
--     KETERANGAN VARCHAR2(70)
-- );

CREATE TABLE BARANG_WAREHOUSE(
    ID NUMBER PRIMARY KEY,
    ID_WAREHOUSE NUMBER REFERENCES WAREHOUSE(ID) NOT NULL,
    ID_BARANG NUMBER REFERENCES BARANG(ID) NOT NULL,
    QTY NUMBER NOT NULL,
    STATUS NUMBER CHECK(STATUS = 1 OR STATUS = 0)
);

CREATE TABLE ADJUSTMENT(
    ID NUMBER PRIMARY KEY,
    REAL_QTY NUMBER NULL,
    QTY NUMBER NOT NULL,
    TANGGAL DATE NOT NULL,
    ID_BARANG NUMBER REFERENCES BARANG(ID) NOT NULL,
    ID_WAREHOUSE NUMBER REFERENCeS WAREHOUSE(ID) NOT NULL,
    KETERANGAN VARCHAR2(70) NOT NULL
);

CREATE TABLE HISTORY_BARANG_KELUAR_MASUK(
    ID_BARANG NUMBER REFERENCES BARANG(ID) NOT NULL,
    TANGGAL DATE NOT NULL,
    QTY NUMBER NOT NULL,
    KETERANGAN VARCHAR2(70),
    ID_WAREHOUSE NUMBER REFERENCeS WAREHOUSE(ID) NOT NULL,
    NAMA_TUJUAN VARCHAR2(30) NOT NULL,
    STATUS NUMBER CHECK(STATUS = 1 OR STATUS = 0)
);

CREATE TABLE H_KELUAR_BARANG(
    KODE VARCHAR2(6) PRIMARY KEY,
    ID_PARTNER NUMBER REFERENCES BUSINESS_PARTNER(ID) NOT NULL,
    TANGGAL DATE NOT NULL,
    ID_WAREHOUSE NUMBER REFERENCES WAREHOUSE(ID) NOT NULL
);

CREATE TABLE D_KELUAR_BARANG(
    KODE_KELUAR VARCHAR2(6) REFERENCES H_KELUAR_BARANG(KODE) NOT NULL,
    ID_BARANG NUMBER REFERENCES BARANG(ID) NOT NULL,
    QTY NUMBER NOT NULL
);

CREATE TABLE H_PINDAH(
    KODE VARCHAR2(6) PRIMARY KEY,
    ASAL NUMBER REFERENCES WAREHOUSE(ID) NOT NULL,
    TUJUAN NUMBER REFERENCES WAREHOUSE(ID) NOT NULL,
    TOTAL_QTY NUMBER NOT NULL,
    TANGGAL DATE NOT NULL, 
    STATUS NUMBER CHECK(STATUS = 0 OR STATUS = 1 OR STATUS = 2)
);

CREATE TABLE D_PINDAH(
    KODE_PINDAH VARCHAR2(6) REFERENCES H_PINDAH(KODE) NOT NULL,
    ID_BARANG NUMBER REFERENCES BARANG(ID) NOT NULL,
    QTY NUMBER NOT NULL
);

CREATE TABLE H_ORDER_SUPPLIER(
    KODE VARCHAR2(14) PRIMARY KEY,
    ID_PARTNER NUMBER REFERENCES BUSINESS_PARTNER(ID) NOT NULL,
    ETA DATE NOT NULL,
    STATUS NUMBER CHECK(STATUS = 0 OR STATUS = 1 OR STATUS = 2 OR STATUS = 3 OR STATUS = 4),
    QTY NUMBER NOT NULL,
    ID_WAREHOUSE NUMBER REFERENCES WAREHOUSE(ID)  NOT NULL,
    GRAND_TOTAL NUMBER NOT NULL
);

CREATE TABLE D_ORDER_SUPPLIER(
    KODE_ORDER VARCHAR2(14) REFERENCES H_ORDER_SUPPLIER(KODE) NOT NULL,
    ID_BARANG NUMBER REFERENCES BARANG(ID) NOT NULL,
    QTY NUMBER NOT NULL
);

-- JABATAN
INSERT INTO JABATAN VALUES(1, 'Master Account');
INSERT INTO JABATAN VALUES(2, 'Warehouse Manager');
INSERT INTO JABATAN VALUES(3, 'Pegawai Warehouse');

-- USER
INSERT INTO USERS VALUES(1, 'Enrico', 'e', 'e', 2, 'Jalan Maju Nomor 2', 'enrico@gmail.com',1);
INSERT INTO USERS VALUES(2, 'Chrisanto', 'c', 'c', 1, 'Jalan Mundur Nomor 18', 'chris@gmail.com',1);
INSERT INTO USERS VALUES(3, 'Michael', 'Michael1', 'Michael1', 2, 'Jalan Tegak Maju Gerak Nomor 11', 'michael@gmail.com',1);
INSERT INTO USERS VALUES(4, 'Kevin', 'Kevin123', 'Kevin123', 2, 'Jalan Apel Hijau Nomor 42', 'kevin@gmail.com', 1);
INSERT INTO USERS VALUES(5, 'Steven', 'Steven12', 'Steven12', 2, 'Jalan Mangga Nomor 54', 'steven@gmail.com', 0);
INSERT INTO USERS VALUES(6, 'Bambang', 'Bambang1', 'Bambang1', 1, 'Jalan Jalan Kesana Kemari Nomor 9', 'bambang@gmail.com', 1);
INSERT INTO USERS VALUES(7, 'Budi', 'Budi12345', 'Budi12345', 1, 'Jalan Santuy Nomor 8', 'budi@gmail.com', 1);
INSERT INTO USERS VALUES(8, 'Agus', 'Agus1', 'Agus1', 2, 'Jalan Kemana Aja Bisa Sih Nomor 152', 'agus@gmail.com',1);
INSERT INTO USERS VALUES(9, 'Valentino', 'Valentino1', 'Valentino1', 2, 'Jalan Tepi Laut Nomor 253', 'valentino@gmail.com', 1);

-- MERK
INSERT INTO Merk VALUES(1, 'ASUS');
INSERT INTO Merk VALUES(2, 'OPPO');
INSERT INTO Merk VALUES(3, 'LENOVO');
INSERT INTO Merk VALUES(4, 'XIAOMI');
INSERT INTO Merk VALUES(5, 'SAMSUNG');
INSERT INTO Merk VALUES(6, 'REXUS'); 
INSERT INTO Merk VALUES(7, 'APPLE'); 
INSERT INTO Merk VALUES(8, 'NVIDIA'); 
INSERT INTO Merk VALUES(9, 'LOGITECH'); 
INSERT INTO Merk VALUES(10, 'SANDISK'); 

-- KATEGORI
INSERT INTO KATEGORI VALUES(1, 'Laptop');
INSERT INTO KATEGORI VALUES(2, 'Keyboard');
INSERT INTO KATEGORI VALUES(3, 'Handphone');
INSERT INTO KATEGORI VALUES(4, 'Headphone');
INSERT INTO KATEGORI VALUES(5, 'Mouse');
INSERT INTO KATEGORI VALUES(6, 'Flashdisk');
INSERT INTO KATEGORI VALUES(7, 'RAM');
INSERT INTO KATEGORI VALUES(8, 'VGA');

-- WAREHOUSE
INSERT INTO WAREHOUSE VALUES(1, 'Warehouse 1', 'Jalan Monyet Nomor 1', '081357630987', 1, 1);
INSERT INTO WAREHOUSE VALUES(2, 'Warehouse 2', 'Jalan Harimau Nomor 12', '081398819927', 3, 1);
INSERT INTO WAREHOUSE VALUES(3, 'Warehouse 3', 'Jalan Singa Nomor 98', '081157483981', 4, 1);
INSERT INTO WAREHOUSE VALUES(4, 'Warehouse 4', 'Jalan Kuda Nomor 23', '081147630230', 8, 1);
INSERT INTO WAREHOUSE VALUES(5, 'Warehouse 5', 'Jalan Raja Nomor 99', '081262580920', 9, 1);

-- BUSINESS PARTNER
INSERT INTO BUSINESS_PARTNER VALUES(1, 'BP0001', 'PT Mega', '087487293012', 'Jalan Sejahtera Jaya Nomor 3');
INSERT INTO BUSINESS_PARTNER VALUES(2, 'BP0002', 'PT Dua', '087487293144', 'Jalan Kenangan Indah Nomor 12');
INSERT INTO BUSINESS_PARTNER VALUES(3, 'BP0003', 'PT Jaya Mega', '081019893532', 'Jalan Gula Gula Nomor 20');
INSERT INTO BUSINESS_PARTNER VALUES(4, 'BP0004', 'Toko Mega Sumber Rezeki', '087487883054', 'Jalan Ku Bukan Jalan Mu Nomor 02');
INSERT INTO BUSINESS_PARTNER VALUES(5, 'BP0005', 'Toko Alfa Komputer Teknik', '087469293031', 'Jalan Kenangan Blok B Nomor 9');
INSERT INTO BUSINESS_PARTNER VALUES(6, 'BP0006', 'CV Sumber Maju Bersama', '087482293000', 'Jalan Bersama Dia Nomor 88');

-- BARANG
INSERT INTO BARANG VALUES(1, 'BMP0001', 'Macbook Pro 256GB', '13 inch Space Grey', 18300000, 1, 7, 10, 2, 1);
INSERT INTO BARANG VALUES(2, 'BMP0002', 'Macbook Pro 512GB', '13 inch Gold', 19449000, 1, 7, 15, 2, 1);
INSERT INTO BARANG VALUES(3, 'BLL0001', 'Lenovo Legion 5i', 'i7-11800H, 1TB SSD, 32GB DDR4-3200MHz', 27599000, 1, 3, 10, 3, 1);
INSERT INTO BARANG VALUES(4, 'BLL0002', 'Lenovo Legion 7i', 'i7-10875H, 1TB SSD, 32GB DDR4-3200MHz', 35999000, 1, 3, 10, 2, 1);
INSERT INTO BARANG VALUES(5, 'BAR0001', 'Asus ROG Flow X13', 'AMD Ryzen 9 5980HS, RTX 3050Ti, 32GB DDR4-3200MHz', 60499000, 1, 1, 10, 2, 1);
INSERT INTO BARANG VALUES(6, 'BAZ0001', 'Asus Zepyrus Duo Pro', 'AMD Ryzen 7 5800H, RTX 3060, 16GB DDR4-3200MHz', 34499000, 1, 1, 10, 2, 1);
INSERT INTO BARANG VALUES(7, 'BSS0001', 'Samsung S21', '128GB White', 10740000, 3, 5, 25, 3, 1);
INSERT INTO BARANG VALUES(8, 'BSN0001', 'Samsung Note 20 Ultra', '256GB Black', 9990000, 3, 5, 25, 4, 1);
INSERT INTO BARANG VALUES(9, 'BSN0002', 'Samsung Note 8', '256GB Black', 10499000, 3, 5, 15, 1, 0);
INSERT INTO BARANG VALUES(10, 'BXP0001', 'Xiaomi Poco F3', '256GB, 8GB RAM, Black', 4775000, 3, 4, 30, 3, 1);
INSERT INTO BARANG VALUES(11, 'BOR0001', 'Oppo Reno 6', '128GB, 8GB RAM, Black', 5199000, 3, 2, 20, 2, 1);
INSERT INTO BARANG VALUES(12, 'BGR0001', 'GeForce RTX 3070', null, 17750000, 8, 8, 25, 5, 1);
INSERT INTO BARANG VALUES(13, 'BGR0002', 'GeForce RTX 3060', null, 12950000, 8, 8, 25, 2, 1);
INSERT INTO BARANG VALUES(14, 'BGG0001', 'GeForce GTX 1660Ti', null, 10430000, 8, 8, 25, 1, 1);
INSERT INTO BARANG VALUES(15, 'BRL0001', 'RAM Laptop 8GB', '2667MHz', 417000, 7, 5, 15, 1, 1);
INSERT INTO BARANG VALUES(16, 'BRL0002', 'RAM Laptop 16GB', '3200MHz', 634000, 7, 5, 15, 1, 1);
INSERT INTO BARANG VALUES(17, 'BLG0001', 'Logitech G PRO X Superlight', '1000Hz polling rate, wireless, 100-25600 DPI', 2299000, 5, 9, 12, 5, 1);
INSERT INTO BARANG VALUES(18, 'BLG0003', 'Logitech G703 HERO', '1000Hz polling rate, 200-25600 DPI', 1389000, 5, 9, 10, 1, 1);
INSERT INTO BARANG VALUES(19, 'BLG0004', 'Logitech G733 Lightspeed', 'Wireless', 1939000, 4, 9, 15, 1, 1);
INSERT INTO BARANG VALUES(20, 'BRL0001', 'Rexus Legionare MX9', 'TKL, Red Switch', 409000, 2, 6, 10, 2, 1);
INSERT INTO BARANG VALUES(21, 'BRL0002', 'Rexus Legionare MX5.2', 'TKL, Blue Switch', 389000, 2, 6, 10, 2, 1);
INSERT INTO BARANG VALUES(22, 'BSF0001', 'SanDisk Flash Drive 16GB', null, 59000, 6, 10, 10, 5, 1);
INSERT INTO BARANG VALUES(23, 'BSF0002', 'SanDisk Flash Drive 32GB', null, 74000, 6, 10, 10, 5, 0);
INSERT INTO BARANG VALUES(24, 'BSF0003', 'SanDisk Flash Drive 64GB', null, 99900, 6, 10, 10, 3, 1);
INSERT INTO BARANG VALUES(25, 'BSF0004', 'SanDisk Flash Drive 128GB', null, 139900, 6, 10, 10, 1, 1);
INSERT INTO BARANG VALUES(26, 'BAM0001', 'AirPods Max', 'Space Gray', 8299000, 4, 7, 10, 2, 1);
INSERT INTO BARANG VALUES(27, 'BLG0002', 'Logitech G102 Lightsync', '1000Hz polling rate, 200-8000 DPI', 250000, 5, 9, 12, 3, 1);

-- RAK WAREHOUSE
-- INSERT INTO RAK_WAREHOUSE VALUES(1, 'RAK01001', 1, null);
-- INSERT INTO RAK_WAREHOUSE VALUES(2, 'RAK01002', 1, null);
-- INSERT INTO RAK_WAREHOUSE VALUES(3, 'RAK01003', 1, null);
-- INSERT INTO RAK_WAREHOUSE VALUES(4, 'RAK02001', 2, null);
-- INSERT INTO RAK_WAREHOUSE VALUES(5, 'RAK02002', 2, null);
-- INSERT INTO RAK_WAREHOUSE VALUES(6, 'RAK02003', 2, null);
-- INSERT INTO RAK_WAREHOUSE VALUES(7, 'RAK03001', 3, null);
-- INSERT INTO RAK_WAREHOUSE VALUES(8, 'RAK03002', 3, null);
-- INSERT INTO RAK_WAREHOUSE VALUES(9, 'RAK03003', 3, null);
-- INSERT INTO RAK_WAREHOUSE VALUES(10, 'RAK04001', 4, null);
-- INSERT INTO RAK_WAREHOUSE VALUES(11, 'RAK04002', 4, null);
-- INSERT INTO RAK_WAREHOUSE VALUES(12, 'RAK04003', 4, null);
-- INSERT INTO RAK_WAREHOUSE VALUES(13, 'RAK05001', 5, null);
-- INSERT INTO RAK_WAREHOUSE VALUES(14, 'RAK05002', 5, null);
-- INSERT INTO RAK_WAREHOUSE VALUES(15, 'RAK05003', 5, null);

-- BARANG WAREHOUSE idw2 idb3
INSERT INTO BARANG_WAREHOUSE VALUES(1, 1, 1, 2, 1);
INSERT INTO BARANG_WAREHOUSE VALUES(2, 1, 2, 2, 1);
INSERT INTO BARANG_WAREHOUSE VALUES(3, 1, 3, 3, 1);
INSERT INTO BARANG_WAREHOUSE VALUES(4, 1, 4, 2, 1);
INSERT INTO BARANG_WAREHOUSE VALUES(5, 1, 5, 2, 1);
INSERT INTO BARANG_WAREHOUSE VALUES(6, 1, 6, 2, 1);
INSERT INTO BARANG_WAREHOUSE VALUES(7, 1, 7, 3, 1);
INSERT INTO BARANG_WAREHOUSE VALUES(8, 2, 8, 4, 1);
INSERT INTO BARANG_WAREHOUSE VALUES(9, 2, 9, 1, 0);
INSERT INTO BARANG_WAREHOUSE VALUES(10, 2, 10, 3, 1);
INSERT INTO BARANG_WAREHOUSE VALUES(11, 2, 11, 2, 1);
INSERT INTO BARANG_WAREHOUSE VALUES(12, 2, 12, 5, 1);
INSERT INTO BARANG_WAREHOUSE VALUES(13, 2, 13, 2, 1);
INSERT INTO BARANG_WAREHOUSE VALUES(14, 3, 14, 1, 1);
INSERT INTO BARANG_WAREHOUSE VALUES(15, 3, 15, 1, 1);
INSERT INTO BARANG_WAREHOUSE VALUES(16, 3, 16, 1, 1);
INSERT INTO BARANG_WAREHOUSE VALUES(17, 3, 17, 5, 1);
INSERT INTO BARANG_WAREHOUSE VALUES(18, 3, 18, 1, 1);
INSERT INTO BARANG_WAREHOUSE VALUES(19, 3, 19, 1, 1);
INSERT INTO BARANG_WAREHOUSE VALUES(20, 4, 20, 2, 1);
INSERT INTO BARANG_WAREHOUSE VALUES(21, 4, 21, 2, 1);
INSERT INTO BARANG_WAREHOUSE VALUES(22, 4, 22, 5, 1);
INSERT INTO BARANG_WAREHOUSE VALUES(23, 5, 23, 5, 0);
INSERT INTO BARANG_WAREHOUSE VALUES(24, 5, 24, 4, 1);
INSERT INTO BARANG_WAREHOUSE VALUES(25, 5, 25, 1, 1);
INSERT INTO BARANG_WAREHOUSE VALUES(26, 5, 26, 2, 1);
INSERT INTO BARANG_WAREHOUSE VALUES(27, 5, 27, 3, 1);

-- ADJUSTMENT
INSERT INTO ADJUSTMENT VALUES(1, 2, 3, TO_DATE('01/12/2021','DD/MM/YYYY'), 1, 1, 'Barang Rusak');
INSERT INTO ADJUSTMENT VALUES(2, 5, 3, TO_DATE('22/04/2021','DD/MM/YYYY'), 17, 3,'Ada kesalahan penghitungan');
INSERT INTO ADJUSTMENT VALUES(3, 2, 1, TO_DATE('14/07/2021','DD/MM/YYYY'), 21, 4, 'Ada penambahan barang yang belum terhitung');
INSERT INTO ADJUSTMENT VALUES(4, 5, 6, TO_DATE('04/10/2021','DD/MM/YYYY'), 22, 4, 'Barang Rusak');
INSERT INTO ADJUSTMENT VALUES(5, 2, 3, TO_DATE('30/11/2021','DD/MM/YYYY'), 26, 5, 'Barang Rusak');

-- HISTORY BARANG KELUAR MASUK 
INSERT INTO HISTORY_BARANG_KELUAR_MASUK VALUES(1, TO_DATE('04/05/2021', 'DD/MM/YYYY'), 1, 'P-2', 1, 'Warehouse 2', 0);
INSERT INTO HISTORY_BARANG_KELUAR_MASUK VALUES(3, TO_DATE('04/05/2021', 'DD/MM/YYYY'), 3, 'P-3', 1, 'Warehouse 3', 0);
INSERT INTO HISTORY_BARANG_KELUAR_MASUK VALUES(8, TO_DATE('04/05/2021', 'DD/MM/YYYY'), 2, 'P-4', 2, 'Warehouse 4', 0);
INSERT INTO HISTORY_BARANG_KELUAR_MASUK VALUES(13, TO_DATE('17/03/2021', 'DD/MM/YYYY'), 1, 'B-1', 2, 'PT Mega', 0);
INSERT INTO HISTORY_BARANG_KELUAR_MASUK VALUES(10, TO_DATE('17/03/2021', 'DD/MM/YYYY'), 4, 'B-1', 2, 'PT Mega', 0);
INSERT INTO HISTORY_BARANG_KELUAR_MASUK VALUES(14, TO_DATE('28/02/2021', 'DD/MM/YYYY'), 1, 'P-1', 2, 'Warehouse 1', 0);
INSERT INTO HISTORY_BARANG_KELUAR_MASUK VALUES(16, TO_DATE('28/02/2021', 'DD/MM/YYYY'), 2, 'B-3', 3, 'PT Jaya Mega', 0);
INSERT INTO HISTORY_BARANG_KELUAR_MASUK VALUES(17, TO_DATE('28/02/2021', 'DD/MM/YYYY'), 4, 'B-3', 3, 'PT Jaya Mega', 0);
INSERT INTO HISTORY_BARANG_KELUAR_MASUK VALUES(19, TO_DATE('28/02/2021', 'DD/MM/YYYY'), 1, 'B-1', 3, 'PT Mega', 0);
INSERT INTO HISTORY_BARANG_KELUAR_MASUK VALUES(20, TO_DATE('15/11/2021', 'DD/MM/YYYY'), 2, 'P-3', 4, 'Warehouse 3', 0);
INSERT INTO HISTORY_BARANG_KELUAR_MASUK VALUES(21, TO_DATE('15/11/2021', 'DD/MM/YYYY'), 3, 'P-2', 4, 'Warehouse 2',0);
INSERT INTO HISTORY_BARANG_KELUAR_MASUK VALUES(22, TO_DATE('23/07/2021', 'DD/MM/YYYY'), 1, 'P-5', 4, 'Warehouse 5',0);
INSERT INTO HISTORY_BARANG_KELUAR_MASUK VALUES(20, TO_DATE('23/07/2021', 'DD/MM/YYYY'), 3, 'P-1', 4, 'Warehouse 1',0);
INSERT INTO HISTORY_BARANG_KELUAR_MASUK VALUES(27, TO_DATE('23/07/2021', 'DD/MM/YYYY'), 2, 'B-1', 5, 'PT Mega',0);
INSERT INTO HISTORY_BARANG_KELUAR_MASUK VALUES(26, TO_DATE('30/03/2021', 'DD/MM/YYYY'), 3, 'B-2', 5, 'Toko Alfa Komputer Teknik',1);
INSERT INTO HISTORY_BARANG_KELUAR_MASUK VALUES(25, TO_DATE('30/03/2021', 'DD/MM/YYYY'), 1, 'B-4', 5, 'Toko Alfa Komputer Teknik',1);
INSERT INTO HISTORY_BARANG_KELUAR_MASUK VALUES(24, TO_DATE('30/03/2021', 'DD/MM/YYYY'), 1, 'B-6', 5, 'Toko Alfa Komputer Teknik',1);
INSERT INTO HISTORY_BARANG_KELUAR_MASUK VALUES(16, TO_DATE('27/08/2021', 'DD/MM/YYYY'), 2, 'P-1', 3, 'Warehouse 3',1);
INSERT INTO HISTORY_BARANG_KELUAR_MASUK VALUES(19, TO_DATE('27/08/2021', 'DD/MM/YYYY'), 2, 'P-5', 3, 'Warehouse3',1);

-- H KELUAR BARANG
INSERT INTO H_KELUAR_BARANG VALUES('HK0001', 5, TO_DATE('04/05/2021', 'DD/MM/YYYY'), 1);
INSERT INTO H_KELUAR_BARANG VALUES('HK0002', 4, TO_DATE('17/03/2021', 'DD/MM/YYYY'), 3);
INSERT INTO H_KELUAR_BARANG VALUES('HK0003', 6, TO_DATE('28/02/2021', 'DD/MM/YYYY'), 3);
INSERT INTO H_KELUAR_BARANG VALUES('HK0004', 6, TO_DATE('15/11/2021', 'DD/MM/YYYY'), 2);
INSERT INTO H_KELUAR_BARANG VALUES('HK0005', 4, TO_DATE('23/07/2021', 'DD/MM/YYYY'), 5);

-- D KELUAR BARANG
INSERT INTO D_KELUAR_BARANG VALUES('HK0001', 1, 1);
INSERT INTO D_KELUAR_BARANG VALUES('HK0001', 3, 3);
INSERT INTO D_KELUAR_BARANG VALUES('HK0001', 5, 2);
INSERT INTO D_KELUAR_BARANG VALUES('HK0002', 15, 1);
INSERT INTO D_KELUAR_BARANG VALUES('HK0002', 19, 4);
INSERT INTO D_KELUAR_BARANG VALUES('HK0003', 14, 1);
INSERT INTO D_KELUAR_BARANG VALUES('HK0003', 16, 2);
INSERT INTO D_KELUAR_BARANG VALUES('HK0003', 17, 4);
INSERT INTO D_KELUAR_BARANG VALUES('HK0003', 19, 1);
INSERT INTO D_KELUAR_BARANG VALUES('HK0004', 8, 2);
INSERT INTO D_KELUAR_BARANG VALUES('HK0004', 10, 3);
INSERT INTO D_KELUAR_BARANG VALUES('HK0005', 24, 1);
INSERT INTO D_KELUAR_BARANG VALUES('HK0005', 26, 3);
INSERT INTO D_KELUAR_BARANG VALUES('HK0005', 27, 2);

-- H PINDAH 
INSERT INTO H_PINDAH VALUES('HP0001', 1, 2, 2, TO_DATE('02/12/2021','DD/MM/YYYY'), 1);
INSERT INTO H_PINDAH VALUES('HP0002', 5, 3, 2, TO_DATE('03/12/2022','DD/MM/YYYY'), 1);
INSERT INTO H_PINDAH VALUES('HP0003', 2, 4, 4, TO_DATE('24/01/2022','DD/MM/YYYY'), 1);

-- D PINDAH  
INSERT INTO D_PINDAH VALUES('HP0001', 8, 1);
INSERT INTO D_PINDAH VALUES('HP0001', 9, 1);  
INSERT INTO D_PINDAH VALUES('HP0002', 14, 1);
INSERT INTO D_PINDAH VALUES('HP0002', 15, 1); 
INSERT INTO D_PINDAH VALUES('HP0003', 20, 1);
INSERT INTO D_PINDAH VALUES('HP0003', 22, 3);

-- H ORDER SUPPLIER
INSERT INTO H_ORDER_SUPPLIER VALUES('HO210320210001', 1, TO_DATE('30/03/2021', 'DD/MM/YYYY'), 3, 5, 1, 15450000);
INSERT INTO H_ORDER_SUPPLIER VALUES('HO140820210001', 2, TO_DATE('25/08/2021', 'DD/MM/YYYY'), 2, 4, 3, 27545000);
INSERT INTO H_ORDER_SUPPLIER VALUES('HO031220210001', 3, TO_DATE('23/01/2022', 'DD/MM/YYYY'), 1, 6, 4, 21760000);

-- D ORDER SUPPLIER
INSERT INTO D_ORDER_SUPPLIER VALUES('HO210320210001', 2, 3);
INSERT INTO D_ORDER_SUPPLIER VALUES('HO210320210001', 3, 1);
INSERT INTO D_ORDER_SUPPLIER VALUES('HO210320210001', 5, 1);
INSERT INTO D_ORDER_SUPPLIER VALUES('HO140820210001', 16, 2);
INSERT INTO D_ORDER_SUPPLIER VALUES('HO140820210001', 19, 2);
INSERT INTO D_ORDER_SUPPLIER VALUES('HO031220210001', 20, 3);
INSERT INTO D_ORDER_SUPPLIER VALUES('HO031220210001', 21, 1);
INSERT INTO D_ORDER_SUPPLIER VALUES('HO031220210001', 22, 2);

COMMIT;