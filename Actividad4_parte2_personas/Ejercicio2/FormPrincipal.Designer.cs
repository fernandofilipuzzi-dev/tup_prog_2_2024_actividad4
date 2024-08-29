namespace Ejercicio2
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbDNIBusqueda = new System.Windows.Forms.TextBox();
            this.btnVerAltaPersona = new System.Windows.Forms.Button();
            this.tvVer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbDNIBusqueda
            // 
            this.tbDNIBusqueda.Location = new System.Drawing.Point(46, 68);
            this.tbDNIBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDNIBusqueda.Name = "tbDNIBusqueda";
            this.tbDNIBusqueda.Size = new System.Drawing.Size(218, 26);
            this.tbDNIBusqueda.TabIndex = 0;
            // 
            // btnVerAltaPersona
            // 
            this.btnVerAltaPersona.Location = new System.Drawing.Point(320, 55);
            this.btnVerAltaPersona.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerAltaPersona.Name = "btnVerAltaPersona";
            this.btnVerAltaPersona.Size = new System.Drawing.Size(198, 52);
            this.btnVerAltaPersona.TabIndex = 1;
            this.btnVerAltaPersona.Text = "Ver/Alta Persona";
            this.btnVerAltaPersona.UseVisualStyleBackColor = true;
            this.btnVerAltaPersona.Click += new System.EventHandler(this.btnVerAltaPersona_Click);
            // 
            // tvVer
            // 
            this.tvVer.Location = new System.Drawing.Point(46, 145);
            this.tvVer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tvVer.Multiline = true;
            this.tvVer.Name = "tvVer";
            this.tvVer.Size = new System.Drawing.Size(508, 150);
            this.tvVer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "DNI";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 315);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tvVer);
            this.Controls.Add(this.btnVerAltaPersona);
            this.Controls.Add(this.tbDNIBusqueda);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDNIBusqueda;
        private System.Windows.Forms.Button btnVerAltaPersona;
        private System.Windows.Forms.TextBox tvVer;
        private System.Windows.Forms.Label label1;
    }
}

