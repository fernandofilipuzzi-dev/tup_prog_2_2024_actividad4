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
using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            #region casos de prueba
            ArrayList lista = new ArrayList();

            lista.Add(new Persona(4343433, "Julia"));
            lista.Add(new Persona(2343422, "Estefanía"));
            lista.Add(new Persona(32443433, "Rebeca"));
            lista.Add(new Persona(31343433, "Eduardo"));
            lista.Add(new Persona(10643433, "Lucia"));
            lista.Add(new Persona(40643433, "Reinaldo"));
            #endregion

            #region listado desordenado
            tbVer.Text += $"\r\nLista desordenada\r\n";
            foreach (Persona p in lista)
            {
                tbVer.Text += $"{p}";
            }
            #endregion region

            #region probando ordenar
            lista.Sort();
            tbVer.Text += $"\r\nLista ordenada\r\n";
            foreach (Persona p in lista)
            {
                tbVer.Text += $"{p}";
            }
            #endregion 

            #region probando la búsqueda - caso 1
            int dni1 = 32443433;
            tbVer.Text += $"\r\nBuscando: {dni1}\r\n";
            int idx1 = lista.BinarySearch(new Persona(dni1));
            if (idx1 >= 0)
            {
                Persona p = lista[idx1] as Persona;
                tbVer.Text += $"{p}";
            }
            else
            {
                tbVer.Text += "No encontrado";
            }
            #endregion

            #region probando la búsqueda - caso 2
            int dni2 = 32447433;
            tbVer.Text += $"\r\nBuscando: {dni2}\r\n";
            int idx2 = lista.BinarySearch(new Persona(dni2));
            if (idx2 >= 0)
            {
                Persona p = lista[idx2] as Persona;
                tbVer.Text += $"{p}";
            }
            else
            {
                tbVer.Text += "No encontrado";
            }
            #endregion
        }
    }
}
