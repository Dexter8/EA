USE [EA2015]
GO
/****** Object:  Table [dbo].[Card]    Script Date: 18.08.2017 15:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Card](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[folder_id] [int] NULL,
	[card_type_id] [int] NULL,
	[status_id] [int] NULL,
	[code] [nvarchar](100) NULL,
	[name] [nvarchar](300) NULL,
	[description] [nvarchar](max) NULL,
	[owner_login] [nvarchar](50) NULL,
	[creation_date] [datetime] NULL CONSTRAINT [DF_Card_creation_date]  DEFAULT (getdate()),
	[last_edit_date] [datetime] NULL,
	[start_develop_date] [datetime] NULL,
	[end_develop_date] [datetime] NULL,
	[dep_temp] [nvarchar](5) NULL,
	[create_user_id] [int] NULL,
	[create_date] [datetime] NULL CONSTRAINT [DF_Card_create_date]  DEFAULT (getdate()),
 CONSTRAINT [PK_Card] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CardObserved]    Script Date: 18.08.2017 15:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CardObserved](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NULL,
	[card_id] [int] NULL,
	[add_date] [datetime] NULL,
 CONSTRAINT [PK_CardObserved] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CardTypeList]    Script Date: 18.08.2017 15:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CardTypeList](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [PK_CardTypeList] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CCardType]    Script Date: 18.08.2017 15:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CCardType](
	[id] [int] NULL,
	[name] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CDraftType]    Script Date: 18.08.2017 15:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CDraftType](
	[id] [int] NULL,
	[name] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CFileType]    Script Date: 18.08.2017 15:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CFileType](
	[id] [int] NULL,
	[name] [nvarchar](50) NULL,
	[short_name] [nvarchar](10) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CFileViewType]    Script Date: 18.08.2017 15:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CFileViewType](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [PK_CFileViewType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CPaparKind]    Script Date: 18.08.2017 15:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CPaparKind](
	[id] [int] NULL,
	[name] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CStatus]    Script Date: 18.08.2017 15:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CStatus](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NULL,
	[short_name] [nvarchar](10) NULL,
 CONSTRAINT [PK_CStatus] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Department]    Script Date: 18.08.2017 15:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[id] [int] NOT NULL,
	[subdivision_id] [int] NULL,
	[name] [nvarchar](100) NULL,
	[code] [nvarchar](50) NULL,
	[deleted] [nchar](10) NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FileContent]    Script Date: 18.08.2017 15:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FileContent](
	[uid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [DF_FileContent_uid]  DEFAULT (newid()),
	[id] [int] IDENTITY(1,1) NOT NULL,
	[parent_id] [int] NULL,
	[card_id] [int] NULL,
	[folder_id] [int] NULL,
	[file_type_id] [int] NULL,
	[content] [varbinary](max) FILESTREAM  NULL,
	[name] [nvarchar](64) NULL,
	[description] [nvarchar](200) NULL,
	[extention] [nvarchar](10) NULL,
	[size] [nvarchar](10) NULL,
	[owner] [nvarchar](20) NULL,
	[version] [int] NULL,
	[last_edit_date] [datetime] NULL,
	[upload_date] [datetime] NULL CONSTRAINT [DF_FileContent_upload_date]  DEFAULT (getdate()),
	[upload_reason] [nvarchar](200) NULL,
	[temp_is_null_ext] [bit] NULL,
	[expire_date] [datetime] NULL,
	[document_type_id] [int] NULL,
	[draft_type_id] [int] NULL,
	[status_id] [int] NULL,
 CONSTRAINT [PK_FileContent] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] FILESTREAM_ON [FilestreamGroup],
 CONSTRAINT [UQ__FileCont__3213E83E15502E78] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__FileCont__DD701265182C9B23] UNIQUE NONCLUSTERED 
(
	[uid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] FILESTREAM_ON [FilestreamGroup]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FileTypeList]    Script Date: 18.08.2017 15:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FileTypeList](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NULL,
	[name_short] [nvarchar](10) NULL,
 CONSTRAINT [PK_FileTypeList] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Folder]    Script Date: 18.08.2017 15:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Folder](
	[id] [int] NOT NULL,
	[parent_id] [int] NULL,
	[folder_type_id] [int] NULL,
	[name] [nvarchar](128) NULL,
	[description] [nvarchar](max) NULL,
	[creation_date] [datetime] NULL,
	[last_edit_date] [datetime] NULL,
	[owner_login] [nvarchar](50) NULL,
	[dep_temp] [nvarchar](5) NULL,
 CONSTRAINT [PK_Folder] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[JFileView]    Script Date: 18.08.2017 15:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JFileView](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[card_id] [int] NULL,
	[file_id] [int] NULL,
	[user_login] [nvarchar](50) NULL,
	[machine_name] [nvarchar](50) NULL,
	[date] [datetime] NULL CONSTRAINT [DF_JFileView_date]  DEFAULT (getdate()),
	[file_view_type_id] [int] NULL,
 CONSTRAINT [PK_JFileView] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[JUserError]    Script Date: 18.08.2017 15:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JUserError](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[error_content] [nvarchar](max) NULL,
	[error_description] [nvarchar](max) NULL,
	[user_id] [int] NULL,
	[date] [datetime] NULL CONSTRAINT [DF_JUserError_date]  DEFAULT (getdate()),
	[version] [nvarchar](100) NULL,
	[user_login] [nvarchar](50) NULL,
 CONSTRAINT [PK_JUserError] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RCard_delete]    Script Date: 18.08.2017 15:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RCard_delete](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[folder_id] [int] NULL,
	[draft_type_id] [int] NULL,
	[status_id] [int] NULL,
	[code] [nvarchar](300) NULL,
	[name] [nvarchar](300) NULL,
	[description] [nvarchar](max) NULL,
	[create_login] [nvarchar](50) NULL,
	[create_date] [datetime] NULL,
	[last_edit_date] [datetime] NULL,
	[start_develop_date] [datetime] NULL,
	[end_develop_date] [datetime] NULL,
 CONSTRAINT [PK_RCard] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RCardLink]    Script Date: 18.08.2017 15:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RCardLink](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[card_id] [int] NULL,
	[parent_card_id] [int] NULL,
	[date] [datetime] NULL CONSTRAINT [DF_RCardLink_date]  DEFAULT (getdate()),
	[user_login] [nvarchar](50) NULL,
 CONSTRAINT [PK_RCardLink] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RFile]    Script Date: 18.08.2017 15:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RFile](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[parent_id] [int] NULL,
	[file_content_id] [int] NULL,
	[card_id] [int] NULL,
	[file_type_id] [int] NULL,
	[draft_type_id] [int] NULL,
	[status_id] [int] NULL,
	[name] [nvarchar](300) NULL,
	[description] [nvarchar](max) NULL,
	[extention] [nvarchar](10) NULL,
	[size] [nvarchar](10) NULL,
	[version] [int] NULL,
	[upload_reason] [nvarchar](200) NULL,
	[upload_login] [nvarchar](20) NULL,
	[upload_date] [datetime] NULL,
	[last_edit_date] [datetime] NULL,
	[expire_date] [datetime] NULL,
 CONSTRAINT [PK_RFile] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RFolder]    Script Date: 18.08.2017 15:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RFolder](
	[id] [int] NULL,
	[pid] [int] NULL,
	[app_id] [int] NULL,
	[name] [nvarchar](250) NULL,
	[description] [nvarchar](max) NULL,
	[create_date] [datetime] NULL,
	[create_user_login] [nvarchar](50) NULL,
	[last_edit_date] [datetime] NULL,
	[dep_temp] [nvarchar](10) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RUser]    Script Date: 18.08.2017 15:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RUser](
	[id] [int] NOT NULL,
	[login] [nvarchar](50) NULL,
	[registration_date] [datetime] NULL,
	[computer_name] [nvarchar](50) NULL,
 CONSTRAINT [PK_RUser] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Subdivision]    Script Date: 18.08.2017 15:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subdivision](
	[id] [int] NOT NULL,
	[name] [nvarchar](100) NULL,
	[deleted] [bit] NULL,
	[owner] [nvarchar](50) NULL,
 CONSTRAINT [PK_Subdivision] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 18.08.2017 15:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[login] [nvarchar](50) NULL,
	[name] [nvarchar](50) NULL,
	[access] [nvarchar](10) NULL,
	[creation_date] [datetime] NULL,
	[department_id] [int] NULL,
	[subdivision_id] [int] NULL,
	[access_list_id] [int] NULL,
	[computer_name] [nvarchar](50) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserAccessList]    Script Date: 18.08.2017 15:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserAccessList](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NULL,
	[description] [nvarchar](150) NULL,
 CONSTRAINT [PK_UserAccessList] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[card_view]    Script Date: 18.08.2017 15:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[card_view]
AS
SELECT        c.id, c.folder_id, c.card_type_id, c.code, c.name, c.description, c.owner_login, c.create_date, c.last_edit_date, c.start_develop_date, c.end_develop_date, 
                         c.creation_date, ctl.name AS card_type_name, CASE WHEN
                             (SELECT        TOP 1 fc.file_type_id
                               FROM            [FileContent] AS fc
                               WHERE        fc.file_type_id = 1 AND fc.card_id = c.id) = 1 THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END AS exist_scan, CASE WHEN
                             (SELECT        TOP 1 fc.file_type_id
                               FROM            [FileContent] AS fc
                               WHERE        fc.file_type_id = 5 AND fc.card_id = c.id) = 5 THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END AS exist_2d, CASE WHEN
                             (SELECT        TOP 1 fc.file_type_id
                               FROM            [FileContent] AS fc
                               WHERE        fc.file_type_id = 2 AND fc.card_id = c.id) = 2 THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END AS exist_3d
FROM            dbo.Card AS c LEFT OUTER JOIN
                         dbo.CardTypeList AS ctl ON ctl.id = c.card_type_id

GO
/****** Object:  View [dbo].[View_Cards]    Script Date: 18.08.2017 15:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Cards]
AS
SELECT        c.id, c.folder_id, c.card_type_id, c.code, c.name, c.description, c.owner_login, c.create_date, c.create_user_id, c.last_edit_date, c.start_develop_date, 
                         c.end_develop_date, s.name AS status_name, s.short_name AS status_short_name, ctl.name AS card_type_name, CASE WHEN
                             (SELECT        TOP 1 fc.file_type_id
                               FROM            [FileContent] AS fc
                               WHERE        fc.file_type_id = 1 AND fc.card_id = c.id) = 1 THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END AS exist_scan, CASE WHEN
                             (SELECT        TOP 1 fc.file_type_id
                               FROM            [FileContent] AS fc
                               WHERE        fc.file_type_id = 5 AND fc.card_id = c.id) = 5 THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END AS exist_2d, CASE WHEN
                             (SELECT        TOP 1 fc.file_type_id
                               FROM            [FileContent] AS fc
                               WHERE        fc.file_type_id = 2 AND fc.card_id = c.id) = 2 THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END AS exist_3d
FROM            dbo.Card AS c LEFT OUTER JOIN
                         dbo.CardTypeList AS ctl ON ctl.id = c.card_type_id LEFT OUTER JOIN
                         dbo.CStatus AS s ON s.id = c.status_id

GO
/****** Object:  StoredProcedure [dbo].[create_login]    Script Date: 18.08.2017 15:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[create_login] 
						@login NVARCHAR(50), 
						@domen NVARCHAR(50),
						@computer_name NVARCHAR(50) = null

AS

Declare @e nvarchar(100)
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    --Если пользователя не зарегистрирован в БАЗЕ ДАННЫХ
	if  (select  count(*) from sys.database_principals where name = @domen + '\' + @login) = 0
		BEGIN	
			SET @E = 'CREATE USER '  + '[' + @domen + '\' + @login + ']'
			EXEC (@E)
		END

	IF NOT EXISTS (SELECT [login] FROM [EA2015].[dbo].[User] WHERE [login] = @login)
		BEGIN
			INSERT INTO [EA2015].[dbo].[User] ([login], [access], [creation_date], [access_list_id], [computer_name]) 
			VALUES (@login, 'alluser' , GETDATE(), 5, @computer_name)
		END
		

END

GO
/****** Object:  StoredProcedure [dbo].[SP_CreateNewCard]    Script Date: 18.08.2017 15:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_CreateNewCard]
	@folder_id int,
	@card_type_id int,
	@code nvarchar(300),
	@name nvarchar(300),
	@description nvarchar(MAX),
	@owner_login nvarchar(50),
	@start_develop_date datetime,
	@end_develop_date datetime,
	@new_id int OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    INSERT INTO [EA2015].[dbo].[Card] (folder_id, card_type_id, code, name, [description], owner_login, creation_date, start_develop_date, end_develop_date)
	VALUES (@folder_id, @card_type_id, @code, @name, @description, @owner_login, GETDATE(), @start_develop_date, @end_develop_date)

	set @new_id = SCOPE_IDENTITY()

	SELECT @new_id
END

GO
/****** Object:  StoredProcedure [dbo].[SP_DrawingViewLog]    Script Date: 18.08.2017 15:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_DrawingViewLog]
	@user_login nvarchar(50),
	@file_id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    INSERT INTO [EA2015].[dbo].[JDrawingView] ([login], [date], [file_id]) VALUES (@user_login, GETDATE(), @file_id)
END

GO
/****** Object:  StoredProcedure [dbo].[SP_RegisterUser]    Script Date: 18.08.2017 15:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_RegisterUser]
	@login nvarchar(50),
	@domen nvarchar(50),
	@computer_name nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @user_login NVARCHAR(100);
	Declare @e nvarchar(100)
	SET @user_login = @domen + '\' + @login;

	--Если пользователя не зарегистрирован в БАЗЕ ДАННЫХ
	if  (select  count(*) from sys.database_principals where name = @user_login) = 0
		BEGIN	
			SET @e = 'CREATE USER '  + '[' + @user_login + ']'
			EXEC (@e)
		END

	IF NOT EXISTS (SELECT [login] FROM [EA2015].[dbo].[RUser] WHERE [login] = @login)
		BEGIN
			INSERT INTO [EA2015].[dbo].[RUser] ([login], [registration_date], [computer_name]) 
			VALUES (@login, GETDATE(), @computer_name)
		END

	SELECT SCOPE_IDENTITY();
END

GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateCard]    Script Date: 18.08.2017 15:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: 15.03.2017
-- Description:	Обновить данные карточки чертежа
-- =============================================
CREATE PROCEDURE [dbo].[SP_UpdateCard] 
	@folder_id int,
	@card_type_id int,
	@code nvarchar(300),
	@name nvarchar(300),
	@description nvarchar(MAX),
	--@owner_login nvarchar(50),
	@start_develop_date datetime,
	@end_develop_date datetime,
	@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	/*
	INSERT INTO [EA2015].[dbo].[Card] (folder_id, card_type_id, code, name, [description], owner_login, creation_date, start_develop_date, end_develop_date)
	VALUES (@folder_id, @card_type_id, @code, @name, @description, @owner_login, GETDATE(), @start_develop_date, @end_develop_date)
	*/




	UPDATE [EA2015].[dbo].[Card] SET folder_id = @folder_id, card_type_id = @card_type_id, code = @code, name = @name, 
									[description] = @description, start_develop_date = @start_develop_date, end_develop_date = @end_develop_date
	WHERE id = @id
