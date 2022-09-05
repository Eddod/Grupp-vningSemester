using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GruppÖvningSemester.Models
{
    public interface IRepository<T>
    {
        public IEnumerable<T> GetAll();
        public T GetById(int id);
        public void Add(T entity);
        public void Remove(int id);
        public void Update(T entity);

    }
}
