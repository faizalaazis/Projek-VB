Imports System.Data.Odbc

Public Class Input_Data_Siswa
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
    Sub simpan()
        koneksi()
        Dim sql As String = "insert into tbsiswa values('" & tnis.Text & "','" & tnama.Text & "','" & tkelas.Text & "')"
        cmd = New OdbcCommand(sql, con)

        Try
            MsgBox("Menyimpan data BERHASIL", vbInformation, "INFORMASI")
        Catch ex As Exception
            MsgBox("Menyimpan data GAGAL", vbInformation, "PERINGATAN")
        End Try
    End Sub

    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tnis.Text = ""
        tnama.Text = ""
        tkelas.Text = ""
        twali.Text = ""
    End Sub

    

    

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

  

    

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        simpan()

    End Sub
End Class