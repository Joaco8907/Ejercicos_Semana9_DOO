using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Post_Parcial_DOO_Ej5.Modelo
{/*Cree una aplicación para administrar cuentas bancarias.
Defina la clase Cuenta con NumeroCuenta, Titular y Saldo.
Clases hijas: CajaAhorro (con tasa de interés) y CuentaCorriente (con límite de descubierto).
La aplicación deberá permitir:
Registrar Cuentas.
Realizar depósitos y extracciones.
Aplicar intereses o actualizar saldos.
Listar todas las cuentas mostrando su tipo y saldo.
Los datos se almacenarán en una List<Cuenta>.*/
    public class Cuenta
    {
        public int numeroCuenta;
        private string titular;
        private double saldo;

        protected int NumeroCuenta { get => numeroCuenta; set => numeroCuenta = value; }
        protected string Titular { get => titular; set => titular = value; }
        protected double Saldo { get => saldo; set => saldo = value; }

        public Cuenta()
        {
        }
        public Cuenta(int numeroCuenta, string titular, double saldo)
        {
            NumeroCuenta = numeroCuenta;
            Titular = titular;
            Saldo = saldo;
        }

        public virtual void mostrarInfo() 
        {
            Console.WriteLine($"Numero de cuenta: {numeroCuenta}, Titular: {titular}, saldo: {saldo}");
        }

    }
}
