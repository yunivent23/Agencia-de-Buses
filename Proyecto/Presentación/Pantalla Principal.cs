using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación
{
    public partial class Pantalla_Principal : Form
    {
        public Pantalla_Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gestión_de_Flota_y_Personal form = new Gestión_de_Flota_y_Personal();
            form.Show();
        }

        private void btnRutaViajes_Click(object sender, EventArgs e)
        {
            Gestión_de_Ruta_y_Viajes form = new Gestión_de_Ruta_y_Viajes();
            form.Show();
        }
    }
}
