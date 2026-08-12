using System;
using System.Collections.Generic;

namespace IMPORTADORAPOO
{
    public class GestorImportacion
    {
        
        public List<ProductoImportado> ObtenerFacturaProveedor()
        {
            List<ProductoImportado> lista = new List<ProductoImportado>();

            lista.Add(new ProductoImportado { Codigo = "101", Descripcion = "Router WiFi TP-Link", Cantidad = 100, PrecioOrigen = 45.00m, CostoReal = 0 });
            lista.Add(new ProductoImportado { Codigo = "102", Descripcion = "Cable HDMI 3m", Cantidad = 250, PrecioOrigen = 15.00m, CostoReal = 0 });
            lista.Add(new ProductoImportado { Codigo = "103", Descripcion = "Switch 8 Puertos", Cantidad = 50, PrecioOrigen = 22.00m, CostoReal = 0 });

            return lista;
        }

       
        public void EjecutarProrrateo(List<ProductoImportado> productos, decimal totalFob, decimal totalGastosExtra)
        {
            foreach (ProductoImportado prod in productos)
            {
               
                decimal porcionGastos = (prod.PrecioOrigen / totalFob) * totalGastosExtra;

              
                prod.CostoReal = prod.PrecioOrigen + porcionGastos;
            }
        }

     
        public void SimularGuardadoEnBaseDeDatos(List<ProductoImportado> productosCalculados)
        {
            foreach (ProductoImportado prod in productosCalculados)
            {
               
                Console.WriteLine($"Simulando UPDATE en BD: Producto {prod.Codigo} - Nuevo Precio: {prod.PrecioSugerido}");
            }
        }
    }
}