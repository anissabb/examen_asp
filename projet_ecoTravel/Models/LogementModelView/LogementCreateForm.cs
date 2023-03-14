using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models.LogementModelView
{
    public class LogementCreateForm
    {
        [ScaffoldColumn(false)]
        [DisplayName("Identifiant")]
        public int IdLogement { get; set; }
        [Required]
        [DisplayName("Nom du logement:")]
        public string NomLogement { get; set; }
        [Required]
        [DisplayName("Rue:")]
        public string adresseRue { get; set; }
        [Required]
        [DisplayName("Numéro:")]
        public string adresseNumero { get; set; }
        [Required]
        [DisplayName("Code postal")]
        public string adresseCodePostal { get; set; }
        [Required]
        [DisplayName("Pays:")]
        public string adressePays { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(8)]
        [DisplayName("Description courte du logement:")]
        
        public string DescriptionCourte { get; set; }
        [Required]
        [MaxLength(512)]
        [MinLength(50)]
        [DisplayName("Description longue du logement:")]
        public string DescriptionLongue { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Date de mise en ligne:")]
        public DateTime DateCreation { get; set; }
        [Required]
        [DisplayName("Nombre de pièces:")]
        public int NombrePieces { get; set; }
        [Required]
        [DisplayName("Prix par nuit")]
        public decimal PrixNuit { get; set; }
        [Required]
        [DisplayName("Nombre de personnes:")]

        public int Capacite { get; set; }
        [Required]
        [DisplayName("Nombre de salles de bain:")]
        public int SalleBain { get; set; }
        [Required]
        [DisplayName("Nombre de toilettes:")]
        public int Wc { get; set; }
        [Required]
        [DisplayName("Balcon:")]
        public bool Balcon { get; set; }
        [Required]
        [DisplayName("Air Conditionné")]
        public bool AirConditionne { get; set; }
        [Required]
        [DisplayName("Wifi")]
        public bool Wifi { get; set; }
        [Required]
        [DisplayName("Mini bar ")]
        public bool MiniBar { get; set; }
        [Required]
        [DisplayName("Animaux admis ")]
        public bool AnimauxAdmis { get; set; }
        [Required]
        [DisplayName("Piscine:")]
        public bool Piscine { get; set; }
        [Required]
        [DisplayName("Room Service")]
        public bool RoomService { get; set; }
        [Required]
        [Range(-180, 180, ErrorMessage = "Entre -180 et 180")]
        //mettre range 
        [DisplayName("Lattitude")]
        
        public decimal Lattitude { get; set; }
        [Required]
        [Range(-180, 180, ErrorMessage = "Entre -180 et 180")]
        //mettre range
        [DisplayName("Longitude")]
        public decimal Longitude { get; set; }
    }
}
