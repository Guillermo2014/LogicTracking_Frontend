using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frontend_TDP.API;
using Frontend_TDP.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace Frontend_TDP.Controllers
{
    public class RepresentanteController : Controller
    {
        Backend _api = new Backend();

        // GET: MedicamentosController
        public async Task<IActionResult> Index()
        {
            List<Representante> representantes = new List<Representante>();
            HttpClient client = _api.Initial();
            HttpResponseMessage response = await client.GetAsync("representantes");

            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                representantes = JsonConvert.DeserializeObject<List<Representante>>(result);
            }
            return View(representantes);
        }



        public async Task<IActionResult> Create()
        {
            List<Representante> representantes = new List<Representante>();


            HttpClient client = _api.Initial();
            HttpResponseMessage response = await client.GetAsync("representantes");


            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                representantes = JsonConvert.DeserializeObject<List<Representante>>(result);
            }

            return View();
        }

        [HttpPost]
        public IActionResult Create(Representante representante)
        {

            HttpClient client = _api.Initial();
            var postTask = client.PostAsJsonAsync<Representante>("representantes", representante);
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
