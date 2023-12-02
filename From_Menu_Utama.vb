Public Class Form1

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub NilaiSiswaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NilaiSiswaToolStripMenuItem.Click
        Input_Data_Siswa.ShowDialog()

    End Sub

    

    Private Sub NilaiSiswaToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NilaiSiswaToolStripMenuItem2.Click
        Input_nil.ShowDialog()
    End Sub

    

    
    
    Private Sub CetakRaportSiswaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CetakRaportSiswaToolStripMenuItem.Click
        Cetak_Raport_Siswa.ShowDialog()

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class
