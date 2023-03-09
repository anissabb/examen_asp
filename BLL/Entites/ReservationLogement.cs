using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entites
{
    public class ReservationLogement
    {
        public int IdReservationLogement { get; set; }
        public bool Annulation { get; set; }
        public decimal Prix { get; set; }
        public bool Assurance { get; set; }
        public int IdIndisponibilite { get; set; }
        public int NombresAdulte { get; set; }
        public int NombresEnfant { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFIN { get; set; }
        public bool AnnulerPar { get; set; }
        public int IdLogement { get; set; }
        public int IdClient { get; set; }
    }
}
