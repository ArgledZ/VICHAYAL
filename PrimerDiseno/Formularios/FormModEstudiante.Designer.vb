<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormModEstudiante
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CboModDistrito = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CboModProvincia = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtModDni = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtModNombres = New System.Windows.Forms.TextBox()
        Me.txtModApellidos = New System.Windows.Forms.TextBox()
        Me.CboModDepartamento = New System.Windows.Forms.ComboBox()
        Me.txtModDireccion = New System.Windows.Forms.TextBox()
        Me.DtmModEstudiante = New System.Windows.Forms.DateTimePicker()
        Me.btnModEstudiante = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(56, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(355, 38)
        Me.Panel2.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Peru
        Me.Label7.Location = New System.Drawing.Point(7, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(338, 35)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "MODIFICAR ESTUDIANTE"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TxtId)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.CboModDistrito)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.CboModProvincia)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtModDni)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtModNombres)
        Me.Panel1.Controls.Add(Me.txtModApellidos)
        Me.Panel1.Controls.Add(Me.CboModDepartamento)
        Me.Panel1.Controls.Add(Me.txtModDireccion)
        Me.Panel1.Controls.Add(Me.DtmModEstudiante)
        Me.Panel1.Location = New System.Drawing.Point(12, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(459, 315)
        Me.Panel1.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(26, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 19)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "ID"
        '
        'TxtId
        '
        Me.TxtId.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtId.Location = New System.Drawing.Point(57, 13)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(62, 26)
        Me.TxtId.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(88, 15)
        Me.Label1.MinimumSize = New System.Drawing.Size(150, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DNI :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(88, 52)
        Me.Label2.MinimumSize = New System.Drawing.Size(150, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombres"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(88, 89)
        Me.Label3.MinimumSize = New System.Drawing.Size(150, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellidos"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(88, 126)
        Me.Label4.MinimumSize = New System.Drawing.Size(150, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha de nacimiento"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CboModDistrito
        '
        Me.CboModDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboModDistrito.Enabled = False
        Me.CboModDistrito.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboModDistrito.FormattingEnabled = True
        Me.CboModDistrito.Location = New System.Drawing.Point(244, 273)
        Me.CboModDistrito.Name = "CboModDistrito"
        Me.CboModDistrito.Size = New System.Drawing.Size(180, 26)
        Me.CboModDistrito.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(88, 200)
        Me.Label5.MinimumSize = New System.Drawing.Size(150, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Departamento"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CboModProvincia
        '
        Me.CboModProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboModProvincia.Enabled = False
        Me.CboModProvincia.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboModProvincia.FormattingEnabled = True
        Me.CboModProvincia.Location = New System.Drawing.Point(244, 236)
        Me.CboModProvincia.Name = "CboModProvincia"
        Me.CboModProvincia.Size = New System.Drawing.Size(180, 26)
        Me.CboModProvincia.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(88, 163)
        Me.Label6.MinimumSize = New System.Drawing.Size(150, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Direccion"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(88, 274)
        Me.Label11.MinimumSize = New System.Drawing.Size(150, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(150, 20)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Distrito"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtModDni
        '
        Me.txtModDni.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModDni.Location = New System.Drawing.Point(244, 13)
        Me.txtModDni.Name = "txtModDni"
        Me.txtModDni.Size = New System.Drawing.Size(180, 26)
        Me.txtModDni.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(88, 237)
        Me.Label10.MinimumSize = New System.Drawing.Size(150, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(150, 20)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Provincia"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtModNombres
        '
        Me.txtModNombres.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModNombres.Location = New System.Drawing.Point(244, 50)
        Me.txtModNombres.Name = "txtModNombres"
        Me.txtModNombres.Size = New System.Drawing.Size(180, 26)
        Me.txtModNombres.TabIndex = 8
        '
        'txtModApellidos
        '
        Me.txtModApellidos.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModApellidos.Location = New System.Drawing.Point(244, 87)
        Me.txtModApellidos.Name = "txtModApellidos"
        Me.txtModApellidos.Size = New System.Drawing.Size(180, 26)
        Me.txtModApellidos.TabIndex = 9
        '
        'CboModDepartamento
        '
        Me.CboModDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboModDepartamento.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboModDepartamento.FormattingEnabled = True
        Me.CboModDepartamento.Location = New System.Drawing.Point(244, 199)
        Me.CboModDepartamento.Name = "CboModDepartamento"
        Me.CboModDepartamento.Size = New System.Drawing.Size(180, 26)
        Me.CboModDepartamento.TabIndex = 11
        '
        'txtModDireccion
        '
        Me.txtModDireccion.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModDireccion.Location = New System.Drawing.Point(244, 163)
        Me.txtModDireccion.Name = "txtModDireccion"
        Me.txtModDireccion.Size = New System.Drawing.Size(180, 26)
        Me.txtModDireccion.TabIndex = 12
        '
        'DtmModEstudiante
        '
        Me.DtmModEstudiante.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtmModEstudiante.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtmModEstudiante.Location = New System.Drawing.Point(244, 125)
        Me.DtmModEstudiante.MinimumSize = New System.Drawing.Size(100, 20)
        Me.DtmModEstudiante.Name = "DtmModEstudiante"
        Me.DtmModEstudiante.Size = New System.Drawing.Size(180, 26)
        Me.DtmModEstudiante.TabIndex = 13
        '
        'btnModEstudiante
        '
        Me.btnModEstudiante.Location = New System.Drawing.Point(283, 375)
        Me.btnModEstudiante.Name = "btnModEstudiante"
        Me.btnModEstudiante.Size = New System.Drawing.Size(188, 40)
        Me.btnModEstudiante.TabIndex = 34
        Me.btnModEstudiante.Text = "MODIFICAR ESTUDIANTE"
        Me.btnModEstudiante.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.btnModEstudiante)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Location = New System.Drawing.Point(2, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(484, 423)
        Me.Panel3.TabIndex = 35
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 375)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(188, 40)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "REGRESAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormModEstudiante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(488, 427)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormModEstudiante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormModEstudiante"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CboModDistrito As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CboModProvincia As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtModDni As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtModNombres As TextBox
    Friend WithEvents txtModApellidos As TextBox
    Friend WithEvents CboModDepartamento As ComboBox
    Friend WithEvents txtModDireccion As TextBox
    Friend WithEvents DtmModEstudiante As DateTimePicker
    Friend WithEvents btnModEstudiante As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
End Class
