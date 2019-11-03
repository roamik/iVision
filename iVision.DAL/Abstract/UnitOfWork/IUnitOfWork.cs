using iVision.MODELS;
using System;
using System.Collections.Generic;
using System.Text;

namespace iVision.DAL.Abstract.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ApplicationContext Context { get; }
        void Commit();
    }
}
