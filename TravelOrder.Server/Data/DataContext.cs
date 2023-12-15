using Microsoft.EntityFrameworkCore;
using TravelOrder.Server.Models;

namespace TravelOrder.Server.Data
{
    using TravelOrder.Server.Models;
    public class DataContext : DbContext
    {
        
        public DataContext(DbContextOptions<DataContext> dbContextOptions) : base (dbContextOptions)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExpenseType>().HasIndex(x => x.Name).IsUnique(true);
            base.OnModelCreating(modelBuilder);
        }


        #region Entities
        public DbSet<ApprovalProcess> Approvals { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DepartmentEmployee> DepartmentsEmployee { get; set;}
        public DbSet<Document> Documents { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<ExpenseType> ExpensesType { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<TravelOrder> TravelOrders { get; set; }
        public DbSet<User> Users { get; set; }
        #endregion

    }

}
