using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Seman9_DOO_Ejercicio3.Logica
{
    /*Id, Nombre y PrecioBase.*/
    public abstract class Producto
    {
        protected int id;
        public int ID { get => id; set => id = value; }
        protected string nombre;
        public string Nombre { get => nombre; set => nombre = value; }
        protected double precioBase;
        public double PrecioBase { get => precioBase; set => precioBase = value; }

        public abstract void MostrarInfo();
    }
}
