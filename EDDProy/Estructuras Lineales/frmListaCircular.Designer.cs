namespace EDDemo
{
    partial class frmListaCircular
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
            this.BtnCrear = new System.Windows.Forms.Button();
            this.BtnInser = new System.Windows.Forms.Button();
            this.BtnVer = new System.Windows.Forms.Button();
            this.BtnBus = new System.Windows.Forms.Button();
            this.BtnModi = new System.Windows.Forms.Button();
            this.BtnElim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDaCircular = new System.Windows.Forms.TextBox();
            this.txtModi = new System.Windows.Forms.TextBox();
            this.txtMostrarr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCrear
            // 
            this.BtnCrear.Location = new System.Drawing.Point(45, 53);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(75, 23);
            this.BtnCrear.TabIndex = 0;
            this.BtnCrear.Text = "Crear Lista";
            this.BtnCrear.UseVisualStyleBackColor = true;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // BtnInser
            // 
            this.BtnInser.Location = new System.Drawing.Point(45, 142);
            this.BtnInser.Name = "BtnInser";
            this.BtnInser.Size = new System.Drawing.Size(75, 23);
            this.BtnInser.TabIndex = 1;
            this.BtnInser.Text = "Insertar";
            this.BtnInser.UseVisualStyleBackColor = true;
            this.BtnInser.Click += new System.EventHandler(this.BtnInser_Click);
            // 
            // BtnVer
            // 
            this.BtnVer.Location = new System.Drawing.Point(142, 142);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(75, 23);
            this.BtnVer.TabIndex = 2;
            this.BtnVer.Text = "Ver lista";
            this.BtnVer.UseVisualStyleBackColor = true;
            this.BtnVer.Click += new System.EventHandler(this.BtnVer_Click);
            // 
            // BtnBus
            // 
            this.BtnBus.Location = new System.Drawing.Point(232, 142);
            this.BtnBus.Name = "BtnBus";
            this.BtnBus.Size = new System.Drawing.Size(75, 23);
            this.BtnBus.TabIndex = 3;
            this.BtnBus.Text = "Buscar";
            this.BtnBus.UseVisualStyleBackColor = true;
            this.BtnBus.Click += new System.EventHandler(this.BtnBus_Click);
            // 
            // BtnModi
            // 
            this.BtnModi.Location = new System.Drawing.Point(322, 142);
            this.BtnModi.Name = "BtnModi";
            this.BtnModi.Size = new System.Drawing.Size(75, 23);
            this.BtnModi.TabIndex = 4;
            this.BtnModi.Text = "Modificar";
            this.BtnModi.UseVisualStyleBackColor = true;
            this.BtnModi.Click += new System.EventHandler(this.BtnModi_Click);
            // 
            // BtnElim
            // 
            this.BtnElim.Location = new System.Drawing.Point(403, 142);
            this.BtnElim.Name = "BtnElim";
            this.BtnElim.Size = new System.Drawing.Size(75, 23);
            this.BtnElim.TabIndex = 5;
            this.BtnElim.Text = "Eliminar";
            this.BtnElim.UseVisualStyleBackColor = true;
            this.BtnElim.Click += new System.EventHandler(this.BtnElim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingresar Dato:";
            // 
            // txtDaCircular
            // 
            this.txtDaCircular.Location = new System.Drawing.Point(122, 98);
            this.txtDaCircular.Name = "txtDaCircular";
            this.txtDaCircular.Size = new System.Drawing.Size(100, 20);
            this.txtDaCircular.TabIndex = 7;
            // 
            // txtModi
            // 
            this.txtModi.Location = new System.Drawing.Point(312, 98);
            this.txtModi.Name = "txtModi";
            this.txtModi.Size = new System.Drawing.Size(100, 20);
            this.txtModi.TabIndex = 8;
            this.txtModi.TextChanged += new System.EventHandler(this.txtModi_TextChanged);
            // 
            // txtMostrarr
            // 
            this.txtMostrarr.Location = new System.Drawing.Point(34, 191);
            this.txtMostrarr.Name = "txtMostrarr";
            this.txtMostrarr.Size = new System.Drawing.Size(444, 20);
            this.txtMostrarr.TabIndex = 9;
            // 
            // frmListaCircular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMostrarr);
            this.Controls.Add(this.txtModi);
            this.Controls.Add(this.txtDaCircular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnElim);
            this.Controls.Add(this.BtnModi);
            this.Controls.Add(this.BtnBus);
            this.Controls.Add(this.BtnVer);
            this.Controls.Add(this.BtnInser);
            this.Controls.Add(this.BtnCrear);
            this.Name = "frmListaCircular";
            this.Text = "frmListaCircular";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCrear;
        private System.Windows.Forms.Button BtnInser;
        private System.Windows.Forms.Button BtnVer;
        private System.Windows.Forms.Button BtnBus;
        private System.Windows.Forms.Button BtnModi;
        private System.Windows.Forms.Button BtnElim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDaCircular;
        private System.Windows.Forms.TextBox txtModi;
        private System.Windows.Forms.TextBox txtMostrarr;
    }
}