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
            MemoryDb.Bands[MemoryDb.Bands.Count-1].Id = MemoryDb.Bands[MemoryDb.Bands.Count - 2].Id+1;
            return RedirectToAction("Index", "Home"); 
        }

        //контроллеры удаления банды
        [HttpGet]
        public IActionResult Delete(Band band)
        {
            return View(band);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            for (int i=0; i<MemoryDb.Bands.Count; i++)
            {
                if (MemoryDb.Bands[i].Id==id) MemoryDb.Bands.Remove(MemoryDb.Bands[i]);
            }        
            return RedirectToAction("Index", "Home");
        }

        //контроллеры редактирования банды
        [HttpGet]
        public IActionResult Edit(Band band)
        {
            return View(band);
        }
        [HttpPost]
        public IActionResult Edit(Band band, int id)
        {
            for (int i = 0; i < MemoryDb.Bands.Count; i++)
            {
                if (MemoryDb.Bands[i].Id == band.Id)
                {
                    MemoryDb.Bands.Remove(MemoryDb.Bands[i]);
                    MemoryDb.Bands.Add(band);                
                } 
            }
            //сортируем по ID что б строчки не шли вразлёт
            var sorted = MemoryDb.Bands.OrderBy(o => o.Id).ToList();
            MemoryDb.Bands = sorted;
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