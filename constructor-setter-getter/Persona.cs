using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace constructor_setter_getter
{
    class Persona
    {
        private string PrimerNombre;
        private string SegundoNombre;
        private string PrimerApellido;
        private string SegundoApellido;

        public Persona()
        { }

        public Persona(string PrimerNombre, string PrimerApellido)
        {
            this.PrimerNombre = PrimerNombre;
            this.PrimerApellido = PrimerApellido;
        }

        public Persona(string PrimerNombre,
            string PrimerApellido,
            string SegundoNombre,
            string SegundoApellido)
        {
            this.PrimerNombre = PrimerNombre;
            this.PrimerApellido = PrimerApellido;
            this.SegundoNombre = SegundoNombre;
            this.SegundoApellido = SegundoApellido;
        }

        public void setPrimerNombre(string PrimerNombre)
        {
            this.PrimerNombre = PrimerNombre;
        }

        public string getPrimerNombre()
        {
            return this.PrimerNombre;
        }

        public string getNombreCompleto()
        {
            return $"{PrimerNombre} {SegundoNombre} {PrimerApellido} {SegundoApellido}";
        }
    }
}
