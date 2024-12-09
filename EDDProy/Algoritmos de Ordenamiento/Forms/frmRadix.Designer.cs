namespace EDDemo.Algoritmos_de_Ordenamiento.Forms
{
    partial class frmRadix
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

        private void InitializeComponent()
        {
            this.txtArreglo = new System.Windows.Forms.TextBox();
            this.lblArreglo = new System.Windows.Forms.Label();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.lstResultado = new System.Windows.Forms.ListBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtArreglo
            // 
            this.txtArreglo.Location = new System.Drawing.Point(121, 24);
            this.txtArreglo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtArreglo.Name = "txtArreglo";
            this.txtArreglo.Size = new System.Drawing.Size(176, 20);
            this.txtArreglo.TabIndex = 0;
            // 
            // lblArreglo
            // 
            this.lblArreglo.AutoSize = true;
            this.lblArreglo.Location = new System.Drawing.Point(26, 27);
            this.lblArreglo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArreglo.Name = "lblArreglo";
            this.lblArreglo.Size = new System.Drawing.Size(97, 13);
            this.lblArreglo.TabIndex = 1;
            this.lblArreglo.Text = "Ingrese Arreglo:";
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(121, 57);
            this.btnOrdenar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(65, 19);
            this.btnOrdenar.TabIndex = 2;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // lstResultado
            // 
            this.lstResultado.FormattingEnabled = true;
            this.lstResultado.Location = new System.Drawing.Point(121, 98);
            this.lstResultado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(176, 108);
            this.lstResultado.TabIndex = 3;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(26, 98);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(68, 13);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado:";
            // 
            // frmRadix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(350, 244);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lstResultado);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.lblArreglo);
            this.Controls.Add(this.txtArreglo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRadix";
            this.Text = "Radix Sort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtArreglo;
        private System.Windows.Forms.Label lblArreglo;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.ListBox lstResultado;
        private System.Windows.Forms.Label lblResultado;
    }
}

