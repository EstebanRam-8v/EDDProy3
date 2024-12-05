namespace EDDemo
{
    partial class frmListas
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
            this.BtnAgregar2 = new System.Windows.Forms.Button();
            this.BtnEliminar2 = new System.Windows.Forms.Button();
            this.BtnBuscar2 = new System.Windows.Forms.Button();
            this.BtnLimpiar2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.LbMostrar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAgregar2
            // 
            this.BtnAgregar2.Location = new System.Drawing.Point(41, 70);
            this.BtnAgregar2.Name = "BtnAgregar2";
            this.BtnAgregar2.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar2.TabIndex = 0;
            this.BtnAgregar2.Text = "Agregar";
            this.BtnAgregar2.UseVisualStyleBackColor = true;
            this.BtnAgregar2.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnEliminar2
            // 
            this.BtnEliminar2.Location = new System.Drawing.Point(140, 70);
            this.BtnEliminar2.Name = "BtnEliminar2";
            this.BtnEliminar2.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar2.TabIndex = 1;
            this.BtnEliminar2.Text = "Eliminar";
            this.BtnEliminar2.UseVisualStyleBackColor = true;
            this.BtnEliminar2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnBuscar2
            // 
            this.BtnBuscar2.Location = new System.Drawing.Point(236, 70);
            this.BtnBuscar2.Name = "BtnBuscar2";
            this.BtnBuscar2.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar2.TabIndex = 2;
            this.BtnBuscar2.Text = "Buscar";
            this.BtnBuscar2.UseVisualStyleBackColor = true;
            this.BtnBuscar2.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnLimpiar2
            // 
            this.BtnLimpiar2.Location = new System.Drawing.Point(336, 70);
            this.BtnLimpiar2.Name = "BtnLimpiar2";
            this.BtnLimpiar2.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar2.TabIndex = 3;
            this.BtnLimpiar2.Text = "Limpiar";
            this.BtnLimpiar2.UseVisualStyleBackColor = true;
            this.BtnLimpiar2.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese datos";
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(115, 126);
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(100, 20);
            this.txtLista.TabIndex = 5;
            // 
            // LbMostrar
            // 
            this.LbMostrar.AutoSize = true;
            this.LbMostrar.Location = new System.Drawing.Point(38, 180);
            this.LbMostrar.Name = "LbMostrar";
            this.LbMostrar.Size = new System.Drawing.Size(35, 13);
            this.LbMostrar.TabIndex = 6;
            this.LbMostrar.Text = "label2";
            // 
            // frmListas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LbMostrar);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLimpiar2);
            this.Controls.Add(this.BtnBuscar2);
            this.Controls.Add(this.BtnEliminar2);
            this.Controls.Add(this.BtnAgregar2);
            this.Name = "frmListas";
            this.Text = "frmListas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAgregar2;
        private System.Windows.Forms.Button BtnEliminar2;
        private System.Windows.Forms.Button BtnBuscar2;
        private System.Windows.Forms.Button BtnLimpiar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.Label LbMostrar;
    }
}