namespace proy_u4
{
    partial class frmPresentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPresentacion));
            this.timersrbTimer = new System.Windows.Forms.Timer(this.components);
            this.pbarsrbBarra = new System.Windows.Forms.ProgressBar();
            this.psrb1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lblsrbSistema = new System.Windows.Forms.Label();
            this.psrb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timersrbTimer
            // 
            this.timersrbTimer.Tick += new System.EventHandler(this.timersrbTimer_Tick);
            // 
            // pbarsrbBarra
            // 
            this.pbarsrbBarra.BackColor = System.Drawing.Color.Snow;
            this.pbarsrbBarra.Location = new System.Drawing.Point(0, 257);
            this.pbarsrbBarra.Name = "pbarsrbBarra";
            this.pbarsrbBarra.Size = new System.Drawing.Size(557, 47);
            this.pbarsrbBarra.TabIndex = 0;
            // 
            // psrb1
            // 
            this.psrb1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.psrb1.Controls.Add(this.pbarsrbBarra);
            this.psrb1.Controls.Add(this.label1);
            this.psrb1.Controls.Add(this.iconPictureBox1);
            this.psrb1.Controls.Add(this.lblsrbSistema);
            this.psrb1.Location = new System.Drawing.Point(1, 3);
            this.psrb1.Name = "psrb1";
            this.psrb1.Size = new System.Drawing.Size(557, 307);
            this.psrb1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(293, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sonia Romero & Jair Jaramillo";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Snow;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Shop;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Snow;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 212;
            this.iconPictureBox1.Location = new System.Drawing.Point(61, 26);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(220, 212);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // lblsrbSistema
            // 
            this.lblsrbSistema.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lblsrbSistema.Font = new System.Drawing.Font("Bahnschrift Condensed", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsrbSistema.ForeColor = System.Drawing.Color.White;
            this.lblsrbSistema.Location = new System.Drawing.Point(288, 36);
            this.lblsrbSistema.Name = "lblsrbSistema";
            this.lblsrbSistema.Size = new System.Drawing.Size(183, 178);
            this.lblsrbSistema.TabIndex = 0;
            this.lblsrbSistema.Text = "SISTEMA DE VENTAS MINISHOP\r\n";
            // 
            // frmPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 307);
            this.ControlBox = false;
            this.Controls.Add(this.psrb1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPresentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPresentacion_Load);
            this.psrb1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timersrbTimer;
        private System.Windows.Forms.ProgressBar pbarsrbBarra;
        private System.Windows.Forms.Panel psrb1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblsrbSistema;
    }
}