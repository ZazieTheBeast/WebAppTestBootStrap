using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Web
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using WebAppTestBootStrap.Models;

namespace WebAppTestBootStrap.Controllers
{
    public class FlickrController : Controller
    {
        //public Uri ImgUrl
        //{
        //    get
        //    {
        //        return new Uri(string.Format("http://farm{0}.static.flickr.com/{1}/{2}_{3}.jpg", farm, server, id, secret));
        //    }
        //}
        public async Task<ActionResult> GetImagesAsync()
        {
            string provideUri = "https://api.flickr.com/services/rest/?&method=flickr.people.getPublicPhotos&api_key=ef92059160e1c024e7190f9f6849c2c3&user_id=147822180@N02&format=json";
            HttpClient client = new HttpClient();
            string jsonstring = await client.GetStringAsync(provideUri);
            var obj = JsonConvert.DeserializeObject<RootObject>(jsonstring);
            return View(obj.photos.photo);
        }
    }
}