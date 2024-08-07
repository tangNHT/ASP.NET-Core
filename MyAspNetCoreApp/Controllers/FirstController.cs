using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyAspNetCoreApp.Models;
using MyAspNetCoreApp.Services;

namespace MyAspNetCoreApp.Controllers;

public class FirstController : Controller
{
    private readonly ILogger<FirstController> _logger;
    private readonly ProductService _productService;
    public FirstController(ILogger<FirstController> logger, ProductService productService){
        _logger = logger;
        _productService = productService;
    }
    public string Index()
    {
        _logger.LogInformation("Index Action");
        return "Toi la Index cua First";
    }
    public void Nothing(){
        _logger.LogInformation("Nothing Action");
        Response.Headers.Append("Hi","xin chao cac ban");
    }

    public IActionResult Bird(){
        string filePath = Path.Combine("C:", "ASP.NET_Core", "MyAspNetCoreApp", "Files", "Bird.png");
        var bytes = System.IO.File.ReadAllBytes(filePath);

        return File(bytes, "image/jpg");
    }

    public IActionResult ViewProduct(int? id)
    {
        var products = _productService.Where(p => p.Id == id).FirstOrDefault();
        if (products == null)
            return NotFound();
        return Content($"San pham ID = {id}");
    }
}