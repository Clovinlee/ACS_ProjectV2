namespace Project_ACS.Manager
{
    partial class Inventory_Tracking
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory_Tracking));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.pl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_barang = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.labeljumlah = new System.Windows.Forms.Label();
            this.btn_refresh = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.labelNamaWarehouse = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.textbox_searchkode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTrack = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_barang)).BeginInit();
            this.SuspendLayout();
            // 
            // pl
            // 
            this.pl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(106)))));
            this.pl.Controls.Add(this.panel1);
            this.pl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl.Location = new System.Drawing.Point(0, 0);
            this.pl.Name = "pl";
            this.pl.Size = new System.Drawing.Size(848, 571);
            this.pl.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(106)))));
            this.panel1.Controls.Add(this.btnTrack);
            this.panel1.Controls.Add(this.textbox_searchkode);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgv_barang);
            this.panel1.Controls.Add(this.labeljumlah);
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.labelNamaWarehouse);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 571);
            this.panel1.TabIndex = 1;
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
            this.dgv_barang.Size = new System.Drawing.Size(808, 330);
            this.dgv_barang.TabIndex = 37;
            this.dgv_barang.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgv_barang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_barang_CellClick);
            // 
            // labeljumlah
            // 
            this.labeljumlah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labeljumlah.AutoSize = true;
            this.labeljumlah.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeljumlah.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(220)))), ((int)(((byte)(228)))));
            this.labeljumlah.Location = new System.Drawing.Point(665, 499);
            this.labeljumlah.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeljumlah.Name = "labeljumlah";
            this.labeljumlah.Size = new System.Drawing.Size(149, 15);
            this.labeljumlah.TabIndex = 36;
            this.labeljumlah.Text = "Showing n data Tracking";
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_refresh.CustomizableEdges = borderEdges2;
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
            this.btn_refresh.Location = new System.Drawing.Point(634, 101);
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
            this.label1.Size = new System.Drawing.Size(231, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "Inventory Tracking";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.dgv_barang;
            // 
            // textbox_searchkode
            // 
            this.textbox_searchkode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textbox_searchkode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textbox_searchkode.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_searchkode.Location = new System.Drawing.Point(17, 116);
            this.textbox_searchkode.Margin = new System.Windows.Forms.Padding(2);
            this.textbox_searchkode.Name = "textbox_searchkode";
            this.textbox_searchkode.Size = new System.Drawing.Size(138, 21);
            this.textbox_searchkode.TabIndex = 39;
            this.textbox_searchkode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textbox_searchkode_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(220)))), ((int)(((byte)(228)))));
            this.label2.Location = new System.Drawing.Point(13, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "Search by Kode, Nama";
            // 
            // btnTrack
            // 
            this.btnTrack.AllowAnimations = true;
            this.btnTrack.AllowMouseEffects = true;
            this.btnTrack.AllowToggling = false;
            this.btnTrack.AnimationSpeed = 200;
            this.btnTrack.AutoGenerateColors = false;
            this.btnTrack.AutoRoundBorders = false;
            this.btnTrack.AutoSizeLeftIcon = true;
            this.btnTrack.AutoSizeRightIcon = true;
            this.btnTrack.BackColor = System.Drawing.Color.Transparent;
            this.btnTrack.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(139)))));
            this.btnTrack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrack.BackgroundImage")));
            this.btnTrack.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTrack.ButtonText = "TRACK ";
            this.btnTrack.ButtonTextMarginLeft = 0;
            this.btnTrack.ColorContrastOnClick = 45;
            this.btnTrack.ColorContrastOnHover = 45;
            this.btnTrack.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnTrack.CustomizableEdges = borderEdges1;
            this.btnTrack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTrack.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTrack.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTrack.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnTrack.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnTrack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTrack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTrack.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrack.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnTrack.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnTrack.IconMarginLeft = 11;
            this.btnTrack.IconPadding = 10;
            this.btnTrack.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrack.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnTrack.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnTrack.IconSize = 25;
            this.btnTrack.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(139)))));
            this.btnTrack.IdleBorderRadius = 15;
            this.btnTrack.IdleBorderThickness = 1;
            this.btnTrack.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(139)))));
            this.btnTrack.IdleIconLeftImage = null;
            this.btnTrack.IdleIconRightImage = null;
            this.btnTrack.IndicateFocus = false;
            this.btnTrack.Location = new System.Drawing.Point(693, 101);
            this.btnTrack.Name = "btnTrack";
            this.btnTrack.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTrack.OnDisabledState.BorderRadius = 15;
            this.btnTrack.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTrack.OnDisabledState.BorderThickness = 1;
            this.btnTrack.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTrack.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnTrack.OnDisabledState.IconLeftImage = null;
            this.btnTrack.OnDisabledState.IconRightImage = null;
            this.btnTrack.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btnTrack.onHoverState.BorderRadius = 15;
            this.btnTrack.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTrack.onHoverState.BorderThickness = 1;
            this.btnTrack.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTrack.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnTrack.onHoverState.IconLeftImage = null;
            this.btnTrack.onHoverState.IconRightImage = null;
            this.btnTrack.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(139)))));
            this.btnTrack.OnIdleState.BorderRadius = 15;
            this.btnTrack.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTrack.OnIdleState.BorderThickness = 1;
            this.btnTrack.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(139)))));
            this.btnTrack.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTrack.OnIdleState.IconLeftImage = null;
            this.btnTrack.OnIdleState.IconRightImage = null;
            this.btnTrack.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.btnTrack.OnPressedState.BorderRadius = 15;
            this.btnTrack.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTrack.OnPressedState.BorderThickness = 1;
            this.btnTrack.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTrack.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnTrack.OnPressedState.IconLeftImage = null;
            this.btnTrack.OnPressedState.IconRightImage = null;
            this.btnTrack.Size = new System.Drawing.Size(132, 36);
            this.btnTrack.TabIndex = 40;
            this.btnTrack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTrack.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTrack.TextMarginLeft = 0;
            this.btnTrack.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnTrack.UseDefaultRadiusAndThickness = true;
            this.btnTrack.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // Inventory_Tracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 571);
            this.Controls.Add(this.pl);
            this.Name = "Inventory_Tracking";
            this.Text = "Inventory_Tracking";
            this.Load += new System.EventHandler(this.Inventory_Tracking_Load);
            this.pl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_barang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuDataGridView dgv_barang;
        private System.Windows.Forms.Label labeljumlah;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_refresh;
        private System.Windows.Forms.Label labelNamaWarehouse;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TextBox textbox_searchkode;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnTrack;
    }
}