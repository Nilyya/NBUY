USE master
GO

DROP DATABASE IF EXISTS KutuphaneDb
GO

CREATE DATABASE KutuphaneDb
GO

USE KutuphaneDb
GO

CREATE TABLE Tur(
	�d INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(30) NOT NULL,	
)

INSERT INTO Tur(ad) VALUES
	('Bilim'),('�iir'),	('Polisiye'),('Tarih'),	('�ocuk'),('Klasikler'),('Roman')	
GO

USE KutuphaneDb
GO

CREATE TABLE Yazar(
	�d INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	adSoyad NVARCHAR(50)NOT NULL,
	cinsiyet CHAR(1) NOT NULL,
	yas INT 
)

INSERT INTO Yazarlar(adSoyad, cinsiyet, yas) VALUES
	('Ya�ar Kemal','E',Null),
	('Carl Sagan','E',Null),
	('Z�lf� Livaneli','E',76),
	('Ahmet �mit','E',62),
	('Virginia Woolf','K',null),
	('Naz�m Hikmet Ran','E',null),
	('Samed Behrengi','E',Null)	
GO


USE KutuphaneDb
GO

CREATE TABLE Yayinevi(
	�d INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	isim NVARCHAR(50)NOT NULL,
	kurulusYili INT NOT NULL,	 
)

INSERT INTO Yay�nevleri(isim,kurulusYili ) VALUES
	('YKY',1992),
	('Alt�n Kitaplar',1980),
	('�� Bankas� Yay�nlar�',1970),	
	('K�rm�z� Kedi',1990),	
	('Epsilon',1980)	
GO

USE KutuphaneDb
GO

CREATE TABLE Uye(
	�d INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	adSoyad NVARCHAR(50)NOT NULL,
	cinsiyet CHAR(1) NOT NULL,
	email NVARCHAR(20),
	telefon CHAR(11),
	ogrenci CHAR(1),
	
)

INSERT INTO Uyeler(adSoyad, cinsiyet, email, telefon, ogrenci) VALUES
	('Erencan Germirli','E','aaaaaa@gmail.com',05367624859,'E'),
	('Selin Ferge�','K','malazgirt@windowslive.com',05462581646,'H'),
	('Sadi Kulo�lu','E',NULL,05558999999,'E'),
	('Me�e Kalabal�k','K','hububat@hotmail.com',NULL,'H'),
	('Sevda A�alar','K','hadibuyur@hotmail.com',05594863612,'E'),
	('Nora Ta�kesen','K','semamama@gmail.com',05495551832,'H'),
	('Emma �eto�lu','K',NULL,05562331212,'E'),
	('Kerem S�zc�','E',NULL,05324567893,'E'),
	('Suat Tartar','E','selamselam@windowslive.com',05369994545,'E')

USE KutuphaneDb
GO

CREATE TABLE Kitaplar(
	id INT NOT NULL PRIMARY KEY,
	ad NVARCHAR(50)NOT NULL,
	yay�neviId INT FOREIGN KEY REFERENCES Yay�nevleri(id) ON DELETE CASCADE,
	yazarId INT FOREIGN KEY REFERENCES yazar(id) ON DELETE SET NULL,
	turId INT DEFAULT 1 FOREIGN KEY REFERENCES turler(id) ON DELETE SET Default			
)

INSERT INTO Kitaplar(ad,yay�neviId,yazarId,turId) VALUES
	('�nce Mehmet',1,1,1),
	('Sussuz Yaz',1,1,2),
	('Kozmos',2,2,3),
	('Leyla n�n Evi',3,3,4),
	('Orta Zekal�lar Cenneti',1,3,5),
	('Beyo�lunun en g�zel abisi',2,4,6),
	('Kendine ait bir oda',4,5,1),
	('Naz�m ile Piraye',1,6,1),
	('K���k Kara Bal�k',5,7,2) 
GO

CREATE TABLE oduncler(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	Ad NVARCHAR(50)NOT NULL,
	uyelerId INT FOREIGN KEY REFERENCES uyeler(id),		
)


INSERT INTO oduncler(ad, uyelerId) VALUES
	('�nce Mehmet',1),
	('Sussuz Yaz',2),
	('Kozmos',3),
	('Leyla n�n Evi',4),
	('Orta Zekal�lar Cenneti',5),
	('Beyo�lunun en g�zel abisi',6),
	('Kendine ait bir oda',7),
	('Naz�m ile Piraye',8),
	('K���k Kara Bal�k',9) 
GO