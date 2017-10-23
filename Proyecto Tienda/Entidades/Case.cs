using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Tienda.Entidades
{
    class Case:Componente
    {
        private string tamaño;
        private string color;

        public Case(string marca,string modelo,double precio,string tamaño,string color)
            :base(marca,modelo,precio)
        {
            this.tamaño = tamaño;
            this.color = color;
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Tamaño
        {
            get { return tamaño; }
            set { tamaño = value; }
        }

    }
}
