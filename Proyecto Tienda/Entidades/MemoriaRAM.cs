using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Tienda.Entidades
{
    class MemoriaRAM:Componente
    {
        private string capacidad;
        private int ranuras;
        public MemoriaRAM(string marca,string modelo,double precio,string capacidad,int ranura):
            base(marca,modelo,precio)
        {
            this.capacidad = capacidad;
            this.ranuras = ranura;
        }
        public int Ranuras
        {
            get { return ranuras; }
            set { ranuras = value; }
        }

        public string Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }

    }
}
