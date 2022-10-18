Imports CapaEntidades
Imports CapaNegocio
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Globalization

Public Class FormModEstudiante
	Dim objNegocio As New cls_CNEstudiante
	Public dist As Integer
	Dim depa As Integer
	Dim prov As Integer
	Dim objEntidades As New cls_CEEstudiantes
	Public ds As New DataSet
	Public cn As New SqlConnection(ConfigurationManager.ConnectionStrings("cnBDV").ConnectionString)

	Private Sub FormModEstudiante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		CargarDistProvDep()
		CargarDepartamento()
		CboModDepartamento.SelectedValue = depa
		CargarProvincia()
		CboModProvincia.SelectedValue = prov
		CargarDistrito()
		CboModDistrito.SelectedValue = dist
		TxtId.Enabled = False
	End Sub

	Private Sub CboModDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboModDepartamento.SelectionChangeCommitted
		CargarProvincia()
		CargarDistrito()
	End Sub

	Private Sub CboModProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboModProvincia.SelectionChangeCommitted
		CargarDistrito()
	End Sub

	Private Sub btnModEstudiante_Click(sender As Object, e As EventArgs) Handles btnModEstudiante.Click

		Dim fecha As DateTime = DateTime.ParseExact(DtmModEstudiante.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)
		objEntidades.ESTUDIANTE_ID = TxtId.Text
		objEntidades.EST_DNI = txtModDni.Text
		objEntidades.EST_NOMBRES = txtModNombres.Text
		objEntidades.EST_APELLIDOS = txtModApellidos.Text
		objEntidades.EST_FECHA = fecha.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture)
		objEntidades.EST_DIRECCION = txtModDireccion.Text
		objEntidades.EST_DISTRITO = Me.CboModDistrito.SelectedValue()
		'Envío a la Capa de Negocio para la inserción
		'MsgBox(objNegocio.CN_ModificarEstudiante(objEntidades))
		If (objNegocio.CN_ModificarEstudiante(objEntidades)) Then
			MessageBox.Show("Se Modifico correctamente")
			Me.Close()
		Else
			MessageBox.Show("Error al Modificar")
		End If


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

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Me.Dispose()
	End Sub
End Class