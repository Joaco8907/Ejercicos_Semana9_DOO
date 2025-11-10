using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Post_Parcial_DOO_Ej5.Modelo
{
    internal interface IOperacionesCuentas
    {
        public void Deposito(double monto);
        public void Extraccion(double monto);

    }
}
