namespace EDDemo.Estructuras_Lineales.Forms
{
    partial class frmListaCircularSimple
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
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lstListaCircular = new System.Windows.Forms.ListBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtPosicion = new System.Windows.Forms.TextBox();
            this.lblDato = new System.Windows.Forms.Label();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(38, 24);
            this.txtDato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(76, 20);
            this.txtDato.TabIndex = 0;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(128, 24);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(68, 19);
            this.btnInsertar.TabIndex = 1;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(128, 57);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(68, 19);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lstListaCircular
            // 
            this.lstListaCircular.FormattingEnabled = true;
            this.lstListaCircular.Location = new System.Drawing.Point(38, 98);
            this.lstListaCircular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstListaCircular.Name = "lstListaCircular";
            this.lstListaCircular.Size = new System.Drawing.Size(147, 82);
            this.lstListaCircular.TabIndex = 3;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(128, 199);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(56, 19);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtPosicion
            // 
            this.txtPosicion.Location = new System.Drawing.Point(38, 200);
            this.txtPosicion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.Size = new System.Drawing.Size(76, 20);
            this.txtPosicion.TabIndex = 5;
            // 
            // lblDato
            // 
            this.lblDato.AutoSize = true;
            this.lblDato.Location = new System.Drawing.Point(38, 8);
            this.lblDato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDato.Name = "lblDato";
            this.lblDato.Size = new System.Drawing.Size(33, 13);
            this.lblDato.TabIndex = 6;
            this.lblDato.Text = "Dato:";
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Location = new System.Drawing.Point(38, 181);
            this.lblPosicion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(50, 13);
            this.lblPosicion.TabIndex = 7;
            this.lblPosicion.Text = "Posición:";
            // 
            // frmListaCircularSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(225, 244);
            this.Controls.Add(this.lblPosicion);
            this.Controls.Add(this.lblDato);
            this.Controls.Add(this.txtPosicion);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lstListaCircular);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtDato);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmListaCircularSimple";
            this.Text = "Lista Circular Simple";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ListBox lstListaCircular;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtPosicion;
        private System.Windows.Forms.Label lblDato;
        private System.Windows.Forms.Label lblPosicion;
    }
}
