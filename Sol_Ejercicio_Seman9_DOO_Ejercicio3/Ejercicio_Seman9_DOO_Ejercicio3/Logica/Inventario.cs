using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Seman9_DOO_Ejercicio3.Logica
{
    internal class Inventario
    {
        private List<Producto> productos = new List<Producto>();
        private int count = 1;
        public Inventario()
        {
        }

        public Inventario(List<Producto> productos)
        {
            this.productos = productos;
        }

        //Agregar producto al inventario
        public void agregarProducto()
        {
            productos.Add(crearProducto());
            count++;
        }

        //Listar productos del inventario
        public void listarProductos()
        {
            foreach (Producto producto in productos)
            {
                producto.MostrarInfo();
            }
        }

        //Eliminar producto del inventario
        public void eliminarProducto(int id)
        {
            foreach (Producto producto in productos)
            {
                if (producto.ID == id)
                {
                    productos.Remove(producto);
                    break;
                }
            }
        }

        public Producto crearProducto()
        {
            Console.WriteLine("Ingrese el tipo de producto a crear (1- Alimenticio, 2- Electronico): ");
            int tipo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Nombre del producto: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el Precio Base del producto: ");
            double precioBase = double.Parse(Console.ReadLine());
            if (tipo == 1)
            {
                Console.WriteLine("Ingrese la Fecha de Vencimiento del producto (dd/mm/yyyy): ");
                DateTime fechaVencimiento = DateTime.Parse(Console.ReadLine());
                ProductoAlimento productoAlimento = new ProductoAlimento(fechaVencimiento)
                {
                    ID = count,
                    Nombre = nombre,
                    PrecioBase = precioBase
                };
                return productoAlimento;
            }
            else
            {
                Console.WriteLine("Ingrese los Meses de Garantia del producto: ");
                int mesesGarantia = int.Parse(Console.ReadLine());
                ProductoElectronico productoElectronico = new ProductoElectronico(mesesGarantia)
                {
                    ID = count,
                    Nombre = nombre,
                    PrecioBase = precioBase
                };
                return productoElectronico;
            }
        }

        //modificar producto del inventario
        public void modificarProducto(int id)
        {
            for (int i = 0; i < productos.Count; i++)
            {
                if (productos[i].ID == id)
                {
                    productos[i] = crearProducto();
                    productos[i].ID = id; // Mantener el mismo ID
                    break;
                }
            }
        }

        public void MostrarProductos_X_Tipo()
        {

            List<Producto> ListaXTipo = new List<Producto>();
            Console.WriteLine("Ingrese el tipo de producto que desea listar: ");
            Console.WriteLine("1- Lista Alimentos");
            Console.WriteLine("2- Lista electronicos");
            int opcion = int.Parse(Console.ReadLine());

            foreach (var producto in productos)
            {
                if (producto is ProductoAlimento && opcion == 1)
                {
                    ListaXTipo.Add(producto);
                }
                else if (producto is ProductoElectronico && opcion == 2)
                {
                    ListaXTipo.Add(producto);
                }
            }
            foreach (var item in ListaXTipo)
            {
                item.MostrarInfo();
            }
        }

    }
}
