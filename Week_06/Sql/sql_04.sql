--sayfa say�s� 300 den b�y�k e�it olan kitaplar� listeleyin

--USE KutuphaneDb
--SELECT * FROM Kitaplar WHERE sayfaSayisi>=300

--stok adeti 90-113 aras�nda olanlar� listelesin
--USE KutuphaneDb
--SELECT * FROM Kitaplar WHERE stok>=90 AND stok<=113

--USE KutuphaneDb
--SELECT * FROM Kitaplar WHERE BETWEEN 90 AND 113

--USE KutuphaneDb
--SELECT * FROM kitaplar ORDER BY SayfaSayisi DESC

--T�rlere g�re
--USE KutuphaneDb
--SELECT * FROM kitaplar ORDER BY turId,sayfaSayisi DESC 
