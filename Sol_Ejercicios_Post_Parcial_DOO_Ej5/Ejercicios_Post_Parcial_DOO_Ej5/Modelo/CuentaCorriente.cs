using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Post_Parcial_DOO_Ej5.Modelo
{
    public class CuentaCorriente: Cuenta,IOperacionesCuentas
    {
        private double limiteDescubierto;
        public double LimiteDescubierto { get => limiteDescubierto; set => limiteDescubierto = value; }
        public int numeroCuenta { get => NumeroCuenta; }
        public string titular { get => Titular; set => titular = value; }
        public double saldo { get => Saldo; set => saldo = value; }
        public CuentaCorriente()
        {
        }
        public CuentaCorriente(int numeroCuenta, string titular, double saldo, double limiteDescubierto)
            : base(numeroCuenta, titular, saldo)
        {
            LimiteDescubierto = limiteDescubierto;
        }
        public override void mostrarInfo()
        {
            Console.WriteLine("Cuenta corriente: ");
            base.mostrarInfo();
            Console.WriteLine($"Limite Descubierto: {limiteDescubierto}");
        }

        public void LimiteDescubiertoDisponible()
        {
            Console.WriteLine($"El limite de descubierto disponible es: {LimiteDescubierto + Saldo}");
        }

        public void Deposito(double monto)
        {
            Saldo += monto;
        }

        public void Extraccion(double monto)
        {
            // saldo - monto. Si es menor a -limiteDescubierto, no se puede hacer la extraccion
            if ((Saldo - monto) < -LimiteDescubierto)
            {
                Console.WriteLine("Fondos insuficientes para realizar la extraccion.");
            }
            else
            {
                Saldo -= monto;
            }
        }
    }
}
