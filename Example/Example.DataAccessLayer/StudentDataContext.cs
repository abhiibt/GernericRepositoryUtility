using System.Data.Entity;
using Example.DataAccessLayer.DbModel;

namespace Example.DataAccessLayer
{
    public class StudentDataContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}
