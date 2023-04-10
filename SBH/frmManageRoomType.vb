Imports System.Data.SqlClient
Public Class frmManageRoomType

    Public Sub KondisiAwal()
        Call koneksi()
        str = "select * from TipeKamar"
        da = New SqlDataAdapter(str, conn)
        ds = New DataSet
        da.Fill(ds, "TipeKamar")
        DataGridView1.DataSource = ds.Tables("TipeKamar")
        Call Kosongkan()
        TextBox2.Focus()
    End Sub

    Public Sub Kosongkan()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Public Sub Ketemu()
        Try
            str = "select * from TipeKamar where IDTipeKamar='" & TextBox1.Text & "'"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader()
            dr.Read()
            If dr.HasRows Then
                TextBox2.Text = dr.Item(1)
                TextBox3.Text = dr.Item(2)
            Else
                MsgBox("Data Tidak Ada!", vbCritical + vbOKOnly, "Error")
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("Data Tidak Ada!", vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub frmManageRoomType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call koneksi()
        If TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Data Belum Lengkap!", vbCritical + vbOKOnly, "Error")
        Else
            str = "insert into TipeKamar values(" &
                  "'" & TextBox2.Text & "'," &
                  "'" & TextBox3.Text & "')"
            cmd = New SqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Disimpan")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call koneksi()
        If TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Data Belum Lengkap", vbCritical + vbOKOnly, "Error")
        Else
            Try
                str = "update TipeKamar set NamaTipeKamar='" & TextBox2.Text & "', Deskripsi='" & TextBox3.Text & "' where IDTipeKamar = '" & TextBox1.Text & "'"
                cmd = New SqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Diedit")
                Call KondisiAwal()
            Catch ex As Exception
                MsgBox("Data Tidak Ada!", vbCritical + vbOKOnly, "Error")
            End Try

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call koneksi()
        If TextBox1.Text = "" Then
            MsgBox("Masukan ID yang akan Dihapus", vbCritical + vbOKOnly, "Error")
        Else
            Try
                str = "delete TipeKamar where IDTipeKamar ='" & TextBox1.Text & "'"
                cmd = New SqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Dihapus")
                Call KondisiAwal()
            Catch ex As Exception
                MsgBox("Data Tidak Ada!", vbCritical + vbOKOnly, "Error")
            End Try
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Call Kosongkan()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Ketemu()
        End If
    End Sub
End Class