using StudentRecordManagementSystemEF.Data;
using System.Data;
using System.Data.SqlClient;



namespace StudentRecordManagementSystemEF.Models
{
    public class StudentDataAccessLayer
    {
        string connectionString=String.Empty;
        StudentManagementContext _dbContext;

        public StudentDataAccessLayer(StudentManagementContext dbContext)
        {
            _dbContext = dbContext;

        }
        public void AddStudent(Student student)
        {
           
                // Assuming Student is your entity class mapped to the database table
                var newStudent = new Student
                {
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    Email = student.Email,
                    Mobile = student.Mobile,
                    Address = student.Address
                };

                _dbContext.Student.Add(newStudent);
                _dbContext.SaveChanges();
        }

        public IEnumerable<Student> GetAllStudent()
        {
            List<Student> lstStudent = new List<Student>();
           
            return lstStudent;
        }


        public Student GetStudentData(int? id)
        {
            Student student = new Student();

            
            return student;
        }

        public void UpdateStudent(Student student)
        {
           
        }

        public void DeleteStudent(int? id)
        {

           
        }
    }
}
