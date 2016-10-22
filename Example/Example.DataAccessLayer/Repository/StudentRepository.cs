using System.Data.Entity;
using Example.DataAccessLayer.DbModel;
using GenericRepositoryUntility.Repository;

namespace Example.DataAccessLayer
{
    public class StudentRepository : Repository<Student, StudentDataContext>
    {

    }
}
