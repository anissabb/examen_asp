using Common.Entities;
using Common.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories
{
    public interface IAvisRepository<TEntity, TId> :
         IRepository<TEntity, TId> where TEntity : IAvis
    {
    }
}
