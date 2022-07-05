using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.EntidadesNegocio;
namespace MVCvivero.Models
{
    public class ViewModelCompra
    {
        public int idTipoPlanta { get; set; }
        public IEnumerable<TipoPlanta> ListaTipoPlanta { get; set; }
    }
}
