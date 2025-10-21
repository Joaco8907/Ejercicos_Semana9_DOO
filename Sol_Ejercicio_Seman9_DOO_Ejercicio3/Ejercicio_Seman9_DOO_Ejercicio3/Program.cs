using Ejercicio_Seman9_DOO_Ejercicio3.Logica;

namespace Ejercicio_Seman9_DOO_Ejercicio3
{
    internal class Program
    {
        /*Se desea desarrollar un sistema para gestionar el inventario de una tienda.
        Cree una clase padre Producto con los atributos Id, Nombre y PrecioBase.
        A partir de ella, crear las clases hijas ProductoAlimenticio (con FechaVencimiento) y
        ProductoElectronico (con MesesGarantia).
        Extra:
        Listar todo el inventario mostrando el tipo de producto*/
        static void Main(string[] args)
        {
            //Hacemos un CRUD basico
            Inventario inventario = new Inventario();
            bool salir = false;
            int opcion;
            while (!salir)
            {
                Console.WriteLine("Seleccione una opcion: ");
                Console.WriteLine("1- Agregar producto");
                Console.WriteLine("2- Listar productos");
                Console.WriteLine("3- Modificar producto");
                Console.WriteLine("4- Eliminar producto");
                Console.WriteLine("5- Mostral lista por tipo de producto: ");
                Console.WriteLine("6- Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        inventario.agregarProducto();
                        break;
                    case 2:
                        inventario.listarProductos();
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el id del producto que desea modificar");
                        int idModificar = int.Parse(Console.ReadLine());
                        inventario.modificarProducto(idModificar);
                        break;
                    case 4:
                        Console.WriteLine("Ingrese el Id del producto a eliminar: ");
                        int id = int.Parse(Console.ReadLine());
                        inventario.eliminarProducto(id);
                        break;
                    case 5:
                        //El extra
                        inventario.MostrarProductos_X_Tipo();
                        break;
                    case 6:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
