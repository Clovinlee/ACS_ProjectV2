
namespace Project_ACS.Master
{
    partial class Add_Akun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Akun));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbb_jabatan = new System.Windows.Forms.ComboBox();
            this.btn_ok = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(220)))), ((int)(((byte)(228)))));
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Add Account";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(11, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 43;
            this.label3.Text = "Username:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(84, 73);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(178, 23);
            this.txtUsername.TabIndex = 42;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(11, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 45;
            this.label2.Text = "Password:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(84, 114);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(178, 23);
            this.txtPass.TabIndex = 44;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(11, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 47;
            this.label4.Text = "Nama:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNama
            // 
            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.Location = new System.Drawing.Point(84, 154);
            this.txtNama.Margin = new System.Windows.Forms.Padding(2);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(178, 23);
            this.txtNama.TabIndex = 46;
            this.txtNama.TextChanged += new System.EventHandler(this.txtNama_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(11, 198);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 49;
            this.label5.Text = "Alamat:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtAlamat
            // 
            this.txtAlamat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlamat.Location = new System.Drawing.Point(84, 195);
            this.txtAlamat.Margin = new System.Windows.Forms.Padding(2);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(178, 23);
            this.txtAlamat.TabIndex = 48;
            this.txtAlamat.TextChanged += new System.EventHandler(this.txtAlamat_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(11, 239);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 51;
            this.label6.Text = "Email:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(84, 236);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(178, 23);
            this.txtEmail.TabIndex = 50;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(11, 281);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 53;
            this.label7.Text = "Jabatan:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cbb_jabatan
            // 
            this.cbb_jabatan.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbb_jabatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_jabatan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_jabatan.FormattingEnabled = true;
            this.cbb_jabatan.Items.AddRange(new object[] {
            "Master Account",
            "Warehouse Manager",
            "Pegawai Warehouse"});
            this.cbb_jabatan.Location = new System.Drawing.Point(84, 278);
            this.cbb_jabatan.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_jabatan.Name = "cbb_jabatan";
            this.cbb_jabatan.Size = new System.Drawing.Size(178, 23);
            this.cbb_jabatan.TabIndex = 52;
            this.cbb_jabatan.SelectedIndexChanged += new System.EventHandler(this.cbb_jabatan_SelectedIndexChanged);
            // 
            // btn_ok
            // 
            this.btn_ok.AllowAnimations = true;
            this.btn_ok.AllowMouseEffects = true;
            this.btn_ok.AllowToggling = false;
            this.btn_ok.AnimationSpeed = 200;
            this.btn_ok.AutoGenerateColors = false;
            this.btn_ok.AutoRoundBorders = false;
            this.btn_ok.AutoSizeLeftIcon = true;
            this.btn_ok.AutoSizeRightIcon = true;
            this.btn_ok.BackColor = System.Drawing.Color.Transparent;
            this.btn_ok.BackColor1 = System.Drawing.Color.MediumSpringGreen;
            this.btn_ok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ok.BackgroundImage")));
            this.btn_ok.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_ok.ButtonText = "Add";
            this.btn_ok.ButtonTextMarginLeft = 0;
            this.btn_ok.ColorContrastOnClick = 45;
            this.btn_ok.ColorContrastOnHover = 45;
            this.btn_ok.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_ok.CustomizableEdges = borderEdges1;
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_ok.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_ok.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_ok.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_ok.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_ok.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ok.ForeColor = System.Drawing.Color.Black;
            this.btn_ok.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ok.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_ok.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_ok.IconMarginLeft = 11;
            this.btn_ok.IconPadding = 10;
            this.btn_ok.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ok.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_ok.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_ok.IconSize = 25;
            this.btn_ok.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_ok.IdleBorderRadius = 1;
            this.btn_ok.IdleBorderThickness = 1;
            this.btn_ok.IdleFillColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_ok.IdleIconLeftImage = null;
            this.btn_ok.IdleIconRightImage = null;
            this.btn_ok.IndicateFocus = false;
            this.btn_ok.Location = new System.Drawing.Point(84, 334);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_ok.OnDisabledState.BorderRadius = 1;
            this.btn_ok.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_ok.OnDisabledState.BorderThickness = 1;
            this.btn_ok.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_ok.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_ok.OnDisabledState.IconLeftImage = null;
            this.btn_ok.OnDisabledState.IconRightImage = null;
            this.btn_ok.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_ok.onHoverState.BorderRadius = 1;
            this.btn_ok.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_ok.onHoverState.BorderThickness = 1;
            this.btn_ok.onHoverState.FillColor = System.Drawing.Color.Aquamarine;
            this.btn_ok.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_ok.onHoverState.IconLeftImage = null;
            this.btn_ok.onHoverState.IconRightImage = null;
            this.btn_ok.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_ok.OnIdleState.BorderRadius = 1;
            this.btn_ok.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_ok.OnIdleState.BorderThickness = 1;
            this.btn_ok.OnIdleState.FillColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_ok.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btn_ok.OnIdleState.IconLeftImage = null;
            this.btn_ok.OnIdleState.IconRightImage = null;
            this.btn_ok.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_ok.OnPressedState.BorderRadius = 1;
            this.btn_ok.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_ok.OnPressedState.BorderThickness = 1;
            this.btn_ok.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_ok.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_ok.OnPressedState.IconLeftImage = null;
            this.btn_ok.OnPressedState.IconRightImage = null;
            this.btn_ok.Size = new System.Drawing.Size(112, 32);
            this.btn_ok.TabIndex = 54;
            this.btn_ok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ok.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_ok.TextMarginLeft = 0;
            this.btn_ok.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_ok.UseDefaultRadiusAndThickness = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // Add_Akun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(277, 392);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbb_jabatan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Name = "Add_Akun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Akun";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbb_jabatan;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_ok;
    }
}