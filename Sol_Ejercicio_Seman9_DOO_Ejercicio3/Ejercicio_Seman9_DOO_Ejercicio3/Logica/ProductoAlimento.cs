using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Seman9_DOO_Ejercicio3.Logica
{
    internal class ProductoAlimento : Producto
    {
        private DateTime fechaVencimiento;

        public ProductoAlimento()
        {
        }

        public ProductoAlimento(DateTime fechaVencimiento)
        {
            this.fechaVencimiento = fechaVencimiento;
        }

        public DateTime FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }


        public override void MostrarInfo()
        {
            Console.WriteLine($"Id: {this.id}, Nombre: {this.nombre}, Precio: {this.precioBase}, fecha de vencimineto: {fechaVencimiento}");
        }
    }
}