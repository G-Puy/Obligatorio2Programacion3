using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.EntidadesNegocio
{
    public class ItemCompraPlanta
    {   
        public int Id { get; set; }
        public Planta planta { get; set; }
        public Compra compra { get; set; }
        public int PlantaId { get; set; }
        public int CompraId { get; set; }
        
        public int Unidades { get; set; }
        public decimal PrecioUnitario { get; set; }
       
    }
}
