using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using hackathon.project.HackathonProject.backend.database;
using hackathon.project.HackathonProject.backend.models;

namespace hackathon.project.HackathonProject.backend.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RequestController : ControllerBase
    {
        // [HttpPost("makeItemRequest")]
        // public async Task<IActionResult> NewItemRequest([FromBody] ItemRequests newRequest)
        // {
        //     Database myDatabase = new();
        //     return await myDatabase.PostItemRequest(newRequest);
        //     // return Ok(request);
        // }

        // [HttpPost("makeServiceRequest")]
        // public async Task<IActionResult> NewServiceRequest([FromBody] ServiceRequests newRequest)
        // {
        //     Database myDatabase = new();
        //     var request = await myDatabase.PostServiceRequest(newRequest);
        //     // return Ok(request);
        // }

        [HttpGet("getItemRequest")]
        public async Task<List<reservation>> Get(){
            Database myDatabase = new();
            return await myDatabase.GetAllItemRequests();
        }

        [HttpGet("getServiceRequest")]
        public async Task<List<reservation>> Get(){
            Database myDatabase = new();
            return await myDatabase.GetAllServiceRequests();
        }
    }
}