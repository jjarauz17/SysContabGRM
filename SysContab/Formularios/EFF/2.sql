CREATE PROC JAR_BalanceGeneralActivos
	@Hasta SMALLDATETIME,
	@Moneda NVARCHAR(2),
	@Tipo NVARCHAR(2),
	@Empresa INT
AS

SET DATEFORMAT dmy;

--JAR_BalanceGeneralActivos '31/07/2015','02','A',1;

/*******************************************
 * Buscar Tipo de Comprobante de Cierre, 
 * para no tomar en cuenta en la consulta
 *******************************************/
DECLARE @Comp_Cierre INT
SELECT @Comp_Cierre = tc.TipComp_Id
FROM TipoComprobantes AS tc
WHERE tc.Empresa = @Empresa
AND tc.TipComp_Cierre = 1;

/*******************************************
 * Moneda base da la Empresa
 *******************************************/
DECLARE @MonedaBase NVARCHAR(5),
		@TC_MttoValor AS INT
		
SELECT @MonedaBase = emp_monedabase  
FROM EMPRESAS AS e WHERE e.CODIGO = @Empresa;

SELECT  @TC_MttoValor = ISNULL(TipComp_ID, 0)
FROM    TipoComprobantes
WHERE   empresa = @Empresa
        AND tipComp_Mtto = 1;

WITH CTE( 
		CUENTA,
		NOMBRE,
		SUBCUENTA,
		CLASE,
		DEBITO,
		CREDITO
) AS (

/*******************************************
 * Generando Saldos de las Cuentas
 *******************************************/
 
SELECT	ca.CUENTA, 
		ca.NOMBRE, 
		ca.SUBCUENTA,
		ca.CLASE,	
		
			
		--CASE WHEN cd.CDet_DC = 'D' THEN CASE WHEN (SELECT ed.Empresa FROM Empresas_Diferentes ed WHERE ed.Empresa = @Empresa) IS NULL THEN 
		--												cd.CDet_Importe * ISNULL(1 / CASE WHEN @MonedaBase = @Moneda THEN 1 
		--																				ELSE CASE WHEN c.Comp_TasaCambio <> 1 
		--																					THEN c.Comp_TasaCambio ELSE 
		--																						ISNULL(dbo.fTasa_Cambio(@Empresa, @MonedaBase, @Moneda, c.Comp_Fecha) ,1) END END , 1) 
		--									ELSE cd.CDet_Importe * ISNULL(1 / dbo.fTasa_Cambio(@Empresa, @MonedaBase, @Moneda, c.comp_fecha), 1) END
		--ELSE 0.00 END Debito,
		
		--CASE WHEN cd.CDet_DC = 'C' THEN CASE WHEN (SELECT ed.Empresa FROM Empresas_Diferentes ed WHERE ed.Empresa = @Empresa) IS NULL THEN 
		--												cd.CDet_Importe * ISNULL(1 / CASE WHEN @MonedaBase = @Moneda THEN 1 
		--																				ELSE CASE WHEN c.Comp_TasaCambio <> 1 
		--																					THEN c.Comp_TasaCambio ELSE 
		--																						ISNULL(dbo.fTasa_Cambio(@Empresa, @MonedaBase, @Moneda, c.Comp_Fecha) ,1) END END , 1) 
		--									ELSE cd.CDet_Importe * ISNULL(1 / dbo.fTasa_Cambio(@Empresa, @MonedaBase, @Moneda, c.comp_fecha), 1) END
		--ELSE 0.00 END Credito
		
		
		--SUM(CASE WHEN cd.CDet_DC = 'D' THEN cd.CDet_Importe * ISNULL(1 / CASE WHEN @MonedaBase = @Moneda THEN 1 
		--																	ELSE CASE WHEN c.Comp_TasaCambio <> 1 THEN c.Comp_TasaCambio 
		--																			ELSE dbo.fTasa_Cambio(@Empresa, @MonedaBase, @Moneda, c.comp_fecha) 
		--																		 END 
		--																  END , 1) ELSE 0.00 END) Debito,
																		  
		--SUM(CASE WHEN cd.CDet_DC = 'C' THEN cd.CDet_Importe * ISNULL(1 / CASE WHEN @MonedaBase = @Moneda THEN 1 
		--																	ELSE CASE WHEN c.Comp_TasaCambio <> 1 THEN c.Comp_TasaCambio 
		--																			ELSE dbo.fTasa_Cambio(@Empresa, @MonedaBase, @Moneda, c.comp_fecha) 
		--																		 END 
		--																  END, 1) ELSE 0.00 END) Credito
		
		SUM(CASE WHEN cd.CDet_DC = 'D' THEN cd.CDet_Importe ELSE 0.00 END) Debito,
		SUM(CASE WHEN cd.CDet_DC = 'C' THEN cd.CDet_Importe ELSE 0.00 END) Credito 
		
FROM Comprobantes AS c WITH (NOLOCK) INNER JOIN ComprobantesDetalles AS cd WITH (NOLOCK)
ON c.Comp_No = cd.Comp_No
AND c.Per_Id = cd.Per_Id
AND c.Mes = cd.Mes
AND c.Empresa = cd.Empresa
INNER JOIN CATALOGO AS ca WITH (NOLOCK) ON cd.CDet_Cuenta = ca.CUENTA
AND ca.EMPRESA = cd.Empresa

WHERE c.Comp_Fecha < = @Hasta
AND c.Empresa = @Empresa
AND ca.BALRES = 'B'
AND c.Comp_Tipo <> ISNULL(@Comp_Cierre,0)
--AND CASE WHEN @MonedaBase = @Moneda THEN CAST(1 AS BIT)
--	ELSE CASE WHEN c.Comp_tipo <> @TC_MttoValor THEN CAST(1 AS BIT)
--			ELSE CAST(0 AS BIT) 
--         END
--	END = CAST(1 AS BIT)

GROUP BY	ca.CUENTA, 
			ca.NOMBRE, 
			ca.SUBCUENTA,
			ca.CLASE
						
UNION ALL		

/*******************************************
 * Aplicando la Recursividad
 *******************************************/	
 
 SELECT ca.CUENTA, 
		ca.NOMBRE, 
		ca.SUBCUENTA,
		ca.CLASE,
		c.Debito,
		c.Credito
		 
 FROM CATALOGO AS ca 
 INNER JOIN CTE AS c ON ca.CUENTA = c.SUBCUENTA
 
 WHERE ca.EMPRESA = @Empresa
 AND ca.BALRES = 'B'

)

SELECT
	c.CUENTA,
	c.NOMBRE,
	c.SUBCUENTA,
	c.CLASE,
	SUM(c.DEBITO) DEBITO,
	SUM(c.CREDITO) CREDITO,
	SUM(c.DEBITO - c.CREDITO) SALDO
	---ROUND(SUM(CASE WHEN c.CLASE = 1 THEN c.DEBITO - c.CREDITO ELSE c.CREDITO - c.DEBITO END),2) SALDO
INTO #SALDOS
FROM
	CTE AS c 
GROUP BY	c.CUENTA,
			c.NOMBRE,
			c.SUBCUENTA,
			c.CLASE
ORDER BY c.CUENTA;

--SELECT * FROM #SALDOS;
--JAR_BalanceGeneralActivos '31/07/2015','02','A',1;

/*******************************************
 * Sumar las formulas que son 
 * cuentas contables
 *******************************************/
SELECT	gbr.IdGrupo, 
		gbr.Codigo,
		gbr.Nombre,
		
		CASE WHEN LEN(gbr.Cuenta) > 0 THEN 
			CASE WHEN gbr.Columna = 1 THEN 	
				ISNULL((SELECT SUM(SALDO) Saldo
					FROM #SALDOS s
				WHERE s.Cuenta IN (SELECT s.[Data] FROM dbo.[Split](gbr.Cuenta,',') AS s)),0.00)
			ELSE NULL END 
		ELSE NULL END Columna1,
		
		CASE WHEN LEN(gbr.Cuenta) > 0 THEN 
			CASE WHEN gbr.Columna = 2 THEN 	
				ISNULL((SELECT SUM(SALDO) Saldo
					FROM #SALDOS s
				WHERE s.Cuenta IN (SELECT s.[Data] FROM dbo.[Split](gbr.Cuenta,',') AS s)),0.00)
			ELSE NULL END 
		ELSE NULL END Columna2,
		
		CASE WHEN LEN(gbr.Cuenta) > 0 THEN 
			CASE WHEN gbr.Columna = 3 THEN 	
				ISNULL((SELECT SUM(SALDO) Saldo
					FROM #SALDOS s
				WHERE s.Cuenta IN (SELECT s.[Data] FROM dbo.[Split](gbr.Cuenta,',') AS s)),0.00)
			ELSE NULL END 
		ELSE NULL END Columna3,
		
		CASE WHEN LEN(gbr.Cuenta) > 0 THEN 
			CASE WHEN gbr.Columna = 4 THEN 	
				ISNULL((SELECT SUM(SALDO) Saldo
					FROM #SALDOS s
				WHERE s.Cuenta IN (SELECT s.[Data] FROM dbo.[Split](gbr.Cuenta,',') AS s)),0.00)
			ELSE NULL END 
		ELSE NULL END Columna4,
		
		gbr.Columna,
		gbr.Nivel,
		gbr.Formula,
		gbr.Tipo, 
		gbr.Tipo_Grupo, 
		gbr.Titulo, 
		gbr.SubTitulo, 
		gbr.Negrita,
		gbr.Utilidad_Mes, 
		gbr.Utilidad_Acumulado

INTO #CUENTAS					 
FROM GruposBalRes AS gbr

WHERE gbr.Tipo = 'B'
AND gbr.Tipo_Grupo = @Tipo
AND gbr.Empresa = @Empresa

ORDER BY gbr.Codigo;
 
 --/****************************************************************
-- * Actualizando valores para los Totales de las cuentas de Mayor
-- * Cursor que se encarga de sumar, restar, multiplicar, 
-- * todas las formulas de tipo Sub Titulo
-- ***************************************************************/
		
IF (SELECT COUNT(*) 
FROM #CUENTAS c 
WHERE LEN(c.Formula) > 0
AND (c.Columna1 IS NULL
OR c.Columna2 IS NULL
OR c.Columna3 IS NULL
OR c.Columna4 IS NULL) ) > 0
--AND er.SubTitulo = 1
BEGIN

REPETIR:	--Si se quedo alguna formula sin valor, volver a revisar

	DECLARE	@IdGrupo INT, 
			@Formula NVARCHAR(256)
			
	DECLARE CURSOR_FORMULAS CURSOR FOR
	
	SELECT	c.IdGrupo, 
			c.Formula
			
	FROM #CUENTAS c 
	WHERE LEN(c.Formula) > 0
	AND c.Columna1 IS NULL
	AND c.Columna2 IS NULL
	AND c.Columna3 IS NULL
	AND c.Columna4 IS NULL
	
	OPEN CURSOR_FORMULAS
	FETCH CURSOR_FORMULAS INTO @IdGrupo, @Formula;
	
	WHILE (@@FETCH_STATUS = 0)
	BEGIN
		
		UPDATE #CUENTAS SET Columna1 =		CASE WHEN Columna = 1 THEN ISNULL((SELECT SUM(ISNULL(CASE	WHEN g.Columna = 1 THEN g.Columna1 
																									WHEN g.Columna = 2 THEN g.Columna2
																									WHEN g.Columna = 3 THEN g.Columna3
																									WHEN g.Columna = 4 THEN g.Columna4 END ,0.00)) FROM #CUENTAS AS g
																			WHERE g.IdGrupo IN (SELECT s.[Data] FROM dbo.[Split](@Formula,',') AS s)),0.00)
											ELSE NULL END,
										
							Columna2 =		CASE WHEN Columna = 2 THEN ISNULL((SELECT SUM(ISNULL(CASE	WHEN g.Columna = 1 THEN g.Columna1 
																									WHEN g.Columna = 2 THEN g.Columna2
																									WHEN g.Columna = 3 THEN g.Columna3
																									WHEN g.Columna = 4 THEN g.Columna4 END ,0.00)) FROM #CUENTAS AS g
																			WHERE g.IdGrupo IN (SELECT s.[Data] FROM dbo.[Split](@Formula,',') AS s)),0.00)
											ELSE NULL END,
											
							Columna3 =		CASE WHEN Columna = 3 THEN ISNULL((SELECT SUM(ISNULL(CASE	WHEN g.Columna = 1 THEN g.Columna1 
																									WHEN g.Columna = 2 THEN g.Columna2
																									WHEN g.Columna = 3 THEN g.Columna3
																									WHEN g.Columna = 4 THEN g.Columna4 END ,0.00)) FROM #CUENTAS AS g
																			WHERE g.IdGrupo IN (SELECT s.[Data] FROM dbo.[Split](@Formula,',') AS s)),0.00)
											ELSE NULL END,
											
							Columna4 =		CASE WHEN Columna = 4 THEN ISNULL((SELECT SUM(ISNULL(CASE	WHEN g.Columna = 1 THEN g.Columna1 
																									WHEN g.Columna = 2 THEN g.Columna2
																									WHEN g.Columna = 3 THEN g.Columna3
																									WHEN g.Columna = 4 THEN g.Columna4 END ,0.00)) FROM #CUENTAS AS g
																			WHERE g.IdGrupo IN (SELECT s.[Data] FROM dbo.[Split](@Formula,',') AS s)),0.00)
											ELSE NULL END
		
		WHERE IdGrupo = @IdGrupo;
		
		FETCH CURSOR_FORMULAS INTO @IdGrupo, @Formula;	
	END;
	
	CLOSE CURSOR_FORMULAS;
	DEALLOCATE CURSOR_FORMULAS;
	
END;

	IF (SELECT COUNT(*) 
	FROM #CUENTAS c 
	WHERE LEN(c.Formula) > 0
	AND c.Columna1 IS NULL
	AND c.Columna2 IS NULL
	AND c.Columna3 IS NULL
	AND c.Columna4 IS NULL) > 0
		GOTO REPETIR;
		

/*******************************************
 * Consulta Principal
 *******************************************/		
DECLARE @EmpresaN NVARCHAR(256),
		@MonedaNombre NVARCHAR(50),
		@Nombre1 NVARCHAR(256),
		@Cargo1 NVARCHAR(256),
		@Nombre2 NVARCHAR(256),
		@Cargo2 NVARCHAR(256),
		@Nombre3 NVARCHAR(256),
		@Cargo3 NVARCHAR(256)

SELECT @EmpresaN = e.NOMBRE
FROM EMPRESAS AS e
WHERE e.CODIGO = @Empresa

SELECT @MonedaNombre = m.mon_simbolo + ' ' + m.mon_descripcion 
FROM Monedas AS m
WHERE m.empr_codigo = @Empresa
AND m.mon_codigo = @Moneda

SELECT	@Nombre1 = flc.nombre, 
		@Cargo1 = flc.cargo 
FROM FirmasLibrosContables AS flc
WHERE flc.empresa = @Empresa
AND flc.Orden = 1

SELECT	@Nombre2 = flc.nombre, 
		@Cargo2 = flc.cargo 
FROM FirmasLibrosContables AS flc
WHERE flc.empresa = @Empresa
AND flc.Orden = 3

SELECT	@Nombre3 = flc.nombre, 
		@Cargo3 = flc.cargo 
FROM FirmasLibrosContables AS flc
WHERE flc.empresa = @Empresa
AND flc.Orden = 2

/*******************************************
 * Verificar Moneda de impresion
 *******************************************/
 
IF @MonedaBase <> @Moneda	--Hacer Conversion de Moneda
BEGIN
	DECLARE @TCambio NUMERIC(18,4)
	
	SELECT @TCambio = ISNULL(dbo.fTasa_Cambio(@Empresa, @MonedaBase, @Moneda, @Hasta),1.00)
	
	--SELECT *
	UPDATE #CUENTAS SET Columna1 = ( Columna1 / @TCambio )
	FROM #CUENTAS c WHERE NOT c.Columna1 IS NULL
	
	--SELECT *
	UPDATE #CUENTAS SET Columna2 = ( Columna2 / @TCambio )
	FROM #CUENTAS c WHERE NOT c.Columna2 IS NULL
	
	--SELECT *
	UPDATE #CUENTAS SET Columna3 = ( Columna3 / @TCambio )
	FROM #CUENTAS c WHERE NOT c.Columna3 IS NULL
	
	--SELECT *
	UPDATE #CUENTAS SET Columna4 = ( Columna4 / @TCambio )
	FROM #CUENTAS c WHERE NOT c.Columna4 IS NULL	
END
			
SELECT	@EmpresaN Empresa,
		'Balance General' TituloReporte,
		@MonedaNombre Moneda,
		'Al: ' + CONVERT(VARCHAR,@Hasta,103) Fecha,
		c.Nombre,
		
		ROUND(c.Columna1,2) Columna1,
		ROUND(c.Columna2,2) Columna2,
		ROUND(c.Columna3,2) Columna3,
		ROUND(c.Columna4,2) Columna4,
		
		c.Nivel,
		c.Titulo, 
		c.SubTitulo, 
		c.Negrita,
		
		ISNULL(@Nombre1,'') Nombre1,
		ISNULL(@Cargo1,'Contador General') Cargo1,
		ISNULL(@Nombre2,'') Nombre2,
		ISNULL(@Cargo2,'Gerente General') Cargo2,
		ISNULL(@Nombre3,'') Nombre3,
		ISNULL(@Cargo3,'Gerente Financiero') Cargo3,
		SUSER_NAME() Usuario
				 
FROM #CUENTAS c
ORDER BY c.Codigo;


--JAR_BalanceGeneralActivos '31/07/2015','02','A',1;
				
DROP TABLE #SALDOS;
DROP TABLE #CUENTAS;

GO


CREATE PROCEDURE dbo.sp_del_GruposBalRes ( @IdGrupo AS int )  AS
BEGIN TRY
	DELETE dbo.GruposBalRes
	WHERE IdGrupo = @IdGrupo
END TRY
BEGIN CATCH
	-- Raise an error with the details of the exception
	DECLARE @ErrMsg nvarchar(4000), @ErrSeverity int
	SELECT @ErrMsg = ERROR_MESSAGE(),
		@ErrSeverity = ERROR_SEVERITY()
	
	RAISERROR(@ErrMsg, @ErrSeverity, 1)
END CATCH

GO

CREATE PROCEDURE dbo.sp_GetGruposPadres
	@Tipo NVARCHAR(5),
	@Empresa INT
 AS
	
SELECT	  IdGrupo
			--, b.Codigo + ' - ' + Nombre Nombre
			, CAST(b.IdGrupo AS NVARCHAR(10)) + ' - ' + Nombre Nombre
FROM dbo.GruposBalRes b
WHERE b.Tipo = @Tipo AND b.Empresa = @Empresa
ORDER BY b.Codigo

