using GruppÖvningSemester.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GruppÖvningSemester.Controllers
{
    ///Instructions on how to use Roles from Identity package
    ///https://learn.microsoft.com/en-us/aspnet/core/security/authorization/roles?view=aspnetcore-6.0
    [Authorize(Roles = "Admin")]
    public class AllocationController : Controller
    {
        private readonly IRepository<Allocation> _repository;

        public AllocationController(IRepository<Allocation> repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            var allAllocations = _repository.GetAll();
            return View(allAllocations);
        }
        //=>
        //Content("Admin")

        public ActionResult DaysLeft(int id)
        {
            var foundAllocation = _repository.GetById(id);
            return View(foundAllocation);
        }
    }
}
