﻿using System;
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

            lbxVer.Items.Add("Lista sin ordenar.");
            lbxVer.Items.Add($"{"Figura",10:f2} {"Área",10:f2} {"Perímetro",10:f2}");
            foreach (IFigura fig in misFiguras)
            {
                lbxVer.Items.Add($"{fig.ToString(),10:f2} {fig.CalcularArea(),10:f2}  {fig.CalcularPerimetro(),10:f2}");
            }

            misFiguras.Sort();
            lbxVer.Items.Add(" ");
            lbxVer.Items.Add("Lista ordenada por area.");
            foreach (IFigura fig in misFiguras)
            {
                lbxVer.Items.Add($"{fig.ToString(),10:f2} {fig.CalcularArea(),10:f2}  {fig.CalcularPerimetro(),10:f2}");
            }
        }
    }
}
