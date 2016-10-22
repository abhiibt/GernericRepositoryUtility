using Example.DataAccessLayer.DbModel;
using GenericRepositoryUntility;
using Ninject.Modules;

namespace Example.DataAccessLayer
{
    public class ExampleNinjectModule: NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<IRepository<Student>>().To<StudentRepository>();
        }
    }
}
