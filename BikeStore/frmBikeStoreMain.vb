Public Class frmBikeStoreMain



    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        txtUsername.Clear()
        txtPW.Clear()
    End Sub

    Private Sub CustomerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BikeStoreDataSet)

    End Sub

    Private Sub frmBikeStoreMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BikeStoreDataSet.SalesOrderDetail' table. You can move, or remove it, as needed.
        Me.SalesOrderDetailTableAdapter.Fill(Me.BikeStoreDataSet.SalesOrderDetail)
        'TODO: This line of code loads data into the 'BikeStoreDataSet.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.BikeStoreDataSet.Product)
        'TODO: This line of code loads data into the 'BikeStoreDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.BikeStoreDataSet.Customer)

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCustomerMaintenance_Click(sender As Object, e As EventArgs)
        frmCustomerMaintenance.ShowDialog()
    End Sub

    Private Sub btnProductMaintenance_Click(sender As Object, e As EventArgs)
        frmProductMaintenance.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged



    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtUsername.Text = "Group_Project" And txtPW.Text = "Summer" Then

            GroupBox1.Visible = False

        Else

            MessageBox.Show("Please enter the correct login credentials")
            txtUsername.Clear()
            txtPW.Clear()

        End If

    End Sub

    Private Sub btnClear_Click_1(sender As Object, e As EventArgs) Handles btnClear.Click

        txtUsername.Clear()
        txtPW.Clear()

    End Sub

    Private Sub btnExit_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class