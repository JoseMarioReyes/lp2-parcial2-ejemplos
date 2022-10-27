using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace constructor_setter_getter
{
    class PersonaV2
    {
        private string _PrimerNombre;
        private string _SegundoNombre;
        private string _PrimerApellido;
        private string _SegundoApellido;

        public string PrimerNombre
        {
            get => _PrimerNombre;
            set
            {
                if (value != String.Empty)
                {
                    _PrimerNombre = value;
                }
            }
        }

    }
}
