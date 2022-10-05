namespace Vista
{
    partial class FormAplicacion
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
            System.Windows.Forms.Panel panel1;
            this.lb_titulo = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_mensajeError = new System.Windows.Forms.Label();
            this.gb_precioUnitarioCantidad = new System.Windows.Forms.GroupBox();
            this.tb_cantidad = new System.Windows.Forms.TextBox();
            this.lb_cantidad = new System.Windows.Forms.Label();
            this.lb_signoPeso = new System.Windows.Forms.Label();
            this.tb_precio = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_premium = new System.Windows.Forms.RadioButton();
            this.rb_standard = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_stockDisponible = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_prenda = new System.Windows.Forms.GroupBox();
            this.cb_chupin = new System.Windows.Forms.CheckBox();
            this.cb_cuelloMao = new System.Windows.Forms.CheckBox();
            this.cb_mangaCorta = new System.Windows.Forms.CheckBox();
            this.rb_pantalon = new System.Windows.Forms.RadioButton();
            this.rb_camisa = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_historialCotizaciones = new System.Windows.Forms.LinkLabel();
            this.lb_codigo = new System.Windows.Forms.Label();
            this.lb_nombreVendedor = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_nombreTienda = new System.Windows.Forms.Label();
            this.lb_direccionTienda = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tb_cotizacionFinal = new System.Windows.Forms.TextBox();
            this.btn_cotizar = new System.Windows.Forms.Button();
            this.lb_signoPesoFinal = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.gb_precioUnitarioCantidad.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb_prenda.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(2)))), ((int)(((byte)(210)))));
            panel1.Controls.Add(this.lb_titulo);
            panel1.ForeColor = System.Drawing.Color.DarkBlue;
            panel1.Location = new System.Drawing.Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(670, 109);
            panel1.TabIndex = 7;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_titulo.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_titulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_titulo.Location = new System.Drawing.Point(185, 30);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(296, 47);
            this.lb_titulo.TabIndex = 0;
            this.lb_titulo.Text = "Cotizador Express";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.lb_mensajeError);
            this.panel4.Controls.Add(this.gb_precioUnitarioCantidad);
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.gb_prenda);
            this.panel4.Location = new System.Drawing.Point(1, 210);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(673, 440);
            this.panel4.TabIndex = 11;
            // 
            // lb_mensajeError
            // 
            this.lb_mensajeError.AutoSize = true;
            this.lb_mensajeError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_mensajeError.ForeColor = System.Drawing.Color.Red;
            this.lb_mensajeError.Location = new System.Drawing.Point(83, 411);
            this.lb_mensajeError.Name = "lb_mensajeError";
            this.lb_mensajeError.Size = new System.Drawing.Size(45, 17);
            this.lb_mensajeError.TabIndex = 7;
            this.lb_mensajeError.Text = "label1";
            this.lb_mensajeError.Visible = false;
            // 
            // gb_precioUnitarioCantidad
            // 
            this.gb_precioUnitarioCantidad.Controls.Add(this.tb_cantidad);
            this.gb_precioUnitarioCantidad.Controls.Add(this.lb_cantidad);
            this.gb_precioUnitarioCantidad.Controls.Add(this.lb_signoPeso);
            this.gb_precioUnitarioCantidad.Controls.Add(this.tb_precio);
            this.gb_precioUnitarioCantidad.Location = new System.Drawing.Point(334, 314);
            this.gb_precioUnitarioCantidad.Name = "gb_precioUnitarioCantidad";
            this.gb_precioUnitarioCantidad.Size = new System.Drawing.Size(261, 78);
            this.gb_precioUnitarioCantidad.TabIndex = 3;
            this.gb_precioUnitarioCantidad.TabStop = false;
            this.gb_precioUnitarioCantidad.Text = "Precio unitario y Cantidad";
            // 
            // tb_cantidad
            // 
            this.tb_cantidad.Location = new System.Drawing.Point(186, 34);
            this.tb_cantidad.Name = "tb_cantidad";
            this.tb_cantidad.Size = new System.Drawing.Size(69, 23);
            this.tb_cantidad.TabIndex = 4;
            // 
            // lb_cantidad
            // 
            this.lb_cantidad.AutoSize = true;
            this.lb_cantidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_cantidad.Location = new System.Drawing.Point(113, 34);
            this.lb_cantidad.Name = "lb_cantidad";
            this.lb_cantidad.Size = new System.Drawing.Size(72, 21);
            this.lb_cantidad.TabIndex = 3;
            this.lb_cantidad.Text = "Cantidad";
            // 
            // lb_signoPeso
            // 
            this.lb_signoPeso.AutoSize = true;
            this.lb_signoPeso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_signoPeso.Location = new System.Drawing.Point(6, 34);
            this.lb_signoPeso.Name = "lb_signoPeso";
            this.lb_signoPeso.Size = new System.Drawing.Size(19, 21);
            this.lb_signoPeso.TabIndex = 2;
            this.lb_signoPeso.Text = "$";
            // 
            // tb_precio
            // 
            this.tb_precio.Location = new System.Drawing.Point(31, 34);
            this.tb_precio.Name = "tb_precio";
            this.tb_precio.Size = new System.Drawing.Size(69, 23);
            this.tb_precio.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_premium);
            this.groupBox2.Controls.Add(this.rb_standard);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(70, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 78);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calidad de Prenda";
            // 
            // rb_premium
            // 
            this.rb_premium.AutoSize = true;
            this.rb_premium.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_premium.Location = new System.Drawing.Point(149, 32);
            this.rb_premium.Name = "rb_premium";
            this.rb_premium.Size = new System.Drawing.Size(92, 25);
            this.rb_premium.TabIndex = 6;
            this.rb_premium.TabStop = true;
            this.rb_premium.Text = "Premium";
            this.rb_premium.UseVisualStyleBackColor = true;
            // 
            // rb_standard
            // 
            this.rb_standard.AutoSize = true;
            this.rb_standard.Checked = true;
            this.rb_standard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_standard.Location = new System.Drawing.Point(23, 32);
            this.rb_standard.Name = "rb_standard";
            this.rb_standard.Size = new System.Drawing.Size(90, 25);
            this.rb_standard.TabIndex = 5;
            this.rb_standard.TabStop = true;
            this.rb_standard.Text = "Standard";
            this.rb_standard.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_stockDisponible);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(70, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 80);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // tb_stockDisponible
            // 
            this.tb_stockDisponible.BackColor = System.Drawing.SystemColors.Control;
            this.tb_stockDisponible.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_stockDisponible.Location = new System.Drawing.Point(264, 38);
            this.tb_stockDisponible.Name = "tb_stockDisponible";
            this.tb_stockDisponible.PlaceholderText = "_____________";
            this.tb_stockDisponible.Size = new System.Drawing.Size(100, 16);
            this.tb_stockDisponible.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(32, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Unidades de stock disponibles: ";
            // 
            // gb_prenda
            // 
            this.gb_prenda.Controls.Add(this.cb_chupin);
            this.gb_prenda.Controls.Add(this.cb_cuelloMao);
            this.gb_prenda.Controls.Add(this.cb_mangaCorta);
            this.gb_prenda.Controls.Add(this.rb_pantalon);
            this.gb_prenda.Controls.Add(this.rb_camisa);
            this.gb_prenda.Location = new System.Drawing.Point(70, 34);
            this.gb_prenda.Name = "gb_prenda";
            this.gb_prenda.Size = new System.Drawing.Size(525, 160);
            this.gb_prenda.TabIndex = 0;
            this.gb_prenda.TabStop = false;
            this.gb_prenda.Text = "Prenda";
            // 
            // cb_chupin
            // 
            this.cb_chupin.AutoSize = true;
            this.cb_chupin.Enabled = false;
            this.cb_chupin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_chupin.Location = new System.Drawing.Point(199, 108);
            this.cb_chupin.Name = "cb_chupin";
            this.cb_chupin.Size = new System.Drawing.Size(79, 25);
            this.cb_chupin.TabIndex = 4;
            this.cb_chupin.Text = "Chupin";
            this.cb_chupin.UseVisualStyleBackColor = true;
            // 
            // cb_cuelloMao
            // 
            this.cb_cuelloMao.AutoSize = true;
            this.cb_cuelloMao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_cuelloMao.Location = new System.Drawing.Point(341, 45);
            this.cb_cuelloMao.Name = "cb_cuelloMao";
            this.cb_cuelloMao.Size = new System.Drawing.Size(108, 25);
            this.cb_cuelloMao.TabIndex = 3;
            this.cb_cuelloMao.Text = "Cuello Mao";
            this.cb_cuelloMao.UseVisualStyleBackColor = true;
            // 
            // cb_mangaCorta
            // 
            this.cb_mangaCorta.AutoSize = true;
            this.cb_mangaCorta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_mangaCorta.Location = new System.Drawing.Point(199, 46);
            this.cb_mangaCorta.Name = "cb_mangaCorta";
            this.cb_mangaCorta.Size = new System.Drawing.Size(119, 25);
            this.cb_mangaCorta.TabIndex = 2;
            this.cb_mangaCorta.Text = "Manga Corta";
            this.cb_mangaCorta.UseVisualStyleBackColor = true;
            // 
            // rb_pantalon
            // 
            this.rb_pantalon.AutoSize = true;
            this.rb_pantalon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_pantalon.Location = new System.Drawing.Point(32, 108);
            this.rb_pantalon.Name = "rb_pantalon";
            this.rb_pantalon.Size = new System.Drawing.Size(88, 25);
            this.rb_pantalon.TabIndex = 1;
            this.rb_pantalon.Text = "Pantalon";
            this.rb_pantalon.UseVisualStyleBackColor = true;
            this.rb_pantalon.CheckedChanged += new System.EventHandler(this.rb_pantalon_CheckedChanged);
            // 
            // rb_camisa
            // 
            this.rb_camisa.AutoSize = true;
            this.rb_camisa.Checked = true;
            this.rb_camisa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_camisa.Location = new System.Drawing.Point(32, 45);
            this.rb_camisa.Name = "rb_camisa";
            this.rb_camisa.Size = new System.Drawing.Size(79, 25);
            this.rb_camisa.TabIndex = 0;
            this.rb_camisa.TabStop = true;
            this.rb_camisa.Text = "Camisa";
            this.rb_camisa.UseVisualStyleBackColor = true;
            this.rb_camisa.CheckedChanged += new System.EventHandler(this.rb_camisa_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.lb_historialCotizaciones);
            this.panel3.Controls.Add(this.lb_codigo);
            this.panel3.Controls.Add(this.lb_nombreVendedor);
            this.panel3.Location = new System.Drawing.Point(1, 163);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(673, 41);
            this.panel3.TabIndex = 9;
            // 
            // lb_historialCotizaciones
            // 
            this.lb_historialCotizaciones.AutoSize = true;
            this.lb_historialCotizaciones.Location = new System.Drawing.Point(505, 13);
            this.lb_historialCotizaciones.Name = "lb_historialCotizaciones";
            this.lb_historialCotizaciones.Size = new System.Drawing.Size(121, 15);
            this.lb_historialCotizaciones.TabIndex = 5;
            this.lb_historialCotizaciones.TabStop = true;
            this.lb_historialCotizaciones.Text = "Historial Cotizaciones";
            this.lb_historialCotizaciones.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_historialCotizaciones_LinkClicked);
            // 
            // lb_codigo
            // 
            this.lb_codigo.AutoSize = true;
            this.lb_codigo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_codigo.ForeColor = System.Drawing.Color.Blue;
            this.lb_codigo.Location = new System.Drawing.Point(270, 10);
            this.lb_codigo.Name = "lb_codigo";
            this.lb_codigo.Size = new System.Drawing.Size(116, 19);
            this.lb_codigo.TabIndex = 4;
            this.lb_codigo.Text = "Codigo Vendedor";
            // 
            // lb_nombreVendedor
            // 
            this.lb_nombreVendedor.AutoSize = true;
            this.lb_nombreVendedor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_nombreVendedor.ForeColor = System.Drawing.Color.Blue;
            this.lb_nombreVendedor.Location = new System.Drawing.Point(18, 10);
            this.lb_nombreVendedor.Name = "lb_nombreVendedor";
            this.lb_nombreVendedor.Size = new System.Drawing.Size(186, 19);
            this.lb_nombreVendedor.TabIndex = 2;
            this.lb_nombreVendedor.Text = "Nombre y Apellido Vendedor";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.lb_nombreTienda);
            this.panel2.Controls.Add(this.lb_direccionTienda);
            this.panel2.Location = new System.Drawing.Point(1, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(673, 41);
            this.panel2.TabIndex = 8;
            // 
            // lb_nombreVendedor
            // 
            this.lb_nombreTienda.AutoSize = true;
            this.lb_nombreTienda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_nombreTienda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(2)))), ((int)(((byte)(210)))));
            this.lb_nombreTienda.Location = new System.Drawing.Point(18, 10);
            this.lb_nombreTienda.Name = "lb_nombreVendedor";
            this.lb_nombreTienda.Size = new System.Drawing.Size(129, 21);
            this.lb_nombreTienda.TabIndex = 2;
            this.lb_nombreTienda.Text = "Nombre Tienda";
            // 
            // lb_direccionTienda
            // 
            this.lb_direccionTienda.AutoSize = true;
            this.lb_direccionTienda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_direccionTienda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(2)))), ((int)(((byte)(210)))));
            this.lb_direccionTienda.Location = new System.Drawing.Point(490, 10);
            this.lb_direccionTienda.Name = "lb_direccionTienda";
            this.lb_direccionTienda.Size = new System.Drawing.Size(180, 21);
            this.lb_direccionTienda.TabIndex = 3;
            this.lb_direccionTienda.Text = "Direccion de la Tienda";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.tb_cotizacionFinal);
            this.panel5.Controls.Add(this.btn_cotizar);
            this.panel5.Controls.Add(this.lb_signoPesoFinal);
            this.panel5.Location = new System.Drawing.Point(1, 656);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(673, 64);
            this.panel5.TabIndex = 10;
            // 
            // tb_cotizacionFinal
            // 
            this.tb_cotizacionFinal.BackColor = System.Drawing.SystemColors.Control;
            this.tb_cotizacionFinal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_cotizacionFinal.Enabled = false;
            this.tb_cotizacionFinal.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_cotizacionFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(2)))), ((int)(((byte)(210)))));
            this.tb_cotizacionFinal.Location = new System.Drawing.Point(381, 11);
            this.tb_cotizacionFinal.Name = "tb_cotizacionFinal";
            this.tb_cotizacionFinal.PlaceholderText = "___________________";
            this.tb_cotizacionFinal.Size = new System.Drawing.Size(214, 36);
            this.tb_cotizacionFinal.TabIndex = 2;
            // 
            // btn_cotizar
            // 
            this.btn_cotizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(2)))), ((int)(((byte)(210)))));
            this.btn_cotizar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cotizar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cotizar.Location = new System.Drawing.Point(70, 3);
            this.btn_cotizar.Name = "btn_cotizar";
            this.btn_cotizar.Size = new System.Drawing.Size(163, 58);
            this.btn_cotizar.TabIndex = 4;
            this.btn_cotizar.Text = "COTIZAR";
            this.btn_cotizar.UseVisualStyleBackColor = false;
            this.btn_cotizar.Click += new System.EventHandler(this.btn_cotizar_Click);
            // 
            // lb_signoPesoFinal
            // 
            this.lb_signoPesoFinal.AutoSize = true;
            this.lb_signoPesoFinal.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_signoPesoFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(2)))), ((int)(((byte)(210)))));
            this.lb_signoPesoFinal.Location = new System.Drawing.Point(334, 10);
            this.lb_signoPesoFinal.Name = "lb_signoPesoFinal";
            this.lb_signoPesoFinal.Size = new System.Drawing.Size(33, 37);
            this.lb_signoPesoFinal.TabIndex = 3;
            this.lb_signoPesoFinal.Text = "$";
            // 
            // FormAplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(677, 725);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormAplicacion";
            this.Text = "FormAplicacion";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.gb_precioUnitarioCantidad.ResumeLayout(false);
            this.gb_precioUnitarioCantidad.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_prenda.ResumeLayout(false);
            this.gb_prenda.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel4;
        private GroupBox gb_precioUnitarioCantidad;
        private TextBox tb_cantidad;
        private Label lb_cantidad;
        private Label lb_signoPeso;
        private TextBox tb_precio;
        private GroupBox groupBox2;
        private RadioButton rb_premium;
        private RadioButton rb_standard;
        private GroupBox groupBox1;
        private TextBox tb_stockDisponible;
        private Label label2;
        private GroupBox gb_prenda;
        private CheckBox cb_chupin;
        private CheckBox cb_cuelloMao;
        private CheckBox cb_mangaCorta;
        private RadioButton rb_pantalon;
        private RadioButton rb_camisa;
        private Panel panel3;
        private LinkLabel lb_historialCotizaciones;
        private Label lb_codigo;
        private Label lb_nombreVendedor;
        private Label lb_titulo;
        private Panel panel2;
        private Label lb_nombreTienda;
        private Label lb_direccionTienda;
        private Panel panel5;
        private TextBox tb_cotizacionFinal;
        private Button btn_cotizar;
        private Label lb_signoPesoFinal;
        private Label lb_mensajeError;
    }
}