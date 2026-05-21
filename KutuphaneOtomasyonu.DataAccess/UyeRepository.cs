using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using KutuphaneOtomasyonu.Entities;

namespace KutuphaneOtomasyonu.DataAccess
{
    public class UyeRepository
    {
        // 1. Tüm Üyeleri Listele
        public List<Uye> GetAll()
        {
            List<Uye> uyeler = new List<Uye>();
            using (SqlConnection connection = ConnectionHelper.GetConnection())
            {
                string query = "SELECT Id, TcNo, AdSoyad, Telefon, Email, Adres, KayitTarihi, Silindi FROM Uyeler WHERE Silindi = 0";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            uyeler.Add(new Uye
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                TcNo = reader["TcNo"]?.ToString() ?? string.Empty,
                                AdSoyad = reader["AdSoyad"].ToString() ?? string.Empty,
                                Telefon = reader["Telefon"]?.ToString() ?? string.Empty,
                                Email = reader["Email"]?.ToString() ?? string.Empty,
                                Adres = reader["Adres"]?.ToString() ?? string.Empty,
                                KayitTarihi = reader["KayitTarihi"] != DBNull.Value ? Convert.ToDateTime(reader["KayitTarihi"]) : DateTime.MinValue,
                                Silindi = Convert.ToBoolean(reader["Silindi"])
                            });
                        }
                    }
                }
            }
            return uyeler;
        }

        // 2. Yeni Üye Ekle
        public void Add(Uye uye)
        {
            using (SqlConnection connection = ConnectionHelper.GetConnection())
            {
                string query = @"INSERT INTO Uyeler (TcNo, AdSoyad, Telefon, Email, Adres, KayitTarihi, Silindi) 
                                 VALUES (@TcNo, @AdSoyad, @Telefon, @Email, @Adres, @KayitTarihi, 0)";
                
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TcNo", uye.TcNo);
                    command.Parameters.AddWithValue("@AdSoyad", uye.AdSoyad);
                    command.Parameters.AddWithValue("@Telefon", uye.Telefon ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Email", uye.Email ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Adres", uye.Adres ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@KayitTarihi", uye.KayitTarihi == DateTime.MinValue ? DateTime.Now : uye.KayitTarihi);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // 3. Üye Güncelle
        public void Update(Uye uye)
        {
            using (SqlConnection connection = ConnectionHelper.GetConnection())
            {
                string query = @"UPDATE Uyeler SET 
                                 TcNo = @TcNo, 
                                 AdSoyad = @AdSoyad, 
                                 Telefon = @Telefon, 
                                 Email = @Email, 
                                 Adres = @Adres 
                                 WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", uye.Id);
                    command.Parameters.AddWithValue("@TcNo", uye.TcNo);
                    command.Parameters.AddWithValue("@AdSoyad", uye.AdSoyad);
                    command.Parameters.AddWithValue("@Telefon", uye.Telefon ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Email", uye.Email ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Adres", uye.Adres ?? (object)DBNull.Value);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // 4. Üye Sil (Soft Delete)
        public void Delete(int id)
        {
            using (SqlConnection connection = ConnectionHelper.GetConnection())
            {
                string query = "UPDATE Uyeler SET Silindi = 1 WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // 5. Arama İşlemi
        public List<Uye> SearchByKeyword(string keyword)
        {
            List<Uye> uyeler = new List<Uye>();
            using (SqlConnection connection = ConnectionHelper.GetConnection())
            {
                string query = @"SELECT Id, TcNo, AdSoyad, Telefon, Email, Adres, KayitTarihi, Silindi 
                                 FROM Uyeler 
                                 WHERE Silindi = 0 AND 
                                 (TcNo LIKE @Keyword OR AdSoyad LIKE @Keyword OR Telefon LIKE @Keyword OR Email LIKE @Keyword)";
                
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Keyword", $"%{keyword}%");

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            uyeler.Add(new Uye
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                TcNo = reader["TcNo"]?.ToString() ?? string.Empty,
                                AdSoyad = reader["AdSoyad"].ToString() ?? string.Empty,
                                Telefon = reader["Telefon"]?.ToString() ?? string.Empty,
                                Email = reader["Email"]?.ToString() ?? string.Empty,
                                Adres = reader["Adres"]?.ToString() ?? string.Empty,
                                KayitTarihi = reader["KayitTarihi"] != DBNull.Value ? Convert.ToDateTime(reader["KayitTarihi"]) : DateTime.MinValue,
                                Silindi = Convert.ToBoolean(reader["Silindi"])
                            });
                        }
                    }
                }
            }
            return uyeler;
        }

        // 6. ID'ye Göre Getir
        public Uye GetById(int id)
        {
            Uye uye = null;
            using (SqlConnection connection = ConnectionHelper.GetConnection())
            {
                string query = "SELECT Id, TcNo, AdSoyad, Telefon, Email, Adres, KayitTarihi, Silindi FROM Uyeler WHERE Id = @Id AND Silindi = 0";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            uye = new Uye
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                TcNo = reader["TcNo"]?.ToString() ?? string.Empty,
                                AdSoyad = reader["AdSoyad"].ToString() ?? string.Empty,
                                Telefon = reader["Telefon"]?.ToString() ?? string.Empty,
                                Email = reader["Email"]?.ToString() ?? string.Empty,
                                Adres = reader["Adres"]?.ToString() ?? string.Empty,
                                KayitTarihi = reader["KayitTarihi"] != DBNull.Value ? Convert.ToDateTime(reader["KayitTarihi"]) : DateTime.MinValue,
                                Silindi = Convert.ToBoolean(reader["Silindi"])
                            };
                        }
                    }
                }
            }
            return uye;
        }
    }
}
