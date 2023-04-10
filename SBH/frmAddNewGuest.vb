Imports System.Data.SqlClient
Public Class frmAddNewGuest
    Public Sub Kosongkan()
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        ComboBox1.Text = ""
    End Sub

    Private Sub frmAddNewGuest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        str = "select * from TipeKendaraan"
        cmd = New SqlCommand(str, conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            ComboBox1.Items.Add(dr.Item(0))
        Loop
        dr.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call koneksi()
        If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Data Belum Lengkap!", vbCritical + vbOKOnly, "Error")
        Else
            str = "insert into Penghuni values(" &
                  "'" & TextBox2.Text & "'," &
                  "'" & TextBox3.Text & "'," &
                  "'" & TextBox4.Text & "'," &
                  "'" & TextBox5.Text & "'," &
                  "'" & TextBox6.Text & "'," &
                  "'" & ComboBox1.Text & "')"
            cmd = New SqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Disimpan")
            Me.Close()
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        End
    End Sub
End Class