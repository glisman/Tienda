using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Tienda.Entidades
{
    class DiscoDuro:Componente
    {
        private string capacidad;
        private string voltaje;

        public DiscoDuro(string marca,string modelo,double precio,string capacidad,string voltaje)
            :base(marca,modelo,precio)
        {
            this.capacidad = capacidad;
            this.voltaje = voltaje;
        }
        public string Voltaje
        {
            get { return voltaje; }
            set { voltaje = value; }
        }

        public string Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }
        public override string ToString()
        {
            return string.Format("{0} Capacidad {1} Voltaje{2}",base.ToString(),Capacidad,Voltaje);
        }
    }
}
