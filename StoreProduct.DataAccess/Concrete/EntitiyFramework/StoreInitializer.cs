using StoreProduct.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProduct.DataAccess.Concrete.EntitiyFramework
{
    public class StoreInitializer : CreateDatabaseIfNotExists<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            List<Category> categories = new List<Category>() {
                new Category(){ Name="Kategori 1"},
                 new Category(){ Name="Kategori 2"},
                new Category(){ Name="Kategori 3"},
                  new Category(){ Name="Kategori 4"},
                new Category(){ Name="Kategori 5"},
                new Category(){ Name="Kategori 6"},
                   new Category(){ Name="Kategori 7"}
            };
            foreach (var item in categories)
            {
                context.Categories.Add(item);
            }
            context.SaveChanges();
            List<Product> product = new List<Product>()
            {
                new Product(){  Name="Ürün 1", Description="Açıklama 1", Image="1.jpg", isApproved=true, isFeatured=false, isHome=true, Price=100, CategoryId=1  },
                new Product(){  Name="Ürün 2", Description="Açıklama 2", Image="2.jpg",isApproved=true, isFeatured=true, isHome=true, Price=200, CategoryId=1  },
                new Product(){  Name="Ürün 3", Description="Açıklama 3", Image="3.jpg",isApproved=true, isFeatured=true, isHome=true, Price=300, CategoryId=1  },
                new Product(){  Name="Ürün 4", Description="Açıklama 4", Image="4.jpg", isApproved=true, isFeatured=true,isHome=false, Price=400, CategoryId=2  },
                new Product(){  Name="Ürün 5", Description="Açıklama 5", Image="5.jpg",isApproved=true, isFeatured=true, isHome=true, Price=500, CategoryId=2  },
                new Product(){  Name="Ürün 6", Description="Açıklama 6", Image="6.jpg",isApproved=false, isFeatured=false, isHome=false, Price=600, CategoryId=2  },
                new Product(){  Name="Ürün 7", Description="Açıklama 7", Image="7.jpg", isApproved=true, isFeatured=true,isHome=true, Price=700, CategoryId=3  },
                 new Product(){  Name="Ürün 8", Description="Açıklama 8", Image="8.jpg", isApproved=true, isFeatured=true,isHome=true, Price=700, CategoryId=3  },
                  new Product(){  Name="Ürün 9", Description="Açıklama 9", Image="9.jpg",isApproved=true, isFeatured=true, isHome=true, Price=700, CategoryId=3  },
                   new Product(){  Name="Ürün 10", Description="Açıklama 10", Image="10.jpg",isApproved=true, isFeatured=true, isHome=true, Price=700, CategoryId=4  },
                    new Product(){  Name="Ürün 11", Description="Açıklama 11", Image="11.jpg",isApproved=true, isFeatured=true, isHome=false, Price=700, CategoryId=4  },
                     new Product(){  Name="Ürün 12", Description="Açıklama 12", Image="12.jpg", isApproved=false, isFeatured=true,isHome=true, Price=700, CategoryId=4  },
                      new Product(){  Name="Ürün 13", Description="Açıklama 13", Image="13.jpg",isApproved=true, isFeatured=true, isHome=true, Price=700, CategoryId=5  },
                       new Product(){  Name="Ürün 14", Description="Açıklama 14", Image="14.jpg", isApproved=true, isFeatured=false,isHome=true, Price=1700, CategoryId=5  },
                        new Product(){  Name="Ürün 15", Description="Açıklama 15", Image="15.jpg",isApproved=true, isFeatured=true, isHome=true, Price=2700, CategoryId=5  },
                         new Product(){  Name="Ürün 16", Description="Açıklama 16", Image="16.jpg",isApproved=true, isFeatured=true, isHome=false, Price=3700, CategoryId=6  },
                          new Product(){  Name="Ürün 17", Description="Açıklama 17", Image="17.jpg",isApproved=false, isFeatured=false, isHome=true, Price=500, CategoryId=6  },
                           new Product(){  Name="Ürün 18", Description="Açıklama 18", Image="18.jpg",isApproved=true, isFeatured=true, isHome=true, Price=400, CategoryId=6  },
                            new Product(){  Name="Ürün 19", Description="Açıklama 19", Image="19.jpg",isApproved=true, isFeatured=true, isHome=false, Price=700, CategoryId=7  },
                             new Product(){  Name="Ürün 20", Description="Açıklama 20", Image="20.jpg",isApproved=true, isFeatured=true, isHome=true, Price=700, CategoryId=7  },
                              new Product(){  Name="Ürün 21", Description="Açıklama 21", Image="21.jpg",isApproved=true, isFeatured=true, isHome=true, Price=700, CategoryId=7  }

            };
            foreach (var item in product)
            {
                context.Products.Add(item);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
