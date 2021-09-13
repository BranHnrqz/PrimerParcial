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

            Venta venta = new Venta();
            NClsVenta nClsVenta = new NClsVenta();

            Console.WriteLine(nClsUsuario.Acceso(usuario));
            Console.WriteLine(nClsVenta.Cobro(venta));
            Console.ReadLine();
        }
    }
}
