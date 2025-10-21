using System;
using System.Collections.Generic;
using System.Diagnostics;
using Ejercicios_Semana9_DOO.Logica;

namespace Ejercicios_Semana9_DOO.UI
{
    /*Se desea además que para cada ejercicio se logre realizar una colección (lista) 
    de objetos creados por su clase padre y a su vez, 
    mostrar todos los elementos disponibles en la lista.
    Defina dentro del main métodos para:
    *  Agregar un nuevo elemento (de cualquier tipo).
    * Modificar los datos de un elemento existente.
    * Eliminar un elemento por su Id*/
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            ControlVehiculos control = new ControlVehiculos();
            vehiculos = control.CrearVehiculo(vehiculos);

            Console.WriteLine("Ingrese el vehiculo que desea leer");
            int leerId = int.Parse(Console.ReadLine());
            control.leerVehiculo(vehiculos, leerId);

            Console.WriteLine("Ingrese el Id del vehiculo que desea modificar");
            leerId = int.Parse(Console.ReadLine());
            control.modificarVehiculo(vehiculos, leerId);
            control.leerVehiculo(vehiculos, leerId);

            Console.WriteLine("Ingrese el Id del vehiculo que desea eliminar");
            leerId = int.Parse(Console.ReadLine());
            vehiculos.RemoveAt(control.EliminarVehiculo(vehiculos, leerId));

            foreach (var veh in vehiculos) 
            {
                veh.MostrarInfo();
            }

            Console.ReadKey();
        }
    }
}
