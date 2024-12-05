namespace EDDemo
{
    partial class frmFactorial
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
            this.BtnCalcu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIngresarFac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LbTiempo3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCalcu
            // 
            this.BtnCalcu.Location = new System.Drawing.Point(101, 121);
            this.BtnCalcu.Name = "BtnCalcu";
            this.BtnCalcu.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcu.TabIndex = 0;
            this.BtnCalcu.Text = "Calcular";
            this.BtnCalcu.UseVisualStyleBackColor = true;
            this.BtnCalcu.Click += new System.EventHandler(this.BtnCalcu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresar Numero";
            // 
            // txtIngresarFac
            // 
            this.txtIngresarFac.Location = new System.Drawing.Point(47, 95);
            this.txtIngresarFac.Name = "txtIngresarFac";
            this.txtIngresarFac.Size = new System.Drawing.Size(73, 20);
            this.txtIngresarFac.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(146, 95);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(103, 20);
            this.txtResultado.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Complejidad: O(n)";
            // 
            // LbTiempo3
            // 
            this.LbTiempo3.AutoSize = true;
            this.LbTiempo3.Location = new System.Drawing.Point(44, 195);
            this.LbTiempo3.Name = "LbTiempo3";
            this.LbTiempo3.Size = new System.Drawing.Size(42, 13);
            this.LbTiempo3.TabIndex = 6;
            this.LbTiempo3.Text = "Tiempo";
            // 
            // frmFactorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LbTiempo3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIngresarFac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCalcu);
            this.Name = "frmFactorial";
            this.Text = "frmFactorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalcu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIngresarFac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LbTiempo3;
    }
}