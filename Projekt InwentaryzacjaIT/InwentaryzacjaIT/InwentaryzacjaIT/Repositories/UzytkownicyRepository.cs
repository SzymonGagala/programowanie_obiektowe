using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using InwentaryzacjaIT.Interfaces;
using InwentaryzacjaIT.Models;

namespace InwentaryzacjaIT.Repositories
{
    public class UzytkownicyRepository : IRepository<Uzytkownik>
    {
        public List<Uzytkownik> GetAll()
        {
            var list = new List<Uzytkownik>();
            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT * FROM UZYTKOWNICY", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Uzytkownik
                        {
                            Id = (int)reader["Id"],
                            Imie = reader["Imie"].ToString(),
                            Nazwisko = reader["Nazwisko"].ToString(),
                            NazwaUzytkownika = reader["NazwaUzytkownika"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public Uzytkownik GetById(int id)
        {
            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT * FROM UZYTKOWNICY WHERE Id = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Uzytkownik
                            {
                                Id = (int)reader["Id"],
                                Imie = reader["Imie"].ToString(),
                                Nazwisko = reader["Nazwisko"].ToString(),
                                NazwaUzytkownika = reader["NazwaUzytkownika"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }

        public int Add(Uzytkownik entity)
        {
            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                var query = "INSERT INTO UZYTKOWNICY (Imie, Nazwisko, NazwaUzytkownika) VALUES (@Imie, @Nazwisko, @Login); SELECT SCOPE_IDENTITY();";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Imie", entity.Imie);
                    cmd.Parameters.AddWithValue("@Nazwisko", entity.Nazwisko);
                    cmd.Parameters.AddWithValue("@Login", entity.NazwaUzytkownika);

                    decimal newId = (decimal)cmd.ExecuteScalar();
                    return (int)newId;
                }
            }
        }

        public void Update(Uzytkownik entity)
        {
            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                var query = "UPDATE UZYTKOWNICY SET Imie=@Imie, Nazwisko=@Nazwisko, NazwaUzytkownika=@Login WHERE Id=@Id";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", entity.Id);
                    cmd.Parameters.AddWithValue("@Imie", entity.Imie);
                    cmd.Parameters.AddWithValue("@Nazwisko", entity.Nazwisko);
                    cmd.Parameters.AddWithValue("@Login", entity.NazwaUzytkownika);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("DELETE FROM UZYTKOWNICY WHERE Id = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}