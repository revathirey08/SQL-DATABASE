CREATE DATABASE Ammu;
USE Ammu;
CREATE TABLE Department
(
DepartmentID INT PRIMARY KEY,
DepartmentName VARCHAR(50) UNIQUE
);
CREATE TABLE Student
(
StudentID INT PRIMARY KEY,
StudentName VARCHAR(50) NOT NULL,
Age INT CHECK (Age>=18),
Department VARCHAR(50) DEFAULT 'AI',
Email VARCHAR(100) UNIQUE,
DepartmentID INT,
FOREIGN KEY (DepartmentID)
REFERENCES Department(DepartmentID)
);
INSERT INTO Department 
values
(1,'AI'),
(2,'CSE'),
(3,'EEE'),
(4,'ECE'),
(5,'IT');

INSERT INTO Student
(StudentID, StudentName , Age, Email, DepartmentID)
VALUES
(101, 'Revathi', 20,'revathimuthu2004@gmail.com',1),
(102, 'Praveen', 24,'praveen142@gmail.com',2),
(103, 'Aravind', 29,'aravind06@gmail.com',3),
(104, 'Renu', 22,'renu90@gmail.com',4),
(105, 'Sweety', 18,'sweety789@gamil.com',5);
SELECT * FROM Department;
SELECT * FROM Student;


