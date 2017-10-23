using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Tienda.Entidades
{
    class Componente
    {
        private string marca;
        private string modelo;
        private double precio;
        public Componente( string marca,string modelo,double precio)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.precio = precio;
        }
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public override string ToString()
        {
            return string.Format("Marca{0}\n Modelo{1} \nPrecio{2}",Marca,Modelo,Precio);
        }
    }
}
