Imports System.IO
Imports System.XML

Public Class Form2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.BackColor = Color.Green
        Button1.BackColor = Color.LavenderBlush
        AccrualButton.BackColor = Color.LavenderBlush
        'this works to launch a text version and no need to clear mem
        'Dim path As String = "D:\My Visual Studio Projects\GL_Launcher\newFile.xml"
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
        Dim newFile As New XmlTextWriter("D:\My Visual Studio Projects\GL_Launcher\newFile.xml", revisedutf8)
        newFile.WriteStartDocument(True)
        newFile.Formatting = Formatting.Indented
        newFile.Indentation = 2
        newFile.WriteStartElement("parms")
        newFile.WriteStartElement("type")
        If AccrualButton.BackColor = Color.Green Then newFile.WriteAttributeString("accrual", "accrual")
        If Button1.BackColor = Color.Green Then newFile.WriteAttributeString("Detailed", "elabordist")
        If Button2.BackColor = Color.Green Then newFile.WriteAttributeString("Standard", "ejentries")
        newFile.WriteAttributeString("name", "reportType")
        newFile.WriteEndElement()
        newFile.WriteStartElement("sp")
        newFile.WriteStartElement("accounts")
        newFile.WriteEndElement()
        newFile.WriteStartElement("fields")
        newFile.WriteEndElement()
        newFile.WriteStartElement("transfers")
        newFile.WriteEndElement()
        newFile.WriteStartElement("miscellaneous")
        newFile.WriteStartElement("misc")
        newFile.WriteEndElement()
        newFile.WriteEndElement()
        newFile.WriteEndElement()
        newFile.WriteStartElement("rdl")
        newFile.WriteStartElement("miscellaneous")
        newFile.WriteStartElement("misc")
        newFile.WriteEndElement()
        newFile.WriteEndElement()
        newFile.WriteStartElement("dates")
        newFile.WriteStartElement("date")
        newFile.WriteEndElement()
        newFile.WriteEndElement()
        newFile.WriteStartElement("sorts")
        newFile.WriteStartElement("sort")
        newFile.WriteEndElement()
        newFile.WriteEndElement()
        newFile.WriteEndElement()
        newFile.WriteStartElement("rdlReportFormat")
        newFile.WriteStartElement("format")
        newFile.WriteEndElement()
        newFile.WriteStartElement("header")
        newFile.WriteEndElement()
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









'Public Class Form1
'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
'Dim newFile As New XmlTextWriter("D:\My Visual Studio Projects\GL_Launcher\newFile.xml", System.Text.Encoding.UTF8)
'        newFile.WriteStartDocument(True)
'        newFile.Formatting = Formatting.Indented
'        newFile.Indentation = 2
'        newFile.WriteStartElement("parms")
'        newFile.WriteStartElement("type")
'        newFile.WriteStartElement("sp")
'        newFile.WriteStartElement("rdl")
'        newFile.WriteStartElement("rdlReportFormat")
'        newFile.WriteEndElement()
'        newFile.WriteEndElement()
'        newFile.WriteEndElement()
'        newFile.WriteEndElement()
'        newFile.WriteEndElement()
'        newFile.Close()
'End Sub
'    Private Sub createNode(ByVal pID As String, ByVal pName As String, ByVal pPrice As String, ByVal writer As XmlTextWriter)
'        writer.WriteStartElement("Product")
'        writer.WriteStartElement("Product_id")
'        writer.WriteString(pID)
'        writer.WriteEndElement()
'        writer.WriteStartElement("Product_name")
'        writer.WriteString(pName)
'        writer.WriteEndElement()
'        writer.WriteStartElement("Product_price")
'        writer.WriteString(pPrice)
'        writer.WriteEndElement()
'        writer.WriteEndElement()
'    End Sub
'End Class