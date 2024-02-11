using System.Data;
using System.Data.SqlClient;



namespace StudentRecordManagementSystem.Models
{
    public class StudentDataAccessLayer
    {
        public void AddStudent(Student student)
        {
            using (SqlConnection con = new SqlConnection("Server=DESKTOP-GF67IHK\\SQLEXPRESS;Database=StudentManagement;Trusted_Connection=True;"))
            {
                SqlCommand cmd = new SqlCommand("spAddStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FirstName", student.FirstName);
                cmd.Parameters.AddWithValue("@LastName", student.LastName);
                cmd.Parameters.AddWithValue("@Email", student.Email);
                cmd.Parameters.AddWithValue("@Mobile", student.Mobile);
                cmd.Parameters.AddWithValue("@Address", student.Address);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
