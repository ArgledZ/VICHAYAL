Imports CapaNegocio

Public Class FormApoderado
	Private objNegocio As New cls_CNApoderado


	Private Sub FormApoderado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		MostrarApoderado()

	End Sub

	Sub MostrarApoderado()
		Mostrar(objNegocio.CN_BuscarApoderadoGeneral(txtApoderado.Text))
	End Sub

	Private Sub Mostrar(var As DataTable)
		Me.DvgApoderado.DataSource = var
		Me.DvgApoderado.Columns(0).Visible = False
		Me.DvgApoderado.Columns(1).Visible = False
		Me.DvgApoderado.Columns(2).Visible = False
		Me.DvgApoderado.Columns(3).Visible = False
		Me.DvgApoderado.Columns(4).Visible = False
		Me.DvgApoderado.Columns(5).Visible = False
		Me.DvgApoderado.Columns(6).Visible = True
		Me.DvgApoderado.Columns(7).Visible = False
		Me.DvgApoderado.Columns(8).Width = 58
		Me.DvgApoderado.Columns(9).Width = 200



	End Sub


	Private Sub PanelBuscar_Paint(sender As Object, e As PaintEventArgs) Handles PanelBuscar.Paint

	End Sub

	Private Sub formularioModificar(FormModApoderado As FormModApoderado)
		FormModApoderado.TxtId.Text = DvgApoderado.CurrentRow.Cells(0).Value.ToString
		FormModApoderado.txtModDni.Text = DvgApoderado.CurrentRow.Cells(1).Value.ToString
		FormModApoderado.txtModNombres.Text = DvgApoderado.CurrentRow.Cells(2).Value.ToString
		FormModApoderado.txtModApellidos.Text = DvgApoderado.CurrentRow.Cells(3).Value.ToString
		FormModApoderado.TxtModTelefono.Text = DvgApoderado.CurrentRow.Cells(4).Value.ToString
		FormModApoderado.txtModCorreo.Text = DvgApoderado.CurrentRow.Cells(5).Value.ToString
		FormModApoderado.dist = DvgApoderado.CurrentRow.Cells(6).Value.ToString
		FormModApoderado.txtModDireccion.Text = DvgApoderado.CurrentRow.Cells(7).Value.ToString
	End Sub

	Private Sub btnModApoderado_Click(sender As Object, e As EventArgs) Handles btnModApoderado.Click
		Dim FormModApoderado As New FormModApoderado
		formularioModificar(FormModApoderado)
		FormModApoderado.ShowDialog()
	End Sub

	Private Sub btnAgrApoderado_Click(sender As Object, e As EventArgs) Handles btnAgrApoderado.Click
		Dim FormAgrApoderado As New FormAgrApoderado
		FormAgrApoderado.ShowDialog()
	End Sub

	Private Sub DvgApoderado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DvgApoderado.CellContentClick

	End Sub

	Private Sub Eliminar()
		If (objNegocio.CN_EliminarApoderado(DvgApoderado.CurrentRow.Cells(0).Value.ToString)) Then
			MessageBox.Show("Eliminado Correctamente")
			Mostrar(objNegocio.CN_BuscarApoderadoGeneral(""))
		Else
			MessageBox.Show("Datos no encontrados")
		End If
	End Sub

	Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
		Dim Pregunta As String

		Pregunta = MsgBox("Deseas Eliminar al Apoderado " & DvgApoderado.CurrentRow.Cells(9).Value.ToString & "?",
						  vbYesNo + vbQuestion, "Alerta de Eliminacion")
		If Pregunta = vbNo Then
		Else
			Eliminar()
		End If
	End Sub
End Class