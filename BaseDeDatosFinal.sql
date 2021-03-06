USE [master]
GO
/****** Object:  Database [SellPoint3]    Script Date: 4/27/2022 9:24:37 PM ******/
CREATE DATABASE [SellPoint3]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SellPoint3', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SellPoint3.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SellPoint3_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SellPoint3_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SellPoint3] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SellPoint3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SellPoint3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SellPoint3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SellPoint3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SellPoint3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SellPoint3] SET ARITHABORT OFF 
GO
ALTER DATABASE [SellPoint3] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SellPoint3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SellPoint3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SellPoint3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SellPoint3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SellPoint3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SellPoint3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SellPoint3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SellPoint3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SellPoint3] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SellPoint3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SellPoint3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SellPoint3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SellPoint3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SellPoint3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SellPoint3] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SellPoint3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SellPoint3] SET RECOVERY FULL 
GO
ALTER DATABASE [SellPoint3] SET  MULTI_USER 
GO
ALTER DATABASE [SellPoint3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SellPoint3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SellPoint3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SellPoint3] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SellPoint3] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SellPoint3] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'SellPoint3', N'ON'
GO
ALTER DATABASE [SellPoint3] SET QUERY_STORE = OFF
GO
USE [SellPoint3]
GO
/****** Object:  Table [dbo].[Entidad]    Script Date: 4/27/2022 9:24:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entidad](
	[IdEntidad] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](120) NOT NULL,
	[Direccion] [ntext] NOT NULL,
	[Localidad] [varchar](40) NOT NULL,
	[TipoEntidad] [varchar](8) NOT NULL,
	[TipoDocumento] [varchar](9) NOT NULL,
	[NumeroDocumento] [numeric](15, 0) NOT NULL,
	[Teléfonos] [varchar](60) NOT NULL,
	[URLPaginaWeb] [varchar](120) NOT NULL,
	[URLFacebook] [varchar](120) NOT NULL,
	[URLInstagram] [varchar](120) NOT NULL,
	[URLTwitter] [varchar](120) NOT NULL,
	[URLTikTok] [varchar](120) NOT NULL,
	[IdGrupoEntidad] [numeric](10, 0) NOT NULL,
	[IdTipoEntidad] [numeric](10, 0) NOT NULL,
	[LimiteCredito] [int] NOT NULL,
	[UserNameEntidad] [varchar](60) NOT NULL,
	[PassworEntidad] [varchar](30) NOT NULL,
	[RolUserEntidad] [varchar](10) NOT NULL,
	[Comentario] [ntext] NOT NULL,
	[SStatus] [varchar](10) NOT NULL,
	[NoEliminable] [bit] NOT NULL,
	[FechaRegistro] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdEntidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GrupoEntidad]    Script Date: 4/27/2022 9:24:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GrupoEntidad](
	[IdGrupoEntidad] [numeric](10, 0) IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](120) NOT NULL,
	[Comentario] [ntext] NOT NULL,
	[SStatus] [varchar](10) NOT NULL,
	[NoEliminable] [bit] NOT NULL,
	[FechaRegistro] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdGrupoEntidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoEntidad]    Script Date: 4/27/2022 9:24:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoEntidad](
	[IdTipoEntidad] [numeric](10, 0) IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](120) NOT NULL,
	[IdGrupoEntidad] [numeric](10, 0) NOT NULL,
	[Comentario] [ntext] NOT NULL,
	[SStatus] [varchar](10) NOT NULL,
	[NoEliminable] [bit] NOT NULL,
	[FechaRegistro] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdTipoEntidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Entidad] ADD  DEFAULT ('Fisico') FOR [TipoEntidad]
GO
ALTER TABLE [dbo].[Entidad] ADD  DEFAULT ('RNC') FOR [TipoDocumento]
GO
ALTER TABLE [dbo].[Entidad] ADD  DEFAULT ((0)) FOR [LimiteCredito]
GO
ALTER TABLE [dbo].[Entidad] ADD  DEFAULT ('User') FOR [RolUserEntidad]
GO
ALTER TABLE [dbo].[Entidad] ADD  DEFAULT ('Activa') FOR [SStatus]
GO
ALTER TABLE [dbo].[Entidad] ADD  DEFAULT ((0)) FOR [NoEliminable]
GO
ALTER TABLE [dbo].[GrupoEntidad] ADD  DEFAULT ('Activa') FOR [SStatus]
GO
ALTER TABLE [dbo].[GrupoEntidad] ADD  DEFAULT ((0)) FOR [NoEliminable]
GO
ALTER TABLE [dbo].[TipoEntidad] ADD  DEFAULT ('Activa') FOR [SStatus]
GO
ALTER TABLE [dbo].[TipoEntidad] ADD  DEFAULT ((0)) FOR [NoEliminable]
GO
ALTER TABLE [dbo].[Entidad]  WITH CHECK ADD  CONSTRAINT [FK_TipoEntidad] FOREIGN KEY([IdTipoEntidad])
REFERENCES [dbo].[TipoEntidad] ([IdTipoEntidad])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Entidad] CHECK CONSTRAINT [FK_TipoEntidad]
GO
ALTER TABLE [dbo].[TipoEntidad]  WITH CHECK ADD  CONSTRAINT [FK_GrupoEntidadDeTipoEntidad] FOREIGN KEY([IdGrupoEntidad])
REFERENCES [dbo].[GrupoEntidad] ([IdGrupoEntidad])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TipoEntidad] CHECK CONSTRAINT [FK_GrupoEntidadDeTipoEntidad]
GO
ALTER TABLE [dbo].[Entidad]  WITH CHECK ADD CHECK  (([LimiteCredito]>(0)))
GO
ALTER TABLE [dbo].[Entidad]  WITH CHECK ADD CHECK  (([RolUserEntidad]='User' OR [RolUserEntidad]='Supervisor' OR [RolUserEntidad]='Admin'))
GO
ALTER TABLE [dbo].[Entidad]  WITH CHECK ADD CHECK  (([SStatus]='Inactiva' OR [SStatus]='Activa'))
GO
ALTER TABLE [dbo].[Entidad]  WITH CHECK ADD CHECK  (([TipoDocumento]='Pasaporte' OR [TipoDocumento]='Cédula' OR [TipoDocumento]='RNC'))
GO
ALTER TABLE [dbo].[Entidad]  WITH CHECK ADD CHECK  (([TipoEntidad]='Juridico' OR [TipoEntidad]='Fisico'))
GO
ALTER TABLE [dbo].[GrupoEntidad]  WITH CHECK ADD CHECK  (([SStatus]='Inactiva' OR [SStatus]='Activa'))
GO
ALTER TABLE [dbo].[TipoEntidad]  WITH CHECK ADD CHECK  (([SStatus]='Inactiva' OR [SStatus]='Activa'))
GO
/****** Object:  StoredProcedure [dbo].[edit]    Script Date: 4/27/2022 9:24:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[edit]
AS
SET IDENTITY_INSERT TipoEntidad ON;
GO
/****** Object:  StoredProcedure [dbo].[SpEntidadActualizar]    Script Date: 4/27/2022 9:24:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SpEntidadActualizar]
@IdEntidad AS INT,
@Descripcion AS VARCHAR(120),
@Direccion AS NTEXT,
@Localidad AS VARCHAR(40),
@TipoEntidad AS VARCHAR(8),
@TipoDocumento AS VARCHAR(9),
@NumeroDocumento AS NUMERIC(15,0),
@Teléfonos AS VARCHAR(60),
@URLPaginaWeb AS VARCHAR(120),
@URLFacebook AS VARCHAR(120),
@URLInstagram AS VARCHAR(120),
@URLTwitter AS VARCHAR(120),
@URLTikTok AS VARCHAR(120),
@IdGrupoEntidad AS NUMERIC(10,0),
@IdTipoEntidad AS NUMERIC(10,0),
@LimiteCredito AS INT,
@UserNameEntidad AS VARCHAR(60),
@PassworEntidad AS VARCHAR(30),
@RolUserEntidad AS VARCHAR(10),
@Comentario AS NTEXT,
@SStatus AS VARCHAR(10),
@NoEliminable AS BIT
AS
BEGIN
UPDATE Entidad
SET Descripcion = @Descripcion,
Direccion = @Direccion,
Localidad = @Localidad,
TipoEntidad = @TipoEntidad,
TipoDocumento = @TipoDocumento,
NumeroDocumento = @NumeroDocumento,
Teléfonos = @Teléfonos,
URLPaginaWeb = @URLPaginaWeb,
URLFacebook = @URLFacebook,
URLInstagram = @URLInstagram,
URLTwitter = @URLTwitter,
URLTikTok = @URLTikTok,
IdGrupoEntidad = @IdGrupoEntidad,
IdTipoEntidad = @IdTipoEntidad,
LimiteCredito = @LimiteCredito,
UserNameEntidad = @UserNameEntidad,
PassworEntidad = @PassworEntidad,
RolUserEntidad = @RolUserEntidad,
Comentario = @Comentario,
SStatus = @SStatus,
NoEliminable = @NoEliminable
WHERE IdEntidad = @IdEntidad
END
GO
/****** Object:  StoredProcedure [dbo].[SpEntidadEliminar]    Script Date: 4/27/2022 9:24:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SpEntidadEliminar]
@IdEntidad AS INT
AS
BEGIN
DELETE FROM Entidad
WHERE IdEntidad = @IdEntidad
END
GO
/****** Object:  StoredProcedure [dbo].[SpEntidadInsertar]    Script Date: 4/27/2022 9:24:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SpEntidadInsertar]
@IdEntidad AS INT,
@Descripcion AS VARCHAR(120),
@Direccion AS NTEXT,
@Localidad AS VARCHAR(40),
@TipoEntidad AS VARCHAR(8),
@TipoDocumento AS VARCHAR(9),
@NumeroDocumento AS NUMERIC(15,0),
@Teléfonos AS VARCHAR(60),
@URLPaginaWeb AS VARCHAR(120),
@URLFacebook AS VARCHAR(120),
@URLInstagram AS VARCHAR(120),
@URLTwitter AS VARCHAR(120),
@URLTikTok AS VARCHAR(120),
@IdGrupoEntidad AS NUMERIC(10,0),
@IdTipoEntidad AS NUMERIC(10,0),
@LimiteCredito AS INT,
@UserNameEntidad AS VARCHAR(60),
@PassworEntidad AS VARCHAR(30),
@RolUserEntidad AS VARCHAR(10),
@Comentario AS NTEXT,
@SStatus AS VARCHAR(10),
@NoEliminable AS BIT,
@FechaRegistro AS DATE
AS
BEGIN
SET @IdEntidad = (select count(IdEntidad)+1 from Entidad)
INSERT INTO Entidad (Descripcion,Direccion,Localidad,TipoEntidad,TipoDocumento,NumeroDocumento,Teléfonos,URLPaginaWeb,URLFacebook,URLInstagram,URLTwitter,URLTikTok,IdGrupoEntidad,IdTipoEntidad,LimiteCredito,UserNameEntidad,PassworEntidad,RolUserEntidad,Comentario,SStatus,NoEliminable,FechaRegistro)
VALUES (@Descripcion,@Direccion,@Localidad,@TipoEntidad,@TipoDocumento,@NumeroDocumento,@Teléfonos,@URLPaginaWeb,@URLFacebook,@URLInstagram,@URLTwitter,@URLTikTok,@IdGrupoEntidad,@IdTipoEntidad,@LimiteCredito,@UserNameEntidad,@PassworEntidad,@RolUserEntidad,@Comentario,@SStatus,@NoEliminable,@FechaRegistro)
END
GO
/****** Object:  StoredProcedure [dbo].[SpEntidadListar]    Script Date: 4/27/2022 9:24:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SpEntidadListar]
AS
BEGIN
SELECT IdEntidad,
Descripcion,
Direccion,
Localidad,
TipoEntidad,
TipoDocumento,
NumeroDocumento,
Teléfonos,
URLPaginaWeb,
URLFacebook,
URLInstagram,
URLTwitter,
URLTikTok,
IdGrupoEntidad,
IdTipoEntidad,
LimiteCredito,
UserNameEntidad,
PassworEntidad,
RolUserEntidad,
Comentario,
SStatus,
NoEliminable,
FechaRegistro
FROM Entidad
END
GO
/****** Object:  StoredProcedure [dbo].[SpEntidadLogins]    Script Date: 4/27/2022 9:24:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SpEntidadLogins]
@UserNameEntidad AS varchar(60),
@PassworEntidad AS varchar(30)
AS
BEGIN
SELECT UserNameEntidad,
PassworEntidad
FROM Entidad
WHERE UserNameEntidad = @UserNameEntidad AND PassworEntidad = @PassworEntidad
END
GO
/****** Object:  StoredProcedure [dbo].[SpGrupoEntidadActualizar]    Script Date: 4/27/2022 9:24:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SpGrupoEntidadActualizar]
@IdGrupoEntidad AS NUMERIC(10,0),
@Descripcion AS VARCHAR(120),
@Comentario AS TEXT,
@SStatus AS VARCHAR(10),
@NoEliminable AS BIT
AS
BEGIN
UPDATE GrupoEntidad
SET Descripcion = @Descripcion,
Comentario = @Comentario,
SStatus = @SStatus,
NoEliminable = @NoEliminable
WHERE IdGrupoEntidad = @IdGrupoEntidad
END
GO
/****** Object:  StoredProcedure [dbo].[SpGrupoEntidadEliminar]    Script Date: 4/27/2022 9:24:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SpGrupoEntidadEliminar]
@IdGrupoEntidad AS NUMERIC(10,0)
AS
BEGIN
DELETE FROM GrupoEntidad
WHERE IdGrupoEntidad = @IdGrupoEntidad
END
GO
/****** Object:  StoredProcedure [dbo].[SpGrupoEntidadInsertar]    Script Date: 4/27/2022 9:24:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SpGrupoEntidadInsertar]
@IdGrupoEntidad AS INT,
@Descripcion AS VARCHAR(120),
@Comentario AS TEXT,
@SStatus AS VARCHAR(10),
@NoEliminable AS BIT,
@FechaRegistro AS DATE
AS
BEGIN				--(select count(IdEntidad)+1 from Entidad)
SET @IdGrupoEntidad = (select count(IdGrupoEntidad)+1 from GrupoEntidad)
INSERT INTO GrupoEntidad (Descripcion,Comentario,SStatus,NoEliminable,FechaRegistro)
VALUES (@Descripcion,@Comentario,@SStatus,@NoEliminable,@FechaRegistro)
END
GO
/****** Object:  StoredProcedure [dbo].[SpGrupoEntidadListar]    Script Date: 4/27/2022 9:24:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SpGrupoEntidadListar]
AS
BEGIN
SELECT IdGrupoEntidad,
Descripcion,
Comentario,
SStatus,
NoEliminable,
FechaRegistro
FROM GrupoEntidad
END
GO
/****** Object:  StoredProcedure [dbo].[SpTipoEntidadActualizar]    Script Date: 4/27/2022 9:24:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SpTipoEntidadActualizar]
@IdTipoEntidad AS NUMERIC(10,0),
@Descripcion AS VARCHAR(120),
@IdGrupoEntidad AS NUMERIC(10,0),
@Comentario AS NTEXT,
@SStatus AS VARCHAR(10),
@NoEliminable AS BIT,
@FechaRegistro AS DATE
AS
BEGIN
UPDATE TipoEntidad
SET Descripcion = @Descripcion,
IdGrupoEntidad = @IdGrupoEntidad,
Comentario = @Comentario,
SStatus = @SStatus,
NoEliminable = @NoEliminable,
FechaRegistro = @FechaRegistro
WHERE IdTipoEntidad = @IdTipoEntidad
END
GO
/****** Object:  StoredProcedure [dbo].[SpTipoEntidadEliminar]    Script Date: 4/27/2022 9:24:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SpTipoEntidadEliminar]
@IdTipoEntidad AS NUMERIC(10,0)
AS
BEGIN
DELETE FROM TipoEntidad
WHERE IdTipoEntidad = @IdTipoEntidad
END
GO
/****** Object:  StoredProcedure [dbo].[SpTipoEntidadInsertar]    Script Date: 4/27/2022 9:24:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SpTipoEntidadInsertar]
@IdTipoEntidad AS NUMERIC(10,0),
@Descripcion AS VARCHAR(120),
@IdGrupoEntidad AS NUMERIC(10,0),
@Comentario AS TEXT,
@SStatus AS VARCHAR(10),
@NoEliminable AS BIT,
@FechaRegistro AS DATE
AS
BEGIN
SET @IdTipoEntidad = (select count(IdTipoEntidad)+1 from TipoEntidad)
SET IDENTITY_INSERT TipoEntidad ON;
INSERT INTO TipoEntidad (IdTipoEntidad, Descripcion,IdGrupoEntidad,Comentario,SStatus,NoEliminable,FechaRegistro)
VALUES (@IdTipoEntidad, @Descripcion,@IdGrupoEntidad,@Comentario,@SStatus,@NoEliminable,@FechaRegistro)
END
GO
/****** Object:  StoredProcedure [dbo].[SpTipoEntidadListar]    Script Date: 4/27/2022 9:24:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SpTipoEntidadListar]
AS
BEGIN
SELECT IdTipoEntidad,
Descripcion,
IdGrupoEntidad,
Comentario,
SStatus,
NoEliminable,
FechaRegistro
FROM TipoEntidad
END
GO
USE [master]
GO
ALTER DATABASE [SellPoint3] SET  READ_WRITE 
GO
