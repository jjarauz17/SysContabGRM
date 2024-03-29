/****** Object:  StoredProcedure [dbo].[sp_Kardex_Reporte]    Script Date: 03/30/2011 11:18:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROC [dbo].[sp_Kardex_Reporte]
@Fecha_Ini DATETIME, @Fecha_Fin DATETIME, @Producto NVARCHAR(100), @string VARCHAR(MAX)

AS
SET DATEFORMAT DMY 

DECLARE @Orden int

--SET @Fecha_Ini = '01/05/2010'
--SET @Fecha_Fin = '01/06/2010'

DECLARE @Fecha_Desde DATETIME 

SET @Fecha_Desde = @Fecha_Ini

SELECT @Orden = MAX(Orden) FROM inventario_cierres
WHERE  fecha_corte  < @Fecha_Ini

SELECT @Orden = ISNULL(MAX(Orden), 0) FROM inventario_cierres
WHERE  fecha_corte  < @Fecha_Ini

IF @Orden = 0
SELECT @Orden = MIN(Orden) from Inventario_Cierres

SELECT @Fecha_Ini = Fecha_Corte FROM Inventario_Cierres ic WHERE ic.Orden = @Orden  

SET @Fecha_Ini = @Fecha_Ini + 1

SET @Fecha_Fin = @Fecha_Fin + 1

DECLARE @Empresa VARCHAR(100)

SELECT @Empresa = e.NOMBRE FROM EMPRESAS e

  
--SELECT cantidad, Saldo, Fecha, codigo_articulo FROM dbo.vKardex(@Orden, @Fecha_Ini, @Fecha_Fin)

--SET @Producto = '''' + @Producto + ''''

--SET @Producto = REPLACE(@Producto, ' ', '')

--SET @Producto = REPLACE(@Producto, ',', ''', ''') 

DECLARE @aBuscar TABLE (Producto VARCHAR(MAX))


IF @string = ''
SET @string = @Producto





--declare @string varchar(500)
--set @string = @Producto

SET @string = REPLACE(@string, ' ', '')

declare @pos int
declare @piece varchar(500)

-- Need to tack a delimiter onto the end of the input string if one doesn't exist
if right(rtrim(@string),1) <> ','
 set @string = @string  + ','

set @pos =  patindex('%,%' , @string)
while @pos <> 0
begin
 set @piece = left(@string, @pos - 1)
 
 -- You have a piece of data, so insert it, print it, do whatever you want to with it.
 print cast(@piece as varchar(500))

 set @string = stuff(@string, 1, @pos, '')
 set @pos =  patindex('%,%' , @string)
 
 --SELECT cast(@piece as varchar(500))
 
 INSERT INTO @aBuscar VALUES (cast(@piece as varchar(500)))
END








SELECT @Empresa AS Empresa, @Fecha_Desde AS Fecha_Ini, @Fecha_Fin AS Fecha_Fin,
  ac.Articulo_ID, ac.Articulo_ID + ' - ' + ac.Articulo_Descripcion AS Articulo, Proveedor, Documento,
  
 CASE tm WHEN 'E' THEN 2 WHEN 'SI' THEN 1 WHEN 'S' THEN 3 END  AS Orden_tm,
  
CASE tm WHEN 'E' THEN 'Compra Material' WHEN 'SI' THEN 'Saldo Inicial' WHEN 'S' THEN 'Salida Material' END Tipo_Movimiento,
(CASE tm WHEN 'SI' THEN Cantidad ELSE 0.00 END) AS SI_Cantidad,  
(CASE tm WHEN 'SI' THEN Saldo ELSE 0.00 END) AS SI_Importe,

(CASE tm WHEN 'E' THEN Cantidad ELSE 0.00 END) AS E_Cantidad,  
(CASE tm WHEN 'E' THEN Saldo ELSE 0.00 END) AS E_Importe,

(CASE tm WHEN 'S' THEN ABS(Cantidad) ELSE 0.00 END) AS S_Cantidad,  
(CASE tm WHEN 'S' THEN ABS(Saldo) ELSE 0.00 END) AS S_Importe,
 
Fecha, tm, Cantidad, Saldo, costo,

(select SUM(cantidad) 
 FROM dbo.vKardex(@Orden, @Fecha_Ini,  @Fecha_Desde, @Fecha_Fin) S  
 WHERE s.codigo_articulo = t.codigo_articulo 
 --AND convert(datetime, s.Fecha) <= convert(datetime, t.Fecha)
 AND s.Orden_tm < = t.orden_tm 
--AND s.RowID <=  t.RowID 
) AS  SF_Cantidad, 

(select SUM(costo) FROM dbo.vKardex(@Orden, @Fecha_Ini, @Fecha_Desde, @Fecha_Fin) S  
 WHERE s.codigo_articulo = t.codigo_articulo 
 --AND s.Fecha <= t.Fecha 
  AND s.Orden_tm < = t.orden_tm
 --AND s.RowID < = t.RowID 
) AS  SF_Costo,

(select SUM(Saldo) FROM dbo.vKardex(@Orden, @Fecha_Ini, @Fecha_Desde, @Fecha_Fin) S  
 WHERE s.codigo_articulo = t.codigo_articulo 
 --AND s.Fecha <= t.Fecha 
--AND s.RowID < = t.RowID 
 AND s.Orden_tm < = t.orden_tm
) AS  SF_Saldo

 FROM ArticulosCC ac LEFT OUTER JOIN dbo.vKardex(@Orden, @Fecha_Ini,  @Fecha_Desde, @Fecha_Fin) T ON ac.Articulo_ID = t.codigo_articulo
WHERE NOT tm IS NULL
--AND ac.Articulo_ID LIKE @Producto
AND ac.Articulo_ID IN (SELECT producto FROM @aBuscar)


ORDER BY ac.Articulo_ID , 
CAST(CONVERT(VARCHAR,Fecha, 103) AS DateTime) ,  
tm
  

	



		


 




