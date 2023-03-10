using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models.LogementModelView
{
    public class LogementDetails
    {

        [DisplayName("Identifiant")]
        public int IdLogement { get; set; }
        [DisplayName("Nom du logement:")]
        public string NomLogement { get; set; }
        [DisplayName("Rue:")]
        public string adresseRue { get; set; }
        [DisplayName("Numéro:")]
        public string adresseNumero { get; set; }
        [DisplayName("Code postal")]
        public string adresseCodePostal { get; set; }
        [DisplayName("Pays:")]
        public string adressePays { get; set; }
        [DisplayName("Description courte du logement:")]
        public string DescriptionCourte { get; set; }
        [DisplayName("Description longue du logement:")]
        public string DescriptionLongue { get; set; }
        [DisplayName("Date de mise en ligne:")]
        public DateTime DateCreation { get; set; }
        [DisplayName("Nombre de pièces:")]
        public int NombrePieces { get; set; }
        [DisplayName("Prix par nuit")]
        public decimal PrixNuit { get; set; }
        [DisplayName("Nombre de personnes:")]

        public int Capacite { get; set; }
        [DisplayName("Nombre de salles de bain:")]
        public int SalleBain { get; set; }
        [DisplayName("Nombre de toilettes:")]
        public int Wc { get; set; }
        [DisplayName("Balcon:")]
        public bool Balcon { get; set; }
        [DisplayName("Air Conditionné")]
        public bool AirConditionne { get; set; }
        [DisplayName("Wifi")]
        public bool Wifi { get; set; }
        [DisplayName("Mini bar ")]
        public bool MiniBar { get; set; }
        [DisplayName("Animaux admis ")]
        public bool AnimauxAdmis { get; set; }
        [DisplayName("Piscine:")]
        public bool Piscine { get; set; }
        [DisplayName("Room Service")]
        public bool RoomService { get; set; }
        [DisplayName("Lattitude")]
        public decimal Lattitude { get; set; }
        [DisplayName("Longitude")]
        public decimal Longitude { get; set; }

    }
}
