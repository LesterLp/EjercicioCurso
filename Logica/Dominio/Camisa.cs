using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{

    public enum ETipoManga
    {
        Corta,
        Larga
    }

    public enum ETipoCuello
    {
        Mao,
        Comun
    }

    public class Camisa : Prenda
    {
        ETipoManga tipoManga;
        ETipoCuello tipoCuello;

        public Camisa(ETipoManga tipoManga, ETipoCuello tipoCuello, ECalidad calidad, int cantidadStock) : base(calidad,cantidadStock)
        {
            this.tipoManga = tipoManga;
            this.tipoCuello = tipoCuello;
        }

        public ETipoManga TipoManga { get => tipoManga; }
        public ETipoCuello TipoCuello { get => tipoCuello; }

        public override double CalcularPrecio(float precioFinal)
        {

            if (tipoManga == ETipoManga.Corta)
                precioFinal *= 0.90f;

            if (tipoCuello == ETipoCuello.Mao)
                precioFinal *= 1.03f;

            if (calidad == ECalidad.Premium)
                precioFinal *= 1.30f;

            return Math.Round(precioFinal, 2);

        }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();

            sb.Append("Prenda: Camisa -");
            sb.Append($"Tipo Manga: {tipoManga} -");
            sb.Append($"Tipo Cuello: {tipoCuello} -");
            sb.Append(base.ToString());

            return sb.ToString();
        }

    }
}
