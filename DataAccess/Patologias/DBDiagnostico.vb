﻿Imports MySql.Data.MySqlClient

Public Class DBDiagnostico
    Inherits ConexionBD

    Public Function Diagnostico(ci As String) As DataTable
        Dim _consultaSQL As String = "SELECT nomEnf as DIAGNOSTICO FROM define E, selec S
                                      WHERE E.nomSint=S.nomSint AND idPac='" & ci & "' and dia=CURDATE() AND
                                      hora BETWEEN CURTIME()-1
                                      AND CURTIME()+1 GROUP BY nomEnf;"
        Return DevolverTabla(_consultaSQL)
    End Function

    Public Function GuardarDiagnostico(ci As String, enfermedades As String) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New MySqlCommand()
                command.Connection = connection
                command.CommandText = "INSERT INTO diagnostico(idDiag,idP,nomE,fecha) VALUES(null,@idP,@nomE,CURDATE());"
                command.Parameters.AddWithValue("@idP", ci)
                command.Parameters.AddWithValue("@nomE", enfermedades)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
                Return True
            End Using
        End Using
    End Function

    Public Function VerDiagnostico(ci As String) As DataTable
        Return DevolverTabla("SELECT nomE Diagnostico,fecha FROM diagnostico WHERE idP='" & ci & "'")
    End Function

    Public Function VerDiagnosticoFecha(ci As String, fecha As String) As DataTable
        Return DevolverTabla("SELECT nomE Diagnostico,fecha FROM diagnostico WHERE idP='" & ci & "' AND fecha='" & fecha & "'")
    End Function

    Public Function VerDiagnosticoEntreFecha(ci As String, fecha As String, fecha2 As String) As DataTable
        Return DevolverTabla("SELECT nomE Diagnostico,fecha FROM diagnostico WHERE idP='" & ci & "' AND fecha >'" & fecha & "' AND fecha <'" & fecha2 & "'")
    End Function

End Class