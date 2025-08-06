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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestión_de_Flota_y_Personal));
            this.tcFlotaYPersonal = new System.Windows.Forms.TabControl();
            this.tpBuses = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAsientos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblEstadoCoductor = new System.Windows.Forms.Label();
            this.cbEstadoConductor = new System.Windows.Forms.ComboBox();
            this.txtLicencia = new System.Windows.Forms.TextBox();
            this.btnBuscarDocumento = new System.Windows.Forms.Button();
            this.lblBuscarDocumento = new System.Windows.Forms.Label();
            this.tbBuscarDocumento = new System.Windows.Forms.TextBox();
            this.dgConductores = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminarCond = new System.Windows.Forms.Button();
            this.btnActualizarCond = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblLicencia = new System.Windows.Forms.Label();
            this.btnRegistrarConductor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tpAsignaciones = new System.Windows.Forms.TabPage();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
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
            this.btnRegistrarMantenimiento = new System.Windows.Forms.Button();
            this.txtDescripcionMant = new System.Windows.Forms.TextBox();
            this.txtEmpresaMant = new System.Windows.Forms.TextBox();
            this.txtCostoMant = new System.Windows.Forms.TextBox();
            this.dtpMant = new System.Windows.Forms.DateTimePicker();
            this.cbBusMant = new System.Windows.Forms.ComboBox();
            this.lblDescripciónMant = new System.Windows.Forms.Label();
            this.lblEmpresaMant = new System.Windows.Forms.Label();
            this.lblCostoMant = new System.Windows.Forms.Label();
            this.lblFechaMant = new System.Windows.Forms.Label();
            this.lblBusManten = new System.Windows.Forms.Label();
            this.dgMantenimiento = new System.Windows.Forms.DataGridView();
            this.btnEditarAsig = new System.Windows.Forms.Button();
            this.btnEliminarAsig = new System.Windows.Forms.Button();
            this.tcFlotaYPersonal.SuspendLayout();
            this.tpBuses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBuses)).BeginInit();
            this.tpConductores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConductores)).BeginInit();
            this.tpAsignaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAsignaciones)).BeginInit();
            this.tpMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMantenimiento)).BeginInit();
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
            this.tpBuses.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpBuses.BackgroundImage")));
            this.tpBuses.Controls.Add(this.label4);
            this.tpBuses.Controls.Add(this.btnAsientos);
            this.tpBuses.Controls.Add(this.button1);
            this.tpBuses.Controls.Add(this.txtCapacidad);
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
            this.tpBuses.Click += new System.EventHandler(this.tpBuses_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Menu;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 12);
            this.label4.TabIndex = 37;
            this.label4.Text = "Capacidad:";
            // 
            // btnAsientos
            // 
            this.btnAsientos.Location = new System.Drawing.Point(121, 224);
            this.btnAsientos.Name = "btnAsientos";
            this.btnAsientos.Size = new System.Drawing.Size(75, 23);
            this.btnAsientos.TabIndex = 35;
            this.btnAsientos.Text = "Asientos";
            this.btnAsientos.UseVisualStyleBackColor = true;
            this.btnAsientos.Click += new System.EventHandler(this.btnAsientos_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(90, 135);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(121, 20);
            this.txtCapacidad.TabIndex = 32;
            this.txtCapacidad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnBuscarPlaca
            // 
            this.btnBuscarPlaca.Location = new System.Drawing.Point(519, 269);
            this.btnBuscarPlaca.Name = "btnBuscarPlaca";
            this.btnBuscarPlaca.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPlaca.TabIndex = 31;
            this.btnBuscarPlaca.Text = "Buscar";
            this.btnBuscarPlaca.UseVisualStyleBackColor = true;
            this.btnBuscarPlaca.Click += new System.EventHandler(this.btnBuscarPlaca_Click);
            // 
            // lblBuscarPlaca
            // 
            this.lblBuscarPlaca.AutoSize = true;
            this.lblBuscarPlaca.BackColor = System.Drawing.SystemColors.Menu;
            this.lblBuscarPlaca.Location = new System.Drawing.Point(271, 274);
            this.lblBuscarPlaca.Name = "lblBuscarPlaca";
            this.lblBuscarPlaca.Size = new System.Drawing.Size(110, 13);
            this.lblBuscarPlaca.TabIndex = 30;
            this.lblBuscarPlaca.Text = "Buscar bus por placa:";
            // 
            // txtBuscarPlaca
            // 
            this.txtBuscarPlaca.Location = new System.Drawing.Point(387, 271);
            this.txtBuscarPlaca.Name = "txtBuscarPlaca";
            this.txtBuscarPlaca.Size = new System.Drawing.Size(127, 20);
            this.txtBuscarPlaca.TabIndex = 29;
            // 
            // btnSalirBus
            // 
            this.btnSalirBus.Location = new System.Drawing.Point(121, 255);
            this.btnSalirBus.Name = "btnSalirBus";
            this.btnSalirBus.Size = new System.Drawing.Size(75, 23);
            this.btnSalirBus.TabIndex = 12;
            this.btnSalirBus.Text = "Salir";
            this.btnSalirBus.UseVisualStyleBackColor = true;
            this.btnSalirBus.Click += new System.EventHandler(this.btnSalirBus_Click);
            // 
            // btnElimnarBus
            // 
            this.btnElimnarBus.Location = new System.Drawing.Point(121, 194);
            this.btnElimnarBus.Name = "btnElimnarBus";
            this.btnElimnarBus.Size = new System.Drawing.Size(75, 23);
            this.btnElimnarBus.TabIndex = 11;
            this.btnElimnarBus.Text = "Eliminar";
            this.btnElimnarBus.UseVisualStyleBackColor = true;
            this.btnElimnarBus.Click += new System.EventHandler(this.btnElimnarBus_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(26, 224);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Actualizar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgBuses
            // 
            this.dgBuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBuses.Location = new System.Drawing.Point(231, 19);
            this.dgBuses.Name = "dgBuses";
            this.dgBuses.RowHeadersWidth = 51;
            this.dgBuses.Size = new System.Drawing.Size(416, 232);
            this.dgBuses.TabIndex = 9;
            // 
            // cbEstadoBus
            // 
            this.cbEstadoBus.FormattingEnabled = true;
            this.cbEstadoBus.Items.AddRange(new object[] {
            "Activo",
            "Retirado",
            "En Mantenimiento"});
            this.cbEstadoBus.Location = new System.Drawing.Point(90, 108);
            this.cbEstadoBus.Name = "cbEstadoBus";
            this.cbEstadoBus.Size = new System.Drawing.Size(121, 21);
            this.cbEstadoBus.TabIndex = 8;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(90, 80);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(121, 20);
            this.txtModelo.TabIndex = 7;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(90, 52);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(121, 20);
            this.txtMarca.TabIndex = 6;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(90, 24);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(121, 20);
            this.txtPlaca.TabIndex = 5;
            // 
            // lblEstadoBus
            // 
            this.lblEstadoBus.AutoSize = true;
            this.lblEstadoBus.BackColor = System.Drawing.SystemColors.Menu;
            this.lblEstadoBus.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoBus.Location = new System.Drawing.Point(13, 108);
            this.lblEstadoBus.Name = "lblEstadoBus";
            this.lblEstadoBus.Size = new System.Drawing.Size(51, 12);
            this.lblEstadoBus.TabIndex = 4;
            this.lblEstadoBus.Text = "Estado:";
            // 
            // btnRegistrarBus
            // 
            this.btnRegistrarBus.Location = new System.Drawing.Point(26, 194);
            this.btnRegistrarBus.Name = "btnRegistrarBus";
            this.btnRegistrarBus.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarBus.TabIndex = 3;
            this.btnRegistrarBus.Text = "Registrar";
            this.btnRegistrarBus.UseVisualStyleBackColor = true;
            this.btnRegistrarBus.Click += new System.EventHandler(this.btnRegistrarBus_Click);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.BackColor = System.Drawing.SystemColors.Menu;
            this.lblModelo.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(12, 83);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(55, 12);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.SystemColors.Menu;
            this.lblMarca.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(13, 55);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(46, 12);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca:";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.BackColor = System.Drawing.SystemColors.Menu;
            this.lblPlaca.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(13, 31);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(40, 12);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Placa:";
            // 
            // tpConductores
            // 
            this.tpConductores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpConductores.BackgroundImage")));
            this.tpConductores.Controls.Add(this.btnLimpiar);
            this.tpConductores.Controls.Add(this.lblEstadoCoductor);
            this.tpConductores.Controls.Add(this.cbEstadoConductor);
            this.tpConductores.Controls.Add(this.txtLicencia);
            this.tpConductores.Controls.Add(this.btnBuscarDocumento);
            this.tpConductores.Controls.Add(this.lblBuscarDocumento);
            this.tpConductores.Controls.Add(this.tbBuscarDocumento);
            this.tpConductores.Controls.Add(this.dgConductores);
            this.tpConductores.Controls.Add(this.btnSalir);
            this.tpConductores.Controls.Add(this.btnEliminarCond);
            this.tpConductores.Controls.Add(this.btnActualizarCond);
            this.tpConductores.Controls.Add(this.txtTelefono);
            this.tpConductores.Controls.Add(this.txtDocumento);
            this.tpConductores.Controls.Add(this.txtNombre);
            this.tpConductores.Controls.Add(this.lblLicencia);
            this.tpConductores.Controls.Add(this.btnRegistrarConductor);
            this.tpConductores.Controls.Add(this.label2);
            this.tpConductores.Controls.Add(this.lblDocumento);
            this.tpConductores.Controls.Add(this.lblNombre);
            this.tpConductores.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpConductores.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpConductores.Location = new System.Drawing.Point(4, 22);
            this.tpConductores.Name = "tpConductores";
            this.tpConductores.Padding = new System.Windows.Forms.Padding(3);
            this.tpConductores.Size = new System.Drawing.Size(656, 315);
            this.tpConductores.TabIndex = 1;
            this.tpConductores.Text = "Conductores";
            this.tpConductores.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(139, 239);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 33;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblEstadoCoductor
            // 
            this.lblEstadoCoductor.AutoSize = true;
            this.lblEstadoCoductor.BackColor = System.Drawing.SystemColors.Menu;
            this.lblEstadoCoductor.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCoductor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEstadoCoductor.Location = new System.Drawing.Point(21, 152);
            this.lblEstadoCoductor.Name = "lblEstadoCoductor";
            this.lblEstadoCoductor.Size = new System.Drawing.Size(55, 12);
            this.lblEstadoCoductor.TabIndex = 31;
            this.lblEstadoCoductor.Text = "Estado: ";
            // 
            // cbEstadoConductor
            // 
            this.cbEstadoConductor.FormattingEnabled = true;
            this.cbEstadoConductor.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbEstadoConductor.Location = new System.Drawing.Point(118, 149);
            this.cbEstadoConductor.Name = "cbEstadoConductor";
            this.cbEstadoConductor.Size = new System.Drawing.Size(121, 22);
            this.cbEstadoConductor.TabIndex = 30;
            // 
            // txtLicencia
            // 
            this.txtLicencia.Location = new System.Drawing.Point(118, 119);
            this.txtLicencia.Name = "txtLicencia";
            this.txtLicencia.Size = new System.Drawing.Size(121, 20);
            this.txtLicencia.TabIndex = 29;
            // 
            // btnBuscarDocumento
            // 
            this.btnBuscarDocumento.Location = new System.Drawing.Point(555, 263);
            this.btnBuscarDocumento.Name = "btnBuscarDocumento";
            this.btnBuscarDocumento.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarDocumento.TabIndex = 28;
            this.btnBuscarDocumento.Text = "Buscar";
            this.btnBuscarDocumento.UseVisualStyleBackColor = true;
            this.btnBuscarDocumento.Click += new System.EventHandler(this.btnBuscarDocumento_Click);
            // 
            // lblBuscarDocumento
            // 
            this.lblBuscarDocumento.AutoSize = true;
            this.lblBuscarDocumento.BackColor = System.Drawing.SystemColors.Menu;
            this.lblBuscarDocumento.Location = new System.Drawing.Point(239, 268);
            this.lblBuscarDocumento.Name = "lblBuscarDocumento";
            this.lblBuscarDocumento.Size = new System.Drawing.Size(193, 14);
            this.lblBuscarDocumento.TabIndex = 27;
            this.lblBuscarDocumento.Text = "Buscar conductor por documento:";
            // 
            // tbBuscarDocumento
            // 
            this.tbBuscarDocumento.Location = new System.Drawing.Point(438, 265);
            this.tbBuscarDocumento.Name = "tbBuscarDocumento";
            this.tbBuscarDocumento.Size = new System.Drawing.Size(109, 20);
            this.tbBuscarDocumento.TabIndex = 26;
            // 
            // dgConductores
            // 
            this.dgConductores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConductores.Location = new System.Drawing.Point(255, 18);
            this.dgConductores.Name = "dgConductores";
            this.dgConductores.RowHeadersWidth = 51;
            this.dgConductores.Size = new System.Drawing.Size(392, 226);
            this.dgConductores.TabIndex = 25;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(87, 277);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminarCond
            // 
            this.btnEliminarCond.Location = new System.Drawing.Point(35, 240);
            this.btnEliminarCond.Name = "btnEliminarCond";
            this.btnEliminarCond.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCond.TabIndex = 23;
            this.btnEliminarCond.Text = "Eliminar";
            this.btnEliminarCond.UseVisualStyleBackColor = true;
            this.btnEliminarCond.Click += new System.EventHandler(this.btnEliminarCond_Click);
            // 
            // btnActualizarCond
            // 
            this.btnActualizarCond.Location = new System.Drawing.Point(139, 202);
            this.btnActualizarCond.Name = "btnActualizarCond";
            this.btnActualizarCond.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarCond.TabIndex = 22;
            this.btnActualizarCond.Text = "Actualizar";
            this.btnActualizarCond.UseVisualStyleBackColor = true;
            this.btnActualizarCond.Click += new System.EventHandler(this.btnActualizarCond_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(118, 91);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(121, 20);
            this.txtTelefono.TabIndex = 20;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(118, 61);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(121, 20);
            this.txtDocumento.TabIndex = 19;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(118, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 18;
            // 
            // lblLicencia
            // 
            this.lblLicencia.AutoSize = true;
            this.lblLicencia.BackColor = System.Drawing.SystemColors.Menu;
            this.lblLicencia.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicencia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLicencia.Location = new System.Drawing.Point(18, 122);
            this.lblLicencia.Name = "lblLicencia";
            this.lblLicencia.Size = new System.Drawing.Size(58, 12);
            this.lblLicencia.TabIndex = 17;
            this.lblLicencia.Text = "Licencia:";
            // 
            // btnRegistrarConductor
            // 
            this.btnRegistrarConductor.Location = new System.Drawing.Point(35, 202);
            this.btnRegistrarConductor.Name = "btnRegistrarConductor";
            this.btnRegistrarConductor.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarConductor.TabIndex = 16;
            this.btnRegistrarConductor.Text = "Registrar";
            this.btnRegistrarConductor.UseVisualStyleBackColor = true;
            this.btnRegistrarConductor.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Menu;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(18, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "Telefono:";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.BackColor = System.Drawing.SystemColors.Menu;
            this.lblDocumento.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDocumento.Location = new System.Drawing.Point(18, 67);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(78, 12);
            this.lblDocumento.TabIndex = 14;
            this.lblDocumento.Text = "Documento:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.SystemColors.Menu;
            this.lblNombre.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNombre.Location = new System.Drawing.Point(21, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 24);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre \r\ncompleto:";
            // 
            // tpAsignaciones
            // 
            this.tpAsignaciones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpAsignaciones.BackgroundImage")));
            this.tpAsignaciones.Controls.Add(this.btnEliminarAsig);
            this.tpAsignaciones.Controls.Add(this.btnEditarAsig);
            this.tpAsignaciones.Controls.Add(this.btnAsignar);
            this.tpAsignaciones.Controls.Add(this.lblObservaciones);
            this.tpAsignaciones.Controls.Add(this.txtObservaciones);
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
            this.btnAsignar.Location = new System.Drawing.Point(36, 252);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(75, 23);
            this.btnAsignar.TabIndex = 11;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.BackColor = System.Drawing.SystemColors.Menu;
            this.lblObservaciones.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblObservaciones.Location = new System.Drawing.Point(69, 159);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(93, 12);
            this.lblObservaciones.TabIndex = 10;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(26, 174);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(189, 72);
            this.txtObservaciones.TabIndex = 9;
            // 
            // cbTurno
            // 
            this.cbTurno.FormattingEnabled = true;
            this.cbTurno.Items.AddRange(new object[] {
            "MAÑANA",
            "TARDE",
            "NOCHE"});
            this.cbTurno.Location = new System.Drawing.Point(94, 69);
            this.cbTurno.Name = "cbTurno";
            this.cbTurno.Size = new System.Drawing.Size(121, 21);
            this.cbTurno.TabIndex = 8;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.BackColor = System.Drawing.SystemColors.Menu;
            this.lblTurno.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurno.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTurno.Location = new System.Drawing.Point(15, 73);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(44, 12);
            this.lblTurno.TabIndex = 7;
            this.lblTurno.Text = "Turno:";
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.BackColor = System.Drawing.SystemColors.Menu;
            this.lblFechaHora.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHora.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFechaHora.Location = new System.Drawing.Point(69, 105);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(85, 12);
            this.lblFechaHora.TabIndex = 6;
            this.lblFechaHora.Text = "Fecha y hora:";
            // 
            // dtpFechaAsignacion
            // 
            this.dtpFechaAsignacion.Location = new System.Drawing.Point(26, 129);
            this.dtpFechaAsignacion.Name = "dtpFechaAsignacion";
            this.dtpFechaAsignacion.Size = new System.Drawing.Size(189, 20);
            this.dtpFechaAsignacion.TabIndex = 5;
            this.dtpFechaAsignacion.ValueChanged += new System.EventHandler(this.dtpFechaAsignacion_ValueChanged);
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
            this.cbBusAsig.SelectedIndexChanged += new System.EventHandler(this.cbBusAsig_SelectedIndexChanged);
            // 
            // lblConductorAsig
            // 
            this.lblConductorAsig.AutoSize = true;
            this.lblConductorAsig.BackColor = System.Drawing.SystemColors.Menu;
            this.lblConductorAsig.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConductorAsig.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblConductorAsig.Location = new System.Drawing.Point(15, 46);
            this.lblConductorAsig.Name = "lblConductorAsig";
            this.lblConductorAsig.Size = new System.Drawing.Size(73, 12);
            this.lblConductorAsig.TabIndex = 2;
            this.lblConductorAsig.Text = "Conductor:";
            // 
            // lblBusAsig
            // 
            this.lblBusAsig.AutoSize = true;
            this.lblBusAsig.BackColor = System.Drawing.SystemColors.Menu;
            this.lblBusAsig.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusAsig.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBusAsig.Location = new System.Drawing.Point(15, 19);
            this.lblBusAsig.Name = "lblBusAsig";
            this.lblBusAsig.Size = new System.Drawing.Size(29, 12);
            this.lblBusAsig.TabIndex = 1;
            this.lblBusAsig.Text = "Bus:";
            // 
            // dgAsignaciones
            // 
            this.dgAsignaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAsignaciones.Location = new System.Drawing.Point(232, 15);
            this.dgAsignaciones.Name = "dgAsignaciones";
            this.dgAsignaciones.RowHeadersWidth = 51;
            this.dgAsignaciones.Size = new System.Drawing.Size(415, 231);
            this.dgAsignaciones.TabIndex = 0;
            this.dgAsignaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAsignaciones_CellClick);
            // 
            // tpMantenimiento
            // 
            this.tpMantenimiento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpMantenimiento.BackgroundImage")));
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
            this.tpMantenimiento.Controls.Add(this.dgMantenimiento);
            this.tpMantenimiento.Location = new System.Drawing.Point(4, 22);
            this.tpMantenimiento.Name = "tpMantenimiento";
            this.tpMantenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tpMantenimiento.Size = new System.Drawing.Size(656, 315);
            this.tpMantenimiento.TabIndex = 3;
            this.tpMantenimiento.Text = "Mantenimientos";
            this.tpMantenimiento.UseVisualStyleBackColor = true;
            this.tpMantenimiento.Click += new System.EventHandler(this.tpMantenimiento_Click);
            // 
            // btnRegistrarMantenimiento
            // 
            this.btnRegistrarMantenimiento.Location = new System.Drawing.Point(49, 272);
            this.btnRegistrarMantenimiento.Name = "btnRegistrarMantenimiento";
            this.btnRegistrarMantenimiento.Size = new System.Drawing.Size(136, 23);
            this.btnRegistrarMantenimiento.TabIndex = 11;
            this.btnRegistrarMantenimiento.Text = "Registrar Mantenimiento";
            this.btnRegistrarMantenimiento.UseVisualStyleBackColor = true;
            this.btnRegistrarMantenimiento.Click += new System.EventHandler(this.btnRegistrarMantenimiento_Click);
            // 
            // txtDescripcionMant
            // 
            this.txtDescripcionMant.Location = new System.Drawing.Point(16, 205);
            this.txtDescripcionMant.Multiline = true;
            this.txtDescripcionMant.Name = "txtDescripcionMant";
            this.txtDescripcionMant.Size = new System.Drawing.Size(200, 50);
            this.txtDescripcionMant.TabIndex = 10;
            // 
            // txtEmpresaMant
            // 
            this.txtEmpresaMant.Location = new System.Drawing.Point(16, 156);
            this.txtEmpresaMant.Name = "txtEmpresaMant";
            this.txtEmpresaMant.Size = new System.Drawing.Size(200, 20);
            this.txtEmpresaMant.TabIndex = 9;
            // 
            // txtCostoMant
            // 
            this.txtCostoMant.Location = new System.Drawing.Point(95, 64);
            this.txtCostoMant.Name = "txtCostoMant";
            this.txtCostoMant.Size = new System.Drawing.Size(121, 20);
            this.txtCostoMant.TabIndex = 8;
            // 
            // dtpMant
            // 
            this.dtpMant.Location = new System.Drawing.Point(16, 108);
            this.dtpMant.Name = "dtpMant";
            this.dtpMant.Size = new System.Drawing.Size(200, 20);
            this.dtpMant.TabIndex = 7;
            // 
            // cbBusMant
            // 
            this.cbBusMant.FormattingEnabled = true;
            this.cbBusMant.Location = new System.Drawing.Point(95, 37);
            this.cbBusMant.Name = "cbBusMant";
            this.cbBusMant.Size = new System.Drawing.Size(121, 21);
            this.cbBusMant.TabIndex = 6;
            // 
            // lblDescripciónMant
            // 
            this.lblDescripciónMant.AutoSize = true;
            this.lblDescripciónMant.BackColor = System.Drawing.SystemColors.Menu;
            this.lblDescripciónMant.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripciónMant.Location = new System.Drawing.Point(79, 189);
            this.lblDescripciónMant.Name = "lblDescripciónMant";
            this.lblDescripciónMant.Size = new System.Drawing.Size(81, 12);
            this.lblDescripciónMant.TabIndex = 5;
            this.lblDescripciónMant.Text = "Descripción:";
            // 
            // lblEmpresaMant
            // 
            this.lblEmpresaMant.AutoSize = true;
            this.lblEmpresaMant.BackColor = System.Drawing.SystemColors.Menu;
            this.lblEmpresaMant.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresaMant.Location = new System.Drawing.Point(56, 140);
            this.lblEmpresaMant.Name = "lblEmpresaMant";
            this.lblEmpresaMant.Size = new System.Drawing.Size(139, 12);
            this.lblEmpresaMant.TabIndex = 4;
            this.lblEmpresaMant.Text = "Empresa Responsable:";
            // 
            // lblCostoMant
            // 
            this.lblCostoMant.AutoSize = true;
            this.lblCostoMant.BackColor = System.Drawing.SystemColors.Menu;
            this.lblCostoMant.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoMant.Location = new System.Drawing.Point(13, 67);
            this.lblCostoMant.Name = "lblCostoMant";
            this.lblCostoMant.Size = new System.Drawing.Size(45, 12);
            this.lblCostoMant.TabIndex = 3;
            this.lblCostoMant.Text = "Costo:";
            // 
            // lblFechaMant
            // 
            this.lblFechaMant.AutoSize = true;
            this.lblFechaMant.BackColor = System.Drawing.SystemColors.Menu;
            this.lblFechaMant.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaMant.Location = new System.Drawing.Point(92, 92);
            this.lblFechaMant.Name = "lblFechaMant";
            this.lblFechaMant.Size = new System.Drawing.Size(43, 12);
            this.lblFechaMant.TabIndex = 2;
            this.lblFechaMant.Text = "Fecha:";
            // 
            // lblBusManten
            // 
            this.lblBusManten.AutoSize = true;
            this.lblBusManten.BackColor = System.Drawing.SystemColors.Menu;
            this.lblBusManten.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusManten.Location = new System.Drawing.Point(13, 40);
            this.lblBusManten.Name = "lblBusManten";
            this.lblBusManten.Size = new System.Drawing.Size(29, 12);
            this.lblBusManten.TabIndex = 1;
            this.lblBusManten.Text = "Bus:";
            // 
            // dgMantenimiento
            // 
            this.dgMantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMantenimiento.Location = new System.Drawing.Point(234, 25);
            this.dgMantenimiento.Name = "dgMantenimiento";
            this.dgMantenimiento.RowHeadersWidth = 51;
            this.dgMantenimiento.Size = new System.Drawing.Size(403, 225);
            this.dgMantenimiento.TabIndex = 0;
            // 
            // btnEditarAsig
            // 
            this.btnEditarAsig.Location = new System.Drawing.Point(130, 252);
            this.btnEditarAsig.Name = "btnEditarAsig";
            this.btnEditarAsig.Size = new System.Drawing.Size(75, 23);
            this.btnEditarAsig.TabIndex = 12;
            this.btnEditarAsig.Text = "Editar";
            this.btnEditarAsig.UseVisualStyleBackColor = true;
            this.btnEditarAsig.Click += new System.EventHandler(this.btnEditarAsig_Click);
            // 
            // btnEliminarAsig
            // 
            this.btnEliminarAsig.Location = new System.Drawing.Point(87, 281);
            this.btnEliminarAsig.Name = "btnEliminarAsig";
            this.btnEliminarAsig.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarAsig.TabIndex = 13;
            this.btnEliminarAsig.Text = "Eliminar";
            this.btnEliminarAsig.UseVisualStyleBackColor = true;
            this.btnEliminarAsig.Click += new System.EventHandler(this.btnEliminarAsig_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgMantenimiento)).EndInit();
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
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminarCond;
        private System.Windows.Forms.Button btnActualizarCond;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblLicencia;
        private System.Windows.Forms.Button btnRegistrarConductor;
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
        private System.Windows.Forms.TextBox txtObservaciones;
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
        private System.Windows.Forms.DataGridView dgMantenimiento;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAsientos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEliminarAsig;
        private System.Windows.Forms.Button btnEditarAsig;
    }
}