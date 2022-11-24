using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using composicion_agregacion.composicion;
using composicion_agregacion.agregacion;

namespace composicion_agregacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona unAdulto = new Persona();
            Persona unInfante = new Persona();

            SimCard simcardTigo = new SimCard("98999011", "TIGO");
            SimCard simcardClaro = new SimCard("38999340", "CLARO");

            Celular SamsungA20 = new Celular("Samsung", "A20");
            SamsungA20.InsertarSimcard(simcardTigo);

            Celular iphone = new Celular("Apple", "13 pro max", simcardClaro);

            Console.ReadLine();
        }
    }
}
