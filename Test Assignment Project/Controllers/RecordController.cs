using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Assignment_Project.Models.RequestModels;
using Test_Assignment_Project.Services.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Test_Assignment_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordController : ControllerBase
    {
        private readonly IRecordService _service;
        public RecordController(IRecordService service)
        {
            _service = service;
        }

        /// GET: api/<RecordController>
        [HttpGet]
        public IActionResult Get([FromQuery] GetRecordParameter parameters)
        {
            dynamic json = JsonConvert.DeserializeObject(_service.GetRecord(parameters));
            return Ok(json);
        }
        

    }
}
