using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.EntidadesNegocio;
using Repositorios;
using Dominio.InterfacesRepositorios;
using claseDTOS;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ViveroAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ComprasController : ControllerBase
    {
        public IRepositorioCompras RepoCompras { get; set; }
        public IRepositorioPlantas RepoPlantas { get; set; }

        public ComprasController(IRepositorioCompras repo, IRepositorioPlantas repoP)
        {
            RepoCompras = repo;
            RepoPlantas = repoP;
        }
        // GET: api/<ComprasController>
        [HttpGet]
        public ActionResult <IEnumerable<Compra>> Get()//findall
        {
            try
            {
                var compras = RepoCompras.FindAll();
                if (compras == null) return BadRequest();
                return Ok(compras);
            }
            catch (Exception ex)
            {

                return StatusCode(500);
            }
            
        }
        
        // GET api/<ComprasController>/5
        [HttpGet("{id}")]//findbyid
        public IActionResult Get(int id)
        {
            try
            {
                Compra buscada = RepoCompras.FindByID(id);
                if (buscada == null) return NotFound();
                return Ok(buscada); // codigo 200

            }
            catch
            {
                return StatusCode(500);
            }

        }

        // POST api/<ComprasController>
        [HttpPost]
        [Route("alta/importacion")]
        public ActionResult<CompraImportacionDTO> Post([FromBody] CompraImportacionDTO impo)//add
        {
            try
            {
                if (impo == null) return BadRequest();
                var nuevaCompra = new Importacion();
                nuevaCompra.EsDeAmericaDelSur = impo.EsDeAmericaDelSur;
                nuevaCompra.DescripcionSanitaria = impo.DescripcionSanitaria;
                nuevaCompra.FechaCompra = impo.FechaCompra;
                nuevaCompra.TasaBasica = RepoCompras.ObtenerTasaBasica(); 
                nuevaCompra.TasaArancelaria = RepoCompras.ObtenerTasaArancelaria();
                nuevaCompra.CalcularTasaBaseAplicar();
                
                List<ItemCompraPlanta> listaCompra = new List<ItemCompraPlanta>();
                foreach (var itemActual in impo.ItemsPlantasCompradas)
                {
                    Planta plantaBuscada = RepoPlantas.FindByID(itemActual.PlantaId);
                    ItemCompraPlanta itemCompra = new ItemCompraPlanta()
                    {
                        CompraId = impo.Id,
                        PlantaId = itemActual.PlantaId,
                        compra = nuevaCompra,
                        planta = plantaBuscada,
                        Unidades = itemActual.Unidades,
                        PrecioUnitario = itemActual.PrecioUnitario
                    };
                    listaCompra.Add(itemCompra);
                }
                nuevaCompra.ItemsPlantasCompradas = listaCompra;
                nuevaCompra.PrecioTotal = nuevaCompra.CalcularCostoTotal();
                bool ok = RepoCompras.Add(nuevaCompra);
                if (!ok) return Conflict();
                return Created("Get", nuevaCompra);//y eso como seria

//                {
//                    "Id":0,
//    "FechaCompra":"2022-02-15",
//    "ItemsPlantasCompradas":[
//        {
//                        "PlantaId":1,
//            "Unidades":6,
//            "PrecioUnitario":22
//        },
//        {
//                        "PlantaId":3,
//            "Unidades":2,
//            "PrecioUnitario":50
//        }
//    ],
//   "EsDeAmericaDelSur":true,
//    "DescripcionSanitaria":"Planta venenosa"
//}

            }
            catch
            {
                return StatusCode(500);
            }


        }

        [HttpPost]
        [Route("alta/plaza")]
        public ActionResult<CompraPlazaDTO> Post([FromBody] CompraPlazaDTO cpDTO)//add
        {
            try
            {
                if (cpDTO == null) return BadRequest();
                var nuevaCompra = new Plaza();
                nuevaCompra.FechaCompra = cpDTO.FechaCompra;
                List<ItemCompraPlanta> listaCompra = new List<ItemCompraPlanta>();
                foreach (var itemActual in cpDTO.ItemsPlantasCompradas)
                {
                    Planta plantaBuscada = RepoPlantas.FindByID(itemActual.PlantaId);
                    ItemCompraPlanta itemCompra = new ItemCompraPlanta()
                    {
                        CompraId = cpDTO.Id,
                        PlantaId = itemActual.PlantaId,
                        compra = nuevaCompra,
                        planta = plantaBuscada,
                        Unidades = itemActual.Unidades,
                        PrecioUnitario = itemActual.PrecioUnitario
                    };
                    listaCompra.Add(itemCompra);
                }
                nuevaCompra.ItemsPlantasCompradas = listaCompra;
                nuevaCompra.CalcularCostoTotal();
                ////nuevaCompra.ImpuestoCompra = RepoCompras.ObtenerIVA(); al parecer no va. remapear?
                nuevaCompra.TasaIva = RepoCompras.ObtenerIVA();
                nuevaCompra.CostoFlete = cpDTO.CostoFlete;
                nuevaCompra.PrecioTotal = nuevaCompra.CalcularCostoTotal();
                bool ok = RepoCompras.Add(nuevaCompra);
                if (!ok) return Conflict();
                return Created("Get", nuevaCompra);




//                {
//                    "Id":0,
//    "FechaCompra":"2022-01-22",
//    "ItemsPlantasCompradas":[
//        {
//                        "PlantaId":1,
//            "Unidades":6,
//            "PrecioUnitario":22
//        },
//        {
//                        "PlantaId":3,
//            "Unidades":2,
//            "PrecioUnitario":50
//        }
//    ],
//    "CostoFlete":200
//}









            }
            catch
            {
                return StatusCode(500);
            }

        }



        //======== TAL VEZ HAYA QUE HACER UN UPDATE DE IMP y otro de PLAZA
        // PUT api/<ComprasController>/5
        [HttpPut("{id}")]
        public ActionResult<Compra> Put(int id, [FromBody] Compra compra)//update
        {
            try
            {
                if (compra != null && compra.Validar() && id != 0)
                {                
                    compra.Id = id;
                    bool ok = RepoCompras.Update(compra);
                    if (!ok) return Conflict();
                    return Ok(compra);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch
            {
                return StatusCode(500);
            }
        }




        // DELETE api/<ComprasController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id == 0) return BadRequest();
            try
            {
                Compra c = RepoCompras.FindByID(id);
                if (c == null) return NotFound();

                //bool ok = RepoCompras.Remove(id);
                //if (!ok) return Conflict();

                return NoContent(); // Codigo 204 (exito pero no se devulve nada)
            }
            catch
            {
                return StatusCode(500);
            }
             
        }

        [HttpGet("{tipoid}")]
        [Route("buscando/PorTipoPlanta")]
        public ActionResult<IEnumerable<MostrarCompraDTO>> GetCTipo([FromQuery]int tipoid)//findall
        {
            try
            {
                var compras = RepoCompras.ListarComprasPorTipoDePlanta(tipoid);
                if (compras == null) return BadRequest();
                return Ok(compras);
            }
            catch (Exception ex)
            {

                return StatusCode(500);
            }


            //localhost:33026/api/compras/buscando/PorTipoPlanta?tipoid=2

        }




    }
}

