namespace EDDemo
{
    partial class frmBusquedaSec
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
            this.txtNumeros3 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar3 = new System.Windows.Forms.TextBox();
            this.LbResultado3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar datos";
            // 
            // txtNumeros3
            // 
            this.txtNumeros3.Location = new System.Drawing.Point(102, 101);
            this.txtNumeros3.Name = "txtNumeros3";
            this.txtNumeros3.Size = new System.Drawing.Size(127, 20);
            this.txtNumeros3.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(202, 137);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar3
            // 
            this.txtBuscar3.Location = new System.Drawing.Point(247, 101);
            this.txtBuscar3.Name = "txtBuscar3";
            this.txtBuscar3.Size = new System.Drawing.Size(115, 20);
            this.txtBuscar3.TabIndex = 3;
            // 
            // LbResultado3
            // 
            this.LbResultado3.AutoSize = true;
            this.LbResultado3.Location = new System.Drawing.Point(356, 142);
            this.LbResultado3.Name = "LbResultado3";
            this.LbResultado3.Size = new System.Drawing.Size(58, 13);
            this.LbResultado3.TabIndex = 4;
            this.LbResultado3.Text = "Resultado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numeros";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Buscar";
            // 
            // frmBusquedaSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LbResultado3);
            this.Controls.Add(this.txtBuscar3);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNumeros3);
            this.Controls.Add(this.label1);
            this.Name = "frmBusquedaSec";
            this.Text = "frmBusquedaSec";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeros3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar3;
        private System.Windows.Forms.Label LbResultado3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}