namespace PryCantallopsIEFI
{
    partial class frmPais
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
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.mrcPais = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.mrcPais.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(136, 26);
            this.txtCod.MaxLength = 3;
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 0;
            this.txtCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCod_KeyPress);
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(136, 52);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(100, 20);
            this.txtPais.TabIndex = 1;
            this.txtPais.TextChanged += new System.EventHandler(this.txtPais_TextChanged);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.ForeColor = System.Drawing.Color.Black;
            this.lblCodigo.Location = new System.Drawing.Point(52, 29);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(78, 13);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Codigo de Pais";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.ForeColor = System.Drawing.Color.Black;
            this.lblPais.Location = new System.Drawing.Point(48, 55);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(82, 13);
            this.lblPais.TabIndex = 3;
            this.lblPais.Text = "Nombre de Pais";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(7, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(297, 29);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "AGREGAR NUEVO PAIS";
            // 
            // mrcPais
            // 
            this.mrcPais.Controls.Add(this.btnBorrar);
            this.mrcPais.Controls.Add(this.lblCodigo);
            this.mrcPais.Controls.Add(this.btnRegistro);
            this.mrcPais.Controls.Add(this.txtCod);
            this.mrcPais.Controls.Add(this.lblPais);
            this.mrcPais.Controls.Add(this.txtPais);
            this.mrcPais.Location = new System.Drawing.Point(12, 76);
            this.mrcPais.Name = "mrcPais";
            this.mrcPais.Size = new System.Drawing.Size(278, 123);
            this.mrcPais.TabIndex = 5;
            this.mrcPais.TabStop = false;
            this.mrcPais.Text = "COMPLETE LOS SIGUIENTES DATOS";
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Red;
            this.btnBorrar.Location = new System.Drawing.Point(136, 84);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(112, 30);
            this.btnBorrar.TabIndex = 20;
            this.btnBorrar.Text = "Salir";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRegistro.Enabled = false;
            this.btnRegistro.Location = new System.Drawing.Point(18, 84);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(112, 30);
            this.btnRegistro.TabIndex = 19;
            this.btnRegistro.Text = "Registrar pais";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // frmPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(302, 211);
            this.Controls.Add(this.mrcPais);
            this.Controls.Add(this.lblTitulo);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "frmPais";
            this.Text = "NUEVO PAIS";
            this.Load += new System.EventHandler(this.frmPais_Load);
            this.mrcPais.ResumeLayout(false);
            this.mrcPais.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox mrcPais;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnRegistro;
    }
}