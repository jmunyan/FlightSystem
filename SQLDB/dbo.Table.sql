CREATE TABLE [dbo].[Sensors]
(
	[Sensor_type] TEXT NOT NULL PRIMARY KEY, 
    [time_of_measurement] TIMESTAMP NULL, 
    [value] FLOAT NULL
)
