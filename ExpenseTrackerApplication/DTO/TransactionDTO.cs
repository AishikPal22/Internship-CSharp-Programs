using ExpenseTrackerApplication.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ExpenseTrackerApplication.DTO
{
    public class TransactionDTO
    {
        public int TransactionId { get; set; }
        public string CategoryName { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
    }
}
