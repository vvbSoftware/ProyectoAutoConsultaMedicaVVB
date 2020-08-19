﻿Imports DataAccess

Public Class Medico
    Inherits Persona
    Property _numMed As Integer
    Property _especialidad As String
    Property _lugarTrabajo As String
    Property _contraseña As String

#Region "Constructores"

    Public Sub New()
    End Sub

    Public Sub New(ci As String)
        MyBase.New(ci)
    End Sub

    Public Sub New(ci As String, contraseña As String)
        MyBase.New(ci)
        _contraseña = contraseña
    End Sub

    Public Sub New(ci As String, tel_cel As Integer, edad As Integer,
                   domicilio As String, sexo As String, sNom As String,
                   pNom As String, pApe As String, sApe As String, especialidad As String, lugarTrabajo As String, contraseña As String)

        MyBase.New(ci, tel_cel, edad, domicilio, sexo, pNom, pApe, sNom, sApe)
        _especialidad = especialidad
        _lugarTrabajo = lugarTrabajo
        _contraseña = contraseña
    End Sub

#End Region

#Region "Metodos"

    Public Overloads Function Listar() As DataTable
        Dim consu As New DBMedicos()
        Return consu.ObtenerMedicos()
    End Function

    Public Overloads Function Guardar() As Boolean
        Dim consu As New DBMedicos()
        Return consu.SetMedico(Me._ci, Me._especialidad, Me._numMed, Me._contraseña,
                   Me._tel_cel, Me._edad, Me._domicilio,
                   Me._sexo, Me._pNom, Me._sNom, Me._pApe, Me._sApe)
    End Function

    Public Overloads Function Modificar() As Boolean
        Dim consu As New DBMedicos()
        Return consu.ModifMedico(Me._ci, Me._especialidad, Me._numMed)
    End Function

    Public Overloads Function Borrar(ci As String) As Boolean
        Dim consu As New DBMedicos()
        Return consu.BorarMedico(ci)
    End Function

    Public Function AceptarChat(ciP As String, idDIag As String)
        Dim consu As New DBMedicos()
        Return consu.AceptarChat(Me._ci, ciP, idDIag)
    End Function

    Public Function ComprobarSoli() As DataTable
        Dim cons As New DBChat
        Return cons.ComprobarSolicitudes()
    End Function

#End Region

End Class