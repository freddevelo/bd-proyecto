Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtobservacion_TextChanged(sender As Object, e As EventArgs) Handles txtobservacion.TextChanged

    End Sub
End Class


'en la fecha actualizar tambien

'en los combobox esto serian los nombres
''cbocontactabilidad.Items.Add()
'cbocontactabilidad.Items.Add("--Contactabilidad--")
'cbocontactabilidad.Items.Add("contactado")
'cbocontactabilidad.Items.Add("no contactado")
'cbocontactabilidad.Items.Add("sin gestion")
'cbocontactabilidad.SelectedIndex = 0

'tipo contacto
'cbotippocontacto.Items.Add("--Tipo de contacto--")
'cbotippocontacto.Items.Add("Se convérso con titular")
'cbotippocontacto.Items.Add("Se converso con terceros")
'cbotippocontacto.Items.Add("Telefono Ocupado")
'cbotippocontacto.Items.Add("Telefono no existe")
'cbotippocontacto.Items.Add("Telefono no corresponde")
'cbotippocontacto.Items.Add("Empresa no existe")
'cbotippocontacto.Items.Add("No lo conocen")
'cbotippocontacto.Items.Add("Cuelgan")
'cbotippocontacto.Items.Add("No contestan")
'cbotippocontacto.Items.Add("Sin dato")
'cbotippocontacto.Items.Add("Casilla de voz ")
'cbotippocontacto.SelectedIndex = 0

'Respuesta cliente
'cborespuestacliente.Items.Add("--Respuesta del Cliente--")
'cborespuestacliente.Items.Add("Compromiso de pago")
'cborespuestacliente.Items.Add("En negociacion")
'cborespuestacliente.Items.Add("No le interesa")
'cborespuestacliente.Items.Add("Consulta")
'cborespuestacliente.Items.Add("Sin intencion de pago")
'cborespuestacliente.Items.Add("Reclamos")
'cborespuestacliente.Items.Add("Indica que ya pagó")
'cborespuestacliente.Items.Add("No lo conocen")
'cborespuestacliente.Items.Add("Se envió correo")
'cborespuestacliente.Items.Add("Se encuentra de viaje")
'cborespuestacliente.Items.Add("Volver a llamar")
'cborespuestacliente.Items.Add("Ya pagó")
'cborespuestacliente.Items.Add("Se envió carta")
'cborespuestacliente.Items.Add("Contestan y apagan el telefono")
'cborespuestacliente.Items.Add("Sin dato")
'cborespuestacliente.Items.Add("Otros")
'cborespuestacliente.Items.Add("No quisieron comunicar")
'cborespuestacliente.Items.Add("Titular fallecido")
'cborespuestacliente.Items.Add("No contestan")
'cborespuestacliente.Items.Add("Empresa no existe")
'cborespuestacliente.Items.Add("Nunca vivió en el domicilio")
'cborespuestacliente.Items.Add("Se mudó")
'cborespuestacliente.Items.Add("Facilidad incumplida")
'cborespuestacliente.SelectedIndex = 0

'Motivo Cliente
'cbomotivocliente.Items.Add("--Motivo Cliente--")
'cbomotivocliente.Items.Add("Volver a llamar")
'cbomotivocliente.Items.Add("Solicito envió de correo")
'cbomotivocliente.Items.Add("Rebaja/plazos/exoneeracion")
'cbomotivocliente.Items.Add("No indica motivos")
'cbomotivocliente.Items.Add("Indica que ya pagó")
'cbomotivocliente.Items.Add("Pago con facilidad de pago")
'cbomotivocliente.Items.Add("Ya pagó")
'cbomotivocliente.Items.Add("Que no generó matricula")
'cbomotivocliente.Items.Add("Que presento carta de retiro")
'cbomotivocliente.Items.Add("Otros")
'cbomotivocliente.Items.Add("Se encuentra en otra Universidad")
'cbomotivocliente.Items.Add("Indica mala experiencia")
'cbomotivocliente.Items.Add("No cuentan con recursos")
'cbomotivocliente.Items.Add("Presento reclamo formal")
'cbomotivocliente.Items.Add("Cancelado con NC")
'cbomotivocliente.Items.Add("Argumenta problemas de salud")
'cbomotivocliente.Items.Add("Deuda castigada")
'cbomotivocliente.Items.Add("Se recuerda castigo/UPC no tiene documentos")
'cborespuestacliente.Items.Add("UPC indico no gestionar")
'cbomotivocliente.Items.Add("UPN indico no gestionar")
'cbomotivocliente.SelectedIndex = 0

'accion
'cboaccion.Items.Add("--Acción")
'cboaccion.Items.Add("Volver a llamar")
'cboaccion.Items.Add("No llamar")
'cboaccion.Items.Add("Buscar dato")
'cboaccion.Items.Add("Enviar carta")
'cboaccion.SelectedIndex = 0

