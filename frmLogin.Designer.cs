namespace proy_u4
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnsrbSalir = new System.Windows.Forms.Button();
            this.lblsrbtxtLogin = new System.Windows.Forms.Label();
            this.lblsrbtxtuser = new System.Windows.Forms.Label();
            this.btnsrbIngresar = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtsrbUser = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblsrbtxtPass = new System.Windows.Forms.Label();
            this.txtsrbContra = new System.Windows.Forms.TextBox();
            this.pbsrbLogo = new System.Windows.Forms.PictureBox();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbsrbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsrbSalir
            // 
            this.btnsrbSalir.BackColor = System.Drawing.Color.Red;
            this.btnsrbSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsrbSalir.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnsrbSalir.ForeColor = System.Drawing.Color.White;
            this.btnsrbSalir.Location = new System.Drawing.Point(308, 1);
            this.btnsrbSalir.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnsrbSalir.Name = "btnsrbSalir";
            this.btnsrbSalir.Size = new System.Drawing.Size(48, 29);
            this.btnsrbSalir.TabIndex = 4;
            this.btnsrbSalir.Text = "X";
            this.btnsrbSalir.UseVisualStyleBackColor = false;
            this.btnsrbSalir.Click += new System.EventHandler(this.btnsrbSalir_Click);
            // 
            // lblsrbtxtLogin
            // 
            this.lblsrbtxtLogin.AutoSize = true;
            this.lblsrbtxtLogin.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblsrbtxtLogin.Location = new System.Drawing.Point(87, 27);
            this.lblsrbtxtLogin.Name = "lblsrbtxtLogin";
            this.lblsrbtxtLogin.Size = new System.Drawing.Size(225, 45);
            this.lblsrbtxtLogin.TabIndex = 98;
            this.lblsrbtxtLogin.Text = "Iniciar Sesión";
            // 
            // lblsrbtxtuser
            // 
            this.lblsrbtxtuser.AutoSize = true;
            this.lblsrbtxtuser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblsrbtxtuser.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblsrbtxtuser.Location = new System.Drawing.Point(90, 98);
            this.lblsrbtxtuser.Name = "lblsrbtxtuser";
            this.lblsrbtxtuser.Size = new System.Drawing.Size(79, 28);
            this.lblsrbtxtuser.TabIndex = 99;
            this.lblsrbtxtuser.Text = "Usuario";
            // 
            // btnsrbIngresar
            // 
            this.btnsrbIngresar.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnsrbIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsrbIngresar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnsrbIngresar.ForeColor = System.Drawing.Color.White;
            this.btnsrbIngresar.Location = new System.Drawing.Point(101, 314);
            this.btnsrbIngresar.Name = "btnsrbIngresar";
            this.btnsrbIngresar.Size = new System.Drawing.Size(147, 40);
            this.btnsrbIngresar.TabIndex = 3;
            this.btnsrbIngresar.Text = "Ingresar";
            this.btnsrbIngresar.UseVisualStyleBackColor = false;
            this.btnsrbIngresar.Click += new System.EventHandler(this.btnsrbIngresar_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(93, 145);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(219, 20);
            this.lbl1.TabIndex = 103;
            this.lbl1.Text = "___________________________________";
            // 
            // txtsrbUser
            // 
            this.txtsrbUser.BackColor = System.Drawing.Color.Snow;
            this.txtsrbUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsrbUser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtsrbUser.Location = new System.Drawing.Point(97, 133);
            this.txtsrbUser.Name = "txtsrbUser";
            this.txtsrbUser.Size = new System.Drawing.Size(210, 27);
            this.txtsrbUser.TabIndex = 1;
            this.txtsrbUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsrbUser_KeyDown);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(93, 237);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(219, 20);
            this.lbl2.TabIndex = 107;
            this.lbl2.Text = "___________________________________";
            // 
            // lblsrbtxtPass
            // 
            this.lblsrbtxtPass.AutoSize = true;
            this.lblsrbtxtPass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblsrbtxtPass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblsrbtxtPass.Location = new System.Drawing.Point(90, 193);
            this.lblsrbtxtPass.Name = "lblsrbtxtPass";
            this.lblsrbtxtPass.Size = new System.Drawing.Size(110, 28);
            this.lblsrbtxtPass.TabIndex = 104;
            this.lblsrbtxtPass.Text = "Contraseña";
            // 
            // txtsrbContra
            // 
            this.txtsrbContra.BackColor = System.Drawing.Color.Snow;
            this.txtsrbContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsrbContra.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtsrbContra.Location = new System.Drawing.Point(97, 225);
            this.txtsrbContra.Name = "txtsrbContra";
            this.txtsrbContra.Size = new System.Drawing.Size(210, 27);
            this.txtsrbContra.TabIndex = 2;
            this.txtsrbContra.UseSystemPasswordChar = true;
            this.txtsrbContra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsrbContra_KeyDown);
            // 
            // pbsrbLogo
            // 
            this.pbsrbLogo.Image = global::proy_u4.Properties.Resources.logo;
            this.pbsrbLogo.Location = new System.Drawing.Point(12, 16);
            this.pbsrbLogo.Name = "pbsrbLogo";
            this.pbsrbLogo.Size = new System.Drawing.Size(75, 68);
            this.pbsrbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbsrbLogo.TabIndex = 97;
            this.pbsrbLogo.TabStop = false;
            this.pbsrbLogo.DoubleClick += new System.EventHandler(this.pbsrbLogo_DoubleClick);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblError.Location = new System.Drawing.Point(97, 270);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(76, 20);
            this.lblError.TabIndex = 101;
            this.lblError.Text = "Incorrecto";
            this.lblError.Visible = false;
            // 
            // frmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(365, 366);
            this.ControlBox = false;
            this.Controls.Add(this.txtsrbContra);
            this.Controls.Add(this.txtsrbUser);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lblsrbtxtPass);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnsrbIngresar);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblsrbtxtuser);
            this.Controls.Add(this.lblsrbtxtLogin);
            this.Controls.Add(this.pbsrbLogo);
            this.Controls.Add(this.btnsrbSalir);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pbsrbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsrbSalir;
        private System.Windows.Forms.PictureBox pbsrbLogo;
        private System.Windows.Forms.Label lblsrbtxtLogin;
        private System.Windows.Forms.Label lblsrbtxtuser;
        private System.Windows.Forms.Button btnsrbIngresar;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtsrbUser;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblsrbtxtPass;
        private System.Windows.Forms.TextBox txtsrbContra;
        private System.Windows.Forms.Label lblError;
    }
}