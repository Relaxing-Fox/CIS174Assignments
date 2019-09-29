using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIS174Assignments.Models;
using CIS174Assignments.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CIS174Assignments.Controllers
{
    public class AssignmentsController : Controller
    {
        public IActionResult Assignment61(int accessLevel)
        {
            var students = new List<Students>()
            {
                new Students()
                {
                    FirstName = "Tyler",
                    LastName = "Johnson",
                    Grade = "A+"
                },
                new Students()
                {
                    FirstName = "Jane",
                    LastName = "Rodriguez",
                    Grade = "A"
                },
                new Students()
                {
                    FirstName = "Eva",
                    LastName = "Johnson",
                    Grade = "C+"
                },
                new Students()
                {
                    FirstName = "John",
                    LastName = "Smith",
                    Grade = "B-"
                },
                new Students()
                {
                    FirstName = "Jennifer",
                    LastName = "Williams",
                    Grade = "C-"
                }
            };

            StudentsViewModel viewModel = new StudentsViewModel();
            viewModel.StudentList = students;
            viewModel.AccessLevel = accessLevel;

            return View(viewModel);
        }
    }
}