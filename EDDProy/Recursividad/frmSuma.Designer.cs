namespace EDDemo
{
    partial class frmSuma
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
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.txtResultado1 = new System.Windows.Forms.TextBox();
            this.BtnResultado1 = new System.Windows.Forms.Button();
            this.LbtiempoSuma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar Dato";
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(31, 78);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(100, 20);
            this.txtSuma.TabIndex = 1;
            // 
            // txtResultado1
            // 
            this.txtResultado1.Location = new System.Drawing.Point(137, 78);
            this.txtResultado1.Name = "txtResultado1";
            this.txtResultado1.Size = new System.Drawing.Size(100, 20);
            this.txtResultado1.TabIndex = 2;
            // 
            // BtnResultado1
            // 
            this.BtnResultado1.Location = new System.Drawing.Point(92, 104);
            this.BtnResultado1.Name = "BtnResultado1";
            this.BtnResultado1.Size = new System.Drawing.Size(87, 24);
            this.BtnResultado1.TabIndex = 3;
            this.BtnResultado1.Text = "Resultado";
            this.BtnResultado1.UseVisualStyleBackColor = true;
            this.BtnResultado1.Click += new System.EventHandler(this.BtnResultado1_Click);
            // 
            // LbtiempoSuma
            // 
            this.LbtiempoSuma.AutoSize = true;
            this.LbtiempoSuma.Location = new System.Drawing.Point(28, 143);
            this.LbtiempoSuma.Name = "LbtiempoSuma";
            this.LbtiempoSuma.Size = new System.Drawing.Size(42, 13);
            this.LbtiempoSuma.TabIndex = 4;
            this.LbtiempoSuma.Text = "Tiempo";
            // 
            // frmSuma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LbtiempoSuma);
            this.Controls.Add(this.BtnResultado1);
            this.Controls.Add(this.txtResultado1);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.label1);
            this.Name = "frmSuma";
            this.Text = "frmSuma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.TextBox txtResultado1;
        private System.Windows.Forms.Button BtnResultado1;
        private System.Windows.Forms.Label LbtiempoSuma;
    }
}