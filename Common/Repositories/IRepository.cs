﻿using Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repository
{
   public interface IRepository<TEntity,TId>:
    
        IGetRepository<TEntity,TId>,
        IInsertRepository<TEntity,TId>,
        IUpdateRepository<TEntity,TId>,
        IDeleteRepository<TEntity,TId>


    {}
}
