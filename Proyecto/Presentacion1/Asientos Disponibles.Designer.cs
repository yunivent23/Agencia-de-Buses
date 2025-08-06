namespace Presentacion1
{
    partial class Asientos_Disponibles
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnLimpiarSelección = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelAsientos
            // 
            this.panelAsientos.Location = new System.Drawing.Point(77, 45);
            this.panelAsientos.Name = "panelAsientos";
            this.panelAsientos.Size = new System.Drawing.Size(356, 383);
            this.panelAsientos.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTitulo.Location = new System.Drawing.Point(164, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(185, 24);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Asientos Disponibles";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(305, 435);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(128, 29);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Confirmar Selección";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnLimpiarSelección
            // 
            this.btnLimpiarSelección.Location = new System.Drawing.Point(77, 435);
            this.btnLimpiarSelección.Name = "btnLimpiarSelección";
            this.btnLimpiarSelección.Size = new System.Drawing.Size(116, 29);
            this.btnLimpiarSelección.TabIndex = 3;
            this.btnLimpiarSelección.Text = "Limpiar selección";
            this.btnLimpiarSelección.UseVisualStyleBackColor = true;
            this.btnLimpiarSelección.Click += new System.EventHandler(this.btnLimpiarSelección_Click);
            // 
            // Asientos_Disponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 476);
            this.Controls.Add(this.btnLimpiarSelección);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelAsientos);
            this.Name = "Asientos_Disponibles";
            this.Text = "Asientos_Disponibles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAsientos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnLimpiarSelección;
    }
}