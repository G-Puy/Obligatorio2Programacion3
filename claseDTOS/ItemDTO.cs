using System;
using System.Collections.Generic;
using System.Text;

namespace claseDTOS
{
    public class ItemDTO
    {
        
        //DATOS DEL ITEMCOMPRA ORIGINAL
      
        public int PlantaId { get; set; }
        public int Unidades { get; set; }
        public decimal PrecioUnitario { get; set; }
        public string NombreCientifico { get; set; }
        //lo vamos a meter en la lista de items DTO que tiene la clase
        //DTOPLAZA asi en el postman no le pasamos la planta entera
        //creo que eso soluciona el tema que se me crea una planta de mas en la bd

    }
}
