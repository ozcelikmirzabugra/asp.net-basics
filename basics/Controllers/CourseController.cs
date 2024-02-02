using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

// course
public class CourseController : Controller {

    public IActionResult Details(int? id)
    {
        if(id == null) {
            // return Redirect("/course/list");
            return RedirectToAction("List", "Course");
        }
        var course = Repository.GetById(id);
        return View(course);
    }
    // course/list
    public IActionResult List()
    {
        return View("CourseList", Repository.Courses);      
    }
}