Imports System.ComponentModel

Public Class Delimit
    Private Sub delimitTextbox_TextChanged(sender As Object, e As EventArgs) Handles delimitTextbox.TextChanged
        delimiter = delimitTextbox.Text
        'turn on for sanity check during testing
        'MessageBox.Show(text:=delimiter)
    End Sub
End Class