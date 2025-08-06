namespace Presentación
{
    partial class Gestión_de_Flota_y_Personal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcFlotaYPersonal = new System.Windows.Forms.TabControl();
            this.tpBuses = new System.Windows.Forms.TabPage();
            this.btnBuscarPlaca = new System.Windows.Forms.Button();
            this.lblBuscarPlaca = new System.Windows.Forms.Label();
            this.txtBuscarPlaca = new System.Windows.Forms.TextBox();
            this.btnSalirBus = new System.Windows.Forms.Button();
            this.btnElimnarBus = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgBuses = new System.Windows.Forms.DataGridView();
            this.cbEstadoBus = new System.Windows.Forms.ComboBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblEstadoBus = new System.Windows.Forms.Label();
            this.btnRegistrarBus = new System.Windows.Forms.Button();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.tpConductores = new System.Windows.Forms.TabPage();
            this.lblEstadoCoductor = new System.Windows.Forms.Label();
            this.cbEstadoConductor = new System.Windows.Forms.ComboBox();
            this.txtLicencia = new System.Windows.Forms.TextBox();
            this.btnBuscarDocumento = new System.Windows.Forms.Button();
            this.lblBuscarDocumento = new System.Windows.Forms.Label();
            this.tbBuscarDocumento = new System.Windows.Forms.TextBox();
            this.dgConductores = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblLicencia = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tpAsignaciones = new System.Windows.Forms.TabPage();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.tbObservaciones = new System.Windows.Forms.TextBox();
            this.cbTurno = new System.Windows.Forms.ComboBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.dtpFechaAsignacion = new System.Windows.Forms.DateTimePicker();
            this.cbConductorAsig = new System.Windows.Forms.ComboBox();
            this.cbBusAsig = new System.Windows.Forms.ComboBox();
            this.lblConductorAsig = new System.Windows.Forms.Label();
            this.lblBusAsig = new System.Windows.Forms.Label();
            this.dgAsignaciones = new System.Windows.Forms.DataGridView();
            this.tpMantenimiento = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblBusManten = new System.Windows.Forms.Label();
            this.lblFechaMant = new System.Windows.Forms.Label();
            this.lblCostoMant = new System.Windows.Forms.Label();
            this.lblEmpresaMant = new System.Windows.Forms.Label();
            this.lblDescripciónMant = new System.Windows.Forms.Label();
            this.cbBusMant = new System.Windows.Forms.ComboBox();
            this.dtpMant = new System.Windows.Forms.DateTimePicker();
            this.txtCostoMant = new System.Windows.Forms.TextBox();
            this.txtEmpresaMant = new System.Windows.Forms.TextBox();
            this.txtDescripcionMant = new System.Windows.Forms.TextBox();
            this.btnRegistrarMantenimiento = new System.Windows.Forms.Button();
            this.tcFlotaYPersonal.SuspendLayout();
            this.tpBuses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBuses)).BeginInit();
            this.tpConductores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConductores)).BeginInit();
            this.tpAsignaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAsignaciones)).BeginInit();
            this.tpMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcFlotaYPersonal
            // 
            this.tcFlotaYPersonal.Controls.Add(this.tpBuses);
            this.tcFlotaYPersonal.Controls.Add(this.tpConductores);
            this.tcFlotaYPersonal.Controls.Add(this.tpAsignaciones);
            this.tcFlotaYPersonal.Controls.Add(this.tpMantenimiento);
            this.tcFlotaYPersonal.Location = new System.Drawing.Point(1, 2);
            this.tcFlotaYPersonal.Name = "tcFlotaYPersonal";
            this.tcFlotaYPersonal.SelectedIndex = 0;
            this.tcFlotaYPersonal.Size = new System.Drawing.Size(664, 341);
            this.tcFlotaYPersonal.TabIndex = 0;
            // 
            // tpBuses
            // 
            this.tpBuses.Controls.Add(this.btnBuscarPlaca);
            this.tpBuses.Controls.Add(this.lblBuscarPlaca);
            this.tpBuses.Controls.Add(this.txtBuscarPlaca);
            this.tpBuses.Controls.Add(this.btnSalirBus);
            this.tpBuses.Controls.Add(this.btnElimnarBus);
            this.tpBuses.Controls.Add(this.btnModificar);
            this.tpBuses.Controls.Add(this.dgBuses);
            this.tpBuses.Controls.Add(this.cbEstadoBus);
            this.tpBuses.Controls.Add(this.txtModelo);
            this.tpBuses.Controls.Add(this.txtMarca);
            this.tpBuses.Controls.Add(this.txtPlaca);
            this.tpBuses.Controls.Add(this.lblEstadoBus);
            this.tpBuses.Controls.Add(this.btnRegistrarBus);
            this.tpBuses.Controls.Add(this.lblModelo);
            this.tpBuses.Controls.Add(this.lblMarca);
            this.tpBuses.Controls.Add(this.lblPlaca);
            this.tpBuses.Location = new System.Drawing.Point(4, 22);
            this.tpBuses.Name = "tpBuses";
            this.tpBuses.Padding = new System.Windows.Forms.Padding(3);
            this.tpBuses.Size = new System.Drawing.Size(656, 315);
            this.tpBuses.TabIndex = 0;
            this.tpBuses.Text = "Buses";
            this.tpBuses.UseVisualStyleBackColor = true;
            // 
            // btnBuscarPlaca
            // 
            this.btnBuscarPlaca.Location = new System.Drawing.Point(549, 264);
            this.btnBuscarPlaca.Name = "btnBuscarPlaca";
            this.btnBuscarPlaca.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPlaca.TabIndex = 31;
            this.btnBuscarPlaca.Text = "Buscar";
            this.btnBuscarPlaca.UseVisualStyleBackColor = true;
            // 
            // lblBuscarPlaca
            // 
            this.lblBuscarPlaca.AutoSize = true;
            this.lblBuscarPlaca.Location = new System.Drawing.Point(228, 270);
            this.lblBuscarPlaca.Name = "lblBuscarPlaca";
            this.lblBuscarPlaca.Size = new System.Drawing.Size(110, 13);
            this.lblBuscarPlaca.TabIndex = 30;
            this.lblBuscarPlaca.Text = "Buscar bus por placa:";
            // 
            // txtBuscarPlaca
            // 
            this.txtBuscarPlaca.Location = new System.Drawing.Point(402, 267);
            this.txtBuscarPlaca.Name = "txtBuscarPlaca";
            this.txtBuscarPlaca.Size = new System.Drawing.Size(127, 20);
            this.txtBuscarPlaca.TabIndex = 29;
            // 
            // btnSalirBus
            // 
            this.btnSalirBus.Location = new System.Drawing.Point(84, 249);
            this.btnSalirBus.Name = "btnSalirBus";
            this.btnSalirBus.Size = new System.Drawing.Size(75, 23);
            this.btnSalirBus.TabIndex = 12;
            this.btnSalirBus.Text = "Salir";
            this.btnSalirBus.UseVisualStyleBackColor = true;
            // 
            // btnElimnarBus
            // 
            this.btnElimnarBus.Location = new System.Drawing.Point(84, 219);
            this.btnElimnarBus.Name = "btnElimnarBus";
            this.btnElimnarBus.Size = new System.Drawing.Size(75, 23);
            this.btnElimnarBus.TabIndex = 11;
            this.btnElimnarBus.Text = "Eliminar";
            this.btnElimnarBus.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(84, 189);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Actualizar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // dgBuses
            // 
            this.dgBuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBuses.Location = new System.Drawing.Point(231, 19);
            this.dgBuses.Name = "dgBuses";
            this.dgBuses.Size = new System.Drawing.Size(393, 232);
            this.dgBuses.TabIndex = 9;
            // 
            // cbEstadoBus
            // 
            this.cbEstadoBus.FormattingEnabled = true;
            this.cbEstadoBus.Items.AddRange(new object[] {
            "Activo",
            "Retirado",
            "En Mantenimiento"});
            this.cbEstadoBus.Location = new System.Drawing.Point(84, 117);
            this.cbEstadoBus.Name = "cbEstadoBus";
            this.cbEstadoBus.Size = new System.Drawing.Size(121, 21);
            this.cbEstadoBus.TabIndex = 8;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(84, 85);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(121, 20);
            this.txtModelo.TabIndex = 7;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(84, 50);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(121, 20);
            this.txtMarca.TabIndex = 6;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(84, 19);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(121, 20);
            this.txtPlaca.TabIndex = 5;
            // 
            // lblEstadoBus
            // 
            this.lblEstadoBus.AutoSize = true;
            this.lblEstadoBus.Location = new System.Drawing.Point(21, 117);
            this.lblEstadoBus.Name = "lblEstadoBus";
            this.lblEstadoBus.Size = new System.Drawing.Size(43, 13);
            this.lblEstadoBus.TabIndex = 4;
            this.lblEstadoBus.Text = "Estado:";
            // 
            // btnRegistrarBus
            // 
            this.btnRegistrarBus.Location = new System.Drawing.Point(84, 159);
            this.btnRegistrarBus.Name = "btnRegistrarBus";
            this.btnRegistrarBus.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarBus.TabIndex = 3;
            this.btnRegistrarBus.Text = "Registrar";
            this.btnRegistrarBus.UseVisualStyleBackColor = true;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(21, 85);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(21, 53);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca:";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(21, 19);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(37, 13);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Placa:";
            // 
            // tpConductores
            // 
            this.tpConductores.Controls.Add(this.lblEstadoCoductor);
            this.tpConductores.Controls.Add(this.cbEstadoConductor);
            this.tpConductores.Controls.Add(this.txtLicencia);
            this.tpConductores.Controls.Add(this.btnBuscarDocumento);
            this.tpConductores.Controls.Add(this.lblBuscarDocumento);
            this.tpConductores.Controls.Add(this.tbBuscarDocumento);
            this.tpConductores.Controls.Add(this.dgConductores);
            this.tpConductores.Controls.Add(this.button1);
            this.tpConductores.Controls.Add(this.button2);
            this.tpConductores.Controls.Add(this.button3);
            this.tpConductores.Controls.Add(this.txtTelefono);
            this.tpConductores.Controls.Add(this.txtDocumento);
            this.tpConductores.Controls.Add(this.txtNombre);
            this.tpConductores.Controls.Add(this.lblLicencia);
            this.tpConductores.Controls.Add(this.button4);
            this.tpConductores.Controls.Add(this.label2);
            this.tpConductores.Controls.Add(this.lblDocumento);
            this.tpConductores.Controls.Add(this.lblNombre);
            this.tpConductores.Location = new System.Drawing.Point(4, 22);
            this.tpConductores.Name = "tpConductores";
            this.tpConductores.Padding = new System.Windows.Forms.Padding(3);
            this.tpConductores.Size = new System.Drawing.Size(656, 315);
            this.tpConductores.TabIndex = 1;
            this.tpConductores.Text = "Conductores";
            this.tpConductores.UseVisualStyleBackColor = true;
            // 
            // lblEstadoCoductor
            // 
            this.lblEstadoCoductor.AutoSize = true;
            this.lblEstadoCoductor.Location = new System.Drawing.Point(20, 152);
            this.lblEstadoCoductor.Name = "lblEstadoCoductor";
            this.lblEstadoCoductor.Size = new System.Drawing.Size(46, 13);
            this.lblEstadoCoductor.TabIndex = 31;
            this.lblEstadoCoductor.Text = "Estado: ";
            // 
            // cbEstadoConductor
            // 
            this.cbEstadoConductor.FormattingEnabled = true;
            this.cbEstadoConductor.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbEstadoConductor.Location = new System.Drawing.Point(117, 152);
            this.cbEstadoConductor.Name = "cbEstadoConductor";
            this.cbEstadoConductor.Size = new System.Drawing.Size(121, 21);
            this.cbEstadoConductor.TabIndex = 30;
            // 
            // txtLicencia
            // 
            this.txtLicencia.Location = new System.Drawing.Point(117, 116);
            this.txtLicencia.Name = "txtLicencia";
            this.txtLicencia.Size = new System.Drawing.Size(121, 20);
            this.txtLicencia.TabIndex = 29;
            // 
            // btnBuscarDocumento
            // 
            this.btnBuscarDocumento.Location = new System.Drawing.Point(543, 262);
            this.btnBuscarDocumento.Name = "btnBuscarDocumento";
            this.btnBuscarDocumento.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarDocumento.TabIndex = 28;
            this.btnBuscarDocumento.Text = "Buscar";
            this.btnBuscarDocumento.UseVisualStyleBackColor = true;
            // 
            // lblBuscarDocumento
            // 
            this.lblBuscarDocumento.AutoSize = true;
            this.lblBuscarDocumento.Location = new System.Drawing.Point(252, 267);
            this.lblBuscarDocumento.Name = "lblBuscarDocumento";
            this.lblBuscarDocumento.Size = new System.Drawing.Size(168, 13);
            this.lblBuscarDocumento.TabIndex = 27;
            this.lblBuscarDocumento.Text = "Buscar conductor por documento:";
            // 
            // tbBuscarDocumento
            // 
            this.tbBuscarDocumento.Location = new System.Drawing.Point(426, 264);
            this.tbBuscarDocumento.Name = "tbBuscarDocumento";
            this.tbBuscarDocumento.Size = new System.Drawing.Size(109, 20);
            this.tbBuscarDocumento.TabIndex = 26;
            // 
            // dgConductores
            // 
            this.dgConductores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConductores.Location = new System.Drawing.Point(255, 18);
            this.dgConductores.Name = "dgConductores";
            this.dgConductores.Size = new System.Drawing.Size(363, 226);
            this.dgConductores.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(88, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Actualizar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(117, 84);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(121, 20);
            this.txtTelefono.TabIndex = 20;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(117, 49);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(121, 20);
            this.txtDocumento.TabIndex = 19;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(117, 21);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 18;
            // 
            // lblLicencia
            // 
            this.lblLicencia.AutoSize = true;
            this.lblLicencia.Location = new System.Drawing.Point(17, 119);
            this.lblLicencia.Name = "lblLicencia";
            this.lblLicencia.Size = new System.Drawing.Size(50, 13);
            this.lblLicencia.TabIndex = 17;
            this.lblLicencia.Text = "Licencia:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(88, 184);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Registrar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Telefono:";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(17, 55);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(65, 13);
            this.lblDocumento.TabIndex = 14;
            this.lblDocumento.Text = "Documento:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(93, 13);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre completo:";
            // 
            // tpAsignaciones
            // 
            this.tpAsignaciones.Controls.Add(this.btnAsignar);
            this.tpAsignaciones.Controls.Add(this.lblObservaciones);
            this.tpAsignaciones.Controls.Add(this.tbObservaciones);
            this.tpAsignaciones.Controls.Add(this.cbTurno);
            this.tpAsignaciones.Controls.Add(this.lblTurno);
            this.tpAsignaciones.Controls.Add(this.lblFechaHora);
            this.tpAsignaciones.Controls.Add(this.dtpFechaAsignacion);
            this.tpAsignaciones.Controls.Add(this.cbConductorAsig);
            this.tpAsignaciones.Controls.Add(this.cbBusAsig);
            this.tpAsignaciones.Controls.Add(this.lblConductorAsig);
            this.tpAsignaciones.Controls.Add(this.lblBusAsig);
            this.tpAsignaciones.Controls.Add(this.dgAsignaciones);
            this.tpAsignaciones.Location = new System.Drawing.Point(4, 22);
            this.tpAsignaciones.Name = "tpAsignaciones";
            this.tpAsignaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tpAsignaciones.Size = new System.Drawing.Size(656, 315);
            this.tpAsignaciones.TabIndex = 2;
            this.tpAsignaciones.Text = "Asignaciones";
            this.tpAsignaciones.UseVisualStyleBackColor = true;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(79, 253);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(75, 23);
            this.btnAsignar.TabIndex = 11;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(23, 158);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(78, 13);
            this.lblObservaciones.TabIndex = 10;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // tbObservaciones
            // 
            this.tbObservaciones.Location = new System.Drawing.Point(26, 174);
            this.tbObservaciones.Multiline = true;
            this.tbObservaciones.Name = "tbObservaciones";
            this.tbObservaciones.Size = new System.Drawing.Size(189, 72);
            this.tbObservaciones.TabIndex = 9;
            // 
            // cbTurno
            // 
            this.cbTurno.FormattingEnabled = true;
            this.cbTurno.Location = new System.Drawing.Point(94, 69);
            this.cbTurno.Name = "cbTurno";
            this.cbTurno.Size = new System.Drawing.Size(121, 21);
            this.cbTurno.TabIndex = 8;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(23, 72);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(38, 13);
            this.lblTurno.TabIndex = 7;
            this.lblTurno.Text = "Turno:";
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Location = new System.Drawing.Point(23, 104);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(72, 13);
            this.lblFechaHora.TabIndex = 6;
            this.lblFechaHora.Text = "Fecha y hora:";
            // 
            // dtpFechaAsignacion
            // 
            this.dtpFechaAsignacion.Location = new System.Drawing.Point(26, 129);
            this.dtpFechaAsignacion.Name = "dtpFechaAsignacion";
            this.dtpFechaAsignacion.Size = new System.Drawing.Size(189, 20);
            this.dtpFechaAsignacion.TabIndex = 5;
            // 
            // cbConductorAsig
            // 
            this.cbConductorAsig.FormattingEnabled = true;
            this.cbConductorAsig.Location = new System.Drawing.Point(94, 42);
            this.cbConductorAsig.Name = "cbConductorAsig";
            this.cbConductorAsig.Size = new System.Drawing.Size(121, 21);
            this.cbConductorAsig.TabIndex = 4;
            // 
            // cbBusAsig
            // 
            this.cbBusAsig.FormattingEnabled = true;
            this.cbBusAsig.Location = new System.Drawing.Point(94, 15);
            this.cbBusAsig.Name = "cbBusAsig";
            this.cbBusAsig.Size = new System.Drawing.Size(121, 21);
            this.cbBusAsig.TabIndex = 3;
            // 
            // lblConductorAsig
            // 
            this.lblConductorAsig.AutoSize = true;
            this.lblConductorAsig.Location = new System.Drawing.Point(23, 45);
            this.lblConductorAsig.Name = "lblConductorAsig";
            this.lblConductorAsig.Size = new System.Drawing.Size(59, 13);
            this.lblConductorAsig.TabIndex = 2;
            this.lblConductorAsig.Text = "Conductor:";
            // 
            // lblBusAsig
            // 
            this.lblBusAsig.AutoSize = true;
            this.lblBusAsig.Location = new System.Drawing.Point(23, 18);
            this.lblBusAsig.Name = "lblBusAsig";
            this.lblBusAsig.Size = new System.Drawing.Size(28, 13);
            this.lblBusAsig.TabIndex = 1;
            this.lblBusAsig.Text = "Bus:";
            // 
            // dgAsignaciones
            // 
            this.dgAsignaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAsignaciones.Location = new System.Drawing.Point(232, 15);
            this.dgAsignaciones.Name = "dgAsignaciones";
            this.dgAsignaciones.Size = new System.Drawing.Size(415, 231);
            this.dgAsignaciones.TabIndex = 0;
            // 
            // tpMantenimiento
            // 
            this.tpMantenimiento.Controls.Add(this.btnRegistrarMantenimiento);
            this.tpMantenimiento.Controls.Add(this.txtDescripcionMant);
            this.tpMantenimiento.Controls.Add(this.txtEmpresaMant);
            this.tpMantenimiento.Controls.Add(this.txtCostoMant);
            this.tpMantenimiento.Controls.Add(this.dtpMant);
            this.tpMantenimiento.Controls.Add(this.cbBusMant);
            this.tpMantenimiento.Controls.Add(this.lblDescripciónMant);
            this.tpMantenimiento.Controls.Add(this.lblEmpresaMant);
            this.tpMantenimiento.Controls.Add(this.lblCostoMant);
            this.tpMantenimiento.Controls.Add(this.lblFechaMant);
            this.tpMantenimiento.Controls.Add(this.lblBusManten);
            this.tpMantenimiento.Controls.Add(this.dataGridView1);
            this.tpMantenimiento.Location = new System.Drawing.Point(4, 22);
            this.tpMantenimiento.Name = "tpMantenimiento";
            this.tpMantenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tpMantenimiento.Size = new System.Drawing.Size(656, 315);
            this.tpMantenimiento.TabIndex = 3;
            this.tpMantenimiento.Text = "Mantenimientos";
            this.tpMantenimiento.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(234, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(403, 225);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblBusManten
            // 
            this.lblBusManten.AutoSize = true;
            this.lblBusManten.Location = new System.Drawing.Point(13, 28);
            this.lblBusManten.Name = "lblBusManten";
            this.lblBusManten.Size = new System.Drawing.Size(28, 13);
            this.lblBusManten.TabIndex = 1;
            this.lblBusManten.Text = "Bus:";
            // 
            // lblFechaMant
            // 
            this.lblFechaMant.AutoSize = true;
            this.lblFechaMant.Location = new System.Drawing.Point(13, 83);
            this.lblFechaMant.Name = "lblFechaMant";
            this.lblFechaMant.Size = new System.Drawing.Size(40, 13);
            this.lblFechaMant.TabIndex = 2;
            this.lblFechaMant.Text = "Fecha:";
            // 
            // lblCostoMant
            // 
            this.lblCostoMant.AutoSize = true;
            this.lblCostoMant.Location = new System.Drawing.Point(13, 55);
            this.lblCostoMant.Name = "lblCostoMant";
            this.lblCostoMant.Size = new System.Drawing.Size(37, 13);
            this.lblCostoMant.TabIndex = 3;
            this.lblCostoMant.Text = "Costo:";
            // 
            // lblEmpresaMant
            // 
            this.lblEmpresaMant.AutoSize = true;
            this.lblEmpresaMant.Location = new System.Drawing.Point(13, 131);
            this.lblEmpresaMant.Name = "lblEmpresaMant";
            this.lblEmpresaMant.Size = new System.Drawing.Size(116, 13);
            this.lblEmpresaMant.TabIndex = 4;
            this.lblEmpresaMant.Text = "Empresa Responsable:";
            // 
            // lblDescripciónMant
            // 
            this.lblDescripciónMant.AutoSize = true;
            this.lblDescripciónMant.Location = new System.Drawing.Point(13, 180);
            this.lblDescripciónMant.Name = "lblDescripciónMant";
            this.lblDescripciónMant.Size = new System.Drawing.Size(66, 13);
            this.lblDescripciónMant.TabIndex = 5;
            this.lblDescripciónMant.Text = "Descripción:";
            // 
            // cbBusMant
            // 
            this.cbBusMant.FormattingEnabled = true;
            this.cbBusMant.Location = new System.Drawing.Point(95, 25);
            this.cbBusMant.Name = "cbBusMant";
            this.cbBusMant.Size = new System.Drawing.Size(121, 21);
            this.cbBusMant.TabIndex = 6;
            // 
            // dtpMant
            // 
            this.dtpMant.Location = new System.Drawing.Point(16, 100);
            this.dtpMant.Name = "dtpMant";
            this.dtpMant.Size = new System.Drawing.Size(200, 20);
            this.dtpMant.TabIndex = 7;
            // 
            // txtCostoMant
            // 
            this.txtCostoMant.Location = new System.Drawing.Point(95, 52);
            this.txtCostoMant.Name = "txtCostoMant";
            this.txtCostoMant.Size = new System.Drawing.Size(121, 20);
            this.txtCostoMant.TabIndex = 8;
            // 
            // txtEmpresaMant
            // 
            this.txtEmpresaMant.Location = new System.Drawing.Point(16, 148);
            this.txtEmpresaMant.Name = "txtEmpresaMant";
            this.txtEmpresaMant.Size = new System.Drawing.Size(200, 20);
            this.txtEmpresaMant.TabIndex = 9;
            // 
            // txtDescripcionMant
            // 
            this.txtDescripcionMant.Location = new System.Drawing.Point(16, 197);
            this.txtDescripcionMant.Multiline = true;
            this.txtDescripcionMant.Name = "txtDescripcionMant";
            this.txtDescripcionMant.Size = new System.Drawing.Size(200, 50);
            this.txtDescripcionMant.TabIndex = 10;
            // 
            // btnRegistrarMantenimiento
            // 
            this.btnRegistrarMantenimiento.Location = new System.Drawing.Point(53, 253);
            this.btnRegistrarMantenimiento.Name = "btnRegistrarMantenimiento";
            this.btnRegistrarMantenimiento.Size = new System.Drawing.Size(136, 23);
            this.btnRegistrarMantenimiento.TabIndex = 11;
            this.btnRegistrarMantenimiento.Text = "Registrar Mantenimiento";
            this.btnRegistrarMantenimiento.UseVisualStyleBackColor = true;
            // 
            // Gestión_de_Flota_y_Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 340);
            this.Controls.Add(this.tcFlotaYPersonal);
            this.Name = "Gestión_de_Flota_y_Personal";
            this.Text = "Gestión_de_Flota_y_Personal";
            this.tcFlotaYPersonal.ResumeLayout(false);
            this.tpBuses.ResumeLayout(false);
            this.tpBuses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBuses)).EndInit();
            this.tpConductores.ResumeLayout(false);
            this.tpConductores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConductores)).EndInit();
            this.tpAsignaciones.ResumeLayout(false);
            this.tpAsignaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAsignaciones)).EndInit();
            this.tpMantenimiento.ResumeLayout(false);
            this.tpMantenimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcFlotaYPersonal;
        private System.Windows.Forms.TabPage tpBuses;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TabPage tpConductores;
        private System.Windows.Forms.TabPage tpAsignaciones;
        private System.Windows.Forms.TabPage tpMantenimiento;
        private System.Windows.Forms.Button btnRegistrarBus;
        private System.Windows.Forms.Button btnSalirBus;
        private System.Windows.Forms.Button btnElimnarBus;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgBuses;
        private System.Windows.Forms.ComboBox cbEstadoBus;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblEstadoBus;
        private System.Windows.Forms.Button btnBuscarPlaca;
        private System.Windows.Forms.Label lblBuscarPlaca;
        private System.Windows.Forms.TextBox txtBuscarPlaca;
        private System.Windows.Forms.Button btnBuscarDocumento;
        private System.Windows.Forms.Label lblBuscarDocumento;
        private System.Windows.Forms.TextBox tbBuscarDocumento;
        private System.Windows.Forms.DataGridView dgConductores;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblLicencia;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtLicencia;
        private System.Windows.Forms.Label lblEstadoCoductor;
        private System.Windows.Forms.ComboBox cbEstadoConductor;
        private System.Windows.Forms.DateTimePicker dtpFechaAsignacion;
        private System.Windows.Forms.ComboBox cbConductorAsig;
        private System.Windows.Forms.ComboBox cbBusAsig;
        private System.Windows.Forms.Label lblConductorAsig;
        private System.Windows.Forms.Label lblBusAsig;
        private System.Windows.Forms.DataGridView dgAsignaciones;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox tbObservaciones;
        private System.Windows.Forms.ComboBox cbTurno;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Button btnRegistrarMantenimiento;
        private System.Windows.Forms.TextBox txtDescripcionMant;
        private System.Windows.Forms.TextBox txtEmpresaMant;
        private System.Windows.Forms.TextBox txtCostoMant;
        private System.Windows.Forms.DateTimePicker dtpMant;
        private System.Windows.Forms.ComboBox cbBusMant;
        private System.Windows.Forms.Label lblDescripciónMant;
        private System.Windows.Forms.Label lblEmpresaMant;
        private System.Windows.Forms.Label lblCostoMant;
        private System.Windows.Forms.Label lblFechaMant;
        private System.Windows.Forms.Label lblBusManten;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}