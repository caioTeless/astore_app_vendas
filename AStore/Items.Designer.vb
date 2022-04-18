<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Items
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_itens = New System.Windows.Forms.Label()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.btn_inserir = New System.Windows.Forms.Button()
        Me.dataItens = New System.Windows.Forms.DataGridView()
        Me.checkBox = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.produto = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.quantidade = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.dataItens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_itens)
        Me.Panel1.Location = New System.Drawing.Point(2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(796, 100)
        Me.Panel1.TabIndex = 0
        '
        'lbl_itens
        '
        Me.lbl_itens.AutoSize = True
        Me.lbl_itens.Font = New System.Drawing.Font("Lucida Sans", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_itens.ForeColor = System.Drawing.Color.White
        Me.lbl_itens.Location = New System.Drawing.Point(374, 29)
        Me.lbl_itens.Name = "lbl_itens"
        Me.lbl_itens.Size = New System.Drawing.Size(115, 37)
        Me.lbl_itens.TabIndex = 0
        Me.lbl_itens.Text = "ITENS"
        '
        'btn_start
        '
        Me.btn_start.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_start.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_start.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_start.ForeColor = System.Drawing.Color.White
        Me.btn_start.Location = New System.Drawing.Point(267, 121)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(130, 40)
        Me.btn_start.TabIndex = 6
        Me.btn_start.Text = "Início"
        Me.btn_start.UseVisualStyleBackColor = False
        '
        'btn_inserir
        '
        Me.btn_inserir.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_inserir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_inserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_inserir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_inserir.ForeColor = System.Drawing.Color.White
        Me.btn_inserir.Location = New System.Drawing.Point(403, 121)
        Me.btn_inserir.Name = "btn_inserir"
        Me.btn_inserir.Size = New System.Drawing.Size(130, 40)
        Me.btn_inserir.TabIndex = 7
        Me.btn_inserir.Text = "Novo"
        Me.btn_inserir.UseVisualStyleBackColor = False
        '
        'dataItens
        '
        Me.dataItens.AllowUserToAddRows = False
        Me.dataItens.AllowUserToDeleteRows = False
        Me.dataItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataItens.BackgroundColor = System.Drawing.Color.White
        Me.dataItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataItens.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.checkBox, Me.produto, Me.cliente, Me.quantidade})
        Me.dataItens.Location = New System.Drawing.Point(2, 200)
        Me.dataItens.Name = "dataItens"
        Me.dataItens.ReadOnly = True
        Me.dataItens.Size = New System.Drawing.Size(796, 248)
        Me.dataItens.TabIndex = 10
        '
        'checkBox
        '
        Me.checkBox.HeaderText = "Selecionar"
        Me.checkBox.Name = "checkBox"
        Me.checkBox.ReadOnly = True
        '
        'produto
        '
        Me.produto.HeaderText = "Produto"
        Me.produto.Name = "produto"
        Me.produto.ReadOnly = True
        '
        'cliente
        '
        Me.cliente.HeaderText = "Cliente"
        Me.cliente.Name = "cliente"
        Me.cliente.ReadOnly = True
        '
        'quantidade
        '
        Me.quantidade.HeaderText = "Quantidade"
        Me.quantidade.Name = "quantidade"
        Me.quantidade.ReadOnly = True
        '
        'Items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dataItens)
        Me.Controls.Add(Me.btn_inserir)
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Items"
        Me.Text = "AStore"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dataItens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_itens As Label
    Friend WithEvents btn_start As Button
    Friend WithEvents btn_inserir As Button
    Friend WithEvents dataItens As DataGridView
    Friend WithEvents checkBox As DataGridViewCheckBoxColumn
    Friend WithEvents produto As DataGridViewCheckBoxColumn
    Friend WithEvents cliente As DataGridViewCheckBoxColumn
    Friend WithEvents quantidade As DataGridViewCheckBoxColumn
End Class
