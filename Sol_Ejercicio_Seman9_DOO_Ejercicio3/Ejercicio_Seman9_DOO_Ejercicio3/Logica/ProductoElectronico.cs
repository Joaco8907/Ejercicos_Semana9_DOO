using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Seman9_DOO_Ejercicio3.Logica
{
    internal class ProductoElectronico : Producto
    {
        private int mesesGarantia;
        public int MesesGarantia { get => mesesGarantia; set => mesesGarantia = value; }
        public ProductoElectronico()
        {
        }

        public ProductoElectronico(int mesesGarantia)
        {
            this.mesesGarantia = mesesGarantia;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"Id: {this.id}, Nombre: {this.nombre}, Precio: {this.precioBase}, meses de garantia: {this.mesesGarantia}");
        }
    }
}
