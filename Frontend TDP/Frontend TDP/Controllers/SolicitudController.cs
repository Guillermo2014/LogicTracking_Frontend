using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frontend_TDP.API;
using Frontend_TDP.Models;
using System.Net.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Frontend_TDP.Controllers
{
    public class SolicitudController : Controller
    {

        Backend _api = new Backend();
        public async Task<IActionResult> Index()
        {
            List<Solicitud> solicituds = new List<Solicitud>();
            HttpClient client = _api.Initial();
            HttpResponseMessage response = await client.GetAsync("despachos");

            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                solicituds = JsonConvert.DeserializeObject<List<Solicitud>>(result);
            }
            return View(solicituds);
        }



        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Solicitud solicitud)
        {

            HttpClient client = _api.Initial();
            var postTask = client.PostAsJsonAsync<Solicitud>("despachos", solicitud);
            postTask.Wait();
            var result = postTask.Result;

            if (result.IsSuccessStatusCode)
            {
                ViewBag.Message = "El medicamento se registro correctamente";
                return RedirectToAction("Index");

            }
            ViewBag.Message = "Error al registrar";
            return View();
        }
    }
}
