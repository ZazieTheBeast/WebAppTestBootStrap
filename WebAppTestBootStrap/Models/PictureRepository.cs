using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppTestBootStrap.Models
{
    public class PictureRepository : IPictureRepository
    {
        private readonly AppDbContext _appDbContext;

        public PictureRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Picture> Pictures
        {
            get
            {
                return _appDbContext.Pictures.Include(c => c.Category);
            }
        }

        public IEnumerable<Picture> PicturesOfTheWeek
        {
            get
            {
                return _appDbContext.Pictures.Include(c => c.Category).Where(p => p.IsPictureOfTheWeek);
            }
        }

        public Picture GetPictureById(int pictureId)
        {
            return _appDbContext.Pictures.FirstOrDefault(p => p.PictureId == pictureId);
        }
    }
}
