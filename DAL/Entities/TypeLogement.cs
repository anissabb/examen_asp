using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class TypeLogement:ITypeLogement
    {
        public int IdTypeLogement { get; set; }
        public string Type { get; set; }
    }
}
