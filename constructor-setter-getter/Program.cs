using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace constructor_setter_getter
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona unaPersona = new Persona("Jose", "Aguilar");
            Console.WriteLine(unaPersona.getNombreCompleto());

            Console.ReadLine();
        }
    }
}
