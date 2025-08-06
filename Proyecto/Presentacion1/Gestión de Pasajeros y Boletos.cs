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
using static Negocio.NConductor;

namespace Presentacion1
{
    public partial class Gestión_de_Pasajeros_y_Boletos : Form
    {
        private NPasajero nPasajero = new NPasajero();
        private NBoleto nBoleto = new NBoleto();
        private NViaje nViaje = new NViaje();
        private NAsiento nAsiento = new NAsiento();
        private List<string> idAsientosSeleccionados = new List<string>();
    


        public Gestión_de_Pasajeros_y_Boletos()
        {
            InitializeComponent();

            nBoleto.ActualizarBoletosUsados();
            MostrarPasajeros(nPasajero.ListarTodo());
            MostrarBoletos(nBoleto.ListarTodo());
            cb_en_Boleto(nPasajero.ListarTodo(), nViaje.ListarTodo());

        }
       


        //MostrarPasajeros
        private void MostrarPasajeros(List<Pasajeros> pasajeros)
        {
            dgPasajeros.DataSource = null;
            if (pasajeros.Count == 0)
            {
                return;
            }
            else
            {
                dgPasajeros.DataSource = pasajeros;
            }
        }

        //Mostrar Boletos
        private void MostrarBoletos(List<Boletos> boletos)
        {
            dgBoletos.DataSource = null;
            if (boletos.Count == 0)
            {
                return;
            }
            else
            {
                dgBoletos.DataSource = boletos;
            }
        }

        private void cb_en_Boleto(List<Pasajeros> pasajeros, List<Viajes> viajes)
        {
            cbPasajeroId.DataSource = null;
            cbViajeId.DataSource = null;
            if (pasajeros.Count != 0)
            {
                cbPasajeroId.DataSource = pasajeros;
                cbPasajeroId.ValueMember = "Id_Pasajero";
                cbPasajeroId.DisplayMember = "Documento_Identidad";
            }
            if (viajes.Count != 0)
            {
                cbViajeId.DataSource = nViaje.ListarTodo();
                cbViajeId.DisplayMember = "Id_Viaje";
                cbViajeId.ValueMember = "Id_Viaje";
            }
        }

        // INICIO CODIGO PASAJERO
        private void btnRegistrarPasajero_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtDocumento.Text == "" || txtCorreo.Text == "" || txtTelefono.Text == "" )
            {
                MessageBox.Show("Completar todos los campos");
                return;
            }

