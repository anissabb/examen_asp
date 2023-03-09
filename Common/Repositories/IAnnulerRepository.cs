using Common.Repository;
using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories
{
    public interface IAnnulerRepository<TEntity, TId> :
        IRepository<TEntity, TId> where TEntity : IAnnuler
    {
    }
}
