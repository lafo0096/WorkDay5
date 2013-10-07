Option Strict On

Public Class Form1

    Private Sub btnDetermine_Click(sender As System.Object, e As System.EventArgs) Handles btnDetermine.Click
        Dim name As String
        name = txtFullName.Text
        txtFirstName.Text = FirstName(name)
    End Sub

    Function FirstName(ByVal name As String) As String
        Dim index As Integer
        index = name.IndexOf(" ")
        Dim fname As String
        fname = name.Substring(0, index)
        Return fname
    End Function

End Class
