﻿using Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repository
{
   public interface IRepository<TEntity,TId>
    
        


    {
        IEnumerable<TEntity> Get();
        TEntity Get(TId id);

        TId Insert(TEntity entity);

        bool Update(TId id, TEntity entity);

        bool Delete(TId id);
    }
}
