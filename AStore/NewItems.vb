Imports System.Collections.Generic
Public Class NewItems

    Private ConnectDatabase As ConnectDatabase
    Private ProductList As New List(Of Data)
    Private ClientList As New List(Of Data)

    Private Sub cmb_product_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_product.SelectedIndexChanged
    End Sub

    Private Sub NewItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim queryProduct = "SELECT [Id], [Produto] FROM Product"
        Dim queryClient = "SELECT [Id], [Nome] FROM Client"

        ConnectDatabase = New ConnectDatabase(queryProduct)
        ConnectDatabase.ReadExecuteCmd()
        Do While ConnectDatabase.SqlReader.Read()
            ProductList.Add(New Data(ConnectDatabase.SqlReader.GetValue(0), ConnectDatabase.SqlReader.GetValue(1)))
        Loop

        cmb_product.ValueMember = "Id"
        cmb_product.DisplayMember = "Name"
        cmb_product.DataSource = ProductList

        ConnectDatabase = New ConnectDatabase(queryClient)
        ConnectDatabase.ReadExecuteCmd()

        Do While ConnectDatabase.SqlReader.Read()
            ClientList.Add(New Data(ConnectDatabase.SqlReader.GetValue(0), ConnectDatabase.SqlReader.GetValue(1)))
        Loop

        cmb_client.ValueMember = "Id"
        cmb_client.DisplayMember = "Name"
        cmb_client.DataSource = ClientList

    End Sub


    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Dim productId = CType(cmb_product.SelectedValue, Data).Id
        Dim clientId = CType(cmb_client.SelectedValue, Data).Id
        Dim query As String
        query = "INSERT INTO ItemData(idClient, IdProduct, Quantity) VALUES ('" _
            & clientId & "','" & productId & "','" &
         txt_quantity.Text & "');"
        ConnectDatabase = New ConnectDatabase(query)
        ConnectDatabase.ExecuteCmd()
        ConnectDatabase.CloseConnection()
    End Sub
End Class