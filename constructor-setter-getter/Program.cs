using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using constructor_setter_getter.getter_setter;
using constructor_setter_getter.getter_setter.properties_autoimplemented;

namespace constructor_setter_getter
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta miCuenta = new Cuenta();
            miCuenta.Saldo = 9000;
            Console.WriteLine(miCuenta.Saldo);

            PersonaAutoImplentedProperties unaPersona = new PersonaAutoImplentedProperties();
            unaPersona.PrimerNombre = "Jose";
            unaPersona.SegundoNombre = "Mario";
            unaPersona.PrimerApellido = "Reyes";
            unaPersona.SegundoApellido = "Aguilar";

            Console.ReadLine();
        }
    }
}