----sp_GetGruposPadres 'B', 1
--SELECT * 
--FROM GruposBalRes AS gbr
--WHERE gbr.Empresa = 1
--AND gbr.Tipo = 'B'
--AND gbr.IdPadre = 0

--/*******************************************
-- * Clonar Tabla y Limpiarla
-- *******************************************/			    	
--SELECT	gbr.Nivel IdGrupo, 
--		gbr.Nombre INTO #GruposBalRes_CLON
--FROM GruposBalRes AS gbr 
--WHERE gbr.Tipo = @Tipo
--AND gbr.Empresa = @Empresa
--TRUNCATE TABLE #GruposBalRes_CLON;

--/*******************************************
-- * Ordenar Grupo por Jerarquia segun IdPadre
-- *******************************************/  
 
--DECLARE @ID INT
 
--DECLARE CURSOR_ORDENAR_ARBOL CURSOR FOR
 
--SELECT IdGrupo
--FROM GruposBalRes AS gbr
--WHERE gbr.IdPadre = 0
--AND gbr.Tipo = @Tipo
--AND gbr.Empresa = @Empresa
--ORDER BY gbr.IdGrupo

--OPEN CURSOR_ORDENAR_ARBOL
--FETCH CURSOR_ORDENAR_ARBOL INTO @ID;
	
--WHILE (@@FETCH_STATUS = 0)
--BEGIN	
--	INSERT INTO #GruposBalRes_CLON	(	IdGrupo,							
--										Nombre 
--									)
--	SELECT	IdGrupo,			
--			Nombre 			
--	FROM GruposBalRes AS gbr
--	WHERE gbr.IdGrupo = @ID;
	
--	INSERT INTO #GruposBalRes_CLON	(	IdGrupo,								
--										Nombre 
--									)
--	SELECT	IdGrupo,			
--			Nombre			 
--	FROM GruposBalRes AS gbr
--	WHERE gbr.IdPadre = @ID 
--	ORDER BY gbr.IdGrupo;
	
--	FETCH CURSOR_ORDENAR_ARBOL INTO @ID;	
--END;

--CLOSE CURSOR_ORDENAR_ARBOL;
--DEALLOCATE CURSOR_ORDENAR_ARBOL;	


--SELECT	gbr.IdGrupo,
--		CAST(gbr.IdGrupo AS NVARCHAR(10)) + ' - ' + gbr.Nombre Nombre
--FROM #GruposBalRes_CLON gbr

----WHERE b.Tipo = @Tipo AND b.Empresa = @Empresa
----ORDER BY b.Codigo
----SELECT	  IdGrupo
----			--, b.Codigo + ' - ' + Nombre Nombre
----			, CAST(b.IdGrupo AS NVARCHAR(10)) + ' - ' + Nombre Nombre
----FROM dbo.GruposBalRes b
----WHERE b.Tipo = @Tipo AND b.Empresa = @Empresa
----ORDER BY b.Codigo

--TRUNCATE TABLE #GruposBalRes_CLON;

GO


CREATE  PROCEDURE dbo.sp_sel_GruposBalRes --1,'B'
	@ID INT,
	@Tipo NVARCHAR(5),
	@Empresa INT
 AS
 
IF @ID = 0
	SELECT g.IdGrupo ID
		, IdGrupo
		, Codigo
		, Nombre
		, Nivel
		, CASE WHEN Tipo = 'B' THEN 'BALANCE GENERAL' ELSE 'ESTADO DE RESULTADO' END Tipo
		, Orden
		, Cuenta
		, Color
		, CASE ISNULL(Operacion,0) WHEN 0 THEN 'Ninguna' WHEN 1 THEN 'Suma' WHEN 2 THEN 'Resta' WHEN 3 THEN 'Multiplicación' END Operacion
		, Formula
		, Fuente
		, CAST(Movimiento AS BIT) Movimiento
		, CAST(Titulo AS BIT) [Subraya + Negrita]
		, CAST(SubTitulo AS BIT) Subraya
		, CAST(Negrita AS BIT) Negrita
		, CAST(Anexo AS BIT) [Imprime Anexo]
		, g.Columna
		, CASE g.Tipo_Grupo WHEN '' THEN 'Ninguno'
							WHEN 'A' THEN 'Activos'
							WHEN 'P' THEN 'Pasivos' END Grupo
		, IdPadre
		, g.Factor
		, CAST(g.Utilidad AS BIT) Utilidad
		, CAST(g.Utilidad_Mes AS BIT) Utilidad_Mes
		, CAST(g.Utilidad_Acumulado AS BIT) Utilidad_Acumulado
		, CAST(g.VentasTotales AS BIT) [Ventas Totales]
		--, Usuario
		--, Registro
	FROM dbo.GruposBalRes g
	WHERE Tipo = @Tipo
	AND g.Empresa = @Empresa
	--ORDER BY g.IdGrupo
	ORDER BY g.Codigo
 
IF @ID > 0
SELECT *  
from GruposBalRes WHERE IdGrupo =@ID

GO

CREATE  PROCEDURE dbo.sp_upd_GruposBalRes (	@IdGrupo AS int, 
											@Codigo AS nvarchar(20), 
											@Nombre AS nvarchar(256), 
											@Nivel AS int, 
											@Tipo AS nvarchar(50), 
											@Orden AS int, 
											@Cuenta AS nvarchar(MAX), 
											@Color AS nvarchar(50), 
											@Operacion AS int, 
											@Formula AS nvarchar(MAX), 
											@Fuente AS nvarchar(50), 
											@Movimiento AS INT, 
											@IdPadre AS INT,
											@Titulo INT,
											@SubTitulo INT,
											@Tipo_Grupo NVARCHAR(5),
											@Factor NUMERIC(18,4),
											@Utilidad INT,
											@Utilidad_Mes INT,
											@Utilidad_Acumulado INT,
											@VentasTotales INT,
											@Empresa INT,
											@Columna INT,
											@Negrita INT,
											@Anexo INT)  AS
BEGIN TRY
	UPDATE dbo.GruposBalRes
	SET Codigo = @Codigo
		, Nombre = @Nombre
		, Nivel = @Nivel
		, Tipo = @Tipo
		, Orden = @Orden
		, Cuenta = @Cuenta
		, Color = @Color
		, Operacion = @Operacion
		, Formula = @Formula
		, Fuente = @Fuente
		, Movimiento = @Movimiento
		, IdPadre = @IdPadre
		, Titulo = @Titulo
		, SubTitulo = @SubTitulo
		, Tipo_Grupo = CASE WHEN @Tipo = 'B' THEN @Tipo_Grupo ELSE '' END
		, Factor = @Factor
		, Utilidad = @Utilidad
		, Utilidad_Mes = @Utilidad_Mes
		, Utilidad_Acumulado = @Utilidad_Acumulado
		, VentasTotales = @VentasTotales
		, Columna = @Columna
		, Negrita = @Negrita
		, Anexo = @Anexo
	WHERE IdGrupo = @IdGrupo
END TRY
BEGIN CATCH
	-- Raise an error with the details of the exception
	DECLARE @ErrMsg nvarchar(4000), @ErrSeverity int
	SELECT @ErrMsg = ERROR_MESSAGE(),
		@ErrSeverity = ERROR_SEVERITY()
	
	RAISERROR(@ErrMsg, @ErrSeverity, 1)
END CATCH

GO

CREATE  PROCEDURE dbo.sp_ins_GruposBalRes (	@IdGrupo AS INT OUTPUT,
											@Codigo AS nvarchar(20), 
											@Nombre AS nvarchar(256), 
											@Nivel AS int, 
											@Tipo AS nvarchar(50), 
											@Orden AS int, 
											@Cuenta AS nvarchar(MAX), 
											@Color AS nvarchar(50), 
											@Operacion AS int, 
											@Formula AS nvarchar(MAX), 
											@Fuente AS nvarchar(50), 
											@Movimiento AS INT, 
											@IdPadre AS int, 
											@Usuario AS nvarchar(50), 
											@Registro AS SMALLDATETIME,
											@Titulo INT,
											@SubTitulo INT,
											@Tipo_Grupo NVARCHAR(5),
											@Factor NUMERIC(18,12),
											@Utilidad INT,
											@Utilidad_Mes INT,
											@Utilidad_Acumulado INT,
											@VentasTotales INT,
											@Empresa INT,
											@Columna INT,
											@Negrita INT,
											@Anexo INT)  AS
BEGIN TRY
	INSERT INTO dbo.GruposBalRes (	Codigo, Nombre, Nivel, Tipo, Orden, Cuenta, Color, Operacion, Formula, 
									Fuente, Movimiento, IdPadre, Usuario, Registro, Titulo, SubTitulo, 
									Tipo_Grupo, Factor, Utilidad, Utilidad_Mes, Utilidad_Acumulado, VentasTotales, Empresa, Columna, Negrita, Anexo) 
	VALUES  (	@Codigo, @Nombre, @Nivel, @Tipo, @Orden, @Cuenta, @Color, @Operacion, @Formula, @Fuente, 
				@Movimiento, @IdPadre, @Usuario, @Registro, @Titulo, @SubTitulo, 
				CASE WHEN @Tipo = 'B' THEN @Tipo_Grupo ELSE '' END, @Factor, @Utilidad, @Utilidad_Mes, @Utilidad_Acumulado, @VentasTotales,@Empresa, @Columna, @Negrita, @Anexo)
	
	SELECT @IdGrupo = SCOPE_IDENTITY() 
END TRY
BEGIN CATCH
	-- Raise an error with the details of the exception
	DECLARE @ErrMsg nvarchar(4000), @ErrSeverity int
	SELECT @ErrMsg = ERROR_MESSAGE(),
		@ErrSeverity = ERROR_SEVERITY()
	
	RAISERROR(@ErrMsg, @ErrSeverity, 1)
END CATCH

GO


CREATE PROCEDURE [dbo].[JAR_LibroAuxiliarDetalle]
	@empresa NVARCHAR(50),
	@desde smalldatetime,
	@hasta smalldatetime,
	@moneda NVARCHAR(5),
	@Cuenta NVARCHAR(50)
AS

SET DATEFORMAT dmy;

--[JAR_LibroAuxiliar] 1,'01/08/2015','31/08/2015','1','%'

DECLARE @MonedaBase NVARCHAR(5),
		@MonedaN NVARCHAR(50),
		@PAbierto_1 INT,
		@FFinCerrados SMALLDATETIME, 
		@FInicioAbiertos SMALLDATETIME,
		@TC_MttoValor as INT,
		@NivelMayor INT,
		@CuentaBuscar NVARCHAR(10)

SELECT	@MonedaBase = e.emp_monedabase, 
		@NivelMayor = e.MAYOR
		
FROM EMPRESAS AS e WHERE e.CODIGO = @empresa

SELECT @MonedaN = m.mon_simbolo + ' - ' + m.mon_descripcion 
FROM Monedas AS m 

WHERE m.empr_codigo = @empresa 
AND m.mon_codigo = @MonedaBase

IF LEN(@Cuenta) > = @NivelMayor
	SELECT @CuentaBuscar = SUBSTRING(@Cuenta,1,@NivelMayor)
ELSE
	SELECT @CuentaBuscar = @Cuenta

Select @TC_MttoValor = isnull(TipComp_ID,0)
from TipoComprobantes
where empresa = @Empresa
and tipComp_Mtto = 1

set @tc_mttovalor = Case When @Monedabase = @Moneda Then 0 ELSE ISNULL(@tc_mttovalor,0) End

--Buscar la fecha final de ultimo periodo cerrado, previo a @Desde
select @FFinCerrados = Max(per_final)
from periodos
where empresa = @empresa
and per_estado = 1
and per_final < @Desde

if @FFinCerrados is not null
begin
	-- El siguiente periodo que esta abierto, luego del ultimo periodo cerrado
	Select @PAbierto_1 = isnull(per_ID,-1)
	From Periodos
	Where empresa = @empresa
	and dateadd(d,1,@FfinCerrados) between per_inicio and per_final

	select @FinicioAbiertos = Min(per_inicio)
	from periodos
	where empresa = @empresa
	and per_estado = 0
	--AND PER_ACTUAL IN (0,1)
end
else
begin
	select @FinicioAbiertos = dateadd(d,-1,Min(CONVERT(smalldatetime, CONVERT(nvarchar(10), comp_fecha, 103), 103)))
	from vComprobantes_DebitosCreditos
	where empresa = @empresa
end


Declare @Arbol as table
(
	empresa int,
	cuenta nvarchar(100),
	padre nvarchar(100),
	nombre nvarchar(100)
)

Declare @Cat as table
(
	empresa int,
	mayor nvarchar(100),
	SC01 nvarchar(100),
	SC02 nvarchar(100),
	SC03 nvarchar(100),
	SC04 nvarchar(100),
	SC05 nvarchar(100),
	SC06 nvarchar(100),
	SC07 nvarchar(100),
	SC08 nvarchar(100),
	SC09 nvarchar(100),
	cuenta nvarchar(100),
	clase INT
)


Insert into @Cat
select  c.EMPRESA ,
	isnull(case when len(c.CUENTA) > E.MAYOR THEN left(c.cuenta, E.MAYOR) ELSE null END, ' ') AS MAYOR, 
	isnull(case when len(c.CUENTA) > e.SC01 THEN left(c.cuenta, e.SC01) ELSE null END, ' ') AS SC01, 
	isnull(case when len(c.CUENTA) > e.SC02 THEN left(c.cuenta,e.SC02) ELSE null END, ' ') AS SC02, 
	isnull(case when len(c.CUENTA) > e.SC03 THEN left(c.cuenta, e.SC03) ELSE null END, ' ') AS SC03, 
	isnull(case when len(c.CUENTA) > e.SC04 THEN left(c.cuenta, e.SC04) ELSE null END, ' ') AS SC04, 
	isnull(case when len(c.CUENTA) > e.SC05 THEN left(c.cuenta, e.SC05) ELSE null END, ' ') AS SC05, 
	isnull(case when len(c.CUENTA) > e.SC06 THEN left(c.cuenta, e.SC06) ELSE null END, ' ') AS SC06, 
	isnull(case when len(c.CUENTA) > e.SC07 THEN left(c.cuenta, e.SC07) ELSE null END, ' ') AS SC07,
	isnull(case when len(c.CUENTA) > e.SC08 THEN left(c.cuenta, e.SC08) ELSE null END, ' ') AS SC08,
	isnull(case when len(c.CUENTA) > e.SC09 THEN left(c.cuenta, e.SC09) ELSE null END, ' ') AS SC09,
	cuenta, 
	c.CLASE
from catalogo c inner join EMPRESAS e on 
	c.EMPRESA = e.CODIGO
where c.EMPRESA = @empresa
AND c.CUENTA LIKE @CuentaBuscar + '%' 

--Procesar mayor
Insert into @Arbol
select empresa, cuenta, mayor, ' ' from @cat where mayor = ' '

--Procesar SC01
Insert into @Arbol
select empresa, cuenta, mayor, ' ' from @cat where mayor <> ' ' and SC01+SC02+SC03+SC04+SC05+SC06+SC07+SC08+SC09= ' '

--Procesar SC02
Insert into @Arbol
select empresa, cuenta, SC01, ' ' from @cat where mayor <> ' ' AND  SC01 <> ' ' and SC02+SC03+SC04+SC05+SC06+SC07+SC08+SC09= ' '

--Procesar SC03
Insert into @Arbol
select empresa, cuenta, SC02, ' ' from @cat where mayor <> ' ' AND SC01 <> ' ' AND SC02 <> ' ' AND SC03+SC04+SC05+SC06+SC07+SC08+SC09= ' '

--Procesar SC04
Insert into @Arbol
select empresa, cuenta, SC03, ' ' from @cat where mayor <> ' ' AND SC01 <> ' ' AND SC02 <> ' ' AND SC03 <> ' ' AND SC04+SC05+SC06+SC07+SC08+SC09= ' '

--Procesar SC05
Insert into @Arbol
select empresa, cuenta, SC04, ' ' from @cat where mayor <> ' ' AND SC01 <> ' ' AND SC02 <> ' ' AND SC03 <> ' ' AND SC04 <> ' '  AND SC05+SC06+SC07+SC08+SC09= ' '

--Procesar SC06
Insert into @Arbol
select empresa, cuenta, SC05, ' ' from @cat where mayor <> ' ' AND SC01 <> ' ' AND SC02 <> ' ' AND SC03 <> ' ' AND SC04 <> ' '  AND SC05 <> ' '  AND SC06+SC07+SC08+SC09= ' '

--Procesar SC07
Insert into @Arbol
select empresa, cuenta, SC06, ' ' from @cat where mayor <> ' ' AND SC01 <> ' ' AND SC02 <> ' ' AND SC03 <> ' ' AND SC04 <> ' '  AND SC05 <> ' '  AND SC06 <> ' ' AND SC07+SC08+SC09= ' '

--Procesar SC08
Insert into @Arbol
select empresa, cuenta, SC07, ' ' from @cat where mayor <> ' ' AND SC01 <> ' ' AND SC02 <> ' ' AND SC03 <> ' ' AND SC04 <> ' '  AND SC05 <> ' '  AND SC06 <> ' ' AND SC07 <> ' ' AND SC08+SC09= ' '

--Procesar SC09
Insert into @Arbol
select empresa, cuenta, SC08, ' ' from @cat where mayor <> ' ' AND SC01 <> ' ' AND SC02 <> ' ' AND SC03 <> ' ' AND SC04 <> ' '  AND SC05 <> ' '  AND SC06 <> ' ' AND SC07 <> ' ' AND SC08 <> ' ' AND SC09= ' '


update @Arbol 
	set nombre = c.NOMBRE  
from @arbol a left outer join CATALOGO c on 
	A.empresa = c.EMPRESa and
	a.cuenta = c.CUENTA 

Declare @Comprobantes as table
(
	empresa INT, 
	periodo INT, 
	mes  INT, 
	Comp_No  NVARCHAR(50), 
	Documento NVARCHAR(50),
	fecha smalldatetime,
	concepto nvarchar(1024),
	cuenta nvarchar(100),
	valor numeric(18,2),
	Saldo NUMERIC(18,2),
	SaldoD NUMERIC(18,2),
	SaldoC NUMERIC(18,2),
	debe NUMERIC(18,2),
	haber NUMERIC(18,2)
)

Insert into @Comprobantes

----SaldoInicial si hay periodo cerrado
--SELECT	CATALOGOSALDO.EMPRESA, 
--		CATALOGOSALDO.Per_Id, 
--		0,
--		dateadd(d,-1,@Desde) as comp_fecha,
--		'Saldo Anterior' as Concepto,
--		 catalogosaldo.cuenta,
--		 CATALOGOSALDO.SALDO, 
--		 CASE WHEN  Catalogo.CLASE = 1 THEN 'D' ELSE 'C' END		  
----saldo * ISNULL(1 / dbo.fTasa_Cambio(@Empresa, @MonedaBase, @Moneda,dateadd(d,1,@FfinCerrados)), 0) as Saldo
--FROM CATALOGOSALDO INNER JOIN Catalogo on catalogosaldo.empresa = catalogo.empresa and catalogosaldo.cuenta = catalogo.cuenta
--WHERE catalogosaldo.EMPRESA = @EMPRESA
--AND catalogosaldo.PER_id = @PABIERTO_1
--AND catalogo.tipo = 'A'

