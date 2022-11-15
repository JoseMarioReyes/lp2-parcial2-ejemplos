using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using herencia.ConHerencia;


namespace herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpleadoPorHora unEmpleadoPorHora = new EmpleadoPorHora();
            unEmpleadoPorHora.PrimerNombre = "Jose";

            //Creacion del objeto unEmpleadoPorComision, del tipo EmpleadoPorComision
            //Utilizando el constructor de la clase EmpleadoPorComision, que a su vez usa el contructor
            //de la clase padre Empleado.
            EmpleadoPorComision unEmpleadoPorComision = new EmpleadoPorComision("Jose", "Mario",
                "Reyes", "Aguilar", "080100000", "Col. Pueblo Antiguo", "98979000", 4, 0);
        }
    }
}
