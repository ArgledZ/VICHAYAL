Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Public Class clsConexion
	Public cn As New SqlConnection(ConfigurationManager.ConnectionStrings("cnBDS").ConnectionString)
	Public Sub conectar()
		Try
			cn.Open()
			MessageBox.Show("CONECTADO")
		Catch ex As Exception
			MessageBox.Show("CONECTADO")
		Finally
			cn.Close()

		End Try
	End Sub

End Class
