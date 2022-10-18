Imports FontAwesome.Sharp
Public Class FormPrimerDiseno
	Private btnActual As IconButton
	Private leftBorderBtn As Panel
	'Formulario hijos
	Private currentChildForm As Form
	'Construtor
	Public Sub New()

		' Esta llamada es exigida por el diseñador.
		InitializeComponent()

		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
		leftBorderBtn = New Panel()
		leftBorderBtn.Size = New Size(6, 44)
		PanelMenu.Controls.Add(leftBorderBtn)
	End Sub
	'Metodos
	'Boton y color personalizado
	Private Sub ActivateButton(senderBtn As Object, customColor As Color)
		If senderBtn IsNot Nothing Then
			DisableButton()
			'Trabajamos con el boton
			btnActual = CType(senderBtn, IconButton)
			btnActual.BackColor = Color.FromArgb(37, 36, 81)
			btnActual.ForeColor = customColor
			btnActual.IconColor = customColor
			btnActual.TextAlign = ContentAlignment.MiddleCenter
			btnActual.ImageAlign = ContentAlignment.MiddleRight
			btnActual.TextImageRelation = TextImageRelation.TextBeforeImage

			'En el panelmenu left Border
			leftBorderBtn.BackColor = customColor
			leftBorderBtn.Location = New Point(0, btnActual.Location.Y)
			leftBorderBtn.Visible = True
			leftBorderBtn.BringToFront()

			'Icono del formulario activo
			IconFormActual.IconChar = btnActual.IconChar
			IconFormActual.IconColor = customColor
		End If
	End Sub
	Public Sub DisableButton()
		If btnActual IsNot Nothing Then
			btnActual.BackColor = SystemColors.HotTrack
			btnActual.ForeColor = Color.Gainsboro
			btnActual.IconColor = Color.Gainsboro
			btnActual.TextAlign = ContentAlignment.MiddleLeft
			btnActual.ImageAlign = ContentAlignment.MiddleLeft
			btnActual.TextImageRelation = TextImageRelation.ImageBeforeText
		End If
	End Sub
	'Abrir formulario hijo 
	Private Sub OpenChildForm(childForm As Form)
		If currentChildForm IsNot Nothing Then
			currentChildForm.Close()
		Else
			ImgLogo2.Visible = False
		End If
		currentChildForm = childForm
		childForm.TopLevel = False
		childForm.Dock = DockStyle.Fill
		childForm.FormBorderStyle = FormBorderStyle.None
		'Agregamos el formulario hijo al panel contenedor
		PanelContenedor.Controls.Add(childForm)
		PanelContenedor.Tag = childForm
		childForm.BringToFront()
		childForm.Show()
		'Agregamos el titulo del formulario actual
		lblFormTituloActual.Text = btnActual.Text.ToString()
	End Sub
	Private Sub BtnUSS_Click(sender As Object, e As EventArgs) Handles BtnUSS.Click
		ActivateButton(sender, RGBColors.color1)
		OpenChildForm(New FormEstudiante)
	End Sub

	Private Sub btnPregrado_Click(sender As Object, e As EventArgs) Handles btnPregrado.Click
		ActivateButton(sender, RGBColors.color2)
		OpenChildForm(New FormApoderado)
	End Sub

	Private Sub btnMatricula_Click(sender As Object, e As EventArgs) Handles btnMatricula.Click
		ActivateButton(sender, RGBColors.color3)
		OpenChildForm(New FormEstudiante)
	End Sub

	Private Sub btnAnioEscolar_Click(sender As Object, e As EventArgs) Handles btnAnioEscolar.Click
		ActivateButton(sender, RGBColors.color4)
		OpenChildForm(New FormEstudiante)
	End Sub

	Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
		ActivateButton(sender, RGBColors.color5)
		OpenChildForm(New FormEstudiante)
	End Sub

	Private Sub ImgLogo_Click(sender As Object, e As EventArgs) Handles ImgLogo.Click
		If currentChildForm IsNot Nothing Then
			currentChildForm.Close()
		End If
		Reset()
	End Sub
	Private Sub Reset()
		DisableButton()
		leftBorderBtn.Visible = False
		IconFormActual.IconChar = IconChar.Napster
		IconFormActual.IconColor = Color.LightSalmon
		ImgLogo2.Visible = True
		lblFormTituloActual.Text = "INICIO"
		lblFormTituloActual.ForeColor = Color.Gainsboro
	End Sub

	Private Sub PanelMenu_Paint(sender As Object, e As PaintEventArgs) Handles PanelMenu.Paint

	End Sub

	Private Sub PanelContenedor_Paint(sender As Object, e As PaintEventArgs) Handles PanelContenedor.Paint

	End Sub

	Private Sub FormPrimerDiseno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

	End Sub

	Private Sub PanelTitulo_Paint(sender As Object, e As PaintEventArgs) Handles PanelTitulo.Paint

	End Sub
End Class
