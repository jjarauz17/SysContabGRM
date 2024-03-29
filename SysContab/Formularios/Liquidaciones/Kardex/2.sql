/****** Object:  UserDefinedFunction [dbo].[vKardex]    Script Date: 03/30/2011 11:19:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER FUNCTION [dbo].[vKardex](@Orden INT,
			 @Fecha_Desde DATETIME,  
			 @Fecha_Ini DATETIME, @Fecha_Fin DATETIME) RETURNS TABLE
		AS
RETURN(
	
	
	SELECT 
	RowID,Orden_tm,fecha, tm, codigo_bodega, codigo_articulo,
	articulo_tipo, Documento, cantidad, costo, 
	 Saldo, Proveedor, 	 Linea, Grupo,	 Linea_ID, Grupo_ID
	FROM
		(
			(SELECT 0 AS RowID,
					Fecha_Corte AS Orden_tm,
					ba.Fecha_Corte AS fecha, 'SI' AS tm, ba.codigo_bodega, ba.codigo_articulo,
					articulo_tipo, 
					'  -  ' AS Documento,
					ba.existencia AS cantidad, ba.costo, 
					Total
					 AS Saldo, 
					 'Saldo Inicial' AS Proveedor,
					 vl.Grupo_Nombre AS Linea, vg.Grupo_Nombre AS Grupo,
					 vg.Linea_ID AS Linea_ID, vg.Grupo_ID AS Grupo_ID
					FROM inventario_cierres ba
					INNER JOIN ArticulosCC ac ON ac.Articulo_ID = ba.codigo_articulo
					LEFT OUTER JOIN v_Lineas vl ON ac.Linea_ID = vl.Grupo_ID
					LEFT OUTER JOIN v_Grupos vg ON ac.Grupo_ID = vg.Grupo_ID
					AND ac.Linea_ID = vg.Linea_ID  
					WHERE Orden = @Orden )
	
		
				UNION ALL
				
					SELECT 
					0 AS RowID,
					--CASE tbd.tipo_movimiento WHEN 'E' THEN 2 WHEN 'S' THEN 3 END  AS Orden_tm,
					@Fecha_Desde AS Orden_Tm, 
					@Fecha_Desde fecha, tbd.tipo_movimiento AS tm, tb.codigo_bodega, tbd.codigo_articulo,
					articulo_tipo,
					'  -  ' AS Documento,  
					SUM(cantidad) AS cantidad,  
					SUM(Costo_Promedio) costo, 
					--CASE WHEN SUM(Costo) > 0 AND SUM(Cantidad) = 0 THEN SUM(Costo) ELSE  SUM(Cantidad * Costo) END AS Saldo,
					SUM(Cantidad * costo) AS Saldo, 
					'Saldo Inicial' AS Proveedor,
					vl.Grupo_Nombre AS Linea, vg.Grupo_Nombre AS Grupo,	
					vg.Linea_ID AS Linea_ID, vg.Grupo_ID AS Grupo_ID
					  FROM Transaccion_Bodega tb INNER JOIN Transaccion_Bodega_Detalle tbd
					ON tb.codigo_bodega = tbd.codigo_bodega AND tb.empresa = tbd.empresa
					AND tb.documento = tbd.documento AND tb.cod_proveedor = tbd.cod_proveedor
					LEFT OUTER JOIN PROVEEDORES p ON tb.cod_proveedor =  p.CODIGO 
					INNER JOIN ArticulosCC ac ON ac.Articulo_ID = tbd.codigo_articulo
					LEFT OUTER JOIN v_Lineas vl ON ac.Linea_ID = vl.Grupo_ID
					LEFT OUTER JOIN v_Grupos vg ON ac.Grupo_ID = vg.Grupo_ID
					AND ac.Linea_ID = vg.Linea_ID
					WHERE CAST(convert(varchar, tb.fecha, 103) AS SMALLDATETIME) >= @Fecha_Desde
					 AND CAST(convert(varchar, tb.fecha, 103) AS SMALLDATETIME) < @Fecha_Ini
		
					GROUP BY 	
				
 					tbd.tipo_movimiento , tb.codigo_bodega, tbd.codigo_articulo,
					articulo_tipo,
					vl.Grupo_Nombre , vg.Grupo_Nombre ,	
					vg.Linea_ID , vg.Grupo_ID 
					
					
		
		) A
	  
	
	
	UNION ALL
	
	--- MOVIMIENTOS DEL RANGO DE BUSQUEDA
	
SELECT 
tranID AS RowID,
--CASE tbd.tipo_movimiento WHEN 'E' THEN 2 WHEN 'S' THEN 3 END  AS Orden_tm,
fecharegistro AS Orden_Tm, 
tb.fecha, tbd.tipo_movimiento AS tm, tb.codigo_bodega, tbd.codigo_articulo,
articulo_tipo,
CASE tbd.tipo_movimiento WHEN 'S' THEN tb.documento ELSE 
CONVERT(VARCHAR(100),(SELECT TOP 1 tranID FROM Facturas_Compras fc WHERE fc.Factura_ID = tb.documento AND fc.Proveedor_ID = tb.cod_proveedor )) END AS Documento,  
  
cantidad,  Costo_Promedio costo, Cantidad * costo AS Saldo, 
CASE  WHEN p.NOMBRE  IS NULL THEN ( SELECT TOP 1 a.are_descripcion FROM Requisas r INNER JOIN areas a ON r.CentroCosto = a.are_codigo WHERE r.req_codigo = tb.documento )   ELSE p.NOMBRE END AS Proveedor,
vl.Grupo_Nombre AS Linea, vg.Grupo_Nombre AS Grupo,	
vg.Linea_ID AS Linea_ID, vg.Grupo_ID AS Grupo_ID
  FROM Transaccion_Bodega tb INNER JOIN Transaccion_Bodega_Detalle tbd
ON tb.codigo_bodega = tbd.codigo_bodega AND tb.empresa = tbd.empresa
AND tb.documento = tbd.documento AND tb.cod_proveedor = tbd.cod_proveedor
LEFT OUTER JOIN PROVEEDORES p ON tb.cod_proveedor =  p.CODIGO 
INNER JOIN ArticulosCC ac ON ac.Articulo_ID = tbd.codigo_articulo
LEFT OUTER JOIN v_Lineas vl ON ac.Linea_ID = vl.Grupo_ID
LEFT OUTER JOIN v_Grupos vg ON ac.Grupo_ID = vg.Grupo_ID
AND ac.Linea_ID = vg.Linea_ID
WHERE CAST(convert(varchar, tb.fecha, 103) AS SMALLDATETIME) >= @Fecha_Ini
AND CAST(convert(varchar, tb.fecha, 103) AS SMALLDATETIME) <  @Fecha_Fin
 
) 


--SET DATEFORMAT DMY
--SELECT CAST(convert(varchar, tb.fecha, 103) AS SMALLDATETIME), * FROM Transaccion_Bodega tb


