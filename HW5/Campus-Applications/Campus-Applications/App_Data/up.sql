CREATE TABLE dbo.Requests (
    [ID]            INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]		NVARCHAR (MAX) NOT NULL,
    [LastName]		NVARCHAR (MAX) NOT NULL,
	[PhoneNumber]	NVARCHAR (MAX) NOT NULL,
    [ApartmentName]	NVARCHAR (MAX) NOT NULL,
    [Explanation]	NVARCHAR (MAX) NOT NULL,
    [UnitNumber]    INT            NOT NULL,
    [SignedDate]    DATETIME       NULL,

    CONSTRAINT [PK_dbo.Request] PRIMARY KEY CLUSTERED (SignedDate ASC)
	
);

INSERT INTO dbo.Requests(FirstName, LastName, PhoneNumber, ApartmentName, Explanation, UnitNumber, SignedDate) VALUES
    ('Shion', 'Wakita', '961-982-9087', 'Catron Houses', 'Leaking water pipe', 408, '2018-10-20 10:23:00'),
    ('Mashu', 'Wakita', '232-656-6593', 'Monmouth Townhouse', 'Heater not working', 374, '2018-11-20 12:25:30'),
    ('John', 'Stephens', '408-345-1324', 'University Houses', 'Crack in the Wall', 342, '2018-09-24 14:23:10'),
    ('Noah', 'Mendoza', '504-312-3453', 'Catron Houses', 'Broken refrigerator', 121, '2018-07-13 10:24:00'),
    ('Mark', 'Stemple', '208-894-0928', 'Independence Housing', 'Black widow breakout', 225, '2018-05-20 08:23:22')