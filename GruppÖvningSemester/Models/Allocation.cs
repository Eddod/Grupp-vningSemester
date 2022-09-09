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
        public ICollection<int> DaysLeft { get; set; } //The amount of integers in this collection should be equal to the amount of vacation type objects
        public ICollection<int> MaxAmountOfDays { get; set; }
    }
}