--UNION all
	--Saldo Inicial de las transacciones
SELECT	vcd.Empresa, 
		vcd.Per_Id, 
		vcd.Mes,
		'' Comp_No, 
		'' Documento,
		dbo.FormatFecha(DATEADD(DAY,-1,@desde)) Comp_fecha,
		--vcd.Comp_fecha, 
		'Saldo Anterior' Concepto, 
		vcd.CDet_Cuenta,
		
		CASE WHEN c.CLASE = 1 THEN vcd.Debitos - vcd.Creditos
			ELSE vcd.Creditos - vcd.Debitos END Valor,
			 
		CASE WHEN c.CLASE = 1 THEN vcd.Debitos - vcd.Creditos
			ELSE vcd.Creditos - vcd.Debitos END Saldo,
			
		vcd.Debitos SaldoD,
		vcd.Creditos SaldoC,
		
		--vcd.Debitos + vcd.Creditos Valor,
		--vcd.Debitos + vcd.Creditos Saldo,
		
		0.00 debe,
		0.00 haber
				
		--vcd.CDet_DC		
		--Cdet_cuenta as Cuenta, 
		--SUM(Debitos * CASE WHEN @MonedaBase = @Moneda THEN 1 ELSE CASE WHEN Comp_TasaCambio = 1 THEN 
		--	 isnull(1/dbo.fTasa_Cambio(@Empresa, @MonedaBase, @Moneda, comp_fecha),0) ELSE (1/Comp_TasaCambio) END END) 
		--- sum(Creditos * CASE WHEN @MonedaBase = @Moneda THEN 1 ELSE CASE WHEN Comp_TasaCambio = 1 THEN 
		--	 isnull(1/dbo.fTasa_Cambio(@Empresa, @MonedaBase, @Moneda, comp_fecha),0) ELSE (1/Comp_TasaCambio) END END) as Saldo
		
		from vComprobantes_DebitosCreditos vcd INNER JOIN  @Cat c ON vcd.Empresa = c.empresa
		AND vcd.CDet_Cuenta = c.cuenta
		
		--INNER JOIN CATALOGO AS c ON vcd.Empresa = c.EMPRESA
		--AND vcd.CDet_Cuenta = c.CUENTA
		 
		where vcd.empresa = @empresa
		AND dbo.FormatFecha(vcd.Comp_fecha) BETWEEN @FInicioAbiertos AND dbo.FormatFecha(DATEADD(d,-1,@Desde))				
		AND comp_tipo <> @TC_MttoValor		
		
UNION ALL

Select	c.Empresa as empresa, 
		c.Per_Id, 
		c.Mes, 
		tc.TipoComp_Abrev + '-' + CAST(c.Comp_No AS NVARCHAR(10)) Comp_No, 
		CASE	WHEN c.Tipo = 1 THEN c.Factura
				WHEN c.Tipo = 2 THEN cd.CDet_NoChk
		ELSE CASE WHEN (c.Concecutivo = '' OR c.Concecutivo = '0') THEN cd.Recibo ELSE c.Concecutivo END END Documento,
		c.Comp_Fecha, 
		CASE WHEN LEN(LTRIM(RTRIM( cd.CDet_Concepto))) = 0 THEN c.Comp_Concepto ELSE cd.CDet_Concepto END Concepto,	
		--c.Comp_Concepto,
		cd.CDet_Cuenta as Cuenta, 
		cd.CDet_Importe,
		0.00,
		0.00,
		0.00,
		CASE WHEN cd.CDet_DC  = 'D' then cd.CDet_Importe else 0 end as debe,
		CASE WHEN cd.CDet_DC  = 'C' then cd.CDet_Importe else 0 end as haber
		
		--ISNULL(cd.CDet_Importe,0) as Valor, 
		--cd.CDet_DC as DC
		
from comprobantes c inner join ComprobantesDetalles cd on 
	c.Empresa = cd.Empresa and
	c.Per_Id = cd.Per_Id and
	c.Mes = cd.Mes and
	c.Comp_No = cd.Comp_No 
	INNER JOIN TipoComprobantes AS tc ON c.Comp_Tipo = tc.TipComp_Id AND c.Empresa = tc.Empresa
	inner join EMPRESAS e ON c.Empresa = e.CODIGO 
	
where c.Empresa = case when @empresa = 0 then c.Empresa else @empresa end and
c.Comp_Fecha between @desde and @hasta 
AND cd.CDet_Importe > 0.00
AND cd.CDet_Cuenta LIKE @CuentaBuscar + '%' 

declare @tbl  as table
	(
	empresa int NULL,
	periodo int NULL,
	mes int NULL,
	Comp_No NVARCHAR(50) NULL,
	Documento NVARCHAR(50) NULL,
	fecha smalldatetime NULL,
	concepto nvarchar(400) NULL,
	cuenta nvarchar(100) NULL,
	valor numeric(18, 2) NULL,
	Saldo numeric(18, 2) NULL,
	SaldoD numeric(18, 2) NULL,
	SaldoC numeric(18, 2) NULL,
--	DC nvarchar(1) NULL,
	debe numeric(18, 2) NULL,
	haber numeric(18, 2) NULL,
	ncuenta nvarchar(100) NOT NULL,
	mayor nvarchar(100) NULL,
	nmayor nvarchar(100) NOT NULL,
	sc01 nvarchar(100) NULL,
	nsc01 nvarchar(100) NOT NULL,
	sc02 nvarchar(100) NULL,
	nsc02 nvarchar(100) NOT NULL,
	sc03 nvarchar(100) NULL,
	nsc03 nvarchar(100) NOT NULL,
	sc04 nvarchar(100) NULL,
	nsc04 nvarchar(100) NOT NULL,
	sc05 nvarchar(100) NULL,
	nsc05 nvarchar(100) NOT NULL,
	sc06 nvarchar(100) NULL,
	nsc06 nvarchar(100) NOT NULL,
	sc07 nvarchar(100) NULL,
	nsc07 nvarchar(100) NOT NULL,
	sc08 nvarchar(100) NULL,
	nsc08 nvarchar(100) NOT NULL,
	sc09 nvarchar(100) NULL,
	nsc09 nvarchar(100) NOT NULL,
	clase INT
	)  


insert into @tbl
select	c.empresa, 
		periodo, 
		mes, 
		Comp_No,
		Documento, 
		fecha, 
		concepto, 
		c.cuenta, 
		valor, --DC , 
		c.Saldo,
		c.SaldoD, 
		c.SaldoC,
		--case when c.DC = 'D' then c.valor else 0 end as debe,
		--case when c.DC = 'C' then c.valor else 0 end as haber,
		c.debe,
		c.Haber,
		isnull((select cat.nombre from catalogo as cat where cat.empresa = cc.empresa and cat.CUENTA = c.cuenta),' ') as ncuenta,
		isnull(cc.mayor,' '), 
			isnull((select cat.nombre from catalogo as cat where cat.empresa = cc.empresa and cat.CUENTA = cc.mayor),' ') as nmayor,
		isnull(cc.sc01,' '), 
			isnull((select cat.nombre from catalogo as cat where cat.empresa = cc.empresa and cat.CUENTA = cc.sc01),' ') as nsc01,
		isnull(cc.sc02,' '), 
			isnull((select cat.nombre from catalogo as cat where cat.empresa = cc.empresa and cat.CUENTA = cc.sc02),' ') as nsc02,
		isnull(cc.sc03,' '),
			isnull((select cat.nombre from catalogo as cat where cat.empresa = cc.empresa and cat.CUENTA = cc.sc03),' ') as nsc03,
		isnull(cc.sc04,' '),
			isnull((select cat.nombre from catalogo as cat where cat.empresa = cc.empresa and cat.CUENTA = cc.sc04),' ') as nsc04,
		isnull(cc.sc05,' '),
			isnull((select cat.nombre from catalogo as cat where cat.empresa = cc.empresa and cat.CUENTA = cc.sc05),' ') as nsc05,
		isnull(cc.sc06,' '),
			isnull((select cat.nombre from catalogo as cat where cat.empresa = cc.empresa and cat.CUENTA = cc.sc06),' ') as nsc06,
		isnull(cc.sc07,' '),
			isnull((select cat.nombre from catalogo as cat where cat.empresa = cc.empresa and cat.CUENTA = cc.sc07),' ') as nsc07,
		isnull(cc.sc08,' '),
			isnull((select cat.nombre from catalogo as cat where cat.empresa = cc.empresa and cat.CUENTA = cc.sc08),' ') as nsc08,
		isnull(cc.sc09,' '), 
			isnull((select cat.nombre from catalogo as cat where cat.empresa = cc.empresa and cat.CUENTA = cc.sc09),' ') as nsc09,
		cc.clase
			
from @Comprobantes c inner join @Cat cc on 
c.empresa = cc.empresa and
c.cuenta = cc.cuenta 

DECLARE @EmpresaN NVARCHAR(256)
SELECT @EmpresaN = e.NOMBRE
FROM EMPRESAS AS e WHERE e.CODIGO = @empresa
	
SELECT	@EmpresaN Empresa,
		'Libro Mayor Auxiliar' Titulo, 
		@desde Desde,
		@hasta Hasta,
		@MonedaN Moneda,
		'Usuario: ' + SUSER_NAME() Usuario,
		Fecha,
		Comp_No,
		Documento,
		Concepto ,
		cuenta ,
		--sum(valor) valor,
		--DC ,
		SUM(Saldo) SaldoAnterior,
		--SUM(SaldoD) SaldoAnterior,
		--SUM(SaldoC) SaldoAnteriorC,
		SUM(debe) debe ,
		SUM(haber) haber,
	
		SUM(Saldo) +  CASE WHEN clase  = 1 THEN SUM(debe) - SUM(haber) ELSE SUM(haber) - SUM(debe) END SaldoActual,
		
		SUM(Saldo) +  CASE WHEN clase  = 1 THEN SUM(debe) - SUM(haber) ELSE SUM(haber) - SUM(debe) END Acumulado,
	
	--CASE WHEN clase = 1 THEN SUM(Saldo) + CASE WHEN clase  = 1 THEN sum(debe) - sum(haber) ELSE sum(haber) - sum(debe) END 
	--	ELSE 0.00 END SaldoActual,
	
	--CASE WHEN clase = 2 THEN SUM(Saldo) + CASE WHEN clase  = 1 THEN sum(debe) - sum(haber) ELSE sum(haber) - sum(debe) END 
	--	ELSE 0.00 END  SaldoActualC,
	
	ncuenta ,
	mayor ,
	nmayor ,
	sc01 ,
	nsc01 ,
	sc02 ,
	nsc02 ,
	sc03 ,
	nsc03 ,
	sc04 ,
	nsc04 ,
	sc05 ,
	nsc05 ,
	sc06 ,
	nsc06 ,
	sc07 ,
	nsc07 ,
	sc08 ,
	nsc08 ,
	sc09 ,
	nsc09 
	from @Tbl
WHERE cuenta LIKE @Cuenta + '%'
GROUP BY 
		cuenta ,
		ncuenta ,
		mayor ,
		nmayor ,
		fecha,
		Comp_No,
		Documento,
		concepto,
		sc01 ,
		nsc01 ,
		sc02 ,
		nsc02 ,
		sc03 ,
		nsc03 ,
		sc04 ,
		nsc04 ,
		sc05 ,
		nsc05 ,
		sc06 ,
		nsc06 ,
		sc07 ,
		nsc07 ,
		sc08 ,
		nsc08 ,
		sc09 ,
		nsc09, 
		clase
order BY cuenta, fecha


--[JAR_LibroAuxiliarDetalle] 1,'01/08/2015','31/08/2015','1','%'1050 03 01 51'

GO


CREATE PROCEDURE [dbo].[JAR_LibroAuxiliar]
	@empresa NVARCHAR(50),
	@desde smalldatetime,
	@hasta smalldatetime,
	@moneda NVARCHAR(5),
	@Cuenta NVARCHAR(50)
AS

SET DATEFORMAT dmy;

--[JAR_LibroAuxiliar] 1,'01/08/2015','31/08/2015','1'

DECLARE @MonedaBase NVARCHAR(5),
		@MonedaN NVARCHAR(50),
		@PAbierto_1 INT,
		@FFinCerrados SMALLDATETIME, 
		@FInicioAbiertos SMALLDATETIME,
		@TC_MttoValor as INT

SELECT @MonedaBase = e.emp_monedabase
FROM EMPRESAS AS e WHERE e.CODIGO = 1

SELECT @MonedaN = m.mon_simbolo + ' - ' + m.mon_descripcion 
FROM Monedas AS m 
WHERE m.empr_codigo = 1 
AND m.mon_codigo = @MonedaBase

Select @TC_MttoValor = isnull(TipComp_ID,0)
from TipoComprobantes
where empresa = @Empresa
and tipComp_Mtto = 1

set @tc_mttovalor = Case When @Monedabase = @Moneda Then 0 ELSE ISNULL(@tc_mttovalor,0) End

--Buscar la fecha final de ultimo periodo cerrado, previo a @Desde
select @FFinCerrados = Max(per_final)
from periodos
where empresa = @empresa
and per_estado = 1
and per_final < @Desde

if @FFinCerrados is not null
begin
	-- El siguiente periodo que esta abierto, luego del ultimo periodo cerrado
	Select @PAbierto_1 = isnull(per_ID,-1)
	From Periodos
	Where empresa = @empresa
	and dateadd(d,1,@FfinCerrados) between per_inicio and per_final

	select @FinicioAbiertos = Min(per_inicio)
	from periodos
	where empresa = @empresa
	and per_estado = 0
	--AND PER_ACTUAL IN (0,1)
end
else
begin
	select @FinicioAbiertos = dateadd(d,-1,Min(CONVERT(smalldatetime, CONVERT(nvarchar(10), comp_fecha, 103), 103)))
	from vComprobantes_DebitosCreditos
	where empresa = @empresa
end


Declare @Arbol as table
(
	empresa int,
	cuenta nvarchar(100),
	padre nvarchar(100),
	nombre nvarchar(100)
)

Declare @Cat as table
(
	empresa int,
	mayor nvarchar(100),
	SC01 nvarchar(100),
	SC02 nvarchar(100),
	SC03 nvarchar(100),
	SC04 nvarchar(100),
	SC05 nvarchar(100),
	SC06 nvarchar(100),
	SC07 nvarchar(100),
	SC08 nvarchar(100),
	SC09 nvarchar(100),
	cuenta nvarchar(100),
	clase INT
)

Insert into @Cat
select  c.EMPRESA ,
	isnull(case when len(c.CUENTA) > E.MAYOR THEN left(c.cuenta, E.MAYOR) ELSE null END, ' ') AS MAYOR, 
	isnull(case when len(c.CUENTA) > e.SC01 THEN left(c.cuenta, e.SC01) ELSE null END, ' ') AS SC01, 
	isnull(case when len(c.CUENTA) > e.SC02 THEN left(c.cuenta,e.SC02) ELSE null END, ' ') AS SC02, 
	isnull(case when len(c.CUENTA) > e.SC03 THEN left(c.cuenta, e.SC03) ELSE null END, ' ') AS SC03, 
	isnull(case when len(c.CUENTA) > e.SC04 THEN left(c.cuenta, e.SC04) ELSE null END, ' ') AS SC04, 
	isnull(case when len(c.CUENTA) > e.SC05 THEN left(c.cuenta, e.SC05) ELSE null END, ' ') AS SC05, 
	isnull(case when len(c.CUENTA) > e.SC06 THEN left(c.cuenta, e.SC06) ELSE null END, ' ') AS SC06, 
	isnull(case when len(c.CUENTA) > e.SC07 THEN left(c.cuenta, e.SC07) ELSE null END, ' ') AS SC07,
	isnull(case when len(c.CUENTA) > e.SC08 THEN left(c.cuenta, e.SC08) ELSE null END, ' ') AS SC08,
	isnull(case when len(c.CUENTA) > e.SC09 THEN left(c.cuenta, e.SC09) ELSE null END, ' ') AS SC09,
	cuenta, 
	c.CLASE
from catalogo c inner join EMPRESAS e on 
	c.EMPRESA = e.CODIGO
where c.EMPRESA = case when @empresa  = 0 then c.EMPRESA else @empresa end 


--Procesar mayor
Insert into @Arbol
select empresa, cuenta, mayor, ' ' from @cat where mayor = ' '

--Procesar SC01
Insert into @Arbol
select empresa, cuenta, mayor, ' ' from @cat where mayor <> ' ' and SC01+SC02+SC03+SC04+SC05+SC06+SC07+SC08+SC09= ' '

--Procesar SC02
Insert into @Arbol
select empresa, cuenta, SC01, ' ' from @cat where mayor <> ' ' AND  SC01 <> ' ' and SC02+SC03+SC04+SC05+SC06+SC07+SC08+SC09= ' '

--Procesar SC03
Insert into @Arbol
select empresa, cuenta, SC02, ' ' from @cat where mayor <> ' ' AND SC01 <> ' ' AND SC02 <> ' ' AND SC03+SC04+SC05+SC06+SC07+SC08+SC09= ' '

--Procesar SC04
Insert into @Arbol
select empresa, cuenta, SC03, ' ' from @cat where mayor <> ' ' AND SC01 <> ' ' AND SC02 <> ' ' AND SC03 <> ' ' AND SC04+SC05+SC06+SC07+SC08+SC09= ' '

--Procesar SC05
Insert into @Arbol
select empresa, cuenta, SC04, ' ' from @cat where mayor <> ' ' AND SC01 <> ' ' AND SC02 <> ' ' AND SC03 <> ' ' AND SC04 <> ' '  AND SC05+SC06+SC07+SC08+SC09= ' '

--Procesar SC06
Insert into @Arbol
select empresa, cuenta, SC05, ' ' from @cat where mayor <> ' ' AND SC01 <> ' ' AND SC02 <> ' ' AND SC03 <> ' ' AND SC04 <> ' '  AND SC05 <> ' '  AND SC06+SC07+SC08+SC09= ' '

--Procesar SC07
Insert into @Arbol
select empresa, cuenta, SC06, ' ' from @cat where mayor <> ' ' AND SC01 <> ' ' AND SC02 <> ' ' AND SC03 <> ' ' AND SC04 <> ' '  AND SC05 <> ' '  AND SC06 <> ' ' AND SC07+SC08+SC09= ' '

--Procesar SC08
Insert into @Arbol
select empresa, cuenta, SC07, ' ' from @cat where mayor <> ' ' AND SC01 <> ' ' AND SC02 <> ' ' AND SC03 <> ' ' AND SC04 <> ' '  AND SC05 <> ' '  AND SC06 <> ' ' AND SC07 <> ' ' AND SC08+SC09= ' '

