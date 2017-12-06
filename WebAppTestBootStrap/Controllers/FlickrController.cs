using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace WebAppTestBootStrap.Controllers
{
    public class FlickrController
    {
        static void GetJson()
        {
            var client = new WebClient();
            var text = client.DownloadString("https://api.flickr.com/services/rest/?&method=flickr.people.getPublicPhotos&api_key=ef92059160e1c024e7190f9f6849c2c3&user_id=147822180@N02&format=json");
            FlickrController flickrController = JsonConvert.DeserializeObject<FlickrController>(text);
        }
    }
}
