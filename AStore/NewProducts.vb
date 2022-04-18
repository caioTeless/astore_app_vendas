Imports System.Data.SqlClient

Public Class NewProducts

    Public ConnectDatabase As ConnectDatabase
    'Private MyReader As SqlDataReader
    'Private results As String
    Private Id As Integer
    Private Produto As String
    Private Descricao As String
    Private ValorUnitario As Double
    Public Sub New(Optional id As Integer = 0, Optional produto As String = "", Optional descricao As String = "", Optional valorUnitario As Double = 0)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Id = id
        Me.Produto = produto
        Me.Descricao = descricao
        Me.ValorUnitario = valorUnitario

    End Sub

    Private Sub btn_saveProduct_Click(sender As Object, e As EventArgs) Handles btn_saveProduct.Click
        Dim query As String
        If Id <> 0 Then
            query = "UPDATE Product SET [Produto] = '" & txt_productName.Text & "', [Descricao] = '" & txt_description.Text & "', [ValorUnitario] = '" _
            & Double.Parse(txt_unitValue.Text) & "' WHERE [Id] = '" & Id & "';"
        Else
            query = "INSERT INTO Product([Produto], [Descricao], [ValorUnitario]) VALUES ('" & txt_productName.Text & "','" _
            & txt_description.Text & "','" & Double.Parse(txt_unitValue.Text) & "');"
        End If
        ConnectDatabase = New ConnectDatabase(query)
        ConnectDatabase.ExecuteCmd()
    End Sub
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Products.dataProduct.Rows.Clear()
        Products.Load_Data()
        Me.Close()
    End Sub

    Private Sub NewProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Produto <> "" And Descricao <> "" And ValorUnitario <> 0 Then
            txt_productName.Text = Produto
            txt_description.Text = Descricao
            txt_unitValue.Text = ValorUnitario
            lbl_products.Text = "EDITAR PRODUTOS"
        End If
    End Sub
End Class