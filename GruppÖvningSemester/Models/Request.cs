using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GruppÖvningSemester.Models
{
    public class Request
    {
        [Key]
        public int RequestId { get; set; }
        public int VacationId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DateEnd { get; set; }
        public bool IsCancelled { get; set; }
        public Status Status { get; set; }
    }

    public enum Status { Pending, Accepted, Declined}
}
