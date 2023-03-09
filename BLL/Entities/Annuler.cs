using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Annuler
    {
        public int IdReservationLogement { get; set; }
        public DateTime DateAnnulation { get; set; }
        public int IdClient { get; set; }
    }
}
