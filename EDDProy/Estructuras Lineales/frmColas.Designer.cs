namespace EDDemo
{
    partial class frmColas
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
            this.LbColas = new System.Windows.Forms.Label();
            this.txtColas = new System.Windows.Forms.TextBox();
            this.Btningresar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.LbContenido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LbColas
            // 
            this.LbColas.AutoSize = true;
            this.LbColas.Location = new System.Drawing.Point(58, 119);
            this.LbColas.Name = "LbColas";
            this.LbColas.Size = new System.Drawing.Size(69, 13);
            this.LbColas.TabIndex = 0;
            this.LbColas.Text = "Ingresar dato";
            // 
            // txtColas
            // 
            this.txtColas.Location = new System.Drawing.Point(162, 116);
            this.txtColas.Name = "txtColas";
            this.txtColas.Size = new System.Drawing.Size(100, 20);
            this.txtColas.TabIndex = 1;
            // 
            // Btningresar
            // 
            this.Btningresar.Location = new System.Drawing.Point(31, 53);
            this.Btningresar.Name = "Btningresar";
            this.Btningresar.Size = new System.Drawing.Size(75, 23);
            this.Btningresar.TabIndex = 2;
            this.Btningresar.Text = "Agregar";
            this.Btningresar.UseVisualStyleBackColor = true;
            this.Btningresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(121, 53);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 3;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(216, 53);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 4;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(311, 53);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 5;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // LbContenido
            // 
            this.LbContenido.AutoSize = true;
            this.LbContenido.Location = new System.Drawing.Point(159, 160);
            this.LbContenido.Name = "LbContenido";
            this.LbContenido.Size = new System.Drawing.Size(35, 13);
            this.LbContenido.TabIndex = 6;
            this.LbContenido.Text = "label1";
            // 
            // frmColas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LbContenido);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.Btningresar);
            this.Controls.Add(this.txtColas);
            this.Controls.Add(this.LbColas);
            this.Name = "frmColas";
            this.Text = "frmColas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbColas;
        private System.Windows.Forms.TextBox txtColas;
        private System.Windows.Forms.Button Btningresar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Label LbContenido;
    }
}