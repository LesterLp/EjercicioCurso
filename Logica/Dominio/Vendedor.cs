using System.Linq;

namespace Logica
{
    public class Vendedor
    {
        string nombre;
        string apellido;
        int codigoVendedor;
        List<Cotizacion> historialCotizaciones;

        public Vendedor(string nombre, string apellido, int codigoVendedor)
        {
            historialCotizaciones = new List<Cotizacion>();
            this.nombre = nombre;
            this.apellido = apellido;
            this.codigoVendedor = codigoVendedor;
        }

        public int CodigoVendedor { get => codigoVendedor; }

        public double AgregarCotizacion(Prenda prendaCotizada, int cantidadPrendas, float precio)
        {
            double precioPrendaCotizada = prendaCotizada.CalcularPrecio(precio);
            Cotizacion cotizacion = new Cotizacion(DateTime.Now, codigoVendedor, prendaCotizada, cantidadPrendas, precioPrendaCotizada);
            historialCotizaciones.Add(cotizacion);

            return cotizacion.GetCostoCotizacion();
        }

        public override string ToString()
        {
            return apellido + "," + nombre;
        }

        public List<string> RetornarCotizacionHistorica()
        {
            return historialCotizaciones.Select(item => item.ToString()).ToList()!;
        }


    }
}