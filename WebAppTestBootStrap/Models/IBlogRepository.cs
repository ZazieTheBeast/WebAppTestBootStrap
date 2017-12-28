using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppTestBootStrap.BlogObjects;

namespace WebAppTestBootStrap.Models
{
    public interface IBlogRepository
    {
        IList<Post> Posts(int pageNo, int pageSize);
        int TotalPosts();
    }
}
