Imports System.Xml

Public Class miscFrm

    Private Sub miscFrm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim newFile As New XmlDocument
        Dim path As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\newFile.xml"
        newFile.Load(path)
        Dim charTrim As XmlElement = newFile.CreateElement("misc")
        Dim cdTag As XmlElement = newFile.CreateElement("misc")
        Dim xmlTrim As String
        Dim miscSP As XmlElement = newFile.SelectSingleNode(xpath:="//miscellaneous")

        'adds any extra characters to trim
        getTrimChars.Add(trimStrAddTxtbox.Text)
        'moves all characters in array to string
        xmlTrim = String.Join(",", getTrimChars)
        'outputs into xml file
        charTrim.SetAttribute("trimChars", xmlTrim)
        charTrim.SetAttribute("trimLength", "5")
        charTrim.SetAttribute("trimBegin", "1")
        charTrim.SetAttribute("name", "trim")
        miscSP.AppendChild(charTrim)

        'alternatively removes the trimming option
        If antiTrimBox.Checked Then
            miscSP.RemoveAttribute("trimChars")
        End If

        'adds the misc line needed for the cd column
        Dim rdl As XmlElement = newFile.SelectSingleNode(xpath:="//rdlReportFormat")
        Dim cdnode As XmlNode = rdl.SelectSingleNode("//format[@value='cd']")
        If cdnode IsNot Nothing Then
            cdTag.SetAttribute("credits", crValTextbox.Text)
            cdTag.SetAttribute("debits", drValTextbox.Text)
            cdTag.SetAttribute("name", "cd")
            cdTag.AppendChild(miscSP)
        End If
        newFile.Save(path)
    End Sub
End Class