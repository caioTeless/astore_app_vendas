<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clients
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pn_clients = New System.Windows.Forms.Panel()
        Me.lbl_clients = New System.Windows.Forms.Label()
        Me.btn_new_client = New System.Windows.Forms.Button()
        Me.btn_start_client = New System.Windows.Forms.Button()
        Me.dataClient = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.endereco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_edit_client = New System.Windows.Forms.Button()
        Me.btn_delete_client = New System.Windows.Forms.Button()
        Me.pn_clients.SuspendLayout()
        CType(Me.dataClient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pn_clients
        '
        Me.pn_clients.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pn_clients.Controls.Add(Me.lbl_clients)
        Me.pn_clients.Location = New System.Drawing.Point(1, 0)
        Me.pn_clients.Name = "pn_clients"
        Me.pn_clients.Size = New System.Drawing.Size(796, 100)
        Me.pn_clients.TabIndex = 0
        '
        'lbl_clients
        '
        Me.lbl_clients.AutoSize = True
        Me.lbl_clients.Font = New System.Drawing.Font("Lucida Sans", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_clients.ForeColor = System.Drawing.Color.White
        Me.lbl_clients.Location = New System.Drawing.Point(359, 33)
        Me.lbl_clients.Name = "lbl_clients"
        Me.lbl_clients.Size = New System.Drawing.Size(176, 37)
        Me.lbl_clients.TabIndex = 0
        Me.lbl_clients.Text = "CLIENTES"
        '
        'btn_new_client
        '
        Me.btn_new_client.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_new_client.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_new_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new_client.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_client.ForeColor = System.Drawing.Color.White
        Me.btn_new_client.Location = New System.Drawing.Point(203, 137)
        Me.btn_new_client.Name = "btn_new_client"
        Me.btn_new_client.Size = New System.Drawing.Size(130, 40)
        Me.btn_new_client.TabIndex = 5
        Me.btn_new_client.Text = "Novo"
        Me.btn_new_client.UseVisualStyleBackColor = False
        '
        'btn_start_client
        '
        Me.btn_start_client.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_start_client.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_start_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_start_client.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_start_client.ForeColor = System.Drawing.Color.White
        Me.btn_start_client.Location = New System.Drawing.Point(59, 137)
        Me.btn_start_client.Name = "btn_start_client"
        Me.btn_start_client.Size = New System.Drawing.Size(130, 40)
        Me.btn_start_client.TabIndex = 4
        Me.btn_start_client.Text = "Início"
        Me.btn_start_client.UseVisualStyleBackColor = False
        '
        'dataClient
        '
        Me.dataClient.AllowUserToAddRows = False
        Me.dataClient.AllowUserToDeleteRows = False
        Me.dataClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataClient.BackgroundColor = System.Drawing.Color.White
        Me.dataClient.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataClient.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.nome, Me.endereco, Me.cidade, Me.uf})
        Me.dataClient.GridColor = System.Drawing.Color.White
        Me.dataClient.Location = New System.Drawing.Point(1, 193)
        Me.dataClient.MultiSelect = False
        Me.dataClient.Name = "dataClient"
        Me.dataClient.ReadOnly = True
        Me.dataClient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dataClient.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataClient.Size = New System.Drawing.Size(796, 150)
        Me.dataClient.TabIndex = 6
        '
        'codigo
        '
        Me.codigo.HeaderText = "Código"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        '
        'nome
        '
        Me.nome.HeaderText = "Nome"
        Me.nome.Name = "nome"
        Me.nome.ReadOnly = True
        '
        'endereco
        '
        Me.endereco.HeaderText = "Endereço"
        Me.endereco.Name = "endereco"
        Me.endereco.ReadOnly = True
        '
        'cidade
        '
        Me.cidade.HeaderText = "Cidade"
        Me.cidade.Name = "cidade"
        Me.cidade.ReadOnly = True
        '
        'uf
        '
        Me.uf.HeaderText = "UF"
        Me.uf.Name = "uf"
        Me.uf.ReadOnly = True
        '
        'btn_edit_client
        '
        Me.btn_edit_client.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_edit_client.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edit_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit_client.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit_client.ForeColor = System.Drawing.Color.White
        Me.btn_edit_client.Location = New System.Drawing.Point(431, 137)
        Me.btn_edit_client.Name = "btn_edit_client"
        Me.btn_edit_client.Size = New System.Drawing.Size(176, 40)
        Me.btn_edit_client.TabIndex = 7
        Me.btn_edit_client.Text = "Editar Selecionado"
        Me.btn_edit_client.UseVisualStyleBackColor = False
        '
        'btn_delete_client
        '
        Me.btn_delete_client.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_delete_client.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete_client.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete_client.ForeColor = System.Drawing.Color.White
        Me.btn_delete_client.Location = New System.Drawing.Point(612, 137)
        Me.btn_delete_client.Name = "btn_delete_client"
        Me.btn_delete_client.Size = New System.Drawing.Size(176, 40)
        Me.btn_delete_client.TabIndex = 8
        Me.btn_delete_client.Text = "Remover Selecionado"
        Me.btn_delete_client.UseVisualStyleBackColor = False
        '
        'Clients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_delete_client)
        Me.Controls.Add(Me.btn_edit_client)
        Me.Controls.Add(Me.dataClient)
        Me.Controls.Add(Me.btn_new_client)
        Me.Controls.Add(Me.btn_start_client)
        Me.Controls.Add(Me.pn_clients)
        Me.Name = "Clients"
        Me.Text = "AStore"
        Me.pn_clients.ResumeLayout(False)
        Me.pn_clients.PerformLayout()
        CType(Me.dataClient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pn_clients As Panel
    Friend WithEvents lbl_clients As Label
    Friend WithEvents btn_new_client As Button
    Friend WithEvents btn_start_client As Button
    Friend WithEvents dataClient As DataGridView
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents endereco As DataGridViewTextBoxColumn
    Friend WithEvents cidade As DataGridViewTextBoxColumn
    Friend WithEvents uf As DataGridViewTextBoxColumn
    Friend WithEvents btn_edit_client As Button
    Friend WithEvents btn_delete_client As Button
End Class
