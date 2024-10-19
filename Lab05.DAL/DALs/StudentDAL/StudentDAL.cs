using System.Collections.Generic;
using System.Linq;
using Lab05.DAL.Entities;

namespace Lab05.DAL.DALs.StudentDAL
{
    public class StudentDAL : IStudentDAL
    {
        private StudentDBContext db;

        public StudentDAL()
        {
            db = new StudentDBContext();
        }

        public List<Student> GetStudents()
        {
            return db.Students.ToList();
        }
    }
}
