CREATE TABLE [dbo].[Location]
(
	[Latitude] BIGINT NOT NULL UNIQUE, 
    [Longitude] BIGINT NOT NULL UNIQUE, 
    [time_of_measurement] TIMESTAMP NOT NULL PRIMARY KEY
)
