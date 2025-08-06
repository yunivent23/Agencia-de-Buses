using System;
using System.Drawing;
using System.Windows.Forms;
using Negocio.Negocio;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Presentacion1
{
    public partial class Consultas : MaterialForm
    {
        private NConsulta consultaNegocio = new NConsulta();
        private MaterialSkinManager skinManager;
        private MaterialButton btnConsultar;

        public Consultas()
        {
            InitializeComponent();

            // Configurar el MaterialSkinManager
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(
               Primary.Green600, Primary.Green700,
                Primary.Green700, Accent.LightGreen200,
                TextShade.WHITE
            );

            // Crear botón de Material
            btnConsultar = new MaterialButton
            {
                Text = "Reporte Detallado",
                Location = new Point(20, 80),
                Width = 150
            };
            btnConsultar.Click += BtnConsultar_Click;
            this.Controls.Add(btnConsultar);

            // Configurar el DataGridView (si no lo hiciste desde el diseñador)
            dgConsultas.Location = new Point(20, 140);
            dgConsultas.Width = 750;
            dgConsultas.Height = 350;
            dgConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgConsultas.ReadOnly = true;
            dgConsultas.AllowUserToAddRows = false;

            // Asegúrate de que esté en el formulario
            this.Controls.Add(dgConsultas);
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                var reporte = consultaNegocio.ObtenerReporteBuses();
                dgConsultas.DataSource = reporte;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el reporte: " + ex.Message);
            }
        }

        private void Consultas_Load(object sender, EventArgs e)
        {

        }

        private void dgConsultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
