
namespace EDDemo.Estructuras_No_Lineales
{
    partial class frmArboles
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
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtArbol = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnCrearArbol = new System.Windows.Forms.Button();
            this.txtNodos = new System.Windows.Forms.NumericUpDown();
            this.rbOrientacion1 = new System.Windows.Forms.RadioButton();
            this.rbOrientacion2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRecorridoPreOrden = new System.Windows.Forms.Label();
            this.lblRecorridoInOrden = new System.Windows.Forms.Label();
            this.lblPreOrden = new System.Windows.Forms.Label();
            this.lblInOrden = new System.Windows.Forms.Label();
            this.lblRecorridoPostOrden = new System.Windows.Forms.Label();
            this.lblPostOrden = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.BtnPodar = new System.Windows.Forms.Button();
            this.btnPredecesor = new System.Windows.Forms.Button();
            this.btnAltitud = new System.Windows.Forms.Button();
            this.btnAltura = new System.Windows.Forms.Button();
            this.btnHojas = new System.Windows.Forms.Button();
            this.btncantidad = new System.Windows.Forms.Button();
            this.btnBinario = new System.Windows.Forms.Button();
            this.btnLleno = new System.Windows.Forms.Button();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.lblAmplitud = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.lblnodos = new System.Windows.Forms.Label();
            this.lblBinario1 = new System.Windows.Forms.Label();
            this.lblLleno = new System.Windows.Forms.Label();
            this.btnSucesor = new System.Windows.Forms.Button();
            this.txtSucesor = new System.Windows.Forms.TextBox();
            this.txtArbolpo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(42, 16);
            this.txtDato.Margin = new System.Windows.Forms.Padding(2);
            this.txtDato.Multiline = true;
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(52, 26);
            this.txtDato.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(104, 16);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(62, 24);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Insertar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtArbol
            // 
            this.txtArbol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArbol.Location = new System.Drawing.Point(12, 221);
            this.txtArbol.Margin = new System.Windows.Forms.Padding(2);
            this.txtArbol.Multiline = true;
            this.txtArbol.Name = "txtArbol";
            this.txtArbol.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtArbol.Size = new System.Drawing.Size(1090, 403);
            this.txtArbol.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.Location = new System.Drawing.Point(1160, 53);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(62, 24);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGrafica
            // 
            this.btnGrafica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrafica.Location = new System.Drawing.Point(1160, 18);
            this.btnGrafica.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(62, 24);
            this.btnGrafica.TabIndex = 3;
            this.btnGrafica.Text = "Grafica";
            this.btnGrafica.UseVisualStyleBackColor = true;
            this.btnGrafica.Click += new System.EventHandler(this.btnGrafica_Click);
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Location = new System.Drawing.Point(104, 85);
            this.btnRecorrer.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(62, 32);
            this.btnRecorrer.TabIndex = 4;
            this.btnRecorrer.Text = "Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(6, 21);
            this.lblDatos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(36, 13);
            this.lblDatos.TabIndex = 5;
            this.lblDatos.Text = "Dato :";
            // 
            // btnCrearArbol
            // 
            this.btnCrearArbol.Location = new System.Drawing.Point(104, 48);
            this.btnCrearArbol.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearArbol.Name = "btnCrearArbol";
            this.btnCrearArbol.Size = new System.Drawing.Size(62, 34);
            this.btnCrearArbol.TabIndex = 6;
            this.btnCrearArbol.Text = "Crear Arbol";
            this.btnCrearArbol.UseVisualStyleBackColor = true;
            this.btnCrearArbol.Click += new System.EventHandler(this.btnCrearArbol_Click);
            // 
            // txtNodos
            // 
            this.txtNodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNodos.Location = new System.Drawing.Point(40, 54);
            this.txtNodos.Margin = new System.Windows.Forms.Padding(2);
            this.txtNodos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNodos.Name = "txtNodos";
            this.txtNodos.Size = new System.Drawing.Size(60, 24);
            this.txtNodos.TabIndex = 8;
            this.txtNodos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNodos.ValueChanged += new System.EventHandler(this.txtNodos_ValueChanged);
            // 
            // rbOrientacion1
            // 
            this.rbOrientacion1.AutoSize = true;
            this.rbOrientacion1.Location = new System.Drawing.Point(181, 100);
            this.rbOrientacion1.Margin = new System.Windows.Forms.Padding(2);
            this.rbOrientacion1.Name = "rbOrientacion1";
            this.rbOrientacion1.Size = new System.Drawing.Size(60, 17);
            this.rbOrientacion1.TabIndex = 15;
            this.rbOrientacion1.TabStop = true;
            this.rbOrientacion1.Text = "Vertical";
            this.rbOrientacion1.UseVisualStyleBackColor = true;
            // 
            // rbOrientacion2
            // 
            this.rbOrientacion2.AutoSize = true;
            this.rbOrientacion2.Location = new System.Drawing.Point(245, 102);
            this.rbOrientacion2.Margin = new System.Windows.Forms.Padding(2);
            this.rbOrientacion2.Name = "rbOrientacion2";
            this.rbOrientacion2.Size = new System.Drawing.Size(72, 17);
            this.rbOrientacion2.TabIndex = 16;
            this.rbOrientacion2.TabStop = true;
            this.rbOrientacion2.Text = "Horizontal";
            this.rbOrientacion2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblRecorridoPreOrden);
            this.groupBox1.Controls.Add(this.lblRecorridoInOrden);
            this.groupBox1.Controls.Add(this.lblPreOrden);
            this.groupBox1.Controls.Add(this.lblInOrden);
            this.groupBox1.Controls.Add(this.lblRecorridoPostOrden);
            this.groupBox1.Controls.Add(this.lblPostOrden);
            this.groupBox1.Location = new System.Drawing.Point(141, 121);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(555, 100);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recorridos";
            // 
            // lblRecorridoPreOrden
            // 
            this.lblRecorridoPreOrden.AutoSize = true;
            this.lblRecorridoPreOrden.Location = new System.Drawing.Point(70, 24);
            this.lblRecorridoPreOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoPreOrden.Name = "lblRecorridoPreOrden";
            this.lblRecorridoPreOrden.Size = new System.Drawing.Size(57, 13);
            this.lblRecorridoPreOrden.TabIndex = 20;
            this.lblRecorridoPreOrden.Text = "PostOrden";
            // 
            // lblRecorridoInOrden
            // 
            this.lblRecorridoInOrden.AutoSize = true;
            this.lblRecorridoInOrden.Location = new System.Drawing.Point(70, 50);
            this.lblRecorridoInOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoInOrden.Name = "lblRecorridoInOrden";
            this.lblRecorridoInOrden.Size = new System.Drawing.Size(57, 13);
            this.lblRecorridoInOrden.TabIndex = 19;
            this.lblRecorridoInOrden.Text = "PostOrden";
            // 
            // lblPreOrden
            // 
            this.lblPreOrden.AutoSize = true;
            this.lblPreOrden.Location = new System.Drawing.Point(10, 24);
            this.lblPreOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreOrden.Name = "lblPreOrden";
            this.lblPreOrden.Size = new System.Drawing.Size(55, 13);
            this.lblPreOrden.TabIndex = 18;
            this.lblPreOrden.Text = "PreOrden:";
            // 
            // lblInOrden
            // 
            this.lblInOrden.AutoSize = true;
            this.lblInOrden.Location = new System.Drawing.Point(18, 50);
            this.lblInOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInOrden.Name = "lblInOrden";
            this.lblInOrden.Size = new System.Drawing.Size(48, 13);
            this.lblInOrden.TabIndex = 17;
            this.lblInOrden.Text = "InOrden:";
            // 
            // lblRecorridoPostOrden
            // 
            this.lblRecorridoPostOrden.AutoSize = true;
            this.lblRecorridoPostOrden.Location = new System.Drawing.Point(70, 74);
            this.lblRecorridoPostOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoPostOrden.Name = "lblRecorridoPostOrden";
            this.lblRecorridoPostOrden.Size = new System.Drawing.Size(57, 13);
            this.lblRecorridoPostOrden.TabIndex = 16;
            this.lblRecorridoPostOrden.Text = "PostOrden";
            // 
            // lblPostOrden
            // 
            this.lblPostOrden.AutoSize = true;
            this.lblPostOrden.Location = new System.Drawing.Point(6, 74);
            this.lblPostOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostOrden.Name = "lblPostOrden";
            this.lblPostOrden.Size = new System.Drawing.Size(60, 13);
            this.lblPostOrden.TabIndex = 15;
            this.lblPostOrden.Text = "PostOrden:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(25, 122);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Buscar nodo";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(12, 151);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 21;
            // 
            // BtnPodar
            // 
            this.BtnPodar.Location = new System.Drawing.Point(181, 16);
            this.BtnPodar.Name = "BtnPodar";
            this.BtnPodar.Size = new System.Drawing.Size(75, 39);
            this.BtnPodar.TabIndex = 22;
            this.BtnPodar.Text = "Podar";
            this.BtnPodar.UseVisualStyleBackColor = true;
            this.BtnPodar.Click += new System.EventHandler(this.BtnPodar_Click);
            // 
            // btnPredecesor
            // 
            this.btnPredecesor.Location = new System.Drawing.Point(274, 16);
            this.btnPredecesor.Name = "btnPredecesor";
            this.btnPredecesor.Size = new System.Drawing.Size(73, 39);
            this.btnPredecesor.TabIndex = 23;
            this.btnPredecesor.Text = "Nodo Precesor";
            this.btnPredecesor.UseVisualStyleBackColor = true;
            this.btnPredecesor.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAltitud
            // 
            this.btnAltitud.Location = new System.Drawing.Point(441, 17);
            this.btnAltitud.Name = "btnAltitud";
            this.btnAltitud.Size = new System.Drawing.Size(75, 23);
            this.btnAltitud.TabIndex = 24;
            this.btnAltitud.Text = "Nivel";
            this.btnAltitud.UseVisualStyleBackColor = true;
            this.btnAltitud.Click += new System.EventHandler(this.btnAltitud_Click);
            // 
            // btnAltura
            // 
            this.btnAltura.Location = new System.Drawing.Point(441, 68);
            this.btnAltura.Name = "btnAltura";
            this.btnAltura.Size = new System.Drawing.Size(75, 23);
            this.btnAltura.TabIndex = 25;
            this.btnAltura.Text = "Altura";
            this.btnAltura.UseVisualStyleBackColor = true;
            this.btnAltura.Click += new System.EventHandler(this.btnAltura_Click);
            // 
            // btnHojas
            // 
            this.btnHojas.Location = new System.Drawing.Point(621, 16);
            this.btnHojas.Name = "btnHojas";
            this.btnHojas.Size = new System.Drawing.Size(75, 23);
            this.btnHojas.TabIndex = 26;
            this.btnHojas.Text = "Hojas";
            this.btnHojas.UseVisualStyleBackColor = true;
            this.btnHojas.Click += new System.EventHandler(this.btnHojas_Click);
            // 
            // btncantidad
            // 
            this.btncantidad.Location = new System.Drawing.Point(621, 68);
            this.btncantidad.Name = "btncantidad";
            this.btncantidad.Size = new System.Drawing.Size(75, 23);
            this.btncantidad.TabIndex = 27;
            this.btncantidad.Text = "Cantidad";
            this.btncantidad.UseVisualStyleBackColor = true;
            this.btncantidad.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnBinario
            // 
            this.btnBinario.Location = new System.Drawing.Point(916, 68);
            this.btnBinario.Name = "btnBinario";
            this.btnBinario.Size = new System.Drawing.Size(64, 23);
            this.btnBinario.TabIndex = 28;
            this.btnBinario.Text = "Binario";
            this.btnBinario.UseVisualStyleBackColor = true;
            this.btnBinario.Click += new System.EventHandler(this.btnBinario_Click);
            // 
            // btnLleno
            // 
            this.btnLleno.Location = new System.Drawing.Point(916, 17);
            this.btnLleno.Name = "btnLleno";
            this.btnLleno.Size = new System.Drawing.Size(64, 23);
            this.btnLleno.TabIndex = 29;
            this.btnLleno.Text = "BinarioL";
            this.btnLleno.UseVisualStyleBackColor = true;
            this.btnLleno.Click += new System.EventHandler(this.btnLleno_Click);
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(274, 62);
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(60, 20);
            this.txtDatos.TabIndex = 31;
            // 
            // lblAmplitud
            // 
            this.lblAmplitud.AutoSize = true;
            this.lblAmplitud.Location = new System.Drawing.Point(438, 48);
            this.lblAmplitud.Name = "lblAmplitud";
            this.lblAmplitud.Size = new System.Drawing.Size(47, 13);
            this.lblAmplitud.TabIndex = 32;
            this.lblAmplitud.Text = "Amplitud";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(438, 95);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 33;
            this.lblAltura.Text = "Altura";
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Location = new System.Drawing.Point(639, 48);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(34, 13);
            this.lblCant.TabIndex = 34;
            this.lblCant.Text = "Hojas";
            // 
            // lblnodos
            // 
            this.lblnodos.AutoSize = true;
            this.lblnodos.Location = new System.Drawing.Point(639, 95);
            this.lblnodos.Name = "lblnodos";
            this.lblnodos.Size = new System.Drawing.Size(49, 13);
            this.lblnodos.TabIndex = 35;
            this.lblnodos.Text = "Cantidad";
            // 
            // lblBinario1
            // 
            this.lblBinario1.AutoSize = true;
            this.lblBinario1.Location = new System.Drawing.Point(913, 95);
            this.lblBinario1.Name = "lblBinario1";
            this.lblBinario1.Size = new System.Drawing.Size(58, 13);
            this.lblBinario1.TabIndex = 36;
            this.lblBinario1.Text = "Respuesta";
            // 
            // lblLleno
            // 
            this.lblLleno.AutoSize = true;
            this.lblLleno.Location = new System.Drawing.Point(913, 48);
            this.lblLleno.Name = "lblLleno";
            this.lblLleno.Size = new System.Drawing.Size(58, 13);
            this.lblLleno.TabIndex = 37;
            this.lblLleno.Text = "Respuesta";
            // 
            // btnSucesor
            // 
            this.btnSucesor.Location = new System.Drawing.Point(359, 16);
            this.btnSucesor.Name = "btnSucesor";
            this.btnSucesor.Size = new System.Drawing.Size(73, 39);
            this.btnSucesor.TabIndex = 38;
            this.btnSucesor.Text = "Nodo Sucesor";
            this.btnSucesor.UseVisualStyleBackColor = true;
            this.btnSucesor.Click += new System.EventHandler(this.btnSucesor_Click);
            // 
            // txtSucesor
            // 
            this.txtSucesor.Location = new System.Drawing.Point(359, 62);
            this.txtSucesor.Name = "txtSucesor";
            this.txtSucesor.Size = new System.Drawing.Size(60, 20);
            this.txtSucesor.TabIndex = 32;
            // 
            // txtArbolpo
            // 
            this.txtArbolpo.Location = new System.Drawing.Point(181, 62);
            this.txtArbolpo.Name = "txtArbolpo";
            this.txtArbolpo.Size = new System.Drawing.Size(60, 20);
            this.txtArbolpo.TabIndex = 32;
            // 
            // frmArboles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 533);
            this.Controls.Add(this.txtArbolpo);
            this.Controls.Add(this.txtSucesor);
            this.Controls.Add(this.btnSucesor);
            this.Controls.Add(this.lblLleno);
            this.Controls.Add(this.lblBinario1);
            this.Controls.Add(this.lblnodos);
            this.Controls.Add(this.lblCant);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblAmplitud);
            this.Controls.Add(this.txtDatos);
            this.Controls.Add(this.btnLleno);
            this.Controls.Add(this.btnBinario);
            this.Controls.Add(this.btncantidad);
            this.Controls.Add(this.btnHojas);
            this.Controls.Add(this.btnAltura);
            this.Controls.Add(this.btnAltitud);
            this.Controls.Add(this.btnPredecesor);
            this.Controls.Add(this.BtnPodar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbOrientacion2);
            this.Controls.Add(this.rbOrientacion1);
            this.Controls.Add(this.txtNodos);
            this.Controls.Add(this.btnCrearArbol);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.btnRecorrer);
            this.Controls.Add(this.btnGrafica);
            this.Controls.Add(this.txtArbol);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDato);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmArboles";
            this.Text = "frmArboles";
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtArbol;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGrafica;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button btnCrearArbol;
        private System.Windows.Forms.NumericUpDown txtNodos;
        private System.Windows.Forms.RadioButton rbOrientacion1;
        private System.Windows.Forms.RadioButton rbOrientacion2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRecorridoPreOrden;
        private System.Windows.Forms.Label lblRecorridoInOrden;
        private System.Windows.Forms.Label lblPreOrden;
        private System.Windows.Forms.Label lblInOrden;
        private System.Windows.Forms.Label lblRecorridoPostOrden;
        private System.Windows.Forms.Label lblPostOrden;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button BtnPodar;
        private System.Windows.Forms.Button btnPredecesor;
        private System.Windows.Forms.Button btnAltitud;
        private System.Windows.Forms.Button btnAltura;
        private System.Windows.Forms.Button btnHojas;
        private System.Windows.Forms.Button btncantidad;
        private System.Windows.Forms.Button btnBinario;
        private System.Windows.Forms.Button btnLleno;
        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.Label lblAmplitud;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Label lblnodos;
        private System.Windows.Forms.Label lblBinario1;
        private System.Windows.Forms.Label lblLleno;
        private System.Windows.Forms.Button btnSucesor;
        private System.Windows.Forms.TextBox txtSucesor;
        private System.Windows.Forms.TextBox txtArbolpo;
    }
}