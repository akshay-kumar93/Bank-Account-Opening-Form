using Microsoft.EntityFrameworkCore;

namespace Bank_Account_Opening_Form.Models
{
    public class BankContext:DbContext
    {
        public BankContext(DbContextOptions<BankContext> options) : base(options) { }

        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<AccountOpeningForm> AccountOpeningForms { get; set; }
    }
}
