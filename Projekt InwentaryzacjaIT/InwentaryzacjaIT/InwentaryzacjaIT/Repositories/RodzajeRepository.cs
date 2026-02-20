using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using InwentaryzacjaIT.Interfaces;
using InwentaryzacjaIT.Models;

namespace InwentaryzacjaIT.Repositories
{
    public class RodzajeRepository : IRepository<Rodzaj>
    {
        public List<Rodzaj> GetAll()
        {
            var list = new List<Rodzaj>();
            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT * FROM RODZAJE", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Rodzaj
                        {
                            Id = (int)reader["Id"],
                            Nazwa = reader["Nazwa"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public Rodzaj GetById(int id)
        {
            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT * FROM RODZAJE WHERE Id = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Rodzaj
                            {
                                Id = (int)reader["Id"],
                                Nazwa = reader["Nazwa"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }

        public int Add(Rodzaj entity)
        {
            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                var query = "INSERT INTO RODZAJE (Nazwa) VALUES (@Nazwa); SELECT SCOPE_IDENTITY();";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nazwa", entity.Nazwa);
                    decimal newId = (decimal)cmd.ExecuteScalar();
                    return (int)newId;
                }
            }
        }

        public void Update(Rodzaj entity)
        {
            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                var query = "UPDATE RODZAJE SET Nazwa=@Nazwa WHERE Id=@Id";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", entity.Id);
                    cmd.Parameters.AddWithValue("@Nazwa", entity.Nazwa);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                var query = "DELETE FROM RODZAJE WHERE Id = @Id";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public int PobierzLubDodaj(string nazwaRodzaju)
        {
            if (string.IsNullOrWhiteSpace(nazwaRodzaju))
            {
                nazwaRodzaju = "Inne";
            }

            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();

                // Sprawda czy istnieje
                var queryCheck = "SELECT Id FROM RODZAJE WHERE Nazwa = @Nazwa";
                using (var cmd = new SqlCommand(queryCheck, conn))
                {
                    cmd.Parameters.AddWithValue("@Nazwa", nazwaRodzaju.Trim());
                    var result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return (int)result;
                    }
                }

                // jeśli nie istnieje to dodaje
                var queryInsert = "INSERT INTO RODZAJE (Nazwa) VALUES (@Nazwa); SELECT SCOPE_IDENTITY();";
                using (var cmd = new SqlCommand(queryInsert, conn))
                {
                    cmd.Parameters.AddWithValue("@Nazwa", nazwaRodzaju.Trim());
                    decimal newId = (decimal)cmd.ExecuteScalar();
                    return (int)newId;
                }
            }
        }
    }
}