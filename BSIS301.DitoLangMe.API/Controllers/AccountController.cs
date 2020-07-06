using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BSIS301.DitoLangMe.API.Infrastructure.Domain.Data;
using Microsoft.AspNetCore.Mvc;

namespace BSIS301.DitoLangMe.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly DefaultDbContext _context;
        public AccountController(DefaultDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Login()
        {
            return View();
        }
    }
}