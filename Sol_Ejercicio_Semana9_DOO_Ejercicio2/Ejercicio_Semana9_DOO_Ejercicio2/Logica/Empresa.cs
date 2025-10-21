using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Semana9_DOO_Ejercicio2.Logica
{
    public class Empresa
    {
        private List<Empleado> empleados;
        private int count=1;
        public Empresa()
        {
            empleados = new List<Empleado>();
        }

        //Add
        public void AgregarEmpleado() 
        { 
            empleados.Add(CrearEmpleado());
        }


        //Read
        public void MostrarEmpleados()
        {
            foreach (var empleado in empleados)
            {
                empleado.mostrarInfo();
            }
        }

        //Create
        public Empleado CrearEmpleado()
        {

            Console.WriteLine("Eliga el tipo de empleado a crear: ");
            Console.WriteLine("1- empleado temporal");
            Console.WriteLine("2- empleado permanente");
            int tipoEmpleado = int.Parse(Console.ReadLine());

            if (tipoEmpleado == 1)
            {
                Empleado e = new EmpleadoTemporal();

                e.ID = count;
                Console.WriteLine("Ingrese Nombre: ");
                e.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese Apellido: ");
                e.Apellido = Console.ReadLine();
                Console.WriteLine("Ingrese Sueldo Base: ");
                e.SueldoBase = Double.Parse(Console.ReadLine());
                count++;
                return e;
            }
            else
            {
                Empleado e = new EmpleadoPermanente();
                e.ID = count;
                Console.WriteLine("Ingrese Nombre: ");
                e.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese Apellido: ");
                e.Apellido = Console.ReadLine();
                Console.WriteLine("Ingrese Sueldo Base: ");
                e.SueldoBase = Double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese Años de Antiguedad: ");
                ((EmpleadoPermanente)e).AniosAntiguedad = int.Parse(Console.ReadLine());
                ((EmpleadoPermanente)e).SueldoBase = e.SueldoBase + (e.SueldoBase * 0.1 * ((EmpleadoPermanente)e).AniosAntiguedad);
                count++;
                return e;
            }
        }

        //Update
        public void ModificarEmpleado(int id)
        {
            foreach (var empleado in empleados)
            {
                
                if (empleado.ID == id)
                {
                    Console.WriteLine("Ingrese nuevo Nombre: ");
                    empleado.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese nuevo Apellido: ");
                    empleado.Apellido = Console.ReadLine();
                    Console.WriteLine("Ingrese nuevo Sueldo Base: ");
                    empleado.SueldoBase = double.Parse(Console.ReadLine());
                    if (empleado is EmpleadoPermanente p)
                    {
                        Console.WriteLine("Ingrese Años de Antiguedad: ");
                        ((EmpleadoPermanente)p).AniosAntiguedad = int.Parse(Console.ReadLine());
                        p.SueldoBase = p.SueldoBase + (p.SueldoBase * 0.1 * p.AniosAntiguedad);
                    }
                }
            }
        }

        //Delete
        public void EliminarEmpleado(int id) 
        {
            int indiceRemover=0;
            foreach (var x in empleados)
            {
                if (x.ID == id)
                {
                    indiceRemover = empleados.IndexOf(x);
                    Console.WriteLine("Empleado removido");
                    break;
                }
                else 
                {
                    Console.WriteLine("No se encontro el empleado ");
                    indiceRemover = empleados.Count;
                }
            }
            empleados.RemoveAt(indiceRemover);
        }
    }
}
