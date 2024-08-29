using Ejercicio1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            IFigura[] misFiguras = new IFigura[]{ 
                                           new Cuadrado(2),
                                           new Cuadrado(5),
                                            new Rectangulo(5,1)
                                               };
            foreach (IFigura fig in misFiguras)
            {
                lbxVer.Items.Add(fig);
            }
        }
    }
}
