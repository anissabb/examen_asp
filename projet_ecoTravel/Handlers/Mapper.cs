using BLL.Entities;
using MVC.Models.ClientModelView;
using MVC.Models.ClientViewModel;
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
                adressePays = entity.Pays,
            };
        }

        public static Client ToBLL(this ClientCreateForm entity)
        {
            if (entity is null) return null;
            return new Client()
            {
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                AdresseMail = entity.AdresseMail,
                MotdePasse = entity.MotdePasse,
                Telephone = entity.Telephone,
                Pays = entity.Pays
            };
        }
    }
}
