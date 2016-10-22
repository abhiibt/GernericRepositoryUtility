using System;
using System.Collections.Generic;
using Example.DataAccessLayer;
using Example.DataAccessLayer.DbModel;
using Ninject;
using NUnit.Framework;

namespace GenericRepositoryUntilityTests
{
    [TestFixture]
    public class RepositoryTests
    {
        [Test]
        public void SubjectRepositoryTest_Add_Subjects()
        {
            using (var kernel = new StandardKernel(new ExampleNinjectModule()))
            {
                var studentRepository = kernel.Get<SubjectRepository>();
                studentRepository.Add(GetTestSubjects);
                studentRepository.Save();
            }
        }

        [Test]
        public void SubjectRepositoryTest_Get_Subjects()
        {
            using (var kernel = new StandardKernel(new ExampleNinjectModule()))
            {
                var studentRepository = kernel.Get<SubjectRepository>();
                var subjects = studentRepository.GetAll();
                Console.WriteLine(subjects);
            }
        }

        [Test]
        public void StudentRepositoryTest_Add_Student()
        {
            using (var kernel = new StandardKernel(new ExampleNinjectModule()))
            {
                var studentRepository = kernel.Get<StudentRepository>();
                studentRepository.Add(TestStudentModel);
                 studentRepository.Save();
            }
        }

        private Student TestStudentModel
        {
            get
            {
                return new Student()
                {
                    Name = "TestName",
                    Age = 26,
                    AssignedSubjectses = new List<StudentSubject>()
                    {
                        new StudentSubject()
                        {
                           AssignedSubject = new Subject()
                           {
                               Name = "Subject1"
                           }
                        },
                    }
                };
            }
        }

        private IEnumerable<Subject> GetTestSubjects
        {
            get
            {
                return new List<Subject>
                {
                    new Subject
                    {
                        Name = "Subject1"
                    },
                    new Subject
                    {
                        Name = "Subject2"
                    },
                    new Subject
                    {
                        Name = "Subject4"
                    },
                    new Subject
                    {
                        Name = "Subject4"
                    },
                };
            }
        } 
    }
}
