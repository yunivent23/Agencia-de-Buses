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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpRuta = new System.Windows.Forms.TabPage();
            this.tpViajes = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpRuta);
            this.tabControl1.Controls.Add(this.tpViajes);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(662, 338);
            this.tabControl1.TabIndex = 0;
            // 
            // tpRuta
            // 
            this.tpRuta.Location = new System.Drawing.Point(4, 22);
            this.tpRuta.Name = "tpRuta";
            this.tpRuta.Padding = new System.Windows.Forms.Padding(3);
            this.tpRuta.Size = new System.Drawing.Size(654, 312);
            this.tpRuta.TabIndex = 0;
            this.tpRuta.Text = "Ruta";
            this.tpRuta.UseVisualStyleBackColor = true;
            // 
            // tpViajes
            // 
            this.tpViajes.Location = new System.Drawing.Point(4, 22);
            this.tpViajes.Name = "tpViajes";
            this.tpViajes.Padding = new System.Windows.Forms.Padding(3);
            this.tpViajes.Size = new System.Drawing.Size(654, 312);
            this.tpViajes.TabIndex = 1;
            this.tpViajes.Text = "Viajes";
            this.tpViajes.UseVisualStyleBackColor = true;
            // 
            // Gestión_de_Ruta_y_Viajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 340);
            this.Controls.Add(this.tabControl1);
            this.Name = "Gestión_de_Ruta_y_Viajes";
            this.Text = "Gestión_de_Ruta_y_Viajes";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpRuta;
        private System.Windows.Forms.TabPage tpViajes;
    }
}