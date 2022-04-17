USE Northwind
GO

--Use Northwind database.  Write query for each step. Do not use IDE. BE CAREFUL WHEN DELETING DATA OR DROPPING TABLE.

--1.      Create a view named ¡°view_product_order_[your_last_name]¡±, list all products and total ordered quantity for that product.
CREATE VIEW view_product_order_feng AS
SELECT ProductName, UnitsOnOrder
FROM Products


--2.      Create a stored procedure ¡°sp_product_order_quantity_[your_last_name]¡± that accept product id as an input and total quantities of order as output parameter.
DROP PROC sp_product_order_quantity_Feng

CREATE PROC sp_product_order_quantity_Feng
@id int,
@quantities smallint output
AS
BEGIN
SELECT @quantities = UnitsOnOrder
FROM Products
WHERE @id = ProductID
END

-- for testing
--DECLARE @result INT;

--EXEC sp_product_order_quantity_Feng
--    @id = 3,
--    @quantities = @result OUTPUT;

--SELECT @result AS 'Number of total quantities';

--3.      Create a stored procedure ¡°sp_product_order_city_[your_last_name]¡± that accept product name as an input and top 5 cities that ordered most that product combined with the total quantity of that product ordered from that city as output.
DROP PROC sp_product_order_city_Feng

CREATE PROC sp_product_order_city_Feng
@name nvarchar(40)
AS
BEGIN
SELECT TOP 5 dt.ShipCity, dt.ProductsSoldNum
FROM
(
SELECT p.ProductName, o.ShipCity, SUM(od.Quantity) AS ProductsSoldNum
FROM Products p JOIN [Order Details] od on p.ProductID = od.ProductID JOIN Orders o on od.OrderID = o.OrderID
GROUP BY p.ProductName, o.ShipCity
) dt
WHERE dt.ProductName = @name
ORDER BY dt.ProductsSoldNum DESC
END

EXEC sp_product_order_city_Feng 'Gorgonzola Telino'

--SELECT TOP 5 dt.ShipCity, dt.ProductsSoldNum
--FROM
--(
--SELECT p.ProductName, o.ShipCity, SUM(od.Quantity) AS ProductsSoldNum
--FROM Products p JOIN [Order Details] od on p.ProductID = od.ProductID JOIN Orders o on od.OrderID = o.OrderID
--GROUP BY p.ProductName, o.ShipCity
--) dt
--WHERE dt.ProductName = 'Gorgonzola Telino'
--ORDER BY dt.ProductsSoldNum DESC


--4.      Create 2 new tables ¡°people_your_last_name¡± ¡°city_your_last_name¡±. City table has two records: {Id:1, City: Seattle}, {Id:2, City: Green Bay}. People has three records: {id:1, Name: Aaron Rodgers, City: 2}, {id:2, Name: Russell Wilson, City:1}, {Id: 3, Name: Jody Nelson, City:2}. Remove city of Seattle. If there was anyone from Seattle, put them into a new city ¡°Madison¡±. Create a view ¡°Packers_your_name¡± lists all people from Green Bay. If any error occurred, no changes should be made to DB. (after test) Drop both tables and view.
DROP TABLE city_feng

CREATE TABLE city_feng(
Id int Primary Key,
City varchar(20)
)

DROP TABLE people_feng

CREATE TABLE people_feng(
Id int Primary Key,
Name varchar(20),
City int FOREIGN KEY REFERENCES city_feng(Id) on delete cascade
)

INSERT INTO city_feng VALUES(1, 'Seattle')
INSERT INTO city_feng VALUES(2, 'Green Bay')

INSERT INTO people_feng VALUES(1, 'Aaron Rodgers', 2)
INSERT INTO people_feng VALUES(2, 'Russell Wilson', 1)
INSERT INTO people_feng VALUES(3, 'Jody Nelson', 2)

SELECT *
FROM city_feng

SELECT * 
FROM people_feng

UPDATE city_feng
SET City = 'Madison'
WHERE Id = 1

CREATE VIEW packer_feng AS
SELECT p.Name
FROM city_feng c JOIN people_feng p on c.Id = p.City
WHERE c.City = 'Green Bay'

DROP TABLE city_feng
DROP TABLE people_feng
DROP VIEW packer_feng

-- ?
--5.       Create a stored procedure ¡°sp_birthday_employees_[you_last_name]¡± that creates a new table ¡°birthday_employees_your_last_name¡± and fill it with all employees that have a birthday on Feb. (Make a screen shot) drop the table. Employee table should not be affected.
--CREATE PROC sp_birthday_employees_feng AS
--BEGIN
--CREATE TABLE birthday_employees_feng AS
--SELECT *
--FROM Employees
--WHERE MONTH(BirthDate) = 2
--END



DROP TABLE birthday_employees_feng

DROP PROCEDURE sp_birthday_employees_feng
CREATE PROCEDURE sp_birthday_employees_feng
        @tableName        nvarchar(30)
        AS
        BEGIN        
DECLARE @SQLString NVARCHAR(MAX)
    Set @SQLString = 'CREATE TABLE ' +@tableName+
    'AS
SELECT *
FROM Employees
WHERE MONTH(BirthDate) = 2'
EXEC (@SQLString)
END

EXEC sp_birthday_employees_feng @tableName = birthday_employees_feng

DROP birthday_employees_feng
--6.      How do you make sure two tables have the same data?
-- use relational operator
--SELECT * FROM TableA
--UNION 
--SELECT * FROM TableB
--EXCEPT 
--SELECT * FROM TableA
--INTERSECT
--SELECT * FROM TableB;

