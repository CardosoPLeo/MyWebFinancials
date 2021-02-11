using System;
using System.Collections.Generic;
using System.Linq;
using Webfinacials.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Webfinacials.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Webfinacials.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly ApplicationContext _context;

        public UsuarioController(ApplicationContext context)
        {
            _context = context;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

    }
}
