namespace EDDemo
{
    partial class frmQuicksort
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
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.BtnOrdenar2 = new System.Windows.Forms.Button();
            this.LbResultado1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar numero";
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(132, 73);
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(100, 20);
            this.txtDatos.TabIndex = 1;
            // 
            // BtnOrdenar2
            // 
            this.BtnOrdenar2.Location = new System.Drawing.Point(142, 99);
            this.BtnOrdenar2.Name = "BtnOrdenar2";
            this.BtnOrdenar2.Size = new System.Drawing.Size(75, 23);
            this.BtnOrdenar2.TabIndex = 2;
            this.BtnOrdenar2.Text = "Ordenar";
            this.BtnOrdenar2.UseVisualStyleBackColor = true;
            this.BtnOrdenar2.Click += new System.EventHandler(this.BtnOrdenar2_Click);
            // 
            // LbResultado1
            // 
            this.LbResultado1.AutoSize = true;
            this.LbResultado1.Location = new System.Drawing.Point(247, 104);
            this.LbResultado1.Name = "LbResultado1";
            this.LbResultado1.Size = new System.Drawing.Size(55, 13);
            this.LbResultado1.TabIndex = 3;
            this.LbResultado1.Text = "Resultado";
            // 
            // frmQuicksort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LbResultado1);
            this.Controls.Add(this.BtnOrdenar2);
            this.Controls.Add(this.txtDatos);
            this.Controls.Add(this.label1);
            this.Name = "frmQuicksort";
            this.Text = "frmQuicksort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.Button BtnOrdenar2;
        private System.Windows.Forms.Label LbResultado1;
    }
}