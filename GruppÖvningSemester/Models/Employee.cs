using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GruppÖvningSemester.Models
{
    public class Employee : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age {  get;  set; }
        ICollection<Request> Requests { get; set; }
        public int AllocationId { get; set; }
    }
}
