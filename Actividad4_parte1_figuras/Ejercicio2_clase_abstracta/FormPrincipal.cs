using Ejercicio2.Models;
using System;

using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Figura[] misFiguras = new Figura[]{ 
                                           new Cuadrado(2),
                                           new Cuadrado(5),
                                            new Rectangulo(5,1)
                                               };
            foreach (Figura fig in misFiguras)
            {
                listBox1.Items.Add(fig);
            }
        }
    }
}
