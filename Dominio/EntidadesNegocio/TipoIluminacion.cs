using Dominio.EntidadesNegocio;
using System.Collections.Generic;
using Dominio.OtrasInterfaces;


namespace Dominio.EntidadesNegocio
{
    public class TipoIluminacion
    {
        public int Id { get; set; }
        public string NombreTipoIluminacion { get; set; }

        public override string ToString()
        {
            return Id + " " + NombreTipoIluminacion;
        }
    }

}

