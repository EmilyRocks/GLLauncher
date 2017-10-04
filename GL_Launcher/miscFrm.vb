Imports System.Xml

Module unchecktrim
    Public removeTrim1 As String = "no"
    Public trimStart As String
    Public trimLength As String
End Module

Public Class miscFrm

    Private Sub miscFrm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim newFile As New XmlDocument
        Dim path As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\newFile.xml"
        newFile.Load(path)
        Dim cdTag As XmlElement = newFile.CreateElement("misc")
        Dim crdrTag As XmlElement = newFile.CreateElement("misc")
        Dim rdlMisc As XmlElement = newFile.SelectSingleNode(xpath:="parms/rdl/miscellaneous")

        'adds any extra characters to trim and establishes starting position and length fields for trim
        getTrimChars.Add(trimStrAddTxtbox.Text)
        trimStart = trimStartTextbox.Text
        trimLength = trimLengthTextbox.Text



        'turn on for sanity check during testing to see if trim list is pulling characters
        Dim testTrim As String
        testTrim = String.Join(",", getTrimChars)
        'MessageBox.Show(text:=testTrim)

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

        'code to create the line to remove the 0 in the cr/dr columns
        If drcr0button.Checked Then
            crdrTag.SetAttribute("zero", "0")
            crdrTag.SetAttribute("name", "cdZero")
            rdlMisc.AppendChild(crdrTag)
        End If
        If drcrNoneButton.Checked Then
            crdrTag.SetAttribute("zero", "")
            crdrTag.SetAttribute("name", "cdZero")
            rdlMisc.AppendChild(crdrTag)
        End If
        'this works to remove the cd field
        'Dim cdnode As XmlNode = fields.SelectSingleNode("//field[@name='cd']")
        'If cdnode IsNot Nothing Then
        '    cdnode.RemoveAll()
        'End If

        'turn on for sanity check during testing to see if cd works
        'MessageBox.Show(Cdmisctrigger1)


        newFile.Save(path)
    End Sub

End Class