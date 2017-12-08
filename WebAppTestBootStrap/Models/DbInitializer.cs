using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppTestBootStrap.Models
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            AppDbContext context = applicationBuilder.ApplicationServices.GetRequiredService<AppDbContext>();
            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Pictures.Any())
            {
                context.AddRange
                (
                    new Picture { Name = "name here", ShortDescription = "short desc here", LongDescription = "long desc here", Category = Categories["Macro"], ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", IsPictureOfTheWeek = true, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg" },
                    new Picture { Name = "name here2", ShortDescription = "short desc here", LongDescription = "long desc here", Category = Categories["Landscapes"], ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", IsPictureOfTheWeek = true, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg" }
                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Landscapes" },
                        new Category { CategoryName = "Portraits" },
                        new Category { CategoryName = "Macro" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}
