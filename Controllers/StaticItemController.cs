using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParserPages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParserPages.Controllers
{
    public class StaticItemController : Controller
    {
        private readonly ParserPageContext _ct;
        public StaticItemController(ParserPageContext ct) 
        {
            _ct = ct;
        }
        public IActionResult Index()
        {
            List<StaticItem> objList = _ct.StaticItems.OrderBy(e => e.PageAddress)
                                                        .ThenBy(q => q.Frequency)
                                                        .ToList();
            return View(objList);
        }
    }
}
