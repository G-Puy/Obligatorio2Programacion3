using Dominio.EntidadesNegocio;
using claseDTOS;
using System.Collections.Generic;

namespace Dominio.InterfacesRepositorios
{
	public interface IRepositorioCompras : IRepositorio<Compra>
	{
		public decimal ObtenerIVA();
		//public List<MostrarCompraDTO> FindAllCompras();
		public decimal ObtenerTasaBasica();
		public decimal ObtenerTasaArancelaria();
		public IEnumerable<Compra> ListarComprasPorTipoDePlanta(int idTipo);

	}

}

