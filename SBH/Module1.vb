Imports System.Data.Sql
Imports System.Data.SqlClient

Module Module1
    Public cmd As SqlCommand
    Public conn As New SqlConnection
    Public da As SqlDataAdapter
    Public dr As SqlDataReader
    Public ds As DataSet
    Public dt As DataTable
    Public str As String

    Public Sub koneksi()
        str = "data source=DESKTOP-4GBHIRJ\BPPI; initial catalog=tes;integrated security=true"
        conn = New SqlConnection(str)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
