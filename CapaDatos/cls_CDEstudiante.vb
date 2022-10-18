Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports CapaEntidades
Public Class cls_CDEstudiante
	Public cn As New SqlConnection(ConfigurationManager.ConnectionStrings("cnBDV").ConnectionString)
	Public ds As New DataSet




	Public Function CD_ListarClientes() As DataTable
		Dim dt As New DataTable
		Dim da As New SqlDataAdapter("sp_listarEstudiantes", cn)
		da.SelectCommand.CommandType = CommandType.StoredProcedure
		da.Fill(dt)
		Return dt

	End Function

	Public Function CD_BuscarEstudiante(ByVal texto As String) As DataTable
		Dim sql As New SqlCommand("SP_BuscarEstudiante", cn)
		sql.CommandType = CommandType.StoredProcedure
		sql.Parameters.AddWithValue("@texto", texto)

		Dim dt As New DataTable
		Dim da As New SqlDataAdapter(sql)
		da.Fill(dt)
		Return dt

	End Function

	'Insertar datos del cliente
	Public Function CD_RegistrarEstudiantes(EST_DNI As String,
	EST_NOMBRES As String, EST_APELLIDOS As String, EST_FECHA As String, EST_DISTRITO As String,
	EST_DIRECCION As String, APODERADO_ID As String) As Boolean
		Dim sql As New SqlCommand("SP_REGISTRAR_ESTUDIANTE", cn)
		cn.Open()
		Try
			sql.CommandType = CommandType.StoredProcedure
			sql.Parameters.AddWithValue("@EST_DNI", EST_DNI)
			sql.Parameters.AddWithValue("@EST_NOMBRES", EST_NOMBRES)
			sql.Parameters.AddWithValue("@EST_APELLIDOS", EST_APELLIDOS)
			sql.Parameters.AddWithValue("@EST_FECHA", EST_FECHA)
			sql.Parameters.AddWithValue("@EST_DISTRITO", EST_DISTRITO)
			sql.Parameters.AddWithValue("@EST_DIRECCION", EST_DIRECCION)
			sql.Parameters.AddWithValue("@APODERADO_ID", APODERADO_ID)
			sql.ExecuteNonQuery()
			cn.Close()
			Return True
		Catch ex As Exception
			Return False
		End Try
	End Function


	Public Function CD_ModificarEstudiantes(EST_DNI As String,
	EST_NOMBRES As String, EST_APELLIDOS As String, EST_FECHA As String, EST_DISTRITO As String,
	EST_DIRECCION As String, ESTUDIANTE_ID As String) As Boolean
		Dim sql As New SqlCommand("SP_MODIFICAR_ESTUDIANTE", cn)
		cn.Open()
		Try
			sql.CommandType = CommandType.StoredProcedure
			sql.Parameters.AddWithValue("@EST_DNI", EST_DNI)
			sql.Parameters.AddWithValue("@EST_NOMBRES", EST_NOMBRES)
			sql.Parameters.AddWithValue("@EST_APELLIDOS", EST_APELLIDOS)
			sql.Parameters.AddWithValue("@EST_FECHA", EST_FECHA)
			sql.Parameters.AddWithValue("@EST_DISTRITO", EST_DISTRITO)
			sql.Parameters.AddWithValue("@EST_DIRECCION", EST_DIRECCION)
			sql.Parameters.AddWithValue("@ESTUDIANTE_ID", ESTUDIANTE_ID)
			sql.ExecuteNonQuery()
			cn.Close()
			Return True
		Catch ex As Exception
			Return False
		End Try
	End Function

	Public Function CD_EliminarEstudiante(EST_ID As String) As Boolean
		Dim sql As New SqlCommand("SP_ELIMINAR_ESTUDIANTE", cn)
		cn.Open()
		Try
			sql.CommandType = CommandType.StoredProcedure
			sql.Parameters.AddWithValue("@EST_ID", EST_ID)
			sql.ExecuteNonQuery()
			cn.Close()
			Return True
		Catch ex As Exception
			Return False
		End Try
	End Function

End Class
