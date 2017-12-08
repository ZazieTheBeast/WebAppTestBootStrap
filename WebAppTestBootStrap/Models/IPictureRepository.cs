using System.Collections.Generic;

namespace WebAppTestBootStrap.Models
{
    public interface IPictureRepository
    {
        IEnumerable<Picture> Pictures { get; }
        IEnumerable<Picture> PicturesOfTheWeek { get; }
        Picture GetPictureById(int pictureId);
    }
}