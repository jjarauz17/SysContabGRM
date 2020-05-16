/****** Object:  Table [dbo].[GruposBalRes]    Script Date: 08/02/2016 02:28:18 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[GruposBalRes](
	[IdGrupo] [int] IDENTITY(1,1) NOT NULL,
	[Empresa] [int] NULL,
	[Codigo] [nvarchar](20) NULL,
	[Nombre] [nvarchar](256) NULL,
	[Nivel] [int] NULL,
	[Tipo] [nvarchar](50) NULL,
	[Cuenta] [nvarchar](max) NOT NULL,
	[Color] [nvarchar](50) NOT NULL,
	[Operacion] [int] NOT NULL,
	[Formula] [nvarchar](max) NOT NULL,
	[Fuente] [nvarchar](50) NOT NULL,
	[Orden] [int] NULL,
	[Movimiento] [bit] NOT NULL,
	[Titulo] [bit] NOT NULL,
	[IdPadre] [int] NULL,
	[Usuario] [nvarchar](50) NULL,
	[Registro] [smalldatetime] NULL,
	[Tipo_Grupo] [nvarchar](5) NOT NULL,
	[SubTitulo] [bit] NOT NULL,
	[Factor] [numeric](18, 4) NOT NULL,
	[Utilidad] [bit] NOT NULL,
	[Utilidad_Mes] [bit] NOT NULL,
	[Utilidad_Acumulado] [bit] NOT NULL,
	[VentasTotales] [bit] NOT NULL,
	[Columna] [int] NOT NULL,
	[Negrita] [bit] NOT NULL,
	[Anexo] [bit] NOT NULL,
	[Signo] [bit] NOT NULL,
 CONSTRAINT [PK_GruposBalRes] PRIMARY KEY CLUSTERED 
(
	[IdGrupo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

ALTER TABLE [dbo].[GruposBalRes] ADD  CONSTRAINT [DF__GruposBal__Cuent__269AB60B]  DEFAULT ('') FOR [Cuenta]
GO

ALTER TABLE [dbo].[GruposBalRes] ADD  CONSTRAINT [DF__GruposBal__Color__278EDA44]  DEFAULT ('') FOR [Color]
GO

ALTER TABLE [dbo].[GruposBalRes] ADD  CONSTRAINT [DF__GruposBal__Opera__33F4B129]  DEFAULT ((0)) FOR [Operacion]
GO

ALTER TABLE [dbo].[GruposBalRes] ADD  CONSTRAINT [DF__GruposBal__Formu__297722B6]  DEFAULT ('') FOR [Formula]
GO

ALTER TABLE [dbo].[GruposBalRes] ADD  CONSTRAINT [DF__GruposBal__Fuent__2A6B46EF]  DEFAULT ('') FOR [Fuente]
GO

ALTER TABLE [dbo].[GruposBalRes] ADD  CONSTRAINT [DF__GruposBal__Movim__147C05D0]  DEFAULT ((0)) FOR [Movimiento]
GO

ALTER TABLE [dbo].[GruposBalRes] ADD  CONSTRAINT [DF__GruposBal__Titul__21D600EE]  DEFAULT ((0)) FOR [Titulo]
GO

ALTER TABLE [dbo].[GruposBalRes] ADD  CONSTRAINT [DF__GruposBal__Tipo___5090EFD7]  DEFAULT ('A') FOR [Tipo_Grupo]
GO

ALTER TABLE [dbo].[GruposBalRes] ADD  CONSTRAINT [DF__GruposBal__SubTi__51851410]  DEFAULT ((0)) FOR [SubTitulo]
GO

ALTER TABLE [dbo].[GruposBalRes] ADD  CONSTRAINT [DF__GruposBal__Facto__5B0E7E4A]  DEFAULT ((1)) FOR [Factor]
GO

ALTER TABLE [dbo].[GruposBalRes] ADD  CONSTRAINT [DF__GruposBal__Utili__6C07F8D5]  DEFAULT ((0)) FOR [Utilidad]
GO

ALTER TABLE [dbo].[GruposBalRes] ADD  CONSTRAINT [DF__GruposBal__Utili__6CFC1D0E]  DEFAULT ((0)) FOR [Utilidad_Mes]
GO

ALTER TABLE [dbo].[GruposBalRes] ADD  CONSTRAINT [DF__GruposBal__Utili__6DF04147]  DEFAULT ((0)) FOR [Utilidad_Acumulado]
GO

ALTER TABLE [dbo].[GruposBalRes] ADD  CONSTRAINT [DF__GruposBal__Venta__6EE46580]  DEFAULT ((0)) FOR [VentasTotales]
GO

ALTER TABLE [dbo].[GruposBalRes] ADD  DEFAULT ((1)) FOR [Columna]
GO

ALTER TABLE [dbo].[GruposBalRes] ADD  DEFAULT ((0)) FOR [Negrita]
GO

ALTER TABLE [dbo].[GruposBalRes] ADD  DEFAULT ((0)) FOR [Anexo]
GO

ALTER TABLE [dbo].[GruposBalRes] ADD  DEFAULT ((0)) FOR [Signo]
GO

