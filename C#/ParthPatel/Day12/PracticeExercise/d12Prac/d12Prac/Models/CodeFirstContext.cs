    using System;  
    using System.Collections.Generic;  
    using System.Data.Entity;  
    using System.Linq;  
    using System.Text;  
    using System.Threading.Tasks;  
      
    namespace d12Prac
{
    public class CodeFirstContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
