USE [BDPROYECTOCAMPO]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 22/4/2024 14:23:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Usuario] [varchar](50) NOT NULL,
	[Contraseña] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[S_CrearUsuario]    Script Date: 22/4/2024 14:23:11 ******/
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
	insert into Usuarios(Usuario,Contraseña) values(@Usuario,@Contraseña)
END
GO
/****** Object:  StoredProcedure [dbo].[S_Eliminarusuario]    Script Date: 22/4/2024 14:23:11 ******/
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
END
GO
/****** Object:  StoredProcedure [dbo].[S_Eliminarusuarios]    Script Date: 22/4/2024 14:23:11 ******/
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
	delete from Usuarios where Usuario=@Usuario
END
GO
/****** Object:  StoredProcedure [dbo].[S_ListarUsuario]    Script Date: 22/4/2024 14:23:11 ******/
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
/****** Object:  StoredProcedure [dbo].[S_ListarUsuarios]    Script Date: 22/4/2024 14:23:11 ******/
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
/****** Object:  StoredProcedure [dbo].[S_Modificarusuarios]    Script Date: 22/4/2024 14:23:11 ******/
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
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update Usuarios set Contraseña=@Contraseña where Usuario=@Usuario
END
GO
/****** Object:  StoredProcedure [dbo].[S_VerificarUsu]    Script Date: 22/4/2024 14:23:11 ******/
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
	
	@Usuario nvarchar(50),
	@Contraseña nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @Disponible bit

    -- Insert statements for procedure here
	if Exists (Select Usuario,Contraseña from Usuarios where Usuario=@Usuario and Contraseña=@Contraseña)
	set @Disponible=1
	else 
	set @Disponible=0

	select @Disponible as Disponible;
END
GO
/****** Object:  StoredProcedure [dbo].[S_VerificarUsuarioRegistrado]    Script Date: 22/4/2024 14:23:11 ******/
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
