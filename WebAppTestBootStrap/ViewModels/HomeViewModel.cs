using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppTestBootStrap.Models;

namespace WebAppTestBootStrap.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Picture> PicturesOfTheWeek { get; set; }
    }
}
