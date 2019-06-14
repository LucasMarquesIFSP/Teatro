using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projTeatroWF
{
    class Lugar
    {
        private bool ocupado;
        private bool meiaEntrada;

        public bool Ocupado
        {
            get { return ocupado; }
            set { ocupado = value; }
        }

        public bool MeiaEntrada
        {
            get { return meiaEntrada; }
            set { meiaEntrada = value; }
        }

        public Lugar(bool ocupado, bool meiaEntrada)
        {
            this.ocupado = ocupado;
            this.meiaEntrada = meiaEntrada;
        }

        public Lugar()
            : this(false, false)
        { }
    }
}
