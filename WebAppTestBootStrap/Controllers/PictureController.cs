using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppTestBootStrap.Models;
using WebAppTestBootStrap.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppTestBootStrap.Controllers
{
    public class PictureController : Controller
    {
        private readonly IPictureRepository _pictureRepository;
        private readonly ICategoryRepository _categoryRepository;
        public PictureController(IPictureRepository pictureRepository, ICategoryRepository categoryRepository)
        {
            _pictureRepository = pictureRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(string category)
        {
            IEnumerable<Picture> pictures;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                pictures = _pictureRepository.Pictures.OrderBy(p => p.PictureId);
                currentCategory = "All pictures";
            }
            else
            {
                pictures = _pictureRepository.Pictures.Where(p => p.Category.CategoryName == category)
                   .OrderBy(p => p.PictureId);
                currentCategory = _categoryRepository.Categories.FirstOrDefault(c => c.CategoryName == category).CategoryName;
            }

            return View(new PicturesListViewModel
            {
                Pictures = pictures,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Details(int id)
        {
            var picture = _pictureRepository.GetPictureById(id);
            if (picture == null)
                return NotFound();

            return View(picture);
        }

    }
}
