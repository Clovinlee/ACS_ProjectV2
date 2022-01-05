namespace Project_ACS.Manager
{
    partial class Detail_Stock_Adjustment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detail_Stock_Adjustment));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_kode = new System.Windows.Forms.TextBox();
            this.btn_check = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_reset = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.gb_adjust = new System.Windows.Forms.GroupBox();
            this.btn_confirm = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_keterangan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.num_newqty = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.num_oldqty = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.gb_adjust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_newqty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_oldqty)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(220)))), ((int)(((byte)(228)))));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Create Stock Adjustment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(220)))), ((int)(((byte)(228)))));
            this.label3.Location = new System.Drawing.Point(13, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Search by Kode";
            // 
            // tb_kode
            // 
            this.tb_kode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_kode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_kode.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_kode.Location = new System.Drawing.Point(17, 77);
            this.tb_kode.Margin = new System.Windows.Forms.Padding(2);
            this.tb_kode.Name = "tb_kode";
            this.tb_kode.Size = new System.Drawing.Size(138, 21);
            this.tb_kode.TabIndex = 27;
            // 
            // btn_check
            // 
            this.btn_check.AllowAnimations = true;
            this.btn_check.AllowMouseEffects = true;
            this.btn_check.AllowToggling = false;
            this.btn_check.AnimationSpeed = 200;
            this.btn_check.AutoGenerateColors = false;
            this.btn_check.AutoRoundBorders = false;
            this.btn_check.AutoSizeLeftIcon = true;
            this.btn_check.AutoSizeRightIcon = true;
            this.btn_check.BackColor = System.Drawing.Color.Transparent;
            this.btn_check.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(139)))));
            this.btn_check.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_check.BackgroundImage")));
            this.btn_check.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_check.ButtonText = "Check";
            this.btn_check.ButtonTextMarginLeft = 0;
            this.btn_check.ColorContrastOnClick = 45;
            this.btn_check.ColorContrastOnHover = 45;
            this.btn_check.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btn_check.CustomizableEdges = borderEdges4;
            this.btn_check.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_check.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_check.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_check.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_check.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btn_check.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_check.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_check.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_check.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_check.IconMarginLeft = 11;
            this.btn_check.IconPadding = 10;
            this.btn_check.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_check.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_check.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_check.IconSize = 25;
            this.btn_check.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(139)))));
            this.btn_check.IdleBorderRadius = 15;
            this.btn_check.IdleBorderThickness = 1;
            this.btn_check.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(139)))));
            this.btn_check.IdleIconLeftImage = null;
            this.btn_check.IdleIconRightImage = null;
            this.btn_check.IndicateFocus = false;
            this.btn_check.Location = new System.Drawing.Point(16, 105);
            this.btn_check.Name = "btn_check";
            this.btn_check.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_check.OnDisabledState.BorderRadius = 15;
            this.btn_check.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_check.OnDisabledState.BorderThickness = 1;
            this.btn_check.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_check.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_check.OnDisabledState.IconLeftImage = null;
            this.btn_check.OnDisabledState.IconRightImage = null;
            this.btn_check.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(154)))));
            this.btn_check.onHoverState.BorderRadius = 15;
            this.btn_check.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_check.onHoverState.BorderThickness = 1;
            this.btn_check.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(154)))));
            this.btn_check.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_check.onHoverState.IconLeftImage = null;
            this.btn_check.onHoverState.IconRightImage = null;
            this.btn_check.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(139)))));
            this.btn_check.OnIdleState.BorderRadius = 15;
            this.btn_check.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_check.OnIdleState.BorderThickness = 1;
            this.btn_check.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(139)))));
            this.btn_check.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_check.OnIdleState.IconLeftImage = null;
            this.btn_check.OnIdleState.IconRightImage = null;
            this.btn_check.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.btn_check.OnPressedState.BorderRadius = 15;
            this.btn_check.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_check.OnPressedState.BorderThickness = 1;
            this.btn_check.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.btn_check.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_check.OnPressedState.IconLeftImage = null;
            this.btn_check.OnPressedState.IconRightImage = null;
            this.btn_check.Size = new System.Drawing.Size(119, 36);
            this.btn_check.TabIndex = 28;
            this.btn_check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_check.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_check.TextMarginLeft = 0;
            this.btn_check.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_check.UseDefaultRadiusAndThickness = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(106)))));
            this.panel1.Controls.Add(this.btn_reset);
            this.panel1.Controls.Add(this.gb_adjust);
            this.panel1.Controls.Add(this.btn_check);
            this.panel1.Controls.Add(this.tb_kode);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 415);
            this.panel1.TabIndex = 2;
            // 
            // btn_reset
            // 
            this.btn_reset.AllowAnimations = true;
            this.btn_reset.AllowMouseEffects = true;
            this.btn_reset.AllowToggling = false;
            this.btn_reset.AnimationSpeed = 200;
            this.btn_reset.AutoGenerateColors = false;
            this.btn_reset.AutoRoundBorders = false;
            this.btn_reset.AutoSizeLeftIcon = true;
            this.btn_reset.AutoSizeRightIcon = true;
            this.btn_reset.BackColor = System.Drawing.Color.Transparent;
            this.btn_reset.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(139)))));
            this.btn_reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_reset.BackgroundImage")));
            this.btn_reset.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_reset.ButtonText = "Reset";
            this.btn_reset.ButtonTextMarginLeft = 0;
            this.btn_reset.ColorContrastOnClick = 45;
            this.btn_reset.ColorContrastOnHover = 45;
            this.btn_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btn_reset.CustomizableEdges = borderEdges5;
            this.btn_reset.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_reset.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_reset.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_reset.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_reset.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btn_reset.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_reset.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_reset.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_reset.IconMarginLeft = 11;
            this.btn_reset.IconPadding = 10;
            this.btn_reset.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_reset.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_reset.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_reset.IconSize = 25;
            this.btn_reset.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(139)))));
            this.btn_reset.IdleBorderRadius = 15;
            this.btn_reset.IdleBorderThickness = 1;
            this.btn_reset.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(139)))));
            this.btn_reset.IdleIconLeftImage = null;
            this.btn_reset.IdleIconRightImage = null;
            this.btn_reset.IndicateFocus = false;
            this.btn_reset.Location = new System.Drawing.Point(153, 105);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_reset.OnDisabledState.BorderRadius = 15;
            this.btn_reset.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_reset.OnDisabledState.BorderThickness = 1;
            this.btn_reset.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_reset.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_reset.OnDisabledState.IconLeftImage = null;
            this.btn_reset.OnDisabledState.IconRightImage = null;
            this.btn_reset.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(154)))));
            this.btn_reset.onHoverState.BorderRadius = 15;
            this.btn_reset.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_reset.onHoverState.BorderThickness = 1;
            this.btn_reset.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(154)))));
            this.btn_reset.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_reset.onHoverState.IconLeftImage = null;
            this.btn_reset.onHoverState.IconRightImage = null;
            this.btn_reset.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(139)))));
            this.btn_reset.OnIdleState.BorderRadius = 15;
            this.btn_reset.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_reset.OnIdleState.BorderThickness = 1;
            this.btn_reset.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(139)))));
            this.btn_reset.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_reset.OnIdleState.IconLeftImage = null;
            this.btn_reset.OnIdleState.IconRightImage = null;
            this.btn_reset.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.btn_reset.OnPressedState.BorderRadius = 15;
            this.btn_reset.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_reset.OnPressedState.BorderThickness = 1;
            this.btn_reset.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.btn_reset.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_reset.OnPressedState.IconLeftImage = null;
            this.btn_reset.OnPressedState.IconRightImage = null;
            this.btn_reset.Size = new System.Drawing.Size(119, 36);
            this.btn_reset.TabIndex = 30;
            this.btn_reset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_reset.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_reset.TextMarginLeft = 0;
            this.btn_reset.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_reset.UseDefaultRadiusAndThickness = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // gb_adjust
            // 
            this.gb_adjust.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_adjust.Controls.Add(this.btn_confirm);
            this.gb_adjust.Controls.Add(this.label5);
            this.gb_adjust.Controls.Add(this.tb_keterangan);
            this.gb_adjust.Controls.Add(this.label4);
            this.gb_adjust.Controls.Add(this.num_newqty);
            this.gb_adjust.Controls.Add(this.label2);
            this.gb_adjust.Controls.Add(this.num_oldqty);
            this.gb_adjust.Enabled = false;
            this.gb_adjust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(220)))), ((int)(((byte)(228)))));
            this.gb_adjust.Location = new System.Drawing.Point(17, 159);
            this.gb_adjust.Name = "gb_adjust";
            this.gb_adjust.Size = new System.Drawing.Size(322, 244);
            this.gb_adjust.TabIndex = 29;
            this.gb_adjust.TabStop = false;
            this.gb_adjust.Text = "Stock Adjustment";
            // 
            // btn_confirm
            // 
            this.btn_confirm.AllowAnimations = true;
            this.btn_confirm.AllowMouseEffects = true;
            this.btn_confirm.AllowToggling = false;
            this.btn_confirm.AnimationSpeed = 200;
            this.btn_confirm.AutoGenerateColors = false;
            this.btn_confirm.AutoRoundBorders = false;
            this.btn_confirm.AutoSizeLeftIcon = true;
            this.btn_confirm.AutoSizeRightIcon = true;
            this.btn_confirm.BackColor = System.Drawing.Color.Transparent;
            this.btn_confirm.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(139)))));
            this.btn_confirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_confirm.BackgroundImage")));
            this.btn_confirm.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_confirm.ButtonText = "Confirm";
            this.btn_confirm.ButtonTextMarginLeft = 0;
            this.btn_confirm.ColorContrastOnClick = 45;
            this.btn_confirm.ColorContrastOnHover = 45;
            this.btn_confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btn_confirm.CustomizableEdges = borderEdges6;
            this.btn_confirm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_confirm.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_confirm.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_confirm.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_confirm.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btn_confirm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_confirm.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_confirm.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_confirm.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_confirm.IconMarginLeft = 11;
            this.btn_confirm.IconPadding = 10;
            this.btn_confirm.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_confirm.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_confirm.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_confirm.IconSize = 25;
            this.btn_confirm.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(139)))));
            this.btn_confirm.IdleBorderRadius = 15;
            this.btn_confirm.IdleBorderThickness = 1;
            this.btn_confirm.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(139)))));
            this.btn_confirm.IdleIconLeftImage = null;
            this.btn_confirm.IdleIconRightImage = null;
            this.btn_confirm.IndicateFocus = false;
            this.btn_confirm.Location = new System.Drawing.Point(8, 193);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_confirm.OnDisabledState.BorderRadius = 15;
            this.btn_confirm.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_confirm.OnDisabledState.BorderThickness = 1;
            this.btn_confirm.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_confirm.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_confirm.OnDisabledState.IconLeftImage = null;
            this.btn_confirm.OnDisabledState.IconRightImage = null;
            this.btn_confirm.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(154)))));
            this.btn_confirm.onHoverState.BorderRadius = 15;
            this.btn_confirm.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_confirm.onHoverState.BorderThickness = 1;
            this.btn_confirm.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(154)))));
            this.btn_confirm.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_confirm.onHoverState.IconLeftImage = null;
            this.btn_confirm.onHoverState.IconRightImage = null;
            this.btn_confirm.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(139)))));
            this.btn_confirm.OnIdleState.BorderRadius = 15;
            this.btn_confirm.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_confirm.OnIdleState.BorderThickness = 1;
            this.btn_confirm.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(139)))));
            this.btn_confirm.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_confirm.OnIdleState.IconLeftImage = null;
            this.btn_confirm.OnIdleState.IconRightImage = null;
            this.btn_confirm.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.btn_confirm.OnPressedState.BorderRadius = 15;
            this.btn_confirm.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_confirm.OnPressedState.BorderThickness = 1;
            this.btn_confirm.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.btn_confirm.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_confirm.OnPressedState.IconLeftImage = null;
            this.btn_confirm.OnPressedState.IconRightImage = null;
            this.btn_confirm.Size = new System.Drawing.Size(119, 36);
            this.btn_confirm.TabIndex = 31;
            this.btn_confirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_confirm.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_confirm.TextMarginLeft = 0;
            this.btn_confirm.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_confirm.UseDefaultRadiusAndThickness = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(220)))), ((int)(((byte)(228)))));
            this.label5.Location = new System.Drawing.Point(5, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "Keterangan";
            // 
            // tb_keterangan
            // 
            this.tb_keterangan.Location = new System.Drawing.Point(6, 95);
            this.tb_keterangan.Multiline = true;
            this.tb_keterangan.Name = "tb_keterangan";
            this.tb_keterangan.Size = new System.Drawing.Size(310, 92);
            this.tb_keterangan.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(220)))), ((int)(((byte)(228)))));
            this.label4.Location = new System.Drawing.Point(195, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "New Quantity";
            // 
            // num_newqty
            // 
            this.num_newqty.Location = new System.Drawing.Point(196, 40);
            this.num_newqty.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.num_newqty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_newqty.Name = "num_newqty";
            this.num_newqty.Size = new System.Drawing.Size(120, 20);
            this.num_newqty.TabIndex = 31;
            this.num_newqty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(220)))), ((int)(((byte)(228)))));
            this.label2.Location = new System.Drawing.Point(5, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Old Quantity";
            // 
            // num_oldqty
            // 
            this.num_oldqty.Location = new System.Drawing.Point(6, 40);
            this.num_oldqty.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.num_oldqty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_oldqty.Name = "num_oldqty";
            this.num_oldqty.ReadOnly = true;
            this.num_oldqty.Size = new System.Drawing.Size(120, 20);
            this.num_oldqty.TabIndex = 0;
            this.num_oldqty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Detail_Stock_Adjustment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 415);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(372, 413);
            this.Name = "Detail_Stock_Adjustment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detail_Stock_Adjustment";
            this.Load += new System.EventHandler(this.Detail_Stock_Adjustment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_adjust.ResumeLayout(false);
            this.gb_adjust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_newqty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_oldqty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_kode;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_check;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gb_adjust;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown num_newqty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_oldqty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_keterangan;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_reset;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_confirm;
    }
}