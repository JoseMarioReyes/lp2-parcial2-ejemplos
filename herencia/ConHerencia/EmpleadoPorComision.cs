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
    }
}
