using System;

namespace IMPORTADORAPOO
{
    public class ProductoImportado
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }

  
        public decimal PrecioOrigen { get; set; }

        
        public decimal CostoReal { get; set; }

       
        public decimal PrecioSugerido
        {
            get
            {
                return CostoReal * 1.30m;
            }
        }
    }
}
