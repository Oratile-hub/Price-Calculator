<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        btnTotalForCustomer = New Button()
        Label1 = New Label()
        Label2 = New Label()
        txtPriceperItem = New TextBox()
        txtQuantityofItems = New TextBox()
        Label3 = New Label()
        txtCustomerName = New TextBox()
        SuspendLayout()
        ' 
        ' btnTotalForCustomer
        ' 
        btnTotalForCustomer.BackColor = Color.CornflowerBlue
        btnTotalForCustomer.Location = New Point(185, 343)
        btnTotalForCustomer.Name = "btnTotalForCustomer"
        btnTotalForCustomer.Size = New Size(343, 73)
        btnTotalForCustomer.TabIndex = 0
        btnTotalForCustomer.Text = "Total for customer"
        btnTotalForCustomer.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(185, 113)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 25)
        Label1.TabIndex = 1
        Label1.Text = "Price per Item"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(185, 189)
        Label2.Name = "Label2"
        Label2.Size = New Size(150, 25)
        Label2.TabIndex = 2
        Label2.Text = "Quantity of items"
        ' 
        ' txtPriceperItem
        ' 
        txtPriceperItem.Location = New Point(378, 113)
        txtPriceperItem.Name = "txtPriceperItem"
        txtPriceperItem.Size = New Size(150, 31)
        txtPriceperItem.TabIndex = 3
        ' 
        ' txtQuantityofItems
        ' 
        txtQuantityofItems.Location = New Point(378, 189)
        txtQuantityofItems.Name = "txtQuantityofItems"
        txtQuantityofItems.Size = New Size(150, 31)
        txtQuantityofItems.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(185, 270)
        Label3.Name = "Label3"
        Label3.Size = New Size(141, 25)
        Label3.TabIndex = 5
        Label3.Text = "Customer Name"
        ' 
        ' txtCustomerName
        ' 
        txtCustomerName.Location = New Point(378, 270)
        txtCustomerName.Name = "txtCustomerName"
        txtCustomerName.Size = New Size(150, 31)
        txtCustomerName.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(900, 450)
        Controls.Add(txtCustomerName)
        Controls.Add(Label3)
        Controls.Add(txtQuantityofItems)
        Controls.Add(txtPriceperItem)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnTotalForCustomer)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTotalForCustomer As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPriceperItem As TextBox
    Friend WithEvents txtQuantityofItems As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCustomerName As TextBox
End Class
