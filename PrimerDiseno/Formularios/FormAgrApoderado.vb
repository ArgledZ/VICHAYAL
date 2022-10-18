Imports CapaEntidades
Imports CapaNegocio
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Globalization

Public Class FormAgrApoderado
	Dim objNegocio As New cls_CNApoderado

	Dim objEntidades As New cls_CEApoderado
	Public ds As New DataSet


	Public cn As New SqlConnection(ConfigurationManager.ConnectionStrings("cnBDV").ConnectionString)

	Private Sub FormAgrApoderado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		cn.Open()
		Dim adt As New SqlDataAdapter("SELECT * FROM DEPARTAMENTO", cn)
		ds = New DataSet
		adt.Fill(ds, "Dep")
		CboDepartamento.DataSource = ds.Tables("Dep")
		CboDepartamento.DisplayMember = "DEPA_DESCRIPCION"
		CboDepartamento.ValueMember = "DEPARTAMENTO_ID"
	End Sub


	Private Sub CboDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboDepartamento.SelectionChangeCommitted
		Dim pos As New String("")
		pos = CboDepartamento.SelectedValue.ToString()
		Dim adt3 As New SqlDataAdapter("SELECT * FROM PROVINCIA WHERE PROV_DEPARTAMENTO =" & pos, cn)
		ds = New DataSet
		adt3.Fill(ds, "Pro2")
		CboProvincia.Enabled = True
		CboProvincia.DataSource = ds.Tables("Pro2")
		CboProvincia.DisplayMember = "PROV_DESCRIPCION"
		CboProvincia.ValueMember = "PROVINCIA_ID"
	End Sub

	Private Sub CboProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboProvincia.SelectionChangeCommitted
		Dim pos1 As New String("")
		pos1 = CboProvincia.SelectedValue.ToString()
		Dim adt2 As New SqlDataAdapter("SELECT * FROM DISTRITO WHERE DIST_PROVINCIA =" & pos1, cn)
		ds = New DataSet
		adt2.Fill(ds, "Dis")
		CboDistrito.Enabled = True
		CboDistrito.DataSource = ds.Tables("Dis")
		CboDistrito.DisplayMember = "DIST_DESCRIPCION"
		CboDistrito.ValueMember = "DISTRITO_ID"
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Me.Dispose()
	End Sub

	Private Sub btnRegApoderado_Click(sender As Object, e As EventArgs) Handles btnRegApoderado.Click
		objEntidades.APO_DNI = txtDni.Text
		objEntidades.APO_NOMBRES = txtNombres.Text
		objEntidades.APO_APELLIDOS = txtApellidos.Text
		objEntidades.APO_TELEFONO = TxtTelefono.Text
		objEntidades.APO_CORREO = txtCorreo.Text
		objEntidades.APO_DISTRITO = Me.CboDistrito.SelectedValue()
		objEntidades.APO_DIRECCION = txtDireccion.Text
		MsgBox("guardo Datos")
		'Envío a la Capa de Negocio para la inserción
		'MsgBox(objEntidades.EST_DISTRITO.ToString)
		'MsgBox(objNegocio.CN_RegistrarEstudiante(objEntidades))
		If (objNegocio.CN_RegistrarApoderado(objEntidades)) Then
			MessageBox.Show("Se registró correctamente")
		Else
			MessageBox.Show("registró incorrecto")
		End If
	End Sub

	Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

	End Sub
End Class