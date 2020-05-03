CREATE TABLE [dbo].[Location]
(
	[Longitude ] FLOAT NOT NULL , 
    [Latitude] FLOAT NOT NULL, 
    [time_of_] TIMESTAMP NOT NULL, 
    CONSTRAINT [PK_Location] PRIMARY KEY ([time_of_])
)
