﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Models
{
    public class Persona : IComparable
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }

        public Persona() { }

        public Persona(int DNI, string Nombre) {
            this.DNI = DNI;
            this.Nombre = Nombre;   
        }

        public Persona(int DNI)
        {
            this.DNI = DNI;
        }

        public int CompareTo(object obj)
        {
            Persona p=obj as Persona;
            if(p!=null )
                return DNI.CompareTo(p.DNI);
            return 1;
        }

        public override string ToString()
        {
            return $"{DNI} {Nombre}\r\n";
        }
    }
}
