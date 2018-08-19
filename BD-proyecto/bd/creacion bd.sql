create database UPNELi
go

use UPNELI
go

create table codigo_alumno(
id_alumno int identity(1,1)PRIMARY KEY,
codigo_alumno varchar(255),
nombre_cliente nvarchar(255),
dni nvarchar(255),
tel nvarchar(255),
cel nvarchar(255),
email nvarchar(255),
fecha_registro nvarchar(255)
)


select * from codigo_alumno

insert into apoderado (apoderado_nombre,tel_apoderado,cel_apoderado,email_apoderado) values(''	,	''	,	''	,	'')

create table apoderado(
id_apo int identity primary key,
apoderado_nombre nvarchar(255),
tel_apoderado nvarchar(255),
cel_apoderado nvarchar(255),
email_apoderado nvarchar(255),
id_alumno int foreign key (id_alumno)references codigo_alumno(id_alumno)
)


create table tipificaciones (
id_tificacione int identity(1,1) primary key,
contactabilidad nvarchar(255),
tipo_contacto nvarchar(255),
respuesta_cliente nvarchar(255),
motivo_cliente nvarchar(255),
accion nvarchar(255),
motivo_desercion nvarchar(255),
carta_noadeduo nvarchar(255),
recategorizacion nvarchar(255),
incidencia nvarchar(255),
incidencias nvarchar(255),
solicitud_facilidad nvarchar(255),
tipo_facilidad nvarchar(255),
observciones nvarchar(max),
id_alumno int foreign key (id_alumno)references codigo_alumno(id_alumno)
)

select * from tipificaciones

insert into apoderado9 (apoderado_nombre,tel_apoderado,cel_apoderado,email_apoderado,id_alumno) values(''	,	''	,	''	,	'',1)
insert into apoderado9 (apoderado_nombre,tel_apoderado,cel_apoderado,email_apoderado,id_alumno) values(''	,	''	,	''	,	'',2)
insert into apoderado9 (apoderado_nombre,tel_apoderado,cel_apoderado,email_apoderado,id_alumno) values(''	,	''	,	''	,	'',3)
insert into apoderado9 (apoderado_nombre,tel_apoderado,cel_apoderado,email_apoderado,id_alumno) values(''	,	''	,	''	,	'',4)



--esto es para visualizar en el data griview

select c.codigo_alumno as [Codigo Alumno],c.nombre_cliente as [Nombre Alumno],
a.apoderado_nombre as [Nombre del Apoderado],a.tel_apoderado as [Telefono Apoderado],
a.cel_apoderado as [Celular Apoderado],a.email_apoderado as [Correo Apoderado],
t.contactabilidad as [Contactabilidad],t.tipo_contacto as [Tipo de Contacto],
t.respuesta_cliente as [Respuesta del Cliente],t.motivo_cliente as [Motivo del Cliente],
t.accion as [Accion],t.motivo_desercion as [Motivo de Desercion],
t.carta_noadeduo as [Carta de no Adeudo],
t.recategorizacion as [Recategorización],t.incidencia as [Incidencias],
t.solicitud_facilidad as [Solicitud de Facilidad],t.tipo_facilidad as [Tipo de Facilidad],
t.observciones as [Observaciones] 
from codigo_alumno c
inner join apoderado a on c.id_alumno=a.id_apo
inner join tipificaciones t on c.id_alumno=t.id_alumno
order by nombre_cliente

 
--procedimiento almacenado para filtrar por nombre
select c.codigo_alumno as [Codigo Alumno],c.nombre_cliente as [Nombre Alumno],
a.apoderado_nombre as [Nombre del Apoderado],a.tel_apoderado as [Telefono Apoderado],
a.cel_apoderado as [Celular Apoderado],a.email_apoderado as [Correo Apoderado],
t.contactabilidad as [Contactabilidad],t.tipo_contacto as [Tipo de Contacto],
t.respuesta_cliente as [Respuesta del Cliente],t.motivo_cliente as [Motivo del Cliente],
t.accion as [Accion],t.motivo_desercion as [Motivo de Desercion],
t.carta_noadeduo as [Carta de no Adeudo],
t.recategorizacion as [Recategorización],t.incidencia as [Incidencias],
t.solicitud_facilidad as [Solicitud de Facilidad],t.tipo_facilidad as [Tipo de Facilidad],
t.observciones as [Observaciones] 
from codigo_alumno c
inner join apoderado a on c.id_alumno=a.id_apo
inner join tipificaciones t on c.id_alumno=t.id_alumno
where nombre_cliente like'%lisset%'
order by nombre_cliente






select * from codigo_alumno

select c.codigo_alumno,c.nombre_cliente,a.apoderado_nombre,a.tel_apoderado, t.contactabilidad,t.tipo_contacto,t.respuesta_cliente,t.motivo_cliente,t.accion,t.motivo_desercion,t.carta_noadeduo,t.recategorizacion,t.incidencia,t.solicitud_facilidad,t.tipo_facilidad,t.observciones from codigo_alumno c join apoderado a join tipificaciones t 
on c.id_alumno=a.id_alumno on c.id_alumno=t.id_alumno


CREATE PROCEDURE sp_insertar
@codigo_alumno nvarchar(255),
@nombre_cliente nvarchar(255),
@dni nvarchar(255),
@tel nvarchar(255),
@cel nvarchar(255),
@email nvarchar(255),
@fecha_registro nvarchar(255)

AS
BEGIN
	insert into codigo_alumno(codigo_alumno,nombre_cliente,dni,tel,cel,email,fecha_registro) values(@codigo_alumno,@nombre_cliente,@dni,@tel,@cel,@email,@fecha_registro)
END
GO

--procedimiento para filtrar

create procedure sp_buscar2
@nombre nvarchar(2255)
as
select c.codigo_alumno as [Codigo Alumno],c.nombre_cliente as [Nombre Alumno],
a.apoderado_nombre as [Nombre del Apoderado],a.tel_apoderado as [Telefono Apoderado],
a.cel_apoderado as [Celular Apoderado],a.email_apoderado as [Correo Apoderado],
t.contactabilidad as [Contactabilidad],t.tipo_contacto as [Tipo de Contacto],
t.respuesta_cliente as [Respuesta del Cliente],t.motivo_cliente as [Motivo del Cliente],
t.accion as [Accion],t.motivo_desercion as [Motivo de Desercion],
t.carta_noadeduo as [Carta de no Adeudo],
t.recategorizacion as [Recategorización],t.incidencia as [Incidencias],
t.solicitud_facilidad as [Solicitud de Facilidad],t.tipo_facilidad as [Tipo de Facilidad],
t.observciones as [Observaciones] 
from codigo_alumno c
inner join apoderado a on c.id_alumno=a.id_apo
inner join tipificaciones t on c.id_alumno=t.id_alumno
where   c.nombre_cliente like @nombre + '%'
order by nombre_cliente
go

--falta el procedimineto para actualizar y al momento de aztualizar la fecha tambien actualizar


