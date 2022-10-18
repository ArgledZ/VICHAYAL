Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports CapaNegocio
Public Class FormEstudiante
	Private objNegocio As New cls_CNEstudiante

	Private Sub FormEstudiante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		MostrarEstudiantes()
		TextBox1_LostFocus(sender, e)

	End Sub

	Sub MostrarEstudiantes()
		Mostrar(objNegocio.CN_BuscarEstudiante(txtEstudiante.Text))
	End Sub


	Private Sub btnAgrEstudiante_Click(sender As Object, e As EventArgs) Handles btnAgrEstudiante.Click
		Dim FormAgrEstudiante As New FormAgrEstudiante
		FormAgrEstudiante.ShowDialog()
	End Sub

	Private Sub btnModEstudiante_Click(sender As Object, e As EventArgs) Handles btnModEstudiante.Click
		Dim FormModEstudiante As New FormModEstudiante
		formularioModificar(FormModEstudiante)
		FormModEstudiante.ShowDialog()


	End Sub

	Private Sub TextBox1_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEstudiante.Enter
		If txtEstudiante.Text = "Buscar Estudiante" Then
			txtEstudiante.Text = ""
		End If
	End Sub
	Private Sub TextBox1_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEstudiante.Leave
		If txtEstudiante.Text = "" Then
			txtEstudiante.ForeColor = Color.Gray
			txtEstudiante.Text = "Buscar Estudiante"
		End If
	End Sub

	Private Sub txtEstudiante_TextChanged(sender As Object, e As EventArgs) Handles txtEstudiante.TextChanged
		If txtEstudiante.Text = "Buscar Estudiante" Then
		Else
			Mostrar(objNegocio.CN_BuscarEstudiante(txtEstudiante.Text))
		End If
	End Sub


	Private Sub Mostrar(var As DataTable)
		Me.DvgEstudiante.DataSource = var
		Me.DvgEstudiante.Columns(0).Visible = False
		Me.DvgEstudiante.Columns(1).Visible = False
		Me.DvgEstudiante.Columns(2).Visible = False
		Me.DvgEstudiante.Columns(3).Visible = False
		Me.DvgEstudiante.Columns(4).Visible = False
		Me.DvgEstudiante.Columns(5).Visible = False
		Me.DvgEstudiante.Columns(6).Visible = False
		Me.DvgEstudiante.Columns(7).Visible = False
		Me.DvgEstudiante.Columns(8).Visible = False
		Me.DvgEstudiante.Columns(9).Width = 58
		Me.DvgEstudiante.Columns(10).Width = 180
		Me.DvgEstudiante.Columns(11).Width = 40


	End Sub

	Private Sub DvgEstudiante_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DvgEstudiante.CellContentClick

	End Sub

	Private Sub formularioModificar(FormModEstudiante As FormModEstudiante)
		FormModEstudiante.TxtId.Text = DvgEstudiante.CurrentRow.Cells(0).Value.ToString
		FormModEstudiante.txtModDni.Text = DvgEstudiante.CurrentRow.Cells(1).Value.ToString
		FormModEstudiante.txtModNombres.Text = DvgEstudiante.CurrentRow.Cells(2).Value.ToString
		FormModEstudiante.txtModApellidos.Text = DvgEstudiante.CurrentRow.Cells(3).Value.ToString
		FormModEstudiante.DtmModEstudiante.Text = DvgEstudiante.CurrentRow.Cells(4).Value.ToString
		FormModEstudiante.txtModDireccion.Text = DvgEstudiante.CurrentRow.Cells(6).Value.ToString
		FormModEstudiante.dist = DvgEstudiante.CurrentRow.Cells(5).Value.ToString
	End Sub

	Private Sub PanelBuscar_Paint(sender As Object, e As PaintEventArgs) Handles PanelBuscar.Paint

	End Sub
	Private Sub Eliminar()
		If (objNegocio.CN_EliminarEstudiante(DvgEstudiante.CurrentRow.Cells(0).Value.ToString)) Then
			MessageBox.Show("Eliminado Correctamente")
			Mostrar(objNegocio.CN_BuscarEstudiante(""))
		Else
			MessageBox.Show("Datos no encontrados")
		End If
	End Sub
	Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
		Dim Pregunta As String

		Pregunta = MsgBox("Deseas Eliminar al Estudiante " & DvgEstudiante.CurrentRow.Cells(10).Value.ToString & "?",
						  vbYesNo + vbQuestion, "Alerta de Eliminacion")
		If Pregunta = vbNo Then

		Else
			Eliminar()
		End If
	End Sub


End Class