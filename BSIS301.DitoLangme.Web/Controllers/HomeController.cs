﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BSIS301.DitoLangme.Web.Models;
using Newtonsoft.Json;
using RestSharp;
using BSIS301.DitoLangme.Web.Infrastructure;
using BSIS301.DitoLangme.Web.ViewModels.Groups;

namespace BSIS301.DitoLangme.Web.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Group()
        {

            var client = new RestClient("http://localhost:5001/api/groups");
            var request = new RestRequest();
            request.Method = Method.GET;
            var response = client.Execute(request);

            var groups = JsonConvert.DeserializeObject<Page<GroupViewModel>>(response.Content);
            return View(new GroupsViewModel()
            {
                Groups = groups
            });
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
