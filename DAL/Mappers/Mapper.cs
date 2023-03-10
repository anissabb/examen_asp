using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    static class Mapper
    {
        public static Client ToClient(this IDataRecord record)
        {
            if (record is null) return null;
            return new Client()
            {
                IdClient = (int)record[nameof(Client.IdClient)],
                Nom = (string)record[nameof(Client.Nom)],
                Prenom = (string)record[nameof(Client.Prenom)],
                AdresseMail = (string)record[nameof(Client.AdresseMail)],
                Telephone=(string)record[nameof(Client.Telephone)],
                MotdePasse = "********",
                Pays = (string)record[nameof(Client.Pays)]
            };
        }

        public static Logement ToLogement(this IDataRecord record)
        {
            if (record is null) return null;
            return new Logement()
            {
                IdLogement = (int)record[nameof(Logement.IdLogement)],
                NomLogement = (string)record[nameof(Logement.NomLogement)],
                adresseRue = (string)record[nameof(Logement.adresseRue)],
                adresseNumero = (string)record[nameof(Logement.adresseNumero)],
                adresseCodePostal = (string)record[nameof(Logement.adresseCodePostal)],
                adressePays = (string)record[nameof(Logement.adressePays)],
                DescriptionCourte = (string)record[nameof(Logement.DescriptionCourte)],
                DescriptionLongue = (string)record[nameof(Logement.DescriptionLongue)],
                DateCreation = (DateTime)record[nameof(Logement.DateCreation)],
                NombrePieces = (int)record[nameof(Logement.NombrePieces)],
                PrixNuit = (decimal)record[nameof(Logement.PrixNuit)],
                Capacite = (int)record[nameof(Logement.Capacite)],
                SalleBain= (int)record[nameof(Logement.SalleBain)],
                Wc = (int)record[nameof(Logement.Wc)],
                Balcon = (bool)record[nameof(Logement.Balcon)],
                AirConditionne = (bool)record[nameof(Logement.AirConditionne)],
                Wifi = (bool)record[nameof(Logement.Wifi)],
                MiniBar = (bool)record[nameof(Logement.MiniBar)],
                AnimauxAdmis = (bool)record[nameof(Logement.AnimauxAdmis)],
                Piscine = (bool)record[nameof(Logement.Piscine)],
                RoomService = (bool)record[nameof(Logement.RoomService)],
               Longitude = (int)record[nameof(Logement.Longitude)],
               Lattitude = (int)record[nameof(Logement.Lattitude)],
                IdProprietaire = (int)record[nameof(Logement.IdProprietaire)],
                IdTypeLogement = (int)record[nameof(Logement.IdTypeLogement)],

            };
        }

    }
}
