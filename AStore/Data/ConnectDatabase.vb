Imports System.Data.SqlClient
Imports System
Public Class ConnectDatabase

    Private ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" _
                                       & "E:\Visual Basic\Project 1\AStore\AStore\Data\AppData.mdf;Integrated Security=True"
    Private Connection As SqlConnection
    Private Query As String
    Private MyCmd As SqlCommand
    Public SqlReader As SqlDataReader

    Public Sub New(Optional query As String = "")
        Me.Connection = New SqlConnection(ConnectionString)
        Me.Query = query
    End Sub

    Public Sub ExecuteCmd()
        If Query <> "" Then
            Connection.Open()
            MyCmd = New SqlCommand(Query, Connection)
            MyCmd.ExecuteNonQuery()
        End If
        Connection.Close()
    End Sub

    Public Sub ReadExecuteCmd()
        If Query <> "" Then
            Connection.Open()
            MyCmd = New SqlCommand(Query, Connection)
            SqlReader = MyCmd.ExecuteReader()
        End If
    End Sub

    Public Sub DeleteExecuteCmd()
        If Query <> "" Then
            Connection.Open()
            MyCmd = New SqlCommand(Query, Connection)
            MyCmd.ExecuteNonQuery()
        End If
        CloseConnection()
    End Sub

    Public Sub CloseConnection()
        Connection.Close()
    End Sub

End Class
