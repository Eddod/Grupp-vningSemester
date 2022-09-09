using GruppÖvningSemester.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GruppÖvningSemester.Controllers
{
    public class AllocationController : Controller
    {
        private readonly IRepository<Allocation> _repository;

        public AllocationController(IRepository<Allocation> repository)
        {
            _repository = repository;
        }

        //public ViewResult DaysLeft()
        //{
        //    _repository.GetById();
        //}
    }
}
