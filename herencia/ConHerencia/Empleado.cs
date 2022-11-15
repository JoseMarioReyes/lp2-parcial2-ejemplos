using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace herencia.ConHerencia
{
    class Empleado
    {
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string Direccion { get; set; }
        public string NumeroTelefono { get; set; }

        public Empleado(string PrimerNombre, string SegundoNombre,
            string PrimerApellido, string SegundoApellido,
            string NumeroIdentificacion, string Direccion,
            string NumeroTelefono)
        {
            this.PrimerNombre = PrimerNombre;
            this.SegundoNombre = SegundoNombre;
            this.PrimerApellido = PrimerApellido;
            this.SegundoApellido = SegundoApellido;
            this.NumeroIdentificacion = NumeroIdentificacion;
            this.Direccion = Direccion;
            this.NumeroTelefono = NumeroTelefono;
        }

    }
}
