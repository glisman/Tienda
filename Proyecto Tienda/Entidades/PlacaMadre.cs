using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Tienda.Entidades
{
    class PlacaMadre:Componente
    {
        private string nombre;
        private string descripcion;
        public PlacaMadre(string marca,string modelo,double precio,string nombre,string descripcion):base(marca,modelo,precio)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

    }
}
