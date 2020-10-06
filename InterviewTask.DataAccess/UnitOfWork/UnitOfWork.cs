using InterviewTask.Common.Repository;
using InterviewTask.Common.UnitOfWork;
using InterviewTask.DataAccess.Context;
using InterviewTask.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTask.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationContext context;

        public UnitOfWork(ApplicationContext context)
        {
            this.context = context;
            this.PersonRepository = new PersonRepository(context);
        }

        public IPersonRepository PersonRepository { get; }

        public void Dispose()
        {
            this.context?.Dispose();
        }

        public async Task SaveAsync()
        {
            await this.context.SaveChangesAsync();
        }
    }
}
