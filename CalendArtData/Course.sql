CREATE TABLE [dbo].[Course]
(
	[CourseId] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Code] VARCHAR(50) NOT NULL, 
    [Title] NVARCHAR(100) NOT NULL, 
    [OwnerId] INT NULL
)
