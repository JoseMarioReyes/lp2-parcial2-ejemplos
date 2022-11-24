using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace composicion_agregacion.composicion
{
    class Persona
    {
        public Cerebro cerebro { get; set; }
        public Corazon corazon { get; set; }

        public Persona()
        {
            this.cerebro = new Cerebro(45);
            this.corazon = new Corazon(60, 10);
        }
    }
}
