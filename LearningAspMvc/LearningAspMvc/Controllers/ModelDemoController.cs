using LearningAspMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace LearningAspMvc.Controllers
{
    public class ModelDemoController : Controller
    {
        private StudentDBContext db = new StudentDBContext();
       //List<Student> students { get; set; }

       
        // GET: ModelDemo
        public ActionResult Index()
        {
            //students = new List<Student>();
            //students = GetAllStudents().OrderBy(Stu => Stu.Id).ToList();
            //return View(students);
            var student = db.Set<Student>().Select(stu => stu);
            return View(student);
        }

        public List<Student> GetAllStudents ()
        {
            return new List<Student> {
                new Student
                {
                    Id = 1, Name = "Somayeh", NationalCode = 12345, IsActive = true, RegisterDate = DateTime.Now.AddDays(-5)
                },
                new Student
                {
                    Id = 2, Name = "Mohammad", NationalCode = 1456, IsActive = true, RegisterDate = DateTime.Now.AddDays(-7)
                },
                new Student
                {
                    Id= 3, Name = "Maryam", NationalCode = 789, IsActive = false, RegisterDate = DateTime.Now.AddDays(-9)
                }
            };
        }

        // GET: ModelDemo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ModelDemo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ModelDemo/Create
        [HttpPost]
        public ActionResult Create(Student stu)
        {
            try
            {
                //var t = stu.IsActive;
                //student.Name = collection["Name"];
                //student.NationalCode = Int32.Parse(collection["NationalCode"]);
                //student.RegisterDate = DateTime.Parse(collection["RegisterDate"]);
                //students.Add(stu);

                db.Students.Add(stu);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ModelDemo/Edit/5
        public ActionResult Edit(int id)
        {
            var student = db.Set<Student>().Single(stu => stu.Id == id);
            return View(student);
        }

        // POST: ModelDemo/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Student stu)
        {
            try
            {
                var Student = db.Set<Student>().Single(student => student.Id == id);
                if(TryUpdateModel(Student))
                {
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(Student);
            }
            catch
            {
                return View();
            }
        }

        // GET: ModelDemo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ModelDemo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
