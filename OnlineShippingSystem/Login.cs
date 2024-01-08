using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShippingSystem
{
    internal static class Login
    {
        public static void Mostrar()
        {
            int intentos = 0;
            while(intentos < 3)
            {
                Console.WriteLine("(El sistema funciona con User1/User1");
                Console.WriteLine("\n" + "\n");
                Console.WriteLine("Ingrese su username");
                string username = Console.ReadLine();
                Console.WriteLine("Ingrese su password");
                string password = Console.ReadLine();
                if (username != "User1"|| password != "User1")
                {

                    Console.WriteLine("Login fallido, vuelva a a intentar");
                    intentos++;
                    continue;
                }
                else
                {
                    Menu.Mostrar();
                    break;
                }
            }



        }
    }
}
