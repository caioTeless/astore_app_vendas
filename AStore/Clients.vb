Public Class Clients
    Private ConnectDatabase As ConnectDatabase

    Private NewClient As New NewClient
    Private Sub pn_clients_Paint(sender As Object, e As PaintEventArgs) Handles pn_clients.Paint
        lbl_clients.Left = (lbl_clients.Parent.Width / 2) - (lbl_clients.Width / 2)
        lbl_clients.Top = (lbl_clients.Parent.Height / 2) - (lbl_clients.Height / 2)
    End Sub

    Private Sub Clients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim checkBox As New DataGridViewCheckBoxColumn()
        checkBox.HeaderText = "Selecionar"
        dataClient.Columns.Insert(0, checkBox)
        Load_Data()
    End Sub

    Public Sub Load_Data()
        dataClient.Refresh()
        Dim query = "SELECT [Id], [Nome], [Endereco], [Cidade], [Uf] FROM Client"
        ConnectDatabase = New ConnectDatabase(query)
        ConnectDatabase.ReadExecuteCmd()
        Do While ConnectDatabase.SqlReader.Read()
            Dim codigo = ConnectDatabase.SqlReader.GetValue(0)
            Dim nome = ConnectDatabase.SqlReader.GetValue(1)
            Dim endereco = ConnectDatabase.SqlReader.GetValue(2)
            Dim cidade = ConnectDatabase.SqlReader.GetValue(3)
            Dim uf = ConnectDatabase.SqlReader.GetValue(4)

            dataClient.Rows.Add({False, CInt(codigo), nome, endereco, cidade, uf})
        Loop
    End Sub

    Private Sub btn_new_client_Click(sender As Object, e As EventArgs) Handles btn_new_client.Click
        NewClient.Show()
    End Sub

    Private Sub btn_start_client_Click(sender As Object, e As EventArgs) Handles btn_start_client.Click
        Home.Show()
        Me.Close()
    End Sub

    Private Sub dataClient_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataClient.CellContentClick
        Dim cell As DataGridViewCheckBoxCell = dataClient.Rows(e.RowIndex).Cells(0)
        Uncheck_Data()
        cell.Value = True

    End Sub

    Private Sub Uncheck_Data()
        For Each row As DataGridViewRow In dataClient.Rows
            Dim cell As DataGridViewCheckBoxCell = row.Cells(0)
            cell.Value = False
        Next
    End Sub

    Private Sub btn_edit_client_Click(sender As Object, e As EventArgs) Handles btn_edit_client.Click
        For Each row In dataClient.Rows
            Dim cell As DataGridViewCheckBoxCell = row.Cells(0)
            If cell.Value Then
                NewClient = New NewClient(CInt(row.Cells(1).Value), row.Cells(2).Value, row.Cells(3).Value,
                                          row.Cells(4).Value, row.Cells(5).Value)
                NewClient.lbl_insert_clients.Text = "EDITAR CLIENTES"
                NewClient.Show()
            End If
        Next
    End Sub

    Private Sub btn_delete_client_Click(sender As Object, e As EventArgs) Handles btn_delete_client.Click
        For Each row As DataGridViewRow In dataClient.Rows
            Dim cell As DataGridViewCheckBoxCell = row.Cells(0)
            If cell.Value Then
                Dim query As String = "DELETE FROM Client WHERE [Id] = '" & row.Cells(1).Value & "';"
                ConnectDatabase = New ConnectDatabase(query)
                ConnectDatabase.DeleteExecuteCmd()
                dataClient.Rows.Remove(row)
            End If
        Next
    End Sub
End Class