namespace EDDemo
{
    partial class frmTorre
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
            this.txtTorre = new System.Windows.Forms.TextBox();
            this.txtDiscos = new System.Windows.Forms.TextBox();
            this.BtnTorre = new System.Windows.Forms.Button();
            this.txtTiempoTorre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar Discos";
            // 
            // txtTorre
            // 
            this.txtTorre.Location = new System.Drawing.Point(49, 90);
            this.txtTorre.Multiline = true;
            this.txtTorre.Name = "txtTorre";
            this.txtTorre.Size = new System.Drawing.Size(511, 294);
            this.txtTorre.TabIndex = 1;
            // 
            // txtDiscos
            // 
            this.txtDiscos.Location = new System.Drawing.Point(39, 48);
            this.txtDiscos.Name = "txtDiscos";
            this.txtDiscos.Size = new System.Drawing.Size(100, 20);
            this.txtDiscos.TabIndex = 2;
            // 
            // BtnTorre
            // 
            this.BtnTorre.Location = new System.Drawing.Point(145, 48);
            this.BtnTorre.Name = "BtnTorre";
            this.BtnTorre.Size = new System.Drawing.Size(94, 25);
            this.BtnTorre.TabIndex = 3;
            this.BtnTorre.Text = "Torre";
            this.BtnTorre.UseVisualStyleBackColor = true;
            this.BtnTorre.Click += new System.EventHandler(this.BtnTorre_Click);
            // 
            // txtTiempoTorre
            // 
            this.txtTiempoTorre.AutoSize = true;
            this.txtTiempoTorre.Location = new System.Drawing.Point(245, 54);
            this.txtTiempoTorre.Name = "txtTiempoTorre";
            this.txtTiempoTorre.Size = new System.Drawing.Size(42, 13);
            this.txtTiempoTorre.TabIndex = 4;
            this.txtTiempoTorre.Text = "Tiempo";
            // 
            // frmTorre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTiempoTorre);
            this.Controls.Add(this.BtnTorre);
            this.Controls.Add(this.txtDiscos);
            this.Controls.Add(this.txtTorre);
            this.Controls.Add(this.label1);
            this.Name = "frmTorre";
            this.Text = "frmTorre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTorre;
        private System.Windows.Forms.TextBox txtDiscos;
        private System.Windows.Forms.Button BtnTorre;
        private System.Windows.Forms.Label txtTiempoTorre;
    }
}