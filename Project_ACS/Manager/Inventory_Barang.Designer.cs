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
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory_Barang));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.pl = new System.Windows.Forms.Panel();
            this.bunifuPages1 = new Bunifu.UI.WinForms.BunifuPages();
            this.tpage = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_next = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_left = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pl.SuspendLayout();
            this.bunifuPages1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl
            // 
            this.pl.BackColor = System.Drawing.Color.Yellow;
            this.pl.Controls.Add(this.btn_left);
            this.pl.Controls.Add(this.btn_next);
            this.pl.Controls.Add(this.bunifuPages1);
            this.pl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl.Location = new System.Drawing.Point(0, 0);
            this.pl.Name = "pl";
            this.pl.Size = new System.Drawing.Size(848, 571);
            this.pl.TabIndex = 0;
            // 
            // bunifuPages1
            // 
            this.bunifuPages1.AllowTransitions = true;
            this.bunifuPages1.Controls.Add(this.tpage);
            this.bunifuPages1.Controls.Add(this.tabPage2);
            this.bunifuPages1.Location = new System.Drawing.Point(130, 126);
            this.bunifuPages1.Multiline = true;
            this.bunifuPages1.Name = "bunifuPages1";
            this.bunifuPages1.Page = this.tabPage2;
            this.bunifuPages1.PageIndex = 1;
            this.bunifuPages1.PageName = "tabPage2";
            this.bunifuPages1.PageTitle = "tabPage2";
            this.bunifuPages1.SelectedIndex = 0;
            this.bunifuPages1.Size = new System.Drawing.Size(425, 208);
            this.bunifuPages1.TabIndex = 0;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuPages1.Transition = animation1;
            this.bunifuPages1.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // tpage
            // 
            this.tpage.Location = new System.Drawing.Point(4, 22);
            this.tpage.Name = "tpage";
            this.tpage.Padding = new System.Windows.Forms.Padding(3);
            this.tpage.Size = new System.Drawing.Size(417, 182);
            this.tpage.TabIndex = 0;
            this.tpage.Text = "tabPage1";
            this.tpage.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(417, 182);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_next
            // 
            this.btn_next.AllowAnimations = true;
            this.btn_next.AllowMouseEffects = true;
            this.btn_next.AllowToggling = false;
            this.btn_next.AnimationSpeed = 200;
            this.btn_next.AutoGenerateColors = false;
            this.btn_next.AutoRoundBorders = false;
            this.btn_next.AutoSizeLeftIcon = true;
            this.btn_next.AutoSizeRightIcon = true;
            this.btn_next.BackColor = System.Drawing.Color.Transparent;
            this.btn_next.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn_next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_next.BackgroundImage")));
            this.btn_next.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_next.ButtonText = "next";
            this.btn_next.ButtonTextMarginLeft = 0;
            this.btn_next.ColorContrastOnClick = 45;
            this.btn_next.ColorContrastOnHover = 45;
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_next.CustomizableEdges = borderEdges2;
            this.btn_next.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_next.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_next.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_next.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_next.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_next.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_next.ForeColor = System.Drawing.Color.White;
            this.btn_next.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_next.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_next.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_next.IconMarginLeft = 11;
            this.btn_next.IconPadding = 10;
            this.btn_next.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_next.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_next.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_next.IconSize = 25;
            this.btn_next.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_next.IdleBorderRadius = 1;
            this.btn_next.IdleBorderThickness = 1;
            this.btn_next.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_next.IdleIconLeftImage = null;
            this.btn_next.IdleIconRightImage = null;
            this.btn_next.IndicateFocus = false;
            this.btn_next.Location = new System.Drawing.Point(695, 82);
            this.btn_next.Name = "btn_next";
            this.btn_next.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_next.OnDisabledState.BorderRadius = 1;
            this.btn_next.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_next.OnDisabledState.BorderThickness = 1;
            this.btn_next.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_next.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_next.OnDisabledState.IconLeftImage = null;
            this.btn_next.OnDisabledState.IconRightImage = null;
            this.btn_next.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_next.onHoverState.BorderRadius = 1;
            this.btn_next.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_next.onHoverState.BorderThickness = 1;
            this.btn_next.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_next.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_next.onHoverState.IconLeftImage = null;
            this.btn_next.onHoverState.IconRightImage = null;
            this.btn_next.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_next.OnIdleState.BorderRadius = 1;
            this.btn_next.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_next.OnIdleState.BorderThickness = 1;
            this.btn_next.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_next.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_next.OnIdleState.IconLeftImage = null;
            this.btn_next.OnIdleState.IconRightImage = null;
            this.btn_next.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_next.OnPressedState.BorderRadius = 1;
            this.btn_next.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_next.OnPressedState.BorderThickness = 1;
            this.btn_next.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_next.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_next.OnPressedState.IconLeftImage = null;
            this.btn_next.OnPressedState.IconRightImage = null;
            this.btn_next.Size = new System.Drawing.Size(150, 39);
            this.btn_next.TabIndex = 1;
            this.btn_next.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_next.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_next.TextMarginLeft = 0;
            this.btn_next.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_next.UseDefaultRadiusAndThickness = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_left
            // 
            this.btn_left.AllowAnimations = true;
            this.btn_left.AllowMouseEffects = true;
            this.btn_left.AllowToggling = false;
            this.btn_left.AnimationSpeed = 200;
            this.btn_left.AutoGenerateColors = false;
            this.btn_left.AutoRoundBorders = false;
            this.btn_left.AutoSizeLeftIcon = true;
            this.btn_left.AutoSizeRightIcon = true;
            this.btn_left.BackColor = System.Drawing.Color.Transparent;
            this.btn_left.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn_left.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_left.BackgroundImage")));
            this.btn_left.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_left.ButtonText = "left";
            this.btn_left.ButtonTextMarginLeft = 0;
            this.btn_left.ColorContrastOnClick = 45;
            this.btn_left.ColorContrastOnHover = 45;
            this.btn_left.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_left.CustomizableEdges = borderEdges1;
            this.btn_left.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_left.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_left.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_left.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_left.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_left.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_left.ForeColor = System.Drawing.Color.White;
            this.btn_left.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_left.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_left.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_left.IconMarginLeft = 11;
            this.btn_left.IconPadding = 10;
            this.btn_left.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_left.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_left.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_left.IconSize = 25;
            this.btn_left.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_left.IdleBorderRadius = 1;
            this.btn_left.IdleBorderThickness = 1;
            this.btn_left.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_left.IdleIconLeftImage = null;
            this.btn_left.IdleIconRightImage = null;
            this.btn_left.IndicateFocus = false;
            this.btn_left.Location = new System.Drawing.Point(698, 161);
            this.btn_left.Name = "btn_left";
            this.btn_left.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_left.OnDisabledState.BorderRadius = 1;
            this.btn_left.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_left.OnDisabledState.BorderThickness = 1;
            this.btn_left.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_left.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_left.OnDisabledState.IconLeftImage = null;
            this.btn_left.OnDisabledState.IconRightImage = null;
            this.btn_left.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_left.onHoverState.BorderRadius = 1;
            this.btn_left.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_left.onHoverState.BorderThickness = 1;
            this.btn_left.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_left.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_left.onHoverState.IconLeftImage = null;
            this.btn_left.onHoverState.IconRightImage = null;
            this.btn_left.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_left.OnIdleState.BorderRadius = 1;
            this.btn_left.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_left.OnIdleState.BorderThickness = 1;
            this.btn_left.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_left.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_left.OnIdleState.IconLeftImage = null;
            this.btn_left.OnIdleState.IconRightImage = null;
            this.btn_left.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_left.OnPressedState.BorderRadius = 1;
            this.btn_left.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_left.OnPressedState.BorderThickness = 1;
            this.btn_left.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_left.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_left.OnPressedState.IconLeftImage = null;
            this.btn_left.OnPressedState.IconRightImage = null;
            this.btn_left.Size = new System.Drawing.Size(150, 39);
            this.btn_left.TabIndex = 2;
            this.btn_left.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_left.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_left.TextMarginLeft = 0;
            this.btn_left.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_left.UseDefaultRadiusAndThickness = true;
            // 
            // Inventory_Barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 571);
            this.Controls.Add(this.pl);
            this.Name = "Inventory_Barang";
            this.Text = "Inventory_Barang";
            this.Load += new System.EventHandler(this.Inventory_Barang_Load);
            this.pl.ResumeLayout(false);
            this.bunifuPages1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl;
        private Bunifu.UI.WinForms.BunifuPages bunifuPages1;
        private System.Windows.Forms.TabPage tpage;
        private System.Windows.Forms.TabPage tabPage2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_next;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_left;
    }
}