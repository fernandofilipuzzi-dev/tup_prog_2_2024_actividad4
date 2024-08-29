using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Models;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        ArrayList lista = new ArrayList();

   
        public Form1()
        {
            InitializeComponent();

            lista.Add(new Persona(2343433, "Ruben"));
            lista.Add(new Persona(2343422, "Mirta"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(textBox1.Text);

            lista.Sort();
            int idx = lista.BinarySearch(new Persona(dni));

            Persona p = null;
            if (idx < 0)
            {
                FormDatos fDatos = new FormDatos();
                fDatos.tbDNI.Text = dni.ToString();

                if (fDatos.ShowDialog() == DialogResult.OK)
                {
                    string nombre = fDatos.tbNombre.Text;
                    p = new Persona(dni, nombre);
                    lista.Add(p);
                }
            }else
            {
                p = lista[idx] as Persona;
            }

            textBox2.Text = p.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
