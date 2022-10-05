using System.Text;

namespace Logica
{
    public class Cotizacion
    {
        static int idCotizacion;
        int numIdentificacion;
        DateTime fecha;
        int idVendedor;
        Prenda prendaCotizada;
        int cantPrendasCotizadas;
        double costoCotizacion;

        static Cotizacion()
        {
            idCotizacion = 0;
        }

        public Cotizacion(DateTime fecha, int idVendedor, Prenda prendaCotizada, int cantPrendasCotizadas, double costoCotizacion)
        {
            idCotizacion++;
            this.numIdentificacion = idCotizacion;
            this.fecha = fecha;
            this.idVendedor = idVendedor;
            this.prendaCotizada = prendaCotizada;
            this.cantPrendasCotizadas = cantPrendasCotizadas;
            this.costoCotizacion = costoCotizacion * cantPrendasCotizadas;
        }

        public double GetCostoCotizacion()
        {
            return costoCotizacion;
        }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.Append($"Id cotizacion:{numIdentificacion} -");
            sb.Append($"Fecha:{fecha} -");
            sb.Append($"Id Vendedor:{idVendedor} -");
            sb.Append($"Prenda cotizada:{prendaCotizada.ToString()} -");
            sb.Append($"Cantidad cotizado:{cantPrendasCotizadas} -");
            sb.Append($"Costo cotizacion:{costoCotizacion} -");

            return sb.ToString();
        }
    }
}