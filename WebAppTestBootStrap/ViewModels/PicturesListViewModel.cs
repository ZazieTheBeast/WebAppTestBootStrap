using System.Collections.Generic;
using WebAppTestBootStrap.Models;

namespace WebAppTestBootStrap.ViewModels
{
    public class PicturesListViewModel
    {
        public IEnumerable<Picture> Pictures { get; set; }
        public string CurrentCategory { get; set; }
    }
}