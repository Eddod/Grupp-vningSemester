using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GruppÖvningSemester.Models
{
    public class Allocation
    {
        [Key]
        public int AllocationId { get; set; }
        //public ICollection<string> VacationTitles { get; set; }
        public ICollection<int> DaysLeft { get; set; }
        public ICollection<int> MaxAmountOfDays { get; set; }
    }
}
