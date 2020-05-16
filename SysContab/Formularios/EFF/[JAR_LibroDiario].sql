CREATE PROCEDURE [dbo].[JAR_LibroDiario]
	@empresa NVARCHAR(50),
	@desde smalldatetime,
	@hasta smalldatetime,
	@moneda NVARCHAR(5)
as

set dateformat dmy;

--[JAR_LibroDiario] 1,'01/01/2015','31/01/2015','01'

DECLARE @MonedaBase NVARCHAR(5),
		@MonedaN NVARCHAR(50)

SELECT @MonedaBase = e.emp_monedabase
FROM EMPRESAS AS e WHERE e.CODIGO = 1

SELECT @MonedaN = m.mon_simbolo + ' - ' + m.mon_descripcion 
FROM Monedas AS m 
WHERE m.empr_codigo = 1 
AND m.mon_codigo = @MonedaBase


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
	cuenta nvarchar(100)
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
	cuenta
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
	concepto nvarchar(400),
	cuenta nvarchar(100),
	valor numeric(18,2),
	DC nvarchar(1)
)

Insert into @Comprobantes
Select c.Empresa as empresa, c.Per_Id, c.Mes, c.Comp_No, c.Comp_Fecha, c.Comp_Concepto,
cd.CDet_Cuenta as Cuenta, isnull(cd.CDet_Importe,0) as Valor, cd.CDet_DC as DC
from comprobantes c inner join ComprobantesDetalles cd on 
	c.Empresa = cd.Empresa and
	c.Per_Id = cd.Per_Id and
	c.Mes = cd.Mes and
	c.Comp_No = cd.Comp_No inner join EMPRESAS e on 
		c.Empresa = e.CODIGO 
where c.Empresa = case when @empresa = 0 then c.Empresa else @empresa end and
c.Comp_Fecha between @desde and @hasta 



--if @formatoarbol = 1 

--	select a.empresa, a.cuenta, a.padre, a.nombre, 
--	isnull(c.periodo,0) as periodo, isnull(c.mes, 0) as mes, 
--	isnull(c.id, 0) as id, isnull(c.fecha, @hasta) as fecha, 
--	isnull(c.concepto, ' ') as concepto, isnull(c.valor,0) as valor, 
--	isnull(c.DC, ' ') as DC
--	from @Arbol a left outer join @Comprobantes c on 
--		a.empresa = c.empresa and
--		a.cuenta = c.cuenta
--else
--begin 
--select * from (

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
	DC nvarchar(1) NULL,
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
	nsc09 nvarchar(100) NOT NULL
	)  


insert into @tbl
select c.empresa, periodo, mes, id, fecha, concepto, c.cuenta, valor, DC , 
	case when c.DC = 'D' then c.valor else 0 end as debe,
	case when c.DC = 'C' then c.valor else 0 end as haber,
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
		isnull((select cat.nombre from catalogo as cat where cat.empresa = cc.empresa and cat.CUENTA = cc.sc09),' ') as nsc09
	from @Comprobantes c inner join @Cat cc on 
	c.empresa = cc.empresa and
	c.cuenta = cc.cuenta 
	
select 

--ROW_NUMBER () over ( partition by fecha, id  order by fecha, id, mayor, sc01, sc02 ) O,
	--empresa ,
	--periodo ,
	--mes ,
	--id ,
	--fecha ,
	@desde Desde,
	@hasta Hasta,
	@MonedaN Moneda,
--	concepto ,
	cuenta ,
	--sum(valor) valor ,
	--DC ,
	sum(debe) debe ,
	sum(haber) haber ,
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
GROUP BY 
		--empresa ,
		--periodo ,
		--mes ,
		--id ,
		--fecha ,		
	--	concepto ,
		cuenta ,
		--DC ,
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
	--order by fecha, id, mayor, sc01, sc02
order BY cuenta ---fecha, id, DC desc, mayor, sc01, sc02, sc03, cuenta


--[JAR_LibroDiario] 1,'01/01/2015','31/01/2015','01'

GO
