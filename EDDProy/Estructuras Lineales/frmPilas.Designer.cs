
namespace EDDemo
{
    partial class frmPilas
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
            this.txtpila = new System.Windows.Forms.TextBox();
            this.btnPush = new System.Windows.Forms.Button();
            this.BtnPop = new System.Windows.Forms.Button();
            this.LbPila = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtpila
            // 
            this.txtpila.Location = new System.Drawing.Point(86, 38);
            this.txtpila.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtpila.Multiline = true;
            this.txtpila.Name = "txtpila";
            this.txtpila.Size = new System.Drawing.Size(72, 27);
            this.txtpila.TabIndex = 0;
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(184, 38);
            this.btnPush.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(42, 21);
            this.btnPush.TabIndex = 1;
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // BtnPop
            // 
            this.BtnPop.Location = new System.Drawing.Point(184, 68);
            this.BtnPop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnPop.Name = "BtnPop";
            this.BtnPop.Size = new System.Drawing.Size(42, 21);
            this.BtnPop.TabIndex = 2;
            this.BtnPop.Text = "Pop";
            this.BtnPop.UseVisualStyleBackColor = true;
            this.BtnPop.Click += new System.EventHandler(this.button1_Click);
            // 
            // LbPila
            // 
            this.LbPila.AutoSize = true;
            this.LbPila.Location = new System.Drawing.Point(83, 109);
            this.LbPila.Name = "LbPila";
            this.LbPila.Size = new System.Drawing.Size(35, 13);
            this.LbPila.TabIndex = 3;
            this.LbPila.Text = "label1";
            this.LbPila.Click += new System.EventHandler(this.LbPila_Click);
            // 
            // frmPilas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 371);
            this.Controls.Add(this.LbPila);
            this.Controls.Add(this.BtnPop);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.txtpila);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPilas";
            this.Text = "frmPilas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpila;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Button BtnPop;
        private System.Windows.Forms.Label LbPila;
    }
}