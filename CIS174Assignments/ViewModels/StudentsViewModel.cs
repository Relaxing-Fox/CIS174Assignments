using CIS174Assignments.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174Assignments.ViewModels
{
    public class StudentsViewModel
    {
        public List<Students> StudentList { get; set; }

        public int AccessLevel { get; set; }

    }
}
