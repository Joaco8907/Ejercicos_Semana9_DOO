using Ejercicios_Semana9_DOO_Ejercicio4.Logica;

namespace Ejercicios_Semana9_DOO_Ejercicio4.UI
{
    internal class Program
    {/*Desarrolle un sistema para registrar las personas de una institución educativa.
    Cree la clase padre Persona con Id, Nombre, Edad.
    Crear las clases hijas Alumno (con Legajo y Promedio) y Profesor (con Materia y Sueldo).
    Extra:
    Listado general, diferenciando alumnos y profesores.*/
        static void Main(string[] args)
        {
            int id;
            InstitutoEducativo insti = new InstitutoEducativo();
            //Create
            insti.agregarPersona();
            insti.agregarPersona();
            insti.agregarPersona();

            //Read
            insti.mostrarPersonas();

            //Update
            Console.WriteLine("ingrese el id de la persona que desea MODIFICAR: ");
            id = int.Parse(Console.ReadLine()); 
            insti.modificarPersona_x_id(id);

            insti.mostrarPersonas();

            //Delete
            Console.WriteLine("ingrese el id de la persona que desea ELIMINAR: ");
            id = int.Parse(Console.ReadLine());
            insti.EliminarPersona(id);

            insti.mostrarPersonas_X_Tipo();
        }
    }
}