using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace composicion_agregacion.agregacion
{
    class SimCard
    {
        public string Numero { get; set; }
        public string NombreCompania { get; set; }

        public SimCard(string Numero, string NombreCompania)
        {
            this.Numero = Numero;
            this.NombreCompania = NombreCompania;
        }
    }
}
