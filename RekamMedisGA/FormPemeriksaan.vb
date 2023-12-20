Option Explicit On
Option Strict On
Imports Microsoft.VisualBasic.Devices
Imports MySql.Data.MySqlClient

Public Class FormPemeriksaan
    Private ID As String = ""


    Private Sub FormPemeriksaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        resetMe()
        loadData()
        Timer1.Enabled = True
        lNama.Text = My.Settings.nama
    End Sub

    Private Sub resetMe()
        Me.ID = ""
        If cbStatus.Items.Count > 0 Then
            cbStatus.SelectedIndex = 0
        End If
    End Sub

    Private Sub Execute(MySQL As String, Optional Parameter As String = "")
        Cmd = New MySqlCommand(MySQL, Con)
        AddParamaters(Parameter)
        PerformCRUD(Cmd)
    End Sub

    Private Sub AddParamaters(str As String)
        Cmd.Parameters.Clear()
        Cmd.Parameters.AddWithValue("@status", cbStatus.SelectedItem.ToString())

        If str = "Update" Or str = "Delete" And Not String.IsNullOrEmpty(Me.ID) Then
            Cmd.Parameters.AddWithValue("@id_rekam", Me.ID)
        End If
    End Sub

    Private Sub loadData(Optional keyword As String = "")
        SQL = "SELECT tb_rekam_medis.id_rekam, tb_pasien.no_kartu,tb_pasien.nama, tb_rekam_medis.tanggal, tb_rekam_medis.status,tb_dokter.spesialis,tb_dokter.nama FROM tb_rekam_medis INNER JOIN tb_pasien ON tb_pasien.id_pasien=tb_rekam_medis.id_pasien INNER JOIN tb_dokter ON tb_dokter.id_dokter=tb_rekam_medis.id_dokter WHERE tb_rekam_medis.status=@status AND  tb_pasien.nama LIKE @keyword1 OR tb_pasien.no_kartu=@keyword2 OR tb_dokter.nama=@keyword3 OR tb_rekam_medis.keluhan=@keyword4 ORDER BY tb_rekam_medis.id_rekam ASC "
        Dim Keyword1 As String = String.Format("%{0}%", keyword)
        Dim sts As String = String.Format("{0}", "pemeriksaan")

        Cmd = New MySqlCommand(SQL, Con)
        Cmd.Parameters.Clear()
        Cmd.Parameters.AddWithValue("keyword1", Keyword1)
        Cmd.Parameters.AddWithValue("keyword2", Keyword1)
        Cmd.Parameters.AddWithValue("keyword3", Keyword1)
        Cmd.Parameters.AddWithValue("keyword4", Keyword1)
        Cmd.Parameters.AddWithValue("status", sts)

        Dim dt As DataTable = PerformCRUD(Cmd)

        With DataGridView1
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoGenerateColumns = True

            .DataSource = dt

            .Columns(0).HeaderText = "ID"
            .Columns(1).HeaderText = "No.Kartu"
            .Columns(2).HeaderText = "Pasien"
            .Columns(3).HeaderText = "Tanggal"
            .Columns(4).HeaderText = "Status"
            .Columns(5).HeaderText = "Spesialis"
            .Columns(6).HeaderText = "Dokter"

            .Columns(0).Width = 60
            .Columns(1).Width = 100
            .Columns(2).Width = 200
            .Columns(3).Width = 85
            .Columns(4).Width = 100
            .Columns(5).Width = 85
            .Columns(6).Width = 200
        End With
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim dgv As DataGridView = DataGridView1

            If e.RowIndex <> -1 Then
                Me.ID = Convert.ToString(dgv.CurrentRow.Cells(0).Value).Trim()

                SQL = "SELECT tb_rekam_medis.id_rekam as id_rekam, tb_pasien.id_pasien as id_pasien,tb_pasien.no_kartu as no_kartu,tb_pasien.nama as nm_pasien, tb_rekam_medis.tanggal as tanggal, tb_rekam_medis.status as status,tb_dokter.id_dokter as id_dokter,tb_dokter.spesialis as spesialis,tb_dokter.nama as nm_dokter FROM tb_rekam_medis INNER JOIN tb_pasien ON tb_pasien.id_pasien=tb_rekam_medis.id_pasien INNER JOIN tb_dokter ON tb_dokter.id_dokter=tb_rekam_medis.id_dokter  WHERE tb_rekam_medis.id_rekam = @keyword1 ORDER BY tb_rekam_medis.id_rekam ASC "
                Dim Keyword1 As String = String.Format("{0}", Me.ID)

                Cmd = New MySqlCommand(SQL, Con)
                Cmd.Parameters.Clear()
                Cmd.Parameters.AddWithValue("keyword1", Keyword1)
                Dim dt As DataTable = PerformCRUD(Cmd)
                lPasien.Text = dt.Rows(0).Item("no_kartu").ToString() & " - " & dt.Rows(0).Item("nm_pasien").ToString()
                lDokter.Text = dt.Rows(0).Item("spesialis").ToString() & " - " & dt.Rows(0).Item("nm_dokter").ToString()
                cbStatus.Text = dt.Rows(0).Item("status").ToString()

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPerbarui_Click(sender As Object, e As EventArgs) Handles btnPerbarui.Click
        If DataGridView1.Rows.Count = 0 Then
            Exit Sub
        End If
        If String.IsNullOrEmpty(Me.ID) Then
            MsgBox("Pilih salah satu item dari list.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation,
                   "PERINGATAN")
            Exit Sub
        End If

        SQL = "UPDATE tb_rekam_medis SET status=@status WHERE id_rekam= @id_rekam"
        Execute(SQL, "Update")
        MsgBox("Data Berhasil di Perbaharui.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information,
                       "SUKSES")
        loadData()
        resetMe()
    End Sub

    Private Sub btnPeriksa_Click(sender As Object, e As EventArgs) Handles btnPeriksa.Click
        If String.IsNullOrEmpty(Me.ID) Then
            MsgBox("Pilih salah satu item dari list.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation,
                   "PERINGATAN")
            Exit Sub
        End If
        Dim OBJ As New FormPeriksaDokter
        OBJ.lPasien.Text = lPasien.Text
        OBJ.ID = Me.ID.ToString()
        OBJ.Show()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        loadData()
        resetMe()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lTanggal.Text = Format(Now, "dd/MM/yyyy")
        lWaktu.Text = Format(Now, "HH:mm:ss")
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If DataGridView1.Rows.Count = 0 Then
            Exit Sub
        End If
        If String.IsNullOrEmpty(Me.ID) Then
            MsgBox("Pilih salah satu item dari list.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation,
                   "PERINGATAN")
        Else
            If MessageBox.Show("Apa kamu akan menghapus data ini? ", "PERINGATAN",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                SQL = "Delete from tb_rekam_medis WHERE id_rekam= @id_rekam"
                Execute(SQL, "Delete")
                MsgBox("Data berhasil di hapus", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information,
                       "PERINGATAN")
                loadData()
                resetMe()
            End If

        End If
    End Sub
End Class