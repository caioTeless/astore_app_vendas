Public Class Home

    Private Sub pn_Title_Paint(sender As Object, e As PaintEventArgs) Handles pn_Title.Paint
        lbl_home.Left = (lbl_home.Parent.Width / 2) - (lbl_home.Width / 2)
        lbl_home.Top = (lbl_home.Parent.Height / 2) - (lbl_home.Height / 2)
    End Sub

    Private Sub btn_products_Click(sender As Object, e As EventArgs) Handles btn_products.Click
        Products.Show()
    End Sub

    Private Sub btn_customers_Click(sender As Object, e As EventArgs) Handles btn_customers.Click
        Clients.Show()
    End Sub

    Private Sub btn_item_data_Click(sender As Object, e As EventArgs) Handles btn_item_data.Click
        Items.Show()
    End Sub
End Class
