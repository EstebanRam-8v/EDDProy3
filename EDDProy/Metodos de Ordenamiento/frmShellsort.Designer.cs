namespace EDDemo
{
    partial class frmShellsort
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
            this.txtShell = new System.Windows.Forms.TextBox();
            this.BtnOrdenar = new System.Windows.Forms.Button();
            this.LbResultado = new System.Windows.Forms.Label();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar Numeros";
            // 
            // txtShell
            // 
            this.txtShell.Location = new System.Drawing.Point(142, 46);
            this.txtShell.Name = "txtShell";
            this.txtShell.Size = new System.Drawing.Size(96, 20);
            this.txtShell.TabIndex = 1;
            // 
            // BtnOrdenar
            // 
            this.BtnOrdenar.Location = new System.Drawing.Point(49, 123);
            this.BtnOrdenar.Name = "BtnOrdenar";
            this.BtnOrdenar.Size = new System.Drawing.Size(66, 29);
            this.BtnOrdenar.TabIndex = 2;
            this.BtnOrdenar.Text = "Ordenar";
            this.BtnOrdenar.UseVisualStyleBackColor = true;
            this.BtnOrdenar.Click += new System.EventHandler(this.BtnOrdenar_Click);
            // 
            // LbResultado
            // 
            this.LbResultado.AutoSize = true;
            this.LbResultado.Location = new System.Drawing.Point(150, 87);
            this.LbResultado.Name = "LbResultado";
            this.LbResultado.Size = new System.Drawing.Size(55, 13);
            this.LbResultado.TabIndex = 4;
            this.LbResultado.Text = "Resultado";
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Location = new System.Drawing.Point(49, 82);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(75, 23);
            this.BtnIniciar.TabIndex = 5;
            this.BtnIniciar.Text = "Ingresar";
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // frmShellsort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.LbResultado);
            this.Controls.Add(this.BtnOrdenar);
            this.Controls.Add(this.txtShell);
            this.Controls.Add(this.label1);
            this.Name = "frmShellsort";
            this.Text = "frmShellsort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtShell;
        private System.Windows.Forms.Button BtnOrdenar;
        private System.Windows.Forms.Label LbResultado;
        private System.Windows.Forms.Button BtnIniciar;
    }
}