using System;
using System.Collections.Generic;
using System.Text;


namespace claseDTOS
{
    public class MostrarCompraDTO
    {
        // esto solo se va a usar para el GET o el BYID GET para >>MOSTRAR<<


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

        //datos de PLAZA
        public decimal TasaIva { get; set; }
        public decimal CostoFlete { get; set; }
        // datos de PLAZA








    }
}
