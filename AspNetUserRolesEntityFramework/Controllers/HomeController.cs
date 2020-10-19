using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AspNetUserRolesEntityFramework.Models;

//Week 12 Tutorial
using AspNetUserRolesEntityFramework.Data;
using Microsoft.EntityFrameworkCore;



namespace AspNetUserRolesEntityFramework.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;//Week 12 Tutorial

        //Week 12 Tutorial
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Privacy()
        {
            if (!User.Identity.IsAuthenticated)
            {
                foreach (var post in _context.DiscussionForum)
                {
                    post.canIncreaseLike = true;
                }
                await _context.SaveChangesAsync();
            }

            var allDiscussions = from result in _context.DiscussionForum
                                 orderby result.PostDate descending
                                 select result;

            return View(await allDiscussions.ToListAsync());
            //return View(await _context.DiscussionForum.ToListAsync());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
