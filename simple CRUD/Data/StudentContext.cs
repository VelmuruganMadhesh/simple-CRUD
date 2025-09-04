using Microsoft.EntityFrameworkCore;
using simple_CRUD.Models;

namespace simple_CRUD.Data
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }
    }
}
