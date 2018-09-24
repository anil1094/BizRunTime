using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiSimple1.Models;

namespace WebApiSimple1.Controllers
{
    public class HomeController : ApiController
    {
        public StudentModel GetStudent()
        {
            return new StudentModel
            {
                Name = "Sandeep",
                Age = 27
            };
        }
    }
}
