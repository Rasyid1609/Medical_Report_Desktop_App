<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPeriksaDokter
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lPasien = New System.Windows.Forms.Label()
        Me.tKeluhan = New System.Windows.Forms.RichTextBox()
        Me.tDiagnosa = New System.Windows.Forms.RichTextBox()
        Me.tTindakan = New System.Windows.Forms.RichTextBox()
        Me.btnSelesai = New System.Windows.Forms.Button()
        Me.tObat = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pasien :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Keluhan :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Diagnosa :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 329)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tindakan :"
        '
        'lPasien
        '
        Me.lPasien.AutoSize = True
        Me.lPasien.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lPasien.Location = New System.Drawing.Point(12, 27)
        Me.lPasien.Name = "lPasien"
        Me.lPasien.Size = New System.Drawing.Size(77, 15)
        Me.lPasien.TabIndex = 4
        Me.lPasien.Text = "namaPasien"
        '
        'tKeluhan
        '
        Me.tKeluhan.Location = New System.Drawing.Point(12, 84)
        Me.tKeluhan.Name = "tKeluhan"
        Me.tKeluhan.Size = New System.Drawing.Size(470, 99)
        Me.tKeluhan.TabIndex = 5
        Me.tKeluhan.Text = ""
        '
        'tDiagnosa
        '
        Me.tDiagnosa.Location = New System.Drawing.Point(12, 215)
        Me.tDiagnosa.Name = "tDiagnosa"
        Me.tDiagnosa.Size = New System.Drawing.Size(470, 99)
        Me.tDiagnosa.TabIndex = 6
        Me.tDiagnosa.Text = ""
        '
        'tTindakan
        '
        Me.tTindakan.Location = New System.Drawing.Point(12, 347)
        Me.tTindakan.Name = "tTindakan"
        Me.tTindakan.Size = New System.Drawing.Size(470, 99)
        Me.tTindakan.TabIndex = 7
        Me.tTindakan.Text = ""
        '
        'btnSelesai
        '
        Me.btnSelesai.BackColor = System.Drawing.Color.SeaGreen
        Me.btnSelesai.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSelesai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelesai.ForeColor = System.Drawing.Color.White
        Me.btnSelesai.Location = New System.Drawing.Point(196, 598)
        Me.btnSelesai.Name = "btnSelesai"
        Me.btnSelesai.Size = New System.Drawing.Size(106, 37)
        Me.btnSelesai.TabIndex = 8
        Me.btnSelesai.Text = "SELESAI"
        Me.btnSelesai.UseVisualStyleBackColor = False
        '
        'tObat
        '
        Me.tObat.Location = New System.Drawing.Point(12, 483)
        Me.tObat.Name = "tObat"
        Me.tObat.Size = New System.Drawing.Size(470, 99)
        Me.tObat.TabIndex = 10
        Me.tObat.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 465)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Obat :"
        '
        'FormPeriksaDokter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(494, 647)
        Me.Controls.Add(Me.tObat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnSelesai)
        Me.Controls.Add(Me.tTindakan)
        Me.Controls.Add(Me.tDiagnosa)
        Me.Controls.Add(Me.tKeluhan)
        Me.Controls.Add(Me.lPasien)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "FormPeriksaDokter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FORM PERIKSA DOKTER"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lPasien As Label
    Friend WithEvents tKeluhan As RichTextBox
    Friend WithEvents tDiagnosa As RichTextBox
    Friend WithEvents tTindakan As RichTextBox
    Friend WithEvents btnSelesai As Button
    Friend WithEvents tObat As RichTextBox
    Friend WithEvents Label5 As Label
End Class
