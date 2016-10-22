using System.Collections.Generic;

namespace Example.DataAccessLayer.DbModel
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual ICollection<StudentSubject> AssignedSubjectses { get; set; }
    }
}
