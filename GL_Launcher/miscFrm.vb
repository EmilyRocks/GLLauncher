Imports System.Xml

Public Class miscFrm

    Private Sub miscFrm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim newFile As New XmlDocument
        newFile.Load("D:\My Visual Studio Projects\GL_Launcher\newFile.xml")
        Dim path As String = "D:\My Visual Studio Projects\GL_Launcher\newFile.xml"
        Dim charTrim As XmlElement = newFile.CreateElement("misc")
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

        If antiTrimBox.Checked Then
            miscSP.RemoveAttribute("trimChars")
        End If

        newFile.Save(path)
    End Sub
End Class