using Microsoft.AspNetCore.Mvc;
using StudentRecordManagementSystemEF.Models;

namespace StudentRecordManagementSystemEF.Controllers
{
    public class StudentController : Controller
    {
        StudentDataAccessLayer _studentDataAccessLayer = null;
        public StudentController(StudentDataAccessLayer studentDataAccessLayer)
        {
            _studentDataAccessLayer = studentDataAccessLayer;
        }
        public IActionResult Index()
        {
            IEnumerable<Student> students= _studentDataAccessLayer.GetAllStudent();
            return View(students);
        }

        public ActionResult Details(int id)
        {
            Student student = _studentDataAccessLayer.GetStudentData(id);
            return View(student);
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
                _studentDataAccessLayer.AddStudent(student);

                //Once  Student Record Created it will redirect to Index Page
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }

        }

        public ActionResult Edit(int id)
        {
            Student student = _studentDataAccessLayer.GetStudentData(id);
            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Student student)
        {
            try
            {
                // TODO: Add update logic here  
                _studentDataAccessLayer.UpdateStudent(student);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            Student student = _studentDataAccessLayer.GetStudentData(id);
            return View(student);
        }

        // POST: Student/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Student student)
        {
            try
            {
                // TODO: Add delete logic here
                _studentDataAccessLayer.DeleteStudent(student.Id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
