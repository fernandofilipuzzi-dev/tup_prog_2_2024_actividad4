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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList lista = new ArrayList();

            lista.Add(new Persona(2343433, "Ruben"));
            lista.Add(new Persona(2343422, "Mirta"));
            lista.Add(new Persona(2443433, "Rebeca"));
            lista.Add(new Persona(1343433, "Tato"));

            textBox1.Text += $"lista desordenada";
            foreach (Persona p in lista)
            {
                textBox1.Text += $"{p}";
            }

            lista.Sort();
            textBox1.Text += $"\r\nlista ordenada\r\n";
            foreach (Persona p in lista)
            {
                textBox1.Text += $"{p}";
            }

            textBox1.Text += $"buscar\r\n";
            int idx = lista.BinarySearch(new Persona(2443433));
            if (idx >= 0)
            {
                Persona p = lista[idx] as Persona;
                textBox1.Text += $"{p}";
            }
            else
            { 
            }
        }
    }
}
