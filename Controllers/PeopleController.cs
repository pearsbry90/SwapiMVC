using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SwapiMVC.Models;

namespace SwapiMVC.Controllers
{
    public class PeopleController : Controller
    {
        private readonly HttpClient _httpClient;
        public PeopleController(IHttpClientFactory httpClientFactory)
        {
            httpClientFactory.CreateClient("swapi");
        }
        public async Task<IActionResult> Index(string page)
        {
        string route = $"people?page={page ?? "1"}";
        HttpResponseMessage response = await _httpClient.GetAsync(route);
        
        var responseString = await response.Content.ReadAsStringAsync();
        var people = JsonSerializer.Deserialize<ResultsViewModel<PeopleViewModel>>(responseString);
            return View(people);
        }

    }
}