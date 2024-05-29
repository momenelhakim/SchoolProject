using Microsoft.AspNetCore.Mvc;
using SchoolProject.Models;

namespace SchoolProject.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
     public ActionResult index() { 
            //return list of students
            
            return View(); }
        [HttpGet]
    public ViewResult Create()
    {
        return View();
    }
        [HttpPost]
        public ActionResult Create(Student student) 
        {
            return View();
        }

        public ActionResult Delete(int StudentId) 
        { return View(); }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(int StudentId,int Courseid) {
            return View();
        
        }
    }

}
