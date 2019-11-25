Imports System.Data.Entity
Public Class Form1
    Private db As SimpleCRUD.NORTHWNDEntities
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db = New SimpleCRUD.NORTHWNDEntities()
        db.Customers.Load()
        CustomerBindingSource.DataSource.Customers.Local
    End Sub
End Class
