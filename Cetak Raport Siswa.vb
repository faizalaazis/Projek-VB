Imports System.Data.Odbc

Public Class Cetak_Raport_Siswa
    Dim con As OdbcConnection
    Dim dr As OdbcDataReader
    Dim da As OdbcDataAdapter
    Dim ds As DataSet
    Dim dt As DataTable
    Dim cmd As OdbcCommand
    Sub koneksi()
        con = New OdbcConnection
        con.ConnectionString = "dsn=dbraport_siswa"
        con.Open()

    End Sub
    Sub tampil()
        DataGridView1.Rows.Clear()
        Try
            koneksi()
            da = New OdbcDataAdapter("select *from tbsiswa order by nis asc", con)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                DataGridView1.Rows.Add(row(0), row(1), row(2), row(3))
            Next
            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan data GAGAL")
        End Try
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        tampil()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim a As String = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        If a = "" Then
            MsgBox("Data Nilai yang akan dihapus belum DIPILIH")
        Else
            If (MessageBox.Show("Anda yakin menghapus data dengan kode_nilai =" & a & "...?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK) Then
                koneksi()
                cmd = New OdbcCommand("delete from tbnilai where kode_nilai ='" & a & "'", con)
                cmd.ExecuteNonQuery()
                MsgBox("Menghapus data nilai BERHASIL", vbInformation, "INFORMASI")
                con.Close()
                tampil()
            End If
        End If

    End Sub

End Class