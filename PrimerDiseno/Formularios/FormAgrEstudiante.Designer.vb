<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAgrEstudiante
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.CboDepartamento = New System.Windows.Forms.ComboBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.DtmEstudiante = New System.Windows.Forms.DateTimePicker()
        Me.LblEstudiante = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CboProvincia = New System.Windows.Forms.ComboBox()
        Me.CboDistrito = New System.Windows.Forms.ComboBox()
        Me.TxbApoderado = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DgvApoderado = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtApoA = New System.Windows.Forms.TextBox()
        Me.txtApoN = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        CType(Me.DgvApoderado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
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
        Me.Label4.Location = New System.Drawing.Point(7, 129)
        Me.Label4.MinimumSize = New System.Drawing.Size(150, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha de nacimiento"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 203)
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
        Me.Label6.Location = New System.Drawing.Point(7, 166)
        Me.Label6.MinimumSize = New System.Drawing.Size(150, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Direccion"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(344, 10)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(127, 38)
        Me.btnAceptar.TabIndex = 6
        Me.btnAceptar.Text = "NUEVO"
        Me.btnAceptar.UseVisualStyleBackColor = True
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
        Me.CboDepartamento.Location = New System.Drawing.Point(163, 202)
        Me.CboDepartamento.Name = "CboDepartamento"
        Me.CboDepartamento.Size = New System.Drawing.Size(180, 26)
        Me.CboDepartamento.TabIndex = 11
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(163, 166)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(180, 26)
        Me.txtDireccion.TabIndex = 12
        '
        'DtmEstudiante
        '
        Me.DtmEstudiante.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtmEstudiante.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtmEstudiante.Location = New System.Drawing.Point(163, 128)
        Me.DtmEstudiante.MinimumSize = New System.Drawing.Size(100, 20)
        Me.DtmEstudiante.Name = "DtmEstudiante"
        Me.DtmEstudiante.Size = New System.Drawing.Size(180, 26)
        Me.DtmEstudiante.TabIndex = 13
        '
        'LblEstudiante
        '
        Me.LblEstudiante.AutoSize = True
        Me.LblEstudiante.BackColor = System.Drawing.Color.Transparent
        Me.LblEstudiante.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblEstudiante.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstudiante.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LblEstudiante.Location = New System.Drawing.Point(37, 0)
        Me.LblEstudiante.Name = "LblEstudiante"
        Me.LblEstudiante.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblEstudiante.Size = New System.Drawing.Size(280, 35)
        Me.LblEstudiante.TabIndex = 14
        Me.LblEstudiante.Text = "NUEVO ESTUDIANTE"
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
        Me.Label7.Size = New System.Drawing.Size(280, 35)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "DATOS ESTUDIANTE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(590, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 13)
        Me.Label8.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Peru
        Me.Label9.Location = New System.Drawing.Point(106, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(274, 35)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "BUSCAR APODERADO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(7, 240)
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
        Me.Label11.Location = New System.Drawing.Point(7, 277)
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
        Me.CboProvincia.Location = New System.Drawing.Point(163, 239)
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
        Me.CboDistrito.Location = New System.Drawing.Point(163, 276)
        Me.CboDistrito.Name = "CboDistrito"
        Me.CboDistrito.Size = New System.Drawing.Size(180, 26)
        Me.CboDistrito.TabIndex = 22
        '
        'TxbApoderado
        '
        Me.TxbApoderado.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbApoderado.Location = New System.Drawing.Point(69, 16)
        Me.TxbApoderado.Name = "TxbApoderado"
        Me.TxbApoderado.Size = New System.Drawing.Size(269, 26)
        Me.TxbApoderado.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(21, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 19)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "DNI"
        '
        'DgvApoderado
        '
        Me.DgvApoderado.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DgvApoderado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvApoderado.Location = New System.Drawing.Point(10, 55)
        Me.DgvApoderado.Name = "DgvApoderado"
        Me.DgvApoderado.ReadOnly = True
        Me.DgvApoderado.RowHeadersVisible = False
        Me.DgvApoderado.Size = New System.Drawing.Size(461, 120)
        Me.DgvApoderado.TabIndex = 25
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
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
        Me.Panel1.Controls.Add(Me.txtDireccion)
        Me.Panel1.Controls.Add(Me.DtmEstudiante)
        Me.Panel1.Location = New System.Drawing.Point(12, 111)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(355, 332)
        Me.Panel1.TabIndex = 27
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(12, 67)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(355, 38)
        Me.Panel2.TabIndex = 28
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.DgvApoderado)
        Me.Panel3.Controls.Add(Me.TxbApoderado)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.btnAceptar)
        Me.Panel3.Location = New System.Drawing.Point(373, 111)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(488, 186)
        Me.Panel3.TabIndex = 29
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Location = New System.Drawing.Point(373, 67)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(488, 38)
        Me.Panel4.TabIndex = 29
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.txtApoA)
        Me.Panel5.Controls.Add(Me.txtApoN)
        Me.Panel5.Controls.Add(Me.Label14)
        Me.Panel5.Controls.Add(Me.Label13)
        Me.Panel5.Location = New System.Drawing.Point(373, 350)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(488, 93)
        Me.Panel5.TabIndex = 30
        '
        'txtApoA
        '
        Me.txtApoA.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApoA.Location = New System.Drawing.Point(112, 52)
        Me.txtApoA.Name = "txtApoA"
        Me.txtApoA.Size = New System.Drawing.Size(359, 26)
        Me.txtApoA.TabIndex = 24
        '
        'txtApoN
        '
        Me.txtApoN.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApoN.Location = New System.Drawing.Point(112, 17)
        Me.txtApoN.Name = "txtApoN"
        Me.txtApoN.Size = New System.Drawing.Size(359, 26)
        Me.txtApoN.TabIndex = 23
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(4, 54)
        Me.Label14.MinimumSize = New System.Drawing.Size(100, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 20)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Apellidos"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 17)
        Me.Label13.MinimumSize = New System.Drawing.Size(100, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 20)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Nombres"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Peru
        Me.Label15.Location = New System.Drawing.Point(116, 3)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(264, 35)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "DATOS APODERADO"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.Label15)
        Me.Panel6.Location = New System.Drawing.Point(373, 306)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(488, 38)
        Me.Panel6.TabIndex = 30
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.LblEstudiante)
        Me.Panel7.Location = New System.Drawing.Point(257, 10)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(355, 38)
        Me.Panel7.TabIndex = 29
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(436, 475)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(188, 40)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "REGISTRAR ESTUDIANTE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(242, 475)
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
        Me.Panel8.Controls.Add(Me.Button1)
        Me.Panel8.Controls.Add(Me.Panel1)
        Me.Panel8.Controls.Add(Me.Panel2)
        Me.Panel8.Controls.Add(Me.Panel6)
        Me.Panel8.Controls.Add(Me.Panel3)
        Me.Panel8.Controls.Add(Me.Panel5)
        Me.Panel8.Controls.Add(Me.Panel4)
        Me.Panel8.Location = New System.Drawing.Point(2, 2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(877, 528)
        Me.Panel8.TabIndex = 35
        '
        'FormAgrEstudiante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(881, 532)
        Me.Controls.Add(Me.Panel8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormAgrEstudiante"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormAgrEstudiante"
        CType(Me.DgvApoderado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
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
    Friend WithEvents btnAceptar As Button
    Friend WithEvents txtDni As TextBox
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents CboDepartamento As ComboBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents DtmEstudiante As DateTimePicker
    Friend WithEvents LblEstudiante As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents CboProvincia As ComboBox
    Friend WithEvents CboDistrito As ComboBox
    Friend WithEvents TxbApoderado As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents DgvApoderado As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtApoA As TextBox
    Friend WithEvents txtApoN As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel8 As Panel
End Class
