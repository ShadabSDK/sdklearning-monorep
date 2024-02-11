using Microsoft.AspNetCore.Mvc;
using StudentRecordManagementSystem.Models;

namespace StudentRecordManagementSystem.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // GET: Student/Create
        [HttpGet]
        public ActionResult Create()
        {
            //- Only to get View and Show Form
            return View();
        }

        // POST: Student/Create 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student student)
        {
            try
            {
                StudentDataAccessLayer studentdal = new StudentDataAccessLayer();
                studentdal.AddStudent(student);

                //Once  Student Record Created it will redirect to Index Page
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }

        }
    }
}
