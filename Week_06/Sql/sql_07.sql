USE Northwind

--SELECT DISTINCT CategoryId FROM Products

--1)bug�ne kadar hangi �lkelere kargo g�ndermisiz
--SELECT DISTINCT ShipCountry FROM Orders
--ORDER BY ShipCountry

--2)Hangi �lkeye ne kadar sat�� yapm���z
--SELECT O.ShipCountry, SUM(OD.Quantity*OD.UnitPrice) as 'Toplam Tutar' FROM Orders O INNER JOIN [Order Details] OD
--ON O.OrderID=OD.OrderID
--GROUP BY O.ShipCountry
--ORDER BY 'Toplam Tutar' DESC

--3) En �ok sat�� yap�lan �� �lke
--SELECT TOP(3) O.ShipCountry, SUM(OD.Quantity*OD.UnitPrice) as 'Toplam Tutar' FROM Orders O INNER JOIN [Order Details] OD
--ON O.OrderID=OD.OrderID
--GROUP BY O.ShipCountry
--ORDER BY 'Toplam Tutar' DESC

--4) Elimizde en �ok sto�u bulunan ilk �� �r�n
--SELECT TOP(3) P.ProductName, P.UnitsInStock FROM Products P
--ORDER BY P.UnitsInStock DESC

--5) Hangi kategoride ka� adet �r�n var
--SELECT C.CategoryName, COUNT(*) as 'Adet' FROM Categories C INNER JOIN Products P
--ON C.CategoryID = P.CategoryID
--GROUP BY C.CategoryName
--HAVING COUNT(*)>10
--ORDER BY Adet DESC

--6) Hangi �r�nden ka� tane sat�lm��t�r.
--SELECT P.ProductName,COUNT(*) as 'Adet' FROM Products P INNER JOIN  [Order Details] OD
--ON P.ProductID=OD.ProductID
--GROUP BY P.ProductName
--ORDER BY Adet DESC


--7)En �ok kazand�ran ilk �� �r�n.
--SELECT P.ProductName,SUM(OD.Quantity*OD.UnitPrice) as 'Total' FROM Products P INNER JOIN  [Order Details] OD
--ON P.ProductID=OD.ProductID
--GROUP BY P.ProductName
--ORDER BY Total DESC



--8) Hangi kargo �irketine ne kadar �deme yap�lm��t�r.(Freight)
--SELECT S.CompanyName, SUM(O.Freight)as 'Total' FROM Shippers S INNER JOIN Orders O
--ON S.ShipperID=O.ShipVia
--GROUP BY S.CompanyName
--ORDER BY Total DESC

--9)
--SELECT TOP(1) S.CompanyName, SUM(O.Freight)as 'Total' FROM Shippers S INNER JOIN Orders O
--ON S.ShipperID=O.ShipVia
--GROUP BY S.CompanyName
--ORDER BY Total 


--10) HAngi b�lgede , hangi �r�nden ka� paral�k sat�� yap�lm��t�r
--SELECT C.CompanyName, SUM(OD.Quantity*OD.UnitPrice) as 'Total'
--FROM Customers C
--INNER JOIN Orders O ON C.CustomerID=O.CustomerID 
--INNER JOIN [Order Details] OD  ON O.OrderID=OD.OrderID
--GROUP BY C.CompanyName
--ORDER BY Total DESC

--11)B�lgelere g�re sat�� tutarlar�
--SELECT R.RegionDescription, SUM(OD.Quantity*OD.UnitPrice) Total FROM Employees E 
--INNER JOIN EmployeeTerritories ET ON E.EmployeeID=ET.EmployeeID
--INNER JOIN Territories T ON ET.TerritoryID=T.TerritoryID
--INNER JOIN Region R ON T.RegionID=R.RegionID
--INNER JOIN Orders O ON E.EmployeeID=O.EmployeeID
--INNER JOIN [Order Details] OD ON O.OrderID=OD.OrderID
--GROUP BY R.RegionDescription
--ORDER BY Total DESC
--12) Hangi b�lgede, hangi r�nden ka� paral�k sat�� yap�lm��t�r
SELECT R.RegionDescription, P.ProductName, SUM(OD.Quantity*OD.UnitPrice) Total FROM Employees E 
INNER JOIN EmployeeTerritories ET ON E.EmployeeID=ET.EmployeeID
INNER JOIN Territories T ON ET.TerritoryID=T.TerritoryID
INNER JOIN Region R ON T.RegionID=R.RegionID
INNER JOIN Orders O ON E.EmployeeID=O.EmployeeID
INNER JOIN [Order Details] OD ON O.OrderID=OD.OrderID
INNER JOIN Products P ON OD.ProductID=P.ProductID
GROUP BY R.RegionDescription, P.ProductName
ORDER BY R.RegionDescription, P.ProductName, Total DESC