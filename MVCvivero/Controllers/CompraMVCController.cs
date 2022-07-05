using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Dominio.EntidadesNegocio;
using claseDTOS;
using Newtonsoft.Json;
using Manejadores;
using MVCvivero.Models;

namespace MVCvivero.Controllers
{
    public class CompraMVCController : Controller
    {
        public IManejadorPlanta ManejadorPlanta { get; set; }
        
        public CompraMVCController(IManejadorPlanta iManejadorP)
        //el IWebHostEnvironment es para poder obtener la ruta a la carpeta root, tiene using
        {
            ManejadorPlanta = iManejadorP;
        }
        // GET: CompraController
        public ActionResult Index()
        {
            
           IEnumerable<TipoPlanta> ListaTipoPlanta = ManejadorPlanta.ObtenerTiposPlantas();
            ViewBag.ListPlanta = ListaTipoPlanta;
            return View(ViewBag.ListPlanta);
        }
        

        [HttpPost]
        public ActionResult ListarComprasPorTipoDePlanta(int tipoId)
        {
            HttpClient compras = new HttpClient();
            Task<HttpResponseMessage> tarea = compras.GetAsync("Http://localhost:33026/api/compras/buscando/PorTipoPlanta?tipoid="+ tipoId);
            tarea.Wait();

            if (!tarea.Result.IsSuccessStatusCode) return View();
            Task<string> resultado = tarea.Result.Content.ReadAsStringAsync();
            resultado.Wait();
            string resultadoDeREsultado = resultado.Result;
            List<MostrarCompraDTO> comp = JsonConvert.DeserializeObject<List<MostrarCompraDTO>>(resultadoDeREsultado);
            ViewBag.Error = "";

            if (comp.Count == 0)
            {
                ViewBag.Error = "No se encontro ese tipo de planta";
                return View(comp);
            }

            foreach (var compraDTOActual in comp)
            {
                foreach (var itemPC in compraDTOActual.ItemsPlantasCompradas)
                {
                    itemPC.NombreCientifico = ManejadorPlanta.ObtenerPlantaPorId(itemPC.PlantaId).NombreCientifico;

                }

            }

            return View(comp);
        }

        // GET: CompraController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CompraController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CompraController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CompraController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CompraController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CompraController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CompraController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
