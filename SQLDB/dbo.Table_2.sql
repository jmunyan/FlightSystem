CREATE TABLE [dbo].[sensor_values]
(
	[type] NVARCHAR(20) NOT NULL PRIMARY KEY, 
    [value] FLOAT NOT NULL, 
    [time_of_measurement] TIMESTAMP NOT NULL
)
