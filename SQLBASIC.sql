-- DDL (Database & Table Create)

CREATE DATABASE CollegeDB;

USE CollegeDB;

CREATE TABLE Users
(
    UserID INT,
    UserName VARCHAR(50),
    Email VARCHAR(100)
);

-- DML (Data Add)

INSERT INTO Users
VALUES
(1, 'Revathi', 'revathimuthu20024@gmail.com');

-- DML (Data View)

SELECT * FROM Users;

-- DML (Data Update)

UPDATE Users
SET Email = 'revathi08@gmail.com'
WHERE UserID = 1;

-- DML (Data Delete)

DELETE FROM Users
WHERE UserID = 1;

-- DCL (Permission Give)

CREATE LOGIN Student1
WITH PASSWORD = 'Student@123';

CREATE USER Student1
FOR LOGIN Student1;

GRANT SELECT
ON Users
TO Student1;

-- DCL (Permission Remove)

REVOKE SELECT
ON Users
FROM Student1;