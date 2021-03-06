USE [EvolentHealthContacts]
GO
/****** Object:  Table [dbo].[Contacts]    Script Date: 4/17/2017 10:30:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contacts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[PhoneNumber] [numeric](10, 0) NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Contacts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Contacts] ON 

GO
INSERT [dbo].[Contacts] ([Id], [FirstName], [LastName], [Email], [PhoneNumber], [Status]) VALUES (1, N'Kartheek', N'Thamma', N'kt@gmail.commmmmmmmm', CAST(123 AS Numeric(10, 0)), 1)
GO
INSERT [dbo].[Contacts] ([Id], [FirstName], [LastName], [Email], [PhoneNumber], [Status]) VALUES (2, N'Sid', N'Kam', N'sd@gmail.com', CAST(345 AS Numeric(10, 0)), 1)
GO
SET IDENTITY_INSERT [dbo].[Contacts] OFF
GO
