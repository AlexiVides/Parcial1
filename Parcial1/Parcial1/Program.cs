using Parcial1.Entidades;
using Parcial1.Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario();

            Console.WriteLine("nombre: ");
            usuario.Nombre = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Contraseña: ");
            usuario.Contraseña = Convert.ToInt32(Console.ReadLine());

            ClsUsuario clsUsuario = new ClsUsuario();

            Console.WriteLine(clsUsuario.acceso(usuario));

            Venta venta = new Venta();

            while (usuario.Nombre == usuario.Nombre && usuario.Contraseña == usuario.Contraseña)
            {
                Console.WriteLine("Ingrese el Id del Producto: ");
                venta.Idproducto = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el nombre del Producto: ");
                venta.NombreProducto = Console.ReadLine();
                Console.WriteLine("Ingrese la descripcion del Producto: ");
                venta.DescripcionProducto = Console.ReadLine();
                Console.WriteLine("Ingrese el precio del Producto: ");
                venta.PrecioProducto = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de Producto que comprará: ");
                venta.Cantidad = Convert.ToInt32(Console.ReadLine());

                ClsVenta clsVenta = new ClsVenta();

                Console.WriteLine(venta.ToString());
                Console.WriteLine(clsVenta.cobro(venta));
                Console.ReadLine();
            }

        }
    }
}
