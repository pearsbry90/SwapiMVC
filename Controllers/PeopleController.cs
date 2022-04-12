using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SwapiMVC.Controllers
{
    public class PeopleController : Controller
    {
        private readonly HttpClient _httpClient;
        public PeopleController(IHttpClientFactory httpClientFactory)
        {
            httpClientFactory.CreateClient("swapi");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}