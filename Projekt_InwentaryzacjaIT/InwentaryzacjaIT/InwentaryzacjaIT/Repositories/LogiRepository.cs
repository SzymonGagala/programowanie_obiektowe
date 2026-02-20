using System;
using System.Data;
using Microsoft.Data.SqlClient;
using InwentaryzacjaIT.Models;

namespace InwentaryzacjaIT.Repositories
{
    public class LogiRepository
    {
        // "= null", żeby można było wywołać tę metodę bez parametrów w Form1
        public DataTable PobierzWszystkieLogi(string id = null)
        {
            var dt = new DataTable();
            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();

                string query = @"
                    SELECT 
                        l.DataZdarzenia,
                        
                        ISNULL(
                            ISNULL(u.NumerInwentarzowy, 'Brak Nr') + ' - ' + u.Model + ' (' + ISNULL(u.NumerSeryjny, 'Brak SN') + ')', 
                            '--- USUNIĘTO / BRAK ---'
                        ) AS Urzadzenie,
                        
                        l.TypZdarzenia,
                        l.StaraWartosc,
                        l.NowaWartosc
                    FROM LOGI l
                    LEFT JOIN URZADZENIA u ON l.IdUrzadzenia = u.Id
                    WHERE u.Id = {id}
                    ORDER BY l.DataZdarzenia DESC";

                if (id == null)
                {
                    query = query.Replace("WHERE u.Id = {id}", "");
                }
                else
                {
                    query = query.Replace("{id}", id);
                }

                using (var cmd = new SqlCommand(query, conn))
                using (var adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        public void Add(Log log)
        {
            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();

                var query = @"INSERT INTO LOGI 
                             (IdUrzadzenia, TypZdarzenia, StaraWartosc, NowaWartosc, DataZdarzenia) 
                             VALUES 
                             (@IdUrz, @Typ, @Stara, @Nowa, @Data)";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdUrz", (object)log.IdUrzadzenia ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Typ", log.TypZdarzenia);
                    cmd.Parameters.AddWithValue("@Stara", log.StaraWartosc ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Nowa", log.NowaWartosc ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Data", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}