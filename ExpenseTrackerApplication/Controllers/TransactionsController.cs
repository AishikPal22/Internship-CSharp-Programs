using ExpenseTrackerApplication.Data;
using ExpenseTrackerApplication.DTO;
using ExpenseTrackerApplication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections;
using System.Security.Claims;

namespace ExpenseTrackerApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        ApplicationDbContext _appdb = new ApplicationDbContext();

        [HttpGet("UserTransactions")]
        [Authorize]
        public IActionResult GetTransactionsByUser()
        {
            var userEmail = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
            var user = _appdb.Users.FirstOrDefault(u => u.Email == userEmail);
            var transaction = _appdb.Transactions.Where(c => c.UserId == user.Id).Select(
                    t => new TransactionDTO { 
                        TransactionId = t.Id,
                        CategoryName = t.Category.Title, 
                        Amount = t.Amount, 
                        Date = t.Date.ToString("dd-MMM-yyyy"), 
                        Description = t.Description 
                    });
            
            if (transaction == null) 
                return NotFound();
            else
                return Ok(transaction);
        }

        [HttpGet("UserTransactionsByCategory")]
        [Authorize]
        public IActionResult GetTransactionsByCategory(int categoryId)
        {
            var userEmail = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
            var user = _appdb.Users.FirstOrDefault(u => u.Email == userEmail);
            var transaction = _appdb.Transactions.Where(c => c.CategoryId == categoryId && c.UserId == user.Id).Select(
                    t => new TransactionDTO {
                        TransactionId = t.Id,
                        CategoryName = t.Category.Title,
                        Amount = t.Amount,
                        Date = t.Date.ToString("dd-MMM-yyyy"),
                        Description = t.Description
                    });
            
            if (transaction == null)
                return NotFound();
            else
                return Ok(transaction);
        }

        [HttpGet("UserTransactionDetails")]
        [Authorize]
        public IActionResult GetTransactionDetails(int id)
        {
            var userEmail = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
            var user = _appdb.Users.FirstOrDefault(u => u.Email == userEmail);
            if (user == null)
                return NotFound();
            else
            {
                var transaction = _appdb.Transactions.Where(c => c.Id == id).Select(
                    t => new TransactionDTO {
                        TransactionId = t.Id,
                        CategoryName = t.Category.Title,
                        Amount = t.Amount,
                        Date = t.Date.ToString("dd-MMM-yyyy"),
                        Description = t.Description
                    });

                if (transaction == null)
                    return NotFound();
                else
                    return Ok(transaction);
            }
        }

        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] Transaction transaction)
        {
            if (transaction == null) { return NoContent(); }
            else
            {
                var userEmail = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
                var user = _appdb.Users.FirstOrDefault(u => u.Email == userEmail);
                if (user == null) { return NotFound(); }
                //property.IsTrending = false;
                transaction.UserId = user.Id;
                _appdb.Transactions.Add(transaction);
                _appdb.SaveChanges();
                return StatusCode(StatusCodes.Status201Created);
            }
        }

        [HttpPut("{id}")]
        [Authorize]
        public IActionResult Put(int id, [FromBody] Transaction transaction)
        {
            var transactionToEdit = _appdb.Transactions.FirstOrDefault(p => p.Id == id);
            if (transactionToEdit == null) { return NoContent(); }
            else
            {
                var userEmail = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
                var user = _appdb.Users.FirstOrDefault(u => u.Email == userEmail);
                if (user == null) { return NotFound(); }
                if (transactionToEdit.UserId == user.Id)
                {
                    transactionToEdit.CategoryId = transaction.CategoryId;
                    transactionToEdit.Amount = transaction.Amount;
                    transactionToEdit.Description = transaction.Description;
                    transactionToEdit.Date = transaction.Date;
                    //property.IsTrending = false;
                    transaction.UserId = user.Id;
                    _appdb.SaveChanges();
                    return Ok("Record updated successfully!");
                }
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        [Authorize]
        public IActionResult Delete(int id)
        {
            var transactionToDelete = _appdb.Transactions.FirstOrDefault(p => p.Id == id);
            if (transactionToDelete == null) { return NoContent(); }
            else
            {
                var userEmail = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
                var user = _appdb.Users.FirstOrDefault(u => u.Email == userEmail);
                if (user == null) { return NotFound(); }
                if (transactionToDelete.UserId == user.Id)
                {
                    _appdb.Transactions.Remove(transactionToDelete);
                    _appdb.SaveChanges();
                    return Ok("Record deleted successfully!");
                }
                return BadRequest();
            }
        }
    }
}
