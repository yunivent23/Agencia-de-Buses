using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion1
{
    public partial class Asientos_Disponibles : Form
    {
        public Asientos_Disponibles()
        {
            InitializeComponent();
        }

        private List<Asientos> listaAsientos;
        public List<string> idAsientosSeleccionados { get; private set; } = new List<string>();


        public void GenerarAsientos(List<Asientos> asientos, List<string> asientosOcupados)
        {
            TableLayoutPanel tablaAsientos = new TableLayoutPanel
            {
                RowCount = asientos.Count / 4 + 1,
                ColumnCount = 5,
                Dock = DockStyle.Fill,
                Padding = new Padding(10),
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
            };

            for (int i = 0; i < 5; i++)
                tablaAsientos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            for (int i = 0; i < tablaAsientos.RowCount; i++)
                tablaAsientos.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / tablaAsientos.RowCount));

            int contador = 0;
            for (int fila = 0; fila < tablaAsientos.RowCount; fila++)
            {
                for (int col = 0; col < 5; col++)
                {
                    if (col == 2) continue; // pasillo

                    if (contador >= asientos.Count) break;

                    var asiento = asientos[contador++];
                    Button btn = new Button
                    {
                        Dock = DockStyle.Fill,
                        Font = new Font("Segoe UI Emoji", 10),
                        Text = asiento.Numero + "\n💺",
                        Tag = asiento,
                        Name = "Asiento" + asiento.Id_Asiento,
                        FlatStyle = FlatStyle.Flat,
                        FlatAppearance = { BorderSize = 0 }
                    };

                    if (asientosOcupados.Contains(asiento.Id_Asiento))
                    {
                        btn.BackColor = Color.Red;
                        btn.Enabled = false;
                    }
                    else
                    {
                        btn.BackColor = Color.LightGreen;
                        btn.Click += Asiento_Click;
                        ToolTip tip = new ToolTip();
                        tip.SetToolTip(btn, "Tipo: " + asiento.Tipo);
                    }

                    tablaAsientos.Controls.Add(btn, col, fila);
                }
            }

            panelAsientos.Controls.Clear();
            panelAsientos.Controls.Add(tablaAsientos);
        }



        private void Asiento_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Tag is Asientos asiento)
            {
                if (btn.BackColor == Color.LightGreen)
                {
                    btn.BackColor = Color.LightBlue;
                }
                else if (btn.BackColor == Color.LightBlue)
                {
                    btn.BackColor = Color.LightGreen;
                }
            }
        }

        /*private void Gestión_de_Pasajeros_y_Boletos_Load(object sender, EventArgs e)
        {
            GenerarAsientos();
        }*/

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            idAsientosSeleccionados.Clear();

            if (panelAsientos.Controls.Count > 0 && panelAsientos.Controls[0] is TableLayoutPanel tabla)
            {
                foreach (Control control in tabla.Controls)
                {
                    if (control is Button btn && btn.Tag is Asientos asiento && btn.BackColor == Color.LightBlue)
                    {
                        idAsientosSeleccionados.Add(asiento.Id_Asiento);
                    }
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }



        private void btnLimpiarSelección_Click(object sender, EventArgs e)
        {
            idAsientosSeleccionados.Clear();
            if (panelAsientos.Controls.Count > 0 && panelAsientos.Controls[0] is TableLayoutPanel tabla)
            {
                foreach (Control control in tabla.Controls)
                {
                    if (control is Button btn && btn.Tag is Asientos asiento && btn.BackColor == Color.LightBlue)
                    {
                        btn.BackColor = Color.LightGreen;
                    }
                }
            }
        }
    }
}
