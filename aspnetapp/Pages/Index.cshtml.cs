using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using aspnetapp.Model;
using aspnetapp.Database;
using MailKit.Net.Smtp;
using MimeKit;

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

            //TODO: test Model_DTM
            //_context.Tests

            // //TODO: test working
            // _context.Tests.Add(new Test(){Id = 4, Name = "Tolik"});
            // _context.SaveChanges();

            //TODO: check MailKit + DigitalOcean Mail Server
            
            // var from = new MailboxAddress("Admin", "admin@mailstorm.ml");
            // var to = new MailboxAddress("Daniel", "arxangeldaniel@gmail.com");
            // var bodyBuilder = new BodyBuilder();
            // bodyBuilder.HtmlBody = "<h1>Hello World!</h1>";
            // bodyBuilder.TextBody = "Hello World!";

            // var message = new MimeMessage();
            // message.From.Add(from);
            // message.To.Add(to);
            // message.Subject = "Uraaa, working";
            // message.Body = bodyBuilder.ToMessageBody();

            // var client = new SmtpClient();
            // client.Connect("mail.mailstorm.ml", 25, false);
            // client.Authenticate("admin@mailstorm.ml", "mushbenari");
            // client.Authenticate("myapp", "mushbenari");

            // client.Send(message);
            // client.Disconnect(true);
            // client.Dispose();
        }

        public void OnGet()
        {
            //var db = Environment.GetEnvironmentVariable("DATABASE_URL");
        }
    }
}
