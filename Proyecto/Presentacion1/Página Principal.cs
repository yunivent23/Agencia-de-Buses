//using Presentación;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Presentacion1
//{
//    public partial class Página_Principal : Form
//    {
//        public Página_Principal()
//        {
//            InitializeComponent();
//            Bitmap img = new Bitmap(Application.StartupPath + @"\img\img1.png");
//            this.BackgroundImage = img;
//            this.BackgroundImageLayout = ImageLayout.Stretch;
//        }

//        private void btnFlotaPersonal_Click(object sender, EventArgs e)
//        {
//            Gestión_de_Flota_y_Personal form = new Gestión_de_Flota_y_Personal();
//            form.Show();
//        }

//        private void btnRutaViajes_Click(object sender, EventArgs e)
//        {
//            Gestión_de_Ruta_y_Viajes form = new Gestión_de_Ruta_y_Viajes();
//            form.Show();
//        }

//        private void btnSalir_Click(object sender, EventArgs e)
//        {
//            this.Close();
//        }

//        private void btnPasajerosBoletos_Click(object sender, EventArgs e)
//        {
//            Gestión_de_Pasajeros_y_Boletos form = new Gestión_de_Pasajeros_y_Boletos();
//            form.Show();
//        }

//        private void Página_Principal_Load(object sender, EventArgs e)
//        {

//        }

//        private void btnCossultas_Click(object sender, EventArgs e)
//        {
//            Consultas form = new Consultas();
//            form.Show();
//        }
//    }
//}

using MaterialSkin;
using MaterialSkin.Controls;
using Presentación;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion1
{
    public partial class Página_Principal : MaterialForm
    {
        private MaterialSkinManager skinManager;

        public Página_Principal()
        {
            InitializeComponent();

            // Configurar MaterialSkin
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(
                Primary.Green600, Primary.Green700,
                Primary.Green700, Accent.LightGreen200,
                TextShade.WHITE
            );

            // Fondo desde recursos
            this.BackgroundImage = Properties.Resources.img1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.DoubleBuffered = true;
            this.DoubleBuffered = true;
            this.BackColor = Color.White;

            //this.BackgroundImage = Image.FromFile("D:\\Windows Data\\Imágenes\\Proyecto\\Proyecto\\Presentacion1\\bin\\Debug\\img\\img1.png");
            //this.BackgroundImageLayout = ImageLayout.Stretch;

        
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Gestión_de_Flota_y_Personal form = new Gestión_de_Flota_y_Personal();
                   form.Show();
        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            Gestión_de_Ruta_y_Viajes form = new Gestión_de_Ruta_y_Viajes();
            form.Show();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            Gestión_de_Pasajeros_y_Boletos form = new Gestión_de_Pasajeros_y_Boletos();
             form.Show();
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            Consultas form = new Consultas();
                 form.Show();
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Página_Principal_Load(object sender, EventArgs e)
        {

        }

      
    }
}
