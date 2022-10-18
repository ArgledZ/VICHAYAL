Imports CapaDatos
Imports CapaEntidades
Public Class cls_CNEstudiante
	Private objDatos As New cls_CDEstudiante
	Public Function CN_ListarClientes() As DataTable
		Return objDatos.CD_ListarClientes
	End Function

	Public Function CN_RegistrarEstudiante(CEDatos As cls_CEEstudiantes) As Boolean

		Return objDatos.CD_RegistrarEstudiantes(CEDatos.EST_DNI, CEDatos.EST_NOMBRES, CEDatos.EST_APELLIDOS,
												CEDatos.EST_FECHA, CEDatos.EST_DISTRITO, CEDatos.EST_DIRECCION,
												CEDatos.APODERADO_ID)
	End Function

	Public Function CN_ModificarEstudiante(CEDatos As cls_CEEstudiantes) As Boolean
		Return objDatos.CD_ModificarEstudiantes(CEDatos.EST_DNI, CEDatos.EST_NOMBRES, CEDatos.EST_APELLIDOS,
												CEDatos.EST_FECHA, CEDatos.EST_DISTRITO, CEDatos.EST_DIRECCION,
												CEDatos.ESTUDIANTE_ID)
	End Function


	Public Function CN_BuscarEstudiante(ByVal texto As String) As DataTable
		Return objDatos.CD_BuscarEstudiante(texto)
	End Function

	Public Function CN_EliminarEstudiante(ID_Est As String) As Boolean
		Return objDatos.CD_EliminarEstudiante(ID_Est)
	End Function



End Class
