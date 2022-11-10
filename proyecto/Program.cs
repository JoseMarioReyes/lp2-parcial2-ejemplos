using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 16;

            string[] amigos = new string[10];

            for (int i = 0; i < amigos.Length; i++)
            {
                Console.WriteLine("Mi amigo número {0} es {1}",i, amigos[i]);
                Console.WriteLine($"Otra forma: Mi amigo número {i} es {amigos[i]}");
            }

            Console.WriteLine("Con foreach");
            foreach ( string _amigo in amigos)
            {
                Console.WriteLine("Mi amigo es {0}", _amigo);
            }

            Console.WriteLine("a : {0} b : {1}", a, b);
            Console.WriteLine("Favor ingrese el dato a...");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("a : {0} b : {1}", a, b);
            Console.ReadLine();
        }
    }
}



