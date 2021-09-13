using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Entidades
{
    class Venta
    {
        private int idproducto;
        private string nombreProducto;
        private string descripcionProducto;
        private double precioProducto;
        private int cantidad;
        private double descuento;
        private double total;

        public int Idproducto { get => idproducto; set => idproducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public string DescripcionProducto { get => descripcionProducto; set => descripcionProducto = value; }
        public double PrecioProducto { get => precioProducto; set => precioProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Descuento { get => descuento; set => descuento = value; }
        public double Total { get => total; set => total = value; }

        

        public override string ToString()
        {
            return "------Datos de su compra-----" +
                "\nId del producto: " + Idproducto +
                "\nNombre: " + NombreProducto +
                "\nDescripcion: " + DescripcionProducto +
                "\nPrecio: " + PrecioProducto.ToString("0.00") +
                "\nCantida: " + Cantidad;
                

        }
    }
}
