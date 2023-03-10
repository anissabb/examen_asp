﻿using BLL1= BLL.Entities;
using DAL1 = DAL.Entities;
using Common.Repositories;
using Common.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Entities;
using BLL.Mapper;

namespace BLL.Services
{
   
     public class LogementService : ILogementRepository<Logement, int> { 
        private readonly ILogementRepository<DAL1.Logement, int> _repository; 
        
        public LogementService(ILogementRepository<DAL1.Logement, int>repository) { 
            _repository = repository;
        } 
        
        public IEnumerable<Logement> Get() { 

            return _repository.Get().Select(e=>e.ToBLL()); 
        
        }

        public Logement Get(int id)
        {
            return _repository.Get(id).ToBLL();
        }


        public int Insert(Logement entity) { 

            return _repository.Insert(entity.ToDAL()); 
        } public bool Update(int id, Logement entity) {

            return _repository.Update(id, entity.ToDAL());
        } public bool Delete(int id) { 
            return _repository.Delete(id); 
        }
    } 
}

