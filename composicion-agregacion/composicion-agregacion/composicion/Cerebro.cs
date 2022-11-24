using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace composicion_agregacion.composicion
{
    class Cerebro
    {
        public double Tamanio { get; set; }

        public Cerebro(double tamanio)
        {
            this.Tamanio = tamanio;
        }
    }
}
