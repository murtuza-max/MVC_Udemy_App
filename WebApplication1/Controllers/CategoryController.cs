using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class CategoryController : Controller
{
    private readonly ApplicationDbContext _db;
    public CategoryController(ApplicationDbContext db)
    {
         _db = db;
    }
    // GET
    public IActionResult Index()
    {
        var categoryList = _db.Categories.ToList();
        return View(categoryList);
    }
    
    public IActionResult Create()
    {
        return View();
    }
}