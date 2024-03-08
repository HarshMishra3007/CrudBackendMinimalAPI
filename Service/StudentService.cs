using CRUDMinimalAPI.Models;
using CRUDMinimalAPI.Repository;

namespace CRUDMinimalAPI.Service
{
    public class StudentService : IStudentContract
    {
       public  IStudentRepo studentRepo {  get; set; }

        public StudentService(IStudentRepo _studentRepo)
        {
            studentRepo= _studentRepo;
        }       

        public IList<Student> GetStudents()
        {
           return studentRepo.GetStudents();
        }
        public Student GetStudentById(int id)
        {
            return studentRepo.GetStudentById(id);
        }
        public Student CreateStudent(Student student)
        {  //Check NUKLL
             return studentRepo.CreateStudent(student);
        }
        public void DeleteStudent(int id)
        {
            studentRepo.DeleteStudent(id);
        }
        public Student UpdateStudent(int id,Student student)
        {
            //Check NUKLL
           return  studentRepo.UpdateStudent(id, student);
        }

        
        
    }
}
