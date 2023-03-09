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
                MotdePasse = "********",
                Pays = (record[nameof(Client.Pays)] is DBNull) ? null : (string)record[nameof(Client.Pays)]
            };
        }

    }
}
