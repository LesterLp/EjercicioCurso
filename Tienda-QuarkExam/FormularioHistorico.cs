using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormularioHistorico : Form
    {
        private readonly List<string> historial;
        private string nombreVendedor;

        public FormularioHistorico(string nombreVendedor, List<string> historial)
        {
            InitializeComponent();
            this.nombreVendedor = nombreVendedor;
            this.historial = historial;
        }


        private void FormularioHistorico_Load(object sender, EventArgs e)
        {
            this.lb_nombreVendedor.Text = nombreVendedor;
            listbox_datosHistoricos.DataSource = historial;
        }
    }
}
