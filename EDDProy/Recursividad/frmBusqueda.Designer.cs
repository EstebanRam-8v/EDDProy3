namespace EDDemo
{
    partial class frmBusqueda
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
            this.txtBinario = new System.Windows.Forms.TextBox();
            this.BtnBuscarBi = new System.Windows.Forms.Button();
            this.LbTiempo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscarBi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos:";
            // 
            // txtBinario
            // 
            this.txtBinario.Location = new System.Drawing.Point(72, 84);
            this.txtBinario.Name = "txtBinario";
            this.txtBinario.Size = new System.Drawing.Size(372, 20);
            this.txtBinario.TabIndex = 1;
            // 
            // BtnBuscarBi
            // 
            this.BtnBuscarBi.Location = new System.Drawing.Point(34, 122);
            this.BtnBuscarBi.Name = "BtnBuscarBi";
            this.BtnBuscarBi.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscarBi.TabIndex = 2;
            this.BtnBuscarBi.Text = "Buscar";
            this.BtnBuscarBi.UseVisualStyleBackColor = true;
            this.BtnBuscarBi.Click += new System.EventHandler(this.BtnBuscarBi_Click);
            // 
            // LbTiempo
            // 
            this.LbTiempo.AutoSize = true;
            this.LbTiempo.Location = new System.Drawing.Point(34, 46);
            this.LbTiempo.Name = "LbTiempo";
            this.LbTiempo.Size = new System.Drawing.Size(48, 13);
            this.LbTiempo.TabIndex = 3;
            this.LbTiempo.Text = "Tiempo: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Complejidad: O(lon n)";
            // 
            // txtBuscarBi
            // 
            this.txtBuscarBi.Location = new System.Drawing.Point(115, 124);
            this.txtBuscarBi.Name = "txtBuscarBi";
            this.txtBuscarBi.Size = new System.Drawing.Size(101, 20);
            this.txtBuscarBi.TabIndex = 6;
            // 
            // frmBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBuscarBi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LbTiempo);
            this.Controls.Add(this.BtnBuscarBi);
            this.Controls.Add(this.txtBinario);
            this.Controls.Add(this.label1);
            this.Name = "frmBusqueda";
            this.Text = "frmBusqueda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBinario;
        private System.Windows.Forms.Button BtnBuscarBi;
        private System.Windows.Forms.Label LbTiempo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscarBi;
    }
}