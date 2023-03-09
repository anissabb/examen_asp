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
                Pays = entity.Pays
            };
        }

       
    }
}
