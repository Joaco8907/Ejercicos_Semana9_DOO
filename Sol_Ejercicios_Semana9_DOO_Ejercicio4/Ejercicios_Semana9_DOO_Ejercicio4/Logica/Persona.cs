using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Semana9_DOO_Ejercicio4.Logica
{
    public abstract class Persona
    {
        protected int id;
        protected string nombre;
        protected int edad;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }

        public abstract void mostrarDatos();
    }
}
