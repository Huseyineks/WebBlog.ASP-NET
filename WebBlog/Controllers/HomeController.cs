using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebBlog.DataAccesLayer.Data;
using WebBlog.Entitiy.Entities;
using WebBlog.Models;

namespace WebBlog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger,ApplicationDbContext _db)
        {
            _context = _db;
            _logger = logger;
        }

        public IActionResult Index()
        {
           

            return View();
        }

        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
