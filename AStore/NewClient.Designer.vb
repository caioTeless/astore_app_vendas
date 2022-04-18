<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewClient
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
        Me.lbl_insert_clients = New System.Windows.Forms.Label()
        Me.txt_clientCity = New System.Windows.Forms.TextBox()
        Me.txt_clientAddress = New System.Windows.Forms.TextBox()
        Me.txt_clientName = New System.Windows.Forms.TextBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_saveProduct = New System.Windows.Forms.Button()
        Me.cmb_clientUf = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_insert_clients)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(796, 100)
        Me.Panel1.TabIndex = 0
        '
        'lbl_insert_clients
        '
        Me.lbl_insert_clients.AutoSize = True
        Me.lbl_insert_clients.BackColor = System.Drawing.Color.Transparent
        Me.lbl_insert_clients.Font = New System.Drawing.Font("Lucida Sans", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_insert_clients.ForeColor = System.Drawing.Color.White
        Me.lbl_insert_clients.Location = New System.Drawing.Point(328, 36)
        Me.lbl_insert_clients.Name = "lbl_insert_clients"
        Me.lbl_insert_clients.Size = New System.Drawing.Size(319, 37)
        Me.lbl_insert_clients.TabIndex = 0
        Me.lbl_insert_clients.Text = "INSERIR CLIENTES"
        '
        'txt_clientCity
        '
        Me.txt_clientCity.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_clientCity.ForeColor = System.Drawing.Color.Black
        Me.txt_clientCity.Location = New System.Drawing.Point(248, 226)
        Me.txt_clientCity.Margin = New System.Windows.Forms.Padding(6)
        Me.txt_clientCity.MaximumSize = New System.Drawing.Size(250, 60)
        Me.txt_clientCity.MinimumSize = New System.Drawing.Size(300, 30)
        Me.txt_clientCity.Name = "txt_clientCity"
        Me.txt_clientCity.Size = New System.Drawing.Size(300, 30)
        Me.txt_clientCity.TabIndex = 7
        '
        'txt_clientAddress
        '
        Me.txt_clientAddress.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_clientAddress.ForeColor = System.Drawing.Color.Black
        Me.txt_clientAddress.Location = New System.Drawing.Point(248, 187)
        Me.txt_clientAddress.Margin = New System.Windows.Forms.Padding(6)
        Me.txt_clientAddress.MaximumSize = New System.Drawing.Size(250, 30)
        Me.txt_clientAddress.MinimumSize = New System.Drawing.Size(300, 30)
        Me.txt_clientAddress.Name = "txt_clientAddress"
        Me.txt_clientAddress.Size = New System.Drawing.Size(300, 30)
        Me.txt_clientAddress.TabIndex = 6
        '
        'txt_clientName
        '
        Me.txt_clientName.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_clientName.ForeColor = System.Drawing.Color.Black
        Me.txt_clientName.Location = New System.Drawing.Point(248, 148)
        Me.txt_clientName.Margin = New System.Windows.Forms.Padding(6)
        Me.txt_clientName.MaximumSize = New System.Drawing.Size(250, 30)
        Me.txt_clientName.MinimumSize = New System.Drawing.Size(300, 30)
        Me.txt_clientName.Name = "txt_clientName"
        Me.txt_clientName.Size = New System.Drawing.Size(300, 30)
        Me.txt_clientName.TabIndex = 5
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.White
        Me.btn_back.Location = New System.Drawing.Point(248, 314)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(300, 40)
        Me.btn_back.TabIndex = 9
        Me.btn_back.Text = "Voltar"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'btn_saveProduct
        '
        Me.btn_saveProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_saveProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_saveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_saveProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_saveProduct.ForeColor = System.Drawing.Color.White
        Me.btn_saveProduct.Location = New System.Drawing.Point(248, 265)
        Me.btn_saveProduct.Name = "btn_saveProduct"
        Me.btn_saveProduct.Size = New System.Drawing.Size(300, 40)
        Me.btn_saveProduct.TabIndex = 8
        Me.btn_saveProduct.Text = "Salvar"
        Me.btn_saveProduct.UseVisualStyleBackColor = False
        '
        'cmb_clientUf
        '
        Me.cmb_clientUf.DropDownHeight = 80
        Me.cmb_clientUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_clientUf.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_clientUf.ForeColor = System.Drawing.Color.Black
        Me.cmb_clientUf.FormattingEnabled = True
        Me.cmb_clientUf.IntegralHeight = False
        Me.cmb_clientUf.ItemHeight = 15
        Me.cmb_clientUf.Location = New System.Drawing.Point(560, 226)
        Me.cmb_clientUf.Margin = New System.Windows.Forms.Padding(6)
        Me.cmb_clientUf.MaximumSize = New System.Drawing.Size(50, 0)
        Me.cmb_clientUf.MinimumSize = New System.Drawing.Size(50, 0)
        Me.cmb_clientUf.Name = "cmb_clientUf"
        Me.cmb_clientUf.Size = New System.Drawing.Size(50, 23)
        Me.cmb_clientUf.TabIndex = 10
        '
        'NewClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmb_clientUf)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_saveProduct)
        Me.Controls.Add(Me.txt_clientCity)
        Me.Controls.Add(Me.txt_clientAddress)
        Me.Controls.Add(Me.txt_clientName)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "NewClient"
        Me.Text = "AStore"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_insert_clients As Label
    Friend WithEvents txt_clientCity As TextBox
    Friend WithEvents txt_clientAddress As TextBox
    Friend WithEvents txt_clientName As TextBox
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_saveProduct As Button
    Friend WithEvents cmb_clientUf As ComboBox
End Class
