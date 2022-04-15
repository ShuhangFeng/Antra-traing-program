--All scenarios are based on Database NORTHWND.
USE Northwind
GO

--1.      List all cities that have both Employees and Customers.
SELECT City
FROM Employees
UNION
SELECT City
FROM Customers
--2.      List all cities that have Customers but no Employee.

--a.      Use sub-query
SELECT DISTINCT City
FROM Customers 
WHERE City not in(
SELECT City
FROM Employees
)

--b.      Do not use sub-query
SELECT City
FROM Customers
Except
SELECT City
FROM Employees

--3.      List all products and their total order quantities throughout all orders.
SELECT p.ProductName, SUM(o.Quantity) AS TotalOrderNum
FROM [Order Details] o JOIN Products p on o.ProductID = p.ProductID
GROUP BY p.ProductName

--4.      List all Customer Cities and total products ordered by that city.
SELECT c.City, SUM(od.Quantity) AS TotalOrderNum
FROM Customers c JOIN Orders o on c.CustomerID = o.CustomerID JOIN [Order Details] od on od.OrderID = o.OrderID
GROUP BY c.City

--5.      List all Customer Cities that have at least two customers.

--?
--a.      Use union
SELECT City
FROM Customers
Except
SELECT DISTINCT City
FROM Customers


--b.      Use sub-query and no union
SELECT City
FROM
(
SELECT City, COUNT(CustomerID) AS CustomerNum
FROM Customers
GROUP BY City
) dt
WHERE dt.CustomerNum >= 2

--6.      List all Customer Cities that have ordered at least two different kinds of products.
SELECT c.City, COUNT(DISTINCT od.ProductID) AS ProductKinds
FROM Customers c JOIN Orders o on c.CustomerID = o.CustomerID JOIN [Order Details] od on od.OrderID = o.OrderID
GROUP BY c.City
HAVING COUNT(DISTINCT od.ProductID) >=2


--7.      List all Customers who have ordered products, but have the ¡®ship city¡¯ on the order different from their own customer cities.
SELECT c.ContactName
FROM Customers c JOIN Orders o on c.CustomerID = o.CustomerID
WHERE c.City != o.ShipCity

--?
--8.      List 5 most popular products, their average price, and the customer city that ordered most quantity of it.
SELECT RANK() OVER(PARTITION BY o.OrderID ORDER BY SUM(o.OrderID) DESC) AS RNK
FROM Customers c JOIN Orders o on c.CustomerID = o.CustomerID JOIN [Order Details] od on od.OrderID = o.OrderID
GROUP BY o.OrderID


SELECT dt.ContactName, dt.Country, dt.NumOfOrders, dt.RNK FROM 
(SELECT c.ContactName, c.Country, COUNT(o.OrderID) AS NumOfOrders, RANK() OVER(PARTITION BY c.Country ORDER BY COUNT(o.OrderId) DESC) AS RNK
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID
GROUP BY c.ContactName, c.Country) dt
WHERE dt.RNK <= 3

--9.      List all cities that have never ordered something but we have employees there.

--a.      Use sub-query
SELECT City
FROM Employees
WHERE City not in(
SELECT ShipCity
FROM Orders)

--b.      Do not use sub-query
SELECT City
FROM Employees
Except
SELECT ShipCity
FROM Orders

--10.  List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, and also the city of most total quantity of products ordered from. (tip: join  sub-query)

SELECT *
FROM 
(SELECT TOP 1 o.ShipCity, COUNT(o.OrderID) as OrderNum
FROM Orders o
GROUP BY ShipCity
ORDER BY COUNT(o.OrderID) DESC) dt1
JOIN
(SELECT TOP 1 o.ShipCity, SUM(od.Quantity) AS ProductsQuantity
FROM Orders o JOIN [Order Details] od on o.OrderID = od.OrderID
GROUP BY o.ShipCity
ORDER BY SUM(od.Quantity) DESC) dt2
ON dt1.ShipCity = dt2.ShipCity

--11. How do you remove the duplicates record of a table?


--Text reply

-- use CTE and ROW_NUMBER(), create row_number for partitions for the columns you select,
-- then delete those row_number are not 1 because they are duplicates

--Upload a file
 