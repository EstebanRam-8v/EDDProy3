namespace EDDemo
{
    partial class frmCalculo
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
            this.BtnInsertar2 = new System.Windows.Forms.Button();
            this.BtnExpo = new System.Windows.Forms.Button();
            this.BtnResul = new System.Windows.Forms.Button();
            this.txtInsertarExpo = new System.Windows.Forms.TextBox();
            this.txtExpo = new System.Windows.Forms.TextBox();
            this.txtResul = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LbTiempo2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnInsertar2
            // 
            this.BtnInsertar2.Location = new System.Drawing.Point(39, 54);
            this.BtnInsertar2.Name = "BtnInsertar2";
            this.BtnInsertar2.Size = new System.Drawing.Size(76, 23);
            this.BtnInsertar2.TabIndex = 0;
            this.BtnInsertar2.Text = "Insertar";
            this.BtnInsertar2.UseVisualStyleBackColor = true;
            this.BtnInsertar2.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnExpo
            // 
            this.BtnExpo.Location = new System.Drawing.Point(159, 54);
            this.BtnExpo.Name = "BtnExpo";
            this.BtnExpo.Size = new System.Drawing.Size(76, 23);
            this.BtnExpo.TabIndex = 1;
            this.BtnExpo.Text = "Exponente";
            this.BtnExpo.UseVisualStyleBackColor = true;
            this.BtnExpo.Click += new System.EventHandler(this.BtnExpo_Click);
            // 
            // BtnResul
            // 
            this.BtnResul.Location = new System.Drawing.Point(278, 54);
            this.BtnResul.Name = "BtnResul";
            this.BtnResul.Size = new System.Drawing.Size(76, 23);
            this.BtnResul.TabIndex = 2;
            this.BtnResul.Text = "Resultado";
            this.BtnResul.UseVisualStyleBackColor = true;
            this.BtnResul.Click += new System.EventHandler(this.BtnResul_Click);
            // 
            // txtInsertarExpo
            // 
            this.txtInsertarExpo.Location = new System.Drawing.Point(27, 83);
            this.txtInsertarExpo.Name = "txtInsertarExpo";
            this.txtInsertarExpo.Size = new System.Drawing.Size(100, 20);
            this.txtInsertarExpo.TabIndex = 3;
            // 
            // txtExpo
            // 
            this.txtExpo.Location = new System.Drawing.Point(147, 83);
            this.txtExpo.Name = "txtExpo";
            this.txtExpo.Size = new System.Drawing.Size(100, 20);
            this.txtExpo.TabIndex = 4;
            // 
            // txtResul
            // 
            this.txtResul.Location = new System.Drawing.Point(267, 83);
            this.txtResul.Name = "txtResul";
            this.txtResul.Size = new System.Drawing.Size(100, 20);
            this.txtResul.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Complejidad: O(n)";
            // 
            // LbTiempo2
            // 
            this.LbTiempo2.AutoSize = true;
            this.LbTiempo2.Location = new System.Drawing.Point(412, 86);
            this.LbTiempo2.Name = "LbTiempo2";
            this.LbTiempo2.Size = new System.Drawing.Size(42, 13);
            this.LbTiempo2.TabIndex = 7;
            this.LbTiempo2.Text = "Tiempo";
            // 
            // frmCalculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LbTiempo2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResul);
            this.Controls.Add(this.txtExpo);
            this.Controls.Add(this.txtInsertarExpo);
            this.Controls.Add(this.BtnResul);
            this.Controls.Add(this.BtnExpo);
            this.Controls.Add(this.BtnInsertar2);
            this.Name = "frmCalculo";
            this.Text = "frmCalculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnInsertar2;
        private System.Windows.Forms.Button BtnExpo;
        private System.Windows.Forms.Button BtnResul;
        private System.Windows.Forms.TextBox txtInsertarExpo;
        private System.Windows.Forms.TextBox txtExpo;
        private System.Windows.Forms.TextBox txtResul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbTiempo2;
    }
}