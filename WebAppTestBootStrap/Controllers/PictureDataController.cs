using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppTestBootStrap.ViewModels;
using WebAppTestBootStrap.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAppTestBootStrap.Controllers
{
    [Route("api/[controller]")]
    public class PictureDataController : Controller
    {
        private readonly IPictureRepository _pictureRepository;

        public PictureDataController(IPictureRepository pictureRepository)
        {
            _pictureRepository = pictureRepository;
        }

        [HttpGet]
        public IEnumerable<PicturesListViewModel> LoadMorePictures()
        {
            IEnumerable<Picture> dbPictures = null;

            dbPictures = _pictureRepository.Pictures.OrderBy(p => p.PictureId).Take(10);

            List<PicturesListViewModel> pictures = new List<PicturesListViewModel>();

            foreach (var dbPicture in dbPictures)
            {
                pictures.Add(MapDbPictureToPictureViewModel(dbPicture));
            }
            return pictures;
        }
        private PicturesListViewModel MapDbPictureToPictureViewModel(Picture dbPicture)
        {
            return new PicturesListViewModel()
            {
                PictureId = dbPicture.PictureId,
                Name = dbPicture.Name,
                ShortDescription = dbPicture.ShortDescription,
                ImageThumbnailUrl = dbPicture.ImageThumbnailUrl
            };
        }
    }
}
