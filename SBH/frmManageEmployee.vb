Imports System.Data.SqlClient


Public Class frmManageEmployee
    Public Sub KondisiAwal()
        Call koneksi()
        str = "select * from Karyawan"
        da = New SqlDataAdapter(str, conn)
        ds = New DataSet
        da.Fill(ds, "Karyawan")
        DataGridView1.DataSource = ds.Tables("Karyawan")
        Call Kosongkan()
        TextBox2.Focus()
    End Sub

    Public Sub Kosongkan()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
    End Sub

    Public Sub Ketemu()
        Try
            str = "select * from Karyawan where IDKaryawan='" & TextBox1.Text & "'"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader()
            dr.Read()
            If dr.HasRows Then
                TextBox2.Text = dr.Item(1)
                TextBox3.Text = dr.Item(2)
                TextBox4.Text = dr.Item(3)
                DateTimePicker1.Text = dr.Item(4)
            Else
                MsgBox("Data Tidak Ada!", vbCritical + vbOKOnly, "Error")
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("Data Tidak Ada!", vbCritical + vbOKOnly, "Error")
        End Try

    End Sub
    Private Sub frmManageEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call koneksi()
        Dim gender As String
        If RadioButton1.Checked = True Then
            gender = RadioButton1.Text
        ElseIf RadioButton2.Checked = True Then
            gender = RadioButton2.Text
        End If
        If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Data Belum Lengkap!", vbCritical + vbOKOnly, "Error")
        Else
            str = "insert into Karyawan values(" &
            "'" & TextBox2.Text & "'," &
            "'" & TextBox3.Text & "'," &
            "'" & TextBox4.Text & "'," &
            "'" & DateTimePicker1.Text & "'," &
            "'" & gender & "')"
            cmd = New SqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Disimpan")
            Call KondisiAwal()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call koneksi()
        Dim gender As String
        If RadioButton1.Checked = True Then
            gender = RadioButton1.Text
        ElseIf RadioButton2.Checked = True Then
            gender = RadioButton2.Text
        End If
        If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Data Belum Lengkap!", vbCritical + vbOKOnly, "Error")
        Else
            Try
                str = "update Karyawan set NamaKaryawan='" & TextBox2.Text & "', Email='" & TextBox3.Text & "', Password='" & TextBox4.Text & "', TglLahir='" & DateTimePicker1.Text & "', JenisKelamin='" & gender & "'where IDKaryawan = '" & TextBox1.Text & "'"
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
            MsgBox("Masukan ID yang akan dihapus", vbCritical + vbOKOnly, "Error")
        Else
            Try
                str = "delete Karyawan where IDKaryawan = '" & TextBox1.Text & "'"
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

    'Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
    '    str = "select * from Karyawan where IDKaryawan like '%" & TextBox5.Text & "%'"
    '    cmd = New SqlCommand(str, conn)
    '    dr = cmd.ExecuteReader()
    '    dr.Read()
    '    If dr.HasRows Then
    '        da = New SqlDataAdapter(str, conn)
    '        ds = New DataSet
    '        da.Fill(ds, "Karyawan")
    '        DataGridView1.DataSource = ds.Tables("Karyawan")
    '    Else
    '        MsgBox("Data Tidak Ada!", vbCritical + vbOKOnly, "Error")
    '    End If
    '    dr.Close()
    'End Sub
End Class