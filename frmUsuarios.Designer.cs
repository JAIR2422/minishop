namespace proy_u4
{
    partial class frmUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.dgsrbUsuarios = new System.Windows.Forms.DataGridView();
            this.lblsrbUAp = new System.Windows.Forms.Label();
            this.txtsrbUId = new System.Windows.Forms.TextBox();
            this.lblsrbUUser = new System.Windows.Forms.Label();
            this.lblsrbUNom = new System.Windows.Forms.Label();
            this.lblsrbUId = new System.Windows.Forms.Label();
            this.txtsrbUNom = new System.Windows.Forms.TextBox();
            this.txtsrbUAp = new System.Windows.Forms.TextBox();
            this.txtsrbUUsuario = new System.Windows.Forms.TextBox();
            this.lblsrbTitulo = new System.Windows.Forms.Label();
            this.menusrbTitulo = new System.Windows.Forms.MenuStrip();
            this.txtsrbUContra = new System.Windows.Forms.TextBox();
            this.lblsrbUContra = new System.Windows.Forms.Label();
            this.cbsrbConfirmar = new System.Windows.Forms.CheckBox();
            this.btnsrbSalir = new System.Windows.Forms.Button();
            this.btnsrbGNuevo = new FontAwesome.Sharp.IconButton();
            this.btnsrbCancelar = new FontAwesome.Sharp.IconButton();
            this.btnsrbAgregar = new FontAwesome.Sharp.IconButton();
            this.btnsrbGuardar = new FontAwesome.Sharp.IconButton();
            this.btnsrbEliminr = new FontAwesome.Sharp.IconButton();
            this.gbRol = new System.Windows.Forms.GroupBox();
            this.rbEmpleado = new System.Windows.Forms.RadioButton();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgsrbUsuarios)).BeginInit();
            this.gbRol.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgsrbUsuarios
            // 
            this.dgsrbUsuarios.AllowUserToAddRows = false;
            this.dgsrbUsuarios.AllowUserToDeleteRows = false;
            this.dgsrbUsuarios.AllowUserToResizeColumns = false;
            this.dgsrbUsuarios.AllowUserToResizeRows = false;
            this.dgsrbUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgsrbUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgsrbUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgsrbUsuarios.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgsrbUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgsrbUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgsrbUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgsrbUsuarios.EnableHeadersVisualStyles = false;
            this.dgsrbUsuarios.Location = new System.Drawing.Point(385, 113);
            this.dgsrbUsuarios.MultiSelect = false;
            this.dgsrbUsuarios.Name = "dgsrbUsuarios";
            this.dgsrbUsuarios.ReadOnly = true;
            this.dgsrbUsuarios.RowHeadersVisible = false;
            this.dgsrbUsuarios.RowHeadersWidth = 51;
            this.dgsrbUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgsrbUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgsrbUsuarios.RowTemplate.Height = 24;
            this.dgsrbUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgsrbUsuarios.Size = new System.Drawing.Size(667, 285);
            this.dgsrbUsuarios.TabIndex = 1;
            this.dgsrbUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgsrbUsuarios_CellClick);
            this.dgsrbUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgsrbUsuarios_CellContentClick);
            // 
            // lblsrbUAp
            // 
            this.lblsrbUAp.AutoSize = true;
            this.lblsrbUAp.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblsrbUAp.Location = new System.Drawing.Point(35, 233);
            this.lblsrbUAp.Name = "lblsrbUAp";
            this.lblsrbUAp.Size = new System.Drawing.Size(72, 23);
            this.lblsrbUAp.TabIndex = 101;
            this.lblsrbUAp.Text = "Apellido";
            // 
            // txtsrbUId
            // 
            this.txtsrbUId.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtsrbUId.Location = new System.Drawing.Point(201, 146);
            this.txtsrbUId.Name = "txtsrbUId";
            this.txtsrbUId.ReadOnly = true;
            this.txtsrbUId.Size = new System.Drawing.Size(158, 30);
            this.txtsrbUId.TabIndex = 94;
            // 
            // lblsrbUUser
            // 
            this.lblsrbUUser.AutoSize = true;
            this.lblsrbUUser.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblsrbUUser.Location = new System.Drawing.Point(35, 275);
            this.lblsrbUUser.Name = "lblsrbUUser";
            this.lblsrbUUser.Size = new System.Drawing.Size(68, 23);
            this.lblsrbUUser.TabIndex = 100;
            this.lblsrbUUser.Text = "Usuario";
            // 
            // lblsrbUNom
            // 
            this.lblsrbUNom.AutoSize = true;
            this.lblsrbUNom.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblsrbUNom.Location = new System.Drawing.Point(35, 189);
            this.lblsrbUNom.Name = "lblsrbUNom";
            this.lblsrbUNom.Size = new System.Drawing.Size(73, 23);
            this.lblsrbUNom.TabIndex = 99;
            this.lblsrbUNom.Text = "Nombre";
            // 
            // lblsrbUId
            // 
            this.lblsrbUId.AutoSize = true;
            this.lblsrbUId.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblsrbUId.Location = new System.Drawing.Point(35, 145);
            this.lblsrbUId.Name = "lblsrbUId";
            this.lblsrbUId.Size = new System.Drawing.Size(27, 23);
            this.lblsrbUId.TabIndex = 98;
            this.lblsrbUId.Text = "ID";
            // 
            // txtsrbUNom
            // 
            this.txtsrbUNom.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtsrbUNom.Location = new System.Drawing.Point(201, 189);
            this.txtsrbUNom.Name = "txtsrbUNom";
            this.txtsrbUNom.Size = new System.Drawing.Size(158, 30);
            this.txtsrbUNom.TabIndex = 105;
            // 
            // txtsrbUAp
            // 
            this.txtsrbUAp.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtsrbUAp.Location = new System.Drawing.Point(201, 233);
            this.txtsrbUAp.Name = "txtsrbUAp";
            this.txtsrbUAp.Size = new System.Drawing.Size(158, 30);
            this.txtsrbUAp.TabIndex = 106;
            // 
            // txtsrbUUsuario
            // 
            this.txtsrbUUsuario.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtsrbUUsuario.Location = new System.Drawing.Point(201, 275);
            this.txtsrbUUsuario.Name = "txtsrbUUsuario";
            this.txtsrbUUsuario.Size = new System.Drawing.Size(158, 30);
            this.txtsrbUUsuario.TabIndex = 108;
            // 
            // lblsrbTitulo
            // 
            this.lblsrbTitulo.AutoSize = true;
            this.lblsrbTitulo.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lblsrbTitulo.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblsrbTitulo.ForeColor = System.Drawing.Color.White;
            this.lblsrbTitulo.Location = new System.Drawing.Point(20, 23);
            this.lblsrbTitulo.Name = "lblsrbTitulo";
            this.lblsrbTitulo.Size = new System.Drawing.Size(154, 45);
            this.lblsrbTitulo.TabIndex = 111;
            this.lblsrbTitulo.Text = "Usuarios";
            // 
            // menusrbTitulo
            // 
            this.menusrbTitulo.AutoSize = false;
            this.menusrbTitulo.BackColor = System.Drawing.Color.PaleVioletRed;
            this.menusrbTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menusrbTitulo.Location = new System.Drawing.Point(0, 0);
            this.menusrbTitulo.Name = "menusrbTitulo";
            this.menusrbTitulo.Size = new System.Drawing.Size(1081, 87);
            this.menusrbTitulo.TabIndex = 110;
            this.menusrbTitulo.Text = "menuStrip1";
            // 
            // txtsrbUContra
            // 
            this.txtsrbUContra.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtsrbUContra.Location = new System.Drawing.Point(201, 319);
            this.txtsrbUContra.Name = "txtsrbUContra";
            this.txtsrbUContra.Size = new System.Drawing.Size(158, 30);
            this.txtsrbUContra.TabIndex = 113;
            this.txtsrbUContra.UseSystemPasswordChar = true;
            // 
            // lblsrbUContra
            // 
            this.lblsrbUContra.AutoSize = true;
            this.lblsrbUContra.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblsrbUContra.Location = new System.Drawing.Point(35, 319);
            this.lblsrbUContra.Name = "lblsrbUContra";
            this.lblsrbUContra.Size = new System.Drawing.Size(97, 23);
            this.lblsrbUContra.TabIndex = 112;
            this.lblsrbUContra.Text = "Contraseña";
            // 
            // cbsrbConfirmar
            // 
            this.cbsrbConfirmar.AutoSize = true;
            this.cbsrbConfirmar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbsrbConfirmar.Location = new System.Drawing.Point(102, 361);
            this.cbsrbConfirmar.Name = "cbsrbConfirmar";
            this.cbsrbConfirmar.Size = new System.Drawing.Size(158, 24);
            this.cbsrbConfirmar.TabIndex = 114;
            this.cbsrbConfirmar.Text = "Mostrar contraseña";
            this.cbsrbConfirmar.UseVisualStyleBackColor = true;
            this.cbsrbConfirmar.Visible = false;
            this.cbsrbConfirmar.CheckedChanged += new System.EventHandler(this.cbsrbConfirmar_CheckedChanged);
            // 
            // btnsrbSalir
            // 
            this.btnsrbSalir.BackColor = System.Drawing.Color.Red;
            this.btnsrbSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsrbSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsrbSalir.ForeColor = System.Drawing.Color.White;
            this.btnsrbSalir.Location = new System.Drawing.Point(1021, 12);
            this.btnsrbSalir.Name = "btnsrbSalir";
            this.btnsrbSalir.Size = new System.Drawing.Size(48, 29);
            this.btnsrbSalir.TabIndex = 116;
            this.btnsrbSalir.Text = "X";
            this.btnsrbSalir.UseVisualStyleBackColor = false;
            this.btnsrbSalir.Click += new System.EventHandler(this.btnsrbSalir_Click);
            // 
            // btnsrbGNuevo
            // 
            this.btnsrbGNuevo.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnsrbGNuevo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsrbGNuevo.ForeColor = System.Drawing.Color.Black;
            this.btnsrbGNuevo.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnsrbGNuevo.IconColor = System.Drawing.Color.Black;
            this.btnsrbGNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsrbGNuevo.IconSize = 40;
            this.btnsrbGNuevo.Location = new System.Drawing.Point(843, 427);
            this.btnsrbGNuevo.Name = "btnsrbGNuevo";
            this.btnsrbGNuevo.Size = new System.Drawing.Size(209, 64);
            this.btnsrbGNuevo.TabIndex = 104;
            this.btnsrbGNuevo.Text = "Guardar";
            this.btnsrbGNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsrbGNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsrbGNuevo.UseVisualStyleBackColor = false;
            this.btnsrbGNuevo.Visible = false;
            this.btnsrbGNuevo.Click += new System.EventHandler(this.btnsrbGNuevo_Click);
            // 
            // btnsrbCancelar
            // 
            this.btnsrbCancelar.BackColor = System.Drawing.Color.Crimson;
            this.btnsrbCancelar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsrbCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnsrbCancelar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnsrbCancelar.IconColor = System.Drawing.Color.Black;
            this.btnsrbCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsrbCancelar.IconSize = 40;
            this.btnsrbCancelar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsrbCancelar.Location = new System.Drawing.Point(615, 427);
            this.btnsrbCancelar.Name = "btnsrbCancelar";
            this.btnsrbCancelar.Size = new System.Drawing.Size(209, 64);
            this.btnsrbCancelar.TabIndex = 12;
            this.btnsrbCancelar.Text = "Cancelar";
            this.btnsrbCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsrbCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsrbCancelar.UseVisualStyleBackColor = false;
            this.btnsrbCancelar.Visible = false;
            this.btnsrbCancelar.Click += new System.EventHandler(this.btnsrbCancelar_Click);
            // 
            // btnsrbAgregar
            // 
            this.btnsrbAgregar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnsrbAgregar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsrbAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnsrbAgregar.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnsrbAgregar.IconColor = System.Drawing.Color.Black;
            this.btnsrbAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsrbAgregar.IconSize = 40;
            this.btnsrbAgregar.Location = new System.Drawing.Point(385, 427);
            this.btnsrbAgregar.Name = "btnsrbAgregar";
            this.btnsrbAgregar.Size = new System.Drawing.Size(209, 64);
            this.btnsrbAgregar.TabIndex = 11;
            this.btnsrbAgregar.Text = "Agregar";
            this.btnsrbAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsrbAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsrbAgregar.UseVisualStyleBackColor = false;
            this.btnsrbAgregar.Click += new System.EventHandler(this.btnsrbAgregar_Click);
            // 
            // btnsrbGuardar
            // 
            this.btnsrbGuardar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnsrbGuardar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsrbGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnsrbGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnsrbGuardar.IconColor = System.Drawing.Color.Black;
            this.btnsrbGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsrbGuardar.IconSize = 40;
            this.btnsrbGuardar.Location = new System.Drawing.Point(615, 427);
            this.btnsrbGuardar.Name = "btnsrbGuardar";
            this.btnsrbGuardar.Size = new System.Drawing.Size(209, 64);
            this.btnsrbGuardar.TabIndex = 10;
            this.btnsrbGuardar.Text = "Guardar";
            this.btnsrbGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsrbGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsrbGuardar.UseVisualStyleBackColor = false;
            this.btnsrbGuardar.Click += new System.EventHandler(this.btnsrbGuardar_Click);
            // 
            // btnsrbEliminr
            // 
            this.btnsrbEliminr.BackColor = System.Drawing.Color.Crimson;
            this.btnsrbEliminr.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsrbEliminr.ForeColor = System.Drawing.Color.Black;
            this.btnsrbEliminr.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnsrbEliminr.IconColor = System.Drawing.Color.Black;
            this.btnsrbEliminr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsrbEliminr.IconSize = 40;
            this.btnsrbEliminr.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsrbEliminr.Location = new System.Drawing.Point(843, 427);
            this.btnsrbEliminr.Name = "btnsrbEliminr";
            this.btnsrbEliminr.Size = new System.Drawing.Size(209, 64);
            this.btnsrbEliminr.TabIndex = 9;
            this.btnsrbEliminr.Text = "Eliminar";
            this.btnsrbEliminr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsrbEliminr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsrbEliminr.UseVisualStyleBackColor = false;
            this.btnsrbEliminr.Click += new System.EventHandler(this.btnsrbEliminr_Click);
            // 
            // gbRol
            // 
            this.gbRol.Controls.Add(this.rbEmpleado);
            this.gbRol.Controls.Add(this.rbAdmin);
            this.gbRol.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.gbRol.Location = new System.Drawing.Point(28, 411);
            this.gbRol.Name = "gbRol";
            this.gbRol.Size = new System.Drawing.Size(320, 80);
            this.gbRol.TabIndex = 117;
            this.gbRol.TabStop = false;
            this.gbRol.Text = "Rol";
            this.gbRol.Visible = false;
            // 
            // rbEmpleado
            // 
            this.rbEmpleado.AutoSize = true;
            this.rbEmpleado.Checked = true;
            this.rbEmpleado.Location = new System.Drawing.Point(162, 36);
            this.rbEmpleado.Name = "rbEmpleado";
            this.rbEmpleado.Size = new System.Drawing.Size(107, 27);
            this.rbEmpleado.TabIndex = 1;
            this.rbEmpleado.TabStop = true;
            this.rbEmpleado.Text = "Empleado";
            this.rbEmpleado.UseVisualStyleBackColor = true;
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(19, 36);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(81, 27);
            this.rbAdmin.TabIndex = 0;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1081, 517);
            this.ControlBox = false;
            this.Controls.Add(this.gbRol);
            this.Controls.Add(this.btnsrbSalir);
            this.Controls.Add(this.cbsrbConfirmar);
            this.Controls.Add(this.txtsrbUContra);
            this.Controls.Add(this.lblsrbUContra);
            this.Controls.Add(this.lblsrbTitulo);
            this.Controls.Add(this.menusrbTitulo);
            this.Controls.Add(this.txtsrbUUsuario);
            this.Controls.Add(this.txtsrbUAp);
            this.Controls.Add(this.txtsrbUNom);
            this.Controls.Add(this.btnsrbGNuevo);
            this.Controls.Add(this.lblsrbUAp);
            this.Controls.Add(this.txtsrbUId);
            this.Controls.Add(this.lblsrbUUser);
            this.Controls.Add(this.lblsrbUNom);
            this.Controls.Add(this.lblsrbUId);
            this.Controls.Add(this.btnsrbCancelar);
            this.Controls.Add(this.btnsrbAgregar);
            this.Controls.Add(this.btnsrbGuardar);
            this.Controls.Add(this.btnsrbEliminr);
            this.Controls.Add(this.dgsrbUsuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgsrbUsuarios)).EndInit();
            this.gbRol.ResumeLayout(false);
            this.gbRol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgsrbUsuarios;
        private FontAwesome.Sharp.IconButton btnsrbGuardar;
        private FontAwesome.Sharp.IconButton btnsrbEliminr;
        private FontAwesome.Sharp.IconButton btnsrbAgregar;
        private FontAwesome.Sharp.IconButton btnsrbCancelar;
        private System.Windows.Forms.Label lblsrbUAp;
        private System.Windows.Forms.TextBox txtsrbUId;
        private System.Windows.Forms.Label lblsrbUUser;
        private System.Windows.Forms.Label lblsrbUNom;
        private System.Windows.Forms.Label lblsrbUId;
        private FontAwesome.Sharp.IconButton btnsrbGNuevo;
        private System.Windows.Forms.TextBox txtsrbUNom;
        private System.Windows.Forms.TextBox txtsrbUAp;
        private System.Windows.Forms.TextBox txtsrbUUsuario;
        private System.Windows.Forms.Label lblsrbTitulo;
        private System.Windows.Forms.MenuStrip menusrbTitulo;
        private System.Windows.Forms.TextBox txtsrbUContra;
        private System.Windows.Forms.Label lblsrbUContra;
        private System.Windows.Forms.CheckBox cbsrbConfirmar;
        private System.Windows.Forms.Button btnsrbSalir;
        private System.Windows.Forms.GroupBox gbRol;
        private System.Windows.Forms.RadioButton rbEmpleado;
        private System.Windows.Forms.RadioButton rbAdmin;
    }
}