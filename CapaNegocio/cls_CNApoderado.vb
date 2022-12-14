Imports CapaDatos
Imports CapaEntidades

Public Class cls_CNApoderado

	Private objDatos As New cls_CDApoderado
	Public Function CN_BuscarApoderado(ByVal texto As String) As DataTable
		Return objDatos.CD_BuscarApoderados(texto)
	End Function

	Public Function CN_BuscarApoderadoGeneral(ByVal texto As String) As DataTable
		Return objDatos.CD_BuscarApoderadoGeneral(texto)
	End Function


	Public Function CN_RegistrarApoderado(CEDatos As cls_CEApoderado) As Boolean
		Return objDatos.CD_RegistrarApoderado(CEDatos.APO_DNI, CEDatos.APO_NOMBRES, CEDatos.APO_APELLIDOS,
												CEDatos.APO_TELEFONO, CEDatos.APO_CORREO, CEDatos.APO_DISTRITO,
												CEDatos.APO_DIRECCION)
	End Function
	Public Function CN_ModificarApoderado(CEDatos As cls_CEApoderado) As Boolean
		Return objDatos.CD_ModificarApoderado(CEDatos.APO_DNI, CEDatos.APO_NOMBRES, CEDatos.APO_APELLIDOS,
												CEDatos.APO_TELEFONO, CEDatos.APO_CORREO, CEDatos.APO_DISTRITO,
												CEDatos.APO_DIRECCION, CEDatos.APODERADO_ID)
	End Function

	Public Function CN_EliminarApoderado(ID_Apo As String) As Boolean
		Return objDatos.CD_EliminarApoderado(ID_Apo)
	End Function
End Class