--Procesar SC09
Insert into @Arbol
select empresa, cuenta, SC08, ' ' from @cat where mayor <> ' ' AND SC01 <> ' ' AND SC02 <> ' ' AND SC03 <> ' ' AND SC04 <> ' '  AND SC05 <> ' '  AND SC06 <> ' ' AND SC07 <> ' ' AND SC08 <> ' ' AND SC09= ' '


update @Arbol 
	set nombre = c.NOMBRE  
from @arbol a left outer join CATALOGO c on 
	A.empresa = c.EMPRESa and
	a.cuenta = c.CUENTA 


Declare @Comprobantes as table
(
	empresa int, 
	periodo int, 
	mes  int, 
	id  int, 
	fecha smalldatetime,
	concepto nvarchar(1024),
	cuenta nvarchar(100),
	valor numeric(18,2),
	Saldo NUMERIC(18,2),
	SaldoD NUMERIC(18,2),
	SaldoC NUMERIC(18,2),
	debe NUMERIC(18,2),
	haber NUMERIC(18,2)
)

Insert into @Comprobantes

----SaldoInicial si hay periodo cerrado
--SELECT	CATALOGOSALDO.EMPRESA, 
--		CATALOGOSALDO.Per_Id, 
--		0,
--		dateadd(d,-1,@Desde) as comp_fecha,
--		'Saldo Anterior' as Concepto,
--		 catalogosaldo.cuenta,
--		 CATALOGOSALDO.SALDO, 
--		 CASE WHEN  Catalogo.CLASE = 1 THEN 'D' ELSE 'C' END		  
----saldo * ISNULL(1 / dbo.fTasa_Cambio(@Empresa, @MonedaBase, @Moneda,dateadd(d,1,@FfinCerrados)), 0) as Saldo
--FROM CATALOGOSALDO INNER JOIN Catalogo on catalogosaldo.empresa = catalogo.empresa and catalogosaldo.cuenta = catalogo.cuenta
--WHERE catalogosaldo.EMPRESA = @EMPRESA
--AND catalogosaldo.PER_id = @PABIERTO_1
--AND catalogo.tipo = 'A'

--UNION all
	--Saldo Inicial de las transacciones
SELECT	vcd.Empresa, 
		vcd.Per_Id, 
		vcd.Mes,
		0 Comp_No, 
		vcd.Comp_fecha, 
		'Saldo Anterior' Comp_Concepto, 
		vcd.CDet_Cuenta,
		
		CASE WHEN c.CLASE = 1 THEN vcd.Debitos - vcd.Creditos
			ELSE vcd.Creditos - vcd.Debitos END Valor,
			 
		CASE WHEN c.CLASE = 1 THEN vcd.Debitos - vcd.Creditos
			ELSE vcd.Creditos - vcd.Debitos END Saldo,
			
		vcd.Debitos SaldoD,
		vcd.Creditos SaldoC,
		
		--vcd.Debitos + vcd.Creditos Valor,
		--vcd.Debitos + vcd.Creditos Saldo,
		0.00 debe,
		0.00 haber
				
		--vcd.CDet_DC		
		--Cdet_cuenta as Cuenta, 
		--SUM(Debitos * CASE WHEN @MonedaBase = @Moneda THEN 1 ELSE CASE WHEN Comp_TasaCambio = 1 THEN 
		--	 isnull(1/dbo.fTasa_Cambio(@Empresa, @MonedaBase, @Moneda, comp_fecha),0) ELSE (1/Comp_TasaCambio) END END) 
		--- sum(Creditos * CASE WHEN @MonedaBase = @Moneda THEN 1 ELSE CASE WHEN Comp_TasaCambio = 1 THEN 
		--	 isnull(1/dbo.fTasa_Cambio(@Empresa, @MonedaBase, @Moneda, comp_fecha),0) ELSE (1/Comp_TasaCambio) END END) as Saldo
		
		from vComprobantes_DebitosCreditos vcd INNER JOIN CATALOGO AS c ON vcd.Empresa = c.EMPRESA
		AND vcd.CDet_Cuenta = c.CUENTA
		 
		where vcd.empresa = @empresa
		and CONVERT(smalldatetime, CONVERT(nvarchar(10), comp_fecha, 103), 103) between @FInicioAbiertos and dateadd(d,-1,@Desde)		
		and comp_tipo <> @TC_MttoValor
		--group by  cdet_cuenta

UNION ALL

Select	c.Empresa as empresa, 
		c.Per_Id, 
		c.Mes, 
		c.Comp_No, 
		c.Comp_Fecha, 
		c.Comp_Concepto,
		cd.CDet_Cuenta as Cuenta, 
		cd.CDet_Importe,
		0.00,
		0.00,
		0.00,
		case when cd.CDet_DC  = 'D' then cd.CDet_Importe else 0 end as debe,
		case when cd.CDet_DC  = 'C' then cd.CDet_Importe else 0 end as haber
		--ISNULL(cd.CDet_Importe,0) as Valor, 
		--cd.CDet_DC as DC
		
from comprobantes c inner join ComprobantesDetalles cd on 
	c.Empresa = cd.Empresa and
	c.Per_Id = cd.Per_Id and
	c.Mes = cd.Mes and
	c.Comp_No = cd.Comp_No inner join EMPRESAS e on 
	c.Empresa = e.CODIGO 
where c.Empresa = case when @empresa = 0 then c.Empresa else @empresa end and
c.Comp_Fecha between @desde and @hasta 
AND cd.CDet_Importe > 0.00


declare @tbl  as table
	(
	empresa int NULL,
	periodo int NULL,
	mes int NULL,
	id int NULL,
	fecha smalldatetime NULL,
	concepto nvarchar(400) NULL,
	cuenta nvarchar(100) NULL,
	valor numeric(18, 2) NULL,
	Saldo numeric(18, 2) NULL,
	SaldoD numeric(18, 2) NULL,
	SaldoC numeric(18, 2) NULL,
--	DC nvarchar(1) NULL,
	debe numeric(18, 2) NULL,
	haber numeric(18, 2) NULL,
	ncuenta nvarchar(100) NOT NULL,
	mayor nvarchar(100) NULL,
	nmayor nvarchar(100) NOT NULL,
	sc01 nvarchar(100) NULL,
	nsc01 nvarchar(100) NOT NULL,
	sc02 nvarchar(100) NULL,
	nsc02 nvarchar(100) NOT NULL,
	sc03 nvarchar(100) NULL,
	nsc03 nvarchar(100) NOT NULL,
	sc04 nvarchar(100) NULL,
	nsc04 nvarchar(100) NOT NULL,
	sc05 nvarchar(100) NULL,
	nsc05 nvarchar(100) NOT NULL,
	sc06 nvarchar(100) NULL,
	nsc06 nvarchar(100) NOT NULL,
	sc07 nvarchar(100) NULL,
	nsc07 nvarchar(100) NOT NULL,
	sc08 nvarchar(100) NULL,
	nsc08 nvarchar(100) NOT NULL,
	sc09 nvarchar(100) NULL,
	nsc09 nvarchar(100) NOT NULL,
	clase INT
	)  


insert into @tbl
select	c.empresa, 
		periodo, 
		mes, 
		id, 
		fecha, 
		concepto, 
		c.cuenta, 
		valor, --DC , 
		c.Saldo,
		c.SaldoD, 
		c.SaldoC,
		--case when c.DC = 'D' then c.valor else 0 end as debe,
		--case when c.DC = 'C' then c.valor else 0 end as haber,
		c.debe,
		c.Haber,
		isnull((select cat.nombre from catalogo as cat where cat.empresa = cc.empresa and cat.CUENTA = c.cuenta),' ') as ncuenta,
		isnull(cc.mayor,' '), 
			isnull((select cat.nombre from catalogo as cat where cat.empresa = cc.empresa and cat.CUENTA = cc.mayor),' ') as nmayor,
		isnull(cc.sc01,' '), 
			isnull((select cat.nombre from catalogo as cat where cat.empresa = cc.empresa and cat.CUENTA = cc.sc01),' ') as nsc01,
		isnull(cc.sc02,' '), 
			isnull((select cat.nombre from catalogo as cat where cat.empresa = cc.empresa and cat.CUENTA = cc.sc02),' ') as nsc02,
		isnull(cc.sc03,' '),
			isnull((select cat.nombre from catalogo as cat where cat.empresa = cc.empresa and cat.CUENTA = cc.sc03),' ') as nsc03,
		isnull(cc.sc04,' '),
			isnull((select cat.nombre from catalogo as cat where cat.empresa = cc.empresa and cat.CUENTA = cc.sc04),' ') as nsc04,
		isnull(cc.sc05,' '),
			isnull((select cat.nombre from catalogo as cat where cat.empresa = cc.empresa and cat.CUENTA = cc.sc05),' ') as nsc05,
		isnull(cc.sc06,' '),
			isnull((select cat.nombre from catalogo as cat where cat.empresa = cc.empresa and cat.CUENTA = cc.sc06),' ') as nsc06,
		isnull(cc.sc07,' '),
			isnull((select cat.nombre from catalogo as cat where cat.empresa = cc.empresa and cat.CUENTA = cc.sc07),' ') as nsc07,
		isnull(cc.sc08,' '),
			isnull((select cat.nombre from catalogo as cat where cat.empresa = cc.empresa and cat.CUENTA = cc.sc08),' ') as nsc08,
		isnull(cc.sc09,' '), 
			isnull((select cat.nombre from catalogo as cat where cat.empresa = cc.empresa and cat.CUENTA = cc.sc09),' ') as nsc09,
		cc.clase
			
from @Comprobantes c inner join @Cat cc on 
c.empresa = cc.empresa and
c.cuenta = cc.cuenta 

DECLARE @EmpresaN NVARCHAR(256)
SELECT @EmpresaN = e.NOMBRE
FROM EMPRESAS AS e WHERE e.CODIGO = @empresa
	
select 
	@EmpresaN Empresa,
	'Libro Mayor Auxiliar' Titulo, 
	@desde Desde,
	@hasta Hasta,
	@MonedaN Moneda,
	'Usuario: ' + SUSER_NAME() Usuario,
--	concepto ,
	cuenta ,
	--sum(valor) valor,
	--DC ,
	SUM(Saldo) SaldoAnterior,
	--SUM(SaldoD) SaldoAnterior,
	--SUM(SaldoC) SaldoAnteriorC,
	sum(debe) debe ,
	sum(haber) haber,
	
	SUM(Saldo) +  CASE WHEN clase  = 1 THEN sum(debe) - sum(haber) ELSE sum(haber) - sum(debe) END SaldoActual,
	
	--CASE WHEN clase = 1 THEN SUM(Saldo) + CASE WHEN clase  = 1 THEN sum(debe) - sum(haber) ELSE sum(haber) - sum(debe) END 
	--	ELSE 0.00 END SaldoActual,
	
	--CASE WHEN clase = 2 THEN SUM(Saldo) + CASE WHEN clase  = 1 THEN sum(debe) - sum(haber) ELSE sum(haber) - sum(debe) END 
	--	ELSE 0.00 END  SaldoActualC,
	
	ncuenta ,
	mayor ,
	nmayor ,
	sc01 ,
	nsc01 ,
	sc02 ,
	nsc02 ,
	sc03 ,
	nsc03 ,
	sc04 ,
	nsc04 ,
	sc05 ,
	nsc05 ,
	sc06 ,
	nsc06 ,
	sc07 ,
	nsc07 ,
	sc08 ,
	nsc08 ,
	sc09 ,
	nsc09 
	from @Tbl
WHERE cuenta LIKE @Cuenta + '%'
GROUP BY 
		cuenta ,
		ncuenta ,
		mayor ,
		nmayor ,
		sc01 ,
		nsc01 ,
		sc02 ,
		nsc02 ,
		sc03 ,
		nsc03 ,
		sc04 ,
		nsc04 ,
		sc05 ,
		nsc05 ,
		sc06 ,
		nsc06 ,
		sc07 ,
		nsc07 ,
		sc08 ,
		nsc08 ,
		sc09 ,
		nsc09, 
		clase
order BY cuenta

--[JAR_LibroDiario] 1,'01/01/2015','31/01/2015','01'

GO


CREATE PROC [dbo].[sp_GetCuentasCatalogoSeleccionar]
		@Empresa INT,
		@Data NVARCHAR(256)
AS

SELECT	c.CUENTA Cuenta, 
		c.NOMBRE NombreCuenta,
		'' Arbol,
		g.NOMBRE Grupo,
		CASE WHEN c.TIPO = 'M' THEN 'MAYOR'
			 WHEN c.TIPO = 'S' THEN 'SUB CUENTA'
			 WHEN c.TIPO = 'A' THEN 'AUXILIAR'
		END Tipo,
		--CAST(0 AS BIT) Seleccionar
		CAST(CASE WHEN d.[Data] IS NULL THEN 0 ELSE 1 END AS BIT) Seleccionar

FROM CATALOGO AS c 
INNER JOIN GRUPOS AS g ON c.GRUPO = g.CODIGO_GRUPO
AND c.BALRES = g.TIPO
AND c.EMPRESA = g.EMPRESA
LEFT OUTER JOIN ( 	
			SELECT s.[Data] FROM dbo.[Split](@Data,',') AS s ) d
		ON c.Cuenta = d.[Data]
WHERE c.EMPRESA = @Empresa

--WITH CTE (
--	Cuenta,
--	Nombre,
--	NombreCuenta,
--	Arbol, 
--	Tipo,
--	Clasificacion, 
--	Balanza
--		)
--		AS (
--			SELECT	c.Cuenta, 
--					c.NombreCuenta Nombre,
--					c.Cuenta + ' - ' + c.NombreCuenta NombreCuenta, 
--					CAST('' AS NVARCHAR(MAX)) Arbol, 
--					tc.Tipo,
--					CASE c.Clasificacion 
--					WHEN 'M' THEN 'MAYOR' 
--					WHEN 'A' THEN 'AUXILIAR' 
--					WHEN 'S' THEN 'SUBCUENTA' 
--					ELSE UPPER(c.Clasificacion) END Clasificacion,
--					c.Balanza
--			FROM Cuentas c
--					INNER JOIN Tipos_Cuentas tc ON tc.IdTipoCuenta = c.IdTipoCuenta
--			WHERE c.CuentaEnlace = ''	
			
--			--Aplicando Recursividad, para obtener Arbol de la Cuenta
--			UNION ALL
			
--			SELECT	c.Cuenta, 
--					c.NombreCuenta Nombre,
--					c.Cuenta + ' - ' + c.NombreCuenta NombreCuenta,
--					CAST(r.Arbol + '/' + RTRIM(LTRIM(r.Nombre)) + '/'   AS NVARCHAR(MAX)) Arbol,
--					tc.Tipo,
--					CASE c.Clasificacion 
--					WHEN 'M' THEN 'MAYOR' 
--					WHEN 'A' THEN 'AUXILIAR' 
--					WHEN 'S' THEN 'SUBCUENTA' 
--					ELSE UPPER(c.Clasificacion) END Clasificacion,
--					c.Balanza
					
--			FROM Cuentas c
--			INNER JOIN Tipos_Cuentas tc ON tc.IdTipoCuenta = c.IdTipoCuenta
--			INNER JOIN CTE AS r ON c.CuentaEnlace  = r.Cuenta	
--			WHERE c.CuentaEnlace <> ''
--		)

--		SELECT	Cuenta,
--				NombreCuenta,
--				Arbol, 
--				Tipo,
--				Clasificacion,
--				CAST(CASE WHEN d.[Data] IS NULL THEN 0 ELSE 1 END AS BIT) Seleccionar
				 
--		FROM CTE AS c LEFT OUTER JOIN ( 	
--			SELECT s.[Data] FROM dbo.[Split](@Data,',') AS s ) d
--		ON c.Cuenta = d.[Data]

--		WHERE c.Balanza = CASE WHEN @Clasificacion = 'M' THEN 1 ELSE c.Balanza END
--		ORDER BY c.Cuenta

GO


CREATE PROC JAR_EstadoDeResultado
	@Hasta SMALLDATETIME,
	@Moneda NVARCHAR(2),	
	@Empresa INT,
	@Comparativo BIT = 1
AS

SET DATEFORMAT dmy;

--EXEC JAR_EstadoDeResultado '31/07/2015','1',1
--SELECT * FROM UTILIDAD_EEFF AS ue

/*******************************************
 * Buscar Tipo de Comprobante de Cierre, 
 * para no tomar en cuenta en la consulta
 *******************************************/
DECLARE @Comp_Cierre INT
SELECT @Comp_Cierre = tc.TipComp_Id
FROM TipoComprobantes AS tc
WHERE tc.Empresa = @Empresa
AND tc.TipComp_Cierre = 1;
/*******************************************
 * Moneda base da la Empresa
 *******************************************/
DECLARE @MonedaBase NVARCHAR(5),
		@TC_MttoValor AS INT
		
SELECT @MonedaBase = emp_monedabase  
FROM EMPRESAS AS e WHERE e.CODIGO = @Empresa;

SELECT  @TC_MttoValor = ISNULL(TipComp_ID, 0)
FROM    TipoComprobantes
WHERE   empresa = @Empresa
        AND tipComp_Mtto = 1;
	
/*******************************************
 *La fecha de Inicio del periodo 
 *que incluye la fecha DESDE 
 *******************************************/
 DECLARE	@Desde SMALLDATETIME,
			@FAbiertos SMALLDATETIME
 
  SELECT  @FAbiertos = per_inicio
  FROM    Periodos
  WHERE   empresa = @empresa
          AND @Hasta BETWEEN per_inicio AND per_final	

SELECT @Desde = dbo.FormatFecha('1/' + dbo.padl(MONTH(@Hasta),2,'0') + '/' + dbo.padl(YEAR(@Hasta),4,'0'));

/*******************************************
 * Generando Saldos y movimientos del Mes
 *******************************************/ 
