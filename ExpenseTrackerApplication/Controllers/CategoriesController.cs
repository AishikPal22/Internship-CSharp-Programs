using ExpenseTrackerApplication.Data;
using ExpenseTrackerApplication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Security.Claims;

namespace ExpenseTrackerApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ApplicationDbContext _appdb = new ApplicationDbContext();

        [HttpGet]
        [Authorize]
        public IActionResult Get()
        {
            return Ok(_appdb.Categories);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] Category category)
        {
            if (category == null) { return NoContent(); }
            else
            {
                //var userEmail = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
                //var user = _appdb.Users.FirstOrDefault(u => u.Email == userEmail);
                //if (user == null) { return NotFound(); }
                _appdb.Categories.Add(category);
                _appdb.SaveChanges();
                return StatusCode(StatusCodes.Status201Created);
            }
        }
    }
}
