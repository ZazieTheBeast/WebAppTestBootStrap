using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppTestBootStrap.Models
{
    public class Photos
    {
        public int page { get; set; }
        public int pages { get; set; }
        public int perpage { get; set; }
        public int total { get; set; }
        public List<Photo> photo { get; set; }
    }
}
