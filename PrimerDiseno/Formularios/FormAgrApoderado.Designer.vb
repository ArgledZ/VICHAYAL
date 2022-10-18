<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAgrApoderado
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.CboDepartamento = New System.Windows.Forms.ComboBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.LblEstudiante = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CboProvincia = New System.Windows.Forms.ComboBox()
        Me.CboDistrito = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnRegApoderado = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 18)
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
        Me.Label2.Location = New System.Drawing.Point(7, 55)
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
        Me.Label3.Location = New System.Drawing.Point(7, 92)
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
        Me.Label4.Location = New System.Drawing.Point(7, 130)
        Me.Label4.MinimumSize = New System.Drawing.Size(150, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Telefono"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 239)
        Me.Label5.MinimumSize = New System.Drawing.Size(150, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Departamento"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 171)
        Me.Label6.MinimumSize = New System.Drawing.Size(150, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Correo"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDni
        '
        Me.txtDni.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDni.Location = New System.Drawing.Point(163, 16)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(180, 26)
        Me.txtDni.TabIndex = 7
        '
        'txtNombres
        '
        Me.txtNombres.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombres.Location = New System.Drawing.Point(163, 53)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(180, 26)
        Me.txtNombres.TabIndex = 8
        '
        'txtApellidos
        '
        Me.txtApellidos.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidos.Location = New System.Drawing.Point(163, 90)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(180, 26)
        Me.txtApellidos.TabIndex = 9
        '
        'CboDepartamento
        '
        Me.CboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboDepartamento.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDepartamento.FormattingEnabled = True
        Me.CboDepartamento.Location = New System.Drawing.Point(163, 236)
        Me.CboDepartamento.Name = "CboDepartamento"
        Me.CboDepartamento.Size = New System.Drawing.Size(180, 26)
        Me.CboDepartamento.TabIndex = 11
        '
        'txtCorreo
        '
        Me.txtCorreo.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Location = New System.Drawing.Point(163, 168)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(180, 26)
        Me.txtCorreo.TabIndex = 12
        '
        'LblEstudiante
        '
        Me.LblEstudiante.AutoSize = True
        Me.LblEstudiante.BackColor = System.Drawing.Color.Transparent
        Me.LblEstudiante.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblEstudiante.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstudiante.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LblEstudiante.Location = New System.Drawing.Point(52, 3)
        Me.LblEstudiante.Name = "LblEstudiante"
        Me.LblEstudiante.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblEstudiante.Size = New System.Drawing.Size(264, 35)
        Me.LblEstudiante.TabIndex = 14
        Me.LblEstudiante.Text = "NUEVO APODERADO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Peru
        Me.Label7.Location = New System.Drawing.Point(32, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(264, 35)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "DATOS APODERADO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(360, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 13)
        Me.Label8.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(7, 278)
        Me.Label10.MinimumSize = New System.Drawing.Size(150, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(150, 20)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Provincia"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 317)
        Me.Label11.MinimumSize = New System.Drawing.Size(150, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(150, 20)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Distrito"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CboProvincia
        '
        Me.CboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboProvincia.Enabled = False
        Me.CboProvincia.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboProvincia.FormattingEnabled = True
        Me.CboProvincia.Location = New System.Drawing.Point(163, 276)
        Me.CboProvincia.Name = "CboProvincia"
        Me.CboProvincia.Size = New System.Drawing.Size(180, 26)
        Me.CboProvincia.TabIndex = 21
        '
        'CboDistrito
        '
        Me.CboDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboDistrito.Enabled = False
        Me.CboDistrito.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDistrito.FormattingEnabled = True
        Me.CboDistrito.Location = New System.Drawing.Point(163, 315)
        Me.CboDistrito.Name = "CboDistrito"
        Me.CboDistrito.Size = New System.Drawing.Size(180, 26)
        Me.CboDistrito.TabIndex = 22
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtDireccion)
        Me.Panel1.Controls.Add(Me.TxtTelefono)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.CboDistrito)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.CboProvincia)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtDni)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtNombres)
        Me.Panel1.Controls.Add(Me.txtApellidos)
        Me.Panel1.Controls.Add(Me.CboDepartamento)
        Me.Panel1.Controls.Add(Me.txtCorreo)
        Me.Panel1.Location = New System.Drawing.Point(27, 111)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(355, 358)
        Me.Panel1.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 207)
        Me.Label9.MinimumSize = New System.Drawing.Size(150, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(150, 20)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Direccion"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(163, 204)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(180, 26)
        Me.txtDireccion.TabIndex = 24
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefono.Location = New System.Drawing.Point(163, 126)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(180, 26)
        Me.TxtTelefono.TabIndex = 23
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(27, 62)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(355, 38)
        Me.Panel2.TabIndex = 28
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.LblEstudiante)
        Me.Panel7.Location = New System.Drawing.Point(27, 10)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(355, 38)
        Me.Panel7.TabIndex = 29
        '
        'btnRegApoderado
        '
        Me.btnRegApoderado.Location = New System.Drawing.Point(206, 475)
        Me.btnRegApoderado.Name = "btnRegApoderado"
        Me.btnRegApoderado.Size = New System.Drawing.Size(188, 40)
        Me.btnRegApoderado.TabIndex = 33
        Me.btnRegApoderado.Text = "REGISTRAR APODERADO"
        Me.btnRegApoderado.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 475)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(188, 40)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "REGRESAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel8.Controls.Add(Me.Panel7)
        Me.Panel8.Controls.Add(Me.Button2)
        Me.Panel8.Controls.Add(Me.Label8)
        Me.Panel8.Controls.Add(Me.btnRegApoderado)
        Me.Panel8.Controls.Add(Me.Panel1)
        Me.Panel8.Controls.Add(Me.Panel2)
        Me.Panel8.Location = New System.Drawing.Point(2, 2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(415, 528)
        Me.Panel8.TabIndex = 35
        '
        'FormAgrApoderado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(419, 532)
        Me.Controls.Add(Me.Panel8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormAgrApoderado"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormAgrApoderado"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDni As TextBox
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents CboDepartamento As ComboBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents LblEstudiante As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents CboProvincia As ComboBox
    Friend WithEvents CboDistrito As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btnRegApoderado As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDireccion As TextBox
End Class
