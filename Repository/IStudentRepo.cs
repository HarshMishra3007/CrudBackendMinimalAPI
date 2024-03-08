using CRUDMinimalAPI.Models;

namespace CRUDMinimalAPI.Repository
{
    public interface IStudentRepo
    {
        List<Student> GetStudents();
        Student GetStudentById(int id);
        Student CreateStudent(Student student);
        void DeleteStudent(int id);
        Student  UpdateStudent(int id, Student student);
    }
}
