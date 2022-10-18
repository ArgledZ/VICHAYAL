Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Globalization
Imports CapaEntidades
Imports CapaNegocio

Public Class FormModApoderado
	Dim objNegocio As New cls_CNApoderado
	Public dist As Integer
	Dim depa As Integer
	Dim prov As Integer
	Dim objEntidades As New cls_CEApoderado
	Public ds As New DataSet
	Public cn As New SqlConnection(ConfigurationManager.ConnectionStrings("cnBDV").ConnectionString)


	Private Sub btnModApoderado_Click(sender As Object, e As EventArgs) Handles btnModApoderado.Click
		objEntidades.APODERADO_ID = TxtId.Text
		objEntidades.APO_DNI = txtModDni.Text
		objEntidades.APO_NOMBRES = txtModNombres.Text
		objEntidades.APO_APELLIDOS = txtModApellidos.Text
		objEntidades.APO_DIRECCION = txtModDireccion.Text
		objEntidades.APO_TELEFONO = TxtModTelefono.Text
		objEntidades.APO_CORREO = txtModCorreo.Text
		objEntidades.APO_DISTRITO = Me.CboModDistrito.SelectedValue()
		'Envío a la Capa de Negocio para la inserción
		'MsgBox(objNegocio.CN_ModificarApoderado(objEntidades))
		If (objNegocio.CN_ModificarApoderado(objEntidades)) Then
			MessageBox.Show("Se Modifico correctamente")
			Me.Close()
		Else
			MessageBox.Show("Error al Modificar")
		End If
	End Sub

	Private Sub FormModApoderado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		CargarDistProvDep()
		CargarDepartamento()
		CboModDepartamento.SelectedValue = depa
		CargarProvincia()
		CboModProvincia.SelectedValue = prov
		CargarDistrito()
		CboModDistrito.SelectedValue = dist
		TxtId.Enabled = False
	End Sub

	Private Sub CargarDistrito()
		Dim pos1 As New String("")
		pos1 = CboModProvincia.SelectedValue.ToString()
		Dim adt2 As New SqlDataAdapter("SELECT * FROM DISTRITO WHERE DIST_PROVINCIA =" & pos1, cn)
		ds = New DataSet
		adt2.Fill(ds, "Dis")
		CboModDistrito.Enabled = True
		CboModDistrito.DataSource = ds.Tables("Dis")
		CboModDistrito.DisplayMember = "DIST_DESCRIPCION"
		CboModDistrito.ValueMember = "DISTRITO_ID"
	End Sub
	Private Sub CargarProvincia()
		Dim pos As New String("")
		pos = CboModDepartamento.SelectedValue.ToString()
		Dim adt3 As New SqlDataAdapter("SELECT * FROM PROVINCIA WHERE PROV_DEPARTAMENTO =" & pos, cn)
		ds = New DataSet
		adt3.Fill(ds, "ProM")
		CboModProvincia.Enabled = True
		CboModProvincia.DataSource = ds.Tables("ProM")
		CboModProvincia.DisplayMember = "PROV_DESCRIPCION"
		CboModProvincia.ValueMember = "PROVINCIA_ID"
	End Sub
	Private Sub CargarDepartamento()
		cn.Open()
		Dim adt As New SqlDataAdapter("SELECT * FROM DEPARTAMENTO", cn)
		ds = New DataSet
		adt.Fill(ds, "Dep")
		CboModDepartamento.DataSource = ds.Tables("Dep")
		CboModDepartamento.DisplayMember = "DEPA_DESCRIPCION"
		CboModDepartamento.ValueMember = "DEPARTAMENTO_ID"
	End Sub

	Private Sub CargarDistProvDep()
		cn.Open()
		Dim sql As New SqlCommand("SP_DATOSDISPRODEP", cn)
		sql.CommandType = CommandType.StoredProcedure
		sql.Parameters.AddWithValue("@texto", dist)

		Dim dt As New DataTable
		Dim da As New SqlDataAdapter(sql)
		da.Fill(dt)
		depa = dt.Rows(0).Item(4).ToString()
		prov = dt.Rows(0).Item(2).ToString()
		cn.Close()
	End Sub

	Private Sub CboModDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs)
		CargarProvincia()
		CargarDistrito()
	End Sub

	Private Sub CboModProvincia_SelectedIndexChanged(sender As Object, e As EventArgs)
		CargarDistrito()
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Me.Dispose()
	End Sub
End Class