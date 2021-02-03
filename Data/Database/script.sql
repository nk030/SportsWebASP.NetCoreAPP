
SET IDENTITY_INSERT [dbo].[Player] ON
INSERT INTO [dbo].[Player] ([PlayerId], [Name], [Postition], [TeamId], [DivisionId], [SportId]) VALUES (4, N'Bikiram', N'9', 10, 1, 1)
INSERT INTO [dbo].[Player] ([PlayerId], [Name], [Postition], [TeamId], [DivisionId], [SportId]) VALUES (5, N'Mohit', N'3', 12, 2, 2)
INSERT INTO [dbo].[Player] ([PlayerId], [Name], [Postition], [TeamId], [DivisionId], [SportId]) VALUES (6, N'Jashan', N'7', 12, 3, 3)
SET IDENTITY_INSERT [dbo].[Player] OFF

 SET IDENTITY_INSERT [dbo].[Division] ON
INSERT INTO [dbo].[Division] ([DivisionId], [Name]) VALUES (1, N'Division1')
INSERT INTO [dbo].[Division] ([DivisionId], [Name]) VALUES (2, N'Division2')
INSERT INTO [dbo].[Division] ([DivisionId], [Name]) VALUES (3, N'Division3')
SET IDENTITY_INSERT [dbo].[Division] OFF

  
  SET IDENTITY_INSERT [dbo].[Sport] ON
INSERT INTO [dbo].[Sport] ([SportId], [Name], [Description]) VALUES (1, N'Volleyball', N'an international game')
INSERT INTO [dbo].[Sport] ([SportId], [Name], [Description]) VALUES (2, N'Cricket', N'an international game')
INSERT INTO [dbo].[Sport] ([SportId], [Name], [Description]) VALUES (3, N'Football', N'an international game')
SET IDENTITY_INSERT [dbo].[Sport] OFF

SET IDENTITY_INSERT [dbo].[Team] ON
INSERT INTO [dbo].[Team] ([TeamId], [Name], [Year]) VALUES (10, N'Blue', N'2005-06-11 00:00:00')
INSERT INTO [dbo].[Team] ([TeamId], [Name], [Year]) VALUES (11, N'Red', N'2004-08-05 00:00:00')
INSERT INTO [dbo].[Team] ([TeamId], [Name], [Year]) VALUES (12, N'Green', N'2010-11-18 00:00:00')
SET IDENTITY_INSERT [dbo].[Team] OFF
