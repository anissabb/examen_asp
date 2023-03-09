using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entites
{
   public class Client
    {
        public int IdClient { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string AdresseMail { get; set; }
        public string Pays { get; set; }

        public string MotdePasse { get; set; }
        public int Telephone { get; set; }


    }
}
