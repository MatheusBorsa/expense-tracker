using Microsoft.EntityFrameworkCore;

namespace expensetracker.Models
{
    public class ExpenseTrackerDbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }

        public ExpenseTrackerDbContext(DbContextOptions<ExpenseTrackerDbContext> options)
            : base(options)
        {
            
        }
    }
}
