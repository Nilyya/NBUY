--USE Northwind
--SELECT*FROM Products ORDER BY UnitPrice
--USE Northwind
--SELECT*FROM Products WHERE UnitPrice>=100
--USE Northwind
--SELECT*FROM Products 
--WHERE CategoryID=7 OR CategoryID=8
--USE Northwind
--SELECT*FROM Products 
--WHERE (CategoryID=7 OR CategoryID=8) AND UnitsInStock<=10
--USE Northwind
--SELECT COUNT(*)FROM Products 
--WHERE (CategoryID=7 OR CategoryID=8) AND UnitsInStock<=10
USE Northwind
--SELECT COUNT(*)FROM Products 
--WHERE (CategoryID=9 OR CategoryID=3) AND UnitsInStock<=50

--INNER JOIN
--SELECT Products.ProductName , Categories.CategoryName FROM Products INNER JOIN Categories
--	ON Products.CategoryID=Categories.CategoryID

--SELECT P.ProductName , C.CategoryName 
--FROM Products P INNER JOIN Categories C
--ON P.CategoryID=C.CategoryID

--SELECT P.ProductName , C.CategoryName 
--FROM Products P INNER JOIN Categories C
--ON P.CategoryID=C.CategoryID
--WHERE CategoryName='Beverages' AND P.UnitPrice<=40
--ORDER BY P.UnitPrice DESC

--Product Name ve Supplier Company Name'i gösteren bir sorgu yazýnýz
--SELECT P.ProductName,
--FROM  Products P INNER JOIN Suppliers S
--ON P.SupplierID = S.SupplierID
--WHERE S.Country='Germany'
--SELECT SUM(P.UnitPrice * P.UnitsInStock) as 'Toplam Tutar'
--FROM  Products P INNER JOIN Suppliers S
--ON P.SupplierID = S.SupplierID
--WHERE S.Country='Sweden'

--Çay satýþlarýnýn toplam tutar
--SELECT SUM(OD.UnitPrice * OD.Quantity)
--FROM Products P INNER JOIN  [Order Details] OD
--ON P.ProductID=OD.ProductID
--WHERE P.ProductName='Chai'

--Germany'e yapýlmýþ satýþlar
--SELECT SUM(OD.UnitPrice * OD.Quantity)
--FROM Orders O INNER JOIN [Order Details] OD
--ON O.OrderID=OD.OrderID INNER JOIN Products P
--ON OD.ProductID=P.ProductID
--WHERE P.ProductName='Chai' AND O.ShipCountry='Germany'

--Ernst Handel müþteriye yapýlan satýþ tutarlarýnýn toplamý
SELECT SUM(UnitPrice*Quantity)
FROM [Order Details] OD INNER JOIN Orders O
ON OD.OrderID=O.OrderID INNER JOIN Customers C
ON O.CustomerID=C.CustomerID
WHERE C.CompanyName='Ernst Handel'
