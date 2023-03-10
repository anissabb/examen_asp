using BLL.Entities;
using MVC.Models.ClientModelView;
using MVC.Models.ClientViewModel;
using MVC.Models.LogementModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Handlers
{
    public static class Mapper
    {
        public static ClientListItem ToListItem(this BLL.Entities.Client entity)
        {
            if (entity is null) return null;
            return new ClientListItem()
            {
                IdClient = entity.IdClient,
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                AdresseMail = entity.AdresseMail,
                Telephone=entity.Telephone,
                MotdePasse = entity.MotdePasse,
                Pays = entity.Pays,
            };
        }

        public static Client ToBLL(this ClientCreateForm entity)
        {
            if (entity is null) return null;
            return new Client()
            {
                IdClient=entity.IdClient,
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                AdresseMail = entity.AdresseMail,
                MotdePasse = entity.MotdePasse,
                Telephone = entity.Telephone,
                Pays = entity.Pays
            };



        }
        public static ClientDetails ToDetails(this Client entity)
        {
            if (entity is null) return null;
            return new ClientDetails()
            {
                IdClient=entity.IdClient,
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                AdresseMail = entity.AdresseMail,
                MotdePasse = entity.MotdePasse,
                Telephone = entity.Telephone,
                Pays = entity.Pays
            };
        }

        public static LogementListItem ToListItem(this BLL.Entities.Logement entity)
        {
            if (entity is null) return null;
            return new LogementListItem()
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
              
            };
        }

        public static Logement ToBLL(this LogementCreateForm entity)
        {
            if (entity is null) return null;
            return new Logement()
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
     
            };



        }
        public static LogementDetails ToDetails(this Logement entity)
        {
            if (entity is null) return null;
            return new LogementDetails()
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
         
            };
        }

    }
}
