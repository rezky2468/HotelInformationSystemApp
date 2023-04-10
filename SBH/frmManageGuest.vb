Imports System.Data.SqlClient

Public Class frmManageGuest
    Public Sub KondisiAwal()
        Call koneksi()
        str = "select * from Penghuni"
        da = New SqlDataAdapter(str, conn)
        ds = New DataSet
        da.Fill(ds, "Penghuni")
        DataGridView1.DataSource = ds.Tables("Penghuni")
        Kosongkan()
        TextBox2.Focus()
    End Sub

    Public Sub Kosongkan()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        ComboBox1.Text = ""
    End Sub

    Public Sub Ketemu()
        Try
            str = "select * from Penghuni where IDPenghuni='" & TextBox1.Text & "'"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader()
            dr.Read()
            If dr.HasRows Then
                'da = New SqlDataAdapter(str, conn)
                'ds = New DataSet
                'da.Fill(ds, "Penghuni")
                TextBox2.Text = dr.Item(1)
                TextBox3.Text = dr.Item(2)
                TextBox4.Text = dr.Item(3)
                TextBox5.Text = dr.Item(4)
                TextBox6.Text = dr.Item(5)
                ComboBox1.Text = dr.Item(6)
            Else
                MsgBox("Data Tidak Ada!", vbCritical + vbOKOnly, "Error")
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("Data Tidak Ada!", vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub frmManageGuest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        str = "select * from TipeKendaraan"
        cmd = New SqlCommand(str, conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            ComboBox1.Items.Add(dr.Item(0))
        Loop
        dr.Close()
        'str = "select * from TipeKendaraan"
        'cmd = New SqlCommand(str, conn)
        'dr = cmd.ExecuteReader()
        'dr.Read()
        'If dr.HasRows Then
        '    Call koneksi()
        '    str = "select * from TipeKendaraan"
        '    da = New SqlDataAdapter(str, conn)
        '    ds = New DataSet
        '    da.Fill(ds, "TipeKendaraan")
        'End If
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
            Call KondisiAwal()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call koneksi()
        If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Data Belum Lengkap!", vbCritical + vbOKOnly, "Error")
        Else
            Try
                str = "update Penghuni set NamaPenghuni='" & TextBox2.Text & "', NomorKTP='" & TextBox3.Text & "', Email='" & TextBox4.Text & "', NomorHP='" & TextBox5.Text & "', PlatNoKendaraan='" & TextBox6.Text & "',IDTipeKendaraan='" & ComboBox1.Text & "' where IDPenghuni = '" & TextBox1.Text & "'"
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
            MsgBox("Masukan ID yang akan dihapus!", vbCritical + vbOKOnly, "Error")
        Else
            Try
                'If MessageBox("Anda Yakin Akan Menghapus Data?", "Konfirmasi", MessageBoxButtons.YesNo) = MessageBox.forms.dialogresult.yes Then

                'End If
                str = "delete Penghuni where IDPenghuni ='" & TextBox1.Text & "'"
                cmd = New SqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Dihapus")
                Call KondisiAwal()
            Catch ex As Exception
                MsgBox("Data Tidak Ada!", vbCritical + vbOKOnly, "Error")
            End Try
        End If
    End Sub

    'Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    '    str = "select * from Penghuni where NamaPenghuni like '%" & TextBox7.Text & "%'"
    '    cmd = New SqlCommand(str, conn)
    '    dr = cmd.ExecuteReader()
    '    dr.Read()
    '    If dr.HasRows Then
    '        da = New SqlDataAdapter(str, conn)
    '        ds = New DataSet
    '        da.Fill(ds, "Penghuni")
    '        DataGridView1.DataSource = ds.Tables("Penghuni")
    '    Else
    '        MsgBox("Data Tidak Ada!", vbCritical + vbOKOnly, "Error")
    '    End If
    '    dr.Close()
    'End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Call Kosongkan()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Ketemu()
        End If
    End Sub
End Class