END

GO
/****** Object:  StoredProcedure [dbo].[SP_UploadFile]    Script Date: 18.08.2017 15:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_UploadFile] 
	--@uid uniqueidentifier,
	@card_id int,
	@parent_id int,
	@content varbinary(MAX),
	@name nvarchar(64),
	@description nvarchar(200),
	@extention nvarchar(10),
	@size nvarchar(10),
	@owner nvarchar(20),
	@expire_date datetime,
	@version int,
	@file_type_id int,
	@draft_type_id int,
	@status_id int,
	@new_id int OUTPUT

AS
BEGIN
	SET NOCOUNT ON;

    INSERT INTO [EA2015].[dbo].[FileContent] ([card_id], [content], [name], [description], [extention], [size], [owner], [expire_date], [version], [parent_id], draft_type_id, status_id, file_type_id) 
           VALUES (@card_id, @content, @name, @description, @extention, @size, @owner, @expire_date, @version, @parent_id, @draft_type_id, @status_id, @file_type_id)

	set @new_id = SCOPE_IDENTITY()

	SELECT @new_id
END

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Владелец файла, кто загрузил файл' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FileContent', @level2type=N'COLUMN',@level2name=N'owner'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Номер версии файла' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FileContent', @level2type=N'COLUMN',@level2name=N'version'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Дата загрузки файла на сервер' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FileContent', @level2type=N'COLUMN',@level2name=N'upload_date'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Причина обновления файла' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FileContent', @level2type=N'COLUMN',@level2name=N'upload_reason'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1- ЭА, 2 - СТП' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Folder', @level2type=N'COLUMN',@level2name=N'folder_type_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[24] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "c"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 267
               Right = 225
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ctl"
            Begin Extent = 
               Top = 6
               Left = 1055
               Bottom = 101
               Right = 1229
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 12
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'card_view'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'card_view'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[29] 4[32] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "s"
            Begin Extent = 
               Top = 6
               Left = 263
               Bottom = 118
               Right = 437
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ctl"
            Begin Extent = 
               Top = 6
               Left = 475
               Bottom = 101
               Right = 649
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "c"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 225
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 18
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Cards'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Cards'
GO