            Pasajeros pasajero = new Pasajeros()
            {
             
                Nombre = txtNombre.Text,
                Documento_Identidad = int.Parse(txtDocumento.Text),
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text,
            };
            String mensaje = nPasajero.Registrar(pasajero);
            MessageBox.Show(mensaje);
            MostrarPasajeros(nPasajero.ListarTodo());
            MostrarBoletos(nBoleto.ListarTodo());
            cb_en_Boleto(nPasajero.ListarTodo(), nViaje.ListarTodo());
        }

        private void btnActualizarPasajero_Click(object sender, EventArgs e)
        {
            if (dgPasajeros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un Pasajero");
                return;
            }

            if (txtNombre.Text == "" || txtDocumento.Text == "" || txtCorreo.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Completar todos los campos");
                return;
            }


            Pasajeros pasajero = new Pasajeros()
            {
                Id_Pasajero = Convert.ToInt16(dgPasajeros.SelectedRows[0].Cells["Id_Pasajero"].Value.ToString()),
                Nombre = txtNombre.Text,
                Documento_Identidad = int.Parse(txtDocumento.Text),
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text,
            };

            try
            {
                nPasajero.Modificar(pasajero);
                MessageBox.Show("Pasajero actualizado correctamente");
                MostrarPasajeros(nPasajero.ListarTodo());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el pasajero: " + ex.Message);
            }
        }

        private void btnEliminarPasajero_Click(object sender, EventArgs e)
        {
            if (dgPasajeros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione el conductor a eliminar");
                return;
            }

            int idPasajero = Convert.ToInt16(dgPasajeros.SelectedRows[0].Cells[0].Value);


            DialogResult confirm = MessageBox.Show("¿Está seguro de eliminar este pasajero y sus boletos?", "Confirmación", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                String mensaje = nPasajero.Eliminar(idPasajero);
                MessageBox.Show(mensaje);
                MostrarPasajeros(nPasajero.ListarTodo());
                MostrarBoletos(nBoleto.ListarTodo());
            }
        }



        private void btnSalirPasajero_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarDoc_Click(object sender, EventArgs e)
        {
            if (txtBuscarDoc.Text == "")
            {
                MessageBox.Show("Ingrese el documento a buscar");
                return;
            }

            int documento = int.Parse(txtBuscarDoc.Text);
            MostrarPasajeros(nPasajero.BuscarPorDocumento(documento));
        }




        //INICIO CODIGO ASIENTOS

        private void btnMostrarAsientosDispo_Click(object sender, EventArgs e)
        {
            if (cbViajeId.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un viaje primero.");
                return;
            }

            int idViaje = ((Viajes)cbViajeId.SelectedItem).Id_Viaje;

            if (!nBoleto.PuedeRegistrar(idViaje))
            {
                MessageBox.Show("No se pueden mostrar los asientos porque el viaje no está programado.");
                return;
            }

            List<Asientos> asientos = nAsiento.ListarPorViaje(idViaje);
            List<string> ocupados = nBoleto.ObtenerAsientosOcupadosPorViaje(idViaje);

            Asientos_Disponibles form = new Asientos_Disponibles();
            form.GenerarAsientos(asientos, ocupados);

            if (form.ShowDialog() == DialogResult.OK)
            {
                idAsientosSeleccionados = form.idAsientosSeleccionados;
                MessageBox.Show("Asientos seleccionados: " + string.Join(", ", idAsientosSeleccionados));
            }

        }


        private void btnRegistrarBoleto_Click(object sender, EventArgs e)
        {
            if (cbPasajeroId.SelectedValue == null || cbViajeId.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un pasajero y un viaje.");
                return;
            }

            int idViaje = Convert.ToInt32(cbViajeId.SelectedValue);
            

            if (string.IsNullOrWhiteSpace(txtPrecio.Text) || !decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("Ingrese un precio válido.");
                return;
            }

            if (cbEstadoBoleto.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un estado para el boleto.");
                return;
            }

            if (idAsientosSeleccionados == null || idAsientosSeleccionados.Count == 0)
            {
                MessageBox.Show("No hay asientos seleccionados.");
                return;
            }

            int idPasajero = Convert.ToInt32(cbPasajeroId.SelectedValue);
            string estado = cbEstadoBoleto.SelectedItem.ToString();
            int registrados = 0;

            List<Asientos> asientosDelViaje = nAsiento.ListarPorViaje(idViaje);

            foreach (string idAsiento in idAsientosSeleccionados)
            {
                var asiento = asientosDelViaje.FirstOrDefault(a => a.Id_Asiento == idAsiento);
                if (asiento == null)
                {
                    MessageBox.Show($"Asiento con ID {idAsiento} no pertenece al viaje.");
                    continue;
                }

                string numAsiento = asiento.Numero.ToString("D2");
                string idBoleto = $"{idViaje}-{numAsiento}";

                if (nBoleto.ExisteIdBoleto(idBoleto))
                {
                    MessageBox.Show($"Ya existe un boleto para el asiento {numAsiento} en este viaje.");
                    continue;
                }

                Boletos nuevoBoleto = new Boletos()
                {
                    Id_Boleto = idBoleto,
                    Id_Pasajero = idPasajero,
                    Id_Viaje = idViaje,
                    Id_Asiento = idAsiento,
                    Precio = precio,
                    Estado = estado,
                    Fecha_Compra = DateTime.Now
                };

                try
                {
                    string mensaje = nBoleto.Registrar(nuevoBoleto);
                    if (mensaje.Contains("correctamente"))
                        registrados++;
                    else
                        MessageBox.Show($"Error: {mensaje}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al registrar boleto para asiento {numAsiento}: {ex.Message}");
                }
            }

            MessageBox.Show($"{registrados} boleto(s) registrados correctamente.");
            MostrarBoletos(nBoleto.ListarTodo());
            idAsientosSeleccionados.Clear();
        }



        private void btnActualizarBoleto_Click(object sender, EventArgs e)
        {
            if (dgBoletos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un Boleto para actualizar.");
                return;
            }

            string originalIdBoleto = dgBoletos.SelectedRows[0].Cells["Id_Boleto"].Value.ToString();

            // VALIDACIÓN: solo se puede modificar si el viaje está programado
            if (!nBoleto.PuedeModificar(originalIdBoleto))
            {
                MessageBox.Show("No se puede modificar este boleto porque su viaje no está programado.");
                return;
            }

            DataGridViewRow selectedRow = dgBoletos.SelectedRows[0];
            int originalIdPasajero = Convert.ToInt32(selectedRow.Cells["Id_Pasajero"].Value);
            int originalIdViaje = Convert.ToInt32(selectedRow.Cells["Id_Viaje"].Value);
            string originalIdAsiento = selectedRow.Cells["Id_Asiento"].Value.ToString();
            decimal originalPrecio = Convert.ToDecimal(selectedRow.Cells["Precio"].Value);
            string originalEstado = selectedRow.Cells["Estado"].Value.ToString();
            DateTime originalFechaCompra = Convert.ToDateTime(selectedRow.Cells["Fecha_Compra"].Value);

            int updatedIdPasajero = originalIdPasajero;
            int updatedIdViaje = originalIdViaje;
            string updatedIdAsiento = originalIdAsiento;
            decimal updatedPrecio = originalPrecio;
            string updatedEstado = originalEstado;

            if (!string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                if (!decimal.TryParse(txtPrecio.Text, out updatedPrecio))
                {
                    MessageBox.Show("Ingrese un precio válido.");
                    return;
                }
            }

            if (cbPasajeroId.SelectedValue != null)
                updatedIdPasajero = Convert.ToInt32(cbPasajeroId.SelectedValue);

            if (cbViajeId.SelectedValue != null)
                updatedIdViaje = Convert.ToInt32(cbViajeId.SelectedValue);

            if (cbEstadoBoleto.SelectedItem != null)
                updatedEstado = cbEstadoBoleto.SelectedItem.ToString();

            if (idAsientosSeleccionados != null && idAsientosSeleccionados.Count == 1)
                updatedIdAsiento = idAsientosSeleccionados[0];

            // Si se cambió viaje o asiento, generar nuevo ID de boleto
            string nuevoIdBoleto = originalIdBoleto;
            if (updatedIdViaje != originalIdViaje || updatedIdAsiento != originalIdAsiento)
            {
                var asientoNuevo = nAsiento.ListarPorViaje(updatedIdViaje)
                    .FirstOrDefault(a => a.Id_Asiento == updatedIdAsiento);

                if (asientoNuevo == null)
                {
                    MessageBox.Show("El asiento seleccionado no pertenece al viaje elegido.");
                    idAsientosSeleccionados.Clear();
                    return;
                }

                string numAsiento = asientoNuevo.Numero.ToString("D2");
                nuevoIdBoleto = $"{updatedIdViaje}-{numAsiento}";

                if (nBoleto.ExisteIdBoleto(nuevoIdBoleto))
                {
                    MessageBox.Show("Ya existe un boleto con ese viaje y asiento.");
                    idAsientosSeleccionados.Clear();
                    return;
                }
            }

            Boletos boletoActualizado = new Boletos()
            {
                Id_Boleto = nuevoIdBoleto,
                Id_Pasajero = updatedIdPasajero,
                Id_Viaje = updatedIdViaje,
                Id_Asiento = updatedIdAsiento,
                Precio = updatedPrecio,
                Estado = updatedEstado,
                Fecha_Compra = originalFechaCompra
            };

            try
            {
                string mensaje = nBoleto.Modificar(originalIdBoleto, boletoActualizado);
                MessageBox.Show(mensaje);
                MostrarBoletos(nBoleto.ListarTodo());
                idAsientosSeleccionados.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar boleto: " + ex.Message);
            }
        }



        private void btnEliminarBoleto_Click_1(object sender, EventArgs e)
        {
            if (dgBoletos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione el boleto a eliminar.");
                return;
            }

            string idBoletoAEliminar = dgBoletos.SelectedRows[0].Cells["Id_Boleto"].Value.ToString();

            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro que desea eliminar el boleto con ID: {idBoletoAEliminar}?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    string mensaje = nBoleto.Eliminar(idBoletoAEliminar);
                    MessageBox.Show(mensaje);
                    MostrarBoletos(nBoleto.ListarTodo());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar eliminar el boleto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


       



        private void cbPasajeroId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*private void btnEliminarBoleto_Click_1(object sender, EventArgs e)
        {
            if (dgBoletos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione el boleto a eliminar");
                return;
            }
            string idBoleto = dgBoletos.SelectedRows[0].Cells[0].Value.ToString();

            try
            {
                string mensaje = nBoleto.Eliminar(idBoleto);
                MessageBox.Show(mensaje);
                MostrarBoletos(nBoleto.ListarTodo());
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
                if (ex.InnerException != null)
                    mensaje += "\n" + ex.InnerException.Message;
                if (ex.InnerException?.InnerException != null)
                    mensaje += "\n" + ex.InnerException.InnerException.Message;

                MessageBox.Show("Error al eliminar el boleto: " + mensaje);
            }
        }
        */

    }
}
