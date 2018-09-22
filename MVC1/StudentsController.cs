using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
namespace RazorHTMLHelper.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HtmlHelperDemo()
        {
            return View();
        }
        [HttpPost]  
        public ContentResult UserRegistration()
        {
            return Content(
                "User Name = " + Request.Form["username"] + "<br/>" +
                "Email ID  = " + Request.Form["email"] + "<br/>" +
                "Gender    = " + Request.Form["gender"] + "<br/>" +
                "Courses   = " + Request.Form.GetValues("C#")[0] + " " + Request.Form.GetValues("ASP.NET")[0] + " " + Request.Form.GetValues("ADO.NET")[0] + "<br/>" +
                "Contact   = " + Request.Form["contact"] + "<br/>"
                );
        }
    }
}  
    
