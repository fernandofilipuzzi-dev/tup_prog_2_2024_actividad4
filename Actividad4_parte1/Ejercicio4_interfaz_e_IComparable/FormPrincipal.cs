using System;
using System.Windows.Forms;
using System.Collections;
using Ejercicio4.Models;

namespace Ejercicio4
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            ArrayList misFiguras =new ArrayList();
            misFiguras.AddRange( new IFigura[]{
                           new Circulo(8), new Circulo(3), new Circulo(4),
                           new Rectangulo(30,10), new Rectangulo(4,8), new Rectangulo(12,10),
                           new Cuadrado(5), new Cuadrado(4), new Cuadrado(12)
                               });

            lbResultados.Items.Add("lista sin ordenar.");
            foreach (IFigura fig in misFiguras)
            {
                lbResultados.Items.Add("   "+fig.ToString() + " " +
                                            fig.CalcularArea().ToString("0.00"));
            }

            misFiguras.Sort();
            lbResultados.Items.Add("lista ordenada por area.");
            foreach (IFigura fig in misFiguras)
            {
                lbResultados.Items.Add("   "+fig.ToString() + ": " +
                                        fig.CalcularArea().ToString("0.00"));
            }
        }
    }
}
