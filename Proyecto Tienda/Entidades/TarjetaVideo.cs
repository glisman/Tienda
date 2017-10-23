using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Tienda.Entidades
{
    class TarjetaVideo:Componente
    {
        private int ranura;
        private int nroPixeles;

        public TarjetaVideo(string marca,string modelo,double precio , int ranura,int nroPixeles )
            :base(marca,modelo,precio)
        {
            this.ranura = ranura;
            this.nroPixeles = nroPixeles;
        }
        public int NroPixeles
        {
            get { return nroPixeles; }
            set { nroPixeles = value; }
        }

        public int Ranura
        {
            get { return ranura; }
            set { ranura = value; }
        }

    }
}
