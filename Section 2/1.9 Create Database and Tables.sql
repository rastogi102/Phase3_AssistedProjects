CREATE DATABASE School;
USE School;

CREATE TABLE Student (
    StudentID INT PRIMARY KEY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Birthdate DATE
)

INSERT INTO Student (StudentID, FirstName, LastName, Birthdate)
VALUES
    (1, 'John', 'Doe', '2000-01-15'),
    (2, 'Jane', 'Smith', '2001-03-20'),
    (3, 'Michael', 'Johnson', '1999-09-10'),
    (4, 'Emily', 'Williams', '2002-05-05'),
    (5, 'David', 'Brown', '2003-11-30')

	

CREATE TABLE Class (
    ClassID INT PRIMARY KEY,
    ClassName NVARCHAR(50),
    TeacherID INT,
    FOREIGN KEY (TeacherID) REFERENCES Teacher(TeacherID)
)
INSERT INTO Class (ClassID, ClassName, TeacherID)
VALUES
    (1, 'Mathematics', 101),
    (2, 'History', 102),
    (3, 'Science', 103),
    (4, 'English', 104),
    (5, 'Computer Science', 105)


CREATE TABLE Subjects (
    SubjectID INT PRIMARY KEY,
    SubjectName NVARCHAR(50),
    Description NVARCHAR(255)
)
INSERT INTO Subjects (SubjectID, SubjectName, Description)
VALUES
    (1, 'Math', 'Basic arithmetic and algebra'),
    (2, 'History', 'World history from ancient times to present'),
    (3, 'Physics', 'Study of matter, energy, and the fundamental forces of nature'),
    (4, 'English Literature', 'Study of literature written in the English language'),
    (5, 'Programming', 'Introduction to programming concepts and languages');




	CREATE TABLE Teacher (
    TeacherID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50)
)
INSERT INTO Teacher (TeacherID, FirstName, LastName)
VALUES
    (101, 'John', 'Smith'),
    (102, 'Emily', 'Johnson'),
    (103, 'Michael', 'Brown'),
    (104, 'Sarah', 'Davis'),
    (105, 'David', 'Williams');

	SELECT * FROM Teacher
	SELECT * FROM Subjects
	SELECT * FROM Student
	SELECT * FROM Class