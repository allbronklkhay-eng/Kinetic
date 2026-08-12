using System;

namespace IMPORTADORAPOO
{
    public class DetalleVenta
    {
     
        public Producto ProductoSeleccionado { get; set; }

        public int Cantidad { get; set; }

        
        public decimal Subtotal
        {
            get
            {
                return ProductoSeleccionado.Precio * Cantidad;
            }
        }
    }
}