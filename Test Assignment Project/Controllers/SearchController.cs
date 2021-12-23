using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using Test_Assignment_Project.Models.RequestModels;
using Test_Assignment_Project.Services.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Test_Assignment_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly ISearchService _service;
        public SearchController(ISearchService service)
        {
            _service = service;
        }

        // GET: api/<SearchController>
        [HttpGet]
        public IActionResult Get([FromQuery] SearchParameter parameters)
        {
            dynamic json = JsonConvert.DeserializeObject(_service.Search(parameters));
            return Ok(json);
        }
    }
}
