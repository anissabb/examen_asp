using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entites
{
    public class Avis
    {
        public int IdAvis { get; set; }
        public string Commentaire{ get; set; }
        public int Note { get; set; }
        public int IdReservation { get; set; }
        public int IdLogement { get; set; }
    }
}
