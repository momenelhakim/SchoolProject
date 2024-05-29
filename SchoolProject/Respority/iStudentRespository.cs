using SchoolProject.Models;
using SchoolProject.Context;
using SchoolProject.Migrations;
namespace SchoolProject.Respority
{
    public interface iStudentRespository
    {

        public interface iStudentRespoirity
        {
            public List<Student> GetAllStudents();

            public void Create(Student student);
            public void Delete(int id);
            public void Register(int StudentId, int Courseid);

        }
    }

}

