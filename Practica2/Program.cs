using System;

namespace Practica2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[10];

            for(int i=0;i<nombres.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre de la persona " + (i + 1));
                //Se guarda el nombre en el arary de nombres

                nombres[i] = Console.ReadLine();


               Console.Clear();


            }

            Console.WriteLine("Presione enter para ver los nombres ingresados: ");
           
            Console.ReadLine();
          foreach(string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }
            Console.Write("Presione cualquier tecla para salir");
            Console.ReadLine();
            }

        }
    }

