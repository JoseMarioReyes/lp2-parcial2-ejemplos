using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace herencia.ConHerencia
{
    class EmpleadoPermanente : Empleado
    {
        public decimal Sueldo { get; set; }

        public EmpleadoPermanente(string PrimerNombre,
            string SegundoNombre,
            string PrimerApellido,
            string SegundoApellido,
            string NumeroIdentificacion,
            string Direccion,
            string Telefono,
            decimal Sueldo) : base(PrimerNombre,
                PrimerApellido,
                SegundoNombre, SegundoApellido, NumeroIdentificacion,
                Direccion,
                Telefono)
        {
            if (Sueldo >= 0)
            {
                this.Sueldo = Sueldo;
            }
        }
    }
}
