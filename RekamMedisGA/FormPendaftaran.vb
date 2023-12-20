Option Explicit On
Option Strict On
Imports Microsoft.VisualBasic.Devices
Imports MySql.Data.MySqlClient
Public Class FormPendaftaran
    Private ID As String = ""

    Private Sub FormPendaftaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        resetMe()
        onnLoad()
        loadData()
        Timer1.Enabled = True
        lNama.Text = My.Settings.nama
    End Sub

    Private Sub onnLoad()
        Dim SQLpasien As String = "SELECT * FROM tb_pasien "
        Dim SQLdokter As String = "SELECT * FROM tb_dokter "
        Dim Cmdpasien As MySqlCommand
        Dim Cmddoker As MySqlCommand

        Cmdpasien = New MySqlCommand(SQLpasien, Con)
        Dim dataPasien As DataTable = PerformCRUD(Cmdpasien)

        Cmddoker = New MySqlCommand(SQLdokter, Con)
        Dim dataDokter As DataTable = PerformCRUD(Cmddoker)

        If dataPasien.Rows.Count > 0 Then
            With cbPasien
                .Items.Clear()

                For i As Integer = 0 To dataPasien.Rows.Count - 1
                    .Items.Add(dataPasien.Rows(i).Item("no_kartu").ToString() & " - " & dataPasien.Rows(i).Item("nama").ToString() & " - " & dataPasien.Rows(i).Item("id_pasien").ToString())
                Next
            End With
        End If

        If dataDokter.Rows.Count > 0 Then

            With cbDokter
                .Items.Clear()

                For i As Integer = 0 To dataDokter.Rows.Count - 1
                    .Items.Add(dataDokter.Rows(i).Item("spesialis").ToString() & " - " & dataDokter.Rows(i).Item("nama").ToString() & " - " & dataDokter.Rows(i).Item("id_dokter").ToString())

                Next
                .SelectedIndex = 0
            End With
        End If
    End Sub


    Private Sub resetMe()
        Me.ID = ""

        If cbPasien.Items.Count > 0 Then
            cbPasien.SelectedIndex = 0
        End If
        If cbDokter.Items.Count > 0 Then
            cbDokter.SelectedIndex = 0
        End If
        If cbStatus.Items.Count > 0 Then
            cbStatus.SelectedIndex = 0
        End If
    End Sub

    Private Sub loadData(Optional keyword As String = "")
        SQL = "SELECT * FROM tb_pasien WHERE nama LIKE @keyword1 OR no_kartu = @keyword2 OR umur = @keyword3 ORDER BY id_pasien ASC "
        Dim strKeyword As String = String.Format("%{0}%", keyword)
        Dim spesialisKeyword As String = String.Format("%{0}%", keyword)

        Cmd = New MySqlCommand(SQL, Con)
        Cmd.Parameters.Clear()
        Cmd.Parameters.AddWithValue("keyword1", strKeyword)
        Cmd.Parameters.AddWithValue("keyword2", keyword)
        Cmd.Parameters.AddWithValue("keyword3", spesialisKeyword)

        Dim dt As DataTable = PerformCRUD(Cmd)

        With DataGridView1
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoGenerateColumns = True

            .DataSource = dt

            .Columns(0).HeaderText = "ID"
            .Columns(1).HeaderText = "Nomor Kartu"
            .Columns(2).HeaderText = "Nama"
            .Columns(3).HeaderText = "Tanggal Lahir"
            .Columns(4).HeaderText = "Umur"
            .Columns(5).HeaderText = "Jenis Kelamin"
            .Columns(6).HeaderText = "No Handphone"
            .Columns(7).HeaderText = "Alamat"

            .Columns(0).Width = 60
            .Columns(1).Width = 150
            .Columns(2).Width = 150
            .Columns(3).Width = 150
            .Columns(4).Width = 85
            .Columns(5).Width = 150
            .Columns(6).Width = 100
            .Columns(7).Width = 180


        End With
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim dgv As DataGridView = DataGridView1
            If e.RowIndex <> 1 Then
                Me.ID = Convert.ToString(dgv.CurrentRow.Cells(0).Value).Trim


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        SQL = "Insert into tb_rekam_medis(id_pasien,id_dokter,tanggal,status) VALUES(@id_pasien,@id_dokter,@tanggal,@status)"
        Execute(SQL, "Insert")
            MsgBox("Berhasil Menyimpan DATA.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information,
                       "SUKSES")
            loadData()
            resetMe()

    End Sub

    Private Sub Execute(MySQL As String, Optional Parameter As String = "")
        Cmd = New MySqlCommand(MySQL, Con)
        AddParameters(Parameter)
        PerformCRUD(Cmd)
    End Sub

    Private Sub AddParameters(str As String)
        Dim p(), d() As String
        p = Split(cbPasien.SelectedItem.ToString(), "-")
        d = Split(cbDokter.SelectedItem.ToString(), "-")

        Cmd.Parameters.Clear()
        Cmd.Parameters.AddWithValue("@id_pasien", p(2).ToString())
        Cmd.Parameters.AddWithValue("@id_dokter", d(2).ToString())
        Cmd.Parameters.AddWithValue("@status", cbStatus.SelectedItem.ToString())
        Cmd.Parameters.AddWithValue("@tanggal", dtTanggal.Value.ToString("yyyy-M-d"))

        If str = "Update" Or str = "Delete" And Not String.IsNullOrEmpty(Me.ID) Then
            Cmd.Parameters.AddWithValue("@id_rekam", Me.ID)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lTanggal.Text = Format(Now, "dd/MM/yyyy")
        lWaktu.Text = Format(Now, "HH:mm:ss")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If Not String.IsNullOrEmpty(tCari.Text.Trim()) Then
            loadData(tCari.Text.Trim())
        Else
            loadData()
        End If

        resetMe()
    End Sub
End Class