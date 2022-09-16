using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GruppÖvningSemester.Models
{
    public class VacationType
    {
        [Key]
        public int VacationID { get; set; }
        public string VacationTitle { get; set; }
        public int AmountOfDays { get; set; }
    }
}
