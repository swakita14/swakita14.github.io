CREATE TABLE dbo.Request (
    [ID]            INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]		NVARCHAR (MAX) NOT NULL,
    [LastName]		NVARCHAR (MAX) NOT NULL,
    [ApartmentName]	NVARCHAR (MAX) NOT NULL,
    [Explanation]	NVARCHAR (MAX) NOT NULL,
    [UnitNumber]    INT            NOT NULL,
    [SignedDate]    DATETIME       NULL,

    CONSTRAINT [PK_dbo.Request] PRIMARY KEY CLUSTERED (ID ASC)
	
);

