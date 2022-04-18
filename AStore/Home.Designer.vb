<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.pn_Title = New System.Windows.Forms.Panel()
        Me.lbl_home = New System.Windows.Forms.Label()
        Me.btn_sales = New System.Windows.Forms.Button()
        Me.btn_products = New System.Windows.Forms.Button()
        Me.btn_employees = New System.Windows.Forms.Button()
        Me.btn_customers = New System.Windows.Forms.Button()
        Me.btn_item_data = New System.Windows.Forms.Button()
        Me.pn_Title.SuspendLayout()
        Me.SuspendLayout()
        '
        'pn_Title
        '
        Me.pn_Title.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pn_Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pn_Title.Controls.Add(Me.lbl_home)
        Me.pn_Title.Location = New System.Drawing.Point(2, 2)
        Me.pn_Title.Name = "pn_Title"
        Me.pn_Title.Size = New System.Drawing.Size(796, 100)
        Me.pn_Title.TabIndex = 0
        '
        'lbl_home
        '
        Me.lbl_home.AutoSize = True
        Me.lbl_home.BackColor = System.Drawing.Color.Transparent
        Me.lbl_home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_home.Font = New System.Drawing.Font("Lucida Sans", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_home.ForeColor = System.Drawing.Color.White
        Me.lbl_home.Location = New System.Drawing.Point(151, 28)
        Me.lbl_home.Name = "lbl_home"
        Me.lbl_home.Size = New System.Drawing.Size(444, 37)
        Me.lbl_home.TabIndex = 1
        Me.lbl_home.Text = "CONTROLE SUAS VENDAS"
        '
        'btn_sales
        '
        Me.btn_sales.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_sales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sales.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sales.ForeColor = System.Drawing.Color.White
        Me.btn_sales.Location = New System.Drawing.Point(63, 122)
        Me.btn_sales.Name = "btn_sales"
        Me.btn_sales.Size = New System.Drawing.Size(130, 40)
        Me.btn_sales.TabIndex = 1
        Me.btn_sales.Text = "Vendas"
        Me.btn_sales.UseVisualStyleBackColor = False
        '
        'btn_products
        '
        Me.btn_products.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_products.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_products.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_products.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_products.ForeColor = System.Drawing.Color.White
        Me.btn_products.Location = New System.Drawing.Point(335, 122)
        Me.btn_products.Name = "btn_products"
        Me.btn_products.Size = New System.Drawing.Size(130, 40)
        Me.btn_products.TabIndex = 2
        Me.btn_products.Text = "Produtos"
        Me.btn_products.UseVisualStyleBackColor = False
        '
        'btn_employees
        '
        Me.btn_employees.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_employees.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_employees.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_employees.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_employees.ForeColor = System.Drawing.Color.White
        Me.btn_employees.Location = New System.Drawing.Point(471, 122)
        Me.btn_employees.Name = "btn_employees"
        Me.btn_employees.Size = New System.Drawing.Size(130, 40)
        Me.btn_employees.TabIndex = 3
        Me.btn_employees.Text = "Funcionários"
        Me.btn_employees.UseVisualStyleBackColor = False
        '
        'btn_customers
        '
        Me.btn_customers.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_customers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_customers.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_customers.ForeColor = System.Drawing.Color.White
        Me.btn_customers.Location = New System.Drawing.Point(607, 122)
        Me.btn_customers.Name = "btn_customers"
        Me.btn_customers.Size = New System.Drawing.Size(130, 40)
        Me.btn_customers.TabIndex = 4
        Me.btn_customers.Text = "Clientes"
        Me.btn_customers.UseVisualStyleBackColor = False
        '
        'btn_item_data
        '
        Me.btn_item_data.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_item_data.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_item_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_item_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_item_data.ForeColor = System.Drawing.Color.White
        Me.btn_item_data.Location = New System.Drawing.Point(199, 122)
        Me.btn_item_data.Name = "btn_item_data"
        Me.btn_item_data.Size = New System.Drawing.Size(130, 40)
        Me.btn_item_data.TabIndex = 5
        Me.btn_item_data.Text = "Itens"
        Me.btn_item_data.UseVisualStyleBackColor = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_item_data)
        Me.Controls.Add(Me.btn_customers)
        Me.Controls.Add(Me.btn_employees)
        Me.Controls.Add(Me.btn_products)
        Me.Controls.Add(Me.btn_sales)
        Me.Controls.Add(Me.pn_Title)
        Me.Name = "Home"
        Me.Text = "AStore"
        Me.pn_Title.ResumeLayout(False)
        Me.pn_Title.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pn_Title As Panel
    Friend WithEvents lbl_home As Label
    Friend WithEvents btn_sales As Button
    Friend WithEvents btn_products As Button
    Friend WithEvents btn_employees As Button
    Friend WithEvents btn_customers As Button
    Friend WithEvents btn_item_data As Button
End Class
