using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica.Presenters;

namespace Vista
{
    public partial class FormAplicacion : Form, ITienda
    {
        TiendaPresenter tienda;
        public FormAplicacion()
        {
            InitializeComponent();
            tienda = new TiendaPresenter(this);
        }

        public string Nombre { get => this.lb_nombreTienda.Text; set => this.lb_nombreTienda.Text = value; }
        public string Direccion { get => this.lb_direccionTienda.Text; set => this.lb_direccionTienda.Text = value; }
        public string NombreVendedor { get => this.lb_nombreVendedor.Text; set => this.lb_nombreVendedor.Text = value; }
        public string CodigoVendedor { get => this.lb_codigo.Text; set => lb_codigo.Text = value; }

        public bool EsCamisa { get => this.rb_camisa.Checked; }
        public bool EsPantalon { get => this.rb_camisa.Checked; }
        public bool EsMangaCorta { get => this.cb_mangaCorta.Checked; }
        public bool EsCuelloMao { get => this.cb_cuelloMao.Checked; }
        public bool EsChupin { get => this.cb_chupin.Checked; }

        public bool EsStandard { get => this.rb_standard.Checked; }
        public bool EsPremium { get => this.rb_premium.Checked; }

        public string Precio { get => this.tb_precio.Text; }
        public string Cantidad { get => this.tb_cantidad.Text; }
        public string Stock { get => this.tb_stockDisponible.Text; set => this.tb_stockDisponible.Text = value; }

        public string Cotizacion { set => this.tb_cotizacionFinal.Text = value; }

        private void btn_cotizar_Click(object sender, EventArgs e)
        {
            lb_mensajeError.Text = "";
            lb_mensajeError.Visible = false;
            tienda.Cotizar();
        }

        private void rb_camisa_CheckedChanged(object sender, EventArgs e)
        {
            this.cb_mangaCorta.Enabled = true;
            this.cb_cuelloMao.Enabled = true;
            this.cb_chupin.Checked = false;
            this.cb_chupin.Enabled = false;
        }

        private void rb_pantalon_CheckedChanged(object sender, EventArgs e)
        {
            this.cb_chupin.Enabled = true;
            this.cb_mangaCorta.Checked = false;
            this.cb_cuelloMao.Checked = false;
            this.cb_mangaCorta.Enabled = false;
            this.cb_cuelloMao.Enabled = false;
        }

        public void MostrarError(string error)
        {
            lb_mensajeError.Visible = true;
            this.lb_mensajeError.Text = error;
        }

        private void lb_historialCotizaciones_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tienda.MostrarHistorialVentas();
        }

        public void AbrirFormularioHistorico(string vendedor, List<string> cotizacionHistorica)
        {
            new FormularioHistorico(vendedor, cotizacionHistorica).ShowDialog();
        }
    }
}
