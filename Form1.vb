Public Class Form1
    Private Sub btnTotalForCustomer_Click(sender As Object, e As EventArgs) Handles btnTotalForCustomer.Click

        'Declaration of variables
        Dim Price As Decimal
        Dim Quantity As Integer
        Dim TotalForCustomer As Decimal
        Dim CustomerName As String



        Price = txtPriceperItem.Text
        Quantity = txtQuantityofItems.Text
        CustomerName = txtCustomerName.Text

        TotalForCustomer = Price * Quantity

        MsgBox("Hello " & CustomerName & ", " & "Your Total is equals to " & TotalForCustomer & " ZAR ")


    End Sub
End Class
