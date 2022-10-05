using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Presenters
{
    public class TiendaPresenter
    {
        TiendaRopa tienda;
        ITienda? vista;

        private TiendaPresenter()
        {
            tienda = new TiendaRopa("TIENDA QUARK", "CALLE FALSA 123");
        }
        public TiendaPresenter(ITienda vista) : this()
        {
            this.vista = vista;
            LlenarCamposVista();
        }

        private void LlenarCamposVista()
        {
            vista.Nombre = tienda.Nombre;
            vista.Direccion = tienda.Direccion;
            vista.NombreVendedor = tienda.Vendedor.ToString();
            vista.CodigoVendedor = tienda.Vendedor.CodigoVendedor.ToString();

        }

        public void Cotizar()
        {
            try
            {
                int cantidad = ValidarDatoIngresado(vista.Cantidad, "cantidad");
                int precio = ValidarDatoIngresado(vista.Precio, "precio");

                CotizarPrenda(cantidad, precio);

            }
            catch (Exception ex)
            {
                vista.MostrarError(ex.Message);
            }
        }

        private int ValidarDatoIngresado(string datoAValidar, string mensaje)
        {
            if (!int.TryParse(datoAValidar, out int valor) || valor < 1)
                throw new Exception($"Ingrese una valor valido para {mensaje}");
            return valor;
        }

        private void CotizarPrenda(int cantidad, int precio)
        {
            ECalidad calidad = ObtenerTipoCalidad();

            Prenda? prenda = vista.EsCamisa ?
                                    tienda.ObtenerCamisa(cantidad, calidad, ObtenerTipoCuello(), ObtenerTipoManga()) :
                                    tienda.ObtenerPantalon(cantidad, calidad, ObtenerTipoPantalon());

            if (prenda is null)
                throw new Exception("No hay prendas con esas caracteristicas");

            vista.Stock = prenda.CantidadStock.ToString();

            if (cantidad > prenda.CantidadStock)
                throw new Exception("No hay stock suficiente");

            vista.Cotizacion = tienda.Vendedor.AgregarCotizacion(prenda, precio, cantidad).ToString();

        }

        private ECalidad ObtenerTipoCalidad()
        {
            return vista.EsPremium ? ECalidad.Premium : ECalidad.Standard;
        }

        private ETipoPantalon ObtenerTipoPantalon()
        {
            return vista.EsChupin ? ETipoPantalon.Chupin : ETipoPantalon.Comun;
        }

        private ETipoManga ObtenerTipoManga()
        {
            return vista.EsMangaCorta ? ETipoManga.Corta : ETipoManga.Larga;
        }

        private ETipoCuello ObtenerTipoCuello()
        {
            return vista.EsCuelloMao ? ETipoCuello.Mao : ETipoCuello.Comun;
        }

        public void MostrarHistorialVentas()
        {
            List<string> cotizacionHistorica = tienda.Vendedor.RetornarCotizacionHistorica();

            vista.AbrirFormularioHistorico(tienda.Vendedor.ToString(), cotizacionHistorica);

        }
    }
}
