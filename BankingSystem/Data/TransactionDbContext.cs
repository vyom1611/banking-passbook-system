using BankingSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace BankingSystem.Data;

public class TransactionDbContext : DbContext
{
    public TransactionDbContext(DbContextOptions<TransactionDbContext> options) : base(options)
    {
    }
    
    public DbSet<Transaction> Transactions { get; set; }
}