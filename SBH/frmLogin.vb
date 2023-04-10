Imports System.Data.SqlClient
Public Class frmLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call koneksi()
        str = "select * from Karyawan where Password ='" & TextBox2.Text & "'"
        cmd = New SqlCommand(str, conn)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows = False Then
            MsgBox("Data Tidak Valid!", vbCritical + vbOKOnly, "Error")
        Else
            frmMain.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Focus()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        End
    End Sub
End Class
