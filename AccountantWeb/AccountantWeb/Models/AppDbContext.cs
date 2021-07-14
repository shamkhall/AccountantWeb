using AccountantWeb.Model;
using AccountantWeb.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Models
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Profit> Profits { get; set; }
        public DbSet<NoteModel> Notes { get; set; }
        public DbSet<DebtsModel> Debts { get; set; }
        public DbSet<CardModel> Cards { get; set; }
        public DbSet<TurnoverModel> Turnovers { get; set; }
        public DbSet<DebtRepaymentModel> DebtRepaymentModels { get; set; }
      
        
    }
}