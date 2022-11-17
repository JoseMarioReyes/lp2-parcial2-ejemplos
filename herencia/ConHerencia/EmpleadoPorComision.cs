using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace herencia.ConHerencia
{
    class EmpleadoPorComision : Empleado
    {
        public decimal PorcentajeDeComision { get; set; }
        public decimal TotalVentas { get; set; }

        public EmpleadoPorComision(string PrimerNombre,
            string SegundoNombre,
            string PrimerApellido,
            string SegundoApellido,
            string NumeroIdentificacion,
            string Direccion,
            string NumeroTelefono,
            decimal PorcentajeComision,
            decimal TotalVentas
            ) : base(
                PrimerNombre,
                SegundoNombre,
                PrimerApellido,
                SegundoApellido,
                NumeroIdentificacion,
                Direccion,
                NumeroTelefono
                )
        {
            if (PorcentajeComision >= 0 && TotalVentas >= 0)
            {
                this.PorcentajeDeComision = PorcentajeDeComision;
                this.TotalVentas = TotalVentas;
            }
            else
            {
                this.PorcentajeDeComision = 0;
                this.TotalVentas = 0;
            }

        }

        //Implementacion de el metodo abstracto de la clase padre Empleado, usando la 
        //palabra reservada override, para sobreescribirlo.
        public override decimal calcularSueldo()
        {
            return TotalVentas * PorcentajeDeComision;
        }
    }
}
