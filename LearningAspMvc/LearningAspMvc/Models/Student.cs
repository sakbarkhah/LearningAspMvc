using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LearningAspMvc.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NationalCode { get; set; }
        public bool IsActive { get; set; }
        public DateTime RegisterDate { get; set; }
    }

    public class StudentDBContext : DbContext
    {
        public StudentDBContext() {}
        public DbSet<Student> Students { get; set; }
    }
}