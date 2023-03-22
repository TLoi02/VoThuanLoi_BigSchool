using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VoThuanLoi_BigSchool.Models;

namespace VoThuanLoi_BigSchool.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}