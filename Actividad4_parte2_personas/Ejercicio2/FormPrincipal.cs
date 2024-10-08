﻿using System;
using System.Collections;
using System.Windows.Forms;
using Ejercicio2.Models;

namespace Ejercicio2
{
    public partial class FormPrincipal : Form
    {
        ArrayList lista = new ArrayList();
        public FormPrincipal()
        {
            InitializeComponent();

            lista.Add(new Persona(4343433, "Julia"));
            lista.Add(new Persona(2343422, "Estefanía"));
        }

        private void btnVerAltaPersona_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbDNIBusqueda.Text.Trim()) == false)
            {
                int dni = Convert.ToInt32(tbDNIBusqueda.Text);

                lista.Sort();
                int idx = lista.BinarySearch(new Persona(dni));

                Persona p = null;
                if (idx < 0)
                {
                    #region si no lo encuentra , solicita al usuario crearlo
                    FormDatos fDatos = new FormDatos();
                    fDatos.tbDNI.Text = dni.ToString();

                    if (fDatos.ShowDialog() == DialogResult.OK)
                    {
                        string nombre = fDatos.tbNombre.Text;
                        p = new Persona(dni, nombre);
                        lista.Add(p);
                    }
                    #endregion
                }
                else
                {
                    #region si lo encuentra lo selecciona
                    p = lista[idx] as Persona;
                    #endregion
                }

                if (p != null)
                    tvVer.Text = p.ToString();
                else
                    tvVer.Clear();
            }
            else
            {
                tvVer.Text = "Debe ingresar un DNI!";
            }
        }
    }
}
