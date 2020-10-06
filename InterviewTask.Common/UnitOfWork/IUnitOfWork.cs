using InterviewTask.Common.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTask.Common.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task SaveAsync();

        IPersonRepository PersonRepository { get; }
    }
}
