using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebAPI1._7_HTTPRequest.Models;

namespace WebAPI1._7_HTTPRequest.Controllers
{
    public class StudentController : ApiController
    {
        Models.Student[] students = new Models.Student[]{
         new  Models.Student {Name="Walter", Class="7A", Address="Address 1", Email="walter@email.com" },
         new Models.Student {Name="Matthew", Class="7A", Address="Address 2", Email="matthew@email.com" },
         new Models.Student {Name="Anne", Class="7A", Address="Address 3", Email="anne@email.com" },
        };

        public IEnumerable<Models.Student> GetAllStudents()
        {
            return students;
        }

        public IHttpActionResult GetStudent(string name)
        {
            var student = students.FirstOrDefault((p) => p.Name == name);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

    }
}

