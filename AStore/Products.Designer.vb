<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Products
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
        Me.pn_title_products = New System.Windows.Forms.Panel()
        Me.lbl_products = New System.Windows.Forms.Label()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.btn_newRegister = New System.Windows.Forms.Button()
        Me.dataProduct = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valorUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.pn_title_products.SuspendLayout()
        CType(Me.dataProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pn_title_products
        '
        Me.pn_title_products.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pn_title_products.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pn_title_products.Controls.Add(Me.lbl_products)
        Me.pn_title_products.Location = New System.Drawing.Point(1, 1)
        Me.pn_title_products.Name = "pn_title_products"
        Me.pn_title_products.Size = New System.Drawing.Size(796, 100)
        Me.pn_title_products.TabIndex = 0
        '
        'lbl_products
        '
        Me.lbl_products.AutoSize = True
        Me.lbl_products.BackColor = System.Drawing.Color.Transparent
        Me.lbl_products.Font = New System.Drawing.Font("Lucida Sans", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_products.ForeColor = System.Drawing.Color.White
        Me.lbl_products.Location = New System.Drawing.Point(293, 35)
        Me.lbl_products.Name = "lbl_products"
        Me.lbl_products.Size = New System.Drawing.Size(203, 37)
        Me.lbl_products.TabIndex = 1
        Me.lbl_products.Text = "PRODUTOS"
        '
        'btn_start
        '
        Me.btn_start.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_start.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_start.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_start.ForeColor = System.Drawing.Color.White
        Me.btn_start.Location = New System.Drawing.Point(45, 137)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(130, 40)
        Me.btn_start.TabIndex = 2
        Me.btn_start.Text = "Início"
        Me.btn_start.UseVisualStyleBackColor = False
        '
        'btn_newRegister
        '
        Me.btn_newRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_newRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_newRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_newRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_newRegister.ForeColor = System.Drawing.Color.White
        Me.btn_newRegister.Location = New System.Drawing.Point(189, 137)
        Me.btn_newRegister.Name = "btn_newRegister"
        Me.btn_newRegister.Size = New System.Drawing.Size(130, 40)
        Me.btn_newRegister.TabIndex = 3
        Me.btn_newRegister.Text = "Novo"
        Me.btn_newRegister.UseVisualStyleBackColor = False
        '
        'dataProduct
        '
        Me.dataProduct.AllowUserToAddRows = False
        Me.dataProduct.AllowUserToDeleteRows = False
        Me.dataProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataProduct.BackgroundColor = System.Drawing.Color.White
        Me.dataProduct.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataProduct.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.nome, Me.descricao, Me.valorUnitario})
        Me.dataProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dataProduct.Location = New System.Drawing.Point(1, 183)
        Me.dataProduct.Name = "dataProduct"
        Me.dataProduct.ReadOnly = True
        Me.dataProduct.RowHeadersWidth = 10
        Me.dataProduct.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataProduct.Size = New System.Drawing.Size(796, 255)
        Me.dataProduct.TabIndex = 4
        '
        'codigo
        '
        Me.codigo.HeaderText = "Codigo"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'nome
        '
        Me.nome.HeaderText = "Nome"
        Me.nome.Name = "nome"
        Me.nome.ReadOnly = True
        '
        'descricao
        '
        Me.descricao.HeaderText = "Descrição"
        Me.descricao.Name = "descricao"
        Me.descricao.ReadOnly = True
        '
        'valorUnitario
        '
        Me.valorUnitario.HeaderText = "Valor Unitário"
        Me.valorUnitario.Name = "valorUnitario"
        Me.valorUnitario.ReadOnly = True
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.Location = New System.Drawing.Point(600, 137)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(188, 40)
        Me.btn_delete.TabIndex = 5
        Me.btn_delete.Text = "Remover Selecionado"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.Location = New System.Drawing.Point(406, 137)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(188, 40)
        Me.btn_update.TabIndex = 6
        Me.btn_update.Text = "Editar Selecionado"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'Products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.dataProduct)
        Me.Controls.Add(Me.btn_newRegister)
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.pn_title_products)
        Me.Name = "Products"
        Me.Text = "AStore"
        Me.pn_title_products.ResumeLayout(False)
        Me.pn_title_products.PerformLayout()
        CType(Me.dataProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pn_title_products As Panel
    Friend WithEvents lbl_products As Label
    Friend WithEvents btn_start As Button
    Friend WithEvents btn_newRegister As Button
    Friend WithEvents dataProduct As DataGridView
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents descricao As DataGridViewTextBoxColumn
    Friend WithEvents valorUnitario As DataGridViewTextBoxColumn
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
End Class
