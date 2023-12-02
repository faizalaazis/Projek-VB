<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NilaiSiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NilaiSiswaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputMapelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MataPelajaranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CetakToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CetakDataSiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CetakRaportSiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CetakMapelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.InputMapelToolStripMenuItem, Me.CetakToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(677, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NilaiSiswaToolStripMenuItem, Me.NilaiSiswaToolStripMenuItem1})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(79, 20)
        Me.ToolStripMenuItem1.Text = "Inout Siswa"
        '
        'NilaiSiswaToolStripMenuItem
        '
        Me.NilaiSiswaToolStripMenuItem.Name = "NilaiSiswaToolStripMenuItem"
        Me.NilaiSiswaToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.NilaiSiswaToolStripMenuItem.Text = "Data Siswa"
        '
        'NilaiSiswaToolStripMenuItem1
        '
        Me.NilaiSiswaToolStripMenuItem1.Name = "NilaiSiswaToolStripMenuItem1"
        Me.NilaiSiswaToolStripMenuItem1.Size = New System.Drawing.Size(168, 22)
        Me.NilaiSiswaToolStripMenuItem1.Text = "Nilai Raport Siswa"
        '
        'InputMapelToolStripMenuItem
        '
        Me.InputMapelToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MataPelajaranToolStripMenuItem})
        Me.InputMapelToolStripMenuItem.Name = "InputMapelToolStripMenuItem"
        Me.InputMapelToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.InputMapelToolStripMenuItem.Text = "Input Mapel"
        '
        'MataPelajaranToolStripMenuItem
        '
        Me.MataPelajaranToolStripMenuItem.Name = "MataPelajaranToolStripMenuItem"
        Me.MataPelajaranToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MataPelajaranToolStripMenuItem.Text = "Mata Pelajaran"
        '
        'CetakToolStripMenuItem
        '
        Me.CetakToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CetakDataSiswaToolStripMenuItem, Me.CetakRaportSiswaToolStripMenuItem, Me.CetakMapelToolStripMenuItem})
        Me.CetakToolStripMenuItem.Name = "CetakToolStripMenuItem"
        Me.CetakToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.CetakToolStripMenuItem.Text = "Cetak"
        '
        'CetakDataSiswaToolStripMenuItem
        '
        Me.CetakDataSiswaToolStripMenuItem.Name = "CetakDataSiswaToolStripMenuItem"
        Me.CetakDataSiswaToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.CetakDataSiswaToolStripMenuItem.Text = "Cetak Data Siswa"
        '
        'CetakRaportSiswaToolStripMenuItem
        '
        Me.CetakRaportSiswaToolStripMenuItem.Name = "CetakRaportSiswaToolStripMenuItem"
        Me.CetakRaportSiswaToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.CetakRaportSiswaToolStripMenuItem.Text = "Cetak Raport Siswa"
        '
        'CetakMapelToolStripMenuItem
        '
        Me.CetakMapelToolStripMenuItem.Name = "CetakMapelToolStripMenuItem"
        Me.CetakMapelToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.CetakMapelToolStripMenuItem.Text = "Cetak Mapel"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(677, 441)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Menu Utama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NilaiSiswaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NilaiSiswaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InputMapelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MataPelajaranToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CetakToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CetakDataSiswaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CetakRaportSiswaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CetakMapelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
