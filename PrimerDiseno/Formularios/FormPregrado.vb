Imports CapaNegocio
Public Class FormPregrado
	Private objNegocio As New cls_CNEstudiante
	Private Sub FormPregrado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		MostrarClientes()
	End Sub
	Sub MostrarClientes()
		Dim dt As DataTable = objNegocio.CN_ListarClientes
		Me.DGVListaClientes.DataSource = dt
	End Sub

	Private Sub btnAgrCliente_Click(sender As Object, e As EventArgs) Handles btnAgrCliente.Click
		Dim FormAgrCliente As New FormAgrEstudiante
		FormAgrCliente.ShowDialog()
		MostrarClientes()

	End Sub

	Private Sub PanelResult_Paint(sender As Object, e As PaintEventArgs) Handles PanelResult.Paint

	End Sub
End Class