Imports System.Data.SqlClient
Public Class frmManageRoomRepairment
    Public Sub KondisiAwal()
        Call koneksi()
        str = "select * from Kamar + PerbaikanKamar"
        da = New SqlDataAdapter(str, conn)
        ds = New DataSet
        da.Fill(ds, "Kamar")
        DataGridView1.DataSource = ds.Tables("Kamar")
        Kosongkan()
    End Sub

    Public Sub Kosongkan()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub frmManageRoomRepairment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        str = "select * from Kamar"
        cmd = New SqlCommand(str, conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            ComboBox1.Items.Add(dr.Item(1))
        Loop
        dr.Close()
    End Sub
End Class