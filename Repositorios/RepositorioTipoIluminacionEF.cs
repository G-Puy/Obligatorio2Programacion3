using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio.EntidadesNegocio;
using Dominio.InterfacesRepositorios;
namespace Repositorios
{
    public class RepositorioTipoIluminacionEF : IRepositorioTiposIluminaciones
    {
        public ViveroContext ContextoViv { get; set; }

        public RepositorioTipoIluminacionEF(ViveroContext contexto)
        {

            ContextoViv = contexto;

        }

        public bool Add(TipoIluminacion obj)
        {
            bool ok = false;
            try
            {
                if (obj != null) {

                    ContextoViv.Add(obj);
                    ContextoViv.SaveChanges();
                    ok = true;
                }
             
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return ok;
        }

        public IEnumerable<TipoIluminacion> FindAll()
        {
            return   ContextoViv.TiposIluminaciones.ToList();
        }

        public TipoIluminacion FindByID(int id)
        {
            return ContextoViv.TiposIluminaciones.Find(id);
        }

        public bool Remove(TipoIluminacion obj)
        {
            bool ok = false;
            try
            {
                if (obj != null) {

                    ContextoViv.TiposIluminaciones.Remove(obj);
                    int afectadas = ContextoViv.SaveChanges();
                    ok = afectadas > 0;

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message) ;
            }
            return ok;

        }

        public bool Update(TipoIluminacion obj)
        {
            bool ok = false;
            try
            {
                if (obj != null) {

                    ContextoViv.TiposIluminaciones.Update(obj);
                    int afectadas = ContextoViv.SaveChanges();
                    ok = afectadas >0;
                }
            }
            catch (Exception ex)
            {

                throw new Exception( ex.Message);
            }
            return ok;
        }
    }
}
