using System.Collections.Generic;

namespace Example.DataAccessLayer.DbModel
{
    public class StudentSubject
    {
        public int Id { get; set; }
        public virtual Subject AssignedSubject { get; set; }
    }
}
