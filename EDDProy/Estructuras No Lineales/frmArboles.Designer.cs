﻿
namespace EDDemo.Estructuras_No_Lineales
{
    partial class frmArboles
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtArbol = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnCrearArbol = new System.Windows.Forms.Button();
            this.txtNodos = new System.Windows.Forms.NumericUpDown();
            this.lblPostOrden = new System.Windows.Forms.Label();
            this.lblRecorridoPostOrden = new System.Windows.Forms.Label();
            this.lblInOrden = new System.Windows.Forms.Label();
            this.lblPreOrden = new System.Windows.Forms.Label();
            this.lblRecorridoInOrden = new System.Windows.Forms.Label();
            this.lblRecorridoPreOrden = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnElmarb = new System.Windows.Forms.Button();
            this.btnPrd = new System.Windows.Forms.Button();
            this.btnSuce = new System.Windows.Forms.Button();
            this.btnAmp = new System.Windows.Forms.Button();
            this.lblAmp = new System.Windows.Forms.Label();
            this.btnAltu = new System.Windows.Forms.Button();
            this.btnConth = new System.Windows.Forms.Button();
            this.btnNodarb = new System.Windows.Forms.Button();
            this.btnComp = new System.Windows.Forms.Button();
            this.btnLlen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(43, 15);
            this.txtDato.Margin = new System.Windows.Forms.Padding(2);
            this.txtDato.Multiline = true;
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(52, 26);
            this.txtDato.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(97, 17);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(62, 24);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Insertar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtArbol
            // 
            this.txtArbol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArbol.Location = new System.Drawing.Point(8, 242);
            this.txtArbol.Margin = new System.Windows.Forms.Padding(2);
            this.txtArbol.Multiline = true;
            this.txtArbol.Name = "txtArbol";
            this.txtArbol.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtArbol.Size = new System.Drawing.Size(558, 301);
            this.txtArbol.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(486, 11);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(62, 24);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGrafica
            // 
            this.btnGrafica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrafica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrafica.Location = new System.Drawing.Point(486, 50);
            this.btnGrafica.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(62, 24);
            this.btnGrafica.TabIndex = 3;
            this.btnGrafica.Text = "Grafica";
            this.btnGrafica.UseVisualStyleBackColor = true;
            this.btnGrafica.Click += new System.EventHandler(this.btnGrafica_Click);
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecorrer.Location = new System.Drawing.Point(423, 177);
            this.btnRecorrer.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(67, 32);
            this.btnRecorrer.TabIndex = 4;
            this.btnRecorrer.Text = "Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(6, 21);
            this.lblDatos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(36, 13);
            this.lblDatos.TabIndex = 5;
            this.lblDatos.Text = "Dato :";
            // 
            // btnCrearArbol
            // 
            this.btnCrearArbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearArbol.Location = new System.Drawing.Point(118, 50);
            this.btnCrearArbol.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearArbol.Name = "btnCrearArbol";
            this.btnCrearArbol.Size = new System.Drawing.Size(62, 34);
            this.btnCrearArbol.TabIndex = 6;
            this.btnCrearArbol.Text = "Crear Árbol";
            this.btnCrearArbol.UseVisualStyleBackColor = true;
            this.btnCrearArbol.Click += new System.EventHandler(this.btnCrearArbol_Click);
            // 
            // txtNodos
            // 
            this.txtNodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNodos.Location = new System.Drawing.Point(40, 54);
            this.txtNodos.Margin = new System.Windows.Forms.Padding(2);
            this.txtNodos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNodos.Name = "txtNodos";
            this.txtNodos.Size = new System.Drawing.Size(60, 24);
            this.txtNodos.TabIndex = 8;
            this.txtNodos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPostOrden
            // 
            this.lblPostOrden.AutoSize = true;
            this.lblPostOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostOrden.Location = new System.Drawing.Point(393, 154);
            this.lblPostOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostOrden.Name = "lblPostOrden";
            this.lblPostOrden.Size = new System.Drawing.Size(70, 13);
            this.lblPostOrden.TabIndex = 9;
            this.lblPostOrden.Text = "PostOrden:";
            // 
            // lblRecorridoPostOrden
            // 
            this.lblRecorridoPostOrden.AutoSize = true;
            this.lblRecorridoPostOrden.Location = new System.Drawing.Point(456, 154);
            this.lblRecorridoPostOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoPostOrden.Name = "lblRecorridoPostOrden";
            this.lblRecorridoPostOrden.Size = new System.Drawing.Size(57, 13);
            this.lblRecorridoPostOrden.TabIndex = 10;
            this.lblRecorridoPostOrden.Text = "PostOrden";
            // 
            // lblInOrden
            // 
            this.lblInOrden.AutoSize = true;
            this.lblInOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInOrden.Location = new System.Drawing.Point(404, 130);
            this.lblInOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInOrden.Name = "lblInOrden";
            this.lblInOrden.Size = new System.Drawing.Size(56, 13);
            this.lblInOrden.TabIndex = 11;
            this.lblInOrden.Text = "InOrden:";
            // 
            // lblPreOrden
            // 
            this.lblPreOrden.AutoSize = true;
            this.lblPreOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreOrden.Location = new System.Drawing.Point(396, 104);
            this.lblPreOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreOrden.Name = "lblPreOrden";
            this.lblPreOrden.Size = new System.Drawing.Size(64, 13);
            this.lblPreOrden.TabIndex = 12;
            this.lblPreOrden.Text = "PreOrden:";
            // 
            // lblRecorridoInOrden
            // 
            this.lblRecorridoInOrden.AutoSize = true;
            this.lblRecorridoInOrden.Location = new System.Drawing.Point(456, 130);
            this.lblRecorridoInOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoInOrden.Name = "lblRecorridoInOrden";
            this.lblRecorridoInOrden.Size = new System.Drawing.Size(57, 13);
            this.lblRecorridoInOrden.TabIndex = 13;
            this.lblRecorridoInOrden.Text = "PostOrden";
            // 
            // lblRecorridoPreOrden
            // 
            this.lblRecorridoPreOrden.AutoSize = true;
            this.lblRecorridoPreOrden.Location = new System.Drawing.Point(456, 104);
            this.lblRecorridoPreOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoPreOrden.Name = "lblRecorridoPreOrden";
            this.lblRecorridoPreOrden.Size = new System.Drawing.Size(57, 13);
            this.lblRecorridoPreOrden.TabIndex = 14;
            this.lblRecorridoPreOrden.Text = "PostOrden";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(118, 91);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(62, 31);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnElmarb
            // 
            this.btnElmarb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElmarb.Location = new System.Drawing.Point(30, 84);
            this.btnElmarb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnElmarb.Name = "btnElmarb";
            this.btnElmarb.Size = new System.Drawing.Size(71, 37);
            this.btnElmarb.TabIndex = 16;
            this.btnElmarb.Text = "Eliminar Árbol";
            this.btnElmarb.UseVisualStyleBackColor = true;
            this.btnElmarb.Click += new System.EventHandler(this.btnElmarb_Click);
            // 
            // btnPrd
            // 
            this.btnPrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrd.Location = new System.Drawing.Point(210, 19);
            this.btnPrd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrd.Name = "btnPrd";
            this.btnPrd.Size = new System.Drawing.Size(92, 38);
            this.btnPrd.TabIndex = 17;
            this.btnPrd.Text = "Eliminar PREDECESOR";
            this.btnPrd.UseVisualStyleBackColor = true;
            this.btnPrd.Click += new System.EventHandler(this.btnPrd_Click);
            // 
            // btnSuce
            // 
            this.btnSuce.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuce.Location = new System.Drawing.Point(306, 19);
            this.btnSuce.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSuce.Name = "btnSuce";
            this.btnSuce.Size = new System.Drawing.Size(92, 38);
            this.btnSuce.TabIndex = 18;
            this.btnSuce.Text = "Eliminar SUCESOR";
            this.btnSuce.UseVisualStyleBackColor = true;
            this.btnSuce.Click += new System.EventHandler(this.btnSuce_Click);
            // 
            // btnAmp
            // 
            this.btnAmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmp.Location = new System.Drawing.Point(169, 207);
            this.btnAmp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAmp.Name = "btnAmp";
            this.btnAmp.Size = new System.Drawing.Size(64, 31);
            this.btnAmp.TabIndex = 19;
            this.btnAmp.Text = "Amplitud";
            this.btnAmp.UseVisualStyleBackColor = true;
            this.btnAmp.Click += new System.EventHandler(this.btnAmp_Click);
            // 
            // lblAmp
            // 
            this.lblAmp.AutoSize = true;
            this.lblAmp.Location = new System.Drawing.Point(247, 216);
            this.lblAmp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmp.Name = "lblAmp";
            this.lblAmp.Size = new System.Drawing.Size(47, 13);
            this.lblAmp.TabIndex = 20;
            this.lblAmp.Text = "Amplitud";
            this.lblAmp.Click += new System.EventHandler(this.lblAmp_Click);
            // 
            // btnAltu
            // 
            this.btnAltu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltu.Location = new System.Drawing.Point(118, 130);
            this.btnAltu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAltu.Name = "btnAltu";
            this.btnAltu.Size = new System.Drawing.Size(62, 47);
            this.btnAltu.TabIndex = 21;
            this.btnAltu.Text = "Altura del Árbol";
            this.btnAltu.UseVisualStyleBackColor = true;
            this.btnAltu.Click += new System.EventHandler(this.btnAltu_Click);
            // 
            // btnConth
            // 
            this.btnConth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConth.Location = new System.Drawing.Point(31, 132);
            this.btnConth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConth.Name = "btnConth";
            this.btnConth.Size = new System.Drawing.Size(69, 35);
            this.btnConth.TabIndex = 22;
            this.btnConth.Text = "Conteo de Hojas";
            this.btnConth.UseVisualStyleBackColor = true;
            this.btnConth.Click += new System.EventHandler(this.btnConth_Click);
            // 
            // btnNodarb
            // 
            this.btnNodarb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNodarb.Location = new System.Drawing.Point(30, 177);
            this.btnNodarb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNodarb.Name = "btnNodarb";
            this.btnNodarb.Size = new System.Drawing.Size(71, 37);
            this.btnNodarb.TabIndex = 23;
            this.btnNodarb.Text = "Nodo del Árbol";
            this.btnNodarb.UseVisualStyleBackColor = true;
            this.btnNodarb.Click += new System.EventHandler(this.btnNodarb_Click);
            // 
            // btnComp
            // 
            this.btnComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComp.Location = new System.Drawing.Point(260, 87);
            this.btnComp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnComp.Name = "btnComp";
            this.btnComp.Size = new System.Drawing.Size(100, 32);
            this.btnComp.TabIndex = 24;
            this.btnComp.Text = "Árbol Completo";
            this.btnComp.UseVisualStyleBackColor = true;
            this.btnComp.Click += new System.EventHandler(this.btnComp_Click);
            // 
            // btnLlen
            // 
            this.btnLlen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLlen.Location = new System.Drawing.Point(260, 124);
            this.btnLlen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLlen.Name = "btnLlen";
            this.btnLlen.Size = new System.Drawing.Size(100, 32);
            this.btnLlen.TabIndex = 25;
            this.btnLlen.Text = "Árbol Lleno";
            this.btnLlen.UseVisualStyleBackColor = true;
            this.btnLlen.Click += new System.EventHandler(this.btnLlen_Click);
            // 
            // frmArboles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(562, 504);
            this.Controls.Add(this.btnLlen);
            this.Controls.Add(this.btnComp);
            this.Controls.Add(this.btnNodarb);
            this.Controls.Add(this.btnConth);
            this.Controls.Add(this.btnAltu);
            this.Controls.Add(this.lblAmp);
            this.Controls.Add(this.btnAmp);
            this.Controls.Add(this.btnSuce);
            this.Controls.Add(this.btnPrd);
            this.Controls.Add(this.btnElmarb);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblRecorridoPreOrden);
            this.Controls.Add(this.lblRecorridoInOrden);
            this.Controls.Add(this.lblPreOrden);
            this.Controls.Add(this.lblInOrden);
            this.Controls.Add(this.lblRecorridoPostOrden);
            this.Controls.Add(this.lblPostOrden);
            this.Controls.Add(this.txtNodos);
            this.Controls.Add(this.btnCrearArbol);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.btnRecorrer);
            this.Controls.Add(this.btnGrafica);
            this.Controls.Add(this.txtArbol);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDato);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmArboles";
            this.Text = "frmArboles";
            this.Load += new System.EventHandler(this.frmArboles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtArbol;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGrafica;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button btnCrearArbol;
        private System.Windows.Forms.NumericUpDown txtNodos;
        private System.Windows.Forms.Label lblPostOrden;
        private System.Windows.Forms.Label lblRecorridoPostOrden;
        private System.Windows.Forms.Label lblInOrden;
        private System.Windows.Forms.Label lblPreOrden;
        private System.Windows.Forms.Label lblRecorridoInOrden;
        private System.Windows.Forms.Label lblRecorridoPreOrden;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnElmarb;
        private System.Windows.Forms.Button btnPrd;
        private System.Windows.Forms.Button btnSuce;
        private System.Windows.Forms.Button btnAmp;
        private System.Windows.Forms.Label lblAmp;
        private System.Windows.Forms.Button btnAltu;
        private System.Windows.Forms.Button btnConth;
        private System.Windows.Forms.Button btnNodarb;
        private System.Windows.Forms.Button btnComp;
        private System.Windows.Forms.Button btnLlen;
    }
}