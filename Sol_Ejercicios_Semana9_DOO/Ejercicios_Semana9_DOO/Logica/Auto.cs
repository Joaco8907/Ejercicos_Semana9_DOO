using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Semana9_DOO.Logica
{
    public class Auto: Vehiculo
    {
        private int cant_puertas { get; set; }

        public Auto()
        {
        }
        public Auto(int id, string Marca, string Modelo, int anio) : base(id, Marca, Modelo, anio)
        {
        }
        //Getters

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
        public int getCant_puertas() => cant_puertas;
        //Setters
        public void setCant_puertas(int cant_puertas) => this.cant_puertas = cant_puertas;

        public override void MostrarInfo()
        {
            Console.WriteLine("Vehiculo: Auto");
            base.MostrarInfo();
            Console.WriteLine($"nCantidad de puertas: {cant_puertas}");
        }
    }
}
