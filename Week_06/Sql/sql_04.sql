--sayfa sayýsý 300 den büyük eþit olan kitaplarý listeleyin

--USE KutuphaneDb
--SELECT * FROM Kitaplar WHERE sayfaSayisi>=300

--stok adeti 90-113 arasýnda olanlarý listelesin
--USE KutuphaneDb
--SELECT * FROM Kitaplar WHERE stok>=90 AND stok<=113

--USE KutuphaneDb
--SELECT * FROM Kitaplar WHERE BETWEEN 90 AND 113

--USE KutuphaneDb
--SELECT * FROM kitaplar ORDER BY SayfaSayisi DESC

--Türlere göre
--USE KutuphaneDb
--SELECT * FROM kitaplar ORDER BY turId,sayfaSayisi DESC 
