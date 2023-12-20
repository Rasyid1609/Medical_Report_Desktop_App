Option Explicit On
Option Strict On

Imports MySql.Data.MySqlClient

Public Class DataPasien
    Private ID As String = ""

    Private Sub DataPasien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        resetMe()
        loadData()
        tmr.Enabled = True
        lNama.Text = My.Settings.nama
    End Sub

    Private Sub resetMe()
        Me.ID = ""

        tNama.Text = ""
        tAlamat.Text = ""
        tNoKartu.Text = ""
        tNoHp.Text = ""
        tUmur.Text = ""

        If cbGender.Items.Count > 0 Then
            cbGender.SelectedIndex = 0
        End If

    End Sub

    Private Sub Execute(MySQL As String, Optional Parameter As String = "")

        Cmd = New MySqlCommand(MySQL, Con)
        AddParameters(Parameter)
        PerformCRUD(Cmd)
    End Sub

    Private Sub AddParameters(str As String)
        Cmd.Parameters.Clear()
        Cmd.Parameters.AddWithValue("@no_kartu", tNoKartu.Text.Trim())
        Cmd.Parameters.AddWithValue("@nama", tNama.Text.Trim())
        Cmd.Parameters.AddWithValue("@tgl", dtTanggal.Value.ToString("yyyy-M-d"))
        Cmd.Parameters.AddWithValue("@umur", tUmur.Text.Trim())
        Cmd.Parameters.AddWithValue("@jk", cbGender.SelectedItem.ToString())
        Cmd.Parameters.AddWithValue("@no_hp", tNoHp.Text.Trim())
        Cmd.Parameters.AddWithValue("@alamat", tAlamat.Text.Trim())

        If str = "Update" Or str = "Delete" And Not String.IsNullOrEmpty(Me.ID) Then
            Cmd.Parameters.AddWithValue("@id_pasien", Me.ID)
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

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If String.IsNullOrEmpty(tNama.Text.Trim()) Or String.IsNullOrEmpty(tNoKartu.Text.Trim()) Or String.IsNullOrEmpty(tUmur.Text.Trim()) Or String.IsNullOrEmpty(tNoHp.Text.Trim()) Or String.IsNullOrEmpty(tAlamat.Text.Trim()) Then
            MsgBox("Tolong isi dulu isianya", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation,
                   "Peringatan")
        Else
            SQL = "Insert into tb_pasien(nama,no_kartu,jk,umur, alamat, no_hp, tgl) VALUES(@nama, @no_kartu, @jk, @umur, @alamat, @no_hp, @tgl)"
            Execute(SQL, "Insert")
            MsgBox("Berhasil Menyimpan DATA.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information,
                       "SUKSES")
            loadData()
            resetMe()
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim dgv As DataGridView = DataGridView1
            If e.RowIndex <> 1 Then
                Me.ID = Convert.ToString(dgv.CurrentRow.Cells(0).Value).Trim

                tNoKartu.Text = Convert.ToString(dgv.CurrentRow.Cells(1).Value).Trim
                tNama.Text = Convert.ToString(dgv.CurrentRow.Cells(2).Value).Trim
                dtTanggal.Value = CDate(Convert.ToString(dgv.CurrentRow.Cells(3).Value).Trim)
                tUmur.Text = Convert.ToString(dgv.CurrentRow.Cells(4).Value).Trim
                cbGender.SelectedItem = Convert.ToString(dgv.CurrentRow.Cells(5).Value).Trim
                tNoHp.Text = Convert.ToString(dgv.CurrentRow.Cells(6).Value).Trim
                tAlamat.Text = Convert.ToString(dgv.CurrentRow.Cells(7).Value).Trim
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
        If String.IsNullOrEmpty(tNoKartu.Text.Trim()) Or String.IsNullOrEmpty(tNama.Text.Trim()) Or String.IsNullOrEmpty(tUmur.Text.Trim()) Or String.IsNullOrEmpty(tNoHp.Text.Trim()) Or String.IsNullOrEmpty(tAlamat.Text.Trim()) Then
            MsgBox("Tolong diisi yang kosong!!!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation,
                    "PERINGATAN")
        Else
            SQL = "UPDATE tb_pasien set no_kartu = @no_kartu, nama = @nama, tgl = @tgl, umur = @umur, jk = @jk, no_hp = no_hp, alamat = @alamat WHERE id_pasien = @id_pasien"
            Execute(SQL, "Update")
            MsgBox("Data Berhasil di Perbaharui.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information,
                       "SUKSES")
            loadData()
            resetMe()
        End If
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
                SQL = "Delete from tb_pasien WHERE id_pasien= @id_pasien"
                Execute(SQL, "Delete")
                MsgBox("Data berhasil di hapus", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information,
                       "PERINGATAN")
                loadData()
                resetMe()
            End If

        End If
    End Sub

    Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick
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