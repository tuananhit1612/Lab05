using System.Collections.Generic;
using Lab05.DAL.Entities;

namespace Lab05.DAL.DALs.StudentDAL
{
    public interface IStudentDAL
    {
        List<Student> GetStudents();
    }
}
