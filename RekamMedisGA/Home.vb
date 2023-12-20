Public Class Home
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        lNama.Text = "Hello, " & My.Settings.nama
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lTgl.Text = Format(Now, "dd/MM/yyyy")
        lWaktu.Text = Format(Now, "HH:mm:ss")
    End Sub
    Private Sub DataDokterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataDokterToolStripMenuItem.Click
        DataDokter.Show()
    End Sub

    Private Sub DataPasienToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPasienToolStripMenuItem.Click
        DataPasien.Show()
    End Sub

    Private Sub RekamMedisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RekamMedisToolStripMenuItem.Click
        DataRekamMediss.Show()
    End Sub

    Private Sub PendaftaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PendaftaranToolStripMenuItem.Click
        FormPendaftaran.Show()
    End Sub

    Private Sub PemeriksaanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PemeriksaanToolStripMenuItem.Click
        FormPemeriksaan.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        FromLogin.Show()
    End Sub
End Class