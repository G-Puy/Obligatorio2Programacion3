using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio.EntidadesNegocio;
using Dominio.InterfacesRepositorios;
using Microsoft.EntityFrameworkCore;
using claseDTOS;



namespace Repositorios
{
    public class RepositorioComprasEF : IRepositorioCompras
    {
        public ViveroContext ContextoViv { get; set; }

        public RepositorioComprasEF(ViveroContext contexto)
        {
            ContextoViv = contexto;
        }

        public bool Add(Compra obj)
        {
            bool ok = false;
            try
            {
                if (obj != null)
                {

                    ContextoViv.Compras.Add(obj);
                    
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

        //public List<MostrarCompraDTO> FindAllCompras()
        //{
            
        //        var list =  ContextoViv.Compras
        //        .Include(c => c.ItemsPlantasCompradas)
        //        //    .ThenInclude(c => c.planta)
        //        //    .ThenInclude(cui => cui.CuidadosPlanta)
        //        //    .ThenInclude(ilu => ilu.TipoIluminacion)
        //        //.Include(c => c.ItemsPlantasCompradas)
        //        //.ThenInclude(c => c.planta)
        //        //.ThenInclude(cui => cui.FotosDePlanta)
        //        .ToList();

        //    var ret = new List<MostrarCompraDTO>();

        //    foreach (var itemDeList in list)
        //    {
        //        itemDeList.Id

        //    }


        //    return ret;

        //}

        public Compra FindByID(int id)
        {
            return ContextoViv.Compras.Find(id);
        }

        public bool Remove(Compra obj)
        {
            bool ok = false;
            try
            {
                if (obj != null)
                {

                    ContextoViv.Remove(obj.Id);
                    int afectadas = ContextoViv.SaveChanges();
                    ok = afectadas > 0;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return ok;
        }

        public bool Update(Compra obj)
        {
            bool ok = false;

            try
            {
                if (obj != null)
                {

                    ContextoViv.Compras.Update(obj);
                    int afectadas = ContextoViv.SaveChanges();
                    ok = afectadas > 0;

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return ok;
        }
        public IEnumerable<Plaza> GetPlazas()
        {

            return ContextoViv.Plazas.ToList();

        }
        public IEnumerable<Importacion> GetImportacions()
        {

            return ContextoViv.Importaciones.ToList();
        }

        public decimal ObtenerIVA()
        {
            decimal iva = 0;
            //IVAplaza 
            //tengo que traer el iva de la base  
            List<Parametros> parametroIva = ContextoViv.Parametros
                            .Where(p => p.TipoParametro == "IVAplaza")
                            .ToList();
            iva = decimal.Parse(parametroIva[0].ValorParametro);
            return iva;
        }
        public decimal ObtenerTasaArancelaria()
        {
            decimal TasaArancelaria = 0;
            List<Parametros> parametroTA = ContextoViv.Parametros
                            .Where(p => p.TipoParametro == "TasaArancelaria")
                            .ToList();
            TasaArancelaria = decimal.Parse(parametroTA[0].ValorParametro);
            return TasaArancelaria;
        }
        
        public decimal ObtenerTasaBasica()
        {
            decimal TasaBasica = 0;
            List<Parametros> parametroTB = ContextoViv.Parametros
                            .Where(p => p.TipoParametro == "TasaBasica")
                            .ToList();
            TasaBasica = decimal.Parse(parametroTB[0].ValorParametro);
            return TasaBasica;
        }

        public IEnumerable<Compra> FindAll()
        {
            return ContextoViv.Compras
                .Include(c => c.ItemsPlantasCompradas)
                    .ThenInclude(c => c.planta)
                          .ThenInclude(cui => cui.CuidadosPlanta)
                              .ThenInclude(ilu => ilu.TipoIluminacion)
                .Include(c => c.ItemsPlantasCompradas)
                    .ThenInclude(c => c.planta)
                        .ThenInclude(cui => cui.FotosDePlanta)
                .Include(c => c.ItemsPlantasCompradas)
                    .ThenInclude(c => c.planta)
                        .ThenInclude(c => c.Tipo)
                .ToList();
        }

        public IEnumerable<Compra> ListarComprasPorTipoDePlanta(int idTipo)
        {


            //return ContextoViv.ItemsPlantasCompradas
            //           .Where(itp => itp.planta.Tipo.Id == idTipo)
            //           .Select(i => i.compra)
            //           .Distinct()
            //           .Include(c => c.ItemsPlantasCompradas)
            //               .ThenInclude(itm => itm.planta.NombreCientifico)
            //            .Include(c => c.ItemsPlantasCompradas)
            //               .ThenInclude(itm => itm.Unidades)
            //           .ToList();







            return ContextoViv.ItemsPlantasCompradas
                        .Where(itp => itp.planta.Tipo.Id == idTipo)
                        .Select(i => i.compra)
                        .Distinct()
                        .Include(c => c.ItemsPlantasCompradas)
                            .ThenInclude(itm => itm.planta)
                                .ThenInclude(pla => pla.CuidadosPlanta)
                                    .ThenInclude(cui => cui.TipoIluminacion)
                            .Include(c => c.ItemsPlantasCompradas)
                                .ThenInclude(itm => itm.planta)
                                    .ThenInclude(pla => pla.FotosDePlanta)
                            .Include(c => c.ItemsPlantasCompradas)
                                .ThenInclude(itm => itm.planta)
                                    .ThenInclude(pla => pla.Tipo)
                        .ToList();
        }
    }

    


}
