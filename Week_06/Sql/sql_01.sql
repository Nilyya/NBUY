USE master
GO

DROP DATABASE IF EXISTS HastaneDb
GO

CREATE DATABASE HastaneDb
GO

--�st taraf varsa hastanedb silip tekrar olu�turur
--yoksa zaten olu�turur.

USE HastaneDb
GO

CREATE TABLE Hastalar(
	�d INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	adSoyad NVARCHAR(50)NOT NULL,
	cinsiyet CHAR(1) NOT NULL,
	adres NVARCHAR(50),
	telefon CHAR(11)
)

INSERT INTO Hastalar(adSoyad, cinsiyet, adres) VALUES
	('Erencan Germirli','E','�stanbul'),
	('Selin Ferge�','K','Ankara'),
	('Sqadi Kulo�lu','E','�zmir'),
	('Me�e Kalabal�k','K','�stanbul'),
	('Sevda A�alar','K','�zmir'),
	('Nora Ta�kesen','K','Ankara'),
	('Emma �eto�lu','K','�stanbul'),
	('Kerem S�zc�','E','Ankara'),
	('Suat Tartar','E','�zmir')
GO

CREATE TABLE Bolumler(
id INT	NOT NULL PRIMARY KEY IDENTITY(1,1),
ad NVARCHAR(30) NOT NULL
)
GO
INSERT INTO Bolumler VALUES
('Dahiliye'),('N�roloji'),('Ortapedi'),('Di�'),('Periodontiloji'),('Genel Cerahi')
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
('Ali Can','�stanbul',1),
('Demet Evgar','Bursa',2),
('Sedat Kanar','�stanbul',3),
('Ferhunde Han�m','�zmir',1),
('Demet Evgar','Bursa',2),
('Hale Elveren','�stanbul',3),
('Tuna Sefer','Ankara',4),
('Kevser Tutku','�stanbul',4),
('Tutkum Kap��mak','�zmir',5),
('�sa Canova','�zmir',5),
('Tu��e B�l�ks�z','�stanbul',null)
GO

--INSERT INTO Doktorlar(adSoyad,adres) VALUES
--('Tu��e B�l�ks�z','�stanbul'),
--GO