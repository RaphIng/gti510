CREATE TABLE [dbo].[Task]
(
	[TaskId] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Title] NVARCHAR(100) NULL, 
    [Description] NVARCHAR(250) NULL, 
    [StartDateTime] DATETIME2 NOT NULL, 
    [EndDateTime] DATETIME2 NOT NULL, 
    [OwnerId] INT NULL, 
    [CourseId] INT NULL, 
    [TaskTypeId] INT NULL
)
