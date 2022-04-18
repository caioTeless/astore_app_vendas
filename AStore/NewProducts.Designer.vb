<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewProducts
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbl_products = New System.Windows.Forms.Label()
        Me.pn_title_products = New System.Windows.Forms.Panel()
        Me.txt_productName = New System.Windows.Forms.TextBox()
        Me.txt_unitValue = New System.Windows.Forms.TextBox()
        Me.txt_description = New System.Windows.Forms.TextBox()
        Me.btn_saveProduct = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.pn_title_products.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_products
        '
        Me.lbl_products.AutoSize = True
        Me.lbl_products.BackColor = System.Drawing.Color.Transparent
        Me.lbl_products.Font = New System.Drawing.Font("Lucida Sans", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_products.ForeColor = System.Drawing.Color.White
        Me.lbl_products.Location = New System.Drawing.Point(242, 26)
        Me.lbl_products.Name = "lbl_products"
        Me.lbl_products.Size = New System.Drawing.Size(346, 37)
        Me.lbl_products.TabIndex = 1
        Me.lbl_products.Text = "INSERIR PRODUTOS"
        '
        'pn_title_products
        '
        Me.pn_title_products.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pn_title_products.Controls.Add(Me.lbl_products)
        Me.pn_title_products.Location = New System.Drawing.Point(1, 1)
        Me.pn_title_products.Name = "pn_title_products"
        Me.pn_title_products.Size = New System.Drawing.Size(796, 100)
        Me.pn_title_products.TabIndex = 1
        '
        'txt_productName
        '
        Me.txt_productName.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_productName.ForeColor = System.Drawing.Color.Black
        Me.txt_productName.Location = New System.Drawing.Point(250, 148)
        Me.txt_productName.Margin = New System.Windows.Forms.Padding(6)
        Me.txt_productName.MaximumSize = New System.Drawing.Size(250, 30)
        Me.txt_productName.MinimumSize = New System.Drawing.Size(300, 30)
        Me.txt_productName.Name = "txt_productName"
        Me.txt_productName.Size = New System.Drawing.Size(300, 30)
        Me.txt_productName.TabIndex = 2
        '
        'txt_unitValue
        '
        Me.txt_unitValue.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_unitValue.ForeColor = System.Drawing.Color.Black
        Me.txt_unitValue.Location = New System.Drawing.Point(250, 187)
        Me.txt_unitValue.Margin = New System.Windows.Forms.Padding(6)
        Me.txt_unitValue.MaximumSize = New System.Drawing.Size(250, 30)
        Me.txt_unitValue.MinimumSize = New System.Drawing.Size(300, 30)
        Me.txt_unitValue.Name = "txt_unitValue"
        Me.txt_unitValue.Size = New System.Drawing.Size(300, 30)
        Me.txt_unitValue.TabIndex = 3
        '
        'txt_description
        '
        Me.txt_description.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_description.ForeColor = System.Drawing.Color.Black
        Me.txt_description.Location = New System.Drawing.Point(250, 226)
        Me.txt_description.Margin = New System.Windows.Forms.Padding(6)
        Me.txt_description.MaximumSize = New System.Drawing.Size(250, 60)
        Me.txt_description.MinimumSize = New System.Drawing.Size(300, 30)
        Me.txt_description.Multiline = True
        Me.txt_description.Name = "txt_description"
        Me.txt_description.Size = New System.Drawing.Size(300, 60)
        Me.txt_description.TabIndex = 4
        '
        'btn_saveProduct
        '
        Me.btn_saveProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_saveProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_saveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_saveProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_saveProduct.ForeColor = System.Drawing.Color.White
        Me.btn_saveProduct.Location = New System.Drawing.Point(250, 295)
        Me.btn_saveProduct.Name = "btn_saveProduct"
        Me.btn_saveProduct.Size = New System.Drawing.Size(300, 40)
        Me.btn_saveProduct.TabIndex = 5
        Me.btn_saveProduct.Text = "Salvar"
        Me.btn_saveProduct.UseVisualStyleBackColor = False
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.White
        Me.btn_back.Location = New System.Drawing.Point(250, 344)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(300, 40)
        Me.btn_back.TabIndex = 6
        Me.btn_back.Text = "Voltar"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'NewProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_saveProduct)
        Me.Controls.Add(Me.txt_description)
        Me.Controls.Add(Me.txt_unitValue)
        Me.Controls.Add(Me.txt_productName)
        Me.Controls.Add(Me.pn_title_products)
        Me.Name = "NewProducts"
        Me.Text = "AStore"
        Me.pn_title_products.ResumeLayout(False)
        Me.pn_title_products.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_products As Label
    Friend WithEvents pn_title_products As Panel
    Friend WithEvents txt_productName As TextBox
    Friend WithEvents txt_unitValue As TextBox
    Friend WithEvents txt_description As TextBox
    Friend WithEvents btn_saveProduct As Button
    Friend WithEvents btn_back As Button
End Class
