using iVision.DAL.Abstract;
using iVision.DAL.Abstract.UnitOfWork;
using iVision.MODELS;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iVision.DAL.Concrete
{
    public abstract class BaseRepository
    {
        protected readonly ApplicationContext _context;

        public BaseRepository(ApplicationContext context)
        {
            _context = context;
        }
    }
}
