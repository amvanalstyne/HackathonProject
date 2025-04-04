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
    public class AdminController : ControllerBase
    {
        [HttpPost("adminLogin")]
        public async Task<IActionResult> Login([FromBody] Login newLogin)
        {
            Database myDatabase = new();
            var admin = await myDatabase.Login(newLogin);
            return Ok(admin);
        }
    }
}