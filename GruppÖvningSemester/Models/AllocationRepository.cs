using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GruppÖvningSemester.Models
{
    public class AllocationRepository : IRepository<Allocation>
    {
        private readonly IRepository<Allocation> _repository;

        public AllocationRepository(DbContextOptions options) : base(options) { }

        public void Add(Allocation entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Allocation> GetAll()
        {
            throw new NotImplementedException();
        }

        public Allocation GetById(int id)
        {
            var foundAllocation = 
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Allocation entity)
        {
            entity.DaysLeft -= 
        }
    }
}
