using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GruppÖvningSemester.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age {  get;  set; }
        ICollection<Request> Requests { get; set; }
    }
}
