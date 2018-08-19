<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtalumno = New System.Windows.Forms.TextBox()
        Me.txtapoderado = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbocontactabilidad = New System.Windows.Forms.ComboBox()
        Me.cbotipo_contacto = New System.Windows.Forms.ComboBox()
        Me.cborespuesta_cliente = New System.Windows.Forms.ComboBox()
        Me.cbomotivo_cliente = New System.Windows.Forms.ComboBox()
        Me.cboaccion = New System.Windows.Forms.ComboBox()
        Me.cbomotivo_desercion = New System.Windows.Forms.ComboBox()
        Me.cbocarta_noadeudo = New System.Windows.Forms.ComboBox()
        Me.cborecategorizacion = New System.Windows.Forms.ComboBox()
        Me.cboincidencias = New System.Windows.Forms.ComboBox()
        Me.cbosolicitud_facilidad = New System.Windows.Forms.ComboBox()
        Me.cbotipo_facilidad = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtobservacion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnregistrar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del Alumno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre del Apoderado"
        '
        'txtalumno
        '
        Me.txtalumno.Location = New System.Drawing.Point(176, 9)
        Me.txtalumno.Name = "txtalumno"
        Me.txtalumno.Size = New System.Drawing.Size(276, 20)
        Me.txtalumno.TabIndex = 2
        '
        'txtapoderado
        '
        Me.txtapoderado.Location = New System.Drawing.Point(176, 35)
        Me.txtapoderado.Name = "txtapoderado"
        Me.txtapoderado.Size = New System.Drawing.Size(276, 20)
        Me.txtapoderado.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 93)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(776, 150)
        Me.DataGridView1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tipificaciones"
        '
        'cbocontactabilidad
        '
        Me.cbocontactabilidad.FormattingEnabled = True
        Me.cbocontactabilidad.Location = New System.Drawing.Point(126, 257)
        Me.cbocontactabilidad.Name = "cbocontactabilidad"
        Me.cbocontactabilidad.Size = New System.Drawing.Size(121, 21)
        Me.cbocontactabilidad.TabIndex = 5
        '
        'cbotipo_contacto
        '
        Me.cbotipo_contacto.FormattingEnabled = True
        Me.cbotipo_contacto.Location = New System.Drawing.Point(282, 257)
        Me.cbotipo_contacto.Name = "cbotipo_contacto"
        Me.cbotipo_contacto.Size = New System.Drawing.Size(121, 21)
        Me.cbotipo_contacto.TabIndex = 5
        '
        'cborespuesta_cliente
        '
        Me.cborespuesta_cliente.FormattingEnabled = True
        Me.cborespuesta_cliente.Location = New System.Drawing.Point(460, 257)
        Me.cborespuesta_cliente.Name = "cborespuesta_cliente"
        Me.cborespuesta_cliente.Size = New System.Drawing.Size(121, 21)
        Me.cborespuesta_cliente.TabIndex = 5
        '
        'cbomotivo_cliente
        '
        Me.cbomotivo_cliente.FormattingEnabled = True
        Me.cbomotivo_cliente.Location = New System.Drawing.Point(635, 257)
        Me.cbomotivo_cliente.Name = "cbomotivo_cliente"
        Me.cbomotivo_cliente.Size = New System.Drawing.Size(121, 21)
        Me.cbomotivo_cliente.TabIndex = 6
        '
        'cboaccion
        '
        Me.cboaccion.FormattingEnabled = True
        Me.cboaccion.Location = New System.Drawing.Point(126, 296)
        Me.cboaccion.Name = "cboaccion"
        Me.cboaccion.Size = New System.Drawing.Size(121, 21)
        Me.cboaccion.TabIndex = 7
        '
        'cbomotivo_desercion
        '
        Me.cbomotivo_desercion.FormattingEnabled = True
        Me.cbomotivo_desercion.Location = New System.Drawing.Point(282, 296)
        Me.cbomotivo_desercion.Name = "cbomotivo_desercion"
        Me.cbomotivo_desercion.Size = New System.Drawing.Size(121, 21)
        Me.cbomotivo_desercion.TabIndex = 7
        '
        'cbocarta_noadeudo
        '
        Me.cbocarta_noadeudo.FormattingEnabled = True
        Me.cbocarta_noadeudo.Location = New System.Drawing.Point(460, 296)
        Me.cbocarta_noadeudo.Name = "cbocarta_noadeudo"
        Me.cbocarta_noadeudo.Size = New System.Drawing.Size(121, 21)
        Me.cbocarta_noadeudo.TabIndex = 7
        '
        'cborecategorizacion
        '
        Me.cborecategorizacion.FormattingEnabled = True
        Me.cborecategorizacion.Location = New System.Drawing.Point(635, 295)
        Me.cborecategorizacion.Name = "cborecategorizacion"
        Me.cborecategorizacion.Size = New System.Drawing.Size(121, 21)
        Me.cborecategorizacion.TabIndex = 8
        '
        'cboincidencias
        '
        Me.cboincidencias.FormattingEnabled = True
        Me.cboincidencias.Location = New System.Drawing.Point(126, 333)
        Me.cboincidencias.Name = "cboincidencias"
        Me.cboincidencias.Size = New System.Drawing.Size(121, 21)
        Me.cboincidencias.TabIndex = 7
        '
        'cbosolicitud_facilidad
        '
        Me.cbosolicitud_facilidad.FormattingEnabled = True
        Me.cbosolicitud_facilidad.Location = New System.Drawing.Point(282, 333)
        Me.cbosolicitud_facilidad.Name = "cbosolicitud_facilidad"
        Me.cbosolicitud_facilidad.Size = New System.Drawing.Size(121, 21)
        Me.cbosolicitud_facilidad.TabIndex = 7
        '
        'cbotipo_facilidad
        '
        Me.cbotipo_facilidad.FormattingEnabled = True
        Me.cbotipo_facilidad.Location = New System.Drawing.Point(460, 333)
        Me.cbotipo_facilidad.Name = "cbotipo_facilidad"
        Me.cbotipo_facilidad.Size = New System.Drawing.Size(121, 21)
        Me.cbotipo_facilidad.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 367)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Observaciones"
        '
        'txtobservacion
        '
        Me.txtobservacion.Location = New System.Drawing.Point(24, 387)
        Me.txtobservacion.Multiline = True
        Me.txtobservacion.Name = "txtobservacion"
        Me.txtobservacion.Size = New System.Drawing.Size(764, 124)
        Me.txtobservacion.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Fecha "
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(176, 66)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 10
        '
        'btnactualizar
        '
        Me.btnactualizar.Location = New System.Drawing.Point(561, 575)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnactualizar.TabIndex = 11
        Me.btnactualizar.Text = "Atualizar"
        Me.btnactualizar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(667, 575)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Atualizar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnregistrar
        '
        Me.btnregistrar.Location = New System.Drawing.Point(460, 575)
        Me.btnregistrar.Name = "btnregistrar"
        Me.btnregistrar.Size = New System.Drawing.Size(75, 23)
        Me.btnregistrar.TabIndex = 11
        Me.btnregistrar.Text = "Registrar"
        Me.btnregistrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 623)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnregistrar)
        Me.Controls.Add(Me.btnactualizar)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cborecategorizacion)
        Me.Controls.Add(Me.cbocarta_noadeudo)
        Me.Controls.Add(Me.cbomotivo_desercion)
        Me.Controls.Add(Me.cbotipo_facilidad)
        Me.Controls.Add(Me.cbosolicitud_facilidad)
        Me.Controls.Add(Me.cboincidencias)
        Me.Controls.Add(Me.cboaccion)
        Me.Controls.Add(Me.cbomotivo_cliente)
        Me.Controls.Add(Me.cborespuesta_cliente)
        Me.Controls.Add(Me.cbotipo_contacto)
        Me.Controls.Add(Me.cbocontactabilidad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtobservacion)
        Me.Controls.Add(Me.txtapoderado)
        Me.Controls.Add(Me.txtalumno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtalumno As TextBox
    Friend WithEvents txtapoderado As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents cbocontactabilidad As ComboBox
    Friend WithEvents cbotipo_contacto As ComboBox
    Friend WithEvents cborespuesta_cliente As ComboBox
    Friend WithEvents cbomotivo_cliente As ComboBox
    Friend WithEvents cboaccion As ComboBox
    Friend WithEvents cbomotivo_desercion As ComboBox
    Friend WithEvents cbocarta_noadeudo As ComboBox
    Friend WithEvents cborecategorizacion As ComboBox
    Friend WithEvents cboincidencias As ComboBox
    Friend WithEvents cbosolicitud_facilidad As ComboBox
    Friend WithEvents cbotipo_facilidad As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtobservacion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnactualizar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnregistrar As Button
End Class
