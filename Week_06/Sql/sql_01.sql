USE master
GO

DROP DATABASE IF EXISTS HastaneDb
GO

CREATE DATABASE HastaneDb
GO

--Üst taraf varsa hastanedb silip tekrar oluþturur
--yoksa zaten oluþturur.

USE HastaneDb
GO

CREATE TABLE Hastalar(
	Ýd INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	adSoyad NVARCHAR(50)NOT NULL,
	cinsiyet CHAR(1) NOT NULL,
	adres NVARCHAR(50),
	telefon CHAR(11)
)

INSERT INTO Hastalar(adSoyad, cinsiyet, adres) VALUES
	('Erencan Germirli','E','Ýstanbul'),
	('Selin Fergeç','K','Ankara'),
	('Sqadi Kuloðlu','E','Ýzmir'),
	('Meþe Kalabalýk','K','Ýstanbul'),
	('Sevda Aðalar','K','Ýzmir'),
	('Nora Taþkesen','K','Ankara'),
	('Emma Çetoðlu','K','Ýstanbul'),
	('Kerem Sözcü','E','Ankara'),
	('Suat Tartar','E','Ýzmir')
GO

CREATE TABLE Bolumler(
id INT	NOT NULL PRIMARY KEY IDENTITY(1,1),
ad NVARCHAR(30) NOT NULL
)
GO
INSERT INTO Bolumler VALUES
('Dahiliye'),('Nöroloji'),('Ortapedi'),('Diþ'),('Periodontiloji'),('Genel Cerahi')
GO
CREATE TABLE Doktorlar(
id INT	NOT NULL PRIMARY KEY IDENTITY(1,1),
ad NVARCHAR(50) NOT NULL,
adres NVARCHAR(50),
bolumId INT,
FOREIGN KEY(bolumId) REFERENCES Bolumler(id)
)
GO
INSERT INTO Doktorlar VALUES
('Ali Can','Ýstanbul',1),
('Demet Evgar','Bursa',2),
('Sedat Kanar','Ýstanbul',3),
('Ferhunde Haným','Ýzmir',1),
('Demet Evgar','Bursa',2),
('Hale Elveren','Ýstanbul',3),
('Tuna Sefer','Ankara',4),
('Kevser Tutku','Ýstanbul',4),
('Tutkum Kapýþmak','Ýzmir',5),
('Ýsa Canova','Ýzmir',5),
('Tuðçe Bölüksüz','Ýstanbul',null)
GO

--INSERT INTO Doktorlar(adSoyad,adres) VALUES
--('Tuðçe Bölüksüz','Ýstanbul'),
--GO