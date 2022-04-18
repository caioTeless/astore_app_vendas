Public Class NewClient

    Public ConnectDatabase As ConnectDatabase

    Private Id As Integer
    Private Nome As String
    Private Endereco As String
    Private Cidade As String
    Private Uf As String

    Public Sub New(Optional id As Integer = 0, Optional nome As String = "",
                   Optional endereco As String = "", Optional cidade As String = "",
                   Optional uf As String = "")

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Id = id
        Me.Nome = nome
        Me.Endereco = endereco
        Me.Cidade = cidade
        Me.Uf = uf

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        lbl_insert_clients.Left = (lbl_insert_clients.Parent.Width / 2) - (lbl_insert_clients.Width / 2)
        lbl_insert_clients.Top = (lbl_insert_clients.Parent.Height / 2) - (lbl_insert_clients.Height / 2)
    End Sub

    Private Sub NewClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_clientUf.Items.AddRange({"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES",
                                    "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR",
                                    "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP",
                                    "SE", "TO"})
        If Id <> 0 Then
            txt_clientName.Text = Nome
            txt_clientAddress.Text = Endereco
            txt_clientCity.Text = Cidade
            cmb_clientUf.SelectedItem = Uf
        End If
    End Sub

    Private Sub btn_saveProduct_Click(sender As Object, e As EventArgs) Handles btn_saveProduct.Click
        Dim query As String
        If Id <> 0 Then
            query = "UPDATE Client SET [Nome] = '" & txt_clientName.Text & "', [Endereco] = '" & txt_clientAddress.Text &
                "', [Cidade] = '" & txt_clientCity.Text & "', [Uf] = '" & cmb_clientUf.SelectedItem.ToString() & "' WHERE [Id] = " & "'" & Id & "';"
        Else
            query = "INSERT INTO Client([Nome], [Endereco], [Cidade], [Uf]) VALUES ('" & txt_clientName.Text & "','" &
            txt_clientAddress.Text & "','" & txt_clientCity.Text & "','" _
            & cmb_clientUf.SelectedItem.ToString() & "');"
        End If
        ConnectDatabase = New ConnectDatabase(query)
        ConnectDatabase.ExecuteCmd()
        ConnectDatabase.CloseConnection()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Clients.dataClient.Rows.Clear()
        Clients.Load_Data()
        Me.Close()
    End Sub
End Class