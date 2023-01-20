CREATE Database ZooManagement;

Use ZooManagement;

CREATE TABLE Species
(
Id INT IDENTITY(1,1) PRIMARY KEY,
Species VARCHAR(150),
SpeciesNumber INT,
AnimalsNumber INT,
);

CREATE TABLE Visitors
(
Id INT IDENTITY(1,1) PRIMARY KEY,
Day VARCHAR(150),
NumberOfVisitors INT,
);

CREATE TABLE Tickets
(
Id INT IDENTITY(1,1) PRIMARY KEY,
Price INT,
Validity VARCHAR(150),
);

CREATE TABLE Caretakers
(
Id INT IDENTITY(1,1) PRIMARY KEY,
Name VARCHAR(150),
);

CREATE TABLE ZooMentenance
(
Id INT IDENTITY(1,1) PRIMARY KEY,
AreaOfWork VARCHAR(150),
);

CREATE TABLE WorkDistribution
(
Id INT IDENTITY(1,1) PRIMARY KEY,
Caretaker INT REFERENCES Caretakers(Id),
AreaOfWork INT References ZooMentenance(Id) 
);

INSERT INTO Species
VALUES ('Tiger', 3, 8)
INSERT INTO Species
VALUES ('Elephant', 4, 11)
INSERT INTO Species
VALUES ('Lion', 1, 3)
INSERT INTO Species
VALUES ('Flamingo', 2, 21)
INSERT INTO Species
VALUES ('Monkey', 5, 18)
INSERT INTO Species
VALUES ('Fox', 2, 4)
INSERT INTO Species
VALUES ('Bear', 4, 15)
INSERT INTO Species
VALUES ('Eagle', 1, 1)
INSERT INTO Species
VALUES ('Ostrich', 2, 3)
INSERT INTO Species
VALUES ('Panther', 2, 2)

SELECT *
FROM Species;
SELECT SUM(AnimalsNumber) 
FROM Species;

INSERT INTO Visitors
VALUES ('Monday', 421)
INSERT INTO Visitors
VALUES ('Tuesday', 510)
INSERT INTO Visitors
VALUES ('Wednesday', 383)
INSERT INTO Visitors
VALUES ('Thursday', 311)
INSERT INTO Visitors
VALUES ('Friday', 401)
INSERT INTO Visitors
VALUES ('Saturday', 758)
INSERT INTO Visitors
VALUES ('Sunday', 1073)

SELECT *
FROM Visitors;

INSERT INTO Tickets
VALUES (12, 'One day')
INSERT INTO Tickets
VALUES (30, 'One week')
INSERT INTO Tickets
VALUES (50, 'One month')
INSERT INTO Tickets
VALUES (130, 'Whole year')

SELECT *
FROM Tickets;

INSERT INTO Caretakers
VALUES ('John')
INSERT INTO Caretakers
VALUES ('Ana')
INSERT INTO Caretakers
VALUES ('Gheorghe')
INSERT INTO Caretakers
VALUES ('Manuela')
INSERT INTO Caretakers
VALUES ('Cristi')
INSERT INTO Caretakers
VALUES ('Florinel')

SELECT *
FROM Caretakers;

INSERT INTO ZooMentenance
VALUES('Tiger cage')
INSERT INTO ZooMentenance
VALUES('Elephant area')
INSERT INTO ZooMentenance
VALUES('Lion cage')
INSERT INTO ZooMentenance
VALUES('Flamingo pound')
INSERT INTO ZooMentenance
VALUES('Monkey island')
INSERT INTO ZooMentenance
VALUES('Fox cage')
INSERT INTO ZooMentenance
VALUES('Bear cave')
INSERT INTO ZooMentenance
VALUES('Eagle cage')
INSERT INTO ZooMentenance
VALUES('Ostrich farm')
INSERT INTO ZooMentenance
VALUES('Panther zone')

SELECT *
FROM ZooMentenance;

INSERT INTO WorkDistribution
VALUES (1,1)
INSERT INTO WorkDistribution
VALUES (2,2)
INSERT INTO WorkDistribution
VALUES (3,3)
INSERT INTO WorkDistribution
VALUES (3,4)
INSERT INTO WorkDistribution
VALUES (4,5)
INSERT INTO WorkDistribution
VALUES (4,6)
INSERT INTO WorkDistribution
VALUES (5,7)
INSERT INTO WorkDistribution
VALUES (5,8)
INSERT INTO WorkDistribution
VALUES (6,9)
INSERT INTO WorkDistribution
VALUES (6,10)

SELECT *
FROM WorkDistribution;