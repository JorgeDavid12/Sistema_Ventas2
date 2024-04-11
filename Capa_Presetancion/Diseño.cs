using System;
using Capa_Logica;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presetancion
{
    public partial class Diseño : Form
    {
        public Diseño()
        {
            InitializeComponent();
        }

        private void cboxCodigoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Logica logica = new Logica();
            logica.vcpCodigoProducto = cboxCodigoProducto.Text;

            lblNombre.Text = logica.mtdNombre();
            lblPrecio.Text = logica.mtdRetornaPrecio().ToString("c");
        }

        private void Diseño_Load(object sender, EventArgs e)
        {
            Logica logica = new Logica();

            lblFecha.Text = logica.mtdRecuperaFechaHoy().ToString("d");
        }
    }
}
