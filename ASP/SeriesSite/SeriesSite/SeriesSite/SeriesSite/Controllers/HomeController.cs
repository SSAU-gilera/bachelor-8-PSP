using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SeriesSite.Data;
using SeriesSite.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SeriesSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDataService _dataService;

        public HomeController(ILogger<HomeController> logger, IDataService dataService)
        {
            _logger = logger;
            _dataService = dataService;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Catalog()
        {
            var listSerials = _dataService.GetSerials();
            ViewBag.ListSerials = listSerials;

            var listImages = _dataService.GetSerialsImages();
            ViewBag.ListImages = listImages;
            ViewBag.Message = "";

            return View();
        }

        [HttpPost]
        public IActionResult Catalog(List<string> genre, string country)
        {
            var listImages = _dataService.GetSerialsImages();
            ViewBag.ListImages = listImages;
            ViewBag.Message = "";
            try
            {
                var listSerials = _dataService.GetFilteredSerials(genre, country);
                if (listSerials.Count == 0)
                {
                    ViewBag.Message = "Не найдено сериалов по запросу.";
                    ViewBag.ListSerials = _dataService.GetSerials();
                }
                else
                {
                    ViewBag.ListSerials = listSerials;
                    List<string> listImage = new List<string>();
                    for (int i = 0; i < listSerials.Count; i++)
                    {
                        List<string> listImg = (_dataService.GetSerialImages(listSerials[i].Id));
                        listImage.AddRange(listImg);
                    }
                    ViewBag.ListImages = listImage;
                }
            }
            catch (Exception e)
            {
                ViewBag.Message = "Невозможно отфильтровать.";
                ViewBag.ListSerials = _dataService.GetSerials();
            }

            return View();
        }

        public IActionResult AboutSeries()
        {
            return View();
        }


        public IActionResult Object(int id)
        {
            var s = _dataService.GetSerialInfo(id);
            ViewBag.Serial = s;
            var listImages = _dataService.GetSerialImages(id);
            ViewBag.ListImages = listImages;

            return View();
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

        [HttpPost]
        public IActionResult AddSeries(string Name, string OriginalName, int Year, string Country, string Genre, string Producer, string Budget, string Premiere,
            string Age, string Duration, string TotalTime, string Rating, string description)
        {
            if (Name != null)
            {
                if (_dataService.AddSeries(Name, OriginalName, Year, Country, Genre, Producer, Budget, Premiere,
             Age, Duration, TotalTime, Rating, description))
                {
                    ViewBag.Message = "Сериал добавлен.";
                }
                else { ViewBag.Message = "."; }
            }
            return View();

        }
        [HttpGet]
        public IActionResult AddSeries()
        {
            ViewBag.Message = "";
            return View();
        }
    }
}
