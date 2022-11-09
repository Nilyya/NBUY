USE Northwind

--SELECT *FROM Customers C INNER JOIN Orders O
--ON C.CustomerID = O.CustomerID

--SELECT C.CompanyName FROM Customers C LEFT JOIN Orders O
--ON C.CustomerID = O.CustomerID
--WHERE o.OrderID IS NULL

--SELECT C.CompanyName FROM Orders O RIGHT JOIN Customers C
--ON C.CustomerID = O.CustomerID
--WHERE o.OrderID IS NULL

--SELECT P.ProductName, OD.ProductID, OD.OrderID FROM Products P LEFT JOIN [Order Details] OD
--ON P.ProductID = OD.ProductID
--WHERE OD.ProductID IS NULL

SELECT * FROM Employees E LEFT JOIN Orders O
ON E.EmployeeID = O.EmployeeID
WHERE O.EmployeeID IS NULL