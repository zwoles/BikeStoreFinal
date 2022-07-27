Public Class frmProductMaintenance
    Private Sub frmProductMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BikeStoreDataSet.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.BikeStoreDataSet.Product)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtListPrice.Clear()
        txtProdColor.Clear()
        mskProductID.Clear()
        txtProdName.Clear()
    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click

        ProductBindingSource.AddNew()

    End Sub

    Private Sub btnRemoveProd_Click(sender As Object, e As EventArgs) Handles btnRemoveProd.Click

        ProductBindingSource.RemoveCurrent()

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click

        ProductBindingSource.MovePrevious()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        ProductBindingSource.MoveNext()

    End Sub

    Private Sub ProductBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles ProductBindingSource.CurrentChanged



    End Sub
End Class