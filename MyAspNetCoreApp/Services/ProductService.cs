using MyAspNetCoreApp.Models;

namespace MyAspNetCoreApp.Services;

public class ProductService : List<ProductModel>
{
    public ProductService()
    {
        this.AddRange(new ProductModel[]{
            new ProductModel() {Id = 1, Name = "Iphone", Price = 1000},
            new ProductModel() {Id = 2, Name = "Samsung", Price = 800},
            new ProductModel() {Id = 3, Name = "Sony", Price = 700},
            new ProductModel() {Id = 4, Name = "Nokia", Price = 600}
        });
    }
}