WITH CTE( 
		CUENTA,
		NOMBRE,
		SUBCUENTA,
		CLASE,
		BALRES,
		INGRESOS,
		DEBITO,
		CREDITO
) AS (

/*******************************************
 * Generando Saldos de las Cuentas
 *******************************************/

SELECT	ca.CUENTA, 
		ca.NOMBRE, 
		ca.SUBCUENTA,
		ca.CLASE,		
		ca.BALRES,				
		ca.Ingresos,
		
		ROUND(SUM(CASE WHEN cd.CDet_DC = 'D' THEN cd.CDet_Importe ELSE 0.00 END),2) Debito,
		ROUND(SUM(CASE WHEN cd.CDet_DC = 'C' THEN cd.CDet_Importe ELSE 0.00 END),2) Credito 
		
		--ROUND(SUM(CASE WHEN vcdc.CDet_DC = 'D' THEN vcdc.Debitos ELSE 0.00 END),2) Debito,
		--ROUND(SUM(CASE WHEN vcdc.CDet_DC = 'C' THEN vcdc.Creditos ELSE 0.00 END),2) Credito 
		
--FROM vComprobantes_DebitosCreditos AS vcdc 
--INNER JOIN CATALOGO AS ca ON vcdc.CDet_Cuenta = ca.CUENTA
--AND vcdc.Empresa = ca.EMPRESA
--WHERE vcdc.Comp_Fecha BETWEEN @Desde AND @Hasta
--AND vcdc.Empresa = @Empresa
--AND vcdc.BALRES = 'R'		
		
FROM Comprobantes AS c INNER JOIN ComprobantesDetalles AS cd
ON c.Comp_No = cd.Comp_No
AND c.Per_Id = cd.Per_Id
AND c.Mes = cd.Mes
AND c.Empresa = cd.Empresa
INNER JOIN CATALOGO AS ca ON cd.CDet_Cuenta = ca.CUENTA
AND ca.EMPRESA = cd.Empresa
WHERE c.Comp_Fecha BETWEEN @Desde AND @Hasta
AND c.Empresa = @Empresa
AND ca.BALRES = 'R'
AND c.Comp_Tipo <> ISNULL(@Comp_Cierre,0)

GROUP BY	ca.CUENTA, 
			ca.NOMBRE, 
			ca.SUBCUENTA,
			ca.CLASE,
			ca.BALRES,
			ca.Ingresos
						
UNION ALL		

/*******************************************
 * Aplicando la Recursividad
 *******************************************/	
 
 SELECT ca.CUENTA, 
		ca.NOMBRE, 
		ca.SUBCUENTA,
		ca.CLASE,
		ca.BALRES,
		ca.Ingresos,
		c.Debito,
		c.Credito
		 
 FROM CATALOGO AS ca 
 INNER JOIN CTE AS c ON ca.CUENTA = c.SUBCUENTA
 
 WHERE ca.EMPRESA = @Empresa
 AND ca.BALRES = 'R'
 
 )

SELECT
	c.CUENTA,
	c.NOMBRE,
	c.SUBCUENTA,
	c.CLASE,
	c.BALRES,
	c.INGRESOS,
	CASE WHEN c.CLASE = 2 THEN 1 ELSE -1 END SINGO,
	SUM(c.DEBITO) DEBITO,
	SUM(c.CREDITO) CREDITO,
	CASE WHEN c.CLASE = 2 THEN ROUND(SUM(c.CREDITO - c.DEBITO),2) ELSE ROUND(SUM(c.DEBITO - c.CREDITO),2) END SALDO
		  					
INTO #SaldoMes
FROM
	CTE AS c 
GROUP BY	c.CUENTA,
			c.NOMBRE,
			c.SUBCUENTA,
			c.CLASE,
			c.BALRES,
			c.INGRESOS
ORDER BY c.CUENTA;


/*******************************************
 * Generando Saldo Acumulado a la Fecha
 *******************************************/ 
WITH CTE( 
		CUENTA,
		NOMBRE,
		SUBCUENTA,
		CLASE,
		BALRES,
		INGRESOS,
		DEBITO,
		CREDITO
) AS (

/*******************************************
 * Generando Saldos de las Cuentas
 *******************************************/

SELECT	ca.CUENTA, 
		ca.NOMBRE, 
		ca.SUBCUENTA,
		ca.CLASE,		
		ca.BALRES,	
		ca.Ingresos,			
		ROUND(SUM(CASE WHEN cd.CDet_DC = 'D' THEN cd.CDet_Importe ELSE 0.00 END),2) Debito,
		ROUND(SUM(CASE WHEN cd.CDet_DC = 'C' THEN cd.CDet_Importe ELSE 0.00 END),2) Credito 		
		--ROUND(SUM(CASE WHEN vcdc.CDet_DC = 'D' THEN vcdc.Debitos ELSE 0.00 END),2) Debito,
		--ROUND(SUM(CASE WHEN vcdc.CDet_DC = 'C' THEN vcdc.Creditos ELSE 0.00 END),2) Credito 

--FROM vComprobantes_DebitosCreditos AS vcdc 
--INNER JOIN CATALOGO AS ca ON vcdc.CDet_Cuenta = ca.CUENTA
--AND vcdc.Empresa = ca.EMPRESA

--WHERE vcdc.Comp_Fecha BETWEEN @FAbiertos AND @Hasta
--AND vcdc.Empresa = @Empresa
--AND vcdc.BALRES = 'R'	
		
FROM Comprobantes AS c INNER JOIN ComprobantesDetalles AS cd
ON c.Comp_No = cd.Comp_No
AND c.Per_Id = cd.Per_Id
AND c.Mes = cd.Mes
AND c.Empresa = cd.Empresa
INNER JOIN CATALOGO AS ca ON cd.CDet_Cuenta = ca.CUENTA
AND ca.EMPRESA = cd.Empresa

WHERE c.Comp_Fecha BETWEEN @FAbiertos AND @Hasta
AND c.Empresa = @Empresa
AND ca.BALRES = 'R'
AND c.Comp_Tipo <> ISNULL(@Comp_Cierre,0)

GROUP BY	ca.CUENTA, 
			ca.NOMBRE, 
			ca.SUBCUENTA,
			ca.CLASE,
			ca.BALRES,
			ca.Ingresos
						
UNION ALL		

/*******************************************
 * Aplicando la Recursividad
 *******************************************/	
 
 SELECT ca.CUENTA, 
		ca.NOMBRE, 
		ca.SUBCUENTA,
		ca.CLASE,
		ca.BALRES,
		ca.Ingresos,
		c.Debito,
		c.Credito
		 
 FROM CATALOGO AS ca 
 INNER JOIN CTE AS c ON ca.CUENTA = c.SUBCUENTA
 
 WHERE ca.EMPRESA = @Empresa
 AND ca.BALRES = 'R'
 
 )

SELECT
	c.CUENTA,
	c.NOMBRE,
	c.SUBCUENTA,
	c.CLASE,
	c.BALRES,
	c.INGRESOS,
	CASE WHEN c.CLASE = 2 THEN 1 ELSE -1 END SINGO,
	SUM(c.DEBITO) DEBITO,
	SUM(c.CREDITO) CREDITO,
	CASE WHEN c.CLASE = 2 THEN ROUND(SUM(c.CREDITO - c.DEBITO),2) ELSE ROUND(SUM(c.DEBITO - c.CREDITO),2) END SALDO
		  					
INTO #Acumulado
FROM
	CTE AS c 
GROUP BY	c.CUENTA,
			c.NOMBRE,
			c.SUBCUENTA,
			c.CLASE,
			c.BALRES,
			c.INGRESOS
ORDER BY c.CUENTA;


/*******************************************
 * Generando Saldos y movimientos del Mes
 * comparativo con el año anterior
 *******************************************/ 
WITH CTE( 
		CUENTA,
		NOMBRE,
		SUBCUENTA,
		CLASE,
		BALRES,
		INGRESOS,
		DEBITO,
		CREDITO
) AS (

/*******************************************
 * Generando Saldos de las Cuentas
 *******************************************/

SELECT	ca.CUENTA, 
		ca.NOMBRE, 
		ca.SUBCUENTA,
		ca.CLASE,		
		ca.BALRES,		
		ca.Ingresos,		
		ROUND(SUM(CASE WHEN cd.CDet_DC = 'D' THEN cd.CDet_Importe ELSE 0.00 END),2) Debito,
		ROUND(SUM(CASE WHEN cd.CDet_DC = 'C' THEN cd.CDet_Importe ELSE 0.00 END),2) Credito 
		
		--ROUND(SUM(CASE WHEN vcdc.CDet_DC = 'D' THEN vcdc.Debitos ELSE 0.00 END),2) Debito,
		--ROUND(SUM(CASE WHEN vcdc.CDet_DC = 'C' THEN vcdc.Creditos ELSE 0.00 END),2) Credito 
		
--FROM vComprobantes_DebitosCreditos AS vcdc 
--INNER JOIN CATALOGO AS ca ON vcdc.CDet_Cuenta = ca.CUENTA
--AND vcdc.Empresa = ca.EMPRESA

--WHERE vcdc.Comp_Fecha BETWEEN DATEADD(YEAR,-1, @Desde) AND DATEADD(YEAR,-1, @Hasta)
--AND vcdc.Empresa = @Empresa
--AND vcdc.BALRES = 'R'			
		
FROM Comprobantes AS c INNER JOIN ComprobantesDetalles AS cd
ON c.Comp_No = cd.Comp_No
AND c.Per_Id = cd.Per_Id
AND c.Mes = cd.Mes
AND c.Empresa = cd.Empresa
INNER JOIN CATALOGO AS ca ON cd.CDet_Cuenta = ca.CUENTA
AND ca.EMPRESA = cd.Empresa

WHERE c.Comp_Fecha BETWEEN DATEADD(YEAR,-1, @Desde) AND DATEADD(YEAR,-1, @Hasta)
AND c.Empresa = @Empresa
AND ca.BALRES = 'R'
AND c.Comp_Tipo <> ISNULL(@Comp_Cierre,0)

GROUP BY	ca.CUENTA, 
			ca.NOMBRE, 
			ca.SUBCUENTA,
			ca.CLASE,
			ca.BALRES,
			ca.Ingresos
						
UNION ALL		

/*******************************************
 * Aplicando la Recursividad
 *******************************************/	
 
 SELECT ca.CUENTA, 
		ca.NOMBRE, 
		ca.SUBCUENTA,
		ca.CLASE,
		ca.BALRES,
		ca.Ingresos,
		c.Debito,
		c.Credito
		 
 FROM CATALOGO AS ca 
 INNER JOIN CTE AS c ON ca.CUENTA = c.SUBCUENTA
 
 WHERE ca.EMPRESA = @Empresa
 AND ca.BALRES = 'R'
 
 )

SELECT
	c.CUENTA,
	c.NOMBRE,
	c.SUBCUENTA,
	c.CLASE,
	c.BALRES,
	c.INGRESOS,
	CASE WHEN c.CLASE = 2 THEN 1 ELSE -1 END SINGO,
	SUM(c.DEBITO) DEBITO,
	SUM(c.CREDITO) CREDITO,
	CASE WHEN c.CLASE = 2 THEN ROUND(SUM(c.CREDITO - c.DEBITO),2) ELSE ROUND(SUM(c.DEBITO - c.CREDITO),2) END SALDO
		  					
INTO #SaldoMesAnterior
FROM
	CTE AS c 
GROUP BY	c.CUENTA,
			c.NOMBRE,
			c.SUBCUENTA,
			c.CLASE,
			c.BALRES,
			c.INGRESOS
ORDER BY c.CUENTA;


/*******************************************
 * Generando Saldo Acumulado a la Fecha del
 * año anterior
 *******************************************/ 
WITH CTE( 
		CUENTA,
		NOMBRE,
		SUBCUENTA,
		CLASE,
		BALRES,
		INGRESOS,
		DEBITO,
		CREDITO
) AS (

/*******************************************
 * Generando Saldos de las Cuentas
 *******************************************/

SELECT	ca.CUENTA, 
		ca.NOMBRE, 
		ca.SUBCUENTA,
		ca.CLASE,		
		ca.BALRES,				
		ca.Ingresos,
		ROUND(SUM(CASE WHEN cd.CDet_DC = 'D' THEN cd.CDet_Importe ELSE 0.00 END),2) Debito,
		ROUND(SUM(CASE WHEN cd.CDet_DC = 'C' THEN cd.CDet_Importe ELSE 0.00 END),2) Credito 
		--ROUND(SUM(CASE WHEN vcdc.CDet_DC = 'D' THEN vcdc.Debitos ELSE 0.00 END),2) Debito,
		--ROUND(SUM(CASE WHEN vcdc.CDet_DC = 'C' THEN vcdc.Creditos ELSE 0.00 END),2) Credito 

--FROM vComprobantes_DebitosCreditos AS vcdc 
--INNER JOIN CATALOGO AS ca ON vcdc.CDet_Cuenta = ca.CUENTA
--AND vcdc.Empresa = ca.EMPRESA

--WHERE vcdc.Comp_Fecha BETWEEN DATEADD(YEAR,-1, @FAbiertos)  AND DATEADD(YEAR,-1, @Hasta)
--AND vcdc.Empresa = @Empresa
--AND vcdc.BALRES = 'R'	
		
FROM Comprobantes AS c INNER JOIN ComprobantesDetalles AS cd
ON c.Comp_No = cd.Comp_No
AND c.Per_Id = cd.Per_Id
AND c.Mes = cd.Mes
AND c.Empresa = cd.Empresa
INNER JOIN CATALOGO AS ca ON cd.CDet_Cuenta = ca.CUENTA
AND ca.EMPRESA = cd.Empresa

WHERE c.Comp_Fecha BETWEEN DATEADD(YEAR,-1, @FAbiertos)  AND DATEADD(YEAR,-1, @Hasta)
AND c.Empresa = @Empresa
AND ca.BALRES = 'R'
AND c.Comp_Tipo <> ISNULL(@Comp_Cierre,0)

GROUP BY	ca.CUENTA, 
			ca.NOMBRE, 
			ca.SUBCUENTA,
			ca.CLASE,
			ca.BALRES,
			ca.Ingresos
						
UNION ALL		

/*******************************************
 * Aplicando la Recursividad
 *******************************************/	
 
 SELECT ca.CUENTA, 
		ca.NOMBRE, 
		ca.SUBCUENTA,
		ca.CLASE,
		ca.BALRES,
		ca.Ingresos,
		c.Debito,
		c.Credito
		 
 FROM CATALOGO AS ca 
 INNER JOIN CTE AS c ON ca.CUENTA = c.SUBCUENTA
 
 WHERE ca.EMPRESA = @Empresa
 AND ca.BALRES = 'R'
 
 )

SELECT
	c.CUENTA,
	c.NOMBRE,
	c.SUBCUENTA,
	c.CLASE,
	c.BALRES,
	c.INGRESOS,
	CASE WHEN c.CLASE = 2 THEN 1 ELSE -1 END SINGO,
	SUM(c.DEBITO) DEBITO,
	SUM(c.CREDITO) CREDITO,
	CASE WHEN c.CLASE = 2 THEN ROUND(SUM(c.CREDITO - c.DEBITO),2) ELSE ROUND(SUM(c.DEBITO - c.CREDITO),2) END SALDO
		  					
INTO #AcumuladoAnterior
FROM
	CTE AS c 
GROUP BY	c.CUENTA,
			c.NOMBRE,
			c.SUBCUENTA,
			c.CLASE,
			c.BALRES,
			c.INGRESOS
ORDER BY c.CUENTA;

/*******************************************
 * Creando una sola tabla con todos los 
 * saldos del mes, acumulados y comparativos
 *******************************************/
SELECT	s.CUENTA, 
		s.NOMBRE,
		s.SUBCUENTA,
		s.CLASE,
		s.BALRES,
		s.SINGO SIGNO,
		s.INGRESOS,
		SUM(MES_ACTUAL) MES_ACTUAL,
		SUM(MES_ANTERIOR) MES_ANTERIOR,
		SUM(ACUMULADO) ACUMULADO,
		SUM(ACUMULADO_ANTERIOR) ACUMULADO_ANTERIOR
INTO #SALDOS
FROM (	
SELECT	s.CUENTA, 
		s.NOMBRE,
		s.SUBCUENTA,
		s.CLASE,
		s.BALRES,
		s.SINGO,
		s.INGRESOS,
		s.SALDO MES_ACTUAL,
		0.00 MES_ANTERIOR,
		0.00 ACUMULADO,
		0.00  ACUMULADO_ANTERIOR
FROM #SaldoMes s
UNION ALL
SELECT	s.CUENTA, 
		s.NOMBRE,
		s.SUBCUENTA,
		s.CLASE,
		s.BALRES,
		s.SINGO,
		s.INGRESOS,
		0.00 MES_ACTUAL,
		s.SALDO MES_ANTERIOR,
		0.00 ACUMULADO,
		0.00  ACUMULADO_ANTERIOR 
FROM #SaldoMesAnterior s
UNION ALL
SELECT	s.CUENTA, 
		s.NOMBRE,
		s.SUBCUENTA,
		s.CLASE,
		s.BALRES,
		s.SINGO,
		s.INGRESOS,
		0.00 MES_ACTUAL,
		0.00 MES_ANTERIOR,
		s.SALDO ACUMULADO,
		0.00  ACUMULADO_ANTERIOR 
FROM #Acumulado s
UNION ALL
SELECT	s.CUENTA, 
		s.NOMBRE,
		s.SUBCUENTA,
		s.CLASE,
		s.BALRES,
		s.SINGO,
		s.INGRESOS,
		0.00 MES_ACTUAL,
		0.00 MES_ANTERIOR,
		0.00 ACUMULADO,
		s.SALDO  ACUMULADO_ANTERIOR 
FROM #AcumuladoAnterior s

) s GROUP BY	s.CUENTA, 
				s.NOMBRE,
				s.SUBCUENTA,
				s.CLASE,
				s.BALRES,
				s.SINGO,
				s.INGRESOS
				
				
--SELECT * FROM #SALDOS;		
--SET DATEFORMAT dmy; 	
--EXEC JAR_EstadoDeResultado '31/01/2014','1',1
				
/*******************************************
 * Sumar las formulas que son 
 * cuentas contables
 *******************************************/ 
SELECT	gbr.IdGrupo, 
		gbr.Codigo,
		gbr.Nombre,
												
		CASE WHEN LEN(gbr.Cuenta) > 0 THEN			 				
				ISNULL((SELECT SUM(s.MES_ACTUAL * s.SIGNO) Saldo
					FROM #SALDOS s
				WHERE s.Cuenta IN (SELECT s.[Data] FROM dbo.[Split](gbr.Cuenta,',') AS s)),0.00)			 
		ELSE NULL END Saldo,
		
		CAST(0.0000 AS NUMERIC(18,4)) PorcentajeSaldo,
		
		CASE WHEN LEN(gbr.Cuenta) > 0 THEN 				
				ISNULL((SELECT SUM(s.MES_ANTERIOR * s.SIGNO) Saldo
					FROM #SALDOS s
				WHERE s.Cuenta IN (SELECT s.[Data] FROM dbo.[Split](gbr.Cuenta,',') AS s)),0.00)			 
		ELSE NULL END SaldoAnterior,
		
		CAST(0.0000 AS NUMERIC(18,4)) PorcentajeSaldoAnterior,
		
		CASE WHEN LEN(gbr.Cuenta) > 0 THEN 				
				ISNULL((SELECT SUM(s.ACUMULADO * s.SIGNO) Saldo
					FROM #SALDOS s
				WHERE s.Cuenta IN (SELECT s.[Data] FROM dbo.[Split](gbr.Cuenta,',') AS s)),0.00)			 
		ELSE NULL END Acumulado,
		
		CAST(0.0000 AS NUMERIC(18,4)) PorcentajeAcumulado,
		
		CASE WHEN LEN(gbr.Cuenta) > 0 THEN 				
				ISNULL((SELECT SUM(s.ACUMULADO_ANTERIOR * s.SIGNO) Saldo
					FROM #SALDOS s
				WHERE s.Cuenta IN (SELECT s.[Data] FROM dbo.[Split](gbr.Cuenta,',') AS s)),0.00)			 
		ELSE NULL END AcumuladoAnterior,	
		
		CAST(0.0000 AS NUMERIC(18,4)) PorcentajeAcumuladoAnterior,			
				
		gbr.Columna,
		gbr.Nivel,
		gbr.IdPadre,
		gbr.Formula,
		gbr.Cuenta,
		gbr.Tipo, 
		gbr.Tipo_Grupo, 
		gbr.Titulo, 
		gbr.SubTitulo, 
		gbr.Negrita,
		gbr.Utilidad_Mes, 
		gbr.Utilidad_Acumulado,
		gbr.Signo, 
		gbr.VentasTotales, 
		gbr.Factor, 
		gbr.Utilidad

