using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShippingSystem
{
    internal static class Menu
    {
        public static void Mostrar()
        {   
            while (true)
            {
                Console.Clear();
                Console.WriteLine("¿Que desea hacer?" + "\n");
                Console.WriteLine("1-Enviar un paquete");
                Console.WriteLine("2-salir del sistema");

                string respuesta = Console.ReadLine();

                if (!int.TryParse(respuesta, out int rsp))
                {
                    Console.WriteLine("Igrese un numero entero");
                    continue;
                }
                else if (rsp < 1 || rsp > 2)
                {
                    Console.WriteLine("Igrese 1 o 2");
                    continue;
                }
                else
                {
                    if (rsp == 1)
                    {
                        Sender.Enviar();
                        bool quehacer = Preguntar();
                        if( quehacer )
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                        

                    }
                    else
                    {
                        break;
                    }
                }
            }


        }

        public static bool Preguntar()
        {
            while(true)
            {
                Console.WriteLine("¿Desea Realizar otra operación (y/n)?");
                string rsp = Console.ReadLine();
                if (rsp != "y" && rsp != "n")
                {
                    Console.WriteLine("Ingrese y/n ");
                }
                else if (rsp  == "n")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

    }
}
