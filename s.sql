USE [MyYouGileDB]
GO
/****** Object:  Table [dbo].[Assignment]    Script Date: 14.03.2023 13:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Assignment](
	[AssignmentUser] [int] NOT NULL,
	[AssignmentProject] [int] NOT NULL,
	[AssignmentUserIsCommited] [bit] NULL,
 CONSTRAINT [PK_Assignment] PRIMARY KEY CLUSTERED 
(
	[AssignmentUser] ASC,
	[AssignmentProject] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 14.03.2023 13:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [int] NOT NULL,
	[CategoryName] [nvarchar](40) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perfomance]    Script Date: 14.03.2023 13:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perfomance](
	[StageID] [int] NOT NULL,
	[ProjectID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[PerfomanceStatus] [int] NOT NULL,
 CONSTRAINT [PK_Perfomance] PRIMARY KEY CLUSTERED 
(
	[StageID] ASC,
	[ProjectID] ASC,
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Project]    Script Date: 14.03.2023 13:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Project](
	[ProjectID] [int] NOT NULL,
	[ProjectName] [nvarchar](150) NOT NULL,
	[ProjectDescription] [nvarchar](500) NOT NULL,
	[ProjectPrice] [decimal](18, 0) NOT NULL,
	[ProjectImage] [image] NULL,
	[ProjectCategory] [int] NOT NULL,
 CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED 
(
	[ProjectID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 14.03.2023 13:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleID] [int] NOT NULL,
	[RoleName] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stage]    Script Date: 14.03.2023 13:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stage](
	[StageID] [int] NOT NULL,
	[StageName] [nvarchar](50) NOT NULL,
	[StageStart] [date] NOT NULL,
	[StageEnd] [date] NOT NULL,
	[StageStatus] [bit] NOT NULL,
 CONSTRAINT [PK_Stage] PRIMARY KEY CLUSTERED 
(
	[StageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 14.03.2023 13:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[StatusID] [int] NOT NULL,
	[StatusName] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[StatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 14.03.2023 13:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserID] [int] NOT NULL,
	[UserSurname] [nvarchar](50) NOT NULL,
	[UserFirstname] [nvarchar](50) NOT NULL,
	[UserPatronymic] [nvarchar](50) NOT NULL,
	[UserLogin] [nvarchar](60) NOT NULL,
	[UserPassword] [nvarchar](50) NOT NULL,
	[UserRole] [int] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Assignment] ([AssignmentUser], [AssignmentProject], [AssignmentUserIsCommited]) VALUES (1, 4, NULL)
INSERT [dbo].[Assignment] ([AssignmentUser], [AssignmentProject], [AssignmentUserIsCommited]) VALUES (2, 4, 1)
INSERT [dbo].[Assignment] ([AssignmentUser], [AssignmentProject], [AssignmentUserIsCommited]) VALUES (4, 1, NULL)
INSERT [dbo].[Assignment] ([AssignmentUser], [AssignmentProject], [AssignmentUserIsCommited]) VALUES (4, 4, NULL)
INSERT [dbo].[Assignment] ([AssignmentUser], [AssignmentProject], [AssignmentUserIsCommited]) VALUES (7, 5, NULL)
INSERT [dbo].[Assignment] ([AssignmentUser], [AssignmentProject], [AssignmentUserIsCommited]) VALUES (8, 2, NULL)
INSERT [dbo].[Assignment] ([AssignmentUser], [AssignmentProject], [AssignmentUserIsCommited]) VALUES (8, 6, NULL)
INSERT [dbo].[Assignment] ([AssignmentUser], [AssignmentProject], [AssignmentUserIsCommited]) VALUES (9, 3, NULL)
GO
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (4, N'Desktop приложение
')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (3, N'Веб-сайт
')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (2, N'Мобильное приложение
')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (1, N'Плагин для веб-сервиса
')
GO
INSERT [dbo].[Perfomance] ([StageID], [ProjectID], [UserID], [PerfomanceStatus]) VALUES (1, 4, 2, 4)
GO
INSERT [dbo].[Project] ([ProjectID], [ProjectName], [ProjectDescription], [ProjectPrice], [ProjectImage], [ProjectCategory]) VALUES (1, N'Автоматизация модерации изображений
', N'Разрабатываемая система должна определять объекты на загружаемых изображений, и определять возрастные ограничения для их показа
', CAST(180000 AS Decimal(18, 0)), NULL, 1)
INSERT [dbo].[Project] ([ProjectID], [ProjectName], [ProjectDescription], [ProjectPrice], [ProjectImage], [ProjectCategory]) VALUES (2, N'Приложение для отслеживания посылок
', N'Пользователи приложения должны иметь доступ к интерактивной карте, на которой должен отрисовываться предстоящий путь до пункта назначения
', CAST(45000 AS Decimal(18, 0)), NULL, 2)
INSERT [dbo].[Project] ([ProjectID], [ProjectName], [ProjectDescription], [ProjectPrice], [ProjectImage], [ProjectCategory]) VALUES (3, N'Простой графический редактор
', N'"Функции:
- Обрезка изображения
- Удаление фона
- Создание коллажа"
', CAST(7000 AS Decimal(18, 0)), NULL, 2)
INSERT [dbo].[Project] ([ProjectID], [ProjectName], [ProjectDescription], [ProjectPrice], [ProjectImage], [ProjectCategory]) VALUES (4, N'Сервис для прохождения платных опросов
', N'Необходимо разработать сайт с функцией оповещения пользователей о появлении нового коммерческого опроса и вывода денежных средств
', CAST(70000 AS Decimal(18, 0)), 0x89504E470D0A1A0A0000000D49484452000000E1000000E10803000000096D2248000000017352474200AECE1CE90000000467414D410000B18F0BFC610500000090504C5445FFFFFF130B7A000076504C95716EA5000072F0EFF70E04799997C0201981110879B8B6D3E4E3F00300790C00786C69A58987B3332F85B0AFCEA5A3C719117E00006F5754988E8CB6F0F0F7E9E8F2D2D1E3F9F9FD45418E7370A9C7C6DCDDDCEA9F9DC33D398DA9A7C96562A25350978582B4BEBDD62E2886413D8FC6C5D97B79AB4B47935F5C9E65639D64619D272085799DA2A20000064E49444154785EED9D715FA24C1080656B4550B634099114CDB4B2AEFBFEDFEE9DA5B93B3BD77E5BC00CDE3BCF5FAC91F8B8CBEE80BB434F10044110043AFAF9ACFF8759DEC7D7FF0D66C3ABBB20890E4982BBABE10CFF7EF60C02AD4C188787C4A1513A18E01EE74DFEA8C3C04DA81F73DCEB8C29A70A5C62754C0CAFAB6989FB9D2DB347108C757299658343B2EC32D1E0A8C605EE79AE2C4030D4994BA3C86CF3D50B2C9E29650A82C9124B7FB34C40313DEF766AAB504DB070CCBD863F9F77252671609E70DBC593812AC6EDB3640E75A44F5761AF37B13BCCB1708E3C83C0A7E7993D4FF53316BA4B31DF0D56370EEEF7701AA623DCCD853554FB7BDCFF03AB6C37EFC648522E02A595766207FBF4B318BB0F86F0EF4EE05DE32BFE8EB6D8A6EA5450F64EFA597C5D199E2654E99EB91E677770A67D8A51B8AB1B6570BF53E827D6EBAC626CDBA1D1699A62D33A223E35DCBFB30C71BF23EC7B5A7DF5C8598B1B108CF57AD2CE15423E79AA42D7572C33B083261AAB1596DAE0C65E81E81D96E8B9B083C13D16DA61628793172C9053C217DC7A13821321D65C63C6CA865C6D1FBCB407E1BADB01118B69FD02B6581B887AB040CDAD0AD40FDC6E8F1F709407DCA6E60EBEDD4BDC6E8F4B68296BDCA6C6D6218921611DF6CBFC8007B23A7CC12356946D8571C570B38E92E90136A422310C623C624512AD37C3163AB8015CCCFC75E39ACE30C0235654B7CB55D303C8686D23C463A80C8F8068F8B32BEB2F53C6F630F6C63506FE1510F913191A3C62C5AFDBE57183C1463F049958E9CDEAF066C5BD1D8B697A9A311EB262B5DAC0D53F6887CDFD7665236CA3322CFD866FB428327BE5AC2EB0589B1DC4F7AE1BD77486C72AEFB7CB9BBAACAA2E921C6FC669587DED4D55E2C85E246DB07008AB617559A59AE94FED7DE9D4755F9AD7700E95F8E9FD747FB60A065C570CC16B5818685A5B2CD4030EE10EEE790D7BE3C606ABAE1A36371C9F3C04B32174F114866FF9A85DF2375E438804DA06467656C3206E1B1B64731942FBA1C17D5396C07079F2E7988671C79F0486BDD19006776C4661C88B18FA23865C88A13F62C88518FA23865C88A13F62C88518FA23865C88A13F62C88518FA23865C88A13F62C88518FA23865C88A13F62C88518FAF30D4392F5749C86D9CF07828C1E8C86DBD4688215127C86031D0426C2428BB019DEDB59FDFA1A4B2DC265B8AB042916B63219CE6D4616F542D199F2188E123B879E26AB0E8B611E81A0896856D07318CEECF27C9310ADDAA5302C378B0FD57567A7632AAA642C0486FD44A9C30A7B05C1581DCDB22B0657F5D8BB1B0581E1736ADBE4EF2ADBC3481FA4C7EB03AED22A79590D12E7894D6098DB8ED3285C2E745D093A9605562BCD6A913A736B509C874BBBBECAA8A1DD5E418506DAB5FEE1569B7A28E58CE3290C7BA5ADC5D8268E18A63694B9C2D73F305BBC5CD4E2C19D1E85C4B057467626747AB3B469788897CDD318C2185F75A0D58CFA31BE460491E17B62C4009AA81A13A723A532EC152F561162B546571E7B4066D82B5E619C881551ACF6073A43180F52E51EB25A85D2B077B360C80C486AC88218FA23865C88A13F62C88518FA23865C88A13F62C88518FA23865C88A13F62C88518FA23865C88A13F62C88518FA53DF1013937D97131390BA6338FF8979C9BECD516ED88AEE18460AF3927D97D09979B34386F617F07AA4CE274275C7F0A66ED2B3F4C939D7B1433DCD7C528F6ABECE311D326C0931F4470CB910437FC4900B31F4470CB910437FC4900B31F4470CB910437FC4900B31F4470CB910437FC4900B31F4470CB910437FC4900B31F4A7B6E1E4BA1E0377E2B0EE18EEEBE6C5D053E72AF1EE189E735E0C3F9E6AE7C5D0CE75E2DD31CC6FC7F558BBA72A74A8A7690931F4470CB910437FC4900B31F4470CB910437FC4900B31F4470CB910437FC4900B31F4470CB910437FFE1786668DDB5D626DFE75C37163865B15C409C9F31CBE4491C48172E50FFF3A431D04EE95B8ACCCD320D027165F7E9191FDB26EB1D01D6E6DD36A283BF383824A6CE6DB6A8E2154616329D297F066F1AF070474842534AC13BF9C7E07FBE08A506FBBD3DB14DBEA813DCD3D9168F69E5A5EBF65D9809F2CDB68FBCBB98A1A4C025F4EABD4F23873801F3B33404D1BCD919EAFB5A9260D7405A3D74D3FBC6E156965C238E4270E8DD2D10A3F578314BBC54B9444FC24D1C562D756AF37CB677D6EE033E0A71104411004C18F5EEF3F9EF19DF0F70F7CC10000000049454E44AE426082, 3)
INSERT [dbo].[Project] ([ProjectID], [ProjectName], [ProjectDescription], [ProjectPrice], [ProjectImage], [ProjectCategory]) VALUES (5, N'Помощь с лабораторной работой исследования алгоритмов сортировки
', N'Нужно, как минимум 10 алгоритмов сортировки массивов
', CAST(1000 AS Decimal(18, 0)), NULL, 4)
INSERT [dbo].[Project] ([ProjectID], [ProjectName], [ProjectDescription], [ProjectPrice], [ProjectImage], [ProjectCategory]) VALUES (6, N'Интеграция чат-бота в интернет магазин
', N'Бот должен отвечать на часто задаваемые вопросы
', CAST(30000 AS Decimal(18, 0)), NULL, 1)
GO
INSERT [dbo].[Role] ([RoleID], [RoleName]) VALUES (1, N'Разработчик')
INSERT [dbo].[Role] ([RoleID], [RoleName]) VALUES (2, N'Заказчик')
INSERT [dbo].[Role] ([RoleID], [RoleName]) VALUES (3, N'Менеджер')
GO
INSERT [dbo].[Stage] ([StageID], [StageName], [StageStart], [StageEnd], [StageStatus]) VALUES (1, N'Проектирование БД', CAST(N'2023-03-13' AS Date), CAST(N'2023-03-20' AS Date), 1)
INSERT [dbo].[Stage] ([StageID], [StageName], [StageStart], [StageEnd], [StageStatus]) VALUES (2, N'Поверю в Бога', CAST(N'2023-01-13' AS Date), CAST(N'2023-01-14' AS Date), 0)
INSERT [dbo].[Stage] ([StageID], [StageName], [StageStart], [StageEnd], [StageStatus]) VALUES (3, N'Жертвоприношение', CAST(N'2023-01-14' AS Date), CAST(N'2023-02-14' AS Date), 0)
GO
INSERT [dbo].[Status] ([StatusID], [StatusName]) VALUES (1, N'Новый')
INSERT [dbo].[Status] ([StatusID], [StatusName]) VALUES (2, N'На рассмотрении')
INSERT [dbo].[Status] ([StatusID], [StatusName]) VALUES (3, N'Отозван')
INSERT [dbo].[Status] ([StatusID], [StatusName]) VALUES (4, N'Не выполнен')
INSERT [dbo].[Status] ([StatusID], [StatusName]) VALUES (5, N'Текущий')
INSERT [dbo].[Status] ([StatusID], [StatusName]) VALUES (6, N'Выполнен')
GO
INSERT [dbo].[User] ([UserID], [UserSurname], [UserFirstname], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (1, N'Кропотов', N'Вадим', N'Михайлович', N'vadikRoPot336', N'YF2xSGKVia4F', 3)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserFirstname], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (2, N'Милованова', N'Маргарита', N'Валентиновна', N'mamilo321', N'a1dqRgwIT1d8', 1)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserFirstname], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (3, N'Лермонтов', N'Нифонт', N'Владимирович', N'lermNiFont456', N'SxVrNASkOlRP', 1)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserFirstname], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (4, N'Репин', N'Тимур', N'Закирович', N'timRepin511', N'lGwJ41yAwz6J', 2)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserFirstname], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (5, N'Вершинина', N'Элиза', N'Евгеньевна', N'eliZaVershinu106', N'riNwivinsL0B', 3)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserFirstname], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (6, N'Охотников', N'Гурий', N'Андреевич', N'guryOxota612', N'54UovbbufD7n', 1)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserFirstname], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (7, N'Обломов', N'Сергей', N'Артемович', N'oblomofSery833', N'Ig85x6Qp4Ebm', 2)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserFirstname], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (8, N'Соловьева', N'Амина', N'Ильинична', N'aminaSolovey646', N'Og5EMAmqnB0W', 2)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserFirstname], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (9, N'Поднебесная', N'Динара', N'Вячеславовна', N'dinaraPodnebo295', N'zRIjtmBqvwhw', 2)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserFirstname], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (10, N'Гусев', N'Георгий', N'Васильевич', N'ggusevOrg672', N'ba0kejKFGQHI', 3)
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Project]    Script Date: 14.03.2023 13:44:14 ******/
ALTER TABLE [dbo].[Project] ADD  CONSTRAINT [IX_Project] UNIQUE NONCLUSTERED 
(
	[ProjectName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Assignment]  WITH CHECK ADD  CONSTRAINT [FK_Assignment_Project1] FOREIGN KEY([AssignmentProject])
REFERENCES [dbo].[Project] ([ProjectID])
GO
ALTER TABLE [dbo].[Assignment] CHECK CONSTRAINT [FK_Assignment_Project1]
GO
ALTER TABLE [dbo].[Assignment]  WITH CHECK ADD  CONSTRAINT [FK_Assignment_User1] FOREIGN KEY([AssignmentUser])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[Assignment] CHECK CONSTRAINT [FK_Assignment_User1]
GO
ALTER TABLE [dbo].[Perfomance]  WITH CHECK ADD  CONSTRAINT [FK_Perfomance_Project] FOREIGN KEY([ProjectID])
REFERENCES [dbo].[Project] ([ProjectID])
GO
ALTER TABLE [dbo].[Perfomance] CHECK CONSTRAINT [FK_Perfomance_Project]
GO
ALTER TABLE [dbo].[Perfomance]  WITH CHECK ADD  CONSTRAINT [FK_Perfomance_Stage] FOREIGN KEY([StageID])
REFERENCES [dbo].[Stage] ([StageID])
GO
ALTER TABLE [dbo].[Perfomance] CHECK CONSTRAINT [FK_Perfomance_Stage]
GO
ALTER TABLE [dbo].[Perfomance]  WITH CHECK ADD  CONSTRAINT [FK_Perfomance_Status] FOREIGN KEY([PerfomanceStatus])
REFERENCES [dbo].[Status] ([StatusID])
GO
ALTER TABLE [dbo].[Perfomance] CHECK CONSTRAINT [FK_Perfomance_Status]
GO
ALTER TABLE [dbo].[Perfomance]  WITH CHECK ADD  CONSTRAINT [FK_Perfomance_Status1] FOREIGN KEY([PerfomanceStatus])
REFERENCES [dbo].[Status] ([StatusID])
GO
ALTER TABLE [dbo].[Perfomance] CHECK CONSTRAINT [FK_Perfomance_Status1]
GO
ALTER TABLE [dbo].[Perfomance]  WITH CHECK ADD  CONSTRAINT [FK_Perfomance_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[Perfomance] CHECK CONSTRAINT [FK_Perfomance_User]
GO
ALTER TABLE [dbo].[Project]  WITH CHECK ADD  CONSTRAINT [FK_Project_Category] FOREIGN KEY([ProjectCategory])
REFERENCES [dbo].[Category] ([CategoryID])
GO
ALTER TABLE [dbo].[Project] CHECK CONSTRAINT [FK_Project_Category]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role] FOREIGN KEY([UserRole])
REFERENCES [dbo].[Role] ([RoleID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Role]
GO
