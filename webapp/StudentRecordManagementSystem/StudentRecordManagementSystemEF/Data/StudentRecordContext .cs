using Microsoft.EntityFrameworkCore;
using StudentRecordManagementSystemEF.Models;

namespace StudentRecordManagementSystemEF.Data
{
    public class StudentManagementContext : DbContext
    {
        public StudentManagementContext(DbContextOptions<StudentManagementContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }
    }
}
