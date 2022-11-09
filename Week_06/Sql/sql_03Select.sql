--USE HastaneDb
--SELECT * FROM Bolumler

--USE HastaneDb
--SELECT * FROM Doktorlar

--USE HastaneDb
--SELECT adSoyad as 'AD SOYAD', adres as ADRES FROM Doktorlar
--Filtreleme
--SELECT * FROM Doktorlar WHERE id=5
--SELECT * FROM Doktorlar WHERE adSoyad='Tuna Sefer'
--SELECT * FROM Doktorlar WHERE adSoyad!='Tuna Sefer'
--SELECT * FROM Doktorlar WHERE id=3 OR id=6
--SELECT * FROM Doktorlar WHERE NOT adSoyad='Tuna Sefer'
--SELECT * FROM Doktorlar WHERE bolumId=5 AND adres='Ýzmir'
--SELECT * FROM Doktorlar WHERE id>=6
--SELECT * FROM Doktorlar WHERE adres IN('ankara','istanbul')
--SELECT * FROM Doktorlar WHERE adSoyad LIKE 't%'
--SELECT * FROM Doktorlar WHERE adSoyad LIKE 'tut%'
--SELECT * FROM Doktorlar WHERE adSoyad LIKE '%evgar'
--SELECT * FROM Doktorlar WHERE adSoyad LIKE '%s%'
--SELECT * FROM Doktorlar WHERE adSoyad LIKE '_e%'
--SELECT * FROM Doktorlar WHERE adSoyad LIKE 'd_m%'

--Sýralama
--SELECT * FROM Doktorlar ORDER BY adSoyad
--SELECT * FROM Doktorlar ORDER BY adSoyad DESC
--SELECT * FROM Doktorlar ORDER BY bolumId DESC
--SELECT * FROM Doktorlar ORDER BY adres
--SELECT * FROM Doktorlar ORDER BY adres, adSoyad DESC

--Hesaplama
--USE HastaneDb
--SELECT * FROM Kitaplar 
--SELECT MIN(sayfaSayisi) as 'En Az Sayfa Sayýsý' FROM Kitaplar
--SELECT MAX(sayfaSayisi) as 'En Çok Sayfa Sayýsý' FROM Kitaplar
--SELECT COUNT(*) FROM Doktorlar
--SELECT COUNT(bolumId) FROM Doktorlar
--USE KutuphaneDb
--SELECT AVG(sayfaSayisi) FROM Kitaplar
--SELECT SUM(stok) FROM Kitaplar
--SELECT SUM(stok*sayfaSayisi) FROM Kitaplar

--STRING
--USE HastaneDb
--SELECT LENGTH ('Aylin Aydemir')
--SELECT adSoyad, LEN(adSoyad) as 'Uzunluk' FROM Doktorlar
--SELECT 
--	adSoyad, 
--	LEFT(adSoyad,3) as 'Ýlk Üç Karakter', 
--	LEN(adSoyad) as 'Uzunluk' 
--FROM Doktorlar
--SELECT
--	adSoyad,
--	UPPER(adSoyad) as 'BÜYÜK',
--	LOWER(adSoyad) as 'küçük'
--FROM Doktorlar

--SELECT
	--REPLACE('Aylin Aydemir','y','MERHABA')
	--LOWER (REPLACE('Aylin Aydemir',' ','')) + '@benimfirmam.com'
--SELECT
--	adSoyad,
--	REPLACE(LOWER(adSoyad),' ','') + @firma.com as 'Mail Adresi'
--FROM Doktorlar
--Sercan Furkan adýnda Amasyada yaþayan bölümü 3 olan doktoru yazýnýz

--USE HastaneDb
--INSERT INTO Doktorlar VALUES
--('Sercan Furkan','Amasya',3)

--Günceleme
--USE HastaneDb
--UPDATE Doktorlar SET adSoyad='Sercan Ahmet Furkan'
--WHERE id=12
--USE HastaneDb
--UPDATE Doktorlar SET adSoyad='Al Sana Yeni Ýsim'

--USE KutuphaneDb
--UPDATE Kitaplar SET sayfaSayisi = sayfaSayisi * 1.2

--Silme
--USE HastaneDb
--DELETE FROM Doktorlar WHERE id=4
USE HastaneDb
DELETE FROM Doktorlar WHERE bolumId IS NULL
