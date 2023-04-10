Imports System.Data.SqlClient
Public Class frmBookingRoom
    Public Sub KondisiAwal()
        Call koneksi()
        str = "select * from Penghuni"
        da = New SqlDataAdapter(str, conn)
        ds = New DataSet
        da.Fill(ds, "Penghuni")
        DataGridView1.DataSource = ds.Tables("Penghuni")
        TextBox2.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.Text = "" Or TextBox2.Text = "" Or ComboBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox3.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Data Belum Lengkap!", vbCritical + vbOKOnly, "Error")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Then
            MsgBox("Data Belum Lengkap!", vbCritical + vbOKOnly, "Error")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox5.Text = "" Then
            MsgBox("Data Belum Lengkap!", vbCritical + vbOKOnly, "Error")
        End If
    End Sub

    Private Sub frmBookingRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        str = "select * from TipeKamar"
        cmd = New SqlCommand(str, conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            ComboBox1.Items.Add(dr.Item(1))
            ComboBox5.Items.Add(dr.Item(1))
        Loop
        dr.Close()
    End Sub
End Class