INTO #GRUPOS					 
FROM GruposBalRes AS gbr

WHERE gbr.Tipo = 'R'
AND gbr.Empresa = @Empresa

ORDER BY gbr.Codigo;

--SELECT * FROM #GRUPOS
--EXEC JAR_EstadoDeResultado '31/07/2015','1',1
--SELECT	c.IdGrupo, 
--			c.Formula,*			
--	FROM #GRUPOS c 
--	WHERE LEN(c.Formula) > 0
--	AND (c.Saldo IS NULL
--	OR c.SaldoAnterior IS NULL
--	OR c.Acumulado IS NULL
--	OR c.AcumuladoAnterior IS NULL)
--ORDER BY c.IdGrupo,idPadre

 --/****************************************************************
-- * Actualizando valores para los Totales de las cuentas de Mayor
-- * Cursor que se encarga de sumar, restar, multiplicar, 
-- * todas las formulas de tipo Sub Titulo
-- ***************************************************************/		
IF (SELECT COUNT(*) 
FROM #GRUPOS c 
WHERE LEN(c.Formula) > 0
AND (c.Saldo IS NULL
OR c.SaldoAnterior IS NULL
OR c.Acumulado IS NULL
OR c.AcumuladoAnterior IS NULL) ) > 0
--AND er.SubTitulo = 1
BEGIN

REPETIR:	--Si se quedo alguna formula sin valor, volver a revisar

	DECLARE	@IdGrupo INT, 
			@Formula NVARCHAR(256)
			
	DECLARE CURSOR_FORMULAS CURSOR FOR
	
	SELECT	c.IdGrupo, 
			c.Formula
			
	FROM #GRUPOS c 
	WHERE LEN(c.Formula) > 0
	AND (c.Saldo IS NULL
	OR c.SaldoAnterior IS NULL
	OR c.Acumulado IS NULL
	OR c.AcumuladoAnterior IS NULL)
	ORDER BY c.Codigo
	
	OPEN CURSOR_FORMULAS
	FETCH CURSOR_FORMULAS INTO @IdGrupo, @Formula;
	
	WHILE (@@FETCH_STATUS = 0)
	BEGIN
		
		UPDATE #GRUPOS SET Saldo =		ISNULL((SELECT SUM(ISNULL(g.Saldo ,0.00)) FROM #GRUPOS AS g
																			WHERE g.IdGrupo IN (SELECT s.[Data] FROM dbo.[Split](@Formula,',') AS s)),0.00)	* CASE WHEN Factor > 0 THEN Factor ELSE 1 END , 									
										
							SaldoAnterior =		ISNULL((SELECT SUM(ISNULL(g.SaldoAnterior ,0.00)) FROM #GRUPOS AS g
																			WHERE g.IdGrupo IN (SELECT s.[Data] FROM dbo.[Split](@Formula,',') AS s)),0.00) * CASE WHEN Factor > 0 THEN Factor ELSE 1 END ,
											
							Acumulado =		ISNULL((SELECT SUM(ISNULL(g.Acumulado ,0.00)) FROM #GRUPOS AS g
																			WHERE g.IdGrupo IN (SELECT s.[Data] FROM dbo.[Split](@Formula,',') AS s)),0.00) * CASE WHEN Factor > 0 THEN Factor ELSE 1 END ,
											
							AcumuladoAnterior =		ISNULL((SELECT SUM(ISNULL(g.AcumuladoAnterior ,0.00)) FROM #GRUPOS AS g
																			WHERE g.IdGrupo IN (SELECT s.[Data] FROM dbo.[Split](@Formula,',') AS s)),0.00) * CASE WHEN Factor > 0 THEN Factor ELSE 1 END 
		
		WHERE IdGrupo = @IdGrupo;
				
		
		FETCH CURSOR_FORMULAS INTO @IdGrupo, @Formula;	
	END;
	
	CLOSE CURSOR_FORMULAS;
	DEALLOCATE CURSOR_FORMULAS;
	
END;

	IF (SELECT COUNT(*) 
	FROM #GRUPOS c 
	WHERE LEN(c.Formula) > 0
	AND (c.Saldo IS NULL
	OR c.SaldoAnterior IS NULL
	OR c.Acumulado IS NULL
	OR c.AcumuladoAnterior IS NULL)) > 0
		GOTO REPETIR;
		
/*******************************************
 * Actualizar el Saldo del Mes con la utilidad
 * del peridodo
 *******************************************/
 --UPDATE #GRUPOS SET Saldo = Acumulado, 
	--				SaldoAnterior = AcumuladoAnterior
 --FROM #GRUPOS g
 --WHERE g.Factor > 0
 
 /*******************************************
  * Actualizar Formula de Utilidad Neta
  *******************************************/
 DECLARE @sFormula NVARCHAR(50)
 
 SELECT @sFormula = g.Formula
 FROM #GRUPOS g
 WHERE g.Utilidad = 1
 
 UPDATE #GRUPOS SET Saldo = ISNULL((SELECT SUM(CASE WHEN g.Factor > 0 THEN g.Saldo * -1 ELSE g.Saldo END)													
										FROM #GRUPOS g
										WHERE g.IdGrupo IN (SELECT s.[Data] FROM dbo.[Split](@Formula,',') AS s)),0.00),
					SaldoAnterior = ISNULL((SELECT SUM(CASE WHEN g.Factor > 0 THEN g.SaldoAnterior * -1 ELSE g.SaldoAnterior END)													
										FROM #GRUPOS g
										WHERE g.IdGrupo IN (SELECT s.[Data] FROM dbo.[Split](@Formula,',') AS s)),0.00),
					Acumulado = ISNULL((SELECT SUM(CASE WHEN g.Factor > 0 THEN g.Acumulado * -1 ELSE g.Acumulado END)													
										FROM #GRUPOS g
										WHERE g.IdGrupo IN (SELECT s.[Data] FROM dbo.[Split](@Formula,',') AS s)),0.00),
					AcumuladoAnterior = ISNULL((SELECT SUM(CASE WHEN g.Factor > 0 THEN g.AcumuladoAnterior * -1 ELSE g.AcumuladoAnterior END)													
										FROM #GRUPOS g
										WHERE g.IdGrupo IN (SELECT s.[Data] FROM dbo.[Split](@Formula,',') AS s)),0.00)
WHERE Utilidad = 1;
 
 --SELECT SUM(CASE WHEN g.Factor > 0 THEN g.Saldo * -1 ELSE g.Saldo END) Saldo,
	--	SUM(CASE WHEN g.Factor > 0 THEN g.SaldoAnterior * -1 ELSE g.SaldoAnterior END) SaldoAnterior,
	--	SUM(CASE WHEN g.Factor > 0 THEN g.Acumulado * -1 ELSE g.Acumulado END) Acumulado,
	--	SUM(CASE WHEN g.Factor > 0 THEN g.AcumuladoAnterior * -1 ELSE g.AcumuladoAnterior END) AcumuladoAnterior
		
 --FROM #GRUPOS g
 --WHERE g.IdGrupo IN (SELECT s.[Data] FROM dbo.[Split](@Formula,',') AS s)


 --SET DATEFORMAT dmy;
 --EXEC JAR_EstadoDeResultado '31/07/2015','1',1

/*******************************************
 * Cambiando los Signos para la presentacion 
 * del formato impreso
 *******************************************/
--SELECT * 
UPDATE #GRUPOS SET	Saldo = Saldo * -1,
					SaldoAnterior = SaldoAnterior *-1,
					Acumulado = Acumulado * -1,
					AcumuladoAnterior = AcumuladoAnterior * -1
FROM #GRUPOS
WHERE Signo = 1;

/*******************************************
 * Actualizar los Porcentaje en Relacion 
 * a las Ventas totales
 *******************************************/
 
DECLARE	@Ventas1 NUMERIC(18,4),
		@Ventas2 NUMERIC(18,4),
		@Ventas3 NUMERIC(18,4),
		@Ventas4 NUMERIC(18,4)
 
SELECT	@Ventas1 = ROUND(g.Saldo,2),
		@Ventas2 = ROUND(g.SaldoAnterior,2),
		@Ventas3 = ROUND(g.Acumulado,2),
		@Ventas4 = ROUND(g.AcumuladoAnterior,2)
		
FROM #GRUPOS g
WHERE g.VentasTotales = 1;

PRINT @Ventas1;
PRINT @Ventas2;
PRINT @Ventas3;
PRINT @Ventas4;
--SET DATEFORMAT dmy;
--EXEC JAR_EstadoDeResultado '31/07/2015','1',1

--SELECT PorcentajeSaldo, CAST(ROUND((Saldo / @Ventas2),2) AS NUMERIC(18,2)), * 
UPDATE #GRUPOS SET	PorcentajeSaldo = CAST(ROUND((CASE WHEN @Ventas1 = 0.00 THEN 0.00 ELSE Saldo / @Ventas1 END),4) AS NUMERIC(18,4)),
					PorcentajeSaldoAnterior = CAST(ROUND((CASE WHEN @Ventas2 = 0.00 THEN 0.00 ELSE SaldoAnterior / @Ventas2 END),4) AS NUMERIC(18,4)),
					PorcentajeAcumulado = CAST(ROUND((CASE WHEN @Ventas3 = 0.00 THEN 0.00 ELSE Acumulado / @Ventas3 END),4) AS NUMERIC(18,4)),
					PorcentajeAcumuladoAnterior = CAST(ROUND((CASE WHEN @Ventas4 = 0.00 THEN 0.00 ELSE AcumuladoAnterior / @Ventas4 END),4) AS NUMERIC(18,4))					
FROM #GRUPOS g
WHERE NOT g.Saldo IS NULL;

/*******************************************
 * Actualizar campos de porcentaje en NULL
 *******************************************/
UPDATE #GRUPOS SET	PorcentajeSaldo = NULL,
					PorcentajeSaldoAnterior = NULL,
					PorcentajeAcumulado = NULL,
					PorcentajeAcumuladoAnterior = NULL
FROM #GRUPOS g
WHERE g.Saldo IS NULL;

/*******************************************
 * Consulta Principal
 *******************************************/

DECLARE @EmpresaN NVARCHAR(256),
		@MonedaNombre NVARCHAR(50),
		@Nombre1 NVARCHAR(256),
		@Cargo1 NVARCHAR(256),
		@Nombre2 NVARCHAR(256),
		@Cargo2 NVARCHAR(256),
		@Nombre3 NVARCHAR(256),
		@Cargo3 NVARCHAR(256)

SELECT @EmpresaN = e.NOMBRE
FROM EMPRESAS AS e
WHERE e.CODIGO = @Empresa

SELECT @MonedaNombre = m.mon_simbolo + ' ' + m.mon_descripcion 
FROM Monedas AS m
WHERE m.empr_codigo = @Empresa
AND m.mon_codigo = @Moneda

SELECT	@Nombre1 = flc.nombre, 
		@Cargo1 = flc.cargo 
FROM FirmasLibrosContables AS flc
WHERE flc.empresa = @Empresa
AND flc.Orden = 1

SELECT	@Nombre2 = flc.nombre, 
		@Cargo2 = flc.cargo 
FROM FirmasLibrosContables AS flc
WHERE flc.empresa = @Empresa
AND flc.Orden = 3

SELECT	@Nombre3 = flc.nombre, 
		@Cargo3 = flc.cargo 
FROM FirmasLibrosContables AS flc
WHERE flc.empresa = @Empresa
AND flc.Orden = 2;

/*******************************************
 * Verificar Moneda de impresion
 *******************************************/ 
IF @MonedaBase <> @Moneda	--Hacer Conversion de Moneda
BEGIN
	DECLARE @TCambio NUMERIC(18,4)
	
	SELECT @TCambio = ISNULL(dbo.fTasa_Cambio(@Empresa, @MonedaBase, @Moneda, @Hasta),1.00)

	UPDATE #GRUPOS SET Saldo = ( Saldo / @TCambio )
	FROM #GRUPOS c WHERE NOT c.Saldo IS NULL;
	
	UPDATE #GRUPOS SET SaldoAnterior = ( SaldoAnterior / @TCambio )
	FROM #GRUPOS c WHERE NOT c.SaldoAnterior IS NULL;
	
	UPDATE #GRUPOS SET Acumulado = ( Acumulado / @TCambio )
	FROM #GRUPOS c WHERE NOT c.Acumulado IS NULL;
	
	UPDATE #GRUPOS SET AcumuladoAnterior = ( AcumuladoAnterior / @TCambio )
	FROM #GRUPOS c WHERE NOT c.AcumuladoAnterior IS NULL;
END

SELECT	@EmpresaN Empresa,
		'ESTADO DE RESULTADO' TituloReporte,
		@MonedaNombre Moneda,
		'Al: ' + CONVERT(VARCHAR,@Hasta,103) Fecha,
		
		ROUND(g.Saldo,2) Saldo,
		ROUND(g.PorcentajeSaldo,4) PorcentajeSaldo,
		
		ROUND(g.SaldoAnterior,2) SaldoAnterior,
		ROUND(g.PorcentajeSaldoAnterior,4) PorcentajeSaldoAnterior,
		
		ROUND(g.Acumulado,2) Acumulado,
		ROUND(g.PorcentajeAcumulado,4) PorcentajeAcumulado,
		
		ROUND(g.AcumuladoAnterior,2) AcumuladoAnterior,
		ROUND(g.PorcentajeAcumuladoAnterior,4) PorcentajeAcumuadoAnterior,
		
		g.Nombre,
		g.Nivel,
		g.Titulo, 
		g.SubTitulo, 
		g.Negrita,
		
		ISNULL(@Nombre1,'') Nombre1,
		ISNULL(@Cargo1,'Contador General') Cargo1,
		ISNULL(@Nombre2,'') Nombre2,
		ISNULL(@Cargo2,'Gerente General') Cargo2,
		ISNULL(@Nombre3,'') Nombre3,
		ISNULL(@Cargo3,'Gerente Financiero') Cargo3,
		SUSER_NAME() Usuario
FROM #GRUPOS g
ORDER BY g.Codigo;

TRUNCATE TABLE #SaldoMes;
TRUNCATE TABLE #Acumulado;
TRUNCATE TABLE #SaldoMesAnterior;
TRUNCATE TABLE #AcumuladoAnterior;
TRUNCATE TABLE #SALDOS;
TRUNCATE TABLE #GRUPOS;

--SET DATEFORMAT dmy;
--EXEC JAR_EstadoDeResultado '31/07/2015','1',1

GO

CREATE PROC JAR_GetBalanceAnexos
	@Desde SMALLDATETIME,
	@Hasta SMALLDATETIME,
	@Moneda NVARCHAR(2),	
	@Empresa INT
AS

SET DATEFORMAT dmy;

/*******************************************
 * Buscar Tipo de Comprobante de Cierre, 
 * para no tomar en cuenta en la consulta
 *******************************************/
DECLARE @Comp_Cierre INT
SELECT @Comp_Cierre = tc.TipComp_Id
FROM TipoComprobantes AS tc
WHERE tc.Empresa = @Empresa
AND tc.TipComp_Cierre = 1;

/*******************************************
 * Moneda base da la Empresa
 *******************************************/
DECLARE @MonedaBase NVARCHAR(5),
		@TC_MttoValor AS INT
		
SELECT @MonedaBase = emp_monedabase  
FROM EMPRESAS AS e WHERE e.CODIGO = @Empresa;

SELECT  @TC_MttoValor = ISNULL(TipComp_ID, 0)
FROM    TipoComprobantes
WHERE   empresa = @Empresa
        AND tipComp_Mtto = 1;

--EXEC JAR_GetBalanceAnexos '01/07/2015','31/07/2015','1',1;

WITH CTE( 
		CUENTA,
		NOMBRE,
		SUBCUENTA,
		CLASE,
		EMPRESA,
		TIPO,
		DEBITO,
		CREDITO
		
) AS (

/*******************************************
 * Generando Saldos de las Cuentas
 *******************************************/

SELECT	ca.CUENTA, 
		ca.NOMBRE, 
		ca.SUBCUENTA,
		ca.CLASE,		
		ca.EMPRESA,
		ca.TIPO,
		ROUND(SUM(CASE WHEN cd.CDet_DC = 'D' THEN cd.CDet_Importe ELSE 0.00 END),2) Debito,
		ROUND(SUM(CASE WHEN cd.CDet_DC = 'C' THEN cd.CDet_Importe ELSE 0.00 END),2) Credito 		
		
FROM Comprobantes AS c INNER JOIN ComprobantesDetalles AS cd
ON c.Comp_No = cd.Comp_No
AND c.Per_Id = cd.Per_Id
AND c.Mes = cd.Mes
AND c.Empresa = cd.Empresa
INNER JOIN CATALOGO AS ca ON cd.CDet_Cuenta = ca.CUENTA
AND ca.EMPRESA = cd.Empresa

WHERE c.Comp_Fecha < = @Hasta
AND c.Empresa = @Empresa
AND ca.BALRES = 'B'
AND c.Comp_Tipo <> ISNULL(@Comp_Cierre,0)

GROUP BY	ca.CUENTA, 
			ca.NOMBRE, 
			ca.SUBCUENTA,
			ca.CLASE, 
			ca.EMPRESA,
			ca.TIPO
						
UNION ALL		

/*******************************************
 * Aplicando la Recursividad
 *******************************************/	
 
 SELECT ca.CUENTA, 
		ca.NOMBRE, 
		ca.SUBCUENTA,
		ca.CLASE,
		ca.EMPRESA,
		ca.TIPO,
		c.Debito,
		c.Credito
		 
 FROM CATALOGO AS ca 
 INNER JOIN CTE AS c ON ca.CUENTA = c.SUBCUENTA
 AND ca.EMPRESA = c.EMPRESA
 
 WHERE c.EMPRESA = @Empresa
 AND ca.BALRES = 'B'
 
 )

/*******************************************
 * Saldo Acumulado a la Fecha
 *******************************************/
