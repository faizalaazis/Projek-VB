Imports System.Data.Odbc
Public Class Input_nil
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
        Dim sql As String = "insert into tbnilai values('" & tkode.Text & "','" & tpkn.Text & "','" & tpai.Text & "','" & tbi.Text & "','" & tbing.Text & "','" & tmat.Text & "','" & tjur.Text & "','" & trata.Text & "')"
        cmd = New OdbcCommand(sql, con)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Menyimpan data BERHASIL", vbInformation, "INFORMASI")
        Catch ex As Exception
            MsgBox("Menyimpan data GAGAL", vbInformation, "PERINGATAN")
        End Try
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        tkode.Text = ""
        tpkn.Text = ""
        tbi.Text = ""
        tbing.Text = ""
        tmat.Text = ""
        tjur.Text = ""
        trata.Text = ""
    End Sub



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        simpan()

    End Sub

    Private Sub tjur_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tjur.TextChanged
        Dim pkn As Integer
        Dim pai As Integer
        Dim bind As Integer
        Dim bing As Integer
        Dim mat As Integer
        Dim jur As Integer
        Dim rata As Single

        pkn = CInt(tpkn.Text)
        pai = CInt(tpai.Text)
        bind = CInt(tbi.Text)
        bing = CInt(tbing.Text)
        mat = CInt(tmat.Text)
        jur = CInt(tjur.Text)
        rata = CSng((pkn + pai + bind + bing + mat + jur) / 6)
        trata.Text = rata
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class