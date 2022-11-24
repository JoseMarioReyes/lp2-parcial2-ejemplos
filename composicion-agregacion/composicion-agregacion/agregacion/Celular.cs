using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace composicion_agregacion.agregacion
{
    class Celular
    {
        public SimCard Simcard { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Celular(string Marca, string Modelo)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
        }

        public Celular(string Marca, string Modelo, SimCard simcard)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Simcard = simcard;
        }

        public void InsertarSimcard(SimCard simcard)
        {
            this.Simcard = simcard;
        }

    }
}
