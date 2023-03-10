using Common.Repositories;
using DAL.Entities;
using DAL.Mappers;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public class LogementService : BaseService, ILogementRepository<Logement, int>
    {
        public LogementService(IConfiguration config) : base(config, "EcoTravelDB") { }
        public IEnumerable<Logement> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [IdLogement] , [NomLogement], [adresseRue],[adresseNumero] ,[adresseCodePostal],[adressePays]  ,[DescriptionCourte],[DescriptionLongue] ,[DateCreation], [NombrePieces],[PrixNuit] ,[Capacite], [SalleBain] ,[Wc],	[Balcon],[AirConditionne],[Wifi],[MiniBar], [AnimauxAdmis], [Piscine], [RoomService],[Lattitude], [Longitude],[IdProprietaire]  ,[IdTypeLogement] FROM[Logement]";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToLogement();
                        }
                    }
                }
            }
        }

        public Logement Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [IdLogement] , [NomLogement], [adresseRue],[adresseNumero] ,[adresseCodePostal],[adressePays]  ,[DescriptionCourte],[DescriptionLongue] ,[DateCreation], [NombrePieces],[PrixNuit] ,[Capacite], [SalleBain] ,[Wc],[Balcon],[AirConditionne],[Wifi],[MiniBar], [AnimauxAdmis], [Piscine], [RoomService],[Lattitude], [Longitude]  ,[IdTypeLogement] FROM[Logement]";
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToLogement();
                        return null;

                        //Format ternaire : return (reader.Read()) ? reader.ToClient() : null;
                    }
                }
            }
        }

        public int Insert(Logement entity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                                    
                    command.CommandText = @"INSERT INTO [Logement] ([IdLogement] , [NomLogement], [adresseRue],[adresseNumero] ,[adresseCodePostal],[adressePays]  ,[DescriptionCourte],[DescriptionLongue] ,[DateCreation], [NombrePieces],[PrixNuit] ,[Capacite], [SalleBain] ,[Wc],	[Balcon],[AirConditionne],[Wifi],[MiniBar], [AnimauxAdmis], [Piscine], [RoomService],[Lattitude], [Longitude],[IdTypeLogement],[IdProprietaire]) 
                      OUTPUT [inserted].[IdLogement]  
                            VALUES(@IdLogement,@NomLogement,@adresseRue,@adresseNumero,@adresseCodePostal,@adressePays,@DescriptionCourte,@DescriptionLongue,@DateCreation,@NombrePieces,@PrixNuit,@Capacite,@salleBain,@Wc,@Balcon,@AirConditionne,@MiniBar,@AnimauxAdmis,@Piscine,@RoomService,@Lattitude,@Longitude,@IdTypeLogement,
@IdProprietaire)";
                    command.Parameters.AddWithValue("IdLogement", entity.NomLogement);
                    command.Parameters.AddWithValue("NomLogement", entity.NomLogement);
                    command.Parameters.AddWithValue("adresseRue", entity.adresseRue);
                    command.Parameters.AddWithValue("adresseNumero", entity.adresseNumero);
                    command.Parameters.AddWithValue("adresseCodePostal", entity.adresseCodePostal);
                    command.Parameters.AddWithValue("adressePays", entity.adressePays);
                    command.Parameters.AddWithValue("DescriptionCourte", entity.DescriptionCourte);
                    command.Parameters.AddWithValue("DescriptionLongue", entity.DescriptionLongue);
                    command.Parameters.AddWithValue("DateCreation", entity.DateCreation);
                    command.Parameters.AddWithValue("NombrePieces", entity.NombrePieces);
                    command.Parameters.AddWithValue("PrixNuit", entity.PrixNuit);
                    command.Parameters.AddWithValue("Capacite", entity.Capacite);
                    command.Parameters.AddWithValue("SalleBain", entity.SalleBain);
                    command.Parameters.AddWithValue("Wc", entity.Wc);
                    command.Parameters.AddWithValue("Balcon", entity.Balcon);
                    command.Parameters.AddWithValue("AirConditionne", entity.AirConditionne);
                    command.Parameters.AddWithValue("Wifi", entity.Wifi);
                    command.Parameters.AddWithValue("MiniBar", entity.MiniBar);
                    command.Parameters.AddWithValue("AnimauxAdmis", entity.AnimauxAdmis);
                    command.Parameters.AddWithValue("Piscine", entity.Piscine);
                    command.Parameters.AddWithValue("RoomService", entity.RoomService);
                    command.Parameters.AddWithValue("Longitude", entity.Longitude);
                    command.Parameters.AddWithValue("Lattitude", entity.Lattitude);
                    command.Parameters.AddWithValue("IdTypeLogement", entity.IdTypeLogement);
                    command.Parameters.AddWithValue("IdProprietaire", entity.IdProprietaire);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }


        }

        public bool Update(int id, Logement entity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [IdLogement] , [NomLogement], [adresseRue],[adresseNumero] ,[adresseCodePostal],[adressePays]  ,[DescriptionCourte],[DescriptionLongue] ,[DateCreation], [NombrePieces],[PrixNuit] ,[Capacite], [SalleBain] ,[Wc],	[Balcon],[AirConditionne],[Wifi][MiniBar], [AnimauxAdmis], [Piscine], [RoomService],[Lattitude], [Longitude]  ,[IdTypeLogement],[IdProprietaire] FROM[Logement]";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("NomLogement", entity.NomLogement);
                    command.Parameters.AddWithValue("adresseRue", entity.adresseRue);
                    command.Parameters.AddWithValue("adresseNumero", entity.adresseNumero);
                    command.Parameters.AddWithValue("adresseCodePostal", entity.adresseCodePostal);
                    command.Parameters.AddWithValue("adressePays", entity.adressePays);
                    command.Parameters.AddWithValue("DescriptionCourte", entity.DescriptionCourte);
                    command.Parameters.AddWithValue("DescriptionLongue", entity.DescriptionLongue);
                    command.Parameters.AddWithValue("DateCreation", entity.DateCreation);
                    command.Parameters.AddWithValue("NombrePieces", entity.NombrePieces);
                    command.Parameters.AddWithValue("PrixNuit", entity.PrixNuit);
                    command.Parameters.AddWithValue("Capacite", entity.Capacite);
                    command.Parameters.AddWithValue("SalleBain", entity.SalleBain);
                    command.Parameters.AddWithValue("Wc", entity.Wc);
                    command.Parameters.AddWithValue("Balcon", entity.Balcon);
                    command.Parameters.AddWithValue("AirConditionne", entity.AirConditionne);
                    command.Parameters.AddWithValue("Wifi", entity.Wifi);
                    command.Parameters.AddWithValue("MiniBar", entity.MiniBar);
                    command.Parameters.AddWithValue("AnimauxAdmis", entity.AnimauxAdmis);
                    command.Parameters.AddWithValue("Piscine", entity.Piscine);
                    command.Parameters.AddWithValue("RoomService", entity.RoomService);
                    command.Parameters.AddWithValue("Longitude", entity.Longitude);
                    command.Parameters.AddWithValue("Lattitude", entity.Lattitude);
                    command.Parameters.AddWithValue("IdTypeLogement", entity.IdTypeLogement);
                    command.Parameters.AddWithValue("IdProprietaire", entity.IdProprietaire);

                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
        public bool Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM [Logement] WHERE [IdLogement] = @id";
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;

                }
            }
        }
    }
}
