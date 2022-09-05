using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GruppÖvningSemester.Models
{
    public class Request
    {
        public int RequestId { get; set; }
        public int VacationId { get; set; }
        public int PendingId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DateEnd { get; set; }
        public bool Cancelled { get; set; }
    }
}
