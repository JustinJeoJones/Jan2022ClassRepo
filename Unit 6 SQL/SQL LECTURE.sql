--CREATE TABLE Books(
--	Id INT NOT NULL IDENTITY(1,1),
--	Title NVARCHAR(255) NOT NULL,
--	Author NVARCHAR(255) NOT NULL,
--	ReleaseDate DATE,
--	PRIMARY KEY (Id)
--);

--INSERT INTO Books (Title, Author, ReleaseDate)
--VALUES ('Harry Potter', 'JK Rowling', '1997-06-26')

--INSERT INTO Books (Title, Author, ReleaseDate)
--VALUES ('The Da Vinci Code', 'Dan Brown', '2003-03-18'),
--('Twilight', 'Stephenie Meyer','2005-10-05');

--SELECT Title FROM Books;

--SELECT Title, Author FROM Books;

--SELECT * FROM Books;

--SELECT * FROM Books
--WHERE ReleaseDate > '2000-01-01';

--SELECT * FROM Books
--WHERE Author = 'JK Rowling';

--SELECT * FROM Books
--ORDER BY Author;

--BAD SET OF DATA
--INSERT INTO Books (Title, Author, ReleaseDate)
--VALUES ('Gorl with dragon tatto', 'Stieg Larsson', '2005-08-01');
--Fix

--UPDATE Books
--SET Title = 'Girl with the Dragon Tattoo'
--WHERE Id = 4;

--SELECT * FROM Books;

--DELETE FROM Books
--WHERE Id = 5;
--------------------------------------------------------
--Exercise
--CREATE TABLE Avengers(
--	ID INT NOT NULL IDENTITY(1,1),
--	Name NVARCHAR(255),
--	HeroName NVARCHAR(255),
--	Power NVARCHAR(255),
--	Popularity INT,

--	PRIMARY KEY(ID)
--);

--INSERT INTO Avengers(Name, HeroName, Power, Popularity)
--VALUES ('Thor', 'Thor', 'Lightning', 8),
--('Bruce Banner', 'Hulk', 'Strength', 9),
--('Tony Stark', 'Iron Man', 'Technology', 10),
--('Clint Barton', 'Hawkeye', 'Bow and Arrow',4),
--('Steve Rogers', 'Captian America', 'Empathy', 7);

--INSERT INTO Avengers(Name, HeroName, Power, Popularity)
--VALUES ('Peter Parker', 'Spider Man', 'Spider Reflexes', 10),
--('Peter Parker', 'Spider Man', 'Emo Dancing', 10),
--('Peter Parker', 'Spider man', 'Losing Mary Jane', 10);

--SELECT * FROM AVENGERS;

--SELECT * FROM Avengers
--Where HeroName = 'Spider Man';

--SELECT * FROM Avengers
--ORDER BY Popularity;

--DELETE FROM Avengers
--WHERE Power <> 'Spider Reflexes' AND HeroName = 'Spider Man';

--UPDATE Avengers
--SET Power = 'Depression'
--WHERE HeroName = 'Spider Man';

--SELECT * FROM Avengers

-----------------------------------------------------------
--LECTURE PART 2

--CREATE TABLE Tickets(
--	Id INT NOT NULL IDENTITY(1,1),
--	Seat NVARCHAR(50) NOT NULL,
--	Price FLOAT NOT NULL,
--	Num_Sold INT NOT NULL,

--	PRIMARY KEY(Id)
--)

--INSERT INTO Tickets(Seat, Price, Num_Sold)
--VALUES('Box Level', 105, 4),
--('Dress Circle', 75, 2),
--('Main Floor', 58, 10),
--('Mid Balcony', 38, 0),
--('Upper Balcony', 19, 3);

--SELECT COUNT(*) FROM Tickets;

--SELECT COUNT(*) FROM Tickets
--WHERE Num_Sold <> 0;

--SELECT SUM(Num_Sold) FROM Tickets;

--SELECT AVG(Price) FROM Tickets;

--SELECT MAX(Num_Sold) FROM Tickets;

--SELECT MIN(Price) FROM Tickets

--SELECT SUM(Num_Sold) AS 'Total Sold', SUM(Price * Num_Sold) AS 'Total Revenue'
--FROM Tickets

---------------------------------------------------------------
--TABLE RELATIONS
--CREATE TABLE Class (
--	ID INT NOT NULL IDENTITY(1,1),
--	Title NVARCHAR(255),

--	PRIMARY KEY(ID)
--);

--CREATE TABLE Student(
--	ID INT NOT NULL IDENTITY(1,1),
--	Name NVARCHAR(255),
--	ClassID INT,

--	PRIMARY KEY (ID),
--	FOREIGN KEY (ClassID) REFERENCES Class(ID)
--);

--INSERT INTO Class (Title)
--VALUES ('.NET'), ('Java'), ('Front-End');
--SELECT * FROM Class;

--INSERT INTO Student (Name, ClassID)
--VALUES ('G.Washington', 1),
--('M.Gandhi',1),
--('N.Mandela', NULL),
--('Q.Victoria',2);

--SELECT * FROM Student;

--SELECT * FROM Student
--JOIN Class ON Student.ClassID = Class.ID;

--SELECT * FROM Student
--INNER JOIN Class ON Student.ClassID = Class.ID;

--SELECT * FROM Student
--LEFT JOIN Class ON Student.ClassID = Class.ID;

--SELECT * FROM Student
--RIGHT JOIN Class ON Student.ClassID = Class.ID;

--SELECT * FROM Student
--FULL JOIN Class ON Student.ClassID = Class.ID;

--SELECT * FROM Student
--CROSS JOIN Class;

SELECT Student.ID, Student.Name FROM Student
JOIN Class ON Student.ClassID = Class.ID
WHERE Class.Title = '.NET' ORDER BY Student.Name;