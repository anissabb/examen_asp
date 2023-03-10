using Common.Repositories;
using DAL.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DAL.Mappers;

namespace DAL.Services
{
    public class ClientService :BaseService,IClientRepository<Client, int>
    {
        public ClientService(IConfiguration config) : base(config, "EcoTravelDB") {}


        public IEnumerable<Client> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [IdClient], [Nom], [Prenom], [AdresseMail], [Pays], [Telephone] FROM [Client]";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToClient();
                        }
                    }
                }
            }
        }

        public int? CheckPassword(string AdresseMail, string MotdePasse)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_ClientCheck";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("AdresseMail", AdresseMail);
                    command.Parameters.AddWithValue("MotdePasse", MotdePasse);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    return (result is DBNull) ? null : (int?)result;
                }
            }
        }

        public Client Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [IdClient], [Nom], [Prenom], [Telephone],[AdresseMail], [Pays] FROM [Client] WHERE [IdClient] = @id";
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToClient();
                        return null;

                        //Format ternaire : return (reader.Read()) ? reader.ToClient() : null;
                    }
                }
            }
        }

        public int Insert(Client entity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    /*command.CommandText = @"INSERT INTO [Client] ([nom], [prenom], [email], [pass], [adresse])
                                            OUTPUT [inserted].[idClient]
                                            VALUES (@nom, @prenom, @email, HASHBYTES('SHA2_512',@pass), @adresse)";*/
                    command.CommandText = "PS_Client";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("Nom", entity.Nom);
                    command.Parameters.AddWithValue("Prenom", entity.Prenom);
                    command.Parameters.AddWithValue("AdresseMail", entity.AdresseMail);
                    command.Parameters.AddWithValue("MotdePasse", entity.MotdePasse);
                    command.Parameters.AddWithValue("Telephone", entity.Telephone);
                    command.Parameters.AddWithValue("Pays", entity.Pays);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }


        public bool Update(int id, Client entity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"UPDATE [Client]
                                            SET [Nom] = @Nom,
                                                [Prenom] = @Prenom,
                                                [AdresseMail] = @AdresseMail,
                                                [Pays] = @Pays
                                            WHERE [IdClient] = @id";
                    command.Parameters.AddWithValue("Nom", entity.Nom);
                    command.Parameters.AddWithValue("Prenom", entity.Prenom);
                    command.Parameters.AddWithValue("AdresseMail", entity.AdresseMail);
                    command.Parameters.AddWithValue("adresse", (object)entity.Pays?? DBNull.Value);
                    command.Parameters.AddWithValue("id", id);
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
                    command.CommandText = "DELETE FROM [Client] WHERE [IdClient] = @id";
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        
    }
}
