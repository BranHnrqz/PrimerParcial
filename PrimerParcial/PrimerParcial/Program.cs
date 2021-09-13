using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimerParcial.Entidades;
using PrimerParcial.Negocio;

namespace PrimerParcial
{
    class Program
    {
        static void Main(string[] args)

        {
            Usuario usuario = new Usuario("Brandon","123");
            NClsUsuario nClsUsuario = new NClsUsuario();
            Console.WriteLine(nClsUsuario.Acceso(usuario));
            Console.ReadLine();


            if (nClsUsuario.confirm == 1)
            {

                Console.WriteLine("==============================================");
                Console.WriteLine("Favor Ingresa el -- 1 -- Si deseas continuar");
                Console.WriteLine("De lo Contrario, Ingresa Cualquier otro Número");
                int condicion = Convert.ToInt32(Console.ReadLine());

                if (condicion == 1)
                {
                    int contador = 1;

                    while (contador == 1)
                    {
                        Venta venta = new Venta();
                        NClsVenta nClsVenta = new NClsVenta();

                        Console.WriteLine(nClsVenta.Cobro(venta));

                        Console.WriteLine(usuario.ToString());
                        Console.WriteLine(venta.ToString());

                        Console.ReadLine();

                    }
                }
                else
                {
                    Console.WriteLine("Ha Decidido no continuar con el proceso!");
                }

            }
            else
            {
                Console.WriteLine("");
            }
        }
    }
}
