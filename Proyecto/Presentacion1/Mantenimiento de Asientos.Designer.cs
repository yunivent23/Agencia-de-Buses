namespace Presentacion1
{
    partial class Mantenimiento_de_Asientos
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
            this.panelAsientos = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.txtNumAsiento = new System.Windows.Forms.TextBox();
            this.lblElegirTipo = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelAsientos
            // 
            this.panelAsientos.AutoScroll = true;
            this.panelAsientos.Location = new System.Drawing.Point(307, 21);
            this.panelAsientos.Name = "panelAsientos";
            this.panelAsientos.Size = new System.Drawing.Size(226, 259);
            this.panelAsientos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Asientos disponibles:";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(176, 77);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(0, 13);
            this.lblCapacidad.TabIndex = 2;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(130, 182);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(75, 23);
            this.btnAsignar.TabIndex = 3;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // txtNumAsiento
            // 
            this.txtNumAsiento.Location = new System.Drawing.Point(118, 146);
            this.txtNumAsiento.Name = "txtNumAsiento";
            this.txtNumAsiento.Size = new System.Drawing.Size(100, 20);
            this.txtNumAsiento.TabIndex = 4;
            // 
            // lblElegirTipo
            // 
            this.lblElegirTipo.AutoSize = true;
            this.lblElegirTipo.Location = new System.Drawing.Point(57, 113);
            this.lblElegirTipo.Name = "lblElegirTipo";
            this.lblElegirTipo.Size = new System.Drawing.Size(172, 13);
            this.lblElegirTipo.TabIndex = 5;
            this.lblElegirTipo.Text = "Asignación de asiento preferencial:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(130, 222);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(458, 286);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(75, 23);
            this.btnRefrescar.TabIndex = 7;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // Mantenimiento_de_Asientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 322);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblElegirTipo);
            this.Controls.Add(this.txtNumAsiento);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelAsientos);
            this.Name = "Mantenimiento_de_Asientos";
            this.Text = "Mantenimiento_de_Asientos";
            this.Load += new System.EventHandler(this.Mantenimiento_de_Asientos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAsientos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.TextBox txtNumAsiento;
        private System.Windows.Forms.Label lblElegirTipo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRefrescar;
    }
}