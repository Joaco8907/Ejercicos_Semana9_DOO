using Ejercicio_Semana9_DOO_Ejercicio2.Logica;

namespace Ejercicio_Semana9_DOO_Ejercicio2.UI
{
    /*Implemente una aplicación para gestionar empleados de una empresa.
    Cree una clase Empleado con Id, Nombre, Apellido y SueldoBase.
    Genere las clases hijas EmpleadoPermanente y EmpleadoTemporal, que redefinan el método
    CalcularSueldo() según su modalidad. Un ejemplo podría ser que el empleado permanente tiene un
    extra de antigüedad. */
    public class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>();
            Empresa empresa = new Empresa();
            int idControl;
            // crear empleados
            empresa.AgregarEmpleado();
            Console.WriteLine("--------------");
            empresa.AgregarEmpleado();

            // leer empleados
            Console.WriteLine("----------------");
            empresa.MostrarEmpleados();

            //modificar empleado
            Console.WriteLine("Ingrese el ID del empleado que desea modificar");
            idControl = int.Parse(Console.ReadLine());
            empresa.ModificarEmpleado(1);
            Console.WriteLine("----------------");
            empresa.MostrarEmpleados();

            //Eliminar emmpleado
            Console.WriteLine("Ingrese el ID del empleado que desea eliminar");
            idControl = int.Parse(Console.ReadLine());
            empresa.EliminarEmpleado(2);
            Console.WriteLine("----------------");
            empresa.MostrarEmpleados();

            Console.ReadKey();
        }
    }
}
