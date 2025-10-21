using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Semana9_DOO.Logica
{
    public class Camion : Vehiculo
    {
        private int capacidad_carga { get; set; }
        
        public Camion()
        {
        }

        public Camion(int id, string Marca, string Modelo, int anio) : base(id, Marca, Modelo, anio)
        {

        }

        // getters
        public int getId() => this.id;
        public string getMarca() => this.Marca;
        public string getModelo() => this.Modelo;
        public int getAnio() => this.anio;

        // setters 
        public void setId(int id) => this.id = id;
        public void setMarca(string Marca) => this.Marca = Marca;
        public void setModelo(string Modelo) => this.Modelo = Modelo;
        public void setAnio(int anio) => this.anio = anio;

        //Getters
        public int getCapacidad_carga() => capacidad_carga;
        //Setters
        public void setCapacidad_carga(int capacidad_carga) => this.capacidad_carga = capacidad_carga;

        public override void MostrarInfo()
        {
            Console.WriteLine("Vehiculo: Camion");
            base.MostrarInfo();
            Console.WriteLine($"Capacidad de carga: {capacidad_carga}");
        }
    }
}
