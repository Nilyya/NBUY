USE master
GO

DROP DATABASE IF EXISTS KutuphaneDb
GO

CREATE DATABASE KutuphaneDb
GO

USE KutuphaneDb
GO

CREATE TABLE Tur(
	Ýd INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(30) NOT NULL,	
)

INSERT INTO Tur(ad) VALUES
	('Bilim'),('Þiir'),	('Polisiye'),('Tarih'),	('Çocuk'),('Klasikler'),('Roman')	
GO

USE KutuphaneDb
GO

CREATE TABLE Yazar(
	Ýd INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	adSoyad NVARCHAR(50)NOT NULL,
	cinsiyet CHAR(1) NOT NULL,
	yas INT 
)

INSERT INTO Yazarlar(adSoyad, cinsiyet, yas) VALUES
	('Yaþar Kemal','E',Null),
	('Carl Sagan','E',Null),
	('Zülfü Livaneli','E',76),
	('Ahmet Ümit','E',62),
	('Virginia Woolf','K',null),
	('Nazým Hikmet Ran','E',null),
	('Samed Behrengi','E',Null)	
GO


USE KutuphaneDb
GO

CREATE TABLE Yayinevi(
	Ýd INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	isim NVARCHAR(50)NOT NULL,
	kurulusYili INT NOT NULL,	 
)

INSERT INTO Yayýnevleri(isim,kurulusYili ) VALUES
	('YKY',1992),
	('Altýn Kitaplar',1980),
	('Ýþ Bankasý Yayýnlarý',1970),	
	('Kýrmýzý Kedi',1990),	
	('Epsilon',1980)	
GO

USE KutuphaneDb
GO

CREATE TABLE Uye(
	Ýd INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	adSoyad NVARCHAR(50)NOT NULL,
	cinsiyet CHAR(1) NOT NULL,
	email NVARCHAR(20),
	telefon CHAR(11),
	ogrenci CHAR(1),
	
)

INSERT INTO Uyeler(adSoyad, cinsiyet, email, telefon, ogrenci) VALUES
	('Erencan Germirli','E','aaaaaa@gmail.com',05367624859,'E'),
	('Selin Fergeç','K','malazgirt@windowslive.com',05462581646,'H'),
	('Sadi Kuloðlu','E',NULL,05558999999,'E'),
	('Meþe Kalabalýk','K','hububat@hotmail.com',NULL,'H'),
	('Sevda Aðalar','K','hadibuyur@hotmail.com',05594863612,'E'),
	('Nora Taþkesen','K','semamama@gmail.com',05495551832,'H'),
	('Emma Çetoðlu','K',NULL,05562331212,'E'),
	('Kerem Sözcü','E',NULL,05324567893,'E'),
	('Suat Tartar','E','selamselam@windowslive.com',05369994545,'E')

USE KutuphaneDb
GO

CREATE TABLE Kitaplar(
	id INT NOT NULL PRIMARY KEY,
	ad NVARCHAR(50)NOT NULL,
	yayýneviId INT FOREIGN KEY REFERENCES Yayýnevleri(id) ON DELETE CASCADE,
	yazarId INT FOREIGN KEY REFERENCES yazar(id) ON DELETE SET NULL,
	turId INT DEFAULT 1 FOREIGN KEY REFERENCES turler(id) ON DELETE SET Default			
)

INSERT INTO Kitaplar(ad,yayýneviId,yazarId,turId) VALUES
	('Ýnce Mehmet',1,1,1),
	('Sussuz Yaz',1,1,2),
	('Kozmos',2,2,3),
	('Leyla nýn Evi',3,3,4),
	('Orta Zekalýlar Cenneti',1,3,5),
	('Beyoðlunun en güzel abisi',2,4,6),
	('Kendine ait bir oda',4,5,1),
	('Nazým ile Piraye',1,6,1),
	('Küçük Kara Balýk',5,7,2) 
GO

CREATE TABLE oduncler(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	Ad NVARCHAR(50)NOT NULL,
	uyelerId INT FOREIGN KEY REFERENCES uyeler(id),		
)


INSERT INTO oduncler(ad, uyelerId) VALUES
	('Ýnce Mehmet',1),
	('Sussuz Yaz',2),
	('Kozmos',3),
	('Leyla nýn Evi',4),
	('Orta Zekalýlar Cenneti',5),
	('Beyoðlunun en güzel abisi',6),
	('Kendine ait bir oda',7),
	('Nazým ile Piraye',8),
	('Küçük Kara Balýk',9) 
GO