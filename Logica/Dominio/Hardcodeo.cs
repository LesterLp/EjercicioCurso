namespace Logica
{
    internal class Hardcodeo
    {

        public static List<Prenda> HardcodeoRopa()
        {
            List<Prenda> auxPrendas = new List<Prenda>();
            HardcodearCamisas(auxPrendas);
            HardcodearPantalones(auxPrendas);

            return auxPrendas;
        }

        private static void HardcodearPantalones(List<Prenda> auxPrendas)
        {
            auxPrendas.Add(new Pantalon(ETipoPantalon.Chupin, ECalidad.Standard, 750));
            auxPrendas.Add(new Pantalon(ETipoPantalon.Chupin, ECalidad.Premium, 750));

            auxPrendas.Add(new Pantalon(ETipoPantalon.Comun, ECalidad.Standard, 250));
            auxPrendas.Add(new Pantalon(ETipoPantalon.Comun, ECalidad.Premium, 250));
        }

        private static void HardcodearCamisas(List<Prenda> auxPrendas)
        {
            auxPrendas.Add(new Camisa(ETipoManga.Corta, ETipoCuello.Mao, ECalidad.Standard, 100));
            auxPrendas.Add(new Camisa(ETipoManga.Corta, ETipoCuello.Mao, ECalidad.Premium, 100));
            auxPrendas.Add(new Camisa(ETipoManga.Corta, ETipoCuello.Comun, ECalidad.Standard, 150));
            auxPrendas.Add(new Camisa(ETipoManga.Corta, ETipoCuello.Comun, ECalidad.Premium, 150));


            auxPrendas.Add(new Camisa(ETipoManga.Larga, ETipoCuello.Mao, ECalidad.Standard, 75));
            auxPrendas.Add(new Camisa(ETipoManga.Larga, ETipoCuello.Mao, ECalidad.Premium, 75));
            auxPrendas.Add(new Camisa(ETipoManga.Larga, ETipoCuello.Comun, ECalidad.Standard, 175));
            auxPrendas.Add(new Camisa(ETipoManga.Larga, ETipoCuello.Comun, ECalidad.Premium, 175));
        }

    }
}