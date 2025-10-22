using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Semana9_DOO_Ejercicio4.Logica
{
    internal class InstitutoEducativo
    {
        List<Persona> personas;
        private int contadorId = 1;

        public int ContadorId { get => contadorId;}

        public InstitutoEducativo()
        {
            personas = new List<Persona>();
            
        }

        public void agregarPersona()
        {
            Persona p = crearPersona();
            personas.Add(p);
            contadorId++;
        }

        public void mostrarPersonas()
        {
            foreach (var persona in personas)
            {
                persona.mostrarDatos();
                Console.WriteLine("-------------------");
            }
        }

        public void EliminarPersona( int id)
        {
            for (int i=0; i<personas.Count;i++)
            {
                if (personas[i].Id == id)
                {
                    personas.RemoveAt(i);
                    break;
                }
            }
        }

        public Persona modificarPersona( Persona p)
        {
            Console.WriteLine("Ingrese el nombre: ");
            p.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la edad: ");
            p.Edad = int.Parse(Console.ReadLine());
            if(p is Alumno)
            {
                Alumno a = (Alumno)p;
                Console.WriteLine("Ingrese el legajo: ");
                a.Legajo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el promedio: ");
                a.Promedio = Console.ReadLine();
            }
            else if (p is Profesor)
            {
                Profesor pr = (Profesor)p;
                Console.WriteLine("Ingrese la materia: ");
                pr.Materia = Console.ReadLine();
                Console.WriteLine("Ingrese el sueldo: ");
                pr.Sueldo = double.Parse(Console.ReadLine());
            }
            return p;
        }

        public Persona crearPersona()
        {
            Console.WriteLine("Ingrese el tipo de persona a crear: ");
            Console.WriteLine("1- Alumno");
            Console.WriteLine("2- Profesor");
            int tipo = int.Parse(Console.ReadLine());
            
            Persona p = null;
            if (tipo == 1)
            {
                p = new Alumno();
                modificarPersona(p);
                p.Id = contadorId;
            }
            else if (tipo == 2)
            {
                p = new Profesor();
                modificarPersona(p);
                p.Id = contadorId;
            }
            return p;
        }

        public void modificarPersona_x_id(int id) 
        {
            int reutilizarId;
            for (int i = 0; i < personas.Count; i++)
            {
                if (personas[i].Id == id)
                {
                    if (personas[i] is Alumno)
                    {
                        modificarPersona((Alumno) personas[i]);
                        reutilizarId = personas[i].Id;
                    }
                    else if (personas[i] is Profesor)
                    {

                        modificarPersona((Profesor)personas[i]);
                        reutilizarId = personas[i].Id;
                    }
                }
            }
        }

        public void mostrarPersonas_X_Tipo()
        {
            List<Alumno> alumnos = new List<Alumno>();
            List<Profesor> profesores = new List<Profesor>();
            foreach (var persona in personas)
            {
                if (persona is Alumno)
                {
                    alumnos.Add((Alumno)persona);
                }
                else if (persona is Profesor)
                {
                    profesores.Add((Profesor)persona);
                }
            }

            Console.WriteLine("Lista de alumnos: ");
            foreach (var alumno in alumnos)
            {
                alumno.mostrarDatos();
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("------------------");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Lista de profesores: ");
            foreach (var profesor in profesores)
            {
                profesor.mostrarDatos();
                Console.WriteLine("-------------------");
            }
        }
    }
}
