using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entites
{
    public class Logement
    {
        public int IdLogement { get; set; }
        public string NomLogement { get; set; }
        public string adresseRue { get; set; }
        public string adresseNumero { get; set; }
        public string adresseCodePostal { get; set; }
        public string adressePays { get; set; }
        public string DescriptionCourte { get; set; }
        public string DescriptionLongue { get; set; }
        public DateTime DateCreation { get; set; }
        public int NombrePieces { get; set; }
        public decimal PrixNuit { get; set; }
        public int Capacite { get; set; }
        public int SalleBain { get; set; }
        public int Wc { get; set; }
        public bool Balcon { get; set; }
         public bool AirConditionne { get; set; }
        public bool Wifi { get; set; }
        public bool MiniBar { get; set; }
        public bool AnimauxAdmis { get; set; }
        public bool Piscine { get; set; }
        public bool RoomService { get; set; }
        public decimal Lattitude { get; set; }
        public decimal Longitude { get; set; }
        public int IdTypeLogement { get; set; }
        public int IdProprietaire { get; set; }
    }
}
