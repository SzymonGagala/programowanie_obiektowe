using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using InwentaryzacjaIT.Interfaces;
using InwentaryzacjaIT.Models;

namespace InwentaryzacjaIT.Repositories
{
    public class FakturyRepository : IRepository<Faktura>
    {
        public List<Faktura> GetAll()
        {
            var list = new List<Faktura>();
            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT * FROM FAKTURY", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Faktura
                        {
                            Id = (int)reader["Id"],
                            NumerFaktury = reader["NumerFaktury"].ToString(),
                            Sprzedawca = reader["Sprzedawca"].ToString(),
                            Kwota = (decimal)reader["Kwota"],
                            DataWystawienia = (DateTime)reader["DataWystawienia"],
                            SciezkaDoPliku = reader["SciezkaDoPliku"] == DBNull.Value ? "" : reader["SciezkaDoPliku"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public Faktura GetById(int id)
        {
            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT * FROM FAKTURY WHERE Id = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Faktura
                            {
                                Id = (int)reader["Id"],
                                NumerFaktury = reader["NumerFaktury"].ToString(),
                                Sprzedawca = reader["Sprzedawca"].ToString(),
                                Kwota = (decimal)reader["Kwota"],
                                DataWystawienia = (DateTime)reader["DataWystawienia"],
                                SciezkaDoPliku = reader["SciezkaDoPliku"] == DBNull.Value ? "" : reader["SciezkaDoPliku"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }

        public int Add(Faktura entity)
        {
            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                var query = "INSERT INTO FAKTURY (NumerFaktury, Sprzedawca, Kwota, DataWystawienia, SciezkaDoPliku) VALUES (@Nr, @Sprzed, @Kwota, @Data, @Plik); SELECT SCOPE_IDENTITY();";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nr", entity.NumerFaktury);
                    cmd.Parameters.AddWithValue("@Sprzed", entity.Sprzedawca);
                    cmd.Parameters.AddWithValue("@Kwota", entity.Kwota);
                    cmd.Parameters.AddWithValue("@Data", entity.DataWystawienia);
                    cmd.Parameters.AddWithValue("@Plik", entity.SciezkaDoPliku ?? (object)DBNull.Value);

                    decimal newId = (decimal)cmd.ExecuteScalar();
                    return (int)newId;
                }
            }
        }

        public void Update(Faktura entity)
        {
            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                var query = "UPDATE FAKTURY SET NumerFaktury=@Nr, Sprzedawca=@Sprzed, Kwota=@Kwota, DataWystawienia=@Data, SciezkaDoPliku=@Plik WHERE Id=@Id";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", entity.Id);
                    cmd.Parameters.AddWithValue("@Nr", entity.NumerFaktury);
                    cmd.Parameters.AddWithValue("@Sprzed", entity.Sprzedawca);
                    cmd.Parameters.AddWithValue("@Kwota", entity.Kwota);
                    cmd.Parameters.AddWithValue("@Data", entity.DataWystawienia);
                    cmd.Parameters.AddWithValue("@Plik", entity.SciezkaDoPliku ?? (object)DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Delete(int id)
        {
            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("DELETE FROM FAKTURY WHERE Id = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}