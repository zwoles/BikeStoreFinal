Option Compare Text
Public Class frmBikeStoreMain

    Public Const SALESTAX As Double = 0.07
    Dim products As String()
    Dim prices As Double()
    Dim quantity As Double
    Dim productPrice As Double
    Dim currentPrice As Double
    Dim totalPrice As Double
    Dim count As Integer = 0
    Dim customerID As Integer
    Dim index As Integer


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

        'HIDE THE TEXT OF THE TextBox3 ON THE FIRST LOAD
        txtPW.UseSystemPasswordChar = True

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

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles grpLogin.Enter

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtUsername.Text = "Group_Project" And txtPW.Text = "Summer" Then

            grpLogin.Visible = False
            grpMain.Visible = True
            grpCart.Visible = True

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

    Private Sub btnSearch1_Click(sender As Object, e As EventArgs) Handles btnSearch1.Click

        DataGridView1.Visible = True
        DataGridView2.Visible = True

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        DataGridView1.Visible = True
        DataGridView2.Visible = True

    End Sub

    Private Sub cbPW_CheckedChanged(sender As Object, e As EventArgs) Handles cbPW.CheckedChanged

        'CHECKING IF THE CHECKBOX WAS CHECKED OR NOT.
        If cbPW.CheckState = CheckState.Checked Then
            'IF TRUE, IT SHOWS THE TEXT
            txtPW.UseSystemPasswordChar = False
        Else
            'IF FALSE, IT WILL HIDE THE TEXT AND IT WILL TURN INTO BULLETS.
            txtPW.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnCustomerMaintenance.Click


        frmCustomerMaintenance.ShowDialog()


    End Sub

    Private Sub btnProductMaintenance_Click_1(sender As Object, e As EventArgs) Handles btnProductMaintenance.Click

        frmProductMaintenance.ShowDialog()

    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click

        products(count) = txtProduct.Text
        currentPrice = txtPrice.Text
        productPrice = txtPrice.Text * quantity * SALESTAX
        prices(count) = productPrice
        quantity = mskQuantity.Text

        totalPrice += productPrice

        lstCart.Items.Add(products(count) & ", Price:" + currentPrice & ", Qty:" & quantity)
        count += 1
        txtProduct.Clear()
        txtPrice.Clear()
        mskQuantity.Clear()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        index = lstCart.SelectedIndex
        totalPrice = totalPrice - prices(index)
        lblTotal.Text = totalPrice
        lstCart.Items.Remove(lstCart.SelectedItem)
    End Sub

    Private Sub txtPW_TextChanged(sender As Object, e As EventArgs) Handles txtPW.TextChanged


    End Sub

    Private Sub lstCart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCart.SelectedIndexChanged

    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnClearCart_Click(sender As Object, e As EventArgs) Handles btnClearCart.Click
        Erase products
        Erase prices
        lstCart.Items.Clear()
        totalPrice = 0
        count = 0
        lblTotal.Text = ""
    End Sub
End Class