using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimerParcial.Entidades;

namespace PrimerParcial.Negocio
{
    class NClsVenta
    {
        public string Cobro(Venta venta)
        {
            Console.WriteLine("========================================================");
            Console.WriteLine("Porfavor, Ingresa el Nombre del Producto que Deseas Comprar:");
            string NombreProducto = Console.ReadLine();
            venta.Nombre_producto = NombreProducto;


            Console.WriteLine("Ingresa el Precio del Producto");
            double Precio = Convert.ToDouble(Console.ReadLine());
            venta.Precio = Precio;

            Console.WriteLine("Ingresa la Cantidad que Deseas Comprar de Este Producto");
            int Cantidad = Convert.ToInt32(Console.ReadLine());
            venta.Cantidad = Cantidad;

            double Total_Venta = Precio * Cantidad;



            if(Total_Venta > 50)
            {
                double Total_Final = Total_Venta * 0.20;
                Console.WriteLine("El Total de la Venta es: $" + Total_Venta);
                Console.WriteLine("Aplicamos un Descuendo del 20%!");
                Console.WriteLine("Su Total Final es: $" + Total_Final);
                Console.WriteLine("=========================");
            }
            else
            {
                Console.WriteLine("No se ha Aplicado NINGUN descuento");
                Console.WriteLine("Su Total a Pagar es: $" + Total_Venta);
            }
            return "";
        }
    }
}
