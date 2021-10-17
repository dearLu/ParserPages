using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Html.Parser;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ParserPages.Computing;
using ParserPages.Models;

namespace ParserPages.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public List<StaticItem> TextAndCountList = new List<StaticItem>();
        private  ParserPageContext _ct;

        public HomeController(ILogger<HomeController> logger, ParserPageContext ct)
        {
            _logger = logger;
            _ct = ct;
        }

        public IActionResult Index()
        {         
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CheckClickAsync(string address)
        {

            CalculateCountWord calc = new CalculateCountWord();
            await calc.FindByAttributeAsync(address,_ct);
            TextAndCountList = calc.TextAndCountList;
            return View(TextAndCountList);

        }

       [HttpPost]
        public RedirectResult GoToConfirm([FromBody] List<StaticItem> items) 
        {

            var listItems = items.OrderByDescending(x => x.Frequency).ToList();

            for (int i = 0; i < 11; i++)
            {               
               
                _ct.StaticItems.Add(listItems[i]);
                
            }

            _ct.SaveChanges();

            return Redirect("/StaticItem/Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
       

    }
}
