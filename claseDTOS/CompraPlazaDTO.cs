using System;
using System.Collections.Generic;
using System.Text;

namespace claseDTOS
{
    public class CompraPlazaDTO
    {
        //Este lo vamos a usar para pasarle los datos desde el postman 
        //y asi dar de alta la compra de tipo PLAZA


        //datos de COMPRA base
        public int Id { get; set; }
        public DateTime FechaCompra { get; set; }
        public List<ItemDTO> ItemsPlantasCompradas { get; set; }
        public decimal ImpuestoCompra { get; set; }
        public decimal PrecioTotal { get; set; } 
        //datos de COMPRA base
        
        //datos de PLAZA
        public decimal TasaIva { get; set; }
        public decimal CostoFlete { get; set; }
        // datos de PLAZA
      

    }
}
