Public Class frmCustomerMaintenance
    Private Sub frmCustomerMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BikeStoreDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.BikeStoreDataSet.Customer)
        'TODO: This line of code loads data into the 'BikeStoreDataSet.ProductModel' table. You can move, or remove it, as needed.
        Me.ProductModelTableAdapter.Fill(Me.BikeStoreDataSet.ProductModel)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtLastName.Clear()
        txtEmail.Clear()
        mskPhone.Clear()
    End Sub

    Private Sub btnAddCust_Click(sender As Object, e As EventArgs) Handles btnAddCust.Click

        CustomerBindingSource.AddNew()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnRemCust_Click(sender As Object, e As EventArgs) Handles btnRemCust.Click

        CustomerBindingSource.RemoveCurrent()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        CustomerBindingSource.MoveNext()

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click

        CustomerBindingSource.MovePrevious()

    End Sub
End Class