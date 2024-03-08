using CRUDMinimalAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDMinimalAPI.Service
{
    public interface IStudentContract
    {
        IList<Student> GetStudents();
        Student GetStudentById(int id);
        Student CreateStudent(Student student);
        void DeleteStudent(int id);
        Student UpdateStudent(int id, Student student);
    }
}
