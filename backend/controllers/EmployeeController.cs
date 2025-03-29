using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using hackathon.project.HackathonProject.backend.database;
using hackathon.project.HackathonProject.backend.models;

namespace backend.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        [HttpPost("employeeLogin")]
        public async Task<IActionResult> Login([FromBody] Login newLogin)
        {
            Database myDatabase = new();
            var employee = await myDatabase.Login(newLogin);
            return Ok(employee);
        }
    }
}