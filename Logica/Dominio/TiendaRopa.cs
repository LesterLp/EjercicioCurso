using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    internal class TiendaRopa
    {
        string nombre;
        string direccion;
        List<Prenda> stockPrendas;
        Vendedor vendedor;


        internal TiendaRopa(string nombre, string direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            vendedor = new Vendedor("Pepe", "Peposo", 123123);
            stockPrendas = Hardcodeo.HardcodeoRopa();
        }

        internal Vendedor Vendedor { get => vendedor; }
        internal string Direccion { get => this.direccion; }
        internal string Nombre { get => this.nombre; }
        internal List<Prenda> StockPrendas { get => stockPrendas; set => stockPrendas = value; }


        public Prenda? ObtenerPantalon(int cantidad, ECalidad calidad, ETipoPantalon tipoPantalon)
        {
            return FiltrarPantalones().Find(pantalon =>
                                        pantalon.Calidad == calidad
                                        && ((Pantalon)pantalon).TipoPantalon == tipoPantalon);
        }

        private List<Prenda> FiltrarPantalones()
        {
            return stockPrendas.FindAll(prenda => prenda is Pantalon);
        }

        public Prenda? ObtenerCamisa(int cantidad, ECalidad calidad, ETipoCuello tipoCuello, ETipoManga tipoManga)
        {
            List<Prenda> listaFiltradaCamisas = FiltrarCamisas();

            return listaFiltradaCamisas.Find(camisa =>
                                        camisa.Calidad == calidad
                                        && ((Camisa)camisa).TipoManga == tipoManga
                                        && ((Camisa)camisa).TipoCuello == tipoCuello);
        }

        private List<Prenda> FiltrarCamisas()
        {
            return stockPrendas.FindAll(prenda => prenda is Camisa);
        }

    }
}

