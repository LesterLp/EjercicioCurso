namespace Vista
{
    partial class FormularioHistorico
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_nombreVendedor = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listbox_datosHistoricos = new System.Windows.Forms.ListBox();
            panel1 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(2)))), ((int)(((byte)(210)))));
            panel1.Controls.Add(this.lb_titulo);
            panel1.ForeColor = System.Drawing.Color.DarkBlue;
            panel1.Location = new System.Drawing.Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1536, 109);
            panel1.TabIndex = 12;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_titulo.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_titulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_titulo.Location = new System.Drawing.Point(185, 30);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(568, 47);
            this.lb_titulo.TabIndex = 0;
            this.lb_titulo.Text = "Historial Cotizaciones Tienda Quark";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.lb_nombreVendedor);
            this.panel2.Location = new System.Drawing.Point(12, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1536, 41);
            this.panel2.TabIndex = 13;
            // 
            // lb_nombreVendedor
            // 
            this.lb_nombreVendedor.AutoSize = true;
            this.lb_nombreVendedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_nombreVendedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(2)))), ((int)(((byte)(210)))));
            this.lb_nombreVendedor.Location = new System.Drawing.Point(18, 10);
            this.lb_nombreVendedor.Name = "lb_nombreVendedor";
            this.lb_nombreVendedor.Size = new System.Drawing.Size(151, 21);
            this.lb_nombreVendedor.TabIndex = 2;
            this.lb_nombreVendedor.Text = "Nombre Vendedor";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.listbox_datosHistoricos);
            this.panel4.Location = new System.Drawing.Point(12, 174);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1536, 432);
            this.panel4.TabIndex = 16;
            // 
            // listbox_datosHistoricos
            // 
            this.listbox_datosHistoricos.FormattingEnabled = true;
            this.listbox_datosHistoricos.ItemHeight = 15;
            this.listbox_datosHistoricos.Location = new System.Drawing.Point(3, 19);
            this.listbox_datosHistoricos.Name = "listbox_datosHistoricos";
            this.listbox_datosHistoricos.Size = new System.Drawing.Size(1528, 409);
            this.listbox_datosHistoricos.TabIndex = 0;
            // 
            // FormularioHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1555, 609);
            this.Controls.Add(this.panel4);
            this.Controls.Add(panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FormularioHistorico";
            this.Text = "FormularioHistorico";
            this.Load += new System.EventHandler(this.FormularioHistorico_Load);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Label lb_titulo;
        private Panel panel2;
        private Label lb_nombreVendedor;
        private Panel panel4;
        private ListBox listbox_datosHistoricos;
    }
}