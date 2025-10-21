using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*n Id, Nombre, Apellido y SueldoBase*/
namespace Ejercicio_Semana9_DOO_Ejercicio2.Logica
{
    public abstract class Empleado
    {
        protected int id;
        protected string nombre;
        protected string apellido;
        protected Double sueldoBase;

        protected Empleado()
        {
        }

        protected Empleado(int id, string nombre, string apellido, Double sueldoBase)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.sueldoBase = sueldoBase;
        }

        public int ID { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public Double SueldoBase { get => sueldoBase; set => sueldoBase = value; }

        public abstract void mostrarInfo();

    }
}
