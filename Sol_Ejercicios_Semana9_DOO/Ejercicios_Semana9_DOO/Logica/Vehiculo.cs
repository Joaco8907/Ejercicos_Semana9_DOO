using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Ejercicio 1 – Gestión de vehículos
Diseñe un sistema para administrar los vehículos que ingresan a un taller.
Cree una clase padre Vehiculo con los atributos: Id, Marca, Modelo y Año.
A partir de ella, crear las clases Auto, Moto y Camion, que agreguen atributos específicos (por
ejemplo, cantidadPuertas, cilindrada, capacidadCarga).
*/
namespace Ejercicios_Semana9_DOO.Logica
{
    public class Vehiculo
    {
        protected int id { get; set; }
        protected string Marca { get; set; }
        protected string Modelo { get; set; }
        protected int anio { get; set; }

        public Vehiculo() { }            
        public Vehiculo(int id, string Marca, string Modelo, int anio) { 
            this.id = id;
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.anio = anio;
        }

        // getters
        public int getId() => id;
        public string getMarca() => Marca;
        public string getModelo() => Modelo;
        public int getAnio() => anio;

        // setters 
        public void setId(int id) => this.id = id;
        public void setMarca(string Marca) => this.Marca = Marca;
        public void setModelo(string Modelo) => this.Modelo = Modelo;
        public void setAnio(int anio) => this.anio = anio;

        public virtual void MostrarInfo() 
        {
            Console.WriteLine($"Id: {id}, Marca: {Marca}, Modelo: {Modelo}, Anio {anio}");
        }
        
         
    }
}
