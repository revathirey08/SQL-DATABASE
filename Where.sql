CREATE DATABASE CompanyDB;
USE CompanyDB;
CREATE TABLE Employee(
EmployeeID INT,
Employeename Varchar(50),
Department Varchar(50),
Salary INT
);
INSERT INTO Employee
VALUES
(101,'Revathi', 'AI',50000),
(102, 'Praveen', 'CSE', 80000),
(103, 'Aravind', 'IT', 60000),
(104, 'Adithi', 'ECE', 90000),
(105, 'Muthu','MEC', 30000),
(106,'Vishnu', 'ECE',60000),
(107, 'Renu', 'CSE', 50000),
(108, 'Pooja', 'IT', 80000),
(109, 'Barath', 'ECE', 30000),
(1010, 'Sandy','AI', 90000);

SELECT * FROM Employee;

SELECT * FROM Empolyee
WHERE Department='AI';

SELECT* FROM Employee
ORDER BY Salary DESC;

SELECT * FROM Employee
ORDER BY Salary ASC;

SELECT DISTINCT Department
FROM Employee;

SELECT Department, COUNT(*) AS TotalEmployees
FROM Employee
GROUP BY Department;

SELECT COUNT(*) AS TotalEmployees
FROM Employee;


SELECT SUM(SALARY) AS TotalSalary
FROM Employee;

SELECT AVG(SALARY) AS AvergeSalary
FROM Employee;

SELECT MAX(SALARY) AS HighestSalary
FROM Employee;

SELECT MIN(SALARY) AS LowesttSalary
FROM Employee;




