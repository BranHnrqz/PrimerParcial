using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimerParcial.Entidades;

namespace PrimerParcial.Negocio
{
    class NClsUsuario
    {
        
        //Asignando Valores.

        public string Acceso(Usuario usuario)
        {
            Console.WriteLine("=========================");
            Console.WriteLine("Bienvenido!");
            Console.WriteLine("=========================");
            
            Console.WriteLine("Para Ingresar, porfavor Ingresa tu Nombre:");
            string Nombre = Console.ReadLine();

            Console.WriteLine("Digita tu Contraseña: ");
            string Contra = Console.ReadLine();

            if (Nombre == "" || Contra == "")
            {
                //Verificamos que se ingrese un nombre o una contraseña
                Console.WriteLine("ERROR");
                Console.WriteLine("Tienes que Ingresar un Nombre o Contraseña!");
                return null;
            }
            else if(Nombre == usuario.Nombre)
               {
                    if (Contra == usuario.Contra)
                    {
                        return "Inicio de Sesión Correcto!";
                    }
                }
            else 
            {
                return "Alguno de los datos que Ingresó NO es Válido";
            }
            return "";
        }
    }
}
