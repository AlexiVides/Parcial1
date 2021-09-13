using Parcial1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Negocios
{
    class ClsVenta
    {
        public string cobro(Venta venta)
        {
            venta.Total = (venta.PrecioProducto * venta.Cantidad) - venta.Descuento ;

            if (venta.Total > 50)
            {
                venta.Descuento = venta.Total * 0.15;
                return "\nSu descuento es de: " + venta.Descuento +
                "\ntotal a pagar: " + venta.Total;
            }
            else
            {
                venta.Descuento = venta.Total * 0;
                return "\nSu descuento es de: " + venta.Descuento +
                "\nTotal a pagar por su compra: " + venta.Total;
            }

        }

    }
}
