using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio.EntidadesNegocio;
using Dominio.InterfacesRepositorios;
namespace Repositorios
{
   public class RepositorioTipoPlantaEF : IRepositorioTiposPlantas
    {


        public ViveroContext ContextoViv { get; set; }

        public RepositorioTipoPlantaEF(ViveroContext contexto)
        {

            ContextoViv = contexto;

        }

        public bool Add(TipoPlanta obj)
        {
            bool ok = false;

            try
            {
                if (obj != null) {
                    if (obj.Validar()) {
                        if (validarLargoDesc(obj.DescTipoPlanta))
                        {
                            ContextoViv.Add(obj);
                            ContextoViv.SaveChanges();
                            ok = true;
                        }
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
            return ok;
        }
        private bool validarLargoDesc(String desc)
        {
            bool valido = false;
            List<Parametros> par = ParametrosValidacionLargoDesc();
            int max = Int32.Parse(par[0].ValorParametro);
            int min = Int32.Parse(par[1].ValorParametro);
            if (desc.Length <= max && desc.Length >= min)
            {
                valido = true;
            }

            return valido;
        }
        public List<Parametros> ParametrosValidacionLargoDesc()
        {
            List<Parametros> par = ContextoViv.Parametros.Where(pr => pr.TipoParametro == "ValidarDescPlanta")
                .ToList();

            return par;
        }

        public TipoPlanta BuscarTipoPlantaPorNombre(string nombreTipo)
        {
            try
            {
               return ContextoViv.TiposPlantas
              .Where(tp => tp.NomTipoPlanta == nombreTipo)
              .SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

          
        }

        public IEnumerable<TipoPlanta> FindAll()
        {
            return ContextoViv.TiposPlantas.ToList();
        }

        public TipoPlanta FindByID(int id)
        {
        
           return  ContextoViv.TiposPlantas.Find(id);
        }

        public bool Remove(TipoPlanta obj)
        {
            bool ok = false;

            try
            {
                ContextoViv.TiposPlantas.Remove(obj);
                int afectadas = ContextoViv.SaveChanges();
                ok = afectadas > 00;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return ok;

        }

        public bool Update(TipoPlanta obj)
        {
            bool ok = false;

            try
            {
                ContextoViv.TiposPlantas.Update(obj);
                int afectada = ContextoViv.SaveChanges();
                ok = afectada > 0;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return ok;
        }
    }
}
