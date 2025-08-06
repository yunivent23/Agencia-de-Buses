namespace Presentación
{
    partial class Gestión_de_Ruta_y_Viajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestión_de_Ruta_y_Viajes));
            this.tcRutaViajes = new System.Windows.Forms.TabControl();
            this.tpRuta = new System.Windows.Forms.TabPage();
            this.dgRuta = new System.Windows.Forms.DataGridView();
            this.btnSalirRuta = new System.Windows.Forms.Button();
            this.btnEliminarRuta = new System.Windows.Forms.Button();
            this.btnEditarRuta = new System.Windows.Forms.Button();
            this.btnRegistrarRuta = new System.Windows.Forms.Button();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.cbDestino = new System.Windows.Forms.ComboBox();
            this.cbOrigen = new System.Windows.Forms.ComboBox();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.tpViajes = new System.Windows.Forms.TabPage();
            this.btnEliminarViaje = new System.Windows.Forms.Button();
            this.btnEditarViaje = new System.Windows.Forms.Button();
            this.dgViajes = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cbEstadoViaje = new System.Windows.Forms.ComboBox();
            this.dtLlegada = new System.Windows.Forms.DateTimePicker();
            this.dtSalida = new System.Windows.Forms.DateTimePicker();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblLlegada = new System.Windows.Forms.Label();
            this.cbRutaViaj = new System.Windows.Forms.ComboBox();
            this.lblSalida = new System.Windows.Forms.Label();
            this.cbConductorViaj = new System.Windows.Forms.ComboBox();
            this.cbBusViaj = new System.Windows.Forms.ComboBox();
            this.lblRuta = new System.Windows.Forms.Label();
            this.lblConductor = new System.Windows.Forms.Label();
            this.lblBus = new System.Windows.Forms.Label();
            this.tcRutaViajes.SuspendLayout();
            this.tpRuta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRuta)).BeginInit();
            this.tpViajes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViajes)).BeginInit();
            this.SuspendLayout();
            // 
            // tcRutaViajes
            // 
            this.tcRutaViajes.Controls.Add(this.tpRuta);
            this.tcRutaViajes.Controls.Add(this.tpViajes);
            this.tcRutaViajes.Location = new System.Drawing.Point(2, 1);
            this.tcRutaViajes.Name = "tcRutaViajes";
            this.tcRutaViajes.SelectedIndex = 0;
            this.tcRutaViajes.Size = new System.Drawing.Size(662, 338);
            this.tcRutaViajes.TabIndex = 0;
            // 
            // tpRuta
            // 
            this.tpRuta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpRuta.BackgroundImage")));
            this.tpRuta.Controls.Add(this.dgRuta);
            this.tpRuta.Controls.Add(this.btnSalirRuta);
            this.tpRuta.Controls.Add(this.btnEliminarRuta);
            this.tpRuta.Controls.Add(this.btnEditarRuta);
            this.tpRuta.Controls.Add(this.btnRegistrarRuta);
            this.tpRuta.Controls.Add(this.lblDuracion);
            this.tpRuta.Controls.Add(this.txtDuracion);
            this.tpRuta.Controls.Add(this.txtDistancia);
            this.tpRuta.Controls.Add(this.cbDestino);
            this.tpRuta.Controls.Add(this.cbOrigen);
            this.tpRuta.Controls.Add(this.lblDistancia);
            this.tpRuta.Controls.Add(this.lblDestino);
            this.tpRuta.Controls.Add(this.lblOrigen);
            this.tpRuta.Location = new System.Drawing.Point(4, 22);
            this.tpRuta.Name = "tpRuta";
            this.tpRuta.Padding = new System.Windows.Forms.Padding(3);
            this.tpRuta.Size = new System.Drawing.Size(654, 312);
            this.tpRuta.TabIndex = 0;
            this.tpRuta.Text = "Ruta";
            this.tpRuta.UseVisualStyleBackColor = true;
            // 
            // dgRuta
            // 
            this.dgRuta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRuta.Location = new System.Drawing.Point(250, 20);
            this.dgRuta.Name = "dgRuta";
            this.dgRuta.Size = new System.Drawing.Size(394, 237);
            this.dgRuta.TabIndex = 15;
            this.dgRuta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRuta_CellClick);
            // 
            // btnSalirRuta
            // 
            this.btnSalirRuta.Location = new System.Drawing.Point(81, 254);
            this.btnSalirRuta.Name = "btnSalirRuta";
            this.btnSalirRuta.Size = new System.Drawing.Size(110, 23);
            this.btnSalirRuta.TabIndex = 14;
            this.btnSalirRuta.Text = "Salir";
            this.btnSalirRuta.UseVisualStyleBackColor = true;
            this.btnSalirRuta.Click += new System.EventHandler(this.btnSalirRuta_Click);
            // 
            // btnEliminarRuta
            // 
            this.btnEliminarRuta.Location = new System.Drawing.Point(81, 224);
            this.btnEliminarRuta.Name = "btnEliminarRuta";
            this.btnEliminarRuta.Size = new System.Drawing.Size(110, 23);
            this.btnEliminarRuta.TabIndex = 13;
            this.btnEliminarRuta.Text = "Eliminar";
            this.btnEliminarRuta.UseVisualStyleBackColor = true;
            this.btnEliminarRuta.Click += new System.EventHandler(this.btnEliminarRuta_Click);
            // 
            // btnEditarRuta
            // 
            this.btnEditarRuta.Location = new System.Drawing.Point(81, 194);
            this.btnEditarRuta.Name = "btnEditarRuta";
            this.btnEditarRuta.Size = new System.Drawing.Size(110, 23);
            this.btnEditarRuta.TabIndex = 12;
            this.btnEditarRuta.Text = "Editar ruta";
            this.btnEditarRuta.UseVisualStyleBackColor = true;
            this.btnEditarRuta.Click += new System.EventHandler(this.btnEditarRuta_Click);
            // 
            // btnRegistrarRuta
            // 
            this.btnRegistrarRuta.Location = new System.Drawing.Point(81, 164);
            this.btnRegistrarRuta.Name = "btnRegistrarRuta";
            this.btnRegistrarRuta.Size = new System.Drawing.Size(110, 23);
            this.btnRegistrarRuta.TabIndex = 11;
            this.btnRegistrarRuta.Text = "Registrar ruta";
            this.btnRegistrarRuta.UseVisualStyleBackColor = true;
            this.btnRegistrarRuta.Click += new System.EventHandler(this.btnRegistrarRuta_Click);
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.BackColor = System.Drawing.SystemColors.Menu;
            this.lblDuracion.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracion.Location = new System.Drawing.Point(22, 129);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(60, 24);
            this.lblDuracion.TabIndex = 10;
            this.lblDuracion.Text = "Duración \r\nestimada:";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(123, 129);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(121, 20);
            this.txtDuracion.TabIndex = 9;
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(123, 99);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(121, 20);
            this.txtDistancia.TabIndex = 8;
            // 
            // cbDestino
            // 
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Items.AddRange(new object[] {
            "Lima",
            "Ica",
            "Trujillo",
            "Cuzco",
            "Huaral",
            "Huancayo"});
            this.cbDestino.Location = new System.Drawing.Point(123, 70);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(121, 21);
            this.cbDestino.TabIndex = 7;
            // 
            // cbOrigen
            // 
            this.cbOrigen.FormattingEnabled = true;
            this.cbOrigen.Items.AddRange(new object[] {
            "Lima",
            "Ica",
            "Trujillo",
            "Cuzco",
            "Huaral",
            "Huancayo"});
            this.cbOrigen.Location = new System.Drawing.Point(123, 41);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.Size = new System.Drawing.Size(121, 21);
            this.cbOrigen.TabIndex = 6;
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.BackColor = System.Drawing.SystemColors.Menu;
            this.lblDistancia.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistancia.Location = new System.Drawing.Point(22, 102);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(60, 12);
            this.lblDistancia.TabIndex = 5;
            this.lblDistancia.Text = "Distancia:";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.BackColor = System.Drawing.SystemColors.Menu;
            this.lblDestino.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Location = new System.Drawing.Point(22, 73);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(51, 12);
            this.lblDestino.TabIndex = 4;
            this.lblDestino.Text = "Destino:";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.BackColor = System.Drawing.SystemColors.Menu;
            this.lblOrigen.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigen.Location = new System.Drawing.Point(22, 44);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(46, 12);
            this.lblOrigen.TabIndex = 3;
            this.lblOrigen.Text = "Origen:";
            // 
            // tpViajes
            // 
            this.tpViajes.BackColor = System.Drawing.SystemColors.Menu;
            this.tpViajes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpViajes.BackgroundImage")));
            this.tpViajes.Controls.Add(this.btnEliminarViaje);
            this.tpViajes.Controls.Add(this.btnEditarViaje);
            this.tpViajes.Controls.Add(this.dgViajes);
            this.tpViajes.Controls.Add(this.btnCancelar);
            this.tpViajes.Controls.Add(this.btnRegistrar);
            this.tpViajes.Controls.Add(this.cbEstadoViaje);
            this.tpViajes.Controls.Add(this.dtLlegada);
            this.tpViajes.Controls.Add(this.dtSalida);
            this.tpViajes.Controls.Add(this.lblEstado);
            this.tpViajes.Controls.Add(this.lblLlegada);
            this.tpViajes.Controls.Add(this.cbRutaViaj);
            this.tpViajes.Controls.Add(this.lblSalida);
            this.tpViajes.Controls.Add(this.cbConductorViaj);
            this.tpViajes.Controls.Add(this.cbBusViaj);
            this.tpViajes.Controls.Add(this.lblRuta);
            this.tpViajes.Controls.Add(this.lblConductor);
            this.tpViajes.Controls.Add(this.lblBus);
            this.tpViajes.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpViajes.Location = new System.Drawing.Point(4, 22);
            this.tpViajes.Name = "tpViajes";
            this.tpViajes.Padding = new System.Windows.Forms.Padding(3);
            this.tpViajes.Size = new System.Drawing.Size(654, 312);
            this.tpViajes.TabIndex = 1;
            this.tpViajes.Text = "Viajes";
            // 
            // btnEliminarViaje
            // 
            this.btnEliminarViaje.Location = new System.Drawing.Point(68, 276);
            this.btnEliminarViaje.Name = "btnEliminarViaje";
            this.btnEliminarViaje.Size = new System.Drawing.Size(105, 23);
            this.btnEliminarViaje.TabIndex = 24;
            this.btnEliminarViaje.Text = "Eliminar Viaje";
            this.btnEliminarViaje.UseVisualStyleBackColor = true;
            this.btnEliminarViaje.Click += new System.EventHandler(this.btnEliminarViaje_Click);
            // 
            // btnEditarViaje
            // 
            this.btnEditarViaje.Location = new System.Drawing.Point(127, 218);
            this.btnEditarViaje.Name = "btnEditarViaje";
            this.btnEditarViaje.Size = new System.Drawing.Size(75, 23);
            this.btnEditarViaje.TabIndex = 23;
            this.btnEditarViaje.Text = "Editar";
            this.btnEditarViaje.UseVisualStyleBackColor = true;
            this.btnEditarViaje.Click += new System.EventHandler(this.btnEditarViaje_Click);
            // 
            // dgViajes
            // 
            this.dgViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViajes.Location = new System.Drawing.Point(253, 17);
            this.dgViajes.Name = "dgViajes";
            this.dgViajes.Size = new System.Drawing.Size(391, 256);
            this.dgViajes.TabIndex = 22;
            this.dgViajes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViajes_CellClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(68, 247);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 23);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar Viaje";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(45, 218);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 20;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cbEstadoViaje
            // 
            this.cbEstadoViaje.FormattingEnabled = true;
            this.cbEstadoViaje.Items.AddRange(new object[] {
            "PROGRAMADO",
            "INICIADO",
            "FINALIZADO",
            "CANCELADO"});
            this.cbEstadoViaje.Location = new System.Drawing.Point(125, 178);
            this.cbEstadoViaje.Name = "cbEstadoViaje";
            this.cbEstadoViaje.Size = new System.Drawing.Size(121, 20);
            this.cbEstadoViaje.TabIndex = 19;
            // 
            // dtLlegada
            // 
            this.dtLlegada.Location = new System.Drawing.Point(125, 152);
            this.dtLlegada.Name = "dtLlegada";
            this.dtLlegada.Size = new System.Drawing.Size(121, 20);
            this.dtLlegada.TabIndex = 18;
            // 
            // dtSalida
            // 
            this.dtSalida.Location = new System.Drawing.Point(125, 124);
            this.dtSalida.Name = "dtSalida";
            this.dtSalida.Size = new System.Drawing.Size(121, 20);
            this.dtSalida.TabIndex = 17;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.SystemColors.Menu;
            this.lblEstado.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(30, 187);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(45, 12);
            this.lblEstado.TabIndex = 16;
            this.lblEstado.Text = "Estado:";
            // 
            // lblLlegada
            // 
            this.lblLlegada.AutoSize = true;
            this.lblLlegada.BackColor = System.Drawing.SystemColors.Menu;
            this.lblLlegada.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLlegada.Location = new System.Drawing.Point(30, 158);
            this.lblLlegada.Name = "lblLlegada";
            this.lblLlegada.Size = new System.Drawing.Size(50, 12);
            this.lblLlegada.TabIndex = 15;
            this.lblLlegada.Text = "Llegada:";
            // 
            // cbRutaViaj
            // 
            this.cbRutaViaj.FormattingEnabled = true;
            this.cbRutaViaj.Location = new System.Drawing.Point(125, 96);
            this.cbRutaViaj.Name = "cbRutaViaj";
            this.cbRutaViaj.Size = new System.Drawing.Size(121, 20);
            this.cbRutaViaj.TabIndex = 14;
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.BackColor = System.Drawing.SystemColors.Menu;
            this.lblSalida.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalida.Location = new System.Drawing.Point(30, 130);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(41, 12);
            this.lblSalida.TabIndex = 12;
            this.lblSalida.Text = "Salida:";
            // 
            // cbConductorViaj
            // 
            this.cbConductorViaj.FormattingEnabled = true;
            this.cbConductorViaj.Location = new System.Drawing.Point(125, 69);
            this.cbConductorViaj.Name = "cbConductorViaj";
            this.cbConductorViaj.Size = new System.Drawing.Size(121, 20);
            this.cbConductorViaj.TabIndex = 10;
            // 
            // cbBusViaj
            // 
            this.cbBusViaj.FormattingEnabled = true;
            this.cbBusViaj.Location = new System.Drawing.Point(125, 40);
            this.cbBusViaj.Name = "cbBusViaj";
            this.cbBusViaj.Size = new System.Drawing.Size(121, 20);
            this.cbBusViaj.TabIndex = 9;
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.BackColor = System.Drawing.SystemColors.Menu;
            this.lblRuta.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.Location = new System.Drawing.Point(30, 104);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(33, 12);
            this.lblRuta.TabIndex = 8;
            this.lblRuta.Text = "Ruta:";
            // 
            // lblConductor
            // 
            this.lblConductor.AutoSize = true;
            this.lblConductor.BackColor = System.Drawing.SystemColors.Menu;
            this.lblConductor.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConductor.Location = new System.Drawing.Point(30, 75);
            this.lblConductor.Name = "lblConductor";
            this.lblConductor.Size = new System.Drawing.Size(66, 12);
            this.lblConductor.TabIndex = 7;
            this.lblConductor.Text = "Conductor:";
            // 
            // lblBus
            // 
            this.lblBus.AutoSize = true;
            this.lblBus.BackColor = System.Drawing.SystemColors.Menu;
            this.lblBus.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBus.Location = new System.Drawing.Point(30, 46);
            this.lblBus.Name = "lblBus";
            this.lblBus.Size = new System.Drawing.Size(28, 12);
            this.lblBus.TabIndex = 6;
            this.lblBus.Text = "Bus:";
            // 
            // Gestión_de_Ruta_y_Viajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 340);
            this.Controls.Add(this.tcRutaViajes);
            this.Name = "Gestión_de_Ruta_y_Viajes";
            this.Text = "Gestión_de_Ruta_y_Viajes";
            this.tcRutaViajes.ResumeLayout(false);
            this.tpRuta.ResumeLayout(false);
            this.tpRuta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRuta)).EndInit();
            this.tpViajes.ResumeLayout(false);
            this.tpViajes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViajes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcRutaViajes;
        private System.Windows.Forms.TabPage tpRuta;
        private System.Windows.Forms.TabPage tpViajes;
        private System.Windows.Forms.DataGridView dgRuta;
        private System.Windows.Forms.Button btnSalirRuta;
        private System.Windows.Forms.Button btnEliminarRuta;
        private System.Windows.Forms.Button btnEditarRuta;
        private System.Windows.Forms.Button btnRegistrarRuta;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.ComboBox cbDestino;
        private System.Windows.Forms.ComboBox cbOrigen;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.DataGridView dgViajes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cbEstadoViaje;
        private System.Windows.Forms.DateTimePicker dtLlegada;
        private System.Windows.Forms.DateTimePicker dtSalida;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblLlegada;
        private System.Windows.Forms.ComboBox cbRutaViaj;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.ComboBox cbConductorViaj;
        private System.Windows.Forms.ComboBox cbBusViaj;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Label lblConductor;
        private System.Windows.Forms.Label lblBus;
        private System.Windows.Forms.Button btnEditarViaje;
        private System.Windows.Forms.Button btnEliminarViaje;
    }
}