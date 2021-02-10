using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using aspnetapp.Model;
using aspnetapp.Database;

namespace aspnetapp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context, ILogger<IndexModel> logger)
        {
            _logger = logger;

            _context = context;

            // //TODO: test working
            // _context.Tests.Add(new Test(){Id = 2, Name = "Tolik"});
            // _context.SaveChanges();
        }

        public void OnGet()
        {
            //var db = Environment.GetEnvironmentVariable("DATABASE_URL");
        }
    }
}
