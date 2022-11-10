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
    }
}
