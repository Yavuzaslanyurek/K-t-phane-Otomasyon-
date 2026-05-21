using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using KutuphaneOtomasyonu.Entities;

namespace KutuphaneOtomasyonu.DataAccess
{
    public class EmanetRepository
    {
        // 1. Tüm Emanetleri Listele (JOIN ile Kitap ve Üye detayları dahil)
        public List<Emanet> GetAll()
        {
            List<Emanet> emanetler = new List<Emanet>();
            using (SqlConnection connection = ConnectionHelper.GetConnection())
            {
                string query = @"
                    SELECT 
                        e.Id, e.KitapId, e.UyeId, e.EmanetTarihi, e.TeslimTarihi, e.TeslimEdildiMi,
                        k.KitapAdi, u.AdSoyad AS UyeAdSoyad
                    FROM Emanetler e
                    INNER JOIN Kitaplar k ON e.KitapId = k.Id
                    INNER JOIN Uyeler u ON e.UyeId = u.Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            emanetler.Add(new Emanet
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                KitapId = Convert.ToInt32(reader["KitapId"]),
                                UyeId = Convert.ToInt32(reader["UyeId"]),
                                EmanetTarihi = Convert.ToDateTime(reader["EmanetTarihi"]),
                                TeslimTarihi = reader["TeslimTarihi"] != DBNull.Value ? Convert.ToDateTime(reader["TeslimTarihi"]) : (DateTime?)null,
                                TeslimEdildiMi = Convert.ToBoolean(reader["TeslimEdildiMi"]),
                                KitapAdi = reader["KitapAdi"]?.ToString() ?? string.Empty,
                                UyeAdSoyad = reader["UyeAdSoyad"]?.ToString() ?? string.Empty
                            });
                        }
                    }
                }
            }
            return emanetler;
        }

        // 2. Yeni Emanet Ekle
        public void Add(Emanet emanet)
        {
            using (SqlConnection connection = ConnectionHelper.GetConnection())
            {
                string query = @"INSERT INTO Emanetler 
                                 (KitapId, UyeId, EmanetTarihi, TeslimTarihi, TeslimEdildiMi) 
                                 VALUES 
                                 (@KitapId, @UyeId, @EmanetTarihi, @TeslimTarihi, @TeslimEdildiMi)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@KitapId", emanet.KitapId);
                    command.Parameters.AddWithValue("@UyeId", emanet.UyeId);
                    command.Parameters.AddWithValue("@EmanetTarihi", emanet.EmanetTarihi == DateTime.MinValue ? DateTime.Now : emanet.EmanetTarihi);

                    if (emanet.TeslimTarihi.HasValue)
                        command.Parameters.AddWithValue("@TeslimTarihi", emanet.TeslimTarihi.Value);
                    else
                        command.Parameters.AddWithValue("@TeslimTarihi", DBNull.Value);

                    command.Parameters.AddWithValue("@TeslimEdildiMi", emanet.TeslimEdildiMi);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // 3. Emanet Güncelle
        public void Update(Emanet emanet)
        {
            using (SqlConnection connection = ConnectionHelper.GetConnection())
            {
                string query = @"UPDATE Emanetler SET 
                                 KitapId = @KitapId, 
                                 UyeId = @UyeId, 
                                 EmanetTarihi = @EmanetTarihi, 
                                 TeslimTarihi = @TeslimTarihi, 
                                 TeslimEdildiMi = @TeslimEdildiMi 
                                 WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", emanet.Id);
                    command.Parameters.AddWithValue("@KitapId", emanet.KitapId);
                    command.Parameters.AddWithValue("@UyeId", emanet.UyeId);
                    command.Parameters.AddWithValue("@EmanetTarihi", emanet.EmanetTarihi);

                    if (emanet.TeslimTarihi.HasValue)
                        command.Parameters.AddWithValue("@TeslimTarihi", emanet.TeslimTarihi.Value);
                    else
                        command.Parameters.AddWithValue("@TeslimTarihi", DBNull.Value);

                    command.Parameters.AddWithValue("@TeslimEdildiMi", emanet.TeslimEdildiMi);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // 4. Emanet Sil (Fiziksel Silme)
        public void Delete(int id)
        {
            using (SqlConnection connection = ConnectionHelper.GetConnection())
            {
                string query = "DELETE FROM Emanetler WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // 5. Teslim Edilmeyen Aktif Emanetleri Listele (Business Katmanı ile tam uyum için)
        public List<Emanet> GetTeslimEdilmeyenler()
        {
            List<Emanet> emanetler = new List<Emanet>();
            using (SqlConnection connection = ConnectionHelper.GetConnection())
            {
                string query = @"
                    SELECT 
                        e.Id, e.KitapId, e.UyeId, e.EmanetTarihi, e.TeslimTarihi, e.TeslimEdildiMi,
                        k.KitapAdi, u.AdSoyad AS UyeAdSoyad
                    FROM Emanetler e
                    INNER JOIN Kitaplar k ON e.KitapId = k.Id
                    INNER JOIN Uyeler u ON e.UyeId = u.Id
                    WHERE e.TeslimEdildiMi = 0";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            emanetler.Add(new Emanet
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                KitapId = Convert.ToInt32(reader["KitapId"]),
                                UyeId = Convert.ToInt32(reader["UyeId"]),
                                EmanetTarihi = Convert.ToDateTime(reader["EmanetTarihi"]),
                                TeslimTarihi = reader["TeslimTarihi"] != DBNull.Value ? Convert.ToDateTime(reader["TeslimTarihi"]) : (DateTime?)null,
                                TeslimEdildiMi = Convert.ToBoolean(reader["TeslimEdildiMi"]),
                                KitapAdi = reader["KitapAdi"]?.ToString() ?? string.Empty,
                                UyeAdSoyad = reader["UyeAdSoyad"]?.ToString() ?? string.Empty
                            });
                        }
                    }
                }
            }
            return emanetler;
        }

        // 6. ID'ye Göre Getir
        public Emanet GetById(int id)
        {
            Emanet emanet = null;
            using (SqlConnection connection = ConnectionHelper.GetConnection())
            {
                string query = @"
                    SELECT 
                        e.Id, e.KitapId, e.UyeId, e.EmanetTarihi, e.TeslimTarihi, e.TeslimEdildiMi,
                        k.KitapAdi, u.AdSoyad AS UyeAdSoyad
                    FROM Emanetler e
                    INNER JOIN Kitaplar k ON e.KitapId = k.Id
                    INNER JOIN Uyeler u ON e.UyeId = u.Id
                    WHERE e.Id = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            emanet = new Emanet
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                KitapId = Convert.ToInt32(reader["KitapId"]),
                                UyeId = Convert.ToInt32(reader["UyeId"]),
                                EmanetTarihi = Convert.ToDateTime(reader["EmanetTarihi"]),
                                TeslimTarihi = reader["TeslimTarihi"] != DBNull.Value ? Convert.ToDateTime(reader["TeslimTarihi"]) : (DateTime?)null,
                                TeslimEdildiMi = Convert.ToBoolean(reader["TeslimEdildiMi"]),
                                KitapAdi = reader["KitapAdi"]?.ToString() ?? string.Empty,
                                UyeAdSoyad = reader["UyeAdSoyad"]?.ToString() ?? string.Empty
                            };
                        }
                    }
                }
            }
            return emanet;
        }
    }
}