using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Semana9_DOO.Logica
{
    public class ControlVehiculos
    {

        private int contadorId=1;
        private int opcion;
        
        //Create Crear un nuevo vehiculo.
        public List<Vehiculo> CrearVehiculo(List<Vehiculo> vehiculos)
        {
            string nuevo = "s";

            while (nuevo != "n")
            { 
            Console.WriteLine("Eliga una opcion:");
            Console.WriteLine("1- Auto");
            Console.WriteLine("2- Moto");
            Console.WriteLine("3- Camion");
            opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Auto auto = new Auto();
                        auto.setId(contadorId);
                        contadorId++;
                        try
                        {
                            Console.WriteLine("Ingrese la Marca del auto: ");
                            auto.setMarca(Console.ReadLine());
                            Console.WriteLine("Ingrese el Modelo del auto: ");
                            auto.setModelo(Console.ReadLine());
                            Console.WriteLine("Ingrese el anio del auto: ");
                            auto.setAnio(int.Parse(Console.ReadLine()));
                            Console.WriteLine("Ingrese la cantidad de puertas del auto: ");
                            auto.setCant_puertas(int.Parse(Console.ReadLine()));
                            vehiculos.Add(auto);
                            Console.WriteLine("¿Desea crear un nuevo vehiculo?");
                            nuevo = Console.ReadLine();
                        }
                        catch (Exception ex)
                        {
                            contadorId--;
                            Console.WriteLine("algun dato no coincide con el solicitado " + ex.Message);
                        }
                        break;
                    case 2:
                        Moto moto = new Moto();
                        moto.setId(contadorId);
                        contadorId++;

                        try
                        {
                            Console.WriteLine("Ingrese la Marca de la moto: ");
                            moto.setMarca(Console.ReadLine());
                            Console.WriteLine("Ingrese el Modelo de la moto: ");
                            moto.setModelo(Console.ReadLine());
                            Console.WriteLine("Ingrese el anio de la moto: ");
                            moto.setAnio(int.Parse(Console.ReadLine()));
                            Console.WriteLine("Ingrese la cilindrada de la moto: ");
                            moto.setCilindrada(int.Parse(Console.ReadLine()));
                            vehiculos.Add(moto);

                            Console.WriteLine("¿Desea crear un nuevo vehiculo?");
                            nuevo = Console.ReadLine();
                        }
                        catch (Exception ex)
                        {
                            contadorId--;
                            Console.WriteLine("algun dato no coincide con el solicitado " + ex.Message);
                        }
                        break;
                    case 3:
                        Camion camion = new Camion();
                        camion.setId(contadorId);
                        contadorId++;
                        try
                        {

                            Console.WriteLine("Ingrese la Marca del camion: ");
                            camion.setMarca(Console.ReadLine());
                            Console.WriteLine("Ingrese el Modelo del camion: ");
                            camion.setModelo(Console.ReadLine());
                            Console.WriteLine("Ingrese el anio del camion: ");
                            camion.setAnio(int.Parse(Console.ReadLine()));
                            Console.WriteLine("Ingrese la capacidad de carga del camion (en toneladas): ");
                            camion.setCapacidad_carga(int.Parse(Console.ReadLine()));
                            vehiculos.Add(camion);
                            Console.WriteLine("¿Desea crear un nuevo vehiculo?");
                            nuevo = Console.ReadLine();
                        }
                        catch (Exception ex)
                        {
                            contadorId--;
                            Console.WriteLine("algun dato no coincide con el solicitado " + ex.Message);
                        }
                        break;
                    default:
                        Console.WriteLine("Opcion no valida.");
                        try
                        {
                            Console.WriteLine("¿Desea crear un nuevo vehiculo?");
                            nuevo = Console.ReadLine();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("algun dato no coincide con el solicitado " + ex.Message);
                        }
                        break;
                }
            }
            return vehiculos;
        }

        //Read leer unvehiculo.
        public void leerVehiculo(List<Vehiculo> vehiculos, int id) {
            foreach (var c in vehiculos)
            {

                if ( c.getId() == id)
                {
                    c.MostrarInfo();
                }
            }
        }

        //Update modificar un vehiculo.
        public void modificarVehiculo(List<Vehiculo> vehiculos, int id) 
        {
            foreach (var c in vehiculos)
            {

                if (c.getId() == id)
                {
                    if (c is Auto auto)
                    {

                        try
                        {
                            Console.WriteLine("Ingrese la Marca del auto: ");
                            auto.setMarca(Console.ReadLine());
                            Console.WriteLine("Ingrese el Modelo del auto: ");
                            auto.setModelo(Console.ReadLine());
                            Console.WriteLine("Ingrese el anio del auto: ");
                            auto.setAnio(int.Parse(Console.ReadLine()));
                            Console.WriteLine("Ingrese la cantidad de puertas del auto: ");
                            auto.setCant_puertas(int.Parse(Console.ReadLine()));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("algun dato no coincide con el solicitado " + ex.Message);
                        }
                        break;
                    }
                    else if (c is Moto moto)
                    {
                        try
                        {
                            Console.WriteLine("Ingrese la Marca de la moto: ");
                            moto.setMarca(Console.ReadLine());
                            Console.WriteLine("Ingrese el Modelo de la moto: ");
                            moto.setModelo(Console.ReadLine());
                            Console.WriteLine("Ingrese el anio de la moto: ");
                            moto.setAnio(int.Parse(Console.ReadLine()));
                            Console.WriteLine("Ingrese la Cilindrada de la moto: ");
                            moto.setCilindrada(int.Parse(Console.ReadLine()));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("algun dato no coincide con el solicitado " + ex.Message);
                        }
                        break;
                    }
                    else if (c is Camion camion)
                    {
                        try
                        {
                            Console.WriteLine("Ingrese la Marca del camion: ");
                            camion.setMarca(Console.ReadLine());
                            Console.WriteLine("Ingrese el Modelo del camion: ");
                            camion.setModelo(Console.ReadLine());
                            Console.WriteLine("Ingrese el anio del camion: ");
                            camion.setAnio(int.Parse(Console.ReadLine()));
                            Console.WriteLine("Ingrese la capacidad de carga del camion (en toneladas): ");
                            camion.setCapacidad_carga(int.Parse(Console.ReadLine()));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("algun dato no coincide con el solicitado " + ex.Message);
                        }
                        break;
                    }
                }
            }
        }

        // Delete eliminar un vehiculo.
        
        public int EliminarVehiculo(List<Vehiculo> vehiculos, int id)
        {
            int count = 0;
            for (int i = 0; i < vehiculos.Count; i++)
            {
                count++;
                if (vehiculos[i].getId() == id)
                {
                    break;
                }
                else 
                {
                    
                }
            }
            return count-1;
        }
    }
}