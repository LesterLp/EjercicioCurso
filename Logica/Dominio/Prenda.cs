using System.Text;

namespace Logica
{

    public enum ECalidad
    {
        Standard,
        Premium
    }

    public abstract class Prenda
    {
        protected ECalidad calidad;
        protected int cantidadStock;

        internal ECalidad Calidad { get => calidad; }
        internal int CantidadStock { get => cantidadStock; }

        public Prenda(ECalidad calidad, int cantidadStock)
        {
            this.calidad = calidad;
            this.cantidadStock = cantidadStock;
        }

        public abstract double CalcularPrecio(float precioFinal);

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Calidad: {calidad}");
            sb.Append($"CantidadStock: {cantidadStock}");

            return sb.ToString();
        }

    }
}