SELECT
	c.CUENTA Cuenta,
	c.NOMBRE Nombre,
	c.SUBCUENTA SubCuenta,
	c.CLASE Clase,
	c.TIPO,
	0.00 SaldoMes,	
	CASE WHEN c.CLASE = 1 THEN ROUND(SUM(c.DEBITO - c.CREDITO),2) ELSE
		 ROUND(SUM(c.CREDITO - c.DEBITO),2) END Acumulado	
INTO #Acumulado
FROM
	CTE AS c 
GROUP BY	c.CUENTA,
			c.NOMBRE,
			c.SUBCUENTA,
			c.CLASE,
			c.TIPO
ORDER BY c.CUENTA;


/*******************************************
 * Generando Saldo del Mes
 *******************************************/
 
WITH CTE( 
		CUENTA,
		NOMBRE,
		SUBCUENTA,
		CLASE,
		EMPRESA,
		TIPO,
		DEBITO,
		CREDITO
		
) AS (
	
/*******************************************
 * Generando Saldos de las Cuentas
 *******************************************/

SELECT	ca.CUENTA, 
		ca.NOMBRE, 
		ca.SUBCUENTA,
		ca.CLASE,		
		ca.EMPRESA,
		ca.TIPO,
		ROUND(SUM(CASE WHEN cd.CDet_DC = 'D' THEN cd.CDet_Importe ELSE 0.00 END),2) Debito,
		ROUND(SUM(CASE WHEN cd.CDet_DC = 'C' THEN cd.CDet_Importe ELSE 0.00 END),2) Credito 		
		
FROM Comprobantes AS c INNER JOIN ComprobantesDetalles AS cd
ON c.Comp_No = cd.Comp_No
AND c.Per_Id = cd.Per_Id
AND c.Mes = cd.Mes
AND c.Empresa = cd.Empresa
INNER JOIN CATALOGO AS ca ON cd.CDet_Cuenta = ca.CUENTA
AND ca.EMPRESA = cd.Empresa

WHERE c.Comp_Fecha BETWEEN @Desde AND @Hasta
AND c.Empresa = @Empresa
AND ca.BALRES = 'B'
AND c.Comp_Tipo <> ISNULL(@Comp_Cierre,0)

GROUP BY	ca.CUENTA, 
			ca.NOMBRE, 
			ca.SUBCUENTA,
			ca.CLASE, 
			ca.EMPRESA,
			ca.TIPO
						
UNION ALL		

/*******************************************
 * Aplicando la Recursividad
 *******************************************/	
 
 SELECT ca.CUENTA, 
		ca.NOMBRE, 
		ca.SUBCUENTA,
		ca.CLASE,
		ca.EMPRESA,
		ca.TIPO,
		c.Debito,
		c.Credito
		 
 FROM CATALOGO AS ca 
 INNER JOIN CTE AS c ON ca.CUENTA = c.SUBCUENTA
 AND ca.EMPRESA = c.EMPRESA
 
 WHERE c.EMPRESA = @Empresa
 AND ca.BALRES = 'B'
 
 )

SELECT	Saldo.Cuenta,
		Saldo.Nombre,
		Saldo.SubCuenta,
		Saldo.Clase,
		Saldo.TIPO Tipo,
		SUM(Saldo.SaldoMes) SaldoMes,
		SUM(Saldo.Acumulado) Acumulado
INTO #SaldoCuentas			
FROM (
SELECT
	c.CUENTA Cuenta,
	c.NOMBRE Nombre,
	c.SUBCUENTA SubCuenta,
	c.CLASE Clase,
	c.TIPO,
	CASE WHEN c.CLASE = 1 THEN ROUND(SUM(c.DEBITO - c.CREDITO),2) ELSE
		 ROUND(SUM(c.CREDITO - c.DEBITO),2) END SaldoMes,	
	0.00 Acumulado	
		
FROM CTE AS c 
GROUP BY	c.CUENTA,
			c.NOMBRE,
			c.SUBCUENTA,
			c.CLASE,
			C.TIPO
			
			
UNION ALL

SELECT	a.Cuenta,
		a.Nombre,
		a.SubCuenta,
		a.Clase,
		a.TIPO,
		a.SaldoMes,
		a.Acumulado
FROM #Acumulado a

) Saldo
	
GROUP BY Saldo.Cuenta,
		Saldo.Nombre,
		Saldo.SubCuenta,
		Saldo.Clase,
		Saldo.TIPO
		
ORDER BY Cuenta;

/*******************************************
 * Crear Tabla donde se guardara el resultado
 * por cuenta
 *******************************************/
 
 CREATE TABLE BG_ANEXOS (
				[IdGrupo] [INT], 
				[Codigo] [NVARCHAR](20),
				[Grupo] [NVARCHAR](256), 
				[Cuenta] [NVARCHAR](50), 
				[Nombre] [NVARCHAR](512), 
				[Tipo] [NVARCHAR](5), 
				[SaldoMes] [NUMERIC](18,2), 
				[Acumulado] [NUMERIC](18,2),
				[TotalMes] [NUMERIC](18,2), 
				[TotalAcumulado] [NUMERIC](18,2)	
 )
 
/*******************************************
 * Buscar las Cuentas que forman 
 * parte del anexo
 *******************************************/
 
 DECLARE	@IdGrupo INT,
			@Codigo NVARCHAR(20),
			@Grupo NVARCHAR(512),
			@Cuenta NVARCHAR(256),
			@Tipo NVARCHAR(5)

DECLARE CURSOR_ANEXOS CURSOR FOR						

SELECT	gbr.IdGrupo,
		gbr.Codigo,
		gbr.Nombre, 
		gbr.Cuenta
		
FROM GruposBalRes AS gbr
WHERE gbr.Empresa = @Empresa
AND gbr.Anexo = 1
ORDER BY gbr.Codigo;

OPEN CURSOR_ANEXOS
FETCH CURSOR_ANEXOS INTO @IdGrupo, @Codigo, @Grupo, @Cuenta;
	
