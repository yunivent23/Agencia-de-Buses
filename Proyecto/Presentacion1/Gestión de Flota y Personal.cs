using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Datos;
using Negocio;
using Presentacion1;
using static Negocio.NConductor;

namespace Presentación
{
    public partial class Gestión_de_Flota_y_Personal : Form
    {
        private NBus nBus = new NBus();
        private NConductor nConductor = new NConductor();
        private NAsignacion nAsignacion = new NAsignacion();
        private NMantenimiento nMantenimiento = new NMantenimiento();
        private NAsiento nAsiento = new NAsiento();
        private NBoleto nBoleto = new NBoleto();
        private NViaje nViaje = new NViaje();

        public Gestión_de_Flota_y_Personal()
        {
            InitializeComponent();
            this.dgBuses.CellClick += new DataGridViewCellEventHandler(this.dgBuses_CellClick);
            this.dgConductores.CellClick += new DataGridViewCellEventHandler(this.dgConductores_CellClick);
            this.dgAsignaciones.CellClick += new DataGridViewCellEventHandler(this.dgAsignaciones_CellClick);

            MostrarBus(nBus.ListarTodo());
            MostrarConductor(nConductor.ListarTodo());
            MostrarAsignaciones(nBus.ListarTodo(), nConductor.ListarTodo());
            MostrarAsignacion(nAsignacion.ListarTodo());
            MostrarMantenimientos(nMantenimiento.ListarTodo(), nBus.ListarTodo());
            dtpFechaAsignacion.Format = DateTimePickerFormat.Custom;
            dtpFechaAsignacion.CustomFormat = "dd-MM-yyyy HH:mm:ss";
            dtpFechaAsignacion.ShowUpDown = true; // opcional: muestra solo selector de tiempo
        }

        private void LimpiarCampos()
        {
          
            txtPlaca.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtCapacidad.Clear();
            cbEstadoBus.SelectedIndex = -1;
           
        }

        //prueba 
        private void dgBuses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgBuses.Rows[e.RowIndex];

