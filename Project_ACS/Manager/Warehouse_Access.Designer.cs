namespace Project_ACS.Manager
{
    partial class Warehouse_Access
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warehouse_Access));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.pl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvWarehouse = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.elipseDgvWarehouse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dgvDetail = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAccept = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnDecline = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // pl
            // 
            this.pl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(139)))));
            this.pl.Controls.Add(this.btnDecline);
            this.pl.Controls.Add(this.btnAccept);
            this.pl.Controls.Add(this.label2);
            this.pl.Controls.Add(this.label4);
            this.pl.Controls.Add(this.dgvDetail);
            this.pl.Controls.Add(this.dgvWarehouse);
            this.pl.Controls.Add(this.label1);
            this.pl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl.Location = new System.Drawing.Point(0, 0);
            this.pl.Name = "pl";
            this.pl.Size = new System.Drawing.Size(869, 461);
            this.pl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Akses Warehouse";
            // 
            // dgvWarehouse
            // 
            this.dgvWarehouse.AllowCustomTheming = false;
            this.dgvWarehouse.AllowUserToAddRows = false;
            this.dgvWarehouse.AllowUserToDeleteRows = false;
            this.dgvWarehouse.AllowUserToResizeColumns = false;
            this.dgvWarehouse.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvWarehouse.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvWarehouse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWarehouse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvWarehouse.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvWarehouse.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWarehouse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvWarehouse.ColumnHeadersHeight = 40;
            this.dgvWarehouse.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvWarehouse.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvWarehouse.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvWarehouse.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvWarehouse.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvWarehouse.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvWarehouse.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvWarehouse.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvWarehouse.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvWarehouse.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvWarehouse.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvWarehouse.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvWarehouse.CurrentTheme.Name = null;
            this.dgvWarehouse.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvWarehouse.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvWarehouse.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvWarehouse.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvWarehouse.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWarehouse.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvWarehouse.EnableHeadersVisualStyles = false;
            this.dgvWarehouse.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvWarehouse.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvWarehouse.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvWarehouse.HeaderForeColor = System.Drawing.Color.White;
            this.dgvWarehouse.Location = new System.Drawing.Point(16, 121);
            this.dgvWarehouse.Margin = new System.Windows.Forms.Padding(2);
            this.dgvWarehouse.MultiSelect = false;
            this.dgvWarehouse.Name = "dgvWarehouse";
            this.dgvWarehouse.ReadOnly = true;
            this.dgvWarehouse.RowHeadersVisible = false;
            this.dgvWarehouse.RowHeadersWidth = 51;
            this.dgvWarehouse.RowTemplate.DividerHeight = 3;
            this.dgvWarehouse.RowTemplate.Height = 40;
            this.dgvWarehouse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWarehouse.Size = new System.Drawing.Size(452, 317);
            this.dgvWarehouse.TabIndex = 19;
            this.dgvWarehouse.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvWarehouse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWarehouse_CellClick);
            // 
            // elipseDgvWarehouse
            // 
            this.elipseDgvWarehouse.ElipseRadius = 10;
            this.elipseDgvWarehouse.TargetControl = this.dgvWarehouse;
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowCustomTheming = false;
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            this.dgvDetail.AllowUserToResizeColumns = false;
            this.dgvDetail.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetail.ColumnHeadersHeight = 40;
            this.dgvDetail.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvDetail.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDetail.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDetail.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvDetail.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDetail.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvDetail.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvDetail.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvDetail.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvDetail.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDetail.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvDetail.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDetail.CurrentTheme.Name = null;
            this.dgvDetail.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDetail.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDetail.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDetail.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvDetail.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetail.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetail.EnableHeadersVisualStyles = false;
            this.dgvDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvDetail.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvDetail.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvDetail.HeaderForeColor = System.Drawing.Color.White;
            this.dgvDetail.Location = new System.Drawing.Point(492, 121);
            this.dgvDetail.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDetail.MultiSelect = false;
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.RowHeadersVisible = false;
            this.dgvDetail.RowHeadersWidth = 51;
            this.dgvDetail.RowTemplate.DividerHeight = 3;
            this.dgvDetail.RowTemplate.Height = 40;
            this.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetail.Size = new System.Drawing.Size(366, 317);
            this.dgvDetail.TabIndex = 20;
            this.dgvDetail.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.dgvDetail;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Daftar Request Pindah";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(488, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Detail Request";
            // 
            // btnAccept
            // 
            this.btnAccept.AllowAnimations = true;
            this.btnAccept.AllowMouseEffects = true;
            this.btnAccept.AllowToggling = false;
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.AnimationSpeed = 200;
            this.btnAccept.AutoGenerateColors = false;
            this.btnAccept.AutoRoundBorders = false;
            this.btnAccept.AutoSizeLeftIcon = true;
            this.btnAccept.AutoSizeRightIcon = true;
            this.btnAccept.BackColor = System.Drawing.Color.Transparent;
            this.btnAccept.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(139)))));
            this.btnAccept.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAccept.BackgroundImage")));
            this.btnAccept.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAccept.ButtonText = "Accept";
            this.btnAccept.ButtonTextMarginLeft = 0;
            this.btnAccept.ColorContrastOnClick = 45;
            this.btnAccept.ColorContrastOnHover = 45;
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnAccept.CustomizableEdges = borderEdges2;
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAccept.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAccept.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAccept.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAccept.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnAccept.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAccept.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccept.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAccept.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAccept.IconMarginLeft = 11;
            this.btnAccept.IconPadding = 10;
            this.btnAccept.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccept.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAccept.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAccept.IconSize = 25;
            this.btnAccept.IdleBorderColor = System.Drawing.Color.White;
            this.btnAccept.IdleBorderRadius = 15;
            this.btnAccept.IdleBorderThickness = 1;
            this.btnAccept.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(139)))));
            this.btnAccept.IdleIconLeftImage = global::Project_ACS.res_icons.plus;
            this.btnAccept.IdleIconRightImage = null;
            this.btnAccept.IndicateFocus = false;
            this.btnAccept.Location = new System.Drawing.Point(492, 40);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAccept.OnDisabledState.BorderRadius = 15;
            this.btnAccept.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAccept.OnDisabledState.BorderThickness = 1;
            this.btnAccept.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAccept.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAccept.OnDisabledState.IconLeftImage = null;
            this.btnAccept.OnDisabledState.IconRightImage = null;
            this.btnAccept.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btnAccept.onHoverState.BorderRadius = 15;
            this.btnAccept.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAccept.onHoverState.BorderThickness = 1;
            this.btnAccept.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(115)))));
            this.btnAccept.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAccept.onHoverState.IconLeftImage = null;
            this.btnAccept.onHoverState.IconRightImage = null;
            this.btnAccept.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btnAccept.OnIdleState.BorderRadius = 15;
            this.btnAccept.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAccept.OnIdleState.BorderThickness = 1;
            this.btnAccept.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(139)))));
            this.btnAccept.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAccept.OnIdleState.IconLeftImage = global::Project_ACS.res_icons.plus;
            this.btnAccept.OnIdleState.IconRightImage = null;
            this.btnAccept.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.btnAccept.OnPressedState.BorderRadius = 15;
            this.btnAccept.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAccept.OnPressedState.BorderThickness = 1;
            this.btnAccept.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(115)))));
            this.btnAccept.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAccept.OnPressedState.IconLeftImage = null;
            this.btnAccept.OnPressedState.IconRightImage = null;
            this.btnAccept.Size = new System.Drawing.Size(168, 41);
            this.btnAccept.TabIndex = 29;
            this.btnAccept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAccept.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAccept.TextMarginLeft = 0;
            this.btnAccept.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAccept.UseDefaultRadiusAndThickness = true;
            this.btnAccept.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDecline
            // 
            this.btnDecline.AllowAnimations = true;
            this.btnDecline.AllowMouseEffects = true;
            this.btnDecline.AllowToggling = false;
            this.btnDecline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecline.AnimationSpeed = 200;
            this.btnDecline.AutoGenerateColors = false;
            this.btnDecline.AutoRoundBorders = false;
            this.btnDecline.AutoSizeLeftIcon = true;
            this.btnDecline.AutoSizeRightIcon = true;
            this.btnDecline.BackColor = System.Drawing.Color.Transparent;
            this.btnDecline.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(139)))));
            this.btnDecline.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDecline.BackgroundImage")));
            this.btnDecline.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDecline.ButtonText = "Decline";
            this.btnDecline.ButtonTextMarginLeft = 0;
            this.btnDecline.ColorContrastOnClick = 45;
            this.btnDecline.ColorContrastOnHover = 45;
            this.btnDecline.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnDecline.CustomizableEdges = borderEdges1;
            this.btnDecline.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDecline.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDecline.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDecline.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDecline.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnDecline.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDecline.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDecline.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDecline.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDecline.IconMarginLeft = 11;
            this.btnDecline.IconPadding = 10;
            this.btnDecline.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDecline.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDecline.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDecline.IconSize = 25;
            this.btnDecline.IdleBorderColor = System.Drawing.Color.White;
            this.btnDecline.IdleBorderRadius = 15;
            this.btnDecline.IdleBorderThickness = 1;
            this.btnDecline.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(139)))));
            this.btnDecline.IdleIconLeftImage = global::Project_ACS.res_icons.plus;
            this.btnDecline.IdleIconRightImage = null;
            this.btnDecline.IndicateFocus = false;
            this.btnDecline.Location = new System.Drawing.Point(689, 40);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDecline.OnDisabledState.BorderRadius = 15;
            this.btnDecline.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDecline.OnDisabledState.BorderThickness = 1;
            this.btnDecline.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDecline.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDecline.OnDisabledState.IconLeftImage = null;
            this.btnDecline.OnDisabledState.IconRightImage = null;
            this.btnDecline.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btnDecline.onHoverState.BorderRadius = 15;
            this.btnDecline.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDecline.onHoverState.BorderThickness = 1;
            this.btnDecline.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnDecline.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDecline.onHoverState.IconLeftImage = null;
            this.btnDecline.onHoverState.IconRightImage = null;
            this.btnDecline.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btnDecline.OnIdleState.BorderRadius = 15;
            this.btnDecline.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDecline.OnIdleState.BorderThickness = 1;
            this.btnDecline.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(139)))));
            this.btnDecline.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDecline.OnIdleState.IconLeftImage = global::Project_ACS.res_icons.plus;
            this.btnDecline.OnIdleState.IconRightImage = null;
            this.btnDecline.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.btnDecline.OnPressedState.BorderRadius = 15;
            this.btnDecline.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDecline.OnPressedState.BorderThickness = 1;
            this.btnDecline.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnDecline.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDecline.OnPressedState.IconLeftImage = null;
            this.btnDecline.OnPressedState.IconRightImage = null;
            this.btnDecline.Size = new System.Drawing.Size(168, 41);
            this.btnDecline.TabIndex = 30;
            this.btnDecline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDecline.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDecline.TextMarginLeft = 0;
            this.btnDecline.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDecline.UseDefaultRadiusAndThickness = true;
            this.btnDecline.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // Warehouse_Access
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 461);
            this.Controls.Add(this.pl);
            this.Name = "Warehouse_Access";
            this.Text = "Warehouse_Access";
            this.pl.ResumeLayout(false);
            this.pl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvWarehouse;
        private Bunifu.Framework.UI.BunifuElipse elipseDgvWarehouse;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvDetail;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAccept;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDecline;
    }
}