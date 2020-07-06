using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BSIS301.DitoLangMe.API.Infrastructure.Domain.Data;
using BSIS301.DitoLangMe.API.Infrastructure.Domain.Models;
using BSIS301.DitoLangMe.DataTransferObjects.Users;
using Microsoft.AspNetCore.Mvc;

namespace BSIS301.DitoLangMe.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        readonly private DefaultDbContext _context; 

        public UsersController(DefaultDbContext context)
        {
            _context = context;
        }

        [HttpGet, Route("users")]
        [HttpGet, Route("users/index")]
        public IActionResult Index(long pageSize, long pageIndex, string keyword = "")
        {
            Page<User> result = new Page<User>();

            if (pageSize < 1)
            {
                pageSize = 1;
            }

            IQueryable<User> userQuery = (IQueryable<User>)this._context.Users;
            
            if (string.IsNullOrEmpty(keyword) == false )
            {
                userQuery = userQuery.Where(u => u.FirstName.Contains(keyword)
                                            || u.LastName.Contains(keyword)
                                            || u.EmailAddress.Contains(keyword));

            }

            long queryCount = userQuery.Count();

            int pageCount = (int)Math.Ceiling((decimal)(queryCount / pageSize));
            long mod = (queryCount % pageSize);

            if (mod > 0)
            {
                pageCount = pageCount + 1;
            }

            int skip = (int)(pageSize * (pageIndex - 1));
            List<User> users = userQuery.ToList();

            result.Items = users.Skip(skip).Take((int)pageSize).ToList();
            result.PageCount = pageCount;
            result.PageSize = pageSize;
            result.QueryCount = queryCount;
            result.PageIndex = pageIndex;
            result.Keyword = keyword;
            return View();
        }
        //[HttpGet, Route("users/create")]
        //public IActionResult Create(CreateViewModel model)
        //{
        //    if(!ModelState.IsValid)
        //    {
        //        return BadRequest();
        //    }

        //    User user = new User
        //    {
        //        Id = model.Id,
        //        FirstName = model.FirstName,
        //        LastName = model.LastName,
        //        Password = model.Password,
        //        EmailAddress = model.EmailAddress,
        //        Gender = model.Gender,
        //        UpdatedAt = DateTime.UtcNow,
        //        CreatedAt = DateTime.UtcNow

        //    };

        //    this._context.Add(user);
        //    this._context.SaveChanges();

        //    return View(/*Redirect("users/index")*/);
        //}

        [HttpPost,Route("users/invites")]
        public IActionResult UpdateUser(UpdateUserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var user = this._context.Users.FirstOrDefault();

            if (user != null)
            {
                return Ok();
            }

            User users = new User
            {
                FirstName = model.FirstName
            };
            return View();
        }
    }
}