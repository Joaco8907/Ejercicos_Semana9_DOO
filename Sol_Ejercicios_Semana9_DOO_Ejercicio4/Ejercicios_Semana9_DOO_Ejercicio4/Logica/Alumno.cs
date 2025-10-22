using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Semana9_DOO_Ejercicio4.Logica
{
    public class Alumno : Persona
    {
        private int legajo;
        private string promedio;

        public Alumno()
        {
        }

        public Alumno(int legajo, string promedio)
        {
            this.legajo = legajo;
            this.promedio = promedio;
        }

        public int Legajo { get => legajo; set => legajo = value; }
        public string Promedio { get => promedio; set => promedio = value; }

        public override void mostrarDatos()
        {
            Console.WriteLine("Alumno: ");
            Console.WriteLine($"ID: {this.Id}, Nombre: {this.Nombre},Edad: {this.Edad}" +
                $", Legajo: {this.legajo}, Promedio: {this.promedio} ");
        }
    }
}
