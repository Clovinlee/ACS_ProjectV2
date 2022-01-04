namespace Project_ACS.Manager
{
    partial class Inventory_Barang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory_Barang));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.pl = new System.Windows.Forms.Panel();
            this.cbb_rak = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_barang = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.labeljumlah = new System.Windows.Forms.Label();
            this.btn_refresh = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.textbox_searchkode = new System.Windows.Forms.TextBox();
            this.cbb_merk = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_kategori = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNamaWarehouse = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_barang)).BeginInit();
            this.SuspendLayout();
            // 
            // pl
            // 
            this.pl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(106)))));
            this.pl.Controls.Add(this.cbb_rak);
            this.pl.Controls.Add(this.label5);
            this.pl.Controls.Add(this.dgv_barang);
            this.pl.Controls.Add(this.labeljumlah);
            this.pl.Controls.Add(this.btn_refresh);
            this.pl.Controls.Add(this.textbox_searchkode);
            this.pl.Controls.Add(this.cbb_merk);
            this.pl.Controls.Add(this.label4);
            this.pl.Controls.Add(this.cbb_kategori);
            this.pl.Controls.Add(this.label3);
            this.pl.Controls.Add(this.label2);
            this.pl.Controls.Add(this.labelNamaWarehouse);
            this.pl.Controls.Add(this.label1);
            this.pl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl.Location = new System.Drawing.Point(0, 0);
            this.pl.Name = "pl";
            this.pl.Size = new System.Drawing.Size(861, 571);
            this.pl.TabIndex = 0;
            // 
            // cbb_rak
            // 
            this.cbb_rak.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbb_rak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_rak.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_rak.FormattingEnabled = true;
            this.cbb_rak.Location = new System.Drawing.Point(168, 116);
            this.cbb_rak.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_rak.Name = "cbb_rak";
            this.cbb_rak.Size = new System.Drawing.Size(126, 20);
            this.cbb_rak.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(220)))), ((int)(((byte)(228)))));
            this.label5.Location = new System.Drawing.Point(165, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 38;
            this.label5.Text = "Rak";
            // 
            // dgv_barang
            // 
            this.dgv_barang.AllowCustomTheming = false;
            this.dgv_barang.AllowUserToAddRows = false;
            this.dgv_barang.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv_barang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_barang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_barang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_barang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_barang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_barang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_barang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_barang.ColumnHeadersHeight = 40;
            this.dgv_barang.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgv_barang.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_barang.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_barang.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_barang.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_barang.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgv_barang.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_barang.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_barang.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgv_barang.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_barang.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgv_barang.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_barang.CurrentTheme.Name = null;
            this.dgv_barang.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_barang.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_barang.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_barang.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_barang.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_barang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_barang.EnableHeadersVisualStyles = false;
            this.dgv_barang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_barang.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_barang.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgv_barang.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_barang.Location = new System.Drawing.Point(17, 153);
            this.dgv_barang.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_barang.MultiSelect = false;
            this.dgv_barang.Name = "dgv_barang";
            this.dgv_barang.ReadOnly = true;
            this.dgv_barang.RowHeadersVisible = false;
            this.dgv_barang.RowHeadersWidth = 51;
            this.dgv_barang.RowTemplate.Height = 40;
            this.dgv_barang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_barang.Size = new System.Drawing.Size(821, 330);
            this.dgv_barang.TabIndex = 37;
            this.dgv_barang.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // labeljumlah
            // 
            this.labeljumlah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labeljumlah.AutoSize = true;
            this.labeljumlah.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeljumlah.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(220)))), ((int)(((byte)(228)))));
            this.labeljumlah.Location = new System.Drawing.Point(694, 497);
            this.labeljumlah.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeljumlah.Name = "labeljumlah";
            this.labeljumlah.Size = new System.Drawing.Size(144, 15);
            this.labeljumlah.TabIndex = 36;
            this.labeljumlah.Text = "Showing n data Barang";
            // 
            // btn_refresh
            // 
            this.btn_refresh.AllowAnimations = true;
            this.btn_refresh.AllowMouseEffects = true;
            this.btn_refresh.AllowToggling = false;
            this.btn_refresh.AnimationSpeed = 200;
            this.btn_refresh.AutoGenerateColors = false;
            this.btn_refresh.AutoRoundBorders = false;
            this.btn_refresh.AutoSizeLeftIcon = true;
            this.btn_refresh.AutoSizeRightIcon = true;
            this.btn_refresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_refresh.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(139)))));
            this.btn_refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_refresh.BackgroundImage")));
            this.btn_refresh.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_refresh.ButtonText = "";
            this.btn_refresh.ButtonTextMarginLeft = 0;
            this.btn_refresh.ColorContrastOnClick = 45;
            this.btn_refresh.ColorContrastOnHover = 45;
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_refresh.CustomizableEdges = borderEdges1;
            this.btn_refresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_refresh.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_refresh.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_refresh.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_refresh.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_refresh.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_refresh.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_refresh.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_refresh.IconMarginLeft = 11;
            this.btn_refresh.IconPadding = 10;
            this.btn_refresh.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_refresh.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_refresh.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_refresh.IconSize = 25;
            this.btn_refresh.IdleBorderColor = System.Drawing.Color.White;
            this.btn_refresh.IdleBorderRadius = 15;
            this.btn_refresh.IdleBorderThickness = 1;
            this.btn_refresh.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(139)))));
            this.btn_refresh.IdleIconLeftImage = global::Project_ACS.res_icons.history_solid;
            this.btn_refresh.IdleIconRightImage = null;
            this.btn_refresh.IndicateFocus = false;
            this.btn_refresh.Location = new System.Drawing.Point(797, 101);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_refresh.OnDisabledState.BorderRadius = 15;
            this.btn_refresh.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_refresh.OnDisabledState.BorderThickness = 1;
            this.btn_refresh.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_refresh.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_refresh.OnDisabledState.IconLeftImage = null;
            this.btn_refresh.OnDisabledState.IconRightImage = null;
            this.btn_refresh.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btn_refresh.onHoverState.BorderRadius = 15;
            this.btn_refresh.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_refresh.onHoverState.BorderThickness = 1;
            this.btn_refresh.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_refresh.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.onHoverState.IconLeftImage = null;
            this.btn_refresh.onHoverState.IconRightImage = null;
            this.btn_refresh.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btn_refresh.OnIdleState.BorderRadius = 15;
            this.btn_refresh.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_refresh.OnIdleState.BorderThickness = 1;
            this.btn_refresh.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(139)))));
            this.btn_refresh.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_refresh.OnIdleState.IconLeftImage = global::Project_ACS.res_icons.history_solid;
            this.btn_refresh.OnIdleState.IconRightImage = null;
            this.btn_refresh.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.btn_refresh.OnPressedState.BorderRadius = 15;
            this.btn_refresh.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_refresh.OnPressedState.BorderThickness = 1;
            this.btn_refresh.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(115)))));
            this.btn_refresh.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.OnPressedState.IconLeftImage = null;
            this.btn_refresh.OnPressedState.IconRightImage = null;
            this.btn_refresh.Size = new System.Drawing.Size(41, 36);
            this.btn_refresh.TabIndex = 35;
            this.btn_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_refresh.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_refresh.TextMarginLeft = 0;
            this.btn_refresh.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_refresh.UseDefaultRadiusAndThickness = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // textbox_searchkode
            // 
            this.textbox_searchkode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textbox_searchkode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textbox_searchkode.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_searchkode.Location = new System.Drawing.Point(20, 116);
            this.textbox_searchkode.Margin = new System.Windows.Forms.Padding(2);
            this.textbox_searchkode.Name = "textbox_searchkode";
            this.textbox_searchkode.Size = new System.Drawing.Size(138, 21);
            this.textbox_searchkode.TabIndex = 34;
            // 
            // cbb_merk
            // 
            this.cbb_merk.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbb_merk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_merk.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_merk.FormattingEnabled = true;
            this.cbb_merk.Location = new System.Drawing.Point(456, 116);
            this.cbb_merk.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_merk.Name = "cbb_merk";
            this.cbb_merk.Size = new System.Drawing.Size(126, 20);
            this.cbb_merk.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(220)))), ((int)(((byte)(228)))));
            this.label4.Location = new System.Drawing.Point(453, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Merk";
            // 
            // cbb_kategori
            // 
            this.cbb_kategori.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbb_kategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_kategori.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_kategori.FormattingEnabled = true;
            this.cbb_kategori.Location = new System.Drawing.Point(306, 116);
            this.cbb_kategori.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_kategori.Name = "cbb_kategori";
            this.cbb_kategori.Size = new System.Drawing.Size(135, 20);
            this.cbb_kategori.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(220)))), ((int)(((byte)(228)))));
            this.label3.Location = new System.Drawing.Point(303, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Kategori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(220)))), ((int)(((byte)(228)))));
            this.label2.Location = new System.Drawing.Point(16, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Search by Kode, Nama";
            // 
            // labelNamaWarehouse
            // 
            this.labelNamaWarehouse.AutoSize = true;
            this.labelNamaWarehouse.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaWarehouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(220)))), ((int)(((byte)(228)))));
            this.labelNamaWarehouse.Location = new System.Drawing.Point(13, 46);
            this.labelNamaWarehouse.Name = "labelNamaWarehouse";
            this.labelNamaWarehouse.Size = new System.Drawing.Size(156, 21);
            this.labelNamaWarehouse.TabIndex = 18;
            this.labelNamaWarehouse.Text = "<Nama Warehouse>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(220)))), ((int)(((byte)(228)))));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "Inventory Barang";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.dgv_barang;
            // 
            // Inventory_Barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 571);
            this.Controls.Add(this.pl);
            this.Name = "Inventory_Barang";
            this.Text = "Inventory_Barang";
            this.Load += new System.EventHandler(this.Inventory_Barang_Load);
            this.pl.ResumeLayout(false);
            this.pl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_barang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNamaWarehouse;
        private Bunifu.UI.WinForms.BunifuDataGridView dgv_barang;
        private System.Windows.Forms.Label labeljumlah;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_refresh;
        private System.Windows.Forms.TextBox textbox_searchkode;
        private System.Windows.Forms.ComboBox cbb_merk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_kategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ComboBox cbb_rak;
        private System.Windows.Forms.Label label5;
    }
}