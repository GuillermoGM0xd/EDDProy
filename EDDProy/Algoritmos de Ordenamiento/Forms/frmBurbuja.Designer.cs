namespace EDDemo.Algoritmos_de_Ordenamiento.Forms
{
    partial class frmBurbuja
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
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.lblIngresarNumeros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(131, 41);
            this.txtNumeros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(263, 20);
            this.txtNumeros.TabIndex = 0;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(131, 81);
            this.btnOrdenar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(88, 24);
            this.btnOrdenar.TabIndex = 1;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.Location = new System.Drawing.Point(131, 122);
            this.lstResultados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(263, 82);
            this.lstResultados.TabIndex = 2;
            // 
            // lblIngresarNumeros
            // 
            this.lblIngresarNumeros.AutoSize = true;
            this.lblIngresarNumeros.Location = new System.Drawing.Point(131, 24);
            this.lblIngresarNumeros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIngresarNumeros.Name = "lblIngresarNumeros";
            this.lblIngresarNumeros.Size = new System.Drawing.Size(228, 13);
            this.lblIngresarNumeros.TabIndex = 3;
            this.lblIngresarNumeros.Text = "Ingrese números separados por comas:";
            // 
            // frmBurbuja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(525, 244);
            this.Controls.Add(this.lblIngresarNumeros);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.txtNumeros);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmBurbuja";
            this.Text = "Ordenamiento Burbuja";
            this.Load += new System.EventHandler(this.frmBurbuja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.Label lblIngresarNumeros;
    }
}
