Public Class Products

    Public ConnectDataBase As ConnectDatabase
    Private NewProducts As NewProducts


    Private Sub pn_title_products_Paint(sender As Object, e As PaintEventArgs) Handles pn_title_products.Paint
        lbl_products.Left = (lbl_products.Parent.Width / 2) - (lbl_products.Width / 2)
        lbl_products.Top = (lbl_products.Parent.Height / 2) - (lbl_products.Height / 2)
    End Sub

    Private Sub btn_newRegister_Click(sender As Object, e As EventArgs) Handles btn_newRegister.Click
        NewProducts = New NewProducts()
        NewProducts.Show()
    End Sub

    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        Me.Close()
        Home.Show()
    End Sub


    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim checkBox As New DataGridViewCheckBoxColumn()
        checkBox.HeaderText = "Selecionar"
        checkBox.Name = "checkProduct"
        Me.dataProduct.Columns.Insert(0, checkBox)
        Load_Data()
    End Sub

    Public Sub Load_Data()

        Dim query = "SELECT [Id], [Produto], [Descricao], [ValorUnitario] FROM Product"
        ConnectDataBase = New ConnectDatabase(query)
        ConnectDataBase.ReadExecuteCmd()

        Do While ConnectDataBase.SqlReader.Read()
            Dim codigo = ConnectDataBase.SqlReader.GetValue(0)
            Dim produto = ConnectDataBase.SqlReader.GetValue(1)
            Dim descricao = ConnectDataBase.SqlReader.GetValue(2)
            Dim valorUnitario = ConnectDataBase.SqlReader.GetValue(3)
            dataProduct.Rows.Add(New String() {False, codigo.ToString(), produto,
                                 descricao, valorUnitario.ToString()})
        Loop
        ConnectDataBase.CloseConnection()
    End Sub

    Private Sub dataProduct_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataProduct.CellContentClick
        Dim cell As DataGridViewCheckBoxCell = dataProduct.Rows(e.RowIndex).Cells(0)
        cell.Value = True
        checkLine_Uncheck()

    End Sub

    Private Sub checkLine_Uncheck()
        For Each row As DataGridViewRow In dataProduct.Rows
            Dim cell As DataGridViewCheckBoxCell = row.Cells(0)
            cell.Value = False
        Next
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        For Each row As DataGridViewRow In dataProduct.Rows 
            Dim cell As DataGridViewCheckBoxCell = row.Cells(0)
            If cell.Value = True Then
                Dim query = "DELETE FROM Product WHERE [Id] = '" & row.Cells(1).Value & "'"
                ConnectDataBase = New ConnectDatabase(query)
                ConnectDataBase.DeleteExecuteCmd()
                dataProduct.Rows.Remove(row)
            End If
        Next
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        For Each row As DataGridViewRow In dataProduct.Rows
            Dim cell As DataGridViewCheckBoxCell = row.Cells(0)
            If cell.Value = True Then
                NewProducts = New NewProducts(CInt(row.Cells(1).Value), row.Cells(2).Value, row.Cells(3).Value, CDbl(row.Cells(4).Value))
                NewProducts.Show()
            End If
        Next
    End Sub
End Class