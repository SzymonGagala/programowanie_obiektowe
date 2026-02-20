using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using InwentaryzacjaIT.Interfaces;
using InwentaryzacjaIT.Models;

namespace InwentaryzacjaIT.Repositories
{
    public class StatusyRepository : IRepository<Status>
    {
        public List<Status> GetAll()
        {
            var list = new List<Status>();
            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT * FROM STATUSY", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Status
                        {
                            Id = (int)reader["Id"],
                            Nazwa = reader["Nazwa"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public Status GetById(int id)
        {
            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT * FROM STATUSY WHERE Id = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Status
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

        public int Add(Status entity)
        {
            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                var query = "INSERT INTO STATUSY (Nazwa) VALUES (@Nazwa); SELECT SCOPE_IDENTITY();";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nazwa", entity.Nazwa);
                    decimal newId = (decimal)cmd.ExecuteScalar();
                    return (int)newId;
                }
            }
        }

        public void Update(Status entity)
        {
            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                var query = "UPDATE STATUSY SET Nazwa=@Nazwa WHERE Id=@Id";
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
                var query = "DELETE FROM STATUSY WHERE Id = @Id";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}