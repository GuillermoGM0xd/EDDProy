using System.Windows.Forms;

namespace EDDemo.Algoritmos_de_Recursividad.Forms
{
    partial class frmRecursividad
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbAlgoritmos = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblResultados = new System.Windows.Forms.Label();
            this.lblTituloTiempo = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblTituloComplejidad = new System.Windows.Forms.Label();
            this.lblComplejidad = new System.Windows.Forms.Label();
            this.lblInput1 = new System.Windows.Forms.Label();
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.lblInput2 = new System.Windows.Forms.Label();
            this.lblAlgoritmo = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbAlgoritmos
            // 
            this.cmbAlgoritmos.FormattingEnabled = true;
            this.cmbAlgoritmos.Location = new System.Drawing.Point(88, 16);
            this.cmbAlgoritmos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbAlgoritmos.Name = "cmbAlgoritmos";
            this.cmbAlgoritmos.Size = new System.Drawing.Size(128, 21);
            this.cmbAlgoritmos.TabIndex = 0;
            this.cmbAlgoritmos.SelectedIndexChanged += new System.EventHandler(this.cmbAlgoritmos_SelectedIndexChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(122, 114);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(65, 19);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Location = new System.Drawing.Point(400, 7);
            this.lblResultados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(74, 13);
            this.lblResultados.TabIndex = 8;
            this.lblResultados.Text = "Resultados:";
            // 
            // lblTituloTiempo
            // 
            this.lblTituloTiempo.AutoSize = true;
            this.lblTituloTiempo.Location = new System.Drawing.Point(18, 228);
            this.lblTituloTiempo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloTiempo.Name = "lblTituloTiempo";
            this.lblTituloTiempo.Size = new System.Drawing.Size(126, 13);
            this.lblTituloTiempo.TabIndex = 9;
            this.lblTituloTiempo.Text = "Tiempo de Ejecución";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(35, 252);
            this.lblTiempo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(64, 13);
            this.lblTiempo.TabIndex = 10;
            this.lblTiempo.Text = "Tiempo: --";
            // 
            // lblTituloComplejidad
            // 
            this.lblTituloComplejidad.AutoSize = true;
            this.lblTituloComplejidad.Location = new System.Drawing.Point(18, 284);
            this.lblTituloComplejidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloComplejidad.Name = "lblTituloComplejidad";
            this.lblTituloComplejidad.Size = new System.Drawing.Size(79, 13);
            this.lblTituloComplejidad.TabIndex = 11;
            this.lblTituloComplejidad.Text = "Complejidad:";
            // 
            // lblComplejidad
            // 
            this.lblComplejidad.AutoSize = true;
            this.lblComplejidad.Location = new System.Drawing.Point(35, 309);
            this.lblComplejidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComplejidad.Name = "lblComplejidad";
            this.lblComplejidad.Size = new System.Drawing.Size(87, 13);
            this.lblComplejidad.TabIndex = 12;
            this.lblComplejidad.Text = "Complejidad --";
            // 
            // lblInput1
            // 
            this.lblInput1.AutoSize = true;
            this.lblInput1.Location = new System.Drawing.Point(18, 49);
            this.lblInput1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInput1.Name = "lblInput1";
            this.lblInput1.Size = new System.Drawing.Size(66, 13);
            this.lblInput1.TabIndex = 13;
            this.lblInput1.Text = "Entrada 1:";
            // 
            // txtInput1
            // 
            this.txtInput1.Location = new System.Drawing.Point(88, 49);
            this.txtInput1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(88, 20);
            this.txtInput1.TabIndex = 14;
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(174, 81);
            this.txtInput2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(88, 20);
            this.txtInput2.TabIndex = 15;
            // 
            // lblInput2
            // 
            this.lblInput2.AutoSize = true;
            this.lblInput2.Location = new System.Drawing.Point(18, 81);
            this.lblInput2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInput2.Name = "lblInput2";
            this.lblInput2.Size = new System.Drawing.Size(66, 13);
            this.lblInput2.TabIndex = 16;
            this.lblInput2.Text = "Entrada 2:";
            // 
            // lblAlgoritmo
            // 
            this.lblAlgoritmo.AutoSize = true;
            this.lblAlgoritmo.Location = new System.Drawing.Point(18, 16);
            this.lblAlgoritmo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlgoritmo.Name = "lblAlgoritmo";
            this.lblAlgoritmo.Size = new System.Drawing.Size(59, 13);
            this.lblAlgoritmo.TabIndex = 17;
            this.lblAlgoritmo.Text = "Algoritmo";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(18, 114);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(65, 19);
            this.btnCalcular.TabIndex = 18;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmRecursividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(700, 366);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblAlgoritmo);
            this.Controls.Add(this.lblInput2);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.txtInput1);
            this.Controls.Add(this.lblInput1);
            this.Controls.Add(this.lblComplejidad);
            this.Controls.Add(this.lblTituloComplejidad);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblTituloTiempo);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cmbAlgoritmos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRecursividad";
            this.Text = "frmRecursividad";
            this.Load += new System.EventHandler(this.frmRecursividad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAlgoritmos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.Label lblTituloTiempo;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblTituloComplejidad;
        private System.Windows.Forms.Label lblComplejidad;
        private System.Windows.Forms.Label lblInput1;
        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.Label lblInput2;
        private System.Windows.Forms.Label lblAlgoritmo;
        private System.Windows.Forms.Button btnCalcular;
    }
}
