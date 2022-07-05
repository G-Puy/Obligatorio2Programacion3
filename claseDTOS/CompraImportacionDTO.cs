using System;
using System.Collections.Generic;
using System.Text;

namespace claseDTOS
{
    public class CompraImportacionDTO
    {
        //datos de COMPRA base
        public int Id { get; set; }
        public DateTime FechaCompra { get; set; }
        public List<ItemDTO> ItemsPlantasCompradas { get; set; }
        public decimal PrecioTotal { get; set; }
        //datos de COMPRA base

        //datos de IMPORTACION

        public decimal TasaBasica { get; set; }
        public bool EsDeAmericaDelSur { get; set; }
        public decimal TasaArancelaria { get; set; }
        public string DescripcionSanitaria { get; set; }

        //datos de IMPORTACION






    }
}
