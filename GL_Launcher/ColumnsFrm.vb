Imports System.ComponentModel
Imports System.Xml

'passing delimiter in from delimiter form
Module Variables
    Private strDelimiter As String
    Public Property delimiter As String
        Get
            Return strdelimiter
        End Get
        Set(ByVal varDelimit As String)
            strDelimiter = varDelimit
        End Set
    End Property


End Module


'passing array of trimming characters
Module DataHolder
    Private trimChars As New List(Of String)
    Public Property getTrimChars As List(Of String)
        Get
            Return trimChars
        End Get
        Set(Val As List(Of String))
            trimChars.Add("")
        End Set
    End Property
End Module

Public Class ColumnsFrm
    'need to activate before publishing
    'Private Sub ColumnsFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
    '    If IO.File.Exists("D:\My Visual Studio Projects\GL_Launcher\newFile.xml") Then
    '        newFile.Load("D:\My Visual Studio Projects\GL_Launcher\newFile.xml")
    '    Else
    '        MessageBox.Show("Go select a report type first")
    '        Me.Close()
    '    End If
    'End Sub

    Private Sub DelimiterButton_Click(sender As Object, e As EventArgs) Handles DelimiterButton.Click
        Dim oForm As Delimit
        oForm = New Delimit
        Delimit.Show()
        oForm = Nothing
    End Sub

    ' adds or hides the second box for combos
    Private Sub ct1Textbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ct1Textbox.SelectedIndexChanged
        If ct1Textbox.Text = "Combo" Then
            cv1bTextbox.Visible = True
        End If
        If ct1Textbox.Text = "Text" Then
            cv1bTextbox.Visible = False
        End If
        If ct1Textbox.Text = "Variable" Then
            cv1bTextbox.Visible = False
        End If
    End Sub



    Private Sub ColumnsFrm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim newFile As New XmlDocument
        newFile.Load("D:\My Visual Studio Projects\GL_Launcher\newFile.xml")
        Dim path As String = "D:\My Visual Studio Projects\GL_Launcher\newFile.xml"
        Dim nsmgr As New XmlNamespaceManager(newFile.NameTable)
        Dim c1Format As XmlElement = newFile.CreateElement("format")
        Dim c2Format As XmlElement = newFile.CreateElement("format")
        Dim c3Format As XmlElement = newFile.CreateElement("format")
        Dim c4Format As XmlElement = newFile.CreateElement("format")
        Dim c5Format As XmlElement = newFile.CreateElement("format")
        Dim c6Format As XmlElement = newFile.CreateElement("format")
        Dim c7Format As XmlElement = newFile.CreateElement("format")
        Dim c8Format As XmlElement = newFile.CreateElement("format")
        Dim c9Format As XmlElement = newFile.CreateElement("format")
        Dim c10Format As XmlElement = newFile.CreateElement("format")
        Dim c11Format As XmlElement = newFile.CreateElement("format")
        Dim c12Format As XmlElement = newFile.CreateElement("format")
        Dim c13Format As XmlElement = newFile.CreateElement("format")
        Dim c14Format As XmlElement = newFile.CreateElement("format")
        Dim c15Format As XmlElement = newFile.CreateElement("format")
        Dim c16Format As XmlElement = newFile.CreateElement("format")
        Dim c17Format As XmlElement = newFile.CreateElement("format")

        Dim rdl As XmlElement = newFile.SelectSingleNode(xpath:="//rdlReportFormat")

        Dim fields As XmlElement = newFile.SelectSingleNode(xpath:="//fields")

        Dim field1 As XmlElement = newFile.CreateElement("field")
        Dim field2 As XmlElement = newFile.CreateElement("field")
        Dim field3 As XmlElement = newFile.CreateElement("field")
        Dim field4 As XmlElement = newFile.CreateElement("field")
        Dim field5 As XmlElement = newFile.CreateElement("field")
        Dim field6 As XmlElement = newFile.CreateElement("field")
        Dim field7 As XmlElement = newFile.CreateElement("field")
        Dim field8 As XmlElement = newFile.CreateElement("field")
        Dim field9 As XmlElement = newFile.CreateElement("field")


        'column separater value was a huge pain in the butt
        Dim xslDelimiter As String = delimiter
        If delimiter = "Comma" Then xslDelimiter = ","
        If delimiter = "Decimal" Then xslDelimiter = "."
        If delimiter = "Tab" Then xslDelimiter = "&#9;"

        'sets the first column in the rdl report format section of xml file
        If ct1Textbox.Text = "Text" Then
            c1Format.SetAttribute(ct1Textbox.Text.ToLower, cv1aTextbox.Text.ToLower)
            c1Format.SetAttribute("type", ct1Textbox.Text.ToLower)
        End If
        If ct1Textbox.Text = "Dynamic" Then
            c1Format.SetAttribute("value", cv1aTextbox.Text.ToLower)
            c1Format.SetAttribute("type", "variable")
            field1.SetAttribute("name", cv1aTextbox.Text.ToLower)
            field1.SetAttribute("include", "Y")
        End If
        If ct1Textbox.Text = "Combo" Then
            c1Format.SetAttribute("text", cv1aTextbox.Text.ToLower)
            c1Format.SetAttribute("value", cv1bTextbox.Text.ToLower)
            c1Format.SetAttribute("type", ct1Textbox.Text.ToLower)
            field1.SetAttribute("name", cv1bTextbox.Text.ToLower)
            field1.SetAttribute("include", "Y")
        End If
        c1Format.SetAttribute("position", "1")
        rdl.AppendChild(c1Format)
        fields.AppendChild(field1)


        'sets the second column in the rdl report format section of xml file
        c2Format.SetAttribute("text", xslDelimiter)
        c2Format.SetAttribute("type", "text")
        c2Format.SetAttribute("position", "2")
        rdl.AppendChild(c2Format)

        'sets the third column in the rdl report format section of xml file
        If ct2Textbox.Text = "Text" Then
            c3Format.SetAttribute(ct2Textbox.Text.ToLower, cv2aTextbox.Text.ToLower)
            c3Format.SetAttribute("type", ct2Textbox.Text.ToLower)
        End If
        If ct2Textbox.Text = "Dynamic" Then
            c3Format.SetAttribute("value", cv2aTextbox.Text.ToLower)
            c3Format.SetAttribute("type", "variable")
            field2.SetAttribute("name", cv2aTextbox.Text.ToLower)
            field2.SetAttribute("include", "Y")
        End If
        If ct2Textbox.Text = "Combo" Then
            c3Format.SetAttribute("value", cv2bTextbox.Text.ToLower)
            c3Format.SetAttribute("text", cv2aTextbox.Text.ToLower)
            c3Format.SetAttribute("type", ct2Textbox.Text.ToLower)
            field2.SetAttribute("name", cv2bTextbox.Text.ToLower)
            field2.SetAttribute("include", "Y")
        End If
        c3Format.SetAttribute("position", "3")
        rdl.AppendChild(c3Format)
        fields.AppendChild(field2)

        'sets the fourth column in the rdl report format section of xml file
        If ct3Textbox.Text <> "" Then
            c4Format.SetAttribute("text", xslDelimiter)
            c4Format.SetAttribute("type", "text")
            c4Format.SetAttribute("position", "4")
            rdl.AppendChild(c4Format)
        End If

        'sets the fifth column in the rdl report format section of xml file
        If ct3Textbox.Text <> "" Then
            If ct3Textbox.Text = "Text" Then
                c5Format.SetAttribute(ct3Textbox.Text.ToLower, cv3aTextbox.Text.ToLower)
                c5Format.SetAttribute("type", ct3Textbox.Text.ToLower)
            End If
            If ct3Textbox.Text = "Dynamic" Then
                c5Format.SetAttribute("value", cv3aTextbox.Text.ToLower)
                c5Format.SetAttribute("type", "variable")
                field3.SetAttribute("name", cv3aTextbox.Text.ToLower)
                field3.SetAttribute("include", "Y")
            End If
            If ct3Textbox.Text = "Combo" Then
                c5Format.SetAttribute("value", cv3bTextbox.Text.ToLower)
                c5Format.SetAttribute("text", cv3aTextbox.Text.ToLower)
                c5Format.SetAttribute("type", ct3Textbox.Text.ToLower)
                field3.SetAttribute("name", cv3bTextbox.Text.ToLower)
                field3.SetAttribute("include", "Y")
            End If
            c5Format.SetAttribute("position", "5")
            rdl.AppendChild(c5Format)
            fields.AppendChild(field3)
        End If

        'sets the sixth column in the rdl report format section of xml file
        If ct4Textbox.Text <> "" Then
            c6Format.SetAttribute("text", xslDelimiter)
            c6Format.SetAttribute("type", "text")
            c6Format.SetAttribute("position", "6")
            rdl.AppendChild(c6Format)
        End If

        'sets the seventh column in the rdl report format section of xml file
        If ct4Textbox.Text <> "" Then
            If ct4Textbox.Text = "Text" Then
                c7Format.SetAttribute(ct4Textbox.Text.ToLower, cv4aTextbox.Text.ToLower)
                c7Format.SetAttribute("type", ct4Textbox.Text.ToLower)
            End If
            If ct4Textbox.Text = "Dynamic" Then
                c7Format.SetAttribute("value", cv4aTextbox.Text.ToLower)
                c7Format.SetAttribute("type", "variable")
                field4.SetAttribute("name", cv4aTextbox.Text.ToLower)
                field4.SetAttribute("include", "Y")
            End If
            If ct4Textbox.Text = "Combo" Then
                c7Format.SetAttribute("value", cv4bTextbox.Text.ToLower)
                c7Format.SetAttribute("text", cv4aTextbox.Text.ToLower)
                c7Format.SetAttribute("type", ct4Textbox.Text.ToLower)
                field4.SetAttribute("name", cv4bTextbox.Text.ToLower)
                field4.SetAttribute("include", "Y")
            End If
            c7Format.SetAttribute("position", "7")
            rdl.AppendChild(c7Format)
            fields.AppendChild(field4)
        End If

        'sets the eighth column in the rdl report format section of xml file
        If ct5Textbox.Text <> "" Then
            c8Format.SetAttribute("text", xslDelimiter)
            c8Format.SetAttribute("type", "text")
            c8Format.SetAttribute("position", "8")
            rdl.AppendChild(c8Format)
        End If

        'sets the ninth column in the rdl report format section of xml file
        If ct5Textbox.Text <> "" Then
            If ct5Textbox.Text = "Text" Then
                c9Format.SetAttribute(ct5Textbox.Text.ToLower, cv5aTextbox.Text.ToLower)
                c9Format.SetAttribute("type", ct5Textbox.Text.ToLower)
            End If
            If ct5Textbox.Text = "Dynamic" Then
                c9Format.SetAttribute("value", cv5aTextbox.Text.ToLower)
                c9Format.SetAttribute("type", "variable")
                field5.SetAttribute("name", cv5aTextbox.Text.ToLower)
                field5.SetAttribute("include", "Y")
            End If
            If ct5Textbox.Text = "Combo" Then
                c9Format.SetAttribute("value", cv5bTextbox.Text.ToLower)
                c9Format.SetAttribute("text", cv5aTextbox.Text.ToLower)
                c9Format.SetAttribute("type", ct5Textbox.Text.ToLower)
                field5.SetAttribute("name", cv5bTextbox.Text.ToLower)
                field5.SetAttribute("include", "Y")
            End If
            c9Format.SetAttribute("position", "9")
            rdl.AppendChild(c9Format)
            fields.AppendChild(field5)
        End If

        'sets the tenth column in the rdl report format section of xml file
        If ct6Textbox.Text <> "" Then
            c10Format.SetAttribute("text", xslDelimiter)
            c10Format.SetAttribute("type", "text")
            c10Format.SetAttribute("position", "10")
            rdl.AppendChild(c10Format)
        End If

        'sets the eleventh column in the rdl report format section of xml file
        If ct6Textbox.Text <> "" Then
            If ct6Textbox.Text = "Text" Then
                c11Format.SetAttribute(ct6Textbox.Text.ToLower, cv6aTextbox.Text.ToLower)
                c11Format.SetAttribute("type", ct6Textbox.Text.ToLower)
            End If
            If ct6Textbox.Text = "Dynamic" Then
                c11Format.SetAttribute("value", cv6aTextbox.Text.ToLower)
                c11Format.SetAttribute("type", "variable")
                field6.SetAttribute("name", cv6aTextbox.Text.ToLower)
                field6.SetAttribute("include", "Y")
            End If
            If ct6Textbox.Text = "Combo" Then
                c11Format.SetAttribute("value", cv6bTextbox.Text.ToLower)
                c11Format.SetAttribute("text", cv6aTextbox.Text.ToLower)
                c11Format.SetAttribute("type", ct6Textbox.Text.ToLower)
                field6.SetAttribute("name", cv6bTextbox.Text.ToLower)
                field6.SetAttribute("include", "Y")
            End If
            c11Format.SetAttribute("position", "11")
            rdl.AppendChild(c11Format)
            fields.AppendChild(field6)
        End If

        'sets the twelfth column in the rdl report format section of xml file
        If ct7Textbox.Text <> "" Then
            c12Format.SetAttribute("text", xslDelimiter)
            c12Format.SetAttribute("type", "text")
            c12Format.SetAttribute("position", "12")
            rdl.AppendChild(c12Format)
        End If

        'sets the thirteenth column in the rdl report format section of xml file
        If ct7Textbox.Text <> "" Then
            If ct7Textbox.Text = "Text" Then
                c13Format.SetAttribute(ct7Textbox.Text.ToLower, cv7aTextbox.Text.ToLower)
                c13Format.SetAttribute("type", ct7Textbox.Text.ToLower)
            End If
            If ct7Textbox.Text = "Dynamic" Then
                c13Format.SetAttribute("value", cv7aTextbox.Text.ToLower)
                c13Format.SetAttribute("type", "variable")
                field7.SetAttribute("name", cv7aTextbox.Text.ToLower)
                field7.SetAttribute("include", "Y")
            End If
            If ct7Textbox.Text = "Combo" Then
                c13Format.SetAttribute("value", cv7bTextbox.Text.ToLower)
                c13Format.SetAttribute("text", cv7aTextbox.Text.ToLower)
                c13Format.SetAttribute("type", ct7Textbox.Text.ToLower)
                field7.SetAttribute("name", cv7bTextbox.Text.ToLower)
                field7.SetAttribute("include", "Y")
            End If
            c13Format.SetAttribute("position", "13")
            rdl.AppendChild(c13Format)
            fields.AppendChild(field7)
        End If


        'sets the fourteenth column in the rdl report format section of xml file
        If ct8Textbox.Text <> "" Then
            c14Format.SetAttribute("text", xslDelimiter)
            c14Format.SetAttribute("type", "text")
            c14Format.SetAttribute("position", "14")
            rdl.AppendChild(c14Format)
        End If


        'sets the fifteenth column in the rdl report format section of xml file
        If ct8Textbox.Text <> "" Then
            If ct8Textbox.Text = "Text" Then
                c15Format.SetAttribute(ct8Textbox.Text.ToLower, cv8aTextbox.Text.ToLower)
                c15Format.SetAttribute("type", ct8Textbox.Text.ToLower)
            End If
            If ct8Textbox.Text = "Dynamic" Then
                c15Format.SetAttribute("value", cv8aTextbox.Text.ToLower)
                c15Format.SetAttribute("type", "variable")
                field8.SetAttribute("name", cv8aTextbox.Text.ToLower)
                field8.SetAttribute("include", "Y")
            End If
            If ct8Textbox.Text = "Combo" Then
                c15Format.SetAttribute("value", cv8bTextbox.Text.ToLower)
                c15Format.SetAttribute("text", cv8aTextbox.Text.ToLower)
                c15Format.SetAttribute("type", ct8Textbox.Text.ToLower)
                field8.SetAttribute("name", cv8bTextbox.Text.ToLower)
                field8.SetAttribute("include", "Y")
            End If
            c15Format.SetAttribute("position", "15")
            rdl.AppendChild(c15Format)
            fields.AppendChild(field8)
        End If


        'sets the sixteenth column in the rdl report format section of xml file
        If ct9Textbox.Text <> "" Then
            c16Format.SetAttribute("text", xslDelimiter)
            c16Format.SetAttribute("type", "text")
            c16Format.SetAttribute("position", "16")
            rdl.AppendChild(c16Format)
        End If

        'sets the seventeenth column in the rdl report format section of xml file
        If ct9Textbox.Text <> "" Then
            If ct9Textbox.Text = "Text" Then
                c17Format.SetAttribute(ct9Textbox.Text.ToLower, cv9aTextbox.Text.ToLower)
                c17Format.SetAttribute("type", ct9Textbox.Text.ToLower)
            End If
            If ct9Textbox.Text = "Dynamic" Then
                c17Format.SetAttribute("value", cv9aTextbox.Text.ToLower)
                c17Format.SetAttribute("type", "variable")
                field9.SetAttribute("name", cv9aTextbox.Text.ToLower)
                field9.SetAttribute("include", "Y")
            End If
            If ct9Textbox.Text = "Combo" Then
                c17Format.SetAttribute("value", cv9bTextbox.Text.ToLower)
                c17Format.SetAttribute("text", cv9aTextbox.Text.ToLower)
                c17Format.SetAttribute("type", ct9Textbox.Text.ToLower)
                field9.SetAttribute("name", cv9bTextbox.Text.ToLower)
                field9.SetAttribute("include", "Y")
            End If
            c17Format.SetAttribute("position", "17")
            rdl.AppendChild(c17Format)
            fields.AppendChild(field9)
        End If

        'After all columns, add another position for the carriage return, line feed
        If fields.HasChildNodes Then
            Dim i As Integer = rdl.GetElementsByTagName("format").Count
            Dim lastFormat As XmlElement = newFile.CreateElement("format")
            i.ToString()
            lastFormat.SetAttribute("text", "&#13;&#10;")
            lastFormat.SetAttribute("type", "text")
            lastFormat.SetAttribute("position", i)
            rdl.AppendChild(lastFormat)
        End If



        ' Attempted to loop through but could not get the if section to apply attributes to the right elements.
        'Dim ctindex As Integer = 0
        'For Each ct As ComboBox In Panel1.Controls.OfType(Of ComboBox)()
        '    ctindex = ctindex + 1
        '    Dim format As XmlElement = newFile.CreateElement("format")
        '    format.SetAttribute("position", ctindex)
        '    format.SetAttribute("type", ct.Text)
        '    If ct.Text = "Text" Then
        '        format.SetAttribute("type", ct.Text)
        '        If ct.Text = "Variable" Then
        '            format.SetAttribute("type", ct.Text)
        '            If ct.Text = "Combo" Then
        '                format.SetAttribute("type", "variable")
        '                If ct.Text = "" Then Exit For
        '            End If
        '        End If
        '    End If
        '    rdl.AppendChild(format)
        'Next
        newFile.Save(path)
    End Sub

    Private Sub ct2Textbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ct2Textbox.SelectedIndexChanged
        If ct2Textbox.Text = "Combo" Then
            cv2bTextbox.Visible = True
        End If
        If ct2Textbox.Text = "Text" Then
            cv2bTextbox.Visible = False
        End If
        If ct2Textbox.Text = "Variable" Then
            cv2bTextbox.Visible = False
        End If
    End Sub

    Private Sub ct3Textbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ct3Textbox.SelectedIndexChanged
        If ct3Textbox.Text = "Combo" Then
            cv3bTextbox.Visible = True
        End If
        If ct3Textbox.Text = "Text" Then
            cv3bTextbox.Visible = False
        End If
        If ct3Textbox.Text = "Variable" Then
            cv3bTextbox.Visible = False
        End If
    End Sub


    Private Sub ct4Textbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ct4Textbox.SelectedIndexChanged
        If ct4Textbox.Text = "Combo" Then
            cv4bTextbox.Visible = True
        End If
        If ct4Textbox.Text = "Text" Then
            cv4bTextbox.Visible = False
        End If
        If ct4Textbox.Text = "Variable" Then
            cv4bTextbox.Visible = False
        End If
    End Sub


    Private Sub ct5Textbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ct5Textbox.SelectedIndexChanged
        If ct5Textbox.Text = "Combo" Then
            cv5bTextbox.Visible = True
        End If
        If ct5Textbox.Text = "Text" Then
            cv5bTextbox.Visible = False
        End If
        If ct5Textbox.Text = "Variable" Then
            cv5bTextbox.Visible = False
        End If
    End Sub

    Private Sub ct6Textbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ct6Textbox.SelectedIndexChanged
        If ct6Textbox.Text = "Combo" Then
            cv6bTextbox.Visible = True
        End If
        If ct6Textbox.Text = "Text" Then
            cv6bTextbox.Visible = False
        End If
        If ct6Textbox.Text = "Variable" Then
            cv6bTextbox.Visible = False
        End If
    End Sub

    Private Sub ct7Textbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ct7Textbox.SelectedIndexChanged
        If ct7Textbox.Text = "Combo" Then
            cv7bTextbox.Visible = True
        End If
        If ct7Textbox.Text = "Text" Then
            cv7bTextbox.Visible = False
        End If
        If ct7Textbox.Text = "Variable" Then
            cv7bTextbox.Visible = False
        End If
    End Sub


    Private Sub ct8Textbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ct8Textbox.SelectedIndexChanged
        If ct8Textbox.Text = "Combo" Then
            cv8bTextbox.Visible = True
        End If
        If ct8Textbox.Text = "Text" Then
            cv8bTextbox.Visible = False
        End If
        If ct8Textbox.Text = "Variable" Then
            cv8bTextbox.Visible = False
        End If
    End Sub


    Private Sub ct9Textbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ct9Textbox.SelectedIndexChanged
        If ct9Textbox.Text = "Combo" Then
            cv9bTextbox.Visible = True
        End If
        If ct9Textbox.Text = "Text" Then
            cv9bTextbox.Visible = False
        End If
        If ct9Textbox.Text = "Variable" Then
            cv9bTextbox.Visible = False
        End If

    End Sub



End Class