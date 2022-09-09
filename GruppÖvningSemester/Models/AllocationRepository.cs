using GruppÖvningSemester.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GruppÖvningSemester.Models
{
    public class AllocationRepository : IRepository<Allocation>
    {
        private readonly ApplicationDbContext _context;

        public AllocationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Allocation entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Allocation> GetAll()
        {
            throw new NotImplementedException();
        }

        public Allocation GetById(int allocationId)
        {
            var foundAllocation = _context.Allocations.FirstOrDefault(a => a.AllocationId == allocationId);
            return foundAllocation;
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Allocation entity)
        {
            entity.DaysLeft -= _context.Requests.Where(e => e.VacationId == entity.)
        }
    }
}
