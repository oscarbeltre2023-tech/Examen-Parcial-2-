namespace Examen_Paarcial_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtCliente = new TextBox();
            chkFrecuente = new CheckBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            txtProducto = new TextBox();
            txtPrecio = new TextBox();
            textBox4 = new TextBox();
            dtpFecha = new DateTimePicker();
            nudCantidad = new NumericUpDown();
            groupBox1 = new GroupBox();
            rbtGrande = new RadioButton();
            rbtNormal = new RadioButton();
            groupBox2 = new GroupBox();
            rbtLlevar = new RadioButton();
            rbtLocal = new RadioButton();
            chkPorcionExtra = new CheckBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            btnAgregar = new Button();
            lblEncabezado = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            lstPedido = new ListBox();
            lblSubtotal = new Label();
            lblDescuento = new Label();
            lblEmpaque = new Label();
            lblItbis = new Label();
            lblTotal = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 1;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(87, 25);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(150, 31);
            txtCliente.TabIndex = 2;
            // 
            // chkFrecuente
            // 
            chkFrecuente.AutoSize = true;
            chkFrecuente.Location = new Point(23, 78);
            chkFrecuente.Name = "chkFrecuente";
            chkFrecuente.Size = new Size(172, 29);
            chkFrecuente.TabIndex = 3;
            chkFrecuente.Text = "Cliente Frecuente";
            chkFrecuente.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 124);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 4;
            label3.Text = "Fecha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 171);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 5;
            label4.Text = "Producto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 215);
            label5.Name = "label5";
            label5.Size = new Size(64, 25);
            label5.TabIndex = 6;
            label5.Text = "Precio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 264);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 7;
            label6.Text = "Cantidad:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(676, 465);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(111, 171);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(150, 31);
            txtProducto.TabIndex = 9;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(111, 215);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(150, 31);
            txtPrecio.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(676, 527);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 11;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(111, 118);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(150, 31);
            dtpFecha.TabIndex = 12;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(111, 262);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(150, 31);
            nudCantidad.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtGrande);
            groupBox1.Controls.Add(rbtNormal);
            groupBox1.Location = new Point(12, 321);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(197, 150);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tamaño:";
            // 
            // rbtGrande
            // 
            rbtGrande.AutoSize = true;
            rbtGrande.Location = new Point(16, 101);
            rbtGrande.Name = "rbtGrande";
            rbtGrande.Size = new Size(175, 29);
            rbtGrande.TabIndex = 1;
            rbtGrande.TabStop = true;
            rbtGrande.Text = "Grande (+RD$25)";
            rbtGrande.UseVisualStyleBackColor = true;
            // 
            // rbtNormal
            // 
            rbtNormal.AutoSize = true;
            rbtNormal.Location = new Point(17, 43);
            rbtNormal.Name = "rbtNormal";
            rbtNormal.Size = new Size(96, 29);
            rbtNormal.TabIndex = 0;
            rbtNormal.TabStop = true;
            rbtNormal.Text = "Normal";
            rbtNormal.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbtLlevar);
            groupBox2.Controls.Add(rbtLocal);
            groupBox2.Location = new Point(236, 321);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(231, 150);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Servicio:";
            // 
            // rbtLlevar
            // 
            rbtLlevar.AutoSize = true;
            rbtLlevar.Location = new Point(23, 93);
            rbtLlevar.Name = "rbtLlevar";
            rbtLlevar.Size = new Size(201, 29);
            rbtLlevar.TabIndex = 1;
            rbtLlevar.TabStop = true;
            rbtLlevar.Text = "Para Llevar (+RD$20)";
            rbtLlevar.UseVisualStyleBackColor = true;
            // 
            // rbtLocal
            // 
            rbtLocal.AutoSize = true;
            rbtLocal.Location = new Point(22, 38);
            rbtLocal.Name = "rbtLocal";
            rbtLocal.Size = new Size(200, 29);
            rbtLocal.TabIndex = 0;
            rbtLocal.TabStop = true;
            rbtLocal.Text = "Consumir En El Local";
            rbtLocal.UseVisualStyleBackColor = true;
            // 
            // chkPorcionExtra
            // 
            chkPorcionExtra.AutoSize = true;
            chkPorcionExtra.Location = new Point(18, 481);
            chkPorcionExtra.Name = "chkPorcionExtra";
            chkPorcionExtra.Size = new Size(221, 29);
            chkPorcionExtra.TabIndex = 16;
            chkPorcionExtra.Text = "Porcion Extra (+RD$30)";
            chkPorcionExtra.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(18, 558);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(129, 51);
            btnCalcular.TabIndex = 17;
            btnCalcular.Text = "Calcular Total";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(164, 558);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(143, 51);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "Nuevo Pedido";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(313, 558);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(129, 51);
            btnSalir.TabIndex = 19;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(539, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(253, 63);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "Agregar Al Pedido";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lblEncabezado
            // 
            lblEncabezado.AutoSize = true;
            lblEncabezado.Location = new Point(517, 94);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(48, 25);
            lblEncabezado.TabIndex = 21;
            lblEncabezado.Text = "Cant";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(587, 94);
            label8.Name = "label8";
            label8.Size = new Size(85, 25);
            label8.TabIndex = 22;
            label8.Text = "Producto";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(703, 94);
            label9.Name = "label9";
            label9.Size = new Size(60, 25);
            label9.TabIndex = 23;
            label9.Text = "Precio";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(803, 94);
            label10.Name = "label10";
            label10.Size = new Size(49, 25);
            label10.TabIndex = 24;
            label10.Text = "Total";
            // 
            // lstPedido
            // 
            lstPedido.FormattingEnabled = true;
            lstPedido.Location = new Point(517, 124);
            lstPedido.Name = "lstPedido";
            lstPedido.Size = new Size(355, 179);
            lstPedido.TabIndex = 25;
            lstPedido.SelectedIndexChanged += lstPedido_SelectedIndexChanged;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(517, 348);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(80, 25);
            lblSubtotal.TabIndex = 26;
            lblSubtotal.Text = "SubTotal";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(512, 405);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(96, 25);
            lblDescuento.TabIndex = 27;
            lblDescuento.Text = "Descuento";
            // 
            // lblEmpaque
            // 
            lblEmpaque.AutoSize = true;
            lblEmpaque.Location = new Point(516, 465);
            lblEmpaque.Name = "lblEmpaque";
            lblEmpaque.Size = new Size(87, 25);
            lblEmpaque.TabIndex = 28;
            lblEmpaque.Text = "Empaque";
            // 
            // lblItbis
            // 
            lblItbis.AutoSize = true;
            lblItbis.Location = new Point(517, 518);
            lblItbis.Name = "lblItbis";
            lblItbis.Size = new Size(101, 25);
            lblItbis.TabIndex = 29;
            lblItbis.Text = "ITBIS (18%)";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            lblTotal.Location = new Point(512, 584);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(161, 25);
            lblTotal.TabIndex = 30;
            lblTotal.Text = "TOTAL A PAGAR";
            lblTotal.Click += label15_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(676, 348);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 31;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(676, 405);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 32;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(676, 584);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 33;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 681);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(lblTotal);
            Controls.Add(lblItbis);
            Controls.Add(lblEmpaque);
            Controls.Add(lblDescuento);
            Controls.Add(lblSubtotal);
            Controls.Add(lstPedido);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(lblEncabezado);
            Controls.Add(btnAgregar);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(chkPorcionExtra);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(nudCantidad);
            Controls.Add(dtpFecha);
            Controls.Add(textBox4);
            Controls.Add(txtPrecio);
            Controls.Add(txtProducto);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(chkFrecuente);
            Controls.Add(txtCliente);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Cafeteria El Buen Sabor";
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCliente;
        private CheckBox chkFrecuente;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox txtProducto;
        private TextBox txtPrecio;
        private TextBox textBox4;
        private DateTimePicker dtpFecha;
        private NumericUpDown nudCantidad;
        private GroupBox groupBox1;
        private RadioButton rbtGrande;
        private RadioButton rbtNormal;
        private GroupBox groupBox2;
        private RadioButton rbtLlevar;
        private RadioButton rbtLocal;
        private CheckBox chkPorcionExtra;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private Button btnAgregar;
        private Label lblEncabezado;
        private Label label8;
        private Label label9;
        private Label label10;
        private ListBox lstPedido;
        private Label lblSubtotal;
        private Label lblDescuento;
        private Label lblEmpaque;
        private Label lblItbis;
        private Label lblTotal;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox5;
    }
}
