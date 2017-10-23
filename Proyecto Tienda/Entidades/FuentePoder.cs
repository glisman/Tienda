using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Tienda.Entidades
{
    class FuentePoder:Componente
    {
        private string  voltaje;
        public FuentePoder(string marca,string modelo,double precio,string voltaje)
            :base(marca,modelo,precio)
        {
            this.voltaje = voltaje;
        }
        public string  Voltaje
        {
            get { return voltaje; }
            set { voltaje = value; }
        }

    }
}
