-- Create Database
CREATE DATABASE CompanyDB;

-- Use Database
USE CompanyDB;

-- Employee Table
CREATE TABLE Employee
(
    EmployeeID INT,
    EmployeeName VARCHAR(50),
    DepartmentID INT
);

-- Department Table
CREATE TABLE Department
(
    DepartmentID INT,
    DepartmentName VARCHAR(50)
);

-- Employee Data
INSERT INTO Employee
VALUES
(101,'Revathi',1),
(102,'Priya',2),
(103,'Arun',1),
(104,'Kaviya',3);

-- Department Data
INSERT INTO Department
VALUES
(1,'AI'),
(2,'HR'),
(3,'IT');

-- INNER JOIN
SELECT Employee.EmployeeName,
       Department.DepartmentName
FROM Employee
INNER JOIN Department
ON Employee.DepartmentID = Department.DepartmentID;

-- LEFT JOIN
SELECT Employee.EmployeeName,
       Department.DepartmentName
FROM Employee
LEFT JOIN Department
ON Employee.DepartmentID = Department.DepartmentID;

-- RIGHT JOIN
SELECT Employee.EmployeeName,
       Department.DepartmentName
FROM Employee
RIGHT JOIN Department
ON Employee.DepartmentID = Department.DepartmentID;

-- FULL OUTER JOIN
SELECT Employee.EmployeeName,
       Department.DepartmentName
FROM Employee
FULL OUTER JOIN Department
ON Employee.DepartmentID = Department.DepartmentID;