CREATE TABLE dbo.Requests (
    [ID]            INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]		NVARCHAR (MAX) NOT NULL,
    [LastName]		NVARCHAR (MAX) NOT NULL,
    [ApartmentName]	NVARCHAR (MAX) NOT NULL,
    [Explanation]	NVARCHAR (MAX) NOT NULL,
    [UnitNumber]    INT            NOT NULL,
    [SignedDate]    DATETIME       NULL,

    CONSTRAINT [PK_dbo.Request] PRIMARY KEY CLUSTERED (ID ASC)
	
);

INSERT INTO dbo.Requests(FirstName, LastName, ApartmentName, Explanation, UnitNumber, SignedDate) VALUES
    ('Shion', 'Wakita', 'Catron Houses', 'Leaking water pipe', '408A', '2018-10-20 10:23:00'),
    ('Mashu', 'Wakita', 'Monmouth Townhouse', 'Heater not working', '374B', '2018-11-20 12:25:30'),
    ('John', 'Stephens', 'University Houses', 'Crack in the Wall', '342C', '2018-09-24 14:23:10'),
    ('Noah', 'Mendoza', 'Catron Houses', 'Broken refrigerator', '12D', '2018-07-13 10:24:00'),
    ('Mark', 'Stemple', 'Independence Housing', 'Black widow breakout', '225A', '2018-05-20 08:23:22');