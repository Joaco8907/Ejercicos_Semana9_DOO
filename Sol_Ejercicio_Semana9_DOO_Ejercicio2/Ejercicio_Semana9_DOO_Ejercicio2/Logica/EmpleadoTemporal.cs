using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Semana9_DOO_Ejercicio2.Logica
{
    public class EmpleadoTemporal : Empleado
    {
        public EmpleadoTemporal()
        {
        }

        public EmpleadoTemporal(int id, string nombre, string apellido, double sueldoBase) 
            : base(id, nombre, apellido, sueldoBase)
        {
        }

        public override void mostrarInfo()
        {
            Console.WriteLine($"ID: {this.ID}, Nombre: {this.nombre}, Apellido: {this.apellido}, Sueldo: {this.sueldoBase}");
        }
    }
}
