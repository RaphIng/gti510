CREATE TABLE [dbo].[Event]
(
	[EventId] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Title] NVARCHAR(100) NOT NULL, 
    [Description] NVARCHAR(250) NULL, 
    [StartDateTime] DATETIME2 NOT NULL, 
    [EndDateTime] DATETIME2 NOT NULL, 
    [OwnerId] NCHAR(10) NULL
)
