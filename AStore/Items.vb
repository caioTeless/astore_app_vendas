Public Class Items

    Private ConnectDatabase As ConnectDatabase
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        lbl_itens.Left = (lbl_itens.Parent.Width / 2) - (lbl_itens.Width / 2)
        lbl_itens.Top = (lbl_itens.Parent.Height / 2) - (lbl_itens.Height / 2)
    End Sub

    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        Home.Show()
        Me.Close()
    End Sub

    Private Sub btn_inserir_Click(sender As Object, e As EventArgs) Handles btn_inserir.Click
        NewItems.Show()
    End Sub

    Private Sub dataItens_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataItens.CellContentClick

    End Sub
End Class