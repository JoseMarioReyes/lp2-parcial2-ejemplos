using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using constructor_setter_getter.getter_setter;

namespace constructor_setter_getter
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta miCuenta = new Cuenta();
            miCuenta.Saldo = 9000;
            Console.WriteLine(miCuenta.Saldo);
            Console.ReadLine();
        }
    }
}
