using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Post_Parcial_DOO_Ej5.Modelo
{
    public class CajaAhorro : Cuenta,IOperacionesCuentas
    {
        private double tasaInteres;
        public double TasaInteres { get => tasaInteres; set => tasaInteres = value; }
        public int numeroCuenta { get => NumeroCuenta; }
        public string titular { get => Titular; set => titular = value; }
        public double saldo { get => Saldo; set => saldo = value; }
        public CajaAhorro()
        {
        }
        public CajaAhorro(int numeroCuenta, string titular, double saldo, double tasaInteres)
            : base(numeroCuenta, titular, saldo)
        {
            TasaInteres = tasaInteres;
        }
        

        public override void mostrarInfo()
        {
            Console.WriteLine("Caja de ahorro: ");
            base.mostrarInfo();
            Console.WriteLine($"Tasa de Interes: {tasaInteres}");
        }

        public void AplicarInteres()
        {
            Saldo += Saldo * TasaInteres / 100;
        }

        public void Deposito(double monto)
        {
            Saldo =+ (monto);
            AplicarInteres();
        }

        public void Extraccion(double monto)
        {
            // aca realiza una copia para no modificar el saldo del obj original
            // con esto puedo evitar que la cuenta quede en negativo, sin modificar el saldo original
            CajaAhorro copia = new CajaAhorro();
            copia.Saldo = this.Saldo;
            copia.Saldo -= monto;
            copia.AplicarInteres();
            if (copia.Saldo <0)
            {
                Console.WriteLine("fondos insuficientes");
            }
            else
            {
                this.Saldo -= monto ;
                AplicarInteres();
            }
        }
    }
}
