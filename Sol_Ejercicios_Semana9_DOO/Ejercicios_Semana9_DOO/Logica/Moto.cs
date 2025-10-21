using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Semana9_DOO.Logica
{
    public  class Moto : Vehiculo
    {
        public Moto()
        {
        }

        public Moto(int id, string Marca, string Modelo, int anio) : base(id, Marca, Modelo, anio)
        {
        }

        public int cilindrada { get; set; }


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
        public int getCilindrada() => cilindrada;

        //Setters
        public void setCilindrada(int cilindrada) => this.cilindrada = cilindrada;


        public override void MostrarInfo()
        {
            Console.WriteLine("Vehiculo: Moto");
            base.MostrarInfo();
            Console.WriteLine($"Cilindrada: {cilindrada}");
        }
    }
}
