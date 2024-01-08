using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShippingSystem
{
    internal static class Sender
    {
        public static void Enviar()
        {
            Console.WriteLine("Ingrese el remitente");
            string remitente = Console.ReadLine();
            Console.WriteLine("Ingrese el destinatario");
            string destinatario = Console.ReadLine();
            Console.WriteLine("Ingrese dirección del destinatario");
            string direccion = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Ingerse peso del paquete en kilos");
                string peso = Console.ReadLine();

                if (!Decimal.TryParse(peso, out decimal valor))
                {
                    Console.WriteLine("Debe ingresar un valor numerico");
                    continue;
                }
                else
                {
                    decimal costo = valor * 2;
                    Random rnd = new Random();
                    int operacion = rnd.Next(1, 1000000);

                    Console.Clear();
                    Console.WriteLine("Los datos de su paquete son:");
                    Console.WriteLine("Remitente: " + remitente);
                    Console.WriteLine("Destinatario: " + destinatario);
                    Console.WriteLine("Dirección del destinatario: " + direccion);
                    Console.WriteLine("Costo del envio: " + costo.ToString() +  " pesos");
                    Console.WriteLine("Identificación del envío: " + operacion.ToString());
                    break;
                }
            }
   
        }
    }
}
