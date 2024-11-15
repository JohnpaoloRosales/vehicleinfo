﻿Imports MySql.Data.MySqlClient
Module Module1
    Public datacon As New MySqlConnection
    Dim server As String = "127.0.0.1"
    Dim dbasename As String = "cs2adbase"
    Dim username As String = "root"
    Dim password As String = "admin"

    Public Sub databaseConnect()
        If Not datacon Is Nothing Then
            datacon.Close()
            datacon.ConnectionString = "server=" &
                server & ";user id=" & username &
                ";password=" & password & ";database=" & dbasename & ""
            Try
                datacon.Open()
                MsgBox("database connected!")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub
End Module

