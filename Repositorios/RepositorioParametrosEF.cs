using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio.EntidadesNegocio;
using Dominio.InterfacesRepositorios;

namespace Repositorios
{
    public class RepositorioParametrosEF : IRepositorioParametros
    {
        public ViveroContext ContextoViv { get; set; }

        public RepositorioParametrosEF(ViveroContext contexto)
        {
            ContextoViv = contexto;
        }

        public Parametros BuscarParametroPorDescripcion(string textoDescripcion)
        {
            try
            {
                return ContextoViv.Parametros
                        .Where(p => p.DescParametro == textoDescripcion)
                        .SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Error al buscar Parametro por Descripcion");

            }
        }

        public bool Add(Parametros obj)
        {
            bool ok = false;
            try
            {
                if (obj != null)
                {
                    ContextoViv.Parametros.Add(obj);
                    ContextoViv.SaveChanges();
                    ok = true;
                }
            }
            catch (Exception)
            {
                return ok;
                throw;
            }
            return ok;
        }

        public bool Remove(Parametros obj)
        {
            bool ok = false;
            try
            {
                if (obj != null)
                {
                    Parametros p = new Parametros { Id = obj.Id };
                    ContextoViv.Parametros.Remove(p);
                    int afectadas = ContextoViv.SaveChanges();
                    ok = afectadas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Error al remover un Parametro");
            }
            return ok;
        }

        public bool Update(Parametros obj)
        {
            if (obj == null) return false;
            try
            {
                ContextoViv.Update(obj);
                ContextoViv.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Parametros FindByID(int id)
        {
            return ContextoViv.Parametros.Find(id);
        }

        public IEnumerable<Parametros> FindAll()
        {
            return ContextoViv.Parametros.ToList();
        }



    }
}
