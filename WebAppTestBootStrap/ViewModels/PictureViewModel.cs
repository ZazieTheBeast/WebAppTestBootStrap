using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppTestBootStrap.ViewModels
{
    public class PicturesViewModel
    {
        public int PictureId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string ImageThumbnailUrl { get; set; }
    }
}