WHILE (@@FETCH_STATUS = 0)
BEGIN
	
	DECLARE @CuentaBuscar NVARCHAR(50)
	
	DECLARE CURSOR_AGREGAR_CUENTAS CURSOR FOR		

	SELECT s.[Data] 
	FROM dbo.[Split](@Cuenta,',') AS s
	
	OPEN CURSOR_AGREGAR_CUENTAS
	FETCH CURSOR_AGREGAR_CUENTAS INTO @CuentaBuscar;
	
	WHILE (@@FETCH_STATUS = 0)
	BEGIN
		IF LEN(@CuentaBuscar) > 0
			INSERT INTO BG_ANEXOS
			SELECT	@IdGrupo IdGrupo, 
					@Codigo Codigo,
					UPPER(LTRIM(RTRIM(@Grupo))) Grupo, 
					sc.Cuenta, 
					sc.Nombre, 
					sc.Tipo,
					sc.SaldoMes, 
					sc.Acumulado,
					ISNULL((SELECT s.SaldoMes FROM #SaldoCuentas s WHERE s.Cuenta = @CuentaBuscar),0.00) TotalMes,
					ISNULL((SELECT s.Acumulado FROM #SaldoCuentas s WHERE s.Cuenta = @CuentaBuscar),0.00) TotalAcumulado
			FROM #SaldoCuentas sc
			WHERE sc.Cuenta LIKE @CuentaBuscar + '%';
	--	ELSE
			--SELECT	gbr.IdGrupo, 
			--gbr.Nombre, 
			--gbr.Cuenta
		
			--FROM GruposBalRes AS gbr
			--WHERE gbr.Empresa = 1
			--AND gbr.Anexo = 1;
			
			
		
		FETCH CURSOR_AGREGAR_CUENTAS INTO @CuentaBuscar;
	END
	
	CLOSE CURSOR_AGREGAR_CUENTAS;
	DEALLOCATE CURSOR_AGREGAR_CUENTAS;

	FETCH CURSOR_ANEXOS INTO @IdGrupo, @Codigo, @Grupo, @Cuenta;	
END

CLOSE CURSOR_ANEXOS;
DEALLOCATE CURSOR_ANEXOS;

/*******************************************
 * Insertar Cuentas de CAPITAL
 *******************************************/
 
 INSERT INTO BG_ANEXOS
 SELECT		99999 IdGrupo, 
			'99999' Codigo,
			'CAPITAL' Grupo, 
			sc.Cuenta, 
			sc.Nombre, 
			sc.Tipo,
			sc.SaldoMes, 
			sc.Acumulado,
			sc.SaldoMes, 
			sc.Acumulado			
 
FROM #SaldoCuentas sc
WHERE sc.Cuenta IN (SELECT gbr.Cuenta		
FROM GruposBalRes AS gbr
WHERE gbr.Empresa = @Empresa
AND gbr.Cuenta LIKE '3%')

--SET DATEFORMAT dmy;
---EXEC JAR_GetBalanceAnexos '01/07/2015','31/07/2015','1',1;

/*******************************************
 * Insertar Utilidad Acumulada y Utilidad 
 * del Periodo
 *******************************************/
INSERT INTO BG_ANEXOS
SELECT 99999 IdGrupo, 
		'99999' Codigo,
		'CAPITAL' Grupo, 
		ue.Cuenta, 
		ue.Nombre, 
		'A',
		ue.TotalMes ,
		ue.TotalAcumulado,
		0.00, 
		0.00 
FROM UTILIDAD_EEFF AS ue;

/*******************************************
 * Sumar Cuentas de Capital
 *******************************************/ 
 UPDATE BG_ANEXOS SET	TotalMes = ISNULL( (SELECT SUM(s.SaldoMes) FROM BG_ANEXOS s WHERE s.Cuenta LIKE '3%') , 0.00), 
						TotalAcumulado = ISNULL( (SELECT SUM(s.Acumulado) FROM BG_ANEXOS s WHERE s.Cuenta LIKE '3%'), 0.00)
 WHERE Cuenta LIKE '3%';
 
 --SELECT SUM(s.SaldoMes) FROM BG_ANEXOS s WHERE s.Cuenta LIKE '3%'
						
/*******************************************
 * Borrar Las cuentsa sin movimientos
 *******************************************/
 DELETE FROM BG_ANEXOS
 WHERE SaldoMes = 0.00 AND Acumulado = 0.00;

/*******************************************
 * Consulta Principal
 *******************************************/		
DECLARE @EmpresaN NVARCHAR(256),
		@MonedaNombre NVARCHAR(50)

SELECT @EmpresaN = e.NOMBRE
FROM EMPRESAS AS e
WHERE e.CODIGO = @Empresa

SELECT @MonedaNombre = m.mon_simbolo + ' ' + m.mon_descripcion 
FROM Monedas AS m
WHERE m.empr_codigo = @Empresa
AND m.mon_codigo = @Moneda

--SELECT SUM(ba.SaldoMes) 
--FROM BG_ANEXOS ba WHERE ba.SaldoMes WHERE ba.Cuenta LIKE '3%'

/*******************************************
 * Verificar Moneda de impresion
 *******************************************/
IF @MonedaBase <> @Moneda	--Hacer Conversion de Moneda
BEGIN
	DECLARE @TCambio NUMERIC(18,4)
	
	SELECT @TCambio = ISNULL(dbo.fTasa_Cambio(@Empresa, @MonedaBase, @Moneda, @Hasta),1.00)
	
	UPDATE BG_ANEXOS SET SaldoMes = ( SaldoMes / @TCambio )
	FROM BG_ANEXOS c WHERE NOT c.SaldoMes IS NULL;
	
	UPDATE BG_ANEXOS SET Acumulado = ( Acumulado / @TCambio )
	FROM BG_ANEXOS c WHERE NOT c.Acumulado IS NULL;
	
	UPDATE BG_ANEXOS SET TotalMes = ( TotalMes / @TCambio )
	FROM BG_ANEXOS c WHERE NOT c.TotalMes IS NULL;
	
	UPDATE BG_ANEXOS SET TotalAcumulado = ( TotalAcumulado / @TCambio )
	FROM BG_ANEXOS c WHERE NOT c.TotalAcumulado IS NULL;
END

SELECT	@EmpresaN Empresa,
		'NOTAS A ESTADOS FINANCIEROS' TituloReporte,
		@MonedaNombre Moneda,
		'Al: ' + CONVERT(VARCHAR,@Hasta,103) Fecha,
		Codigo IdGrupo,
		c.Codigo,
		c.Grupo,
		c.Cuenta, 
		c.Nombre, 
		c.Tipo,
		c.SaldoMes, 
		c.Acumulado,
		c.TotalMes, 
		c.TotalAcumulado,
		SUSER_NAME() Usuario
FROM BG_ANEXOS c
ORDER BY c.Codigo	--, c.Cuenta

DROP TABLE #Acumulado;
DROP TABLE #SaldoCuentas;
DROP TABLE BG_ANEXOS;

--EXEC JAR_GetBalanceAnexos '01/07/2015','31/07/2015','1',1;
--JAR_GetBalanceAnexos '01/03/2015','31/03/2015','1',16;

GO


CREATE PROC JAR_BalanceGeneralPasivo
	@Hasta SMALLDATETIME,
	@Moneda NVARCHAR(2),
	@Tipo NVARCHAR(2),
	@Empresa INT
AS

SET DATEFORMAT dmy;

--EXEC JAR_BalanceGeneralPasivo '31/07/2015','1','P',1
--SELECT * FROM UTILIDAD_EEFF AS ue

/*******************************************
 * Buscar Tipo de Comprobante de Cierre, 
 * para no tomar en cuenta en la consulta
 *******************************************/
DECLARE @Comp_Cierre INT
SELECT @Comp_Cierre = tc.TipComp_Id
FROM TipoComprobantes AS tc
WHERE tc.Empresa = @Empresa
AND tc.TipComp_Cierre = 1;

/*******************************************
 * Moneda base da la Empresa
 *******************************************/
DECLARE @MonedaBase NVARCHAR(5),
		@TC_MttoValor AS INT
		
SELECT @MonedaBase = emp_monedabase  
FROM EMPRESAS AS e WHERE e.CODIGO = @Empresa;

SELECT  @TC_MttoValor = ISNULL(TipComp_ID, 0)
FROM    TipoComprobantes
WHERE   empresa = @Empresa
        AND tipComp_Mtto = 1;

WITH CTE( 
		CUENTA,
		NOMBRE,
		SUBCUENTA,
		CLASE,
		BALRES,
		DEBITO,
		CREDITO
) AS (

/*******************************************
 * Generando Saldos de las Cuentas
 *******************************************/

SELECT	ca.CUENTA, 
		ca.NOMBRE, 
		ca.SUBCUENTA,
		ca.CLASE,		
		ca.BALRES,
		SUM(CASE WHEN cd.CDet_DC = 'D' THEN cd.CDet_Importe ELSE 0.00 END) Debito,
		SUM(CASE WHEN cd.CDet_DC = 'C' THEN cd.CDet_Importe ELSE 0.00 END) Credito
		
		--ROUND(SUM(CASE WHEN cd.CDet_DC = 'D' THEN cd.CDet_Importe ELSE 0.00 END),2) Debito,
		--ROUND(SUM(CASE WHEN cd.CDet_DC = 'C' THEN cd.CDet_Importe ELSE 0.00 END),2) Credito
		
		--CASE WHEN cd.CDet_DC = 'D' THEN CASE WHEN (SELECT ed.Empresa FROM Empresas_Diferentes ed WHERE ed.Empresa = @Empresa) IS NULL THEN 
		--												cd.CDet_Importe * ISNULL(1 / CASE WHEN @MonedaBase = @Moneda THEN 1 
		--																				ELSE CASE WHEN c.Comp_TasaCambio <> 1 
		--																					THEN c.Comp_TasaCambio ELSE 
		--																						ISNULL(dbo.fTasa_Cambio(@Empresa, @MonedaBase, @Moneda, c.Comp_Fecha) ,1) END END , 1) 
		--									ELSE cd.CDet_Importe * ISNULL(1 / dbo.fTasa_Cambio(@Empresa, @MonedaBase, @Moneda, c.comp_fecha), 1) END
		--ELSE 0.00 END Debito,
		
		--CASE WHEN cd.CDet_DC = 'C' THEN CASE WHEN (SELECT ed.Empresa FROM Empresas_Diferentes ed WHERE ed.Empresa = @Empresa) IS NULL THEN 
		--												cd.CDet_Importe * ISNULL(1 / CASE WHEN @MonedaBase = @Moneda THEN 1 
		--																				ELSE CASE WHEN c.Comp_TasaCambio <> 1 
		--																					THEN c.Comp_TasaCambio ELSE 
		--																						ISNULL(dbo.fTasa_Cambio(@Empresa, @MonedaBase, @Moneda, c.Comp_Fecha) ,1) END END , 1) 
		--									ELSE cd.CDet_Importe * ISNULL(1 / dbo.fTasa_Cambio(@Empresa, @MonedaBase, @Moneda, c.comp_fecha), 1) END
		--ELSE 0.00 END Credito 
		
		--SUM(CASE WHEN cd.CDet_DC = 'D' THEN cd.CDet_Importe * ISNULL(1 / dbo.fTasa_Cambio(@Empresa, @MonedaBase, @Moneda, c.comp_fecha), 1) ELSE 0.00 END) Debito,
		--SUM(CASE WHEN cd.CDet_DC = 'C' THEN cd.CDet_Importe * ISNULL(1 / dbo.fTasa_Cambio(@Empresa, @MonedaBase, @Moneda, c.comp_fecha), 1) ELSE 0.00 END) Credito
		
		--SUM(CASE WHEN cd.CDet_DC = 'D' THEN cd.CDet_Importe * ISNULL(1 / CASE WHEN @MonedaBase = @Moneda THEN 1 
		--																	ELSE CASE WHEN c.Comp_TasaCambio <> 1 THEN c.Comp_TasaCambio 
		--																			ELSE dbo.fTasa_Cambio(@Empresa, @MonedaBase, @Moneda, c.comp_fecha) 
		--																		 END 
		--																  END , 1) ELSE 0.00 END) Debito,
																		  
		--SUM(CASE WHEN cd.CDet_DC = 'C' THEN cd.CDet_Importe * ISNULL(1 / CASE WHEN @MonedaBase = @Moneda THEN 1 
		--																	ELSE CASE WHEN c.Comp_TasaCambio <> 1 THEN c.Comp_TasaCambio 
		--																			ELSE dbo.fTasa_Cambio(@Empresa, @MonedaBase, @Moneda, c.comp_fecha) 
		--																		 END 
		--																  END, 1) ELSE 0.00 END) Credito

FROM Comprobantes AS c INNER JOIN ComprobantesDetalles AS cd
ON c.Comp_No = cd.Comp_No
AND c.Per_Id = cd.Per_Id
AND c.Mes = cd.Mes
AND c.Empresa = cd.Empresa
INNER JOIN CATALOGO AS ca ON cd.CDet_Cuenta = ca.CUENTA
AND ca.EMPRESA = cd.Empresa

WHERE c.Comp_Fecha < = @Hasta
AND c.Empresa = @Empresa
AND ca.BALRES = 'B'
AND c.Comp_Tipo <> ISNULL(@Comp_Cierre,0)
--AND CASE WHEN @MonedaBase = @Moneda THEN CAST(1 AS BIT)
--	ELSE CASE WHEN c.Comp_tipo <> @TC_MttoValor THEN CAST(1 AS BIT)
--			ELSE CAST(0 AS BIT) 
--         END
--	END = CAST(1 AS BIT)

GROUP BY	ca.CUENTA, 
			ca.NOMBRE, 
			ca.SUBCUENTA,
			ca.CLASE,
			ca.BALRES
						
UNION ALL		

/*******************************************
 * Aplicando la Recursividad
 *******************************************/	
 
 SELECT ca.CUENTA, 
		ca.NOMBRE, 
		ca.SUBCUENTA,
		ca.CLASE,
		ca.BALRES,
		c.Debito,
		c.Credito
		 
 FROM CATALOGO AS ca 
 INNER JOIN CTE AS c ON ca.CUENTA = c.SUBCUENTA
 
 WHERE ca.EMPRESA = @Empresa
 
 )

SELECT
	c.CUENTA,
	c.NOMBRE,
	c.SUBCUENTA,
	c.CLASE,
	c.BALRES,
	SUM(c.DEBITO) DEBITO,
	SUM(c.CREDITO) CREDITO,	
	ROUND(SUM(c.CREDITO - c.DEBITO),2) SALDO		
	---ROUND(SUM(CASE WHEN c.CLASE = 1 THEN c.DEBITO - c.CREDITO ELSE c.CREDITO - c.DEBITO END),2) SALDO
INTO #SALDOS
FROM
	CTE AS c 
GROUP BY	c.CUENTA,
			c.NOMBRE,
			c.SUBCUENTA,
			c.CLASE,
			c.BALRES
ORDER BY c.CUENTA;

--SELECT * FROM #SALDOS s
--EXEC JAR_BalanceGeneralPasivo '31/01/2015','01','P',7

/*******************************************
 * Sumar las formulas que son 
 * cuentas contables
 *******************************************/
SELECT	gbr.IdGrupo, 
		gbr.Codigo,
		gbr.Nombre,
		
		CASE WHEN LEN(gbr.Cuenta) > 0 THEN 
			CASE WHEN gbr.Columna = 1 THEN 	
				ISNULL((SELECT SUM(SALDO) Saldo
					FROM #SALDOS s
				WHERE s.Cuenta IN (SELECT s.[Data] FROM dbo.[Split](gbr.Cuenta,',') AS s)),0.00)
			ELSE NULL END 
		ELSE NULL END Columna1,
		
		CASE WHEN LEN(gbr.Cuenta) > 0 THEN 
			CASE WHEN gbr.Columna = 2 THEN 	
				ISNULL((SELECT SUM(SALDO) Saldo
					FROM #SALDOS s
				WHERE s.Cuenta IN (SELECT s.[Data] FROM dbo.[Split](gbr.Cuenta,',') AS s)),0.00)
			ELSE NULL END 
		ELSE NULL END Columna2,
		
		CASE WHEN LEN(gbr.Cuenta) > 0 THEN 
			CASE WHEN gbr.Columna = 3 THEN 	
				ISNULL((SELECT SUM(SALDO) Saldo
					FROM #SALDOS s
				WHERE s.Cuenta IN (SELECT s.[Data] FROM dbo.[Split](gbr.Cuenta,',') AS s)),0.00)
			ELSE NULL END 
		ELSE NULL END Columna3,
		
		CASE WHEN LEN(gbr.Cuenta) > 0 THEN 
			CASE WHEN gbr.Columna = 4 THEN 	
				ISNULL((SELECT SUM(SALDO) Saldo
					FROM #SALDOS s
				WHERE s.Cuenta IN (SELECT s.[Data] FROM dbo.[Split](gbr.Cuenta,',') AS s)),0.00)
			ELSE NULL END 
		ELSE NULL END Columna4,
		
		gbr.Columna,
		gbr.Nivel,
		gbr.Formula,
		gbr.Tipo, 
		gbr.Tipo_Grupo, 
		gbr.Titulo, 
		gbr.SubTitulo, 
		gbr.Negrita,
		gbr.Utilidad_Mes, 
		gbr.Utilidad_Acumulado

INTO #CUENTAS					 
FROM GruposBalRes AS gbr

WHERE gbr.Tipo = 'B'
AND gbr.Tipo_Grupo = @Tipo
AND gbr.Empresa = @Empresa

ORDER BY gbr.Codigo;

/*******************************************
 * Calular Utilidad Acumulada y Utilidad del 
 * Periodo
 *******************************************/
 
 DECLARE @FAbiertos SMALLDATETIME,
		@FechaInicio SMALLDATETIME,
		@Utilidad_Mes NUMERIC(18,4),
		@Utilidad_Acumulada NUMERIC(18,4),
		@Utilidad_Saldo NUMERIC(18,4),
		@Cuenta_Utilidad NVARCHAR(50),
		@NombreAcumulada NVARCHAR(512),
		@Cuenta_Utilidad_Periodo NVARCHAR(50),
		@NombrePeriodo NVARCHAR(512),
		@UtilidadCorriente NUMERIC(18,4)
		
/*******************************************
 *La fecha de Inicio del periodo 
 *que incluye la fecha DESDE 
 *******************************************/
  SELECT  @FAbiertos = per_inicio
  FROM    Periodos
  WHERE   empresa = @empresa
          AND @Hasta BETWEEN per_inicio AND per_final	
          
SELECT @Cuenta_Utilidad = c.CUENTA, @NombreAcumulada = c.NOMBRE
FROM CATALOGO AS c
WHERE c.EMPRESA = @Empresa
AND c.UtilidadAcumulada = 1;          

SELECT @Cuenta_Utilidad_Periodo = c.CUENTA, @NombrePeriodo = c.NOMBRE
FROM CATALOGO AS c
WHERE c.EMPRESA = @Empresa
AND c.UtilidadPerdida = 1;   

SELECT @FechaInicio = dbo.FormatFecha('1/' + dbo.padl(MONTH(@Hasta),2,'0') + '/' + dbo.padl(YEAR(@Hasta),4,'0')) 

/*******************************************
 * Calculando Utilidad Acumulada
 *******************************************/
SELECT @Utilidad_Saldo = ISNULL(SUM(s.SALDO),0.00)
FROM #SALDOS s
WHERE s.CUENTA = @Cuenta_Utilidad

--SELECT @Utilidad_Acumulada = ISNULL(SUM((vcdc.Creditos * ISNULL(1 / CASE WHEN @MonedaBase = @Moneda THEN 1 
--																			ELSE CASE WHEN vcdc.Comp_TasaCambio <> 1 THEN vcdc.Comp_TasaCambio 
--																					ELSE dbo.fTasa_Cambio(@Empresa, @MonedaBase, @Moneda, vcdc.comp_fecha) 
--																				 END 
--																		  END, 1)) - 
--										(vcdc.Debitos * ISNULL(1 / CASE WHEN @MonedaBase = @Moneda THEN 1 
--																			ELSE CASE WHEN vcdc.Comp_TasaCambio <> 1 THEN vcdc.Comp_TasaCambio 
--																					ELSE dbo.fTasa_Cambio(@Empresa, @MonedaBase, @Moneda, vcdc.comp_fecha) 
--																				 END 
--																		  END, 1))),0.00)																		  
SELECT @Utilidad_Acumulada = ISNULL(SUM(vcdc.Creditos - vcdc.Debitos),0.00)																				  
FROM vComprobantes_DebitosCreditos AS vcdc
WHERE vcdc.Empresa = @Empresa
AND vcdc.BALRES = 'R'
AND vcdc.Comp_fecha < @FAbiertos 
--AND CASE WHEN @MonedaBase = @Moneda THEN CAST(1 AS BIT)
--	ELSE CASE WHEN vcdc.Comp_tipo <> @TC_MttoValor THEN CAST(1 AS BIT)
--			ELSE CAST(0 AS BIT) 
--         END
--	END = CAST(1 AS BIT);

SELECT @Utilidad_Acumulada = @Utilidad_Saldo + @Utilidad_Acumulada

--SET DATEFORMAT dmy;
--EXEC JAR_BalanceGeneralPasivo '31/01/2015','01','P',7
          
/*******************************************
 * Calculando Utilidad del Periodo
 *******************************************/
--SELECT @Utilidad_Mes = ISNULL(SUM((vcdc.Creditos * ISNULL(1 / CASE WHEN @MonedaBase = @Moneda THEN 1 
--																			ELSE CASE WHEN vcdc.Comp_TasaCambio <> 1 THEN vcdc.Comp_TasaCambio 
--																					ELSE dbo.fTasa_Cambio(@Empresa, @MonedaBase, @Moneda, vcdc.comp_fecha) 
--																				 END 
--																		  END, 1)) - 
--										(vcdc.Debitos * ISNULL(1 / CASE WHEN @MonedaBase = @Moneda THEN 1 
--																			ELSE CASE WHEN vcdc.Comp_TasaCambio <> 1 THEN vcdc.Comp_TasaCambio 
--																					ELSE dbo.fTasa_Cambio(@Empresa, @MonedaBase, @Moneda, vcdc.comp_fecha) 
--																				 END 
--																		  END, 1))),0.00)

SELECT @Utilidad_Mes = ISNULL(SUM(vcdc.Creditos - vcdc.Debitos),0.00)																		  
FROM vComprobantes_DebitosCreditos AS vcdc
WHERE vcdc.Empresa = @Empresa
AND vcdc.BALRES = 'R'
AND vcdc.Comp_fecha BETWEEN @FAbiertos AND @Hasta 
--AND CASE WHEN @MonedaBase = @Moneda THEN CAST(1 AS BIT)
--	ELSE CASE WHEN vcdc.Comp_tipo <> @TC_MttoValor THEN CAST(1 AS BIT)
--			ELSE CAST(0 AS BIT) 
--         END
--	END = CAST(1 AS BIT);   

SELECT @Utilidad_Saldo = ISNULL(SUM(s.SALDO),0.00)
FROM #SALDOS s
WHERE s.CUENTA = @Cuenta_Utilidad_Periodo
	
SELECT @Utilidad_Mes = @Utilidad_Mes + @Utilidad_Saldo;

/*******************************************
 * Calculando Utilidad del Mes Actual
 *******************************************/
--SELECT @UtilidadCorriente = ISNULL(SUM((vcdc.Creditos * ISNULL(1 / CASE WHEN @MonedaBase = @Moneda THEN 1 
--																			ELSE CASE WHEN vcdc.Comp_TasaCambio <> 1 THEN vcdc.Comp_TasaCambio 
--																					ELSE dbo.fTasa_Cambio(@Empresa, @MonedaBase, @Moneda, vcdc.comp_fecha) 
--																				 END 
--																		  END, 1)) - 
--										(vcdc.Debitos * ISNULL(1 / CASE WHEN @MonedaBase = @Moneda THEN 1 
--																			ELSE CASE WHEN vcdc.Comp_TasaCambio <> 1 THEN vcdc.Comp_TasaCambio 
--																					ELSE dbo.fTasa_Cambio(@Empresa, @MonedaBase, @Moneda, vcdc.comp_fecha) 
--																				 END 
--																		  END, 1))),0.00)

SELECT @UtilidadCorriente = ISNULL(SUM(vcdc.Creditos - vcdc.Debitos),0.00)							
FROM vComprobantes_DebitosCreditos AS vcdc
WHERE vcdc.Empresa = @Empresa
AND vcdc.BALRES = 'R'
AND vcdc.Comp_fecha BETWEEN @FechaInicio AND @Hasta
--AND CASE WHEN @MonedaBase = @Moneda THEN CAST(1 AS BIT)
--	ELSE CASE WHEN vcdc.Comp_tipo <> @TC_MttoValor THEN CAST(1 AS BIT)
--			ELSE CAST(0 AS BIT) 
--         END
--	END = CAST(1 AS BIT);

SELECT @UtilidadCorriente = @UtilidadCorriente + @Utilidad_Saldo;

UPDATE #CUENTAS SET  Columna2 = @Utilidad_Mes
WHERE Utilidad_Mes = 1;    	

UPDATE #CUENTAS SET  Columna2 = @Utilidad_Acumulada
WHERE Utilidad_Acumulado = 1; 

/*******************************************
 * Guardar la Utilidad para no volver 
 * a calcular
 *******************************************/

TRUNCATE TABLE UTILIDAD_EEFF;

INSERT INTO UTILIDAD_EEFF (	Cuenta,	Nombre, TotalMes, TotalAcumulado )
SELECT @Cuenta_Utilidad, @NombreAcumulada, 0.00, @Utilidad_Acumulada
UNION ALL
SELECT @Cuenta_Utilidad_Periodo, @NombrePeriodo, @UtilidadCorriente, @Utilidad_Mes
 
 --/****************************************************************
-- * Actualizando valores para los Totales de las cuentas de Mayor
-- * Cursor que se encarga de sumar, restar, multiplicar, 
-- * todas las formulas de tipo Sub Titulo
-- ***************************************************************/		
IF (SELECT COUNT(*) 
FROM #CUENTAS c 
WHERE LEN(c.Formula) > 0
AND (c.Columna1 IS NULL
OR c.Columna2 IS NULL
OR c.Columna3 IS NULL
OR c.Columna4 IS NULL) ) > 0
--AND er.SubTitulo = 1
BEGIN

REPETIR:	--Si se quedo alguna formula sin valor, volver a revisar

	DECLARE	@IdGrupo INT, 
			@Formula NVARCHAR(256)
			
	DECLARE CURSOR_FORMULAS CURSOR FOR
	
	SELECT	c.IdGrupo, 
			c.Formula
			
	FROM #CUENTAS c 
	WHERE LEN(c.Formula) > 0
	AND c.Columna1 IS NULL
	AND c.Columna2 IS NULL
	AND c.Columna3 IS NULL
	AND c.Columna4 IS NULL
	
	OPEN CURSOR_FORMULAS
	FETCH CURSOR_FORMULAS INTO @IdGrupo, @Formula;
	
	WHILE (@@FETCH_STATUS = 0)
	BEGIN
		
		UPDATE #CUENTAS SET Columna1 =		CASE WHEN Columna = 1 THEN ISNULL((SELECT SUM(ISNULL(CASE	WHEN g.Columna = 1 THEN g.Columna1 
																									WHEN g.Columna = 2 THEN g.Columna2
																									WHEN g.Columna = 3 THEN g.Columna3
																									WHEN g.Columna = 4 THEN g.Columna4 END ,0.00)) FROM #CUENTAS AS g
																			WHERE g.IdGrupo IN (SELECT s.[Data] FROM dbo.[Split](@Formula,',') AS s)),0.00)
											ELSE NULL END,
										
							Columna2 =		CASE WHEN Columna = 2 THEN ISNULL((SELECT SUM(ISNULL(CASE	WHEN g.Columna = 1 THEN g.Columna1 
																									WHEN g.Columna = 2 THEN g.Columna2
																									WHEN g.Columna = 3 THEN g.Columna3
																									WHEN g.Columna = 4 THEN g.Columna4 END ,0.00)) FROM #CUENTAS AS g
																			WHERE g.IdGrupo IN (SELECT s.[Data] FROM dbo.[Split](@Formula,',') AS s)),0.00)
											ELSE NULL END,
											
							Columna3 =		CASE WHEN Columna = 3 THEN ISNULL((SELECT SUM(ISNULL(CASE	WHEN g.Columna = 1 THEN g.Columna1 
																									WHEN g.Columna = 2 THEN g.Columna2
																									WHEN g.Columna = 3 THEN g.Columna3
																									WHEN g.Columna = 4 THEN g.Columna4 END ,0.00)) FROM #CUENTAS AS g
																			WHERE g.IdGrupo IN (SELECT s.[Data] FROM dbo.[Split](@Formula,',') AS s)),0.00)
											ELSE NULL END,
											
							Columna4 =		CASE WHEN Columna = 4 THEN ISNULL((SELECT SUM(ISNULL(CASE	WHEN g.Columna = 1 THEN g.Columna1 
																									WHEN g.Columna = 2 THEN g.Columna2
																									WHEN g.Columna = 3 THEN g.Columna3
																									WHEN g.Columna = 4 THEN g.Columna4 END ,0.00)) FROM #CUENTAS AS g
																			WHERE g.IdGrupo IN (SELECT s.[Data] FROM dbo.[Split](@Formula,',') AS s)),0.00)
											ELSE NULL END
		
		WHERE IdGrupo = @IdGrupo;
		
		FETCH CURSOR_FORMULAS INTO @IdGrupo, @Formula;	
	END;
	
	CLOSE CURSOR_FORMULAS;
	DEALLOCATE CURSOR_FORMULAS;
	
END;

	IF (SELECT COUNT(*) 
	FROM #CUENTAS c 
	WHERE LEN(c.Formula) > 0
	AND c.Columna1 IS NULL
	AND c.Columna2 IS NULL	
	AND c.Columna3 IS NULL
	AND c.Columna4 IS NULL) > 0
		GOTO REPETIR;	  
		
/*******************************************
 * Verificar Moneda de impresion
 *******************************************/
IF @MonedaBase <> @Moneda	--Hacer Conversion de Moneda
BEGIN
	DECLARE @TCambio NUMERIC(18,4)
	
	SELECT @TCambio = ISNULL(dbo.fTasa_Cambio(@Empresa, @MonedaBase, @Moneda, @Hasta),1.00)
	
	UPDATE #CUENTAS SET Columna1 = ( Columna1 / @TCambio )
	FROM #CUENTAS c WHERE NOT c.Columna1 IS NULL
	
	UPDATE #CUENTAS SET Columna2 = ( Columna2 / @TCambio )
	FROM #CUENTAS c WHERE NOT c.Columna2 IS NULL

	UPDATE #CUENTAS SET Columna3 = ( Columna3 / @TCambio )
	FROM #CUENTAS c WHERE NOT c.Columna3 IS NULL
	
	UPDATE #CUENTAS SET Columna4 = ( Columna4 / @TCambio )
	FROM #CUENTAS c WHERE NOT c.Columna4 IS NULL	
	
	UPDATE UTILIDAD_EEFF SET	TotalMes =  ( TotalMes / @TCambio ),
								TotalAcumulado = ( TotalAcumulado / @TCambio );		  
END	
		
/*******************************************
 * Consulta Principal
 *******************************************/		
SELECT	c.Nombre,
		ROUND(c.Columna1,2) Columna1,
		ROUND(c.Columna2,2) Columna2,
		ROUND(c.Columna3,2) Columna3,
		ROUND(c.Columna4,2) Columna4,
		c.Nivel,
		c.Titulo, 
		c.SubTitulo,
		c.Negrita							 
FROM #CUENTAS c
ORDER BY c.Codigo;
				
DROP TABLE #SALDOS;
DROP TABLE #CUENTAS;

GO



















