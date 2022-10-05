using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public enum ETipoPantalon
    {
        Comun,
        Chupin
    }
    internal class Pantalon : Prenda
    {

        ETipoPantalon tipoPantalon;


        internal Pantalon(ETipoPantalon tipoPantalon, ECalidad calidad, int cantidadStock) : base(calidad, cantidadStock)
        {
            this.tipoPantalon = tipoPantalon;
        }

        internal ETipoPantalon TipoPantalon { get => tipoPantalon; set => tipoPantalon = value; }

        public override double CalcularPrecio(float precioFinal)
        {
            if (tipoPantalon == ETipoPantalon.Chupin)
                precioFinal *= 0.88f;

            if (calidad == ECalidad.Premium)
                precioFinal *= 1.30f;

            return Math.Round(precioFinal,2);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Prenda: Pantalon -");
            sb.Append($"Tipo: {tipoPantalon} -");
            sb.Append(base.ToString());

            return sb.ToString();
        }
    }
}
