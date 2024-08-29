using System;
using System.Windows.Forms;
using System.Collections;
using Ejercicio3.Models;

namespace Ejercicio3
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

            lbResultados.Items.Add("Lista sin ordenar.");
            foreach (IFigura fig in misFiguras)
            {
                lbResultados.Items.Add(fig);
            }

            lbResultados.Items.Add("");

            misFiguras.Sort();
            lbResultados.Items.Add("Lista ordenada por área.");
            foreach (IFigura fig in misFiguras)
            {
                lbResultados.Items.Add(fig);
            }
        }
    }
}
