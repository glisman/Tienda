using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Tienda.Entidades
{
    class Procesador:Componente
    {
        private string  capacidad;
        private int ranura;
        public Procesador(string marca,string modelo,double precio,string capacidad,int ranura)
            :base(marca,modelo,precio)
        {
            this.capacidad = capacidad;
            this.ranura = ranura;
        }
        public int Ranura
        {
            get { return ranura; }
            set { ranura = value; }
        }

        public string  Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }

    }
}
