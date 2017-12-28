using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppTestBootStrap.BlogObjects;
using WebAppTestBootStrap.Models;

namespace WebAppTestBootStrap.ViewModels
{
    public class BlogListViewModel
    {
        public BlogListViewModel(IBlogRepository _blogRepository, int p)
        {
            Posts = _blogRepository.Posts(p - 1, 10);
            TotalPosts = _blogRepository.TotalPosts();
        }
        public IList<Post> Posts { get; private set; }
        public int TotalPosts { get; private set; }
    }
}
