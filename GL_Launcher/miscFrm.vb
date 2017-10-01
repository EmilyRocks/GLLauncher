Imports System.Xml

Module unchecktrim
    Public removeTrim1 As String = "no"

End Module

Public Class miscFrm

    Private Sub miscFrm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim newFile As New XmlDocument
        Dim path As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\newFile.xml"
        newFile.Load(path)
        Dim cdTag As XmlElement = newFile.CreateElement("misc")

        Dim rdlMisc As XmlElement = newFile.SelectSingleNode(xpath:="parms/rdl/miscellaneous")

        'adds any extra characters to trim
        getTrimChars.Add(trimStrAddTxtbox.Text)



        'turn on for sanity check during testing to see if trim list is pulling characters
        Dim testTrim As String
        testTrim = String.Join(",", getTrimChars)
        MessageBox.Show(text:=testTrim)

        'alternatively removes the trimming option
        If antiTrimBox.Checked Then
            removeTrim1 = "yes"
        End If

        'adds the misc line needed for the cd column
        If Cdmisctrigger1 = "yes" Then
            cdTag.SetAttribute("credits", crValTextbox.Text)
            cdTag.SetAttribute("debits", drValTextbox.Text)
            cdTag.SetAttribute("name", "cd")
            rdlMisc.AppendChild(cdTag)
        End If
        'this works to remove the cd field
        'Dim cdnode As XmlNode = fields.SelectSingleNode("//field[@name='cd']")
        'If cdnode IsNot Nothing Then
        '    cdnode.RemoveAll()
        'End If

        'turn on for sanity check during testing to see if cd works
        MessageBox.Show(Cdmisctrigger1)


        newFile.Save(path)
    End Sub
End Class