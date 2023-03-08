using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VoThuanLoi_BigSchool.Models;
using VoThuanLoi_BigSchool.ViewModels;

namespace VoThuanLoi_BigSchool.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses
        private readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }
    }
}