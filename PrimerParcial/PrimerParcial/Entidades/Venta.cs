using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Entidades
{
    class Venta
    {
        
        //Abstracción
        private string id_producto;
        private string nombre_producto;
        private string descripcion_producto;
        private double precio;
        private int cantidad;


        //Encapsulamiento
        public string Id_producto { get => id_producto; set => id_producto = value; }
        public string Nombre_producto { get => nombre_producto; set => nombre_producto = value; }
        public string Descripcion_producto { get => descripcion_producto; set => descripcion_producto = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        //Constructor

        public Venta() { }

        public Venta(string nombre_producto, double precio, int cantidad)
        {
            this.nombre_producto = nombre_producto;
            this.precio = precio;
            this.cantidad = cantidad;
        }
    }
}
