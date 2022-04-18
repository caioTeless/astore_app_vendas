Public Class Employees

    Public ConnectDatabase As ConnectDatabase

    Private Sub pn_employees_Paint(sender As Object, e As PaintEventArgs) Handles pn_employees.Paint
        lbl_employees.Left = (lbl_employees.Parent.Width / 2) - (lbl_employees.Width / 2)
        lbl_employees.Top = (lbl_employees.Parent.Height / 2) - (lbl_employees.Height / 2)
    End Sub

    Private Sub btn_employee_start_Click(sender As Object, e As EventArgs) Handles btn_employee_start.Click
        Home.Show()
        Me.Close()
    End Sub

    Private Sub btn_inserir_Click(sender As Object, e As EventArgs) Handles btn_inserir.Click
        Dim query As String
        If lbl_id.Text <> "" Then
            query = "UPDATE Employee SET [Nome] = '" & txt_name_employee.Text & "' WHERE [Id] = '" & lbl_id.Text & "'"
        Else
            query = "INSERT INTO Employee (Nome) VALUES ('" & txt_name_employee.Text & "');"
        End If
        ConnectDatabase = New ConnectDatabase(query)
        ConnectDatabase.ExecuteCmd()
        ConnectDatabase.CloseConnection()
        lbl_id.Text = ""
        dataEmp.Rows.Clear()
        txt_name_employee.Clear()
        Load_Data()
    End Sub

    Private Sub dataEmp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataEmp.CellContentClick
        Dim check As DataGridViewCheckBoxCell = dataEmp.Rows(e.RowIndex).Cells(0)
        Uncheck()
        check.Value = True
        If check.Value Then
            txt_name_employee.Text = dataEmp.Rows(e.RowIndex).Cells(2).Value
            lbl_id.Text = dataEmp.Rows(e.RowIndex).Cells(1).Value
        End If
    End Sub

    Public Sub Uncheck()
        For Each row As DataGridViewRow In dataEmp.Rows
            Dim cell As DataGridViewCheckBoxCell = row.Cells(0)
            cell.Value = False
        Next
    End Sub

    Private Sub Employees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_id.Visible = False
        Load_Data()
    End Sub

    Public Sub Load_Data()
        Dim query As String
        query = "SELECT [Id], [Nome] FROM Employee"
        ConnectDatabase = New ConnectDatabase(query)
        ConnectDatabase.ReadExecuteCmd()
        Do While ConnectDatabase.SqlReader.Read()
            Dim codigo = ConnectDatabase.SqlReader.GetValue(0)
            Dim nome = ConnectDatabase.SqlReader.GetValue(1)
            dataEmp.Rows.Add(New String() {False, codigo, nome})
        Loop
        ConnectDatabase.CloseConnection()
    End Sub

    Private Sub btn_delete_emp_Click(sender As Object, e As EventArgs) Handles btn_delete_emp.Click
        Dim query As String
        For Each row As DataGridViewRow In dataEmp.Rows
            Dim cell As DataGridViewCheckBoxCell = row.Cells(0)
            If cell.Value Then
                query = "DELETE FROM Employee WHERE [Id] = '" & row.Cells(1).Value & "'"
                ConnectDatabase = New ConnectDatabase(query)
                ConnectDatabase.DeleteExecuteCmd()
                dataEmp.Rows.Remove(row)
                txt_name_employee.Clear()
            End If
        Next
        ConnectDatabase.CloseConnection()
    End Sub
End Class