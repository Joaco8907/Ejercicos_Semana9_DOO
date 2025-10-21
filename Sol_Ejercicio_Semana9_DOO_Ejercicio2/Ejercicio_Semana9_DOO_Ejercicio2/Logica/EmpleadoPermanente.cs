using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Semana9_DOO_Ejercicio2.Logica
{
    public class EmpleadoPermanente: Empleado
    {
        private int aniosAntiguedad;

        public EmpleadoPermanente()
        {
        }

        public EmpleadoPermanente(int id, string nombre, string apellido, double sueldoBase, 
            int aniosAntiguedad) : base(id, nombre, apellido, sueldoBase)
        {
            this.AniosAntiguedad = aniosAntiguedad;
        }

        public int AniosAntiguedad { get => aniosAntiguedad; set => aniosAntiguedad = value; }

        public override void mostrarInfo()
        {
            Console.WriteLine($"Id: {this.id}, Nombre: {this.nombre}, Apellido: {this.apellido}, Antiguedad: {AniosAntiguedad} Anios, Sueldo Neto: {sueldoBase}");
        }
    }
}
