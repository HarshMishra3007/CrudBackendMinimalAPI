using CRUDMinimalAPI.Models;

namespace CRUDMinimalAPI.Repository
{
    public class StudentRepository : IStudentRepo
    {
        public StudentContext dbContext { get; set; }
        public StudentRepository(StudentContext studentContext)
        {
            dbContext = studentContext;
        }
        public List<Student> GetStudents()
        {
            return dbContext.Students.ToList();
        }
        public Student GetStudentById(int id)
        {
            return dbContext.Students.Find(id);
        }
        public Student CreateStudent(Student student) {
          
            dbContext.Students.Add(student);
            dbContext.SaveChanges();
            return student;

        }
        public void DeleteStudent(int id)
        {
          var employee = dbContext.Students.Find(id);
            dbContext.Students.Remove(employee);
            dbContext.SaveChanges();

        }
        public Student UpdateStudent(int id,Student student)
        {
            var st=dbContext.Students.Find(id);
            if (st == null)
            {
            return st;
            }
            st.Name = student.Name;
            st.Age = student.Age;
            dbContext.Students.Update(st);
            dbContext.SaveChanges();
            return student;
        }
    }
}
