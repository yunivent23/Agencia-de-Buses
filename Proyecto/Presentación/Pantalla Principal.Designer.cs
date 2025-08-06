namespace Presentación
{
    partial class Pantalla_Principal
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnRutaViajes = new System.Windows.Forms.Button();
            this.btnPasajerosBoletos = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gestión de Flota y Personal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRutaViajes
            // 
            this.btnRutaViajes.Location = new System.Drawing.Point(142, 86);
            this.btnRutaViajes.Name = "btnRutaViajes";
            this.btnRutaViajes.Size = new System.Drawing.Size(180, 42);
            this.btnRutaViajes.TabIndex = 1;
            this.btnRutaViajes.Text = "Gestión de Ruta y Viajes";
            this.btnRutaViajes.UseVisualStyleBackColor = true;
            this.btnRutaViajes.Click += new System.EventHandler(this.btnRutaViajes_Click);
            // 
            // btnPasajerosBoletos
            // 
            this.btnPasajerosBoletos.Location = new System.Drawing.Point(142, 134);
            this.btnPasajerosBoletos.Name = "btnPasajerosBoletos";
            this.btnPasajerosBoletos.Size = new System.Drawing.Size(180, 42);
            this.btnPasajerosBoletos.TabIndex = 2;
            this.btnPasajerosBoletos.Text = "Gestión de Pasajeros y Boletos";
            this.btnPasajerosBoletos.UseVisualStyleBackColor = true;
            // 
            // btnConsultas
            // 
            this.btnConsultas.Location = new System.Drawing.Point(142, 182);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(180, 42);
            this.btnConsultas.TabIndex = 3;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(142, 230);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(180, 42);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // Pantalla_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 311);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultas);
            this.Controls.Add(this.btnPasajerosBoletos);
            this.Controls.Add(this.btnRutaViajes);
            this.Controls.Add(this.button1);
            this.Name = "Pantalla_Principal";
            this.Text = "Pantalla_Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRutaViajes;
        private System.Windows.Forms.Button btnPasajerosBoletos;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnSalir;
    }
}