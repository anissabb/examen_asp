using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models.ClientModelView
{
    public class ClientDetails
    {
        [DisplayName("Identifiant")]
        public int IdClient { get; set; }

        [DisplayName("Nom:")]
        public string Nom { get; set; }

        [DisplayName("Prénom:")]
        public string Prenom { get; set; }

        [DisplayName("Adresse mail:")]
        public string AdresseMail { get; set; }


        [DisplayName("Télephone:")]
        public string Telephone { get; set; }


        [DisplayName("Pays:")]
        public string Pays { get; set; }

        [DisplayName("Mot de passe: ")]
        public string MotdePasse { get; set; }

    }
}
