using SchoolProject.Context;
using SchoolProject.Models;


using static SchoolProject.Respority.iStudentRespository;

namespace SchoolProject.Respority
{
    public class StudentReposirity : iStudentRespoirity
    {
        private readonly MyDbContext _MyDbConnection;


        public StudentReposirity(MyDbContext MyDbContext)
        {
            _MyDbConnection = MyDbContext;
        }

        public List<Student> GetAllStudents()
        {
            try
            {
                List<Student> students = (from stdsobj in _MyDbConnection.Student select stdsobj).ToList;

                return students;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                return null;
            }


        }

        public void Create(Student student)
        {

        }

        public void Delete(int id)
        {

        }



        public void Register(int StudentId, int Courseid)
        {

        }
    }
}


