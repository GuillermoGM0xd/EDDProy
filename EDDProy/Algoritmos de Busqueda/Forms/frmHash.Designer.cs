namespace EDDemo.Algoritmos_de_Busqueda.Forms
{
    partial class frmHash
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblClave = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblBuscarClave = new System.Windows.Forms.Label();
            this.txtBuscarClave = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lstResultado = new System.Windows.Forms.ListBox();
            this.btnCargarArchivo = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(26, 24);
            this.lblClave.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(43, 13);
            this.lblClave.TabIndex = 0;
            this.lblClave.Text = "Clave:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(26, 57);
            this.lblValor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(40, 13);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "Valor:";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(88, 24);
            this.txtClave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(132, 20);
            this.txtClave.TabIndex = 2;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(88, 57);
            this.txtValor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(132, 20);
            this.txtValor.TabIndex = 3;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(236, 41);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(88, 24);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblBuscarClave
            // 
            this.lblBuscarClave.AutoSize = true;
            this.lblBuscarClave.Location = new System.Drawing.Point(26, 98);
            this.lblBuscarClave.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscarClave.Name = "lblBuscarClave";
            this.lblBuscarClave.Size = new System.Drawing.Size(86, 13);
            this.lblBuscarClave.TabIndex = 5;
            this.lblBuscarClave.Text = "Buscar Clave:";
            // 
            // txtBuscarClave
            // 
            this.txtBuscarClave.Location = new System.Drawing.Point(114, 98);
            this.txtBuscarClave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscarClave.Name = "txtBuscarClave";
            this.txtBuscarClave.Size = new System.Drawing.Size(106, 20);
            this.txtBuscarClave.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(236, 93);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 24);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lstResultado
            // 
            this.lstResultado.FormattingEnabled = true;
            this.lstResultado.Location = new System.Drawing.Point(26, 130);
            this.lstResultado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(298, 82);
            this.lstResultado.TabIndex = 8;
            // 
            // btnCargarArchivo
            // 
            this.btnCargarArchivo.Location = new System.Drawing.Point(26, 228);
            this.btnCargarArchivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCargarArchivo.Name = "btnCargarArchivo";
            this.btnCargarArchivo.Size = new System.Drawing.Size(131, 24);
            this.btnCargarArchivo.TabIndex = 9;
            this.btnCargarArchivo.Text = "Cargar Archivo";
            this.btnCargarArchivo.UseVisualStyleBackColor = true;
            this.btnCargarArchivo.Click += new System.EventHandler(this.btnCargarArchivo_Click);
            // 
            // frmHash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(350, 284);
            this.Controls.Add(this.btnCargarArchivo);
            this.Controls.Add(this.lstResultado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscarClave);
            this.Controls.Add(this.lblBuscarClave);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblClave);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmHash";
            this.Text = "Hash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblBuscarClave;
        private System.Windows.Forms.TextBox txtBuscarClave;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListBox lstResultado;
        private System.Windows.Forms.Button btnCargarArchivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}
