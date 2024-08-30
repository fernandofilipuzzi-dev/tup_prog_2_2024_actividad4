namespace Ejercicio2
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPrueba = new System.Windows.Forms.Button();
            this.lbxVer = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnPrueba
            // 
            this.btnPrueba.Location = new System.Drawing.Point(355, 101);
            this.btnPrueba.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(112, 35);
            this.btnPrueba.TabIndex = 0;
            this.btnPrueba.Text = "Prueba";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbxVer
            // 
            this.lbxVer.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxVer.FormattingEnabled = true;
            this.lbxVer.ItemHeight = 18;
            this.lbxVer.Location = new System.Drawing.Point(13, 14);
            this.lbxVer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbxVer.Name = "lbxVer";
            this.lbxVer.Size = new System.Drawing.Size(317, 238);
            this.lbxVer.TabIndex = 1;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 257);
            this.Controls.Add(this.lbxVer);
            this.Controls.Add(this.btnPrueba);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.Text = "Ejercico 2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrueba;
        private System.Windows.Forms.ListBox lbxVer;
    }
}

