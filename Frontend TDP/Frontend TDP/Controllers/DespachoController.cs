using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Frontend_TDP.API;
using Frontend_TDP.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Frontend_TDP.Controllers
{
    public class DespachoController : Controller
    {
        Backend _api = new Backend();
        // GET: DespachoController
        public async Task<IActionResult> Index()
        {
            List<Despacho> despachos = new List<Despacho>();
            HttpClient client = _api.Initial();
            HttpResponseMessage response = await client.GetAsync("despachos");

            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                despachos = JsonConvert.DeserializeObject<List<Despacho>>(result);
            }
            return View(despachos);
        }

        // GET: DespachoController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            List<Despacho> despachos = new List<Despacho>();
            HttpClient client = _api.Initial();
            HttpResponseMessage response = await client.GetAsync("despachos");

            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                despachos = JsonConvert.DeserializeObject<List<Despacho>>(result);
            }

            Despacho desdetail = new Despacho();

            for (int i = 0; i < despachos.Count(); i++)
            {
                if (id == despachos[i].idDespacho)
                {
                    desdetail = despachos[i];
                }
            }

            return View(desdetail);
        }

        // POST: DespachoController/Create
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

        // GET: DespachoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DespachoController/Edit/5
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

        // GET: DespachoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DespachoController/Delete/5
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
