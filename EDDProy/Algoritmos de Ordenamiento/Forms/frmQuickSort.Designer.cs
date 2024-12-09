namespace EDDemo.Algoritmos_de_Ordenamiento.Forms
{
    partial class frmQuickSort
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
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.lblIngresarDatos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(44, 41);
            this.txtDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(176, 20);
            this.txtDatos.TabIndex = 0;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(245, 41);
            this.btnOrdenar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(88, 19);
            this.btnOrdenar.TabIndex = 1;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.Location = new System.Drawing.Point(44, 81);
            this.lstResultados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(289, 147);
            this.lstResultados.TabIndex = 2;
            // 
            // lblIngresarDatos
            // 
            this.lblIngresarDatos.AutoSize = true;
            this.lblIngresarDatos.Location = new System.Drawing.Point(44, 16);
            this.lblIngresarDatos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIngresarDatos.Name = "lblIngresarDatos";
            this.lblIngresarDatos.Size = new System.Drawing.Size(222, 13);
            this.lblIngresarDatos.TabIndex = 3;
            this.lblIngresarDatos.Text = "Ingrese números separados por coma:";
            // 
            // frmQuickSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(394, 284);
            this.Controls.Add(this.lblIngresarDatos);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.txtDatos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmQuickSort";
            this.Text = "QuickSort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.Label lblIngresarDatos;
    }
}
