using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Semana9_DOO_Ejercicio4.Logica
{
    public class Profesor : Persona
    {
        private string materia;
        private double sueldo;

        public Profesor()
        {
        }


        public Profesor(string materia, double sueldo)
        {
            this.materia = materia;
            this.sueldo = sueldo;
        }

        public string Materia { get => materia; set => materia = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }

        public override void mostrarDatos()
        {
            Console.WriteLine("Profesor: ");
            Console.WriteLine($"ID: {this.Id}, Nombre: {this.Nombre}, Edad: {this.Edad}" +
                $", Materia: {this.materia}, Sueldo: {this.sueldo} ");
        }
    }
}
