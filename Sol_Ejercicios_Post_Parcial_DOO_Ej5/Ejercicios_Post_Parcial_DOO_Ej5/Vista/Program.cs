using Ejercicios_Post_Parcial_DOO_Ej5.Modelo;
using System.Xml.Schema;

namespace Ejercicios_Post_Parcial_DOO_Ej5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cuenta> cuentas = new List<Cuenta>();
            CuentaCorriente cc1 = new RepositorioCuenta().crearCuentaCorriente(1, "Pedro", 100000, 10000);
            CuentaCorriente cc2 = new RepositorioCuenta().crearCuentaCorriente(2, "Juan", 150000, 15000);
            CajaAhorro ca1 = new RepositorioCuenta().crearCajaAhorro(3, "Maria", 200000, 2.1);
            CajaAhorro ca2 = new RepositorioCuenta().crearCajaAhorro(4, "Ana", 250000, 3.1);
            agregarCuenta(cuentas, cc1);
            agregarCuenta(cuentas, cc2);
            agregarCuenta(cuentas, ca1);
            agregarCuenta(cuentas, ca2);
            mostrarCuentas(cuentas);

            Console.WriteLine("*******************");

            Console.WriteLine("*******************");

            Console.WriteLine("*******************");
            eliminarCuenta(cuentas, 2);
            CuentaCorriente cc =cuentas[0] as CuentaCorriente;
            cc.Deposito(5000);
            cuentas[0] = cc;
            CajaAhorro caja = cuentas[2] as CajaAhorro;
            caja.Extraccion(10000);
            cuentas[2] = caja;

            mostrarCuentas(cuentas);
        }

        public static void mostrarCuentas(List<Cuenta> cuentas)
        {
            foreach (var cuenta in cuentas)
            {
                cuenta.mostrarInfo();
            }
        }

        public static void agregarCuenta(List<Cuenta> cuentas, Cuenta cc)
        {
            cuentas.Add(cc);
        }

        public static void eliminarCuenta(List<Cuenta> cuentas, int nroCuenta)
        {
            cuentas.RemoveAll(c=>c.numeroCuenta == nroCuenta);
        }
    }
}
