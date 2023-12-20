<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(listData))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tKeluhan = New System.Windows.Forms.RichTextBox()
        Me.tDiagnosa = New System.Windows.Forms.RichTextBox()
        Me.tTindakan = New System.Windows.Forms.RichTextBox()
        Me.lPasien = New System.Windows.Forms.Label()
        Me.lTgl = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tAlamat = New System.Windows.Forms.RichTextBox()
        Me.rbObat = New System.Windows.Forms.RichTextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pasien :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(253, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal Lahir :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(483, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Alamat :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Keluhan :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(253, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Diagnosa :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(483, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tindakan :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 346)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Obat :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MintCream
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(-1, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 63)
        Me.Panel1.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bookman Old Style", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(275, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(231, 41)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Data Pasien"
        '
        'tKeluhan
        '
        Me.tKeluhan.Location = New System.Drawing.Point(12, 209)
        Me.tKeluhan.Name = "tKeluhan"
        Me.tKeluhan.ReadOnly = True
        Me.tKeluhan.Size = New System.Drawing.Size(195, 101)
        Me.tKeluhan.TabIndex = 8
        Me.tKeluhan.Text = ""
        '
        'tDiagnosa
        '
        Me.tDiagnosa.Location = New System.Drawing.Point(256, 209)
        Me.tDiagnosa.Name = "tDiagnosa"
        Me.tDiagnosa.ReadOnly = True
        Me.tDiagnosa.Size = New System.Drawing.Size(195, 101)
        Me.tDiagnosa.TabIndex = 9
        Me.tDiagnosa.Text = ""
        '
        'tTindakan
        '
        Me.tTindakan.Location = New System.Drawing.Point(486, 209)
        Me.tTindakan.Name = "tTindakan"
        Me.tTindakan.ReadOnly = True
        Me.tTindakan.Size = New System.Drawing.Size(195, 101)
        Me.tTindakan.TabIndex = 10
        Me.tTindakan.Text = ""
        '
        'lPasien
        '
        Me.lPasien.AutoSize = True
        Me.lPasien.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lPasien.Location = New System.Drawing.Point(12, 100)
        Me.lPasien.Name = "lPasien"
        Me.lPasien.Size = New System.Drawing.Size(48, 16)
        Me.lPasien.TabIndex = 12
        Me.lPasien.Text = "Label9"
        '
        'lTgl
        '
        Me.lTgl.AutoSize = True
        Me.lTgl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTgl.Location = New System.Drawing.Point(253, 100)
        Me.lTgl.Name = "lTgl"
        Me.lTgl.Size = New System.Drawing.Size(55, 16)
        Me.lTgl.TabIndex = 13
        Me.lTgl.Text = "Label10"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(463, 343)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(267, 147)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'tAlamat
        '
        Me.tAlamat.Location = New System.Drawing.Point(486, 93)
        Me.tAlamat.Name = "tAlamat"
        Me.tAlamat.ReadOnly = True
        Me.tAlamat.Size = New System.Drawing.Size(195, 71)
        Me.tAlamat.TabIndex = 17
        Me.tAlamat.Text = ""
        '
        'rbObat
        '
        Me.rbObat.Location = New System.Drawing.Point(12, 364)
        Me.rbObat.Name = "rbObat"
        Me.rbObat.ReadOnly = True
        Me.rbObat.Size = New System.Drawing.Size(195, 113)
        Me.rbObat.TabIndex = 18
        Me.rbObat.Text = ""
        '
        'listData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(742, 518)
        Me.Controls.Add(Me.rbObat)
        Me.Controls.Add(Me.tAlamat)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lTgl)
        Me.Controls.Add(Me.lPasien)
        Me.Controls.Add(Me.tTindakan)
        Me.Controls.Add(Me.tDiagnosa)
        Me.Controls.Add(Me.tKeluhan)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "listData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REKAM MEDIS PASIEN"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents tKeluhan As RichTextBox
    Friend WithEvents tDiagnosa As RichTextBox
    Friend WithEvents tTindakan As RichTextBox
    Friend WithEvents lPasien As Label
    Friend WithEvents lTgl As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tAlamat As RichTextBox
    Friend WithEvents rbObat As RichTextBox
End Class
