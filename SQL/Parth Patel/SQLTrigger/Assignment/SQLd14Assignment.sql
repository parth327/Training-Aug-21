--SQL Day 14 Assignment


CREATE TABLE Student(StudentID INT NOT NULL PRIMARY KEY,StudentName VARCHAR(25),TotalFees INT,RemainingAmt INT);

INSERT INTO Student(StudentID,StudentName,TotalFees,RemainingAmt)
VALUES(101,'RAKESH',25000,5000),(102,'MUKESH',20000,9000),(103,'MAHESH',30000,10000),(104,'MANISH',38000,12000);

CREATE TABLE Course(CourseID INT NOT NULL PRIMARY KEY,CourseName VARCHAR(20),TotalFees INT);

INSERT INTO Course(CourseID,CourseName,TotalFees)
VALUES(11,'C',10000),(12,'C++',15000),(13,'C#',20000),(14,'NodeJs',18000);

CREATE TABLE CourseEnrolled(StudentID INT FOREIGN KEY REFERENCES Student(StudentID),
CourseID INT FOREIGN KEY REFERENCES Course(CourseID));

CREATE TABLE FeePayment(StudentID INT FOREIGN KEY REFERENCES Student(StudentID),AmountPaid INT,DateOfPayment DATE);






-- Create an insert trigger on CourseEnrolled Table, record should be updated in TotalFees Field 
--on the Student table for the respective student.

SELECT * FROM Student
SELECT * FROM Course


-----trigger ---------------------------------------

CREATE TRIGGER t_CourseEnr
ON CourseEnrolled
FOR INSERT AS
IF @@ROWCOUNT = 1
BEGIN
	UPDATE Student
	SET TotalFees = TotalFees + (SELECT TotalFees FROM Course WHERE Course.CourseID = CourseId),RemainingAmt = RemainingAmt + (SELECT TotalFees FROM Course 
	WHERE Course.CourseID = inserted.CourseId)
	FROM inserted WHERE Student.StudentID = inserted.StudentID
END
ELSE 
BEGIN
	UPDATE Student
	SET TotalFees = TotalFees + (SELECT SUM(c.TotalFees) FROM CourseEnrolled ce JOIN Course c ON c.CourseID = ce.CourseId
	GROUP BY ce.StudentID HAVING ce.StudentID = Student.StudentID), RemainingAmt = RemainingAmt + 
	(SELECT SUM(c.TotalFees) FROM CourseEnrolled ce JOIN Course c ON c.CourseID = ce.CourseId
	GROUP BY ce.StudentID HAVING ce.StudentID = Student.StudentID) WHERE Student.StudentID IN ( SELECT StudentID FROM CourseEnrolled )
END

--------Trigger created---------------------------


-------------inserting data-----------------------

INSERT INTO CourseEnrolled(StudentID,CourseID) 
VALUES(1,1),(2,1),(2,2),(5,2),(3,2),(2,3),(3,4),(4,4),(1,4),(2,4),(1,5),(5,5);

SELECT * FROM Student
SELECT * FROM CourseEnrolled



-- Create an insert trigger on FeePayment, record should be updated in RemainingAmt Field of the Student Table
--for the respective student.



CREATE TRIGGER t_insertFeePayment
ON FeePayment
AFTER INSERT AS
IF @@ROWCOUNT = 1
BEGIN
	UPDATE Student
	SET RemainingAmt = RemainingAmt - inserted.AmountPaid FROM inserted WHERE Student.StudentID = inserted.StudentID
END
ELSE
BEGIN
	UPDATE Student
	SET RemainingAmt = RemainingAmt - (SELECT AmountPaid FROM inserted WHERE Student.StudentID = inserted.StudentID )
	WHERE Student.StudentID IN (SELECT StudentID FROM inserted)
END


INSERT INTO FeePayment
VALUES(2,10000,GETDATE()),(4,5000,GETDATE()),(5,6000,GETDATE())

SELECT * FROM FeePayment
SELECT * FROM Student
