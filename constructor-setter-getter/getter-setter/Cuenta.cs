using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace constructor_setter_getter.getter_setter
{
    class Cuenta
    {
        private decimal _saldo;
        public decimal Saldo
        {
            get => _saldo;
            set
            {
                if (value > 0)
                {
                    _saldo = value;
                }
            }
        }
    }
}
