using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL1 = BLL.Entities;
using DAL1 = DAL.Entities;




namespace BLL.Mapper
{
    static class Mapper
    {
        public static BLL1.Client ToBLL(this DAL1.Client entity)
        {
            if (entity is null) return null;
            return new BLL1.Client()
            {
                IdClient = entity.IdClient,
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                AdresseMail = entity.AdresseMail,
                Telephone=entity.Telephone,
                MotdePasse= entity.MotdePasse,
                Pays= entity.Pays
            };
        }


        public static DAL1.Client ToDAL(this BLL1.Client entity)
        {
            if (entity is null) return null;
            return new DAL1.Client()
            {
                IdClient = entity.IdClient,
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                AdresseMail= entity.AdresseMail,
                MotdePasse = entity.MotdePasse,
                Telephone= entity.Telephone,
                Pays = entity.Pays
            };
        }

        public static DAL1.Logement ToDAL(this BLL1.Logement entity)
        {
            if (entity is null) return null;
            return new DAL1.Logement()
            {
                IdLogement = entity.IdLogement,
                NomLogement = entity.NomLogement,
                adresseRue = entity.adresseRue,
                adresseNumero = entity.adresseNumero,
                adresseCodePostal = entity.adresseCodePostal,
                adressePays = entity.adressePays,
                DescriptionCourte = entity.DescriptionCourte,
                DescriptionLongue = entity.DescriptionLongue,
                DateCreation = entity.DateCreation,
                NombrePieces = entity.NombrePieces,
                PrixNuit = entity.PrixNuit,
                Capacite = entity.Capacite,
                SalleBain = entity.SalleBain,
                Wc = entity.Wc,
                Balcon = entity.Balcon,
                AirConditionne = entity.AirConditionne,
                Wifi = entity.Wifi,
                MiniBar = entity.MiniBar,
                AnimauxAdmis = entity.AnimauxAdmis,
                Piscine = entity.Piscine,
                RoomService = entity.RoomService,
                Longitude = entity.Longitude,
                Lattitude = entity.Lattitude,
                IdProprietaire = entity.IdProprietaire,
                IdTypeLogement = entity.IdTypeLogement,

            };
        }

        public static BLL1.Logement ToBLL(this DAL1.Logement entity)
        {
            if (entity is null) return null;
            return new BLL1.Logement()
            {
                IdLogement = entity.IdLogement,
                NomLogement = entity.NomLogement,
                adresseRue = entity.adresseRue,
                adresseNumero = entity.adresseNumero,
                adresseCodePostal = entity.adresseCodePostal,
                adressePays = entity.adressePays,
                DescriptionCourte = entity.DescriptionCourte,
                DescriptionLongue = entity.DescriptionLongue,
                DateCreation = entity.DateCreation,
                NombrePieces = entity.NombrePieces,
                PrixNuit = entity.PrixNuit,
                Capacite = entity.Capacite,
                SalleBain = entity.SalleBain,
                Wc = entity.Wc,
                Balcon = entity.Balcon,
                AirConditionne = entity.AirConditionne,
                Wifi = entity.Wifi,
                MiniBar = entity.MiniBar,
                AnimauxAdmis = entity.AnimauxAdmis,
                Piscine = entity.Piscine,
                RoomService = entity.RoomService,
                Longitude = entity.Longitude,
                Lattitude = entity.Lattitude,
                IdProprietaire = entity.IdProprietaire,
                IdTypeLogement = entity.IdTypeLogement,

            };
        }

    }
}
