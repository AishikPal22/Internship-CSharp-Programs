using ExpenseTrackerApplication.Data;
using ExpenseTrackerApplication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace ExpenseTrackerApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        ApplicationDbContext _appdb = new ApplicationDbContext();

        [HttpGet("TotalBalance")]
        [Authorize]
        public IActionResult GetBalance()
        {
            //var balanceResult = _appdb.Users.FirstOrDefault(p => p.Id == id);
            //if (balanceResult == null) { return NoContent(); }
            //else
            //{
                var userEmail = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
                var user = _appdb.Users.FirstOrDefault(u => u.Email == userEmail);

                if (user == null) { return NotFound(); }
                else
                {
                    List<Transaction> SelectedTransactions = _appdb.Transactions
                    .Include(x => x.Category)
                    .Where(y => y.UserId == user.Id)
                    .ToList();

                    //Total Income
                    int TotalIncome = SelectedTransactions
                        .Where(i => i.Category.Type == "Income")
                        .Sum(j => j.Amount);

                    //Total Expense
                    int TotalExpense = SelectedTransactions
                        .Where(i => i.Category.Type == "Expense")
                        .Sum(j => j.Amount);

                    //Balance
                    int Balance = TotalIncome - TotalExpense;

                    return Ok(new { Total_Income = TotalIncome, Total_Expense = TotalExpense, Current_Balance = Balance });
                }
                //return BadRequest();
            //}
        }
    }
}
