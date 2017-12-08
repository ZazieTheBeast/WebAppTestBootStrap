using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppTestBootStrap.Models;
using WebAppTestBootStrap.ViewModels;

namespace WebAppTestBootStrap.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPictureRepository _pictureRepository;
        public HomeController(IPictureRepository pictureRepository)
        {
            _pictureRepository = pictureRepository;
        }
        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PicturesOfTheWeek = _pictureRepository.PicturesOfTheWeek
            };
            return View(homeViewModel);
        }
    }
}
