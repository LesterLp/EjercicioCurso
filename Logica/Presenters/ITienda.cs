using System.Globalization;

namespace Logica.Presenters
{
    public interface ITienda
    {
        string Nombre { get; set; }
        string Direccion { get; set; }
        string NombreVendedor { get; set; }
        string CodigoVendedor { get; set; }
        bool EsCamisa { get; }
        bool EsPantalon { get; }
        bool EsMangaCorta { get; }
        bool EsCuelloMao { get; }
        bool EsChupin { get; }
        string Precio { get; }
        string Cantidad { get; }
        bool EsStandard { get; }
        bool EsPremium { get; }
        string Cotizacion { set; }
        string Stock { get; set; }

        void AbrirFormularioHistorico(string vendedor, List<string> cotizacionHistorica);
        void MostrarError(string error);
    }
}