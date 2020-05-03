CREATE TABLE [dbo].[sensor_parameters]
(
	[type] NVARCHAR(20) NOT NULL PRIMARY KEY, 
	[parameter_high] FLOAT NOT NULL, 
	[parameter_low] FLOAT NOT NULL
)
