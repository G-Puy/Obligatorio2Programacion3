using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio.EntidadesNegocio;
using Dominio.InterfacesRepositorios;
using Microsoft.EntityFrameworkCore;

namespace Repositorios
{
    public class RepositorioPlantaEF : IRepositorioPlantas
    {

        public ViveroContext ContextoViv { get; set; }

        public RepositorioPlantaEF(ViveroContext contexto)
        {
            ContextoViv = contexto;
        }


        public bool Add(Planta obj)
        {
            bool ok = false;
            try
            {
                if (obj != null)
                {
                    if (validarLargoDesc(obj.DescripcionPlanta) && 
                        !BuscarPlantaPorNombreCientifico(obj.NombreCientifico))
                    {
                        ContextoViv.Plantas.Add(obj);
                        ContextoViv.SaveChanges();
                        return ok = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Error, no se puede agregar planta");
            }
            return ok;
        }
        private bool validarLargoDesc(string desc)
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
        public bool BuscarPlantaPorNombreCientifico(string strNombreCientifico)
        {
            bool ok = false;
            Planta pla = ContextoViv.Plantas
                //.Include(p => p.FotosDePlanta)
                //.Include(p => p.Tipo)
                //.Include(p => p.CuidadosPlanta)
                //    .ThenInclude(c => c.TipoIluminacion)
                    .Where(p => p.NombreCientifico == strNombreCientifico).SingleOrDefault();
            if (pla == null) return ok;
            return ok = true; 
        }

        public Planta BuscarPlantaPorNombreCientificoDevuelvePlanta(string nombreCientifico)
        {
            Planta pla = ContextoViv.Plantas
                .Include(p => p.FotosDePlanta)
                .Include(p => p.Tipo)
                .Include(p => p.CuidadosPlanta)
                    .ThenInclude(c => c.TipoIluminacion)
                    .Where(p => p.NombreCientifico == nombreCientifico).SingleOrDefault();
            return pla;

        }

        public IEnumerable<Planta> BuscarPlantaPorTexto(string texto)
        {
            IEnumerable<Planta> pla = ContextoViv.Plantas
                .Where(p=> p.NombreCientifico.ToLower().Contains(texto.ToLower()) 
                        || p.NombresVulgares.ToLower().Contains(texto.ToLower()))
                .Include(p => p.FotosDePlanta)
                .Include(p => p.Tipo)
                .Include(p => p.CuidadosPlanta)
                    .ThenInclude(c => c.TipoIluminacion)
                .ToList();
            return pla;
        }

        //////////////////////////
       
            //users = users.Where(u => u.FIRSTNAME.ToLower().Contains(FirstName.ToLower()));
      
            //users = users.Where(u => u.LASTNAME.ToLower().Contains(LastName.ToLower()));





        public IEnumerable<Planta> BuscarPlantasPorAlturaMaxima(int masDeXaltura)
        {
            IEnumerable<Planta> pla = ContextoViv.Plantas
                .Include(p => p.FotosDePlanta)
                .Include(p => p.Tipo)
                .Include(p => p.CuidadosPlanta)
                    .ThenInclude(c => c.TipoIluminacion)
                .Where(p => p.Altura >= masDeXaltura)
                .ToList();
            return pla;
        }

        public IEnumerable<Planta> BuscarPlantasPorAlturaMinima(int alturaMnima)
        {
            IEnumerable<Planta> pla = ContextoViv.Plantas
                .Include(p => p.FotosDePlanta)
                .Include(p => p.Tipo)
                .Include(p => p.CuidadosPlanta)
                    .ThenInclude(c => c.TipoIluminacion)
                .Where(p => p.Altura < alturaMnima)
                .ToList();
            return pla;
        }

        public IEnumerable<Planta> BuscarPlantasPorAmbiente(string ambiente)
        {
            Planta  pamb = new Planta();
            switch (ambiente)
            {
                case "interior":
                    pamb.TipoAmbiente = Planta.Ambiente.interior;
                    break;
                case "exterior":
                    pamb.TipoAmbiente = Planta.Ambiente.exterior;
                    break;
                case "mixto":
                    pamb.TipoAmbiente = Planta.Ambiente.mixta;
                    break;
            }

            IEnumerable<Planta> pla = ContextoViv.Plantas.Where(p => p.TipoAmbiente == pamb.TipoAmbiente)
                .Include(p => p.FotosDePlanta)
                .Include(p => p.Tipo)
                .Include(p => p.CuidadosPlanta)
                    .ThenInclude(c => c.TipoIluminacion)
                .ToList();

             //.IncludeFilter()
            return pla;
        }

        public IEnumerable<Planta> BuscarPlantasPorTipo(TipoPlanta x)
        {
            IEnumerable<Planta> pla = ContextoViv.Plantas
               .Include(p => p.FotosDePlanta)
               .Include(p => p.Tipo)
               .Include(p => p.CuidadosPlanta)
                   .ThenInclude(c => c.TipoIluminacion)
                .Where(p => p.Tipo == x)
               .ToList();
            return pla;
        }

        public IEnumerable<Planta> FindAll()
        {
            IEnumerable<Planta> pla = ContextoViv.Plantas
                .Include(p => p.FotosDePlanta)
                .Include(p => p.Tipo)
                .Include(p => p.CuidadosPlanta)
                    .ThenInclude(c =>c.TipoIluminacion)
                .ToList();
            return pla;
        }

        public Planta FindByID(int id)
        {
            Planta pla = ContextoViv.Plantas
                .Include(p => p.FotosDePlanta)
                .Include(p => p.Tipo)
                .Include(p => p.CuidadosPlanta)
                    .ThenInclude(c => c.TipoIluminacion)
                    .Where(p => p.Id == id).SingleOrDefault(); 
            return pla;
        }

        public List<Parametros> ParametrosValidacionLargoDesc()
        {
            List<Parametros> par = ContextoViv.Parametros.Where(pr => pr.TipoParametro == "ValidarDescPlanta")
                .ToList();

                return par;
        }

        public bool Remove(Planta obj)
        {
            bool ok = false;
            try
            {
                if (obj != null)
                {
                    Planta p = new Planta { Id = obj.Id };
                    ContextoViv.Plantas.Remove(p);
                    int afectadas = ContextoViv.SaveChanges();
                    ok = afectadas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Ocurrio un error, no se puede eliminar planta");
            }
            return ok;
        }

        public bool Update(Planta obj)
        {
            bool ok = false;
            try
            {
                if (obj != null)
                {
                    if (obj.Validar())
                    {
                        ContextoViv.Plantas.Update(obj);
                        int afectadas = ContextoViv.SaveChanges();
                        ok = afectadas > 0;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }


            return ok;
        }
    }
    }

