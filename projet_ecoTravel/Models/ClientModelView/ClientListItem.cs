using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models.ClientViewModel
{
    public class ClientListItem
    {
        [DisplayName("Identifiant")]
        public int IdClient { get; set; }

        [DisplayName("Nom:")]
        public string Nom { get; set; }

        [DisplayName("Préom:")]
        public string Prenom { get; set; }

        [DisplayName("Préom:")]
        public string AdresseMail { get; set; }


        [DisplayName("Télephone:")]
        public int Telephone { get; set; }
   

        [DisplayName("Pays:")]
        public string adressePays { get; set; }
       


    }
}
