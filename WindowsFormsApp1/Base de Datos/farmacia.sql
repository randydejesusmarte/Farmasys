USE [farmacia]
GO
/****** Object:  Table [dbo].[caja]    Script Date: 19/12/2020 12:31:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[caja](
	[id] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 19/12/2020 12:31:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Id] [int] NULL,
	[nom_cli] [varchar](50) NULL,
	[tel_cli] [varchar](50) NULL,
	[dir_cli] [varchar](50) NULL,
	[desc_cli] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 19/12/2020 12:31:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[idfactura] [int] NOT NULL,
	[Nombre_cliente] [varchar](50) NULL,
	[Nombre_producto] [varchar](max) NULL,
	[Precio] [smallmoney] NULL,
	[Cantidad] [int] NULL,
	[Monto] [smallmoney] NULL,
	[precio_total] [smallmoney] NULL,
	[Fecha_del_Registro] [varchar](50) NULL,
 CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED 
(
	[idfactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventario]    Script Date: 19/12/2020 12:31:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventario](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](50) NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](max) NULL,
	[Precio] [int] NULL,
	[Tipo_de_Empaque] [varchar](50) NULL,
	[Original_o_no] [varchar](8) NULL,
	[Cantidad] [int] NULL,
	[Ubicacion] [varchar](50) NULL,
	[FechaExp] [varchar](50) NULL,
	[Fecha_del_Registro] [varchar](50) NULL,
 CONSTRAINT [PK_Inventario] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pagServicios]    Script Date: 19/12/2020 12:31:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pagServicios](
	[id] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pedadom]    Script Date: 19/12/2020 12:31:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pedadom](
	[id] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 19/12/2020 12:31:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[idcliente] [int] IDENTITY(1,1) NOT NULL,
	[uname] [varchar](max) NULL,
	[pass] [varchar](50) NULL,
	[nombre] [varchar](max) NULL,
	[sexo] [varchar](50) NULL,
	[puesto] [varchar](30) NULL,
	[estado] [tinyint] NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[idcliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
