using Datos;
using Negocio;
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
    public partial class Mantenimiento_de_Asientos : Form
    {
        private NAsiento nAsiento = new NAsiento();
        private NBus nBuses = new NBus();
        int id;
        public Mantenimiento_de_Asientos(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        private int ObtenerCapacidadBus(int idBus)
        {
            Datos.Buses bus = new NBus().BuscarPorId(idBus);
            return bus != null ? bus.Capacidad : 0;
        }

        /*private void MostrarAsientos(string idBus)
        {
            panelAsientos.Controls.Clear();

            var asientos = new NAsiento().ListarPorBus(idBus).OrderBy(a => a.Numero).ToList();

            int columnas = 5; // 2 asientos + 1 pasillo + 2 asientos
            int filas = (int)Math.Ceiling(asientos.Count / 4.0); // 4 asientos por fila (sin contar pasillo)

            TableLayoutPanel tabla = new TableLayoutPanel
            {
                RowCount = filas,
                ColumnCount = columnas,
                Dock = DockStyle.Fill,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single,
                Padding = new Padding(10),
            };

            for (int i = 0; i < columnas; i++)
                tabla.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / columnas));
            for (int i = 0; i < filas; i++)
                tabla.RowStyles.Add(new RowStyle(SizeType.Absolute, 60));

            int columna = 0, fila = 0;

            foreach (var asiento in asientos)
            {
                if (columna == 2) columna++; // saltar pasillo

                // Crear Label para emoji + número debajo
                Label lblAsiento = new Label
                {
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    Font = new Font("Segoe UI Emoji", 14, FontStyle.Bold),
                    Text = $"💺\n{asiento.Numero}",
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = GetColorPorTipo(asiento),
                    ForeColor = Color.Black
                };

                tabla.Controls.Add(lblAsiento, columna, fila);

                columna++;
                if (columna > 4)
                {
                    columna = 0;
                    fila++;
                }
            }

            panelAsientos.Controls.Add(tabla);
        }
        */



        private Color GetColorPorTipo(Asientos asiento)
        {
            if (asiento.Numero == 1 || asiento.Numero == 2)
                return Color.Black;

            if (asiento.Tipo.Equals("Preferencial", StringComparison.OrdinalIgnoreCase))
                return Color.Gold;

            return Color.LightGreen;
        }

        private void MostrarAsientos(int idBus)
        {
            panelAsientos.Controls.Clear();
            panelAsientos.AutoScroll = true;

            var asientos = new NAsiento().ListarPorBus(idBus).OrderBy(a => a.Numero).ToList();

            int columnas = 5; // 2 asientos + pasillo + 2 asientos
            int filas = (int)Math.Ceiling(asientos.Count / 4.0); // 4 asientos por fila
            int totalFilas = filas + 1; // una fila extra para "Entrada Bus"

            TableLayoutPanel tabla = new TableLayoutPanel
            {
                RowCount = totalFilas,
                ColumnCount = columnas,
                Dock = DockStyle.Top,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single,
                Padding = new Padding(10),
                AutoSize = false,
                Width = panelAsientos.Width - 20,
                Height = totalFilas * 65
            };

            for (int i = 0; i < columnas; i++)
                tabla.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / columnas));
            for (int i = 0; i < totalFilas; i++)
                tabla.RowStyles.Add(new RowStyle(SizeType.Absolute, 60));

            // Fila superior - entrada bus
            tabla.Controls.Add(new Label
            {
                Text = "Entrada Bus",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.DarkSlateGray,
                BackColor = Color.LightGray
            }, 4, 0); // columna 4, fila 0

            int asientoIndex = 0;

            for (int fila = 1; fila < totalFilas; fila++) // comienza en fila 1
            {
                for (int columna = 0; columna < columnas; columna++)
                {
                    if (columna == 2) continue; // pasillo

                    if (asientoIndex >= asientos.Count) break;

                    var asiento = asientos[asientoIndex++];

                    Label lblAsiento = new Label
                    {
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Fill,
                        Font = new Font("Segoe UI", 10, FontStyle.Bold),
                        Text = $"💺\n{asiento.Numero}",
                        BorderStyle = BorderStyle.FixedSingle,
                        BackColor = GetColorPorTipo(asiento),
                        ForeColor = Color.Black,
                        Padding = new Padding(0),
                        Margin = new Padding(2)
                    };

                    tabla.Controls.Add(lblAsiento, columna, fila);
                }
            }

            panelAsientos.Controls.Add(tabla);
        }



        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (txtNumAsiento.Text == "")
            {
                MessageBox.Show("Ingrese el número del asiento a asignar.");
                return;
            }

            if (!int.TryParse(txtNumAsiento.Text.Trim(), out int numeroAsiento))
            {
                MessageBox.Show("Ingrese un número válido para el asiento.", "Formato incorrecto");
                txtNumAsiento.Clear();
                txtNumAsiento.Focus();
                return;
            }

            int capacidad = ObtenerCapacidadBus(this.id);
            if (numeroAsiento <= 2 || numeroAsiento > capacidad)
            {
                MessageBox.Show($"Asiento fuera de rango. El número debe ser mayor a 2 y menor o igual a la capacidad del bus ({capacidad}).", "Asiento inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumAsiento.Clear();
                txtNumAsiento.Focus();
                return;
            }

            string idAsiento = $"{this.id}{numeroAsiento:D2}"; // e.g., B23 + 05 = B2305

            try
            {
                bool actualizado = nAsiento.Modificar(idAsiento, "Preferencial");

                if (actualizado)
                {
                    MessageBox.Show($"Asiento {numeroAsiento} asignado como 'Preferencial'.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNumAsiento.Clear();
                }
                else
                {
                    MessageBox.Show("No se encontró el asiento para actualizar. Verifique si existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al asignar asiento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            MostrarAsientos(this.id);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mantenimiento_de_Asientos_Load(object sender, EventArgs e)
        {
            int capacidad = ObtenerCapacidadBus(this.id);
            lblCapacidad.Text = $"{capacidad - 2} asientos";
            MostrarAsientos(this.id);
        }
    }
}
