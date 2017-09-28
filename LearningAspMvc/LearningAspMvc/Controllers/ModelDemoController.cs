using LearningAspMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Net;

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
        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var student = db.Set<Student>().Find(id);
            if (student == null)
                return HttpNotFound();

            return View(student);
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

                return View("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ModelDemo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var student = db.Set<Student>().Find(id);
            if (student == null)
                return HttpNotFound();

            return View(student);
        }

        // POST: ModelDemo/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Student stu)
        {
            try
            {
                var Student = db.Set<Student>().Find(id);
                if(TryUpdateModel(Student))
                {
                    db.SaveChanges();
                    return View("Index");
                }
                return View(Student);
            }
            catch
            {
                return View();
            }
        }

        // GET: ModelDemo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var student = db.Set<Student>().Find(id);
            if (student == null)
                return HttpNotFound();

            return View(student);
        }

        // POST: ModelDemo/Delete/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Student stu)
        {
            try
            {
                var student = db.Set<Student>().Find(id);
                if (student == null)
                    return HttpNotFound();

                db.Set<Student>().Remove(student);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
