namespace Project_ACS.Master
{
    partial class Master_BusinessPartner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Master_BusinessPartner));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.pl = new System.Windows.Forms.Panel();
            this.dgv_bp = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_jml = new System.Windows.Forms.Label();
            this.btn_refresh = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_update = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_insert = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.tb_kode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tb_nama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bp)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl
            // 
            this.pl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(106)))));
            this.pl.Controls.Add(this.panel1);
            this.pl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl.Location = new System.Drawing.Point(0, 0);
            this.pl.Name = "pl";
            this.pl.Size = new System.Drawing.Size(866, 511);
            this.pl.TabIndex = 0;
            // 
            // dgv_bp
            // 
            this.dgv_bp.AllowCustomTheming = false;
            this.dgv_bp.AllowUserToAddRows = false;
            this.dgv_bp.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv_bp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_bp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_bp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_bp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_bp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_bp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_bp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_bp.ColumnHeadersHeight = 40;
            this.dgv_bp.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgv_bp.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_bp.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_bp.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_bp.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_bp.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgv_bp.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_bp.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_bp.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgv_bp.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_bp.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgv_bp.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_bp.CurrentTheme.Name = null;
            this.dgv_bp.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_bp.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_bp.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_bp.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_bp.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_bp.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_bp.EnableHeadersVisualStyles = false;
            this.dgv_bp.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_bp.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_bp.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgv_bp.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_bp.Location = new System.Drawing.Point(17, 105);
            this.dgv_bp.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_bp.MultiSelect = false;
            this.dgv_bp.Name = "dgv_bp";
            this.dgv_bp.ReadOnly = true;
            this.dgv_bp.RowHeadersVisible = false;
            this.dgv_bp.RowHeadersWidth = 51;
            this.dgv_bp.RowTemplate.Height = 40;
            this.dgv_bp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_bp.Size = new System.Drawing.Size(807, 367);
            this.dgv_bp.TabIndex = 28;
            this.dgv_bp.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(106)))));
            this.panel1.Controls.Add(this.tb_nama);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dgv_bp);
            this.panel1.Controls.Add(this.lbl_jml);
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_insert);
            this.panel1.Controls.Add(this.tb_kode);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 511);
            this.panel1.TabIndex = 1;
            // 
            // lbl_jml
            // 
            this.lbl_jml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_jml.AutoSize = true;
            this.lbl_jml.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jml.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(220)))), ((int)(((byte)(228)))));
            this.lbl_jml.Location = new System.Drawing.Point(624, 487);
            this.lbl_jml.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_jml.Name = "lbl_jml";
            this.lbl_jml.Size = new System.Drawing.Size(200, 15);
            this.lbl_jml.TabIndex = 27;
            this.lbl_jml.Text = "Showing n data Business Partner";
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
            this.btn_refresh.Location = new System.Drawing.Point(107, 55);
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
            this.btn_refresh.Size = new System.Drawing.Size(40, 36);
            this.btn_refresh.TabIndex = 26;
            this.btn_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_refresh.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_refresh.TextMarginLeft = 0;
            this.btn_refresh.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_refresh.UseDefaultRadiusAndThickness = true;
            // 
            // btn_update
            // 
            this.btn_update.AllowAnimations = true;
            this.btn_update.AllowMouseEffects = true;
            this.btn_update.AllowToggling = false;
            this.btn_update.AnimationSpeed = 200;
            this.btn_update.AutoGenerateColors = false;
            this.btn_update.AutoRoundBorders = false;
            this.btn_update.AutoSizeLeftIcon = true;
            this.btn_update.AutoSizeRightIcon = true;
            this.btn_update.BackColor = System.Drawing.Color.Transparent;
            this.btn_update.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(139)))));
            this.btn_update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_update.BackgroundImage")));
            this.btn_update.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_update.ButtonText = "";
            this.btn_update.ButtonTextMarginLeft = 0;
            this.btn_update.ColorContrastOnClick = 45;
            this.btn_update.ColorContrastOnHover = 45;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_update.CustomizableEdges = borderEdges2;
            this.btn_update.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_update.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_update.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_update.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_update.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_update.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_update.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_update.IconMarginLeft = 11;
            this.btn_update.IconPadding = 10;
            this.btn_update.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_update.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_update.IconSize = 25;
            this.btn_update.IdleBorderColor = System.Drawing.Color.White;
            this.btn_update.IdleBorderRadius = 15;
            this.btn_update.IdleBorderThickness = 1;
            this.btn_update.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(139)))));
            this.btn_update.IdleIconLeftImage = global::Project_ACS.res_icons.pencil;
            this.btn_update.IdleIconRightImage = null;
            this.btn_update.IndicateFocus = false;
            this.btn_update.Location = new System.Drawing.Point(61, 55);
            this.btn_update.Name = "btn_update";
            this.btn_update.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_update.OnDisabledState.BorderRadius = 15;
            this.btn_update.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_update.OnDisabledState.BorderThickness = 1;
            this.btn_update.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_update.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_update.OnDisabledState.IconLeftImage = null;
            this.btn_update.OnDisabledState.IconRightImage = null;
            this.btn_update.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btn_update.onHoverState.BorderRadius = 15;
            this.btn_update.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_update.onHoverState.BorderThickness = 1;
            this.btn_update.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_update.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_update.onHoverState.IconLeftImage = null;
            this.btn_update.onHoverState.IconRightImage = null;
            this.btn_update.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btn_update.OnIdleState.BorderRadius = 15;
            this.btn_update.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_update.OnIdleState.BorderThickness = 1;
            this.btn_update.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(139)))));
            this.btn_update.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_update.OnIdleState.IconLeftImage = global::Project_ACS.res_icons.pencil;
            this.btn_update.OnIdleState.IconRightImage = null;
            this.btn_update.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.btn_update.OnPressedState.BorderRadius = 15;
            this.btn_update.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_update.OnPressedState.BorderThickness = 1;
            this.btn_update.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(115)))));
            this.btn_update.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_update.OnPressedState.IconLeftImage = null;
            this.btn_update.OnPressedState.IconRightImage = null;
            this.btn_update.Size = new System.Drawing.Size(40, 36);
            this.btn_update.TabIndex = 24;
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_update.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_update.TextMarginLeft = 0;
            this.btn_update.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_update.UseDefaultRadiusAndThickness = true;
            // 
            // btn_insert
            // 
            this.btn_insert.AllowAnimations = true;
            this.btn_insert.AllowMouseEffects = true;
            this.btn_insert.AllowToggling = false;
            this.btn_insert.AnimationSpeed = 200;
            this.btn_insert.AutoGenerateColors = false;
            this.btn_insert.AutoRoundBorders = false;
            this.btn_insert.AutoSizeLeftIcon = true;
            this.btn_insert.AutoSizeRightIcon = true;
            this.btn_insert.BackColor = System.Drawing.Color.Transparent;
            this.btn_insert.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(139)))));
            this.btn_insert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_insert.BackgroundImage")));
            this.btn_insert.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_insert.ButtonText = "";
            this.btn_insert.ButtonTextMarginLeft = 0;
            this.btn_insert.ColorContrastOnClick = 45;
            this.btn_insert.ColorContrastOnHover = 45;
            this.btn_insert.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btn_insert.CustomizableEdges = borderEdges3;
            this.btn_insert.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_insert.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_insert.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_insert.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_insert.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btn_insert.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_insert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_insert.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_insert.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_insert.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_insert.IconMarginLeft = 11;
            this.btn_insert.IconPadding = 10;
            this.btn_insert.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_insert.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_insert.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_insert.IconSize = 25;
            this.btn_insert.IdleBorderColor = System.Drawing.Color.White;
            this.btn_insert.IdleBorderRadius = 15;
            this.btn_insert.IdleBorderThickness = 1;
            this.btn_insert.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(139)))));
            this.btn_insert.IdleIconLeftImage = global::Project_ACS.res_icons.plus;
            this.btn_insert.IdleIconRightImage = null;
            this.btn_insert.IndicateFocus = false;
            this.btn_insert.Location = new System.Drawing.Point(17, 55);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_insert.OnDisabledState.BorderRadius = 15;
            this.btn_insert.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_insert.OnDisabledState.BorderThickness = 1;
            this.btn_insert.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_insert.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_insert.OnDisabledState.IconLeftImage = null;
            this.btn_insert.OnDisabledState.IconRightImage = null;
            this.btn_insert.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btn_insert.onHoverState.BorderRadius = 15;
            this.btn_insert.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_insert.onHoverState.BorderThickness = 1;
            this.btn_insert.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(115)))));
            this.btn_insert.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_insert.onHoverState.IconLeftImage = null;
            this.btn_insert.onHoverState.IconRightImage = null;
            this.btn_insert.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btn_insert.OnIdleState.BorderRadius = 15;
            this.btn_insert.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_insert.OnIdleState.BorderThickness = 1;
            this.btn_insert.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(139)))));
            this.btn_insert.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_insert.OnIdleState.IconLeftImage = global::Project_ACS.res_icons.plus;
            this.btn_insert.OnIdleState.IconRightImage = null;
            this.btn_insert.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.btn_insert.OnPressedState.BorderRadius = 15;
            this.btn_insert.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_insert.OnPressedState.BorderThickness = 1;
            this.btn_insert.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(115)))));
            this.btn_insert.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_insert.OnPressedState.IconLeftImage = null;
            this.btn_insert.OnPressedState.IconRightImage = null;
            this.btn_insert.Size = new System.Drawing.Size(40, 36);
            this.btn_insert.TabIndex = 23;
            this.btn_insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_insert.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_insert.TextMarginLeft = 0;
            this.btn_insert.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_insert.UseDefaultRadiusAndThickness = true;
            // 
            // tb_kode
            // 
            this.tb_kode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_kode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_kode.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_kode.Location = new System.Drawing.Point(228, 70);
            this.tb_kode.Margin = new System.Windows.Forms.Padding(2);
            this.tb_kode.Name = "tb_kode";
            this.tb_kode.Size = new System.Drawing.Size(138, 21);
            this.tb_kode.TabIndex = 22;
            this.tb_kode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_nama_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(220)))), ((int)(((byte)(228)))));
            this.label2.Location = new System.Drawing.Point(224, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Search by Kode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(220)))), ((int)(((byte)(228)))));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Business Partner";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.dgv_bp;
            // 
            // tb_nama
            // 
            this.tb_nama.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_nama.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_nama.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nama.Location = new System.Drawing.Point(384, 70);
            this.tb_nama.Margin = new System.Windows.Forms.Padding(2);
            this.tb_nama.Name = "tb_nama";
            this.tb_nama.Size = new System.Drawing.Size(138, 21);
            this.tb_nama.TabIndex = 30;
            this.tb_nama.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_nama_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(220)))), ((int)(((byte)(228)))));
            this.label3.Location = new System.Drawing.Point(380, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Search by Nama";
            // 
            // Master_BusinessPartner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 511);
            this.Controls.Add(this.pl);
            this.Name = "Master_BusinessPartner";
            this.Text = "Master_BusinessPartner";
            this.Load += new System.EventHandler(this.Master_BusinessPartner_Load);
            this.pl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuDataGridView dgv_bp;
        private System.Windows.Forms.Label lbl_jml;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_refresh;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_update;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_insert;
        private System.Windows.Forms.TextBox tb_kode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TextBox tb_nama;
        private System.Windows.Forms.Label label3;
    }
}