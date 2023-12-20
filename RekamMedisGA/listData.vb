Option Explicit On
Option Strict On
Imports MySql.Data.MySqlClient

Public Class listData
    Public Property ID As String

    Private Sub listData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub loadData(Optional keyword As String = "")
        SQL = "SELECT * FROM tb_rekam_medis WHERE id_rekam=" & Me.ID & " ORDER BY nama ASC "

        Cmd = New MySqlCommand(SQL, Con)
        Cmd.Parameters.Clear()

    End Sub
End Class