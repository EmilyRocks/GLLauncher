Imports System.IO
Imports System.XML

Public Class Form2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.BackColor = Color.Green
        Button1.BackColor = Color.LavenderBlush
        AccrualButton.BackColor = Color.LavenderBlush
        'this works to launch a text version and no need to clear mem
        'Dim path As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\newFile.xml"
        'Using newFile As StreamWriter = New StreamWriter(path)
        'End Using
    End Sub

    Private Sub AccrualButton_Click(sender As Object, e As EventArgs) Handles AccrualButton.Click
        AccrualButton.BackColor = Color.Green
        Button1.BackColor = Color.LavenderBlush
        Button2.BackColor = Color.LavenderBlush
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.BackColor = Color.Green
        AccrualButton.BackColor = Color.LavenderBlush
        Button2.BackColor = Color.LavenderBlush
    End Sub

    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim revisedutf8 As New System.Text.UTF8Encoding(False)
        Dim path As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\newFile.xml"
        Dim newFile As New XmlTextWriter(path, revisedutf8)
        newFile.WriteStartDocument(True)
        newFile.Formatting = Formatting.Indented
        newFile.Indentation = 2
        newFile.WriteStartElement("parms")
        newFile.WriteStartElement("sp")
        If AccrualButton.BackColor = Color.Green Then newFile.WriteAttributeString("reportType", "accrual")
        If Button1.BackColor = Color.Green Then newFile.WriteAttributeString("reportType", "detailed")
        If Button2.BackColor = Color.Green Then newFile.WriteAttributeString("reportType", "standard")
        newFile.WriteStartElement("accounts")
        newFile.WriteEndElement()
        newFile.WriteStartElement("fields")
        newFile.WriteEndElement()
        newFile.WriteStartElement("transfers")
        newFile.WriteEndElement()
        newFile.WriteStartElement("miscellaneous")
        newFile.WriteEndElement()
        newFile.WriteEndElement()
        newFile.WriteStartElement("rdl")
        newFile.WriteStartElement("miscellaneous")
        newFile.WriteEndElement()
        newFile.WriteStartElement("dates")
        newFile.WriteEndElement()
        newFile.WriteStartElement("sorts")
        newFile.WriteStartElement("sort")
        newFile.WriteEndElement()
        newFile.WriteEndElement()
        newFile.WriteEndElement()
        newFile.WriteStartElement("rdlReportFormat")
        newFile.WriteStartElement("footer")
        newFile.WriteEndElement()
        newFile.WriteStartElement("fro")
        newFile.WriteEndElement()
        newFile.WriteStartElement("groupFooter")
        newFile.WriteEndElement()
        newFile.WriteStartElement("groupHeader")
        newFile.WriteEndElement()
        newFile.WriteStartElement("pdf")
        newFile.WriteEndElement()
        newFile.WriteStartElement("pdfHeader")
        newFile.WriteEndElement()
        newFile.WriteStartElement("pdfBody")
        newFile.WriteEndElement()
        newFile.WriteEndElement()
        newFile.WriteEndElement()
        newFile.Close()
    End Sub




End Class


'"D:\My Visual Studio Projects\GL_Launcher\newFile.xml"