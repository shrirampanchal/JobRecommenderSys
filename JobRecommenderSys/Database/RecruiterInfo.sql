
CREATE TABLE [dbo].[RecruiterInfo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[password] [varchar](10) NULL,
	[city] [varchar](50) NULL,
	[contactno] [varchar](10) NULL
) ON [PRIMARY]