using Microsoft.EntityFrameworkCore;

namespace ViewComponentEx.Models
{
    public class CompanyContext:DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Emp>().HasData(
                 new Emp() { EmpID=121,EmpName="Sunil",DeptName="Computer",Salary=12000},
                                  new Emp() { EmpID = 122, EmpName = "Amit", DeptName = "Computer", Salary = 56000 },
                                     new Emp() { EmpID = 123, EmpName = "Manish", DeptName = "Sales", Salary = 21000 }

                );


            modelBuilder.Entity<Book>().HasData(
                 new Book()
                 {
                     BookID = 1,
                     BookName = "Let us C",
                     Author="Yeshwant Kanetkar",
                     Price= 500
                 },
                 new Book()
                 {
                     BookID = 2,
                     BookName = "Complete Ref C",
                     Author = "Steve Gothic",
                     Price=550
                 }
                );

            modelBuilder.Entity<Product>().HasData(
                
                 new Product() {ProductID=1,ProductName="Mouse",MfgName="Intex",Price=950 },
                  new Product() { ProductID =2, ProductName = "Keyboard", MfgName = "Logitech", Price = 1150 },
                   new Product() { ProductID = 3, ProductName = "Monitor", MfgName = "LG", Price = 2950 },
                    new Product() { ProductID = 4, ProductName = "Bottle", MfgName = "cello", Price = 450 }
                );
        }

        public DbSet<Emp> Emps { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
