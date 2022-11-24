using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace composicion_agregacion.composicion
{
    class Corazon
    {
        public int CantidadLatidos { get; set; }
        public double Tamanio { get; set; }

        public Corazon(int cantidadLatidos, double Tamanio)
        {
            this.CantidadLatidos = cantidadLatidos;
            this.Tamanio = Tamanio;
        }
    }
}
