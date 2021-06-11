using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASM_1.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
    }
}