Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports CapaEntidades

Public Class cls_CDApoderado
	Public cn As New SqlConnection(ConfigurationManager.ConnectionStrings("cnBDV").ConnectionString)
	Public ds As New DataSet

	Public Function CD_BuscarApoderados(ByVal texto As String) As DataTable
		Dim sql As New SqlCommand("SP_BuscarApoderado", cn)
		sql.CommandType = CommandType.StoredProcedure
		sql.Parameters.AddWithValue("@texto", texto)

		Dim dt As New DataTable
		Dim da As New SqlDataAdapter(sql)
		da.Fill(dt)
		Return dt

	End Function


	Public Function CD_BuscarApoderadoGeneral(ByVal texto As String) As DataTable
		Dim sql As New SqlCommand("SP_BuscarApoderadoGeneral", cn)
		sql.CommandType = CommandType.StoredProcedure
		sql.Parameters.AddWithValue("@texto", texto)

		Dim dt As New DataTable
		Dim da As New SqlDataAdapter(sql)
		da.Fill(dt)
		Return dt
	End Function


	Public Function CD_RegistrarApoderado(APO_DNI As String,
	APO_NOMBRES As String, APO_APELLIDOS As String, APO_TELEFONO As String, APO_CORREO As String,
	APO_DISTRITO As String, APO_DIRECCION As String) As Boolean
		Dim sql As New SqlCommand("SP_REGISTRAR_APODERADO", cn)
		cn.Open()
		Try
			sql.CommandType = CommandType.StoredProcedure
			sql.Parameters.AddWithValue("@APO_DNI", APO_DNI)
			sql.Parameters.AddWithValue("@APO_NOMBRES", APO_NOMBRES)
			sql.Parameters.AddWithValue("@APO_APELLIDOS", APO_APELLIDOS)
			sql.Parameters.AddWithValue("@APO_TELEFONO", APO_TELEFONO)
			sql.Parameters.AddWithValue("@APO_CORREO", APO_CORREO)
			sql.Parameters.AddWithValue("@APO_DISTRITO", APO_DISTRITO)
			sql.Parameters.AddWithValue("@APO_DIRECCION", APO_DIRECCION)
			sql.ExecuteNonQuery()
			cn.Close()
			Return True
		Catch ex As Exception
			Return False
		End Try
	End Function

	Public Function CD_ModificarApoderado(APO_DNI As String,
	APO_NOMBRES As String, APO_APELLIDOS As String, APO_TELEFONO As String,
	APO_CORREO As String, APO_DISTRITO As String,
	APO_DIRECCION As String, APODERADO_ID As String) As Boolean
		Dim sql As New SqlCommand("SP_MODIFICAR_APODERADO", cn)
		cn.Open()
		Try
			sql.CommandType = CommandType.StoredProcedure
			sql.Parameters.AddWithValue("@APO_DNI", APO_DNI)
			sql.Parameters.AddWithValue("@APO_NOMBRES", APO_NOMBRES)
			sql.Parameters.AddWithValue("@APO_APELLIDOS", APO_APELLIDOS)
			sql.Parameters.AddWithValue("@APO_TELEFONO", APO_TELEFONO)
			sql.Parameters.AddWithValue("@APO_CORREO", APO_CORREO)
			sql.Parameters.AddWithValue("@APO_DISTRITO", APO_DISTRITO)
			sql.Parameters.AddWithValue("@APO_DIRECCION", APO_DIRECCION)
			sql.Parameters.AddWithValue("@APODERADO_ID", APODERADO_ID)
			sql.ExecuteNonQuery()
			cn.Close()
			Return True
		Catch ex As Exception
			Return False
		End Try
	End Function

	Public Function CD_EliminarApoderado(APO_ID As String) As Boolean
		Dim sql As New SqlCommand("SP_ELIMINAR_APODERADO", cn)
		cn.Open()
		Try
			sql.CommandType = CommandType.StoredProcedure
			sql.Parameters.AddWithValue("@APO_ID", APO_ID)
			sql.ExecuteNonQuery()
			cn.Close()
			Return True
		Catch ex As Exception
			Return False
		End Try
	End Function

End Class
