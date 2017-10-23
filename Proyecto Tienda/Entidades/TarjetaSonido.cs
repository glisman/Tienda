using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Tienda.Entidades
{
    class TarjetaSonido:Componente
    {
        private int nroConector;
        public TarjetaSonido(string marca,string modelo,double precio,int nroConector)
            :base(marca,modelo,precio)
        {
            this.nroConector = nroConector;
        }
        public int NroConector
        {
            get { return nroConector; }
            set { nroConector = value; }
        }

    }
}
