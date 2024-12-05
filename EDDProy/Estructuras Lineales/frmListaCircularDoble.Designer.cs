namespace EDDemo
{
    partial class frmListaCircularDoble
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIngresar = new System.Windows.Forms.TextBox();
            this.txtListaMos = new System.Windows.Forms.TextBox();
            this.BtnCrearDo = new System.Windows.Forms.Button();
            this.BtnInsertarDo = new System.Windows.Forms.Button();
            this.BtnVerlist = new System.Windows.Forms.Button();
            this.BtnBuscarDo = new System.Windows.Forms.Button();
            this.BtnEliminarDo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mostrar Lista";
            // 
            // txtIngresar
            // 
            this.txtIngresar.Location = new System.Drawing.Point(28, 69);
            this.txtIngresar.Name = "txtIngresar";
            this.txtIngresar.Size = new System.Drawing.Size(102, 20);
            this.txtIngresar.TabIndex = 2;
            // 
            // txtListaMos
            // 
            this.txtListaMos.Location = new System.Drawing.Point(12, 140);
            this.txtListaMos.Name = "txtListaMos";
            this.txtListaMos.Size = new System.Drawing.Size(238, 20);
            this.txtListaMos.TabIndex = 3;
            // 
            // BtnCrearDo
            // 
            this.BtnCrearDo.Location = new System.Drawing.Point(275, 61);
            this.BtnCrearDo.Name = "BtnCrearDo";
            this.BtnCrearDo.Size = new System.Drawing.Size(59, 35);
            this.BtnCrearDo.TabIndex = 4;
            this.BtnCrearDo.Text = "Crear Lista";
            this.BtnCrearDo.UseVisualStyleBackColor = true;
            this.BtnCrearDo.Click += new System.EventHandler(this.BtnCrearDo_Click);
            // 
            // BtnInsertarDo
            // 
            this.BtnInsertarDo.Location = new System.Drawing.Point(340, 61);
            this.BtnInsertarDo.Name = "BtnInsertarDo";
            this.BtnInsertarDo.Size = new System.Drawing.Size(59, 35);
            this.BtnInsertarDo.TabIndex = 5;
            this.BtnInsertarDo.Text = "Insertar";
            this.BtnInsertarDo.UseVisualStyleBackColor = true;
            this.BtnInsertarDo.Click += new System.EventHandler(this.BtnInsertarDo_Click);
            // 
            // BtnVerlist
            // 
            this.BtnVerlist.Location = new System.Drawing.Point(405, 61);
            this.BtnVerlist.Name = "BtnVerlist";
            this.BtnVerlist.Size = new System.Drawing.Size(59, 35);
            this.BtnVerlist.TabIndex = 6;
            this.BtnVerlist.Text = "Ver lista";
            this.BtnVerlist.UseVisualStyleBackColor = true;
            this.BtnVerlist.Click += new System.EventHandler(this.BtnVerlist_Click);
            // 
            // BtnBuscarDo
            // 
            this.BtnBuscarDo.Location = new System.Drawing.Point(470, 61);
            this.BtnBuscarDo.Name = "BtnBuscarDo";
            this.BtnBuscarDo.Size = new System.Drawing.Size(59, 35);
            this.BtnBuscarDo.TabIndex = 7;
            this.BtnBuscarDo.Text = "Buscar Dato";
            this.BtnBuscarDo.UseVisualStyleBackColor = true;
            this.BtnBuscarDo.Click += new System.EventHandler(this.BtnBuscarDo_Click);
            // 
            // BtnEliminarDo
            // 
            this.BtnEliminarDo.Location = new System.Drawing.Point(535, 61);
            this.BtnEliminarDo.Name = "BtnEliminarDo";
            this.BtnEliminarDo.Size = new System.Drawing.Size(59, 35);
            this.BtnEliminarDo.TabIndex = 8;
            this.BtnEliminarDo.Text = "Eliminar";
            this.BtnEliminarDo.UseVisualStyleBackColor = true;
            this.BtnEliminarDo.Click += new System.EventHandler(this.BtnEliminarDo_Click);
            // 
            // frmListaCircularDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnEliminarDo);
            this.Controls.Add(this.BtnBuscarDo);
            this.Controls.Add(this.BtnVerlist);
            this.Controls.Add(this.BtnInsertarDo);
            this.Controls.Add(this.BtnCrearDo);
            this.Controls.Add(this.txtListaMos);
            this.Controls.Add(this.txtIngresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmListaCircularDoble";
            this.Text = "frmListaCircularDoble";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIngresar;
        private System.Windows.Forms.TextBox txtListaMos;
        private System.Windows.Forms.Button BtnCrearDo;
        private System.Windows.Forms.Button BtnInsertarDo;
        private System.Windows.Forms.Button BtnVerlist;
        private System.Windows.Forms.Button BtnBuscarDo;
        private System.Windows.Forms.Button BtnEliminarDo;
    }
}