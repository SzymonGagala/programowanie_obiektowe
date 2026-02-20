using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using InwentaryzacjaIT.Interfaces;
using InwentaryzacjaIT.Models;

namespace InwentaryzacjaIT.Repositories
{
    // Klasa implementuje IRepository dla modelu lokalizacja
    public class LokalizacjeRepository : IRepository<Lokalizacja>
    {
        // pobierz wszystkie
        public List<Lokalizacja> GetAll()
        {
            var list = new List<Lokalizacja>();
            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT * FROM LOKALIZACJE", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Lokalizacja
                        {
                            Id = (int)reader["Id"],
                            NazwaBudynku = reader["NazwaBudynku"].ToString(),
                            NumerPokoju = reader["NumerPokoju"].ToString(),
                            Opis = reader["Opis"] == DBNull.Value ? "" : reader["Opis"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public Lokalizacja GetById(int id)
        {
            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT * FROM LOKALIZACJE WHERE Id = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Lokalizacja
                            {
                                Id = (int)reader["Id"],
                                NazwaBudynku = reader["NazwaBudynku"].ToString(),
                                NumerPokoju = reader["NumerPokoju"].ToString(),
                                Opis = reader["Opis"] == DBNull.Value ? "" : reader["Opis"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }

        public int Add(Lokalizacja entity)
        {
            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                var query = "INSERT INTO LOKALIZACJE (NazwaBudynku, NumerPokoju, Opis) VALUES (@Nazwa, @Numer, @Opis); SELECT SCOPE_IDENTITY();";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nazwa", entity.NazwaBudynku);
                    cmd.Parameters.AddWithValue("@Numer", entity.NumerPokoju);
                    cmd.Parameters.AddWithValue("@Opis", string.IsNullOrEmpty(entity.Opis) ? (object)DBNull.Value : entity.Opis);

                    decimal newId = (decimal)cmd.ExecuteScalar();// ExecuteScalar wykonuje zapytanie i zwraca pierwszą kolumnę pierwszego wiersza czyli id
                    return (int)newId;
                }
            }
        }

        public void Update(Lokalizacja entity)
        {
            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                var query = "UPDATE LOKALIZACJE SET NazwaBudynku=@Nazwa, NumerPokoju=@Numer, Opis=@Opis WHERE Id=@Id";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", entity.Id);
                    cmd.Parameters.AddWithValue("@Nazwa", entity.NazwaBudynku);
                    cmd.Parameters.AddWithValue("@Numer", entity.NumerPokoju);
                    cmd.Parameters.AddWithValue("@Opis", string.IsNullOrEmpty(entity.Opis) ? (object)DBNull.Value : entity.Opis);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                var query = "DELETE FROM LOKALIZACJE WHERE Id = @Id";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}