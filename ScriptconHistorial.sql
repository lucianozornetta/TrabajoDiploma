USE [BDPROYECTOCAMPO]
GO
/****** Object:  Table [dbo].[Bitacoras]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bitacoras](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NOT NULL,
	[Tipo] [int] NOT NULL,
	[Usuario] [nvarchar](50) NOT NULL,
	[Mensaje] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Bitacoras] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cambios]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cambios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [nvarchar](50) NULL,
	[Contraseña] [varchar](50) NULL,
	[Eliminado] [bit] NULL,
 CONSTRAINT [PK_Cambios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContraseñaAnterior]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContraseñaAnterior](
	[Contraseña] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Idioma]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Idioma](
	[Id_Idioma] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Idioma] PRIMARY KEY CLUSTERED 
(
	[Id_Idioma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Palabra]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Palabra](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tag] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Palabra] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permiso]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permiso](
	[ID_Permiso] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[EsPadre] [int] NOT NULL,
 CONSTRAINT [PK_Permiso] PRIMARY KEY CLUSTERED 
(
	[ID_Permiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PermisoPadre_Hijo]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PermisoPadre_Hijo](
	[PermisoPadre] [int] NOT NULL,
	[PermisoHijo] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Traduccion]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Traduccion](
	[Id_Idioma] [int] NOT NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Id_Palabra] [int] NOT NULL,
	[Traduccion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Traduccion] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario_Permiso]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario_Permiso](
	[Usuario] [nvarchar](50) NOT NULL,
	[Id_Permiso] [int] NOT NULL,
 CONSTRAINT [PK_Usuario_Permiso] PRIMARY KEY CLUSTERED 
(
	[Usuario] ASC,
	[Id_Permiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Usuario] [nvarchar](50) NOT NULL,
	[Contraseña] [nvarchar](50) NOT NULL,
	[Eliminado] [bit] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Bitacoras]  WITH CHECK ADD  CONSTRAINT [FK_Bitacoras_Usuarios] FOREIGN KEY([Usuario])
REFERENCES [dbo].[Usuarios] ([Usuario])
GO
ALTER TABLE [dbo].[Bitacoras] CHECK CONSTRAINT [FK_Bitacoras_Usuarios]
GO
ALTER TABLE [dbo].[PermisoPadre_Hijo]  WITH CHECK ADD  CONSTRAINT [FK_PermisoPadre_Hijo_Permiso] FOREIGN KEY([PermisoHijo])
REFERENCES [dbo].[Permiso] ([ID_Permiso])
GO
ALTER TABLE [dbo].[PermisoPadre_Hijo] CHECK CONSTRAINT [FK_PermisoPadre_Hijo_Permiso]
GO
ALTER TABLE [dbo].[PermisoPadre_Hijo]  WITH CHECK ADD  CONSTRAINT [FK_PermisoPadre_Hijo_Permiso1] FOREIGN KEY([PermisoPadre])
REFERENCES [dbo].[Permiso] ([ID_Permiso])
GO
ALTER TABLE [dbo].[PermisoPadre_Hijo] CHECK CONSTRAINT [FK_PermisoPadre_Hijo_Permiso1]
GO
ALTER TABLE [dbo].[Traduccion]  WITH CHECK ADD  CONSTRAINT [FK_Traduccion_Idioma] FOREIGN KEY([Id_Idioma])
REFERENCES [dbo].[Idioma] ([Id_Idioma])
GO
ALTER TABLE [dbo].[Traduccion] CHECK CONSTRAINT [FK_Traduccion_Idioma]
GO
ALTER TABLE [dbo].[Traduccion]  WITH CHECK ADD  CONSTRAINT [FK_Traduccion_Palabra] FOREIGN KEY([Id_Palabra])
REFERENCES [dbo].[Palabra] ([Id])
GO
ALTER TABLE [dbo].[Traduccion] CHECK CONSTRAINT [FK_Traduccion_Palabra]
GO
ALTER TABLE [dbo].[Usuario_Permiso]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Permiso_Permiso] FOREIGN KEY([Id_Permiso])
REFERENCES [dbo].[Permiso] ([ID_Permiso])
GO
ALTER TABLE [dbo].[Usuario_Permiso] CHECK CONSTRAINT [FK_Usuario_Permiso_Permiso]
GO
ALTER TABLE [dbo].[Usuario_Permiso]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Permiso_Usuarios] FOREIGN KEY([Usuario])
REFERENCES [dbo].[Usuarios] ([Usuario])
GO
ALTER TABLE [dbo].[Usuario_Permiso] CHECK CONSTRAINT [FK_Usuario_Permiso_Usuarios]
GO
/****** Object:  StoredProcedure [dbo].[Actualizar_contraseña]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Actualizar_contraseña] 
	-- Add the parameters for the stored procedure here
	@UsuarioRestaurar NVARCHAR(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
--UPDATE Usuarios
--SET Contraseña = (SELECT Contraseña FROM Cambios WHERE Usuario = @UsuarioRestaurar)
--WHERE Usuario = @UsuarioRestaurar;

--SELECT Usuario, Contraseña
--FROM Cambios
--WHERE Id = (
--    SELECT MAX(Id)-1
--    FROM Cambios
--    WHERE Usuario = @UsuarioRestaurar
--);

UPDATE Usuarios
SET Contraseña = (SELECT Contraseña
FROM Cambios
WHERE Id = (
    SELECT MAX(Id)-1
    FROM Cambios
    WHERE Usuario = @UsuarioRestaurar))
WHERE Usuario = @UsuarioRestaurar;

DELETE FROM Cambios where Id=(SELECT Id
FROM Cambios
WHERE Id = (
    SELECT MAX(Id)
    FROM Cambios
    WHERE Usuario = @UsuarioRestaurar))

END
GO
/****** Object:  StoredProcedure [dbo].[GuardarOActualizarTraduccion]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GuardarOActualizarTraduccion]
    @IdPalabra INT,
    @IdIdioma INT,
    @Texto NVARCHAR(50)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Traduccion WHERE Id_Palabra = @IdPalabra AND Id_Idioma = @IdIdioma)
    BEGIN
        
        UPDATE Traduccion
        SET Traduccion = @Texto
        WHERE Id_Palabra = @IdPalabra AND Id_Idioma = @IdIdioma;
    END
    ELSE
    BEGIN

        INSERT INTO Traduccion (Id_Palabra, Id_Idioma, Traduccion.Traduccion)
        VALUES (@IdPalabra, @IdIdioma, @Texto);
    END
END
GO
/****** Object:  StoredProcedure [dbo].[Listar_cambios]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Listar_cambios]
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Cambios where Eliminado=0
END
GO
/****** Object:  StoredProcedure [dbo].[ListarBitacorasFiltro]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ListarBitacorasFiltro]
    @Desde DATE = NULL,
    @Hasta DATE = NULL,
    @Usuario VARCHAR(100) = '',
    @Tipo VARCHAR(100) = ''


AS
BEGIN
   SET NOCOUNT ON;

    SELECT *
    FROM Bitacoras
    where	(Bitacoras.Usuario = @Usuario or @Usuario = '')
		and convert(date,Bitacoras.Fecha) between convert(date,@Desde) and convert(date,@Hasta)
		and (Bitacoras.Tipo = @Tipo or @Tipo = 3 or @Tipo is null)
END
GO
/****** Object:  StoredProcedure [dbo].[S_AsignarPermiso]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_AsignarPermiso]
	-- Add the parameters for the stored procedure here
	@Usuario nvarchar(50),
	@Id_Permiso int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Usuario_Permiso (Usuario , Id_Permiso) VALUES (@Usuario , @Id_Permiso)
END
GO
/****** Object:  StoredProcedure [dbo].[S_CrearBitacora]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_CrearBitacora]
	@Tipo int,
	@Usuario nvarchar(50),
	@Mensaje nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert into Bitacoras (Fecha,Tipo,Usuario,Mensaje) VALUES (getdate(),@Tipo,@Usuario,@Mensaje)
END
GO
/****** Object:  StoredProcedure [dbo].[S_CrearIdioma]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_CrearIdioma]
	-- Add the parameters for the stored procedure here
	@Nombre nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Idioma(Nombre) VALUES (@Nombre)
END
GO
/****** Object:  StoredProcedure [dbo].[S_CrearUsuario]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_CrearUsuario]
	-- Add the parameters for the stored procedure here
	@Usuario nvarchar(50),
	@Contraseña nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Usuarios(Usuario,Contraseña,Eliminado) values(@Usuario,@Contraseña,0)
	insert into Cambios(Usuario,Contraseña,Eliminado) values(@Usuario,@Contraseña,0)
END
GO
/****** Object:  StoredProcedure [dbo].[S_EliminarPermiso]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_EliminarPermiso]
	-- Add the parameters for the stored procedure here
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM PermisoPadre_Hijo WHERE PermisoPadre_Hijo.PermisoPadre = @Id 
	DELETE FROM Permiso where Permiso.ID_Permiso = @Id 
END
GO
/****** Object:  StoredProcedure [dbo].[S_Eliminarusuario]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_Eliminarusuario]
	@Usuario varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete from Usuarios where Usuario=@Usuario
	delete from Cambios where Usuario=@Usuario
END
GO
/****** Object:  StoredProcedure [dbo].[S_Eliminarusuarios]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_Eliminarusuarios]
	@Usuario varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update Usuarios set Eliminado = 1 where Usuario=@Usuario
	update Cambios set Eliminado = 1 where Usuario=@Usuario
END
GO
/****** Object:  StoredProcedure [dbo].[S_GuardarPalabra]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_GuardarPalabra]
	-- Add the parameters for the stored procedure here
	@tag nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Palabra (Tag) values (@tag)
END
GO
/****** Object:  StoredProcedure [dbo].[S_GuardarPermiso]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_GuardarPermiso]
	-- Add the parameters for the stored procedure here
	 
	@Nombre nvarchar(50),
	@EsPadre int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert INTO Permiso(Nombre , EsPadre) Values (@Nombre , @EsPadre)
END
GO
/****** Object:  StoredProcedure [dbo].[S_GuardarPermisoRelacion]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_GuardarPermisoRelacion]
	-- Add the parameters for the stored procedure here
	 
	@PermisoPadre int,
	@PermisoHijo int

		
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO PermisoPadre_Hijo (PermisoPadre , PermisoHijo) VALUES (@PermisoPadre , @PermisoHijo)
END
GO
/****** Object:  StoredProcedure [dbo].[S_LeerUsuario_Permiso]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_LeerUsuario_Permiso]
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM Usuario_Permiso
END
GO
/****** Object:  StoredProcedure [dbo].[S_ListarBitacoras]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_ListarBitacoras]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Bitacoras
END
GO
/****** Object:  StoredProcedure [dbo].[S_ListarIdiomas]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_ListarIdiomas]
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Idioma
END
GO
/****** Object:  StoredProcedure [dbo].[S_ListarPalabras]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_ListarPalabras]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM Palabra
END
GO
/****** Object:  StoredProcedure [dbo].[S_ListarPermisos]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_ListarPermisos]
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM Permiso
END
GO
/****** Object:  StoredProcedure [dbo].[S_ListarPermisosPadre_Hijo]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_ListarPermisosPadre_Hijo]
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM PermisoPadre_Hijo
END
GO
/****** Object:  StoredProcedure [dbo].[S_ListarTraducciones]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_ListarTraducciones]
	-- Add the parameters for the stored procedure here
	@Idioma int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
    t.Id AS TraduccionId,
    p.Tag AS Palabra,
    t.Traduccion
FROM 
    Traduccion t
JOIN 
    Palabra p ON t.Id_Palabra = p.Id
JOIN 
    Idioma i ON t.Id_Idioma = i.Id_Idioma
WHERE 
    i.Id_Idioma = @Idioma;
END
GO
/****** Object:  StoredProcedure [dbo].[S_ListarUsuario]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_ListarUsuario]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *from Usuarios
END
GO
/****** Object:  StoredProcedure [dbo].[S_ListarUsuarios]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_ListarUsuarios]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *from Usuarios
END
GO
/****** Object:  StoredProcedure [dbo].[S_ModificarIdioma]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_ModificarIdioma]
	 @IdPalabra INT,
    @IdIdioma INT,
    @Texto NVARCHAR(255)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Traduccion WHERE Id_Palabra = @IdPalabra AND Id_Idioma = @IdIdioma)
    BEGIN
        -- Si existe, actualiza la traducción
        UPDATE Traduccion
        SET Traduccion.Traduccion = @Texto
        WHERE Id_Palabra = @IdPalabra AND Id_Idioma = @IdIdioma;
    END
    ELSE
    BEGIN
        -- Si no existe, inserta una nueva traducción
        INSERT INTO Traduccion (Id_Palabra, Id_Idioma, Traduccion.Traduccion)
        VALUES (@IdPalabra, @IdIdioma, @Texto);
    END
END
GO
/****** Object:  StoredProcedure [dbo].[S_Modificarusuarios]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_Modificarusuarios] 
	-- Add the parameters for the stored procedure here
	
	@Usuario varchar(50),
	@Contraseña varchar(50)
AS
BEGIN TRANSACTION;

UPDATE Usuarios 
SET Contraseña = @Contraseña 
OUTPUT INSERTED.Usuario, @Contraseña, 0 INTO Cambios(Usuario, Contraseña, Eliminado)
WHERE Usuario = @Usuario;

COMMIT TRANSACTION;
GO
/****** Object:  StoredProcedure [dbo].[S_ObtenerIDPalabraConTag]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_ObtenerIDPalabraConTag]
	-- Add the parameters for the stored procedure here
	@Tag nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ID FROM Palabra where Tag = @Tag
END
GO
/****** Object:  StoredProcedure [dbo].[S_QuitarPermisos]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_QuitarPermisos]
	-- Add the parameters for the stored procedure here
	@Usuario nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM Usuario_Permiso WHERE Usuario = @Usuario
END
GO
/****** Object:  StoredProcedure [dbo].[S_VerificarUsu]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_VerificarUsu]
	-- Add the parameters for the stored procedure here
	
	@Usuario varchar(50),
	@Contraseña varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @Disponible bit

    -- Insert statements for procedure here
	if Exists (Select Usuario,Contraseña from Usuarios where  Usuario=@Usuario and Contraseña=@Contraseña and Eliminado = 0)
	set @Disponible=1
	else 
	set @Disponible=0

	select @Disponible as Disponible;
END
GO
/****** Object:  StoredProcedure [dbo].[S_VerificarUsuarioRegistrado]    Script Date: 10/6/2024 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_VerificarUsuarioRegistrado]
	-- Add the parameters for the stored procedure here
	@Usuario varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @Disponible bit

    -- Insert statements for procedure here
	if Exists (Select Usuario from Usuarios where Usuario=@Usuario )
	set @Disponible=1
	else 
	set @Disponible=0

	select @Disponible as Disponible;
END
GO
