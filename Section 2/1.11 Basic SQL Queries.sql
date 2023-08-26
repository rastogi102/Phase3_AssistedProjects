USE School

-- Insert a new student
INSERT INTO Student (StudentID, FirstName, LastName, Birthdate)
VALUES (6, 'Sarah', 'Miller', '2004-08-10')
INSERT INTO Student (StudentID, FirstName, LastName, Birthdate)
VALUES (12, 'Aman', 'Gupta', '2008-10-12')

-- View all students
SELECT * FROM Student

-- View specific columns for students
SELECT StudentID, FirstName, LastName FROM Student

-- Update a student's last name
UPDATE Student
SET LastName = 'Johnson'
WHERE StudentID = 6

-- Delete a student
DELETE FROM Student
WHERE StudentID = 6

-- Display students born after 2000-01-01
SELECT * FROM Student
WHERE Birthdate > '2000-01-01'

-- Display students sorted by last name
SELECT * FROM Student
ORDER BY LastName

-- Declare and use a variable
DECLARE @ClassID INT = 1
SELECT * FROM Class
WHERE ClassID = @ClassID


