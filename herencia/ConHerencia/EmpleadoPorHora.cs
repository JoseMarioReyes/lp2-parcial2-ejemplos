using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace herencia.ConHerencia
{
    class EmpleadoPorHora : Empleado
    {
        public decimal HorasTrabajadas { get; set; }
        public decimal PrecioPorHora { get; set; }

        public EmpleadoPorHora(
            string PrimerNombre,
            string SegundoNombre,
            string PrimerApellido,
            string SegundoApellido,
            string NumeroIdentificacion,
            string Direccion,
            string NumeroTelefono,
            decimal HorasTrabajadas,
            decimal PrecioPorHora
            ) : base(PrimerNombre, SegundoNombre,
                PrimerApellido, SegundoApellido, NumeroIdentificacion, Direccion, NumeroTelefono)
        {
            if (HorasTrabajadas >= 0 && PrecioPorHora >= 0)
            {

            }
        }

        //Implementacion de el metodo abstracto de la clase padre Empleado, usando la 
        //palabra reservada override, para sobreescribirlo.
        public override decimal calcularSueldo()
        {
            return HorasTrabajadas * PrecioPorHora;
        }
    }
}
