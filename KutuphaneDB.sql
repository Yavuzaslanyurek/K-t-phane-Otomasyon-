CREATE DATABASE KutuphaneDB;
GO

USE KutuphaneDB;
GO

CREATE TABLE Uyeler (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    TcNo NVARCHAR(11) NOT NULL UNIQUE,
    AdSoyad NVARCHAR(100) NOT NULL,
    Telefon NVARCHAR(15),
    Email NVARCHAR(100),
    Adres NVARCHAR(250),
    KayitTarihi DATETIME DEFAULT GETDATE(),
    Silindi BIT DEFAULT 0
);
GO

CREATE TABLE Kitaplar (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    ISBN NVARCHAR(20),
    KitapAdi NVARCHAR(150) NOT NULL,
    Yazar NVARCHAR(100) NOT NULL,
    Yayinevi NVARCHAR(100),
    SayfaSayisi INT,
    YayinYili INT,
    StokAdedi INT DEFAULT 0,
    Silindi BIT DEFAULT 0
);
GO

CREATE TABLE Emanetler (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    KitapId INT NOT NULL,
    UyeId INT NOT NULL,
    VerilisTarihi DATETIME DEFAULT GETDATE(),
    TeslimEdilmesiGerekenTarih DATETIME NOT NULL,
    TeslimEdilenTarih DATETIME NULL,
    TeslimEdildi BIT DEFAULT 0,
    DurumNotu NVARCHAR(250),
    CONSTRAINT FK_Emanetler_Kitaplar FOREIGN KEY (KitapId) REFERENCES Kitaplar(Id),
    CONSTRAINT FK_Emanetler_Uyeler FOREIGN KEY (UyeId) REFERENCES Uyeler(Id)
);
GO
