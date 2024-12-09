namespace EDDemo.Algoritmos_de_Busqueda.Forms
{
    partial class frmBinaria
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
            this.lblArreglo = new System.Windows.Forms.Label();
            this.txtArreglo = new System.Windows.Forms.TextBox();
            this.lblObjetivo = new System.Windows.Forms.Label();
            this.txtObjetivo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lstResultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblArreglo
            // 
            this.lblArreglo.AutoSize = true;
            this.lblArreglo.Location = new System.Drawing.Point(18, 16);
            this.lblArreglo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArreglo.Name = "lblArreglo";
            this.lblArreglo.Size = new System.Drawing.Size(107, 13);
            this.lblArreglo.TabIndex = 0;
            this.lblArreglo.Text = "Lista de números:";
            // 
            // txtArreglo
            // 
            this.txtArreglo.Location = new System.Drawing.Point(131, 16);
            this.txtArreglo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtArreglo.Name = "txtArreglo";
            this.txtArreglo.Size = new System.Drawing.Size(176, 20);
            this.txtArreglo.TabIndex = 1;
            // 
            // lblObjetivo
            // 
            this.lblObjetivo.AutoSize = true;
            this.lblObjetivo.Location = new System.Drawing.Point(18, 49);
            this.lblObjetivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblObjetivo.Name = "lblObjetivo";
            this.lblObjetivo.Size = new System.Drawing.Size(58, 13);
            this.lblObjetivo.TabIndex = 2;
            this.lblObjetivo.Text = "Objetivo:";
            // 
            // txtObjetivo
            // 
            this.txtObjetivo.Location = new System.Drawing.Point(131, 49);
            this.txtObjetivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtObjetivo.Name = "txtObjetivo";
            this.txtObjetivo.Size = new System.Drawing.Size(176, 20);
            this.txtObjetivo.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(131, 81);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 24);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lstResultado
            // 
            this.lstResultado.FormattingEnabled = true;
            this.lstResultado.Location = new System.Drawing.Point(18, 122);
            this.lstResultado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(289, 82);
            this.lstResultado.TabIndex = 5;
            // 
            // frmBinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(350, 244);
            this.Controls.Add(this.lstResultado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtObjetivo);
            this.Controls.Add(this.lblObjetivo);
            this.Controls.Add(this.txtArreglo);
            this.Controls.Add(this.lblArreglo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmBinaria";
            this.Text = "Búsqueda Binaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArreglo;
        private System.Windows.Forms.TextBox txtArreglo;
        private System.Windows.Forms.Label lblObjetivo;
        private System.Windows.Forms.TextBox txtObjetivo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListBox lstResultado;
    }
}
