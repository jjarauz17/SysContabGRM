/****** Object:  Table [dbo].[Inventario_Cierres]    Script Date: 03/30/2011 11:20:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Inventario_Cierres](
	[fecha] [datetime] NULL,
	[mes] [int] NOT NULL,
	[año] [int] NOT NULL,
	[empr_codigo] [int] NOT NULL,
	[codigo_bodega] [nvarchar](100) NOT NULL,
	[codigo_articulo] [nvarchar](100) NOT NULL,
	[articulo_tipo] [nvarchar](2) NOT NULL,
	[existencia] [numeric](18, 6) NULL,
	[costo] [numeric](18, 6) NULL,
	[Orden] [int] NULL,
	[Fecha_Corte] [datetime] NULL,
	[Total] [numeric](18, 6) NULL,
 CONSTRAINT [PK_Inventario_Cierres] PRIMARY KEY CLUSTERED 
(
	[mes] ASC,
	[año] ASC,
	[empr_codigo] ASC,
	[codigo_bodega] ASC,
	[codigo_articulo] ASC,
	[articulo_tipo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Inventario_Cierres] ADD  CONSTRAINT [DF_Inventario_Cierres_Fecha]  DEFAULT (getdate()) FOR [fecha]
GO

ALTER TABLE [dbo].[Inventario_Cierres] ADD  CONSTRAINT [DF_Inventario_Cierres_Orden]  DEFAULT ((0)) FOR [Orden]
GO


