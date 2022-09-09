using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GruppÖvningSemester.Models
{
    public class Allocation
    {
        [Key]
        public int AllocationId { get; set; }
        //public ICollection<string> VacationTitles { get; set; }
        [NotMapped]
        public Dictionary<string, int> DaysLeft { get; set; } //The amount of integers in this collection should be equal to the amount of vacation type objects
        [NotMapped]
        public Dictionary<string, int> MaxAmountOfDays { get; set; }
    }
}
