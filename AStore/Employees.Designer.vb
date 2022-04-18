<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employees
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
        Me.pn_employees = New System.Windows.Forms.Panel()
        Me.lbl_employees = New System.Windows.Forms.Label()
        Me.btn_employee_start = New System.Windows.Forms.Button()
        Me.btn_inserir = New System.Windows.Forms.Button()
        Me.dataEmp = New System.Windows.Forms.DataGridView()
        Me.checkBox = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_name_employee = New System.Windows.Forms.TextBox()
        Me.btn_delete_emp = New System.Windows.Forms.Button()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.pn_employees.SuspendLayout()
        CType(Me.dataEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pn_employees
        '
        Me.pn_employees.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pn_employees.Controls.Add(Me.lbl_employees)
        Me.pn_employees.Location = New System.Drawing.Point(2, 0)
        Me.pn_employees.Name = "pn_employees"
        Me.pn_employees.Size = New System.Drawing.Size(796, 100)
        Me.pn_employees.TabIndex = 0
        '
        'lbl_employees
        '
        Me.lbl_employees.AutoSize = True
        Me.lbl_employees.Font = New System.Drawing.Font("Lucida Sans", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_employees.ForeColor = System.Drawing.Color.White
        Me.lbl_employees.Location = New System.Drawing.Point(324, 28)
        Me.lbl_employees.Name = "lbl_employees"
        Me.lbl_employees.Size = New System.Drawing.Size(274, 37)
        Me.lbl_employees.TabIndex = 0
        Me.lbl_employees.Text = "FUNCIONÁRIOS"
        '
        'btn_employee_start
        '
        Me.btn_employee_start.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_employee_start.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_employee_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_employee_start.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_employee_start.ForeColor = System.Drawing.Color.White
        Me.btn_employee_start.Location = New System.Drawing.Point(42, 132)
        Me.btn_employee_start.Name = "btn_employee_start"
        Me.btn_employee_start.Size = New System.Drawing.Size(130, 40)
        Me.btn_employee_start.TabIndex = 2
        Me.btn_employee_start.Text = "Inicio"
        Me.btn_employee_start.UseVisualStyleBackColor = False
        '
        'btn_inserir
        '
        Me.btn_inserir.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_inserir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_inserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_inserir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_inserir.ForeColor = System.Drawing.Color.White
        Me.btn_inserir.Location = New System.Drawing.Point(446, 132)
        Me.btn_inserir.Name = "btn_inserir"
        Me.btn_inserir.Size = New System.Drawing.Size(130, 40)
        Me.btn_inserir.TabIndex = 3
        Me.btn_inserir.Text = "Salvar"
        Me.btn_inserir.UseVisualStyleBackColor = False
        '
        'dataEmp
        '
        Me.dataEmp.AllowUserToAddRows = False
        Me.dataEmp.AllowUserToDeleteRows = False
        Me.dataEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataEmp.BackgroundColor = System.Drawing.Color.White
        Me.dataEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataEmp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.checkBox, Me.codigo, Me.nome})
        Me.dataEmp.Location = New System.Drawing.Point(2, 178)
        Me.dataEmp.Name = "dataEmp"
        Me.dataEmp.ReadOnly = True
        Me.dataEmp.Size = New System.Drawing.Size(796, 150)
        Me.dataEmp.TabIndex = 4
        '
        'checkBox
        '
        Me.checkBox.FillWeight = 30.0!
        Me.checkBox.HeaderText = "Selecionar"
        Me.checkBox.Name = "checkBox"
        Me.checkBox.ReadOnly = True
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
        'txt_name_employee
        '
        Me.txt_name_employee.Location = New System.Drawing.Point(585, 133)
        Me.txt_name_employee.Margin = New System.Windows.Forms.Padding(6)
        Me.txt_name_employee.MinimumSize = New System.Drawing.Size(200, 30)
        Me.txt_name_employee.Name = "txt_name_employee"
        Me.txt_name_employee.Size = New System.Drawing.Size(200, 30)
        Me.txt_name_employee.TabIndex = 5
        '
        'btn_delete_emp
        '
        Me.btn_delete_emp.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_delete_emp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete_emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete_emp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete_emp.ForeColor = System.Drawing.Color.White
        Me.btn_delete_emp.Location = New System.Drawing.Point(310, 132)
        Me.btn_delete_emp.Name = "btn_delete_emp"
        Me.btn_delete_emp.Size = New System.Drawing.Size(130, 40)
        Me.btn_delete_emp.TabIndex = 6
        Me.btn_delete_emp.Text = "Remover"
        Me.btn_delete_emp.UseVisualStyleBackColor = False
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(665, 111)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(0, 13)
        Me.lbl_id.TabIndex = 7
        '
        'Employees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.btn_delete_emp)
        Me.Controls.Add(Me.txt_name_employee)
        Me.Controls.Add(Me.dataEmp)
        Me.Controls.Add(Me.btn_inserir)
        Me.Controls.Add(Me.btn_employee_start)
        Me.Controls.Add(Me.pn_employees)
        Me.Name = "Employees"
        Me.Text = "AStore"
        Me.pn_employees.ResumeLayout(False)
        Me.pn_employees.PerformLayout()
        CType(Me.dataEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pn_employees As Panel
    Friend WithEvents lbl_employees As Label
    Friend WithEvents btn_employee_start As Button
    Friend WithEvents btn_inserir As Button
    Friend WithEvents dataEmp As DataGridView
    Friend WithEvents checkBox As DataGridViewCheckBoxColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents txt_name_employee As TextBox
    Friend WithEvents btn_delete_emp As Button
    Friend WithEvents lbl_id As Label
End Class
