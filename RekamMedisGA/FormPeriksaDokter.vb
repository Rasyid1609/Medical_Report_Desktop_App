Option Explicit On
Option Strict On
Imports MySql.Data.MySqlClient

Public Class FormPeriksaDokter
    Public Property ID As String
    Private namaResep As String = ""


    Private Sub Execute(MySQL As String, Optional Parameter As String = "")
        Cmd = New MySqlCommand(MySQL, Con)
        AddParameters(Parameter)
        PerformCRUD(Cmd)
    End Sub

    Private Sub AddParameters(str As String)
        Cmd.Parameters.Clear()
        Cmd.Parameters.AddWithValue("@diagnosa", tDiagnosa.Text)
        Cmd.Parameters.AddWithValue("@keluhan", tKeluhan.Text)
        Cmd.Parameters.AddWithValue("@tindakan", tTindakan.Text)
        Cmd.Parameters.AddWithValue("@obat", tObat.Text)


        If str = "Update" Or str = "Delete" And Not String.IsNullOrEmpty(Me.ID) Then
            Cmd.Parameters.AddWithValue("@id_rekam", Me.ID)
        End If
    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        SQL = "UPDATE tb_rekam_medis SET status='tebus_obat',keluhan=@keluhan,diagnosa=@diagnosa, tindakan=@tindakan, obat=@obat  WHERE id_rekam= @id_rekam"
        Execute(SQL, "Update")

        MsgBox("Data Berhasil di Disimpan.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information,
                       "SUKSES")
        Me.Hide()
    End Sub


End Class