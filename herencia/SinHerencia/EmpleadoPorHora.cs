using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace herencia.SinHerencia
{
    class EmpleadoPorHora
    {
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string Direccion { get; set; }
        public string NumeroTelefono { get; set; }
        public decimal PrecioPorHora { get; set; }
        public decimal HorasTrabajadas { get; set; }
        public decimal calcularSueldo()
        {
            return HorasTrabajadas * PrecioPorHora;

        }





    }
}
