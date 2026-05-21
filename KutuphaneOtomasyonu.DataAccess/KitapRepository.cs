using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using KutuphaneOtomasyonu.Entities;

namespace KutuphaneOtomasyonu.DataAccess
{
    public class KitapRepository
    {
        // 1. Tüm Kitapları Listele
        public List<Kitap> GetAll()
        {
            List<Kitap> kitaplar = new List<Kitap>();
            using (SqlConnection connection = ConnectionHelper.GetConnection())
            {
                // Silinmemiş kitapları listeleriz
                string query = "SELECT Id, ISBN, KitapAdi, Yazar, Yayinevi, SayfaSayisi, YayinYili, StokAdedi, Silindi FROM Kitaplar WHERE Silindi = 0";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            kitaplar.Add(new Kitap
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                ISBN = reader["ISBN"]?.ToString() ?? string.Empty,
                                KitapAdi = reader["KitapAdi"].ToString() ?? string.Empty,
                                Yazar = reader["Yazar"].ToString() ?? string.Empty,
                                Yayinevi = reader["Yayinevi"]?.ToString() ?? string.Empty,
                                SayfaSayisi = reader["SayfaSayisi"] != DBNull.Value ? Convert.ToInt32(reader["SayfaSayisi"]) : 0,
                                YayinYili = reader["YayinYili"] != DBNull.Value ? Convert.ToInt32(reader["YayinYili"]) : 0,
                                StokAdedi = reader["StokAdedi"] != DBNull.Value ? Convert.ToInt32(reader["StokAdedi"]) : 0,
                                Silindi = Convert.ToBoolean(reader["Silindi"])
                            });
                        }
                    }
                }
            }
            return kitaplar;
        }

        // 2. Yeni Kitap Ekle
        public void Add(Kitap kitap)
        {
            using (SqlConnection connection = ConnectionHelper.GetConnection())
            {
                string query = @"INSERT INTO Kitaplar (ISBN, KitapAdi, Yazar, Yayinevi, SayfaSayisi, YayinYili, StokAdedi, Silindi) 
                                 VALUES (@ISBN, @KitapAdi, @Yazar, @Yayinevi, @SayfaSayisi, @YayinYili, @StokAdedi, 0)";
                
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ISBN", kitap.ISBN ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@KitapAdi", kitap.KitapAdi);
                    command.Parameters.AddWithValue("@Yazar", kitap.Yazar);
                    command.Parameters.AddWithValue("@Yayinevi", kitap.Yayinevi ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@SayfaSayisi", kitap.SayfaSayisi);
                    command.Parameters.AddWithValue("@YayinYili", kitap.YayinYili);
                    command.Parameters.AddWithValue("@StokAdedi", kitap.StokAdedi);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // 3. Kitap Güncelle
        public void Update(Kitap kitap)
        {
            using (SqlConnection connection = ConnectionHelper.GetConnection())
            {
                string query = @"UPDATE Kitaplar SET 
                                 ISBN = @ISBN, 
                                 KitapAdi = @KitapAdi, 
                                 Yazar = @Yazar, 
                                 Yayinevi = @Yayinevi, 
                                 SayfaSayisi = @SayfaSayisi, 
                                 YayinYili = @YayinYili, 
                                 StokAdedi = @StokAdedi 
                                 WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", kitap.Id);
                    command.Parameters.AddWithValue("@ISBN", kitap.ISBN ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@KitapAdi", kitap.KitapAdi);
                    command.Parameters.AddWithValue("@Yazar", kitap.Yazar);
                    command.Parameters.AddWithValue("@Yayinevi", kitap.Yayinevi ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@SayfaSayisi", kitap.SayfaSayisi);
                    command.Parameters.AddWithValue("@YayinYili", kitap.YayinYili);
                    command.Parameters.AddWithValue("@StokAdedi", kitap.StokAdedi);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // 4. Kitap Sil (Soft Delete - Silindi bayrağını 1 yapar)
        public void Delete(int id)
        {
            using (SqlConnection connection = ConnectionHelper.GetConnection())
            {
                // Fiziksel silme yerine soft delete önerilir:
                string query = "UPDATE Kitaplar SET Silindi = 1 WHERE Id = @Id";
                
                // Eğer doğrudan fiziksel silme yapılması isteniyorsa aşağıdaki sorgu kullanılabilir:
                // string query = "DELETE FROM Kitaplar WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // 5. Arama İşlemi
        public List<Kitap> SearchByKeyword(string keyword)
        {
            List<Kitap> kitaplar = new List<Kitap>();
            using (SqlConnection connection = ConnectionHelper.GetConnection())
            {
                string query = @"SELECT Id, ISBN, KitapAdi, Yazar, Yayinevi, SayfaSayisi, YayinYili, StokAdedi, Silindi 
                                 FROM Kitaplar 
                                 WHERE Silindi = 0 AND 
                                 (KitapAdi LIKE @Keyword OR Yazar LIKE @Keyword OR ISBN LIKE @Keyword OR Yayinevi LIKE @Keyword)";
                
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Arama işleminde 'içeren' kayıtlara bakmak için % karakterlerini ekliyoruz
                    command.Parameters.AddWithValue("@Keyword", $"%{keyword}%");

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            kitaplar.Add(new Kitap
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                ISBN = reader["ISBN"]?.ToString() ?? string.Empty,
                                KitapAdi = reader["KitapAdi"].ToString() ?? string.Empty,
                                Yazar = reader["Yazar"].ToString() ?? string.Empty,
                                Yayinevi = reader["Yayinevi"]?.ToString() ?? string.Empty,
                                SayfaSayisi = reader["SayfaSayisi"] != DBNull.Value ? Convert.ToInt32(reader["SayfaSayisi"]) : 0,
                                YayinYili = reader["YayinYili"] != DBNull.Value ? Convert.ToInt32(reader["YayinYili"]) : 0,
                                StokAdedi = reader["StokAdedi"] != DBNull.Value ? Convert.ToInt32(reader["StokAdedi"]) : 0,
                                Silindi = Convert.ToBoolean(reader["Silindi"])
                            });
                        }
                    }
                }
            }
            return kitaplar;
        }

        // ID'ye Göre Tek Kitap Getirme
        public Kitap GetById(int id)
        {
            Kitap kitap = null;
            using (SqlConnection connection = ConnectionHelper.GetConnection())
            {
                string query = "SELECT Id, ISBN, KitapAdi, Yazar, Yayinevi, SayfaSayisi, YayinYili, StokAdedi, Silindi FROM Kitaplar WHERE Id = @Id AND Silindi = 0";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            kitap = new Kitap
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                ISBN = reader["ISBN"]?.ToString() ?? string.Empty,
                                KitapAdi = reader["KitapAdi"].ToString() ?? string.Empty,
                                Yazar = reader["Yazar"].ToString() ?? string.Empty,
                                Yayinevi = reader["Yayinevi"]?.ToString() ?? string.Empty,
                                SayfaSayisi = reader["SayfaSayisi"] != DBNull.Value ? Convert.ToInt32(reader["SayfaSayisi"]) : 0,
                                YayinYili = reader["YayinYili"] != DBNull.Value ? Convert.ToInt32(reader["YayinYili"]) : 0,
                                StokAdedi = reader["StokAdedi"] != DBNull.Value ? Convert.ToInt32(reader["StokAdedi"]) : 0,
                                Silindi = Convert.ToBoolean(reader["Silindi"])
                            };
                        }
                    }
                }
            }
            return kitap;
        }
    }
}
