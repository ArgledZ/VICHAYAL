<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrimerDiseno
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
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnUsuarios = New FontAwesome.Sharp.IconButton()
        Me.btnAnioEscolar = New FontAwesome.Sharp.IconButton()
        Me.btnMatricula = New FontAwesome.Sharp.IconButton()
        Me.btnPregrado = New FontAwesome.Sharp.IconButton()
        Me.BtnUSS = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.lblFormTituloActual = New System.Windows.Forms.Label()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.IconFormActual = New FontAwesome.Sharp.IconPictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ImgLogo = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ImgLogo2 = New System.Windows.Forms.PictureBox()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        Me.PanelTitulo.SuspendLayout()
        Me.PanelContenedor.SuspendLayout()
        CType(Me.IconFormActual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgLogo2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.SystemColors.HotTrack
        Me.PanelMenu.Controls.Add(Me.btnUsuarios)
        Me.PanelMenu.Controls.Add(Me.btnAnioEscolar)
        Me.PanelMenu.Controls.Add(Me.btnMatricula)
        Me.PanelMenu.Controls.Add(Me.btnPregrado)
        Me.PanelMenu.Controls.Add(Me.BtnUSS)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(259, 681)
        Me.PanelMenu.TabIndex = 0
        '
        'btnUsuarios
        '
        Me.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUsuarios.FlatAppearance.BorderSize = 0
        Me.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuarios.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.btnUsuarios.IconColor = System.Drawing.Color.Gainsboro
        Me.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuarios.Location = New System.Drawing.Point(0, 274)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnUsuarios.Size = New System.Drawing.Size(259, 44)
        Me.btnUsuarios.TabIndex = 5
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.UseVisualStyleBackColor = True
        '
        'btnAnioEscolar
        '
        Me.btnAnioEscolar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAnioEscolar.FlatAppearance.BorderSize = 0
        Me.btnAnioEscolar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnioEscolar.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnioEscolar.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnAnioEscolar.IconChar = FontAwesome.Sharp.IconChar.Award
        Me.btnAnioEscolar.IconColor = System.Drawing.Color.Gainsboro
        Me.btnAnioEscolar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAnioEscolar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnioEscolar.Location = New System.Drawing.Point(0, 230)
        Me.btnAnioEscolar.Name = "btnAnioEscolar"
        Me.btnAnioEscolar.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnAnioEscolar.Size = New System.Drawing.Size(259, 44)
        Me.btnAnioEscolar.TabIndex = 4
        Me.btnAnioEscolar.Text = "Año Escolar"
        Me.btnAnioEscolar.UseVisualStyleBackColor = True
        '
        'btnMatricula
        '
        Me.btnMatricula.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMatricula.FlatAppearance.BorderSize = 0
        Me.btnMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMatricula.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMatricula.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnMatricula.IconChar = FontAwesome.Sharp.IconChar.Registered
        Me.btnMatricula.IconColor = System.Drawing.Color.Gainsboro
        Me.btnMatricula.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMatricula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMatricula.Location = New System.Drawing.Point(0, 186)
        Me.btnMatricula.Name = "btnMatricula"
        Me.btnMatricula.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnMatricula.Size = New System.Drawing.Size(259, 44)
        Me.btnMatricula.TabIndex = 3
        Me.btnMatricula.Text = "Matricula"
        Me.btnMatricula.UseVisualStyleBackColor = True
        '
        'btnPregrado
        '
        Me.btnPregrado.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPregrado.FlatAppearance.BorderSize = 0
        Me.btnPregrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPregrado.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPregrado.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnPregrado.IconChar = FontAwesome.Sharp.IconChar.AppStore
        Me.btnPregrado.IconColor = System.Drawing.Color.Gainsboro
        Me.btnPregrado.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPregrado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPregrado.Location = New System.Drawing.Point(0, 142)
        Me.btnPregrado.Name = "btnPregrado"
        Me.btnPregrado.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnPregrado.Size = New System.Drawing.Size(259, 44)
        Me.btnPregrado.TabIndex = 2
        Me.btnPregrado.Text = "Apoderados"
        Me.btnPregrado.UseVisualStyleBackColor = True
        '
        'BtnUSS
        '
        Me.BtnUSS.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnUSS.FlatAppearance.BorderSize = 0
        Me.BtnUSS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUSS.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUSS.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnUSS.IconChar = FontAwesome.Sharp.IconChar.HouseUser
        Me.BtnUSS.IconColor = System.Drawing.Color.Gainsboro
        Me.BtnUSS.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnUSS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUSS.Location = New System.Drawing.Point(0, 98)
        Me.BtnUSS.Name = "BtnUSS"
        Me.BtnUSS.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BtnUSS.Size = New System.Drawing.Size(259, 44)
        Me.BtnUSS.TabIndex = 1
        Me.BtnUSS.Text = "Estudiantes"
        Me.BtnUSS.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.ImgLogo)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(259, 98)
        Me.PanelLogo.TabIndex = 0
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.SystemColors.HotTrack
        Me.PanelTitulo.Controls.Add(Me.lblFormTituloActual)
        Me.PanelTitulo.Controls.Add(Me.IconFormActual)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.ForeColor = System.Drawing.Color.Gainsboro
        Me.PanelTitulo.Location = New System.Drawing.Point(259, 0)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(1005, 98)
        Me.PanelTitulo.TabIndex = 1
        '
        'lblFormTituloActual
        '
        Me.lblFormTituloActual.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTituloActual.Location = New System.Drawing.Point(99, 24)
        Me.lblFormTituloActual.Name = "lblFormTituloActual"
        Me.lblFormTituloActual.Size = New System.Drawing.Size(281, 56)
        Me.lblFormTituloActual.TabIndex = 1
        Me.lblFormTituloActual.Text = "INICIO"
        Me.lblFormTituloActual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.SystemColors.Window
        Me.PanelContenedor.Controls.Add(Me.ImgLogo2)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(259, 98)
        Me.PanelContenedor.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1005, 583)
        Me.PanelContenedor.TabIndex = 2
        '
        'IconFormActual
        '
        Me.IconFormActual.BackColor = System.Drawing.Color.Transparent
        Me.IconFormActual.ForeColor = System.Drawing.Color.LightSalmon
        Me.IconFormActual.IconChar = FontAwesome.Sharp.IconChar.Napster
        Me.IconFormActual.IconColor = System.Drawing.Color.LightSalmon
        Me.IconFormActual.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconFormActual.IconSize = 85
        Me.IconFormActual.Location = New System.Drawing.Point(6, 7)
        Me.IconFormActual.Name = "IconFormActual"
        Me.IconFormActual.Size = New System.Drawing.Size(87, 85)
        Me.IconFormActual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.IconFormActual.TabIndex = 0
        Me.IconFormActual.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(259, 629)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1005, 52)
        Me.Panel1.TabIndex = 3
        '
        'ImgLogo
        '
        Me.ImgLogo.Image = Global.PrimerDiseno.My.Resources.Resources.logouss
        Me.ImgLogo.Location = New System.Drawing.Point(26, 7)
        Me.ImgLogo.Name = "ImgLogo"
        Me.ImgLogo.Size = New System.Drawing.Size(227, 86)
        Me.ImgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgLogo.TabIndex = 4
        Me.ImgLogo.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1231, 98)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(33, 531)
        Me.Panel2.TabIndex = 0
        '
        'ImgLogo2
        '
        Me.ImgLogo2.Image = Global.PrimerDiseno.My.Resources.Resources.logouss
        Me.ImgLogo2.Location = New System.Drawing.Point(308, 197)
        Me.ImgLogo2.Name = "ImgLogo2"
        Me.ImgLogo2.Size = New System.Drawing.Size(358, 108)
        Me.ImgLogo2.TabIndex = 5
        Me.ImgLogo2.TabStop = False
        '
        'FormPrimerDiseno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.PanelTitulo)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "FormPrimerDiseno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario Principal"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelContenedor.ResumeLayout(False)
        CType(Me.IconFormActual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgLogo2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
	Friend WithEvents BtnUSS As FontAwesome.Sharp.IconButton
	Friend WithEvents PanelLogo As Panel
    Friend WithEvents btnPregrado As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents lblFormTituloActual As Label
    Friend WithEvents btnUsuarios As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAnioEscolar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMatricula As FontAwesome.Sharp.IconButton
    Friend WithEvents IconFormActual As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ImgLogo As PictureBox
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ImgLogo2 As PictureBox
End Class
