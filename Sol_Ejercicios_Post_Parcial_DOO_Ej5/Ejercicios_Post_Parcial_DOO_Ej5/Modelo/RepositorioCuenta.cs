using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Post_Parcial_DOO_Ej5.Modelo
{
    public class RepositorioCuenta
    {
        public CuentaCorriente crearCuentaCorriente(int numeroCuenta, string titular, double saldo, double limiteDescubierto)
        {
            return new CuentaCorriente(numeroCuenta,titular,saldo,limiteDescubierto);
        }
        public void acualizarCuentaCorriente(CuentaCorriente cuenta)
        {
            Console.WriteLine("Ingrese el nuevo nombre del titular: ");
            cuenta.titular = Console.ReadLine();
        }

        public CajaAhorro crearCajaAhorro(int numeroCuenta, string titular, double saldo, double tasaInteres)
        {
            return new CajaAhorro(numeroCuenta,titular,saldo,tasaInteres);
        }

        public void actualizarCajaAhorro(CajaAhorro cuenta)
        {
            Console.WriteLine("Ingrese el nuevo nombre del titular: ");
            cuenta.titular = Console.ReadLine();
        }


    }
}
