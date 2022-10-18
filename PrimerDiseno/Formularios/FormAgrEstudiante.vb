Imports CapaNegocio
Imports CapaEntidades
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Globalization

Public Class FormAgrEstudiante
	Dim objNegocio As New cls_CNEstudiante
	Dim objNegocioA As New cls_CNApoderado
	Dim ID_APo As New String("")

	Dim objEntidades As New cls_CEEstudiantes
	Public ds As New DataSet


	Public cn As New SqlConnection(ConfigurationManager.ConnectionStrings("cnBDV").ConnectionString)




	Private Sub FormAgrEstudiante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		cn.Open()
		Dim adt As New SqlDataAdapter("SELECT * FROM DEPARTAMENTO", cn)
		ds = New DataSet
		adt.Fill(ds, "Dep")
		CboDepartamento.DataSource = ds.Tables("Dep")
		CboDepartamento.DisplayMember = "DEPA_DESCRIPCION"
		CboDepartamento.ValueMember = "DEPARTAMENTO_ID"
		Me.DgvApoderado.DataSource = objNegocioA.CN_BuscarApoderado(TxbApoderado.Text)
		Me.DgvApoderado.Columns(0).Visible = False
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

	Private Sub TxbApoderado_TextChanged(sender As Object, e As EventArgs) Handles TxbApoderado.TextChanged
		Me.DgvApoderado.DataSource = objNegocioA.CN_BuscarApoderado(TxbApoderado.Text)
		Me.DgvApoderado.Columns(0).Visible = False
	End Sub

	Private Sub DgvApoderado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvApoderado.CellContentClick
		Dim var As New DataGridViewRow()
		var = Me.DgvApoderado.CurrentRow()
		ID_APo = var.Cells(0).Value.ToString()
		Me.txtApoN.Text = var.Cells(1).Value.ToString()
		Me.txtApoA.Text = var.Cells(2).Value.ToString()

	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Me.Dispose()
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

		Dim fecha As DateTime = DateTime.ParseExact(DtmEstudiante.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)
		objEntidades.EST_DNI = txtDni.Text
		objEntidades.EST_NOMBRES = txtNombres.Text
		objEntidades.EST_APELLIDOS = txtApellidos.Text
		objEntidades.EST_FECHA = fecha.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture)
		objEntidades.EST_DIRECCION = txtDireccion.Text
		objEntidades.EST_DISTRITO = Me.CboDistrito.SelectedValue()
		objEntidades.APODERADO_ID = ID_APo
		MsgBox("guardo Datos")
		'Envío a la Capa de Negocio para la inserción
		'MsgBox(objEntidades.EST_DISTRITO.ToString)
		'MsgBox(objNegocio.CN_RegistrarEstudiante(objEntidades))
		If (objNegocio.CN_RegistrarEstudiante(objEntidades)) Then
			MessageBox.Show("Se registró correctamente")
		Else
			MessageBox.Show("registró incorrecto")
		End If




	End Sub

	Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

	End Sub
End Class