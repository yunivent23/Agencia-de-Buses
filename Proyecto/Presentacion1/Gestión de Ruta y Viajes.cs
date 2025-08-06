using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Negocio;
using static Negocio.NConductor;

namespace Presentación
{
    public partial class Gestión_de_Ruta_y_Viajes : Form
    {
        private NRuta nRuta = new NRuta();
        private NViaje nViaje = new NViaje();
        private Negocio.NBus nBus = new Negocio.NBus();
        private NConductor nConductor = new NConductor();
        private NBoleto nBoleto = new NBoleto(); 

        public Gestión_de_Ruta_y_Viajes()
        {
            InitializeComponent();
            this.dgRuta.CellClick += new DataGridViewCellEventHandler(this.dgRuta_CellClick);
            this.dgViajes.CellClick += new DataGridViewCellEventHandler(this.dgViajes_CellClick);

            MostrarRuta(nRuta.ListarTodo());
            MostrarVIAJES(nBus.ListarTodo(), nConductor.ListarTodo(), nRuta.ListarTodo());
            MostrarViaje(nViaje.ListarTodo());
            dtSalida.Format = DateTimePickerFormat.Custom;
            dtSalida.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtLlegada.Format = DateTimePickerFormat.Custom;
            dtLlegada.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtLlegada.ShowUpDown = true;
            dtSalida.ShowUpDown = true;
        }

        //prueba
        private void dgRuta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgRuta.Rows[e.RowIndex];
             
