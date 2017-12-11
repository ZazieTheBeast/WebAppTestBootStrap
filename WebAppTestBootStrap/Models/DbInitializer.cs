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
                    new Picture { Name = "Chruch @ blink cincinnati", ShortDescription = "Chruch @ blink cincinnati", LongDescription = "Chruch @ blink cincinnati", Category = Categories["Cityscapes"], ImageUrl = "./images/big/24101531268_8f5ed620b8_k.jpg", IsPictureOfTheWeek = true, ImageThumbnailUrl = "./images/thumbs/24101531268_db7ff00d0f_m.jpg" },
                    new Picture { Name = "Twilight in Newport", ShortDescription = "Twilight in Newport", LongDescription = "Twilight in Newport", Category = Categories["Landscapes"], ImageUrl = "./images/big/24787103228_0a866c1c28_k.jpg", IsPictureOfTheWeek = true, ImageThumbnailUrl = "./images/thumbs/24787103228_d0d0bb2da1_z.jpg" },
                    new Picture { Name = "Twilight Cincinnati Skyline", ShortDescription = "Twilight Cincinnati Skyline", LongDescription = "Twilight Cincinnati Skyline - Shot w/ Rokinon 16mm", Category = Categories["Cityscapes"], ImageUrl = "./images/big/33465620483_796756d995_k.jpg", IsPictureOfTheWeek = true, ImageThumbnailUrl = "./images/thumbs/33465620483_1ae44f86d9_z.jpg" },
                    new Picture { Name = "Queen City Twilight", ShortDescription = "Queen City Twilight", LongDescription = "Queen City Twilight - Downtown Cincinnati @ Twilight Shot w/ Rokinon 16mm f/2.0", Category = Categories["Cityscapes"], ImageUrl = "./images/big/33904338225_4879f82760_k.jpg", IsPictureOfTheWeek = true, ImageThumbnailUrl = "./images/thumbs/33904338225_ac34c7778e_z.jpg" },
                    new Picture { Name = "Quiet Night at Newport on the Levee", ShortDescription = "Quiet Night at Newport on the Levee", LongDescription = "Quiet Night at Newport on the Levee", Category = Categories["Architecture"], ImageUrl = "./images/big/34144841241_cf40d09ecc_k.jpg", IsPictureOfTheWeek = true, ImageThumbnailUrl = "./images/thumbs/34144841241_6c0bb79d58_z.jpg" },
                    new Picture { Name = "Cincinnati Reds Fireworks", ShortDescription = "Cincinnati Reds Fireworks", LongDescription = "Cincinnati Reds Fireworks", Category = Categories["Cityscapes"], ImageUrl = "./images/big/34250963584_b680ae4781_k.jpg", IsPictureOfTheWeek = true, ImageThumbnailUrl = "./images/thumbs/34250963584_b342ba3686_z.jpg" },
                    new Picture { Name = "Night time but no milky way", ShortDescription = "Night time but no milky way", LongDescription = "Night time but no milky way", Category = Categories["Landscapes"], ImageUrl = "./images/big/34276426705_fde9ade519_k.jpg", IsPictureOfTheWeek = true, ImageThumbnailUrl = "./images/thumbs/34276426705_c2fa5c9dba_z.jpg" },
                    new Picture { Name = "Cincinnati Reds Fireworks", ShortDescription = "Cincinnati Reds Fireworks", LongDescription = "Cincinnati Reds Fireworks", Category = Categories["Cityscapes"], ImageUrl = "./images/big/35054789126_9095813065_k.jpg", IsPictureOfTheWeek = true, ImageThumbnailUrl = "./images/thumbs/35054789126_2c7d1ed7b6_z.jpg" },
                    new Picture { Name = "Irvine Kentucky Milky Way and Shooting Star", ShortDescription = "Irvine Kentucky Milky Way and Shooting Star", LongDescription = "Irvine Kentucky Milky Way and Shooting Star", Category = Categories["Astrophotography"], ImageUrl = "./images/big/35650747182_a2b213b150_k.jpg", IsPictureOfTheWeek = true, ImageThumbnailUrl = "./images/thumbs/35650747182_149a4ff1b3_z.jpg" },
                    new Picture { Name = "Bernie Sanders in Covington, KY 9/7/2017", ShortDescription = "Bernie Sanders in Covington, KY 9/7/2017", LongDescription = "Bernie Sanders in Covington, KY 9/7/2017", Category = Categories["People"], ImageUrl = "./images/big/35719274492_2e32806030_k.jpg", IsPictureOfTheWeek = true, ImageThumbnailUrl = "./images/thumbs/35719274492_6be1cdc020_z.jpg" },
                    new Picture { Name = "Smale Park in Cincinnati", ShortDescription = "Smale Park in Cincinnati", LongDescription = "Smale Park in Cincinnati", Category = Categories["Cityscapes"], ImageUrl = "./images/big/35719276282_18511a1452_k.jpg", IsPictureOfTheWeek = true, ImageThumbnailUrl = "./images/thumbs/35719276282_ce08b38efa_z.jpg" },
                    new Picture { Name = "Bernie Sanders in Covington, KY 9/7/2017", ShortDescription = "Bernie Sanders in Covington, KY 9/7/2017", LongDescription = "Bernie Sanders in Covington, KY 9/7/2017", Category = Categories["People"], ImageUrl = "./images/big/35847714996_d09795bd88_k.jpg", IsPictureOfTheWeek = true, ImageThumbnailUrl = "./images/thumbs/35847714996_38c1bb8978_z.jpg" },
                    new Picture { Name = "Strawberry Moon in Cincinnati", ShortDescription = "Strawberry Moon in Cincinnati", LongDescription = "Strawberry Moon in Cincinnati", Category = Categories["Cityscapes"], ImageUrl = "./images/big/35847719836_a4eda13b05_k.jpg", IsPictureOfTheWeek = true, ImageThumbnailUrl = "./images/thumbs/35847714996_38c1bb8978_z.jpg" },
                    new Picture { Name = "Bernie Sanders in Covington, KY 9/7/2017", ShortDescription = "Bernie Sanders in Covington, KY 9/7/2017", LongDescription = "Bernie Sanders in Covington, KY 9/7/2017", Category = Categories["People"], ImageUrl = "./images/big/35847844236_235c7d529c_k.jpg", IsPictureOfTheWeek = true, ImageThumbnailUrl = "./images/thumbs/35847844236_9722c16a7f_z.jpg" },
                    new Picture { Name = "American Lady Butterfly (w/ vintage lens)", ShortDescription = "American Lady Butterfly (w/ vintage lens)", LongDescription = "American Lady Butterfly (w/ vintage lens) - Taken with a Helios 44m @ F/2.0", Category = Categories["Macro"], ImageUrl = "./images/big/35886202454_34d84f2f17_k.jpg", IsPictureOfTheWeek = true, ImageThumbnailUrl = "./images/thumbs/35886202454_6e2d4c79fd_z.jpg" },
                    new Picture { Name = "Silver Spoon Rings", ShortDescription = "Silver Spoon Rings", LongDescription = "Silver Spoon Rings @ Petefest 2017 in Louisville, KY", Category = Categories["Macro"], ImageUrl = "./images/big/36358707684_a28e863357_k.jpg", IsPictureOfTheWeek = true, ImageThumbnailUrl = "./images/thumbs/36358707684_acb6484382_z.jpg" },
                    new Picture { Name = "Sparkly Orbs", ShortDescription = "Sparkly Orbs", LongDescription = "Sparkly Orbs @ Blink Cincinnati", Category = Categories["Things"], ImageUrl = "./images/big/37899310586_7caeb17636_k.jpg", IsPictureOfTheWeek = true, ImageThumbnailUrl = "./images/thumbs/37899310586_87688050ab_z.jpg" },
                    new Picture { Name = "Kentucky Milky Way", ShortDescription = "Kentucky Milky Way", LongDescription = "Kentucky Milky Way - The night sky was cooperating with me on Friday. Right on the edge of the Appalachian mountains in Kentucky at The Moonshiner's Ball music festival.", Category = Categories["Astrophotography"], ImageUrl = "./images/big/34447226100_9f30e93231_k.jpg", IsPictureOfTheWeek = true, ImageThumbnailUrl = "./images/thumbs/34447226100_78d1cfba92_z.jpg" },
                    new Picture { Name = "Festival Facepaint", ShortDescription = "Festival Facepaint", LongDescription = "Festival Facepaint @ Petefest 2017 in Louisville, KY", Category = Categories["People"], ImageUrl = "./images/big/37195482305_afa26c7ded_k.jpg", IsPictureOfTheWeek = true, ImageThumbnailUrl = "./images/thumbs/37195482305_5056a6846c_z.jpg" },
                    new Picture { Name = "Brother's Newport, Newport, KY", ShortDescription = "Brother's Newport, Newport, KY", LongDescription = "Brother's Newport, Newport, KY - Taken with Rokinon 16mm @ f/16", Category = Categories["Cityscapes"], ImageUrl = "./images/big/37660315874_4e17adc1ed_h.jpg", IsPictureOfTheWeek = true, ImageThumbnailUrl = "./images/thumbs/37660315874_d2e78198fb_z.jpg" }
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
                        new Category { CategoryName = "Macro" },
                        new Category { CategoryName = "People" },
                        new Category { CategoryName = "Cityscapes" },
                        new Category { CategoryName = "Astrophotography" },
                        new Category { CategoryName = "Things" },
                        new Category { CategoryName = "Architecture" }
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
