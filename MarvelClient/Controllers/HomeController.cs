using MarvelClient.Models;
using MarvelClient.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringLocalizer _stringLocalizer;
        private readonly IMarvelService _marvelService;

        public HomeController(IStringLocalizer<HomeController> stringLocalizer, IMarvelService marvelService)
        {
            _stringLocalizer = stringLocalizer;
            _marvelService = marvelService;
        }

        public async Task<IActionResult> Index(string heroId)
        {
            try
            {
                if (string.IsNullOrEmpty(heroId))
                    return View();

                if (!int.TryParse(heroId, out _))
                    throw new Exception(_stringLocalizer["HERO_ID_INVALID"]);
                    

                Hero hero = await _marvelService.FindHeroById(int.Parse(heroId));
                return View(hero);
            }
            catch (Exception e)
            {
                ViewBag.ErrorMessage = e.Message;
                return View();
            }
        }
    }
}