                cbOrigen.Text = row.Cells["Origen"].Value.ToString();
                cbDestino.Text = row.Cells["Destino"].Value.ToString();
                txtDistancia.Text = row.Cells["Distancia_Km"].Value.ToString();
                txtDuracion.Text = row.Cells["Duracion_Estimada"].Value.ToString();
            }
        }

        private void dgViajes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgViajes.Rows[e.RowIndex];

                cbBusViaj.Text = row.Cells["Id_Bus1"].Value.ToString();
                cbConductorViaj.Text = row.Cells["Id_Conductor"].Value.ToString();
                cbRutaViaj.Text = row.Cells["Id_Ruta"].Value.ToString();
                dtSalida.Text = row.Cells["Fecha_Salida"].Value.ToString();
                dtLlegada.Text = row.Cells["Fecha_Llegada"].Value.ToString();
                cbEstadoViaje.Text = row.Cells["Estado"].Value.ToString();
            }
        }

        private void MostrarRuta(List<Rutas> rutas)
        {
            dgRuta.DataSource = null;
            if (rutas.Count == 0)
            {
                return;
            }
            else
            {
                dgRuta.DataSource = rutas;
            }
            dgRuta.Columns["Viajes"].Visible = false;
      
        }

        private void MostrarViaje(List<Viajes> viajes)
        {
            dgViajes.DataSource = null;
            if (viajes.Count == 0)
            {
                return;
            }
            else
            {
                dgViajes.DataSource = viajes;
            }
            dgViajes.Columns["Boletos"].Visible = false;
            dgViajes.Columns["Buses"].Visible = false;
            dgViajes.Columns["Conductores"].Visible = false;
            dgViajes.Columns["Rutas"].Visible = false;
        }

        //CBO DE VIAJES 
        private void MostrarVIAJES(List<Buses> buses, List<Conductores> conductores, List<Rutas> rutas)
        {
            cbBusViaj.DataSource = null;
            cbConductorViaj.DataSource = null;
            if (buses.Count != 0)
            {
                cbBusViaj.DataSource = buses;
                cbBusViaj.ValueMember = "Id_Bus";
                cbBusViaj.DisplayMember = "Placa";
            }
            if (conductores.Count != 0)
            {
                cbConductorViaj.DataSource = conductores;
                cbConductorViaj.ValueMember = "Id_Conductor";
                cbConductorViaj.DisplayMember = "Nombre";
            }
            if (rutas.Count != 0)
            {
                cbRutaViaj.DataSource = rutas;
                cbRutaViaj.ValueMember = "Id_Ruta";
                cbRutaViaj.DisplayMember = "Id_Ruta";
            }

        }
        // INICIO DE CODIGO DE RUTA
        private void btnRegistrarRuta_Click(object sender, EventArgs e)
        {
            if ( cbOrigen.Text == "" || cbDestino.Text == "" || txtDistancia.Text == "" || txtDuracion.Text == "")
            {
                MessageBox.Show("Completar todos los campos");
                return;
            }

            Rutas rutas = new Rutas()
            {
              
                Origen = cbOrigen.Text,
                Destino = cbDestino.Text,
                Distancia_Km = Convert.ToDecimal(txtDistancia.Text),
                Duracion_Estimada = TimeSpan.Parse(txtDuracion.Text)
            };
            String mensaje = nRuta.Registrar(rutas);
            MessageBox.Show(mensaje);
            MostrarRuta(nRuta.ListarTodo());
            MostrarVIAJES(nBus.ListarTodo(), nConductor.ListarTodo(), nRuta.ListarTodo());
            MostrarViaje(nViaje.ListarTodo());
        }

        private void btnEditarRuta_Click(object sender, EventArgs e)
        {

            if (dgRuta.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una Ruta");
                return;
            }

            if ( cbOrigen.Text == "" || cbDestino.Text == "" || txtDistancia.Text == "" || txtDuracion.Text == "")
            {
                MessageBox.Show("Completar todos los campos");
                return;
            }

            Rutas rutas = new Rutas()
            {
                
                Origen = cbOrigen.Text,
                Destino = cbDestino.Text,
                Distancia_Km = Convert.ToDecimal(txtDistancia.Text),
                Duracion_Estimada = TimeSpan.Parse(txtDuracion.Text)
            };

            String mensaje = nRuta.Modificar(rutas);
            MessageBox.Show(mensaje);
            MostrarRuta(nRuta.ListarTodo());
            MostrarVIAJES(nBus.ListarTodo(), nConductor.ListarTodo(), nRuta.ListarTodo());
            MostrarViaje(nViaje.ListarTodo());
        }

        private void btnEliminarRuta_Click(object sender, EventArgs e)
        {
            if (dgRuta.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione la Ruta a Eliminar");
                return;
            }

            int idRuta = Convert.ToInt32(dgRuta.SelectedRows[0].Cells[0].Value);

            try
            {
                // 1. Obtener los viajes asociados a la ruta
                var viajes = nViaje.ListarTodo().Where(v => v.Id_Ruta == idRuta).ToList();

                // 2. Eliminar boletos de cada viaje
                foreach (var viaje in viajes)
                {
                    var boletos = nBoleto.ListarPorViaje(viaje.Id_Viaje);
                    foreach (var boleto in boletos)
                    {
                        nBoleto.Eliminar(boleto.Id_Boleto);
                    }
                }

                // 3. Eliminar los viajes
                foreach (var viaje in viajes)
                {
                    nViaje.Eliminar(viaje.Id_Viaje);
                }

                // 4. Finalmente, eliminar la ruta
                string mensaje = nRuta.Eliminar(idRuta);
                MessageBox.Show(mensaje);

                // 5. Actualizar vistas
                MostrarRuta(nRuta.ListarTodo());
                MostrarVIAJES(nBus.ListarTodo(), nConductor.ListarTodo(), nRuta.ListarTodo());
                MostrarViaje(nViaje.ListarTodo());
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
                if (ex.InnerException != null)
                    mensaje += "\n" + ex.InnerException.Message;
                if (ex.InnerException?.InnerException != null)
                    mensaje += "\n" + ex.InnerException.InnerException.Message;

                MessageBox.Show("Error al eliminar la ruta y sus relaciones: " + mensaje);
            }
        }


        private void btnSalirRuta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //FIN CODIGO DE RUTA

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cbBusViaj.Text == "" || cbConductorViaj.Text == "" || cbRutaViaj.Text == "" ||
            dtSalida.Text == "" || dtLlegada.Text == "" || cbEstadoViaje.Text == "")
            {
                MessageBox.Show("Completar todos los campos");
                return;
            }

            Viajes viaje = new Viajes()
            {
                Id_Bus = int.Parse(cbBusViaj.SelectedValue.ToString()),
                Id_Conductor = int.Parse(cbConductorViaj.SelectedValue.ToString()),
                Id_Ruta = int.Parse(cbRutaViaj.SelectedValue.ToString()),
                Fecha_Salida = dtSalida.Value,
                Fecha_LLegada = dtLlegada.Value,
                Estado = cbEstadoViaje.Text
            };

            string validacion = nViaje.ValidarViaje(viaje);
            if (validacion != "OK")
            {
                MessageBox.Show(validacion);
                return;
            }

            string mensaje = nViaje.Registrar(viaje);
            MessageBox.Show(mensaje);

            if (mensaje == "Registrado correctamente")
            {
                MostrarViaje(nViaje.ListarTodo());
                MostrarVIAJES(nBus.ListarTodo(), nConductor.ListarTodo(), nRuta.ListarTodo());
                MostrarRuta(nRuta.ListarTodo());
            }
        }

        private void btnEditarViaje_Click(object sender, EventArgs e)
        {
            if (dgViajes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un viaje para editar.");
                return;
            }

            if (cbBusViaj.Text == "" || cbConductorViaj.Text == "" || cbRutaViaj.Text == "" ||
                dtSalida.Text == "" || dtLlegada.Text == "" || cbEstadoViaje.Text == "")
            {
                MessageBox.Show("Completar todos los campos");
                return;
            }

            Viajes viaje = new Viajes()
            {
                Id_Viaje = Convert.ToInt32(dgViajes.SelectedRows[0].Cells["Id_Viaje"].Value),
                Id_Bus = int.Parse(cbBusViaj.SelectedValue.ToString()),
                Id_Conductor = int.Parse(cbConductorViaj.SelectedValue.ToString()),
                Id_Ruta = int.Parse(cbRutaViaj.SelectedValue.ToString()),
                Fecha_Salida = dtSalida.Value,
                Fecha_LLegada = dtLlegada.Value,
                Estado = cbEstadoViaje.Text
            };

            string validacion = nViaje.ValidarViaje(viaje);
            if (validacion != "OK")
            {
                MessageBox.Show(validacion);
                return;
            }

            string mensaje = nViaje.Modificar(viaje);
            MessageBox.Show(mensaje);

            if (mensaje == "Viaje modificado correctamente")
            {
                MostrarViaje(nViaje.ListarTodo());
                MostrarVIAJES(nBus.ListarTodo(), nConductor.ListarTodo(), nRuta.ListarTodo());
                MostrarRuta(nRuta.ListarTodo());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgViajes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione el viaje que desea cancelar.");
                return;
            }

            int idViaje = Convert.ToInt32(dgViajes.SelectedRows[0].Cells["Id_Viaje"].Value);

            DialogResult confirmacion = MessageBox.Show(
                "¿Estás seguro de que deseas cancelar este viaje?\nTambién se cancelarán todos sus boletos.",
                "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                string mensaje = nViaje.CancelarViaje(idViaje);
                MessageBox.Show(mensaje);
                MostrarRuta(nRuta.ListarTodo());
                MostrarVIAJES(nBus.ListarTodo(), nConductor.ListarTodo(), nRuta.ListarTodo());
                MostrarViaje(nViaje.ListarTodo());
            }
        }

        private void btnEliminarViaje_Click(object sender, EventArgs e)
        {
            if (dgViajes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione el viaje a eliminar.");
                return;
            }

            int idViaje = Convert.ToInt32(dgViajes.SelectedRows[0].Cells["Id_Viaje"].Value);

            DialogResult confirmacion = MessageBox.Show(
                "¿Estás seguro de eliminar este viaje?\nSolo se eliminará si no tiene boletos.",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                string mensaje = nViaje.EliminarViajeSiNoTieneBoletos(idViaje);
                MessageBox.Show(mensaje);
                MostrarRuta(nRuta.ListarTodo());
                MostrarVIAJES(nBus.ListarTodo(), nConductor.ListarTodo(), nRuta.ListarTodo());
                MostrarViaje(nViaje.ListarTodo());
            }
        }
    }
}
