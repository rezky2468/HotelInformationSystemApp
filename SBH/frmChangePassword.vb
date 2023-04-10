Imports System.Data.SqlClient
Public Class frmChangePassword


    Private Sub frmChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call koneksi()
        If TextBox3.Text = TextBox4.Text Then
            str = "select * from Karyawan where Password ='" & TextBox2.Text & "'"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader()
            dr.Read()
            cmd.Dispose()
            If dr.HasRows Then
                cmd = New SqlCommand("update Karyawan set Password ='" & TextBox3.Text & "' where Email='" & TextBox1.Text & "'", conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Diedit")
            End If
        Else
            MsgBox("Password Tidak Sama!", vbCritical + vbOKOnly, "Error")
        End If
    End Sub
End Class