using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Entidades
{
    class Usuario
    {
        //Abstracción.
        private string nombre;
        private string contra;

        //Encapsulamiento
        public string Nombre { get => nombre; set => nombre = value; }
        public string Contra { get => contra; set => contra = value; }

        //Constructor
        public Usuario(string nombre, string contra)
        {
            this.nombre = nombre;
            this.contra = contra;
        }

    }
}
