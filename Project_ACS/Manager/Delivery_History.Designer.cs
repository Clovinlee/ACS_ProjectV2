namespace Project_ACS.Manager
{
    partial class Delivery_History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delivery_History));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_refresh = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dgv_barang = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_rak = new System.Windows.Forms.ComboBox();
            this.pl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_barang)).BeginInit();
            this.SuspendLayout();
            // 
            // pl
            // 
            this.pl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(139)))));
            this.pl.Controls.Add(this.btn_refresh);
            this.pl.Controls.Add(this.dgv_barang);
            this.pl.Controls.Add(this.label5);
            this.pl.Controls.Add(this.cbb_rak);
            this.pl.Controls.Add(this.label1);
            this.pl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl.Location = new System.Drawing.Point(0, 0);
            this.pl.Name = "pl";
            this.pl.Size = new System.Drawing.Size(848, 571);
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
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "History Delivery";
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
            this.btn_refresh.Location = new System.Drawing.Point(794, 115);
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
            this.btn_refresh.TabIndex = 47;
            this.btn_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_refresh.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_refresh.TextMarginLeft = 0;
            this.btn_refresh.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_refresh.UseDefaultRadiusAndThickness = true;
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
            this.dgv_barang.Location = new System.Drawing.Point(15, 156);
            this.dgv_barang.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_barang.MultiSelect = false;
            this.dgv_barang.Name = "dgv_barang";
            this.dgv_barang.ReadOnly = true;
            this.dgv_barang.RowHeadersVisible = false;
            this.dgv_barang.RowHeadersWidth = 51;
            this.dgv_barang.RowTemplate.Height = 40;
            this.dgv_barang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_barang.Size = new System.Drawing.Size(821, 330);
            this.dgv_barang.TabIndex = 46;
            this.dgv_barang.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(220)))), ((int)(((byte)(228)))));
            this.label5.Location = new System.Drawing.Point(12, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Business Partner";
            // 
            // cbb_rak
            // 
            this.cbb_rak.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbb_rak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_rak.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_rak.FormattingEnabled = true;
            this.cbb_rak.Location = new System.Drawing.Point(16, 118);
            this.cbb_rak.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_rak.Name = "cbb_rak";
            this.cbb_rak.Size = new System.Drawing.Size(218, 20);
            this.cbb_rak.TabIndex = 44;
            // 
            // Delivery_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 571);
            this.Controls.Add(this.pl);
            this.Name = "Delivery_History";
            this.Text = "Delivery_History";
            this.pl.ResumeLayout(false);
            this.pl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_barang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_refresh;
        private Bunifu.UI.WinForms.BunifuDataGridView dgv_barang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_rak;
    }
}