using iVision.DAL.Concrete;
using iVision.MODELS;
using System;
using System.Collections.Generic;

namespace iVision.DAL.Abstract.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public ApplicationContext Context { get; }

        public UnitOfWork(ApplicationContext context)
        {
            Context = context;
        }
        public void Commit()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();

        }
    }
}
