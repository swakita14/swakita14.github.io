CREATE TABLE [dbo].[Country]
(
	CountryID		INT IDENTITY (1,1) NOT NULL,
	CountryName		NVARCHAR(MAX) NOT NULL,
	CONSTRAINT [PK_dbo.Country] PRIMARY KEY CLUSTERED (CountryID ASC)
);

CREATE TABLE [dbo].[Mission]
(
	MissionID	INT IDENTITY (1,1) NOT NULL,
	Designation		NVARCHAR(MAX) NOT NULL,
	Description		NVARCHAR(MAX) NOT NULL,
	CONSTRAINT [PK_dbo.Mission] PRIMARY KEY CLUSTERED (MissionID ASC)
);

CREATE TABLE [dbo].[Astronaut]
(
	AstronautID	INT IDENTITY (1,1) NOT NULL,
	Name		NVARCHAR(MAX) NOT NULL,
	Birthday 	DATETIME NOT NULL,
	Nationality INT NOT NULL,
	CONSTRAINT [PK_dbo.Astronaut] PRIMARY KEY CLUSTERED (AstronautID ASC),
	CONSTRAINT [FK_dbo.Astronaut] FOREIGN KEY (Nationality) REFERENCES [dbo].[Country] (CountryID),
    
    
);

CREATE TABLE [dbo].[Crew]
(
	CrewID		INT IDENTITY (1,1) NOT NULL, 
	Astronaut 	INT NOT NULL,
	Mission		INT NOT NULL,
	Position	NVARCHAR(MAX) NOT NULL,
	CONSTRAINT [PK_dbo.Crew] PRIMARY KEY CLUSTERED (CrewID ASC),
	CONSTRAINT [FK_dbo.Crew] FOREIGN KEY (Astronaut) REFERENCES [dbo].[Astronaut] (AstronautID) 
		ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT [FK2_dbo.Crew] FOREIGN KEY (Mission) REFERENCES [dbo].[Mission] (MissionID) 
		ON DELETE CASCADE ON UPDATE CASCADE

);


INSERT INTO [dbo].[Country](CountryName) VALUES
    ('Russia'),
    ('Italy'),
    ('USA'),
    ('Japan');

INSERT INTO [dbo].[Mission](Designation, Description) VALUES
	('Expedition 53', 'Expedition 53 is the 53rd expedition to the International Space Station.'),
	('Expedition 52', 'Expedition 52 is the 52nd expedition to the International Space Station.'),
	('STS-112',       'STS-112 was an 11-day space shuttle mission to the International Space Station.');

INSERT INTO [dbo].[Astronaut](Name, Birthday, Nationality)VALUES
	('Randy Bresnik',    '1967-09-11', 3),
	('Sergey Ryazansky', '1974-11-13', 1),
	('Paolo Nespoli',    '1957-05-06', 2),
	('Fyodor Yurchikhin','1959-01-03', 1);

INSERT INTO [dbo].[Crew](Astronaut, Mission, Position) VALUES
	(4,3, 'Mission Specialist 4'),
	(1,1, 'Commander'),
	(2,1, 'Flight Engineer 1'),
	(3,2, 'Flight Engineer 5');