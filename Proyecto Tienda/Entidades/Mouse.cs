using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Tienda.Entidades
{
    class Mouse:Componente
    {
        private string  color;
        public Mouse( string marca,string modelo,double precio,string color)
            :base(marca,modelo,precio)
        {
            this.color = color;
        }
        public string  Color
        {
            get { return color; }
            set { color = value; }
        }

    }
}
