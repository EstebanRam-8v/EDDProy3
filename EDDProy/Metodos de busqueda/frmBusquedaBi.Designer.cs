namespace EDDemo
{
    partial class frmBusquedaBi
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
            this.txtNumero4 = new System.Windows.Forms.TextBox();
            this.txtBuscar4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar4 = new System.Windows.Forms.Button();
            this.LbResultado4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar Busqueda Binaria";
            // 
            // txtNumero4
            // 
            this.txtNumero4.Location = new System.Drawing.Point(176, 147);
            this.txtNumero4.Name = "txtNumero4";
            this.txtNumero4.Size = new System.Drawing.Size(119, 20);
            this.txtNumero4.TabIndex = 1;
            // 
            // txtBuscar4
            // 
            this.txtBuscar4.Location = new System.Drawing.Point(301, 147);
            this.txtBuscar4.Name = "txtBuscar4";
            this.txtBuscar4.Size = new System.Drawing.Size(119, 20);
            this.txtBuscar4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numeros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Buscar";
            // 
            // btnBuscar4
            // 
            this.btnBuscar4.Location = new System.Drawing.Point(265, 173);
            this.btnBuscar4.Name = "btnBuscar4";
            this.btnBuscar4.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar4.TabIndex = 5;
            this.btnBuscar4.Text = "Buscar";
            this.btnBuscar4.UseVisualStyleBackColor = true;
            this.btnBuscar4.Click += new System.EventHandler(this.btnBuscar4_Click);
            // 
            // LbResultado4
            // 
            this.LbResultado4.AutoSize = true;
            this.LbResultado4.Location = new System.Drawing.Point(426, 150);
            this.LbResultado4.Name = "LbResultado4";
            this.LbResultado4.Size = new System.Drawing.Size(58, 13);
            this.LbResultado4.TabIndex = 6;
            this.LbResultado4.Text = "Resultado:";
            // 
            // frmBusquedaBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LbResultado4);
            this.Controls.Add(this.btnBuscar4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscar4);
            this.Controls.Add(this.txtNumero4);
            this.Controls.Add(this.label1);
            this.Name = "frmBusquedaBi";
            this.Text = "frmBusquedaBi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero4;
        private System.Windows.Forms.TextBox txtBuscar4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar4;
        private System.Windows.Forms.Label LbResultado4;
    }
}