'motivo de desercion
'cbomotivodesercion.Items.Add("--Motivos de Deserción")
'cbomotivodesercion.Items.Add("Económicos")
'cbomotivodesercion.Items.Add("Disconformidad")
'cbomotivodesercion.Items.Add("Problemas académicos")
'cbomotivodesercion.Items.Add("Viaje")
'cbomotivodesercion.Items.Add("Trabajo")
'cbomotivodesercion.Items.Add("Otros")
'cbomotivodesercion.SelectedIndex = 0

'carta no adeudo
'cbocartanoadeudo.Items.Add("--Carta de no Adeudo")
'cbocartanoadeudo.Items.Add("Si")
'cbocartanoadeudo.Items.Add("No")
'cbocartanoadeudo.SelectedIndex = 0

'recateorrizacion
'cborecategorizacion.Items.Add("--Recategorización--")
'cborecategorizacion.Items.Add("Si")
'cborecategorizacion.Items.Add("No")
'cborecategorizacion.SelectedIndex = 0

'incidencias
'cboincidencias.Items.Add("--Incidencias--")
'cboincidencias.Items.Add("Alumno indica ya cancelo")
'cboincidencias.Items.Add("Alumno indica reclamo")
'cboincidencias.Items.Add("Alumno indica se retiró")
'cboincidencias.Items.Add("Alumno envía voucher de pago")
'cboincidencias.Items.Add("Indica nunca estudió en la UPN")
'cboincidencias.Items.Add("Indecopi")
'cboincidencias.SelectedIndex = 0

'Solicitud de FACILIDAD
'cbosolictudfacilidad.Items.Add("--Solicitud de Facilidad--")
'cbosolictudfacilidad.Items.Add("Facilidad de pago")
'cbosolictudfacilidad.Items.Add("Pago total")
'cbosolictudfacilidad.SelectedIndex = 0

'Tipo de FACILIDAD
'cbotipofacilidad.Items.Add("--Tipo de Facilidad--")
'cbotipofacilidad.Items.Add("Cuotas")
'cbotipofacilidad.Items.Add("Exoneracion de mora")
'cbotipofacilidad.Items.Add("Boletas")
'cbotipofacilidad.SelectedIndex = 0

'este es para que muestre los datos a vizualizar en el datagriview
'"select c.codigo_alumno as [Codigo Alumno],c.nombre_cliente as [Nombre Alumno],a.apoderado_nombre as [Nombre del Apoderado],a.tel_apoderado as [Telefono Apoderado],a.cel_apoderado as [Celular Apoderado],a.email_apoderado as [Correo Apoderado],t.contactabilidad as [Contactabilidad],t.tipo_contacto as [Tipo de Contacto],t.respuesta_cliente as [Respuesta del Cliente],t.motivo_cliente as [Motivo del Cliente],t.accion as [Accion],t.motivo_desercion as [Motivo de Desercion],t.carta_noadeduo as [Carta de no Adeudo],t.recategorizacion as [Recategorización],t.incidencia as [Incidencias],t.solicitud_facilidad as [Solicitud de Facilidad],t.tipo_facilidad as [Tipo de Facilidad],t.observciones as [Observaciones] from codigo_alumno c inner join apoderado a on c.id_alumno=a.id_apo inner join tipificaciones t on c.id_alumno=t.id_alumno order by nombre_cliente"

'este es el procedimiento almacenado de la busqueda o filtro por nombre
'Select Case c.codigo_alumno As [Codigo Alumno],c.nombre_cliente As [Nombre Alumno],
'a.apoderado_nombre as [Nombre del Apoderado], a.tel_apoderado As [Telefono Apoderado],
'a.cel_apoderado as [Celular Apoderado], a.email_apoderado As [Correo Apoderado],
't.contactabilidad as [Contactabilidad], t.tipo_contacto As [Tipo de Contacto],
't.respuesta_cliente as [Respuesta del Cliente], t.motivo_cliente As [Motivo del Cliente],
't.accion as [Accion], t.motivo_desercion As [Motivo de Desercion],
't.carta_noadeduo as [Carta de no Adeudo],
't.recategorizacion As [Recategorización], t.incidencia As [Incidencias],
't.solicitud_facilidad as [Solicitud de Facilidad], t.tipo_facilidad As [Tipo de Facilidad],
't.observciones as [Observaciones] 
'from codigo_alumno c
'inner join apoderado a On c.id_alumno=a.id_apo
'inner join tipificaciones t On c.id_alumno=t.id_alumno
'where nombre_cliente Like'%lisset%'
'order by nombre_cliente