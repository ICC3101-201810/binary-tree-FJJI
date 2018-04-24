using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido, ingrese tipo de dato a trabajar\n 1- Para string \n 2- Para int \n 3- Para Char \n 0- Para salir");
            string respuesta = Console.ReadLine();

            if (respuesta == "1")
            {
                Console.WriteLine("Ingrese string que contendra el nodo");
                string cosa = Console.ReadLine();
                Node<string> string_node = new Node<string>(cosa);
                Console.WriteLine("¿Desea agregar algun nodo a este? (s/n)");
                string r1 = Console.ReadLine().ToLower();
                while (!((r1 == "s") | (r1 == "n")))
                {
                    Console.WriteLine("opcion incorrecta");
                    Console.WriteLine("¿Desea agregar algun nodo a este? (s/n)");
                }
                while ((r1=="s")|(r1=="n"))
                {
                    Console.WriteLine("Opciones aun no implementadas");
                    break;
                }
            }
            else if (respuesta == "2")
            {
                Console.WriteLine("Ingrese int que contendra el nodo");
                string cosa = Console.ReadLine();
                while (true)
                {
                    try
                    {
                        Int32.Parse(cosa);
                        Console.WriteLine(cosa);
                        Console.WriteLine(cosa + 1);
                        // Hay error aun aca

                        break;
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e);
                        Console.WriteLine("Usted ingreso un int no valido, ingrese un correcto int");
                        Console.WriteLine("Ingrese int que contendra el nodo");
                        cosa = Console.ReadLine();
                    }
                }
                //Int32.Parse(cosa, int numero);
                //Console.WriteLine(numero);
            }
            else if (respuesta == "3")
            {
                Console.WriteLine("Opciones aun no implementadas");
            }
            else if (respuesta == "0")
            {
                Console.WriteLine("Gracias por usar el programa 'Programa Generico De Arbol Binario' \n \nPresione 'ENTER' para salir");
            }
            else
            {
                Console.WriteLine("Opcion no implementada\nEstamos Trabajando Para Usted");
            }



            Console.ReadLine();
        }
    }
}
