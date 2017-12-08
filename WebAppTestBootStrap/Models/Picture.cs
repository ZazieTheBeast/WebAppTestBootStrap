namespace WebAppTestBootStrap.Models
{
    public class Picture
    {
        public int PictureId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsPictureOfTheWeek { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}