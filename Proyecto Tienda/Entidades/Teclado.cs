using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Tienda.Entidades
{
    class Teclado:Componente
    {
        private string descripcion;
        public Teclado(string marca,string modelo,double precio,string descripcion)
            :base(marca,modelo,precio)
        {
            this.descripcion = descripcion;
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

    }
}
