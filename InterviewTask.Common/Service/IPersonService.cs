using InterviewTask.Common.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTask.Common.Service
{
    public interface IPersonService
    {
        Task<IEnumerable<Person>> GetAllPeopleAsync();

        Task<IEnumerable<Person>> GetPeopleFilteredAsync(Expression<Func<Person, bool>> predicate);
    }
}
