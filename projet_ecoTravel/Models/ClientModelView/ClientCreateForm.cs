using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models.ClientModelView
{
    public class ClientCreateForm
    {

        public int IdClient { get; set; }
        [Required]
        [MinLength(1)]
        [MaxLength(50)]
        [DisplayName("Nom:")]
        public string Nom { get; set; }
        [Required]
        [MinLength(1)]
        [MaxLength(50)]
        [DisplayName("Prénom:")]
        public string Prenom { get; set; }

        [Required]
        [MaxLength(250)]
        [MinLength(1)]
        [EmailAddress]
        [DisplayName("Adresse mail:")]
        public string AdresseMail { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(2)]
        [DisplayName("Pays:")]
        public string Pays { get; set; }


        [Required]
        [MaxLength(50)]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [DisplayName("Mot de passe:")]
        public string MotdePasse { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [Compare(nameof(MotdePasse))]
        [DisplayName("Confirmer mot de passe: ")]
        public string confirmpass { get; set; }

       [Required]
       [MaxLength(50)]
       [MinLength(2)]
       [DataType(DataType.PhoneNumber)]

        public int Telephone { get; set; }
    }
}
