using System.Collections.Generic;

namespace WebAppTestBootStrap.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}