                txtPlaca.Text = row.Cells["Placa"].Value.ToString();
                txtMarca.Text = row.Cells["Marca"].Value.ToString();
                txtModelo.Text = row.Cells["Modelo"].Value.ToString();
                cbEstadoBus.Text = row.Cells["Estado"].Value.ToString();
                txtCapacidad.Text = row.Cells["Capacidad"].Value.ToString();
            }
        }
        private void dgAsignaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgAsignaciones.Rows[e.RowIndex];

                cbBusAsig.Text = row.Cells["Id_Bus"].Value.ToString();
                cbConductorAsig.Text = row.Cells["Id_Conductor"].Value.ToString();
                dtpFechaAsignacion.Text = row.Cells["Fecha_Asignacion"].Value.ToString();
                cbTurno.Text = row.Cells["Turno"].Value.ToString();
                txtObservaciones.Text = row.Cells["Observaciones"].Value.ToString();
            }
        }

        private void dgConductores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgConductores.Rows[e.RowIndex];
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtDocumento.Text = row.Cells["Documento_Identidad"].Value.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
                txtLicencia.Text = row.Cells["Licencia"].Value.ToString();
                cbEstadoConductor.Text = row.Cells["Estado"].Value.ToString();
            }
        }


        //Mostar bus
        private void MostrarBus(List<Buses> buses)
        {
            nBus.ActualizarEstadoBusesPorMantenimiento();
            dgBuses.DataSource = null;
            if (buses.Count == 0)
            {
                return;
            }
            else
            {
                dgBuses.DataSource = buses;
            }
            dgBuses.Columns["Asientos"].Visible = false;
            dgBuses.Columns["Asignaciones"].Visible = false;
            dgBuses.Columns["Mantenimientos"].Visible = false;
            dgBuses.Columns["Viajes"].Visible = false;
        }
        //Mostrar Conductor
        private void MostrarConductor(List<Conductores> conductores)
        {
            dgConductores.DataSource = null;
            if (conductores.Count == 0)
            {
                return;
            }
            else
            {
                dgConductores.DataSource = conductores;
            }
            dgConductores.Columns["Asignaciones"].Visible = false;
            dgConductores.Columns["Viajes"].Visible = false;
        }
        //mostrar asignacion
        private void MostrarAsignaciones(List<Buses> buses, List<Conductores> conductores)
        {
            cbConductorAsig.DataSource = null;
            cbBusAsig.DataSource = null;
            if (buses.Count != 0)
            {
                cbBusAsig.DataSource = buses;
                cbBusAsig.ValueMember = "Id_Bus";
                cbBusAsig.DisplayMember = "Placa";
            }
            if (conductores.Count != 0)
            {
                cbConductorAsig.DataSource = conductores;
                cbConductorAsig.ValueMember = "Id_Conductor";
                cbConductorAsig.DisplayMember = "Nombre";
            }
        }
        private void MostrarAsignacion(List<Asignaciones> asignaciones)
        {
            dgAsignaciones.DataSource = null;
            if (asignaciones.Count == 0)
            {
                return;
            }
            else
            {
                dgAsignaciones.DataSource = asignaciones;
            }
            dgAsignaciones.Columns["Buses"].Visible = false;
            dgAsignaciones.Columns["Conductores"].Visible = false;
        }
        //mostrar mantenimiento
        private void MostrarMantenimientos(List<Mantenimientos> mantenimientos, List<Buses> buses)
        {

            cbBusMant.DataSource = null;
            if (buses.Count != 0)
            {
                cbBusMant.DataSource = buses;
                cbBusMant.ValueMember = "Id_Bus";
                cbBusMant.DisplayMember = "Placa";

                dgMantenimiento.DataSource = null;
                if (mantenimientos.Count == 0)
                {
                    return;
                }
                else
                {
                    dgMantenimiento.DataSource = mantenimientos;
                }
            }
           
        }

        //GENERACION DE ID ASIENTOS

        private void GenerarAsientosParaBus(int idBus, int capacidad)
        {
            for (int i = 1; i <= capacidad; i++)
            {
                if (i <= 2)
                    continue;

                // Asegurar dos dígitos para el número de asiento
                string numAsiento = i.ToString("D2");
                string idAsiento = $"{idBus}-{numAsiento}";

                Asientos nuevoAsiento = new Asientos
                {
                    Id_Asiento = idAsiento,
                    Id_Bus = idBus,
                    Numero = i,
                    Tipo = "Normal"
                };

                try
                {
                    nAsiento.Registrar(nuevoAsiento);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al registrar asiento {i}: {ex.Message}");
                }
            }
        }




        // inicio codigo de BUS
        private void btnRegistrarBus_Click(object sender, System.EventArgs e)
        {
            if (txtPlaca.Text == "" || txtMarca.Text == "" || txtModelo.Text == "" || cbEstadoBus.Text == "" || txtCapacidad.Text == "")
            {
                MessageBox.Show("Completar todos los campos");
                return;
            }

            Buses bus = new Buses()
            {
                Placa = txtPlaca.Text,
                Marca = txtMarca.Text,
                Modelo = txtModelo.Text,
                Estado = cbEstadoBus.Text,
                Capacidad = int.Parse(txtCapacidad.Text)
            };
            String mensaje = nBus.Registrar(bus);
            MessageBox.Show(mensaje);
            MostrarBus(nBus.ListarTodo()); LimpiarCampos();
            MostrarAsignaciones(nBus.ListarTodo(), nConductor.ListarTodo());
            MostrarMantenimientos(nMantenimiento.ListarTodo(), nBus.ListarTodo());
            GenerarAsientosParaBus(bus.Id_Bus, bus.Capacidad);

        }
        private void btnAsientos_Click(object sender, EventArgs e)
        {
            if (dgBuses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un bus");
                return;
            }

            int id = Convert.ToInt16(dgBuses.SelectedRows[0].Cells[0].Value.ToString());

            Mantenimiento_de_Asientos form = new Mantenimiento_de_Asientos(id);
            form.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgBuses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un Bus");
                return;
            }

            if (txtPlaca.Text == "" || txtMarca.Text == "" || txtModelo.Text == "" || cbEstadoBus.Text == "" || txtCapacidad.Text == "")
            {
                MessageBox.Show("Completar todos los campos");
                return;
            }

            int idBus = int.Parse(dgBuses.SelectedRows[0].Cells["Id_Bus"].Value.ToString());
            int nuevaCapacidad = int.Parse(txtCapacidad.Text);

            int capacidadActual = int.Parse(dgBuses.SelectedRows[0].Cells["Capacidad"].Value.ToString());

            Buses buses = new Buses()
            {
                Id_Bus = idBus,
                Placa = txtPlaca.Text,
                Marca = txtMarca.Text,
                Modelo = txtModelo.Text,
                Estado = cbEstadoBus.Text,
                Capacidad = nuevaCapacidad
            };

            string mensaje = nBus.Modificar(buses);
            MessageBox.Show(mensaje);
            MostrarBus(nBus.ListarTodo());
            MostrarAsignaciones(nBus.ListarTodo(), nConductor.ListarTodo());
            MostrarMantenimientos(nMantenimiento.ListarTodo(), nBus.ListarTodo());

            if (nuevaCapacidad != capacidadActual)
            {
                bool eliminados = nAsiento.EliminarPorBus(idBus);
                if (eliminados)
                {
                    GenerarAsientosParaBus(idBus, nuevaCapacidad);
                }
                else
                {
                    MessageBox.Show("No se pudieron eliminar los asientos anteriores. Verifica si hay asientos en uso.");
                }
            }
        }


        private void btnElimnarBus_Click(object sender, EventArgs e)
        {
            if (dgBuses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione el bus a eliminar");
                return;
            }

            string idBus = dgBuses.SelectedRows[0].Cells[0].Value.ToString();

            try
            {
                // 1. Obtener todos los viajes asociados al bus
                var viajes = nViaje.ListarTodo().Where(v => v.Id_Bus.ToString() == idBus).ToList();

                // 2. Eliminar boletos de cada viaje
                foreach (var viaje in viajes)
                {
                    var boletosViaje = nBoleto.ListarPorViaje(viaje.Id_Viaje);
                    foreach (var boleto in boletosViaje)
                    {
                        nBoleto.Eliminar(boleto.Id_Boleto);
                    }
                }

                // 3. Obtener y eliminar boletos por asiento
                var asientos = nAsiento.ListarPorBus(Convert.ToInt32(idBus));
                foreach (var asiento in asientos)
                {
                    var boletosAsiento = nBoleto.ListarPorAsiento(asiento.Id_Asiento);
                    foreach (var boleto in boletosAsiento)
                    {
                        nBoleto.Eliminar(boleto.Id_Boleto);
                    }
                }

                // 4. Eliminar asientos
                nAsiento.EliminarPorBus(Convert.ToInt32(idBus));

                // 5. Eliminar asignaciones
                var asignaciones = nAsignacion.ListarTodo().Where(a => a.Id_Bus.ToString() == idBus).ToList();
                foreach (var asig in asignaciones)
                {
                    nAsignacion.Eliminar(asig.Id_Asignacion);
                }

                // 6. Eliminar mantenimientos
                var mantenimientos = nMantenimiento.ListarTodo().Where(m => m.Id_Bus.ToString() == idBus).ToList();
                foreach (var mant in mantenimientos)
                {
                    nMantenimiento.Eliminar(mant.Id_Mantenimiento);
                }

                // 7. Eliminar viajes
                foreach (var viaje in viajes)
                {
                    nViaje.Eliminar(viaje.Id_Viaje);
                }

                // 8. Finalmente, eliminar el bus
                string mensaje = nBus.Eliminar(Convert.ToInt32(idBus));
                MessageBox.Show(mensaje);

                // Actualizar vistas
                MostrarBus(nBus.ListarTodo());
                MostrarAsignaciones(nBus.ListarTodo(), nConductor.ListarTodo());
                MostrarMantenimientos(nMantenimiento.ListarTodo(), nBus.ListarTodo());
                MostrarConductor(nConductor.ListarTodo());
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
                if (ex.InnerException != null)
                    mensaje += "\n" + ex.InnerException.Message;
                if (ex.InnerException?.InnerException != null)
                    mensaje += "\n" + ex.InnerException.InnerException.Message;

                MessageBox.Show("Error al eliminar el bus y sus relaciones: " + mensaje);
            }
        }

        private void btnSalirBus_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnBuscarPlaca_Click(object sender, EventArgs e)
        {
            if (txtBuscarPlaca.Text == "")
            {
                MessageBox.Show("Ingrese la placa a buscar");
                return;
            }

            String placa = txtBuscarPlaca.Text;
            MostrarBus(nBus.BuscarporPlaca(placa));
        }
        //termina codigo de bus


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //codigo de conductor

       

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtDocumento.Text == "" || txtTelefono.Text == "" || txtLicencia.Text == "" || cbEstadoConductor.Text == "")
            {
                MessageBox.Show("Completar todos los campos");
                return;
            }

            Conductores conductores = new Conductores()
            {
                Nombre = txtNombre.Text,
                Documento_Identidad = int.Parse(txtDocumento.Text),
                Telefono = txtTelefono.Text,
                Licencia = txtLicencia.Text,
                Estado = cbEstadoConductor.Text
            };
            String mensaje = nConductor.Registrar(conductores);
            MessageBox.Show(mensaje);
            MostrarConductor(nConductor.ListarTodo()); LimpiarCampos();
            MostrarAsignaciones(nBus.ListarTodo(), nConductor.ListarTodo());
            MostrarMantenimientos(nMantenimiento.ListarTodo(), nBus.ListarTodo());
        }

        private void btnActualizarCond_Click(object sender, EventArgs e)
        {
            if (dgConductores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un Conductor");
                return;
            }

            if ( txtNombre.Text == "" || txtDocumento.Text == "" || txtTelefono.Text == "" || txtLicencia.Text == "" || cbEstadoConductor.Text == "")
            {
                MessageBox.Show("Completar todos los campos");
                return;
            }

            Conductores conductores = new Conductores()
            {
                Id_Conductor = Convert.ToInt16(dgConductores.SelectedRows[0].Cells[0].Value),
                Nombre = txtNombre.Text,
                Documento_Identidad = int.Parse(txtDocumento.Text),
                Telefono = txtTelefono.Text,
                Licencia = txtLicencia.Text,
                Estado = cbEstadoConductor.Text
            };

            String mensaje = nConductor.Modificar(conductores);
            MessageBox.Show(mensaje);
            MostrarConductor(nConductor.ListarTodo());
            MostrarAsignaciones(nBus.ListarTodo(), nConductor.ListarTodo());
            MostrarMantenimientos(nMantenimiento.ListarTodo(), nBus.ListarTodo());
        }


        private void btnEliminarCond_Click(object sender, EventArgs e)
        {
            if (dgConductores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione el conductor a eliminar");
                return;
            }

            int idConductor = Convert.ToInt32(dgConductores.SelectedRows[0].Cells[0].Value);

            try
            {
                // 1. Obtener viajes del conductor
                var viajes = nViaje.ListarTodo().Where(v => v.Id_Conductor == idConductor).ToList();

                // 2. Eliminar boletos de esos viajes
                foreach (var viaje in viajes)
                {
                    var boletos = nBoleto.ListarPorViaje(viaje.Id_Viaje);
                    foreach (var boleto in boletos)
                    {
                        nBoleto.Eliminar(boleto.Id_Boleto);
                    }
                }

                foreach (var viaje in viajes)
                {
                    nViaje.Eliminar(viaje.Id_Viaje);
                }
                var asignaciones = nAsignacion.ListarTodo().Where(a => a.Id_Conductor == idConductor).ToList();
                foreach (var asig in asignaciones)
                {
                    nAsignacion.Eliminar(asig.Id_Asignacion);
                }
                string mensaje = nConductor.Eliminar(idConductor);
                MessageBox.Show(mensaje);

                
                MostrarConductor(nConductor.ListarTodo());
                MostrarAsignaciones(nBus.ListarTodo(), nConductor.ListarTodo());
                MostrarMantenimientos(nMantenimiento.ListarTodo(), nBus.ListarTodo());
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
                if (ex.InnerException != null)
                    mensaje += "\n" + ex.InnerException.Message;
                if (ex.InnerException?.InnerException != null)
                    mensaje += "\n" + ex.InnerException.InnerException.Message;

                MessageBox.Show("Error al eliminar el conductor y sus relaciones: " + mensaje);
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnBuscarDocumento_Click(object sender, EventArgs e)
        {
            if (tbBuscarDocumento.Text == "")
            {
                MessageBox.Show("Ingrese el documento a buscar");
                return;
            }

            int documento = int.Parse(tbBuscarDocumento.Text);
            MostrarConductor(nConductor.BuscarporDocumento(documento));
        }
        //FIN CODIGO DE CONDUCTOR
        private void cbBusAsig_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaAsignacion_ValueChanged(object sender, EventArgs e)
        {

        }
        //codigo ASIGNACION
         

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (cbBusAsig.Text == "" || cbConductorAsig.Text == "" || cbTurno.Text == "" || dtpFechaAsignacion.Text == "" || txtObservaciones.Text == "")
            {
                MessageBox.Show("Completar todos los campos");
                return;
            }
            

            Asignaciones asignaciones = new Asignaciones()
            {
                Id_Bus = Convert.ToInt32(cbBusAsig.SelectedValue),
                Id_Conductor = Convert.ToInt32(cbConductorAsig.SelectedValue),
                Fecha_Asignacion = dtpFechaAsignacion.Value,
                Turno = cbTurno.Text,
                Observaciones = txtObservaciones.Text
            };

            string mensaje = nAsignacion.Registrar(asignaciones);

            if (mensaje == "OK")
            {
                MessageBox.Show("Asignación registrada correctamente");
                
            }
            else
            {
                MessageBox.Show(mensaje);
            }

            MostrarAsignaciones(nBus.ListarTodo(), nConductor.ListarTodo());
            MostrarAsignacion(nAsignacion.ListarTodo());
            MostrarMantenimientos(nMantenimiento.ListarTodo(), nBus.ListarTodo());
        }
        private void btnEditarAsig_Click(object sender, EventArgs e)
        {
            if (dgAsignaciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una Asignación");
                return;
            }

            if (cbBusAsig.Text == "" || cbConductorAsig.Text == "" || cbTurno.Text == "" || dtpFechaAsignacion.Text == "" || txtObservaciones.Text == "")
            {
                MessageBox.Show("Completar todos los campos");
                return;
            }

            Asignaciones asignacion = new Asignaciones()
            {
                Id_Asignacion = Convert.ToInt16(dgAsignaciones.SelectedRows[0].Cells[0].Value),
                Id_Bus = Convert.ToInt32(cbBusAsig.SelectedValue),
                Id_Conductor = Convert.ToInt32(cbConductorAsig.SelectedValue),
                Fecha_Asignacion = dtpFechaAsignacion.Value,
                Turno = cbTurno.Text,
                Observaciones = txtObservaciones.Text
            };
            string resultadoValidacion = nAsignacion.ValidarAsignacion(asignacion);

            if (resultadoValidacion != "OK")
            {
                MessageBox.Show(resultadoValidacion);
                return;
            }

            string mensaje = nAsignacion.Modificar(asignacion);
            MessageBox.Show(mensaje);
            MostrarAsignacion(nAsignacion.ListarTodo());
            MostrarAsignaciones(nBus.ListarTodo(), nConductor.ListarTodo());
            MostrarConductor(nConductor.ListarTodo());
            MostrarMantenimientos(nMantenimiento.ListarTodo(), nBus.ListarTodo());
        }

        private void btnEliminarAsig_Click(object sender, EventArgs e)
        {
            if (dgAsignaciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una asignación para eliminar.");
                return;
            }

            int idAsignacion = Convert.ToInt32(dgAsignaciones.SelectedRows[0].Cells["Id_Asignacion"].Value);
            int idBus = Convert.ToInt32(dgAsignaciones.SelectedRows[0].Cells["Id_Bus"].Value);
            int idConductor = Convert.ToInt32(dgAsignaciones.SelectedRows[0].Cells["Id_Conductor"].Value);
            DateTime fechaAsignacion = Convert.ToDateTime(dgAsignaciones.SelectedRows[0].Cells["Fecha_Asignacion"].Value);

            // Encontrar viaje asociado a la asignación
            var viaje = nViaje.ListarTodo().FirstOrDefault(v =>
                v.Id_Bus == idBus &&
                v.Id_Conductor == idConductor &&
                v.Fecha_Salida.HasValue &&
                v.Fecha_Salida.Value.Date == fechaAsignacion.Date
            );

            DialogResult confirm = MessageBox.Show(
                "¿Está seguro de eliminar esta asignación?\n\n⚠ El viaje y sus boletos serán cancelados.",
                "Confirmar cancelación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                if (viaje != null)
                {
                    viaje.Estado = "CANCELADO";
                    nViaje.Modificar(viaje);

                    var boletos = nBoleto.ListarPorViaje(viaje.Id_Viaje);
                    foreach (var boleto in boletos)
                    {
                        boleto.Estado = "CANCELADO";

                        nBoleto.Modificar(boleto.Id_Boleto, boleto);
                    }
                }

                string mensaje = nAsignacion.Eliminar(idAsignacion);
                MessageBox.Show("Asignación eliminada y viaje/boletos cancelados.");

                MostrarAsignacion(nAsignacion.ListarTodo());
                MostrarAsignaciones(nBus.ListarTodo(), nConductor.ListarTodo());
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
                
            }
        }


        //codigo mantenimiento
        private void btnRegistrarMantenimiento_Click(object sender, EventArgs e)
        {
            if (cbBusMant.Text == "" || txtCostoMant.Text == "" || dtpMant.Text == "" || txtEmpresaMant.Text == "" || txtDescripcionMant.Text == "")
            {
                MessageBox.Show("Completar todos los campos");
                return;
            }

            Mantenimientos mantenimiento = new Mantenimientos()
            {
                Id_Bus = Convert.ToInt32(cbBusMant.SelectedValue),
                Fecha = dtpMant.Value,
                Descripcion = txtDescripcionMant.Text,
                Costo = decimal.Parse(txtCostoMant.Text),
                EmpresaResponsable = txtEmpresaMant.Text
            };

            string mensaje = nMantenimiento.Registrar(mantenimiento);

            if (mensaje == "OK")
            {
                MessageBox.Show("Mantenimiento registrado correctamente.");
                
            }
            else
            {
                MessageBox.Show(mensaje);
            }
            MostrarMantenimientos(nMantenimiento.ListarTodo(), nBus.ListarTodo());
            MostrarBus(nBus.ListarTodo());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBuscarPlaca.Clear();
            MostrarBus(nBus.ListarTodo());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbBuscarDocumento.Clear();
            MostrarConductor(nConductor.ListarTodo());
        }

        private void tpBuses_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\img1.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void tpMantenimiento_Click(object sender, EventArgs e)
        {

        }

        
    }
}
