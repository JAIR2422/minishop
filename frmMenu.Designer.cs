namespace proy_u4
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnsrbSalir = new System.Windows.Forms.Button();
            this.lblsrbTitulo = new System.Windows.Forms.Label();
            this.menusrbTitulo = new System.Windows.Forms.MenuStrip();
            this.lblsrbtxtFecha = new System.Windows.Forms.Label();
            this.lblsrbFecha = new System.Windows.Forms.Label();
            this.lblsrbNomUser = new System.Windows.Forms.Label();
            this.llsrbSalir = new System.Windows.Forms.LinkLabel();
            this.pbsrbImgUser = new System.Windows.Forms.PictureBox();
            this.pbsrbLogo = new System.Windows.Forms.PictureBox();
            this.btnVenta = new FontAwesome.Sharp.IconButton();
            this.btnHistorial = new FontAwesome.Sharp.IconButton();
            this.btnCorte = new FontAwesome.Sharp.IconButton();
            this.btnProductos = new FontAwesome.Sharp.IconButton();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbsrbImgUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbsrbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsrbSalir
            // 
            this.btnsrbSalir.BackColor = System.Drawing.Color.Red;
            this.btnsrbSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsrbSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsrbSalir.ForeColor = System.Drawing.Color.White;
            this.btnsrbSalir.Location = new System.Drawing.Point(727, 2);
            this.btnsrbSalir.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.btnsrbSalir.Name = "btnsrbSalir";
            this.btnsrbSalir.Size = new System.Drawing.Size(48, 29);
            this.btnsrbSalir.TabIndex = 97;
            this.btnsrbSalir.Text = "X";
            this.btnsrbSalir.UseVisualStyleBackColor = false;
            this.btnsrbSalir.Click += new System.EventHandler(this.btnsrbSalir_Click);
            // 
            // lblsrbTitulo
            // 
            this.lblsrbTitulo.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lblsrbTitulo.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsrbTitulo.ForeColor = System.Drawing.Color.Snow;
            this.lblsrbTitulo.Location = new System.Drawing.Point(100, 15);
            this.lblsrbTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsrbTitulo.Name = "lblsrbTitulo";
            this.lblsrbTitulo.Size = new System.Drawing.Size(352, 57);
            this.lblsrbTitulo.TabIndex = 96;
            this.lblsrbTitulo.Text = "Sistema de Ventas";
            // 
            // menusrbTitulo
            // 
            this.menusrbTitulo.AutoSize = false;
            this.menusrbTitulo.BackColor = System.Drawing.Color.PaleVioletRed;
            this.menusrbTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menusrbTitulo.Location = new System.Drawing.Point(0, 0);
            this.menusrbTitulo.Name = "menusrbTitulo";
            this.menusrbTitulo.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menusrbTitulo.Size = new System.Drawing.Size(784, 137);
            this.menusrbTitulo.TabIndex = 95;
            this.menusrbTitulo.Text = "menuStrip1";
            // 
            // lblsrbtxtFecha
            // 
            this.lblsrbtxtFecha.AutoSize = true;
            this.lblsrbtxtFecha.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lblsrbtxtFecha.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblsrbtxtFecha.ForeColor = System.Drawing.Color.Snow;
            this.lblsrbtxtFecha.Location = new System.Drawing.Point(106, 78);
            this.lblsrbtxtFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsrbtxtFecha.Name = "lblsrbtxtFecha";
            this.lblsrbtxtFecha.Size = new System.Drawing.Size(111, 23);
            this.lblsrbtxtFecha.TabIndex = 100;
            this.lblsrbtxtFecha.Text = "Fecha Actual:";
            // 
            // lblsrbFecha
            // 
            this.lblsrbFecha.AutoSize = true;
            this.lblsrbFecha.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lblsrbFecha.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblsrbFecha.ForeColor = System.Drawing.Color.Snow;
            this.lblsrbFecha.Location = new System.Drawing.Point(224, 78);
            this.lblsrbFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsrbFecha.Name = "lblsrbFecha";
            this.lblsrbFecha.Size = new System.Drawing.Size(51, 23);
            this.lblsrbFecha.TabIndex = 101;
            this.lblsrbFecha.Text = "fecha";
            // 
            // lblsrbNomUser
            // 
            this.lblsrbNomUser.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lblsrbNomUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsrbNomUser.ForeColor = System.Drawing.Color.White;
            this.lblsrbNomUser.Location = new System.Drawing.Point(495, 19);
            this.lblsrbNomUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsrbNomUser.Name = "lblsrbNomUser";
            this.lblsrbNomUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblsrbNomUser.Size = new System.Drawing.Size(154, 29);
            this.lblsrbNomUser.TabIndex = 102;
            this.lblsrbNomUser.Text = "nombre";
            this.lblsrbNomUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // llsrbSalir
            // 
            this.llsrbSalir.BackColor = System.Drawing.Color.PaleVioletRed;
            this.llsrbSalir.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(22)))), ((int)(((byte)(44)))));
            this.llsrbSalir.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llsrbSalir.ForeColor = System.Drawing.Color.Snow;
            this.llsrbSalir.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llsrbSalir.LinkColor = System.Drawing.Color.White;
            this.llsrbSalir.Location = new System.Drawing.Point(591, 48);
            this.llsrbSalir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llsrbSalir.Name = "llsrbSalir";
            this.llsrbSalir.Size = new System.Drawing.Size(52, 32);
            this.llsrbSalir.TabIndex = 103;
            this.llsrbSalir.TabStop = true;
            this.llsrbSalir.Text = "Salir";
            this.llsrbSalir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llsrbSalir_LinkClicked);
            // 
            // pbsrbImgUser
            // 
            this.pbsrbImgUser.BackColor = System.Drawing.Color.PaleVioletRed;
            this.pbsrbImgUser.Location = new System.Drawing.Point(647, 14);
            this.pbsrbImgUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbsrbImgUser.Name = "pbsrbImgUser";
            this.pbsrbImgUser.Size = new System.Drawing.Size(66, 70);
            this.pbsrbImgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbsrbImgUser.TabIndex = 104;
            this.pbsrbImgUser.TabStop = false;
            // 
            // pbsrbLogo
            // 
            this.pbsrbLogo.BackColor = System.Drawing.Color.PaleVioletRed;
            this.pbsrbLogo.Image = global::proy_u4.Properties.Resources.logo;
            this.pbsrbLogo.Location = new System.Drawing.Point(14, 17);
            this.pbsrbLogo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbsrbLogo.Name = "pbsrbLogo";
            this.pbsrbLogo.Size = new System.Drawing.Size(88, 90);
            this.pbsrbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbsrbLogo.TabIndex = 99;
            this.pbsrbLogo.TabStop = false;
            // 
            // btnVenta
            // 
            this.btnVenta.BackColor = System.Drawing.Color.Honeydew;
            this.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnVenta.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
            this.btnVenta.IconColor = System.Drawing.Color.Black;
            this.btnVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVenta.IconSize = 80;
            this.btnVenta.Location = new System.Drawing.Point(96, 188);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(198, 87);
            this.btnVenta.TabIndex = 105;
            this.btnVenta.Text = "Nueva Venta";
            this.btnVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVenta.UseVisualStyleBackColor = false;
            this.btnVenta.Click += new System.EventHandler(this.misrbVentas_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.LightCyan;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnHistorial.IconChar = FontAwesome.Sharp.IconChar.FileText;
            this.btnHistorial.IconColor = System.Drawing.Color.Black;
            this.btnHistorial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHistorial.IconSize = 80;
            this.btnHistorial.Location = new System.Drawing.Point(96, 296);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(198, 88);
            this.btnHistorial.TabIndex = 106;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.misrbHistorial_Click);
            // 
            // btnCorte
            // 
            this.btnCorte.IconChar = FontAwesome.Sharp.IconChar._3;
            this.btnCorte.IconColor = System.Drawing.Color.Black;
            this.btnCorte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCorte.Location = new System.Drawing.Point(292, 238);
            this.btnCorte.Name = "btnCorte";
            this.btnCorte.Size = new System.Drawing.Size(198, 75);
            this.btnCorte.TabIndex = 107;
            this.btnCorte.Text = "Corte";
            this.btnCorte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCorte.UseVisualStyleBackColor = true;
            this.btnCorte.Visible = false;
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.PeachPuff;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnProductos.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            this.btnProductos.IconColor = System.Drawing.Color.Black;
            this.btnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductos.IconSize = 80;
            this.btnProductos.Location = new System.Drawing.Point(481, 188);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(198, 87);
            this.btnProductos.TabIndex = 108;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.misrbProductos_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Lavender;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.btnUsuarios.IconColor = System.Drawing.Color.Black;
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.IconSize = 80;
            this.btnUsuarios.Location = new System.Drawing.Point(481, 296);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(198, 88);
            this.btnUsuarios.TabIndex = 109;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.misrbUsuarios_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(784, 427);
            this.ControlBox = false;
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnCorte);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.pbsrbImgUser);
            this.Controls.Add(this.llsrbSalir);
            this.Controls.Add(this.lblsrbNomUser);
            this.Controls.Add(this.lblsrbFecha);
            this.Controls.Add(this.lblsrbtxtFecha);
            this.Controls.Add(this.pbsrbLogo);
            this.Controls.Add(this.btnsrbSalir);
            this.Controls.Add(this.lblsrbTitulo);
            this.Controls.Add(this.menusrbTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbsrbImgUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbsrbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsrbSalir;
        private System.Windows.Forms.Label lblsrbTitulo;
        private System.Windows.Forms.MenuStrip menusrbTitulo;
        private System.Windows.Forms.PictureBox pbsrbLogo;
        private System.Windows.Forms.Label lblsrbtxtFecha;
        private System.Windows.Forms.Label lblsrbFecha;
        private System.Windows.Forms.Label lblsrbNomUser;
        private System.Windows.Forms.LinkLabel llsrbSalir;
        private System.Windows.Forms.PictureBox pbsrbImgUser;
        private FontAwesome.Sharp.IconButton btnVenta;
        private FontAwesome.Sharp.IconButton btnHistorial;
        private FontAwesome.Sharp.IconButton btnCorte;
        private FontAwesome.Sharp.IconButton btnProductos;
        private FontAwesome.Sharp.IconButton btnUsuarios;
    }
}