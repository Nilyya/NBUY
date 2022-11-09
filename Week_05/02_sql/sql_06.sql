CREATE DATABASE SirketDb2
GO

USE SirketDb2
CREATE TABLE Departmanlar(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(MAX) NOT NULL
)

INSERT INTO Departmanlar(ad) VALUES('Muhasebe'), ('Teknik'), ('Satýþ'),('ÝK'), ('Yönetim')

USE SirketDb2
CREATE TABLE Unvanlar(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(MAX) NOT NULL
)
INSERT INTO Unvanlar(ad) VALUES ('Ýþçi'),('Muhasebe Uzmaný'), ('Satýþçý'), ('ÝK Uzmaný'), ('ÝK Stajyeri'), ('Yöneticisi'), ('Yönetici Yardýmcýsý')  

USE SirketDb2
CREATE TABLE Iller(
	id CHAR(2) NOT NULL PRIMARY KEY,
	ad NVARCHAR(30) NOT NULL
)
INSERT INTO Iller(ad) VALUES
('34','Ýstanbul'),
('06', 'Ankara'),
('35','Ýzmir'),
('58', 'Sivas'),
('41','Ýzmit')

USE SirketDb2
CREATE TABLE Ilceler(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(30) NOT NULL,
	ilId CHAR(2) NOT NULL,
	FOREIGN KEY (ilId) REFERENCES Iller(id)
)
INSERT INTO Ilceler(ad,ilId) VALUES
('Kadýköy','34'),
('Beþiktaþ','34'),
('Avcýlar','34'),
('Konak', '35'),
('YeniMahalle', '06'),
('Çankaya','06'),
('Suþehri','58')

USE SirketDb2
CREATE TABLE Personel(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(25) NOT NULL,
	soyad NVARCHAR(25) NOT NULL,
	cinsiyet BIT NOT NULL,
	dogumTarihi DATE NOT NULL,
	ikametgahIlceId INT NOT NULL,
	iseBaslamaTarihi DATE NOT NULL,
	depertmanId INT NOT NULL,
	unvanId INT NOT NULL,
	maas MONEY NOT NULL,
	FOREIGN KEY(ikametgahIlceId) REFERENCES Ilceler(id),
	FOREIGN KEY(depertmanId) REFERENCES Departmanlar(id),
	FOREIGN KEY(unvanId)REFERENCES Unvanlar(id)
)
INSERT INTO Personel
(ad, soyad,cinsiyet,dogumTarihi,ikametgahIlceId,iseBaslamaTarihi,depertmanId,unvanId,maas)VALUES
('Alican','Kabak',0,'1999-05-23',1,'2011-01-13',1,6,125000),
('Ali','Kabak',0,'1990-05-23',2,'2012-12-19',2,5,225000),
('Hakan','Kabak',0,'1991-05-23',3,'2001-11-21',3,4,175000),
('Ayþe','Kabak',0,'1993-01-23',4,'2011-02-01',4,3,125000),
('Sema','Kabak',0,'1994-02-23',5,'2015-10-21',1,2,129000),
('Tuðçe','Kabak',0,'1995-02-23',4,'2011-11-31',2,1,145000),
('Zeynep','Kabak',0,'1997-03-23',1,'2021-11-15',3,6,125600),
('Berk','Kabak',0,'1998-09-23',2,'2022-08-27',4,5,245000),
('Ahmet','Kabak',0,'1988-05-23',3,'2001-03-07',1,4,455000),
('Sinan','Kabak',0,'1979-10-23',4,'2011-11-11',2,3,925000),
('Aliye','Kabak',0,'1969-11-23',5,'1989-01-16',3,2,335000),
('Alin','Kabak',0,'1959-12-23',3,'1978-03-15',4,1,126600),

USE SirketDb2

CREATE TABLE Projeler(
id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
ad NVARCHAR(50) NOT NULL,
)