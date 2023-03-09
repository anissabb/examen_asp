using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public class ImagesService
    {
        public IEnumerable<Images> Get()
        {
            return null;
        }

        public ImagesService Get(int id)
        {
            return null;
        }

        public int Insert(Images entity)
        {
            return 0;
        }
        public bool Update(int id, Images entity)
        {
            return false;
        }
        public bool Delete(int id)
        {
            return false;
        }
    }
}
