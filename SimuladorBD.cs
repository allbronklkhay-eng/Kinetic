using System;
using System.Collections.Generic;

namespace IMPORTADORAPOO
{
    public class SimuladorBD
    {
        
        public List<Producto> ObtenerProductosPrueba()
        {
            List<Producto> inventario = new List<Producto>();

         
            inventario.Add(new Producto { Codigo = "101", Nombre = "Cable HDMI 3m", Precio = 15.00m, Stock = 50 });
            inventario.Add(new Producto { Codigo = "102", Nombre = "Router WiFi TP-Link", Precio = 45.00m, Stock = 20 });
            inventario.Add(new Producto { Codigo = "103", Nombre = "Cable Coaxial 2m", Precio = 10.00m, Stock = 100 });
            inventario.Add(new Producto { Codigo = "104", Nombre = "Switch 8 Puertos", Precio = 25.50m, Stock = 15 });
            inventario.Add(new Producto { Codigo = "105", Nombre = "Antena Receptora USB", Precio = 12.75m, Stock = 30 });

            return inventario;
        }
    }
}