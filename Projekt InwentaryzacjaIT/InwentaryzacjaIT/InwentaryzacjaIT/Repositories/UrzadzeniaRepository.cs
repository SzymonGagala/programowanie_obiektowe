using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using InwentaryzacjaIT.Models;
using InwentaryzacjaIT.Interfaces;

namespace InwentaryzacjaIT.Repositories
{
    public class UrzadzeniaRepository : IRepository<Urzadzenie>
    {
        public DataTable PobierzWszystkoDoWyswietlenia()
        {
            var dt = new DataTable();
            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                var query = @"
                    SELECT 
                        u.Id,
                        u.NumerInwentarzowy AS [Nr Inwentarzowy],
                        u.Model,
                        u.Producent,
                        r.Nazwa AS [Rodzaj],
                        s.Nazwa AS [Status],
                        l.NazwaBudynku + ' ' + l.NumerPokoju AS [Lokalizacja],
                        uz.Imie + ' ' + uz.Nazwisko AS [Użytkownik],
                        u.NumerSeryjny AS [Numer seryjny],
                        u.DataZakupu AS [Data Zakupu],
                        u.DataGwarancji AS [Gwarancja do]
                    FROM URZADZENIA u
                    LEFT JOIN RODZAJE r ON u.IdRodzaju = r.Id
                    LEFT JOIN STATUSY s ON u.IdStatusu = s.Id
                    LEFT JOIN LOKALIZACJE l ON u.IdLokalizacji = l.Id
                    LEFT JOIN UZYTKOWNICY uz ON u.IdUzytkownika = uz.Id";

                using (var cmd = new SqlCommand(query, conn))
                using (var adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        // metoda dla walidacji
        public List<string> PobierzZajeteNumery()
        {
            var lista = new List<string>();
            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                var query = "SELECT NumerInwentarzowy FROM URZADZENIA WHERE NumerInwentarzowy IS NOT NULL";
                using (var cmd = new SqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(reader["NumerInwentarzowy"].ToString());
                    }
                }
            }
            return lista;
        }

        // Metody z (IRepository<Urzadzenie>)

        public List<Urzadzenie> GetAll()
        {
            return new List<Urzadzenie>();
        }

        public Urzadzenie GetById(int id)
        {
            Urzadzenie u = null;
            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                var query = "SELECT * FROM URZADZENIA WHERE Id = @Id";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            u = new Urzadzenie
                            {
                                Id = (int)reader["Id"],
                                Model = reader["Model"].ToString(),
                                Producent = reader["Producent"].ToString(),
                                NumerInwentarzowy = reader["NumerInwentarzowy"] as string,
                                NumerSeryjny = reader["NumerSeryjny"] as string,
                                IdStatusu = (int)reader["IdStatusu"],
                                IdLokalizacji = (int)reader["IdLokalizacji"],
                                IdRodzaju = reader["IdRodzaju"] as int?,
                                IdUzytkownika = reader["IdUzytkownika"] as int?,
                                DataZakupu = (DateTime)reader["DataZakupu"],
                                DataGwarancji = reader["DataGwarancji"] as DateTime?
                            };
                        }
                    }
                }
            }
            return u;
        }

        public int Add(Urzadzenie entity)
        {
            int newId = 0;
            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                var query = @"INSERT INTO URZADZENIA 
                            (NumerInwentarzowy, NumerSeryjny, Model, Producent, DataZakupu, DataGwarancji, IdStatusu, IdLokalizacji, IdRodzaju, IdUzytkownika) 
                            VALUES 
                            (@NrInw, @Sn, @Model, @Prod, @DataZak, @DataGw, @Stat, @Lok, @Rodz, @User);
                            SELECT SCOPE_IDENTITY();";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NrInw", (object)entity.NumerInwentarzowy ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Sn", (object)entity.NumerSeryjny ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Model", entity.Model);
                    cmd.Parameters.AddWithValue("@Prod", entity.Producent);
                    cmd.Parameters.AddWithValue("@DataZak", entity.DataZakupu);
                    cmd.Parameters.AddWithValue("@DataGw", (object)entity.DataGwarancji ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Stat", entity.IdStatusu);
                    cmd.Parameters.AddWithValue("@Lok", entity.IdLokalizacji);
                    cmd.Parameters.AddWithValue("@Rodz", (object)entity.IdRodzaju ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@User", (object)entity.IdUzytkownika ?? DBNull.Value);

                    newId = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return newId;
        }

        public void Update(Urzadzenie entity)
        {
            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                var query = @"UPDATE URZADZENIA SET 
                            NumerInwentarzowy = @NrInw, 
                            NumerSeryjny = @Sn, 
                            Model = @Model, 
                            Producent = @Prod, 
                            DataZakupu = @DataZak, 
                            DataGwarancji = @DataGw, 
                            IdStatusu = @Stat, 
                            IdLokalizacji = @Lok, 
                            IdRodzaju = @Rodz, 
                            IdUzytkownika = @User
                            WHERE Id = @Id";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", entity.Id);
                    cmd.Parameters.AddWithValue("@NrInw", (object)entity.NumerInwentarzowy ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Sn", (object)entity.NumerSeryjny ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Model", entity.Model);
                    cmd.Parameters.AddWithValue("@Prod", entity.Producent);
                    cmd.Parameters.AddWithValue("@DataZak", entity.DataZakupu);
                    cmd.Parameters.AddWithValue("@DataGw", (object)entity.DataGwarancji ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Stat", entity.IdStatusu);
                    cmd.Parameters.AddWithValue("@Lok", entity.IdLokalizacji);
                    cmd.Parameters.AddWithValue("@Rodz", (object)entity.IdRodzaju ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@User", (object)entity.IdUzytkownika ?? DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();

                var query = "DELETE FROM URZADZENIA WHERE Id = @Id";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}