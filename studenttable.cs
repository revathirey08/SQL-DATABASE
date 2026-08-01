CREATE TABLE Student (
    StudentID INT PRIMARY KEY,
    Name VARCHAR(50),
    Age INT,
    Department VARCHAR(50),
    Phone VARCHAR(10)
);
select * from Student;

INSERT INTO Student (StudentID, Name, Age, Department, Phone)
VALUES (101, 'Revathi', 20, 'AI&DS', '9876543210');

INSERT INTO Student (StudentID, Name, Age, Department, Phone)
VALUES (102, 'Priya', 21, 'CSE', '9876543211');

INSERT INTO Student (StudentID, Name, Age, Department, Phone)
VALUES (103, 'Arun', 20, 'IT', '9876543212');

INSERT INTO Student (StudentID, Name, Age, Department, Phone)
VALUES (104, 'Kavin', 22, 'ECE', '9876543213');

INSERT INTO Student (StudentID, Name, Age, Department, Phone)
VALUES (105, 'Divya', 21, 'AI&DS', '9876543214');