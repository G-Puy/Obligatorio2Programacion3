using Dominio.EntidadesNegocio;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.EntidadesNegocio
{
	public class Plaza : Compra
	{
        //public int IdPlaza { get; set; }      
        public  decimal TasaIva { get; set; }
        public decimal CostoFlete { get; set; }

        
        public override decimal CalcularImpuesto()
        {
            throw new System.NotImplementedException();
        }

        public override decimal CalcularCostoTotal()
        {
            decimal total = 0;
            foreach (var itemCompradoActual in ItemsPlantasCompradas)
            {
                total += itemCompradoActual.PrecioUnitario * itemCompradoActual.Unidades;
            }
            MontoImpuestosAplicados = total * (TasaIva / 100);

            total += total * (TasaIva/100);
            total += CostoFlete;
            return total;
        }

        public override string ObtenerTipoCompra()
        {
            throw new System.NotImplementedException();
        }

     
    }

}

