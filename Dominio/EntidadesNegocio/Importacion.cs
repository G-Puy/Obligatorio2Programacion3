using Dominio.EntidadesNegocio;

namespace Dominio.EntidadesNegocio
{
	public class Importacion : Compra
	{

        //public int IdImportacion { get; set; }
        public  decimal TasaBasica { get; set; }
        public bool EsDeAmericaDelSur { get; set; }
        public  decimal TasaArancelaria { get; set; }
        public string DescripcionSanitaria { get; set; }

        public void CalcularTasaBaseAplicar()
		{
            if (EsDeAmericaDelSur == true) TasaBasica -= TasaArancelaria;

		}

		public override decimal CalcularCostoTotal()
		{
            decimal total = 0;
            foreach (var itemCompradoActual in ItemsPlantasCompradas)
                
            {
                total += itemCompradoActual.PrecioUnitario * itemCompradoActual.Unidades;
            }
            MontoImpuestosAplicados = total * (TasaBasica / 100);
            
            total += total * (TasaBasica/ 100);
            
            return total;
        }

        public override decimal CalcularImpuesto()
        {
            throw new System.NotImplementedException();
        }

        public override string ObtenerTipoCompra()
        {
            throw new System.NotImplementedException();
        }
    }

}

