using CRUDMinimalAPI.Models;
using CRUDMinimalAPI.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace CRUDMinimalAPI.EndPoints
{
    public static class StudentEndpoint
    {
        public static WebApplication ConfigureStudentEndPoints( this WebApplication app)

        {
            //Retrieiving all students from the database
            app.MapGet("/CRUDMinimalAPI/Students", (IStudentContract studentService) =>
            {
                return studentService.GetStudents();
            });
            //Retrieving a student by an id

            app.MapGet("/CRUDMinimalAPI/StudentByID", (IStudentContract studentService, int id) =>
            {
              
                return studentService.GetStudentById(id );

            });

            //Adding a new student in the record

             app.MapPost("/CRUDMinimalAPI/AddStudent", (IStudentContract studentService, [FromBody] Student student) =>
            {
                if (student == null)
                {
                    return student;
                }
               
                    return studentService.CreateStudent(student);
            });

            //Updating a existing student in the record

            app.MapPut("/CRUDMinimalAPI/UpdateEmployee/{id}", (IStudentContract studentService, int id, Student student) =>
            {
               return studentService.UpdateStudent(id, student);
            });

            //Deleting the student from the record
            app.MapDelete("/CRUDMinimalAPI/DeleteEmployee/{id}", (IStudentContract studentService, int id) =>
            {
                studentService.DeleteStudent(id);
             
            });
            return app;
        }
    }
}
