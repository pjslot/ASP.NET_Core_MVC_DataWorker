using ASP.NET_Core_MVC_DataWorker.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP.NET_Core_MVC_DataWorker.Controllers
{
    
    public class HomeController : Controller
    {
      

        public IActionResult Index()
        {
            //готовим данные для представления
            ViewData["Title"] = "ВИА";
            var bands = MemoryDb.Bands;

            //передача управления представлению
            return View(bands);
        }

        //контроллеры создания банды
        [HttpGet]
        public IActionResult Create()
        {
            Band band = new Band();
            return View(band);
        }
        [HttpPost]
        public IActionResult Create(Band band)
        {           
            MemoryDb.Bands.Add(band);
            //генерация ID
            MemoryDb.Bands[MemoryDb.Bands.Count-1].Id = MemoryDb.Bands.Count-1;
            return RedirectToAction("Index", "Home"); 
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}