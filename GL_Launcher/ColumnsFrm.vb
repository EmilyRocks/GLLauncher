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
    'dateformat stuff
    Public Property DateList1 As String()
        Get
            Return dateList
        End Get
        Set(value As String())
            dateList = value
        End Set
    End Property

    Dim cdmisctrigger As String
    Public Property Cdmisctrigger1 As String
        Get
            Return cdmisctrigger
        End Get
        Set(value As String)
            cdmisctrigger = value
        End Set
    End Property

    Dim dateList() As String = {"beginDate", "checkDate", "endDate", "endofMonthDate", "processDate"}

End Module
Module dtFormatListmod
    Private dtFormatList As New List(Of String)
    Public Property getdtFormatList As List(Of String)
        Get
            Return dtFormatList
        End Get
        Set(Val As List(Of String))
            dtFormatList.Add("")
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
        If ct1Textbox.Text = "combo" Then
            cv1bTextbox.Visible = True
        End If
        If ct1Textbox.Text = "text" Then
            cv1bTextbox.Visible = False
        End If
        If ct1Textbox.Text = "variable" Then
            cv1bTextbox.Visible = False
        End If
    End Sub




    Private Sub ColumnsFrm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim newFile As New XmlDocument
        Dim path As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\newFile.xml"
        newFile.Load(path)
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
        Dim rdlMisc As XmlElement = newFile.SelectSingleNode(xpath:="parms/rdl/miscellaneous")
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
        Dim misc1 As XmlElement = newFile.CreateElement("misc")
        Dim misc2 As XmlElement = newFile.CreateElement("misc")
        Dim fieldcheck As New List(Of String)
        Dim amtcheck As New List(Of String)
        Dim amtOptions As New List(Of String)
        amtOptions.Add("absAmount")
        amtOptions.Add("debit")
        amtOptions.Add("credit")






        'column separater value
        Dim xslDelimiter As String = delimiter
        If delimiter = "Comma" Then xslDelimiter = ","
        If delimiter = "Decimal" Then xslDelimiter = "."
        If delimiter = "Tab" Then xslDelimiter = "&#9;"

        'sets the first column in the rdl report format section of xml file
        'if text selected
        If ct1Textbox.Text = "text" Then
            c1Format.SetAttribute(ct1Textbox.Text, cv1aTextbox.Text)
            c1Format.SetAttribute("type", ct1Textbox.Text)
        End If
        'if a value is needed
        If ct1Textbox.Text = "dynamic" Then
            'if amount has formatting but is required in rdl otherwise just whatever value is selected
            If amtOptions.Contains(amtFormatButton1.Text) Then
                c1Format.SetAttribute("value", amtFormatButton1.Text)
            Else
                c1Format.SetAttribute("value", cv1aTextbox.Text)
            End If
            c1Format.SetAttribute("type", "variable")
            field1.SetAttribute("name", cv1aTextbox.Text)
            field1.SetAttribute("include", "Y")
            amtcheck.Add(amtFormatButton1.Text)
        End If
        'if a text item and a value are needed
        If ct1Textbox.Text = "combo" Then
            c1Format.SetAttribute("text", cv1aTextbox.Text)
            c1Format.SetAttribute("value", cv1bTextbox.Text)
            c1Format.SetAttribute("type", ct1Textbox.Text)
            field1.SetAttribute("name", cv1bTextbox.Text)
            field1.SetAttribute("include", "Y")
        End If
        'sets the column
        c1Format.SetAttribute("position", "1")
        'adds to rdl format
        rdl.AppendChild(c1Format)
        'adds to fields
        fields.AppendChild(field1)
        'adds to array to prevent duplicates works on dynamic values only atm
        fieldcheck.Add(field1.GetAttribute("name"))



        'sets the second column in the rdl report format section of xml file
        c2Format.SetAttribute("text", xslDelimiter)
        c2Format.SetAttribute("type", "text")
        c2Format.SetAttribute("position", "2")
        rdl.AppendChild(c2Format)

        'sets the third column in the rdl report format section of xml file
        If ct2Textbox.Text = "text" Then
            c3Format.SetAttribute(ct2Textbox.Text, cv2aTextbox.Text)
            c3Format.SetAttribute("type", ct2Textbox.Text)
        End If
        If ct2Textbox.Text = "dynamic" Then
            If amtOptions.Contains(amtFormatButton2.Text) Then
                c3Format.SetAttribute("value", amtFormatButton2.Text)
            Else
                c3Format.SetAttribute("value", cv2aTextbox.Text)
            End If
            c3Format.SetAttribute("type", "variable")
            field2.SetAttribute("name", cv2aTextbox.Text)
            field2.SetAttribute("include", "Y")
            amtcheck.Add(amtFormatButton2.Text)
        End If
        If ct2Textbox.Text = "combo" Then
            c3Format.SetAttribute("value", cv2bTextbox.Text)
            c3Format.SetAttribute("text", cv2aTextbox.Text)
            c3Format.SetAttribute("type", ct2Textbox.Text)
            field2.SetAttribute("name", cv2bTextbox.Text)
            field2.SetAttribute("include", "Y")
        End If
        c3Format.SetAttribute("position", "3")
        rdl.AppendChild(c3Format)
        'code differs here to start checking array to look to see if the variable is already included in the sp fields list, if not then it adds it
        If Not fieldcheck.Contains(cv2aTextbox.Text) Then
            fields.AppendChild(field2)
            fieldcheck.Add(field2.GetAttribute("name"))
        End If

        'sets the fourth column in the rdl report format section of xml file
        If ct3Textbox.Text <> "" Then
            c4Format.SetAttribute("text", xslDelimiter)
            c4Format.SetAttribute("type", "text")
            c4Format.SetAttribute("position", "4")
            rdl.AppendChild(c4Format)
        End If

        'sets the fifth column in the rdl report format section of xml file
        If ct3Textbox.Text <> "" Then
            If ct3Textbox.Text = "text" Then
                c5Format.SetAttribute(ct3Textbox.Text, cv3aTextbox.Text)
                c5Format.SetAttribute("type", ct3Textbox.Text)
            End If
            If ct3Textbox.Text = "dynamic" Then
                If amtOptions.Contains(amtFormatButton3.Text) Then
                    c5Format.SetAttribute("value", amtFormatButton3.Text)
                Else
                    c5Format.SetAttribute("value", cv3aTextbox.Text)
                End If
                c5Format.SetAttribute("type", "variable")
                field3.SetAttribute("name", cv3aTextbox.Text)
                field3.SetAttribute("include", "Y")
                amtcheck.Add(amtFormatButton3.Text)
            End If
            If ct3Textbox.Text = "combo" Then
                c5Format.SetAttribute("value", cv3bTextbox.Text)
                c5Format.SetAttribute("text", cv3aTextbox.Text)
                c5Format.SetAttribute("type", ct3Textbox.Text)
                field3.SetAttribute("name", cv3bTextbox.Text)
                field3.SetAttribute("include", "Y")
            End If
            c5Format.SetAttribute("position", "5")
            rdl.AppendChild(c5Format)
            If Not fieldcheck.Contains(cv3aTextbox.Text) Then
                fields.AppendChild(field3)
                fieldcheck.Add(field3.GetAttribute("name"))
            End If
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
            If ct4Textbox.Text = "text" Then
                c7Format.SetAttribute(ct4Textbox.Text, cv4aTextbox.Text)
                c7Format.SetAttribute("type", ct4Textbox.Text)
            End If
            If ct4Textbox.Text = "dynamic" Then
                If amtOptions.Contains(amtFormatButton4.Text) Then
                    c7Format.SetAttribute("value", amtFormatButton4.Text)
                Else
                    c7Format.SetAttribute("value", cv4aTextbox.Text)
                End If
                c7Format.SetAttribute("type", "variable")
                field4.SetAttribute("name", cv4aTextbox.Text)
                field4.SetAttribute("include", "Y")
                amtcheck.Add(amtFormatButton4.Text)
            End If
            If ct4Textbox.Text = "combo" Then
                c7Format.SetAttribute("value", cv4bTextbox.Text)
                c7Format.SetAttribute("text", cv4aTextbox.Text)
                c7Format.SetAttribute("type", ct4Textbox.Text)
                field4.SetAttribute("name", cv4bTextbox.Text)
                field4.SetAttribute("include", "Y")
            End If
            c7Format.SetAttribute("position", "7")
            rdl.AppendChild(c7Format)
            If Not fieldcheck.Contains(cv4aTextbox.Text) Then
                fields.AppendChild(field4)
                fieldcheck.Add(field4.GetAttribute("name"))
            End If
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
            If ct5Textbox.Text = "text" Then
                c9Format.SetAttribute(ct5Textbox.Text, cv5aTextbox.Text)
                c9Format.SetAttribute("type", ct5Textbox.Text)
            End If
            If ct5Textbox.Text = "dynamic" Then
                If amtOptions.Contains(amtFormatButton5.Text) Then
                    c9Format.SetAttribute("value", amtFormatButton5.Text)
                Else
                    c9Format.SetAttribute("value", cv5aTextbox.Text)
                End If
                c9Format.SetAttribute("type", "variable")
                field5.SetAttribute("name", cv5aTextbox.Text)
                field5.SetAttribute("include", "Y")
                amtcheck.Add(amtFormatButton5.Text)
            End If
            If ct5Textbox.Text = "combo" Then
                c9Format.SetAttribute("value", cv5bTextbox.Text)
                c9Format.SetAttribute("text", cv5aTextbox.Text)
                c9Format.SetAttribute("type", ct5Textbox.Text)
                field5.SetAttribute("name", cv5bTextbox.Text)
                field5.SetAttribute("include", "Y")
            End If
            c9Format.SetAttribute("position", "9")
            rdl.AppendChild(c9Format)
            If Not fieldcheck.Contains(cv5aTextbox.Text) Then
                fields.AppendChild(field5)
                fieldcheck.Add(field5.GetAttribute("name"))
            End If
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
            If ct6Textbox.Text = "text" Then
                c11Format.SetAttribute(ct6Textbox.Text, cv6aTextbox.Text)
                c11Format.SetAttribute("type", ct6Textbox.Text)
            End If
            If ct6Textbox.Text = "dynamic" Then
                If amtOptions.Contains(amtFormatButton6.Text) Then
                    c11Format.SetAttribute("value", amtFormatButton6.Text)
                Else
                    c11Format.SetAttribute("value", cv6aTextbox.Text)
                End If
                c11Format.SetAttribute("type", "variable")
                field6.SetAttribute("name", cv6aTextbox.Text)
                field6.SetAttribute("include", "Y")
                amtcheck.Add(amtFormatButton6.Text)
            End If
            If ct6Textbox.Text = "combo" Then
                c11Format.SetAttribute("value", cv6bTextbox.Text)
                c11Format.SetAttribute("text", cv6aTextbox.Text)
                c11Format.SetAttribute("type", ct6Textbox.Text)
                field6.SetAttribute("name", cv6bTextbox.Text)
                field6.SetAttribute("include", "Y")
            End If
            c11Format.SetAttribute("position", "11")
            rdl.AppendChild(c11Format)
            If Not fieldcheck.Contains(cv6aTextbox.Text) Then
                fields.AppendChild(field6)
                fieldcheck.Add(field6.GetAttribute("name"))
            End If
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
            If ct7Textbox.Text = "text" Then
                c13Format.SetAttribute(ct7Textbox.Text, cv7aTextbox.Text)
                c13Format.SetAttribute("type", ct7Textbox.Text)
            End If
            If ct7Textbox.Text = "dynamic" Then
                If amtOptions.Contains(amtFormatButton7.Text) Then
                    c13Format.SetAttribute("value", amtFormatButton7.Text)
                Else
                    c13Format.SetAttribute("value", cv7aTextbox.Text)
                End If
                c13Format.SetAttribute("type", "variable")
                field7.SetAttribute("name", cv7aTextbox.Text)
                field7.SetAttribute("include", "Y")
                amtcheck.Add(amtFormatButton7.Text)
            End If
            If ct7Textbox.Text = "combo" Then
                c13Format.SetAttribute("value", cv7bTextbox.Text)
                c13Format.SetAttribute("text", cv7aTextbox.Text)
                c13Format.SetAttribute("type", ct7Textbox.Text)
                field7.SetAttribute("name", cv7bTextbox.Text)
                field7.SetAttribute("include", "Y")
            End If
            c13Format.SetAttribute("position", "13")
            rdl.AppendChild(c13Format)
            If Not fieldcheck.Contains(cv7aTextbox.Text) Then
                fields.AppendChild(field7)
                fieldcheck.Add(field7.GetAttribute("name"))
            End If
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
            If ct8Textbox.Text = "text" Then
                c15Format.SetAttribute(ct8Textbox.Text, cv8aTextbox.Text)
                c15Format.SetAttribute("type", ct8Textbox.Text)
            End If
            If ct8Textbox.Text = "dynamic" Then
                If amtOptions.Contains(amtFormatButton8.Text) Then
                    c15Format.SetAttribute("value", amtFormatButton8.Text)
                Else
                    c15Format.SetAttribute("value", cv8aTextbox.Text)
                End If
                c15Format.SetAttribute("type", "variable")
                field8.SetAttribute("name", cv8aTextbox.Text)
                field8.SetAttribute("include", "Y")
                amtcheck.Add(amtFormatButton8.Text)
            End If
            If ct8Textbox.Text = "combo" Then
                c15Format.SetAttribute("value", cv8bTextbox.Text)
                c15Format.SetAttribute("text", cv8aTextbox.Text)
                c15Format.SetAttribute("type", ct8Textbox.Text)
                field8.SetAttribute("name", cv8bTextbox.Text)
                field8.SetAttribute("include", "Y")
            End If
            c15Format.SetAttribute("position", "15")
            rdl.AppendChild(c15Format)
            If Not fieldcheck.Contains(cv8aTextbox.Text) Then
                fields.AppendChild(field8)
                fieldcheck.Add(field8.GetAttribute("name"))
            End If
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
            If ct9Textbox.Text = "text" Then
                c17Format.SetAttribute(ct9Textbox.Text, cv9aTextbox.Text)
                c17Format.SetAttribute("type", ct9Textbox.Text)
            End If
            If ct9Textbox.Text = "dynamic" Then
                If amtOptions.Contains(amtFormatButton9.Text) Then
                    c17Format.SetAttribute("value", amtFormatButton9.Text)
                Else
                    c17Format.SetAttribute("value", cv9aTextbox.Text)
                End If
                c17Format.SetAttribute("type", "variable")
                field9.SetAttribute("name", cv9aTextbox.Text)
                field9.SetAttribute("include", "Y")
                amtcheck.Add(amtFormatButton9.Text)
            End If
            If ct9Textbox.Text = "combo" Then
                c17Format.SetAttribute("value", cv9bTextbox.Text)
                c17Format.SetAttribute("text", cv9aTextbox.Text)
                c17Format.SetAttribute("type", ct9Textbox.Text)
                field9.SetAttribute("name", cv9bTextbox.Text)
                field9.SetAttribute("include", "Y")
            End If
            c17Format.SetAttribute("position", "17")
            rdl.AppendChild(c17Format)
            If Not fieldcheck.Contains(cv9aTextbox.Text) Then
                fields.AppendChild(field9)
                fieldcheck.Add(field9.GetAttribute("name"))
            End If
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

        'this code declares the location of a specific node by specific attribute and deletes it
        Dim cdnode As XmlNode = fields.SelectSingleNode("//field[@name='cd']")
        If cdnode IsNot Nothing Then
            cdnode.RemoveAll()
            Cdmisctrigger1 = "yes"
        End If


        'turn on for sanity check during testing to see if cd works
        'Dim testcd As String
        'testcd = cdnode.ToString
        'MessageBox.Show(text:=testcd)


        'sets misc absvalue line
        If amtcheck.Contains("absAmount") Then
            misc1.SetAttribute("include", "Y")
            misc1.SetAttribute("name", "absAmount")
            rdlMisc.AppendChild(misc1)
        End If

        'setes misc nodecimal line
        If amtcheck.Contains("noDecimal") Then
            misc2.SetAttribute("include", "Y")
            misc2.SetAttribute("name", "noDecimal")
            rdlMisc.AppendChild(misc2)
        End If

        'adding date formats 
        Dim dateFormat1 As XmlElement = newFile.CreateElement("date")
        Dim dateFormat2 As XmlElement = newFile.CreateElement("date")
        Dim dateFormat3 As XmlElement = newFile.CreateElement("date")
        Dim dateFormat4 As XmlElement = newFile.CreateElement("date")
        Dim dateFormat5 As XmlElement = newFile.CreateElement("date")
        Dim dateFormat6 As XmlElement = newFile.CreateElement("date")
        Dim dateFormat7 As XmlElement = newFile.CreateElement("date")
        Dim dateFormat8 As XmlElement = newFile.CreateElement("date")
        Dim dateFormat9 As XmlElement = newFile.CreateElement("date")
        Dim dates As XmlElement = newFile.SelectSingleNode(xpath:="//dates")
        Dim cnt As Integer = 0
        Dim dateCheck As New List(Of String)

        If dtFormatButton1.Visible = True Then
            dateFormat1.SetAttribute("format", dtFormatButton1.Text)
            dateFormat1.SetAttribute("name", cv1aTextbox.Text)
            dates.AppendChild(dateFormat1)
            dateCheck.Add(cv1aTextbox.Text)
        End If

        If dtFormatButton2.Visible = True Then
            If dateCheck.Contains(cv2aTextbox.Text) Then
                cnt = cnt + 1
                dateFormat2.SetAttribute("date", cv2aTextbox.Text)
                dateFormat2.SetAttribute("format", dtFormatButton2.Text)
                dateFormat2.SetAttribute("name", "date" & cnt.ToString)
                dates.AppendChild(dateFormat2)
            Else
                dateFormat2.SetAttribute("format", dtFormatButton2.Text)
                dateFormat2.SetAttribute("name", cv2aTextbox.Text)
                dates.AppendChild(dateFormat2)
                dateCheck.Add(cv2aTextbox.Text)
            End If
        End If

        If dtFormatButton3.Visible = True Then
            If dateCheck.Contains(cv3aTextbox.Text) Then
                cnt = cnt + 1
                dateFormat3.SetAttribute("date", cv3aTextbox.Text)
                dateFormat3.SetAttribute("format", dtFormatButton3.Text)
                dateFormat3.SetAttribute("name", "date" & cnt.ToString)
                dates.AppendChild(dateFormat3)
            Else
                dateFormat3.SetAttribute("format", dtFormatButton3.Text)
                dateFormat3.SetAttribute("name", cv3aTextbox.Text)
                dates.AppendChild(dateFormat3)
                dateCheck.Add(cv3aTextbox.Text)
            End If
        End If

        If dtFormatButton4.Visible = True Then
            If dateCheck.Contains(cv4aTextbox.Text) Then
                cnt = cnt + 1
                dateFormat4.SetAttribute("date", cv4aTextbox.Text)
                dateFormat4.SetAttribute("format", dtFormatButton4.Text)
                dateFormat4.SetAttribute("name", "date" & cnt.ToString)
                dates.AppendChild(dateFormat4)
            Else
                dateFormat4.SetAttribute("format", dtFormatButton4.Text)
                dateFormat4.SetAttribute("name", cv4aTextbox.Text)
                dates.AppendChild(dateFormat4)
                dateCheck.Add(cv4aTextbox.Text)
            End If
        End If

        If dtFormatButton5.Visible = True Then
            If dateCheck.Contains(cv5aTextbox.Text) Then
                cnt = cnt + 1
                dateFormat5.SetAttribute("date", cv5aTextbox.Text)
                dateFormat5.SetAttribute("format", dtFormatButton5.Text)
                dateFormat5.SetAttribute("name", "date" & cnt.ToString)
                dates.AppendChild(dateFormat5)
            Else
                dateFormat5.SetAttribute("format", dtFormatButton5.Text)
                dateFormat5.SetAttribute("name", cv5aTextbox.Text)
                dates.AppendChild(dateFormat5)
                dateCheck.Add(cv5aTextbox.Text)
            End If
        End If

        If dtFormatButton6.Visible = True Then
            If dateCheck.Contains(cv6aTextbox.Text) Then
                cnt = cnt + 1
                dateFormat6.SetAttribute("date", cv6aTextbox.Text)
                dateFormat6.SetAttribute("format", dtFormatButton6.Text)
                dateFormat6.SetAttribute("name", "date" & cnt.ToString)
                dates.AppendChild(dateFormat6)
            Else
                dateFormat6.SetAttribute("format", dtFormatButton6.Text)
                dateFormat6.SetAttribute("name", cv6aTextbox.Text)
                dates.AppendChild(dateFormat6)
                dateCheck.Add(cv6aTextbox.Text)
            End If
        End If

        If dtFormatButton7.Visible = True Then
            If dateCheck.Contains(cv7aTextbox.Text) Then
                cnt = cnt + 1
                dateFormat7.SetAttribute("date", cv7aTextbox.Text)
                dateFormat7.SetAttribute("format", dtFormatButton7.Text)
                dateFormat7.SetAttribute("name", "date" & cnt.ToString)
                dates.AppendChild(dateFormat7)
            Else
                dateFormat7.SetAttribute("format", dtFormatButton7.Text)
                dateFormat7.SetAttribute("name", cv7aTextbox.Text)
                dates.AppendChild(dateFormat7)
                dateCheck.Add(cv7aTextbox.Text)
            End If
        End If

        If dtFormatButton8.Visible = True Then
            If dateCheck.Contains(cv8aTextbox.Text) Then
                cnt = cnt + 1
                dateFormat8.SetAttribute("date", cv8aTextbox.Text)
                dateFormat8.SetAttribute("format", dtFormatButton8.Text)
                dateFormat8.SetAttribute("name", "date" & cnt.ToString)
                dates.AppendChild(dateFormat8)
            Else
                dateFormat8.SetAttribute("format", dtFormatButton8.Text)
                dateFormat8.SetAttribute("name", cv8aTextbox.Text)
                dates.AppendChild(dateFormat8)
                dateCheck.Add(cv8aTextbox.Text)
            End If
        End If

        If dtFormatButton9.Visible = True Then
            If dateCheck.Contains(cv9aTextbox.Text) Then
                cnt = cnt + 1
                dateFormat9.SetAttribute("date", cv9aTextbox.Text)
                dateFormat9.SetAttribute("format", dtFormatButton9.Text)
                dateFormat9.SetAttribute("name", "date" & cnt.ToString)
                dates.AppendChild(dateFormat9)
            Else
                dateFormat9.SetAttribute("format", dtFormatButton9.Text)
                dateFormat9.SetAttribute("name", cv9aTextbox.Text)
                dates.AppendChild(dateFormat9)
                dateCheck.Add(cv9aTextbox.Text)
            End If
        End If



        ' Attempted to loop through but could not get the if section to apply attributes to the right elements. Play with later.
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

    'these subs turn on the second box for the combo text value options
    Private Sub ct2Textbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ct2Textbox.SelectedIndexChanged
        If ct2Textbox.Text = "combo" Then
            cv2bTextbox.Visible = True
        End If
        If ct2Textbox.Text = "text" Then
            cv2bTextbox.Visible = False
        End If
        If ct2Textbox.Text = "variable" Then
            cv2bTextbox.Visible = False
        End If
    End Sub

    Private Sub ct3Textbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ct3Textbox.SelectedIndexChanged
        If ct3Textbox.Text = "combo" Then
            cv3bTextbox.Visible = True
        End If
        If ct3Textbox.Text = "text" Then
            cv3bTextbox.Visible = False
        End If
        If ct3Textbox.Text = "variable" Then
            cv3bTextbox.Visible = False
        End If
    End Sub


    Private Sub ct4Textbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ct4Textbox.SelectedIndexChanged
        If ct4Textbox.Text = "combo" Then
            cv4bTextbox.Visible = True
        End If
        If ct4Textbox.Text = "text" Then
            cv4bTextbox.Visible = False
        End If
        If ct4Textbox.Text = "variable" Then
            cv4bTextbox.Visible = False
        End If
    End Sub


    Private Sub ct5Textbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ct5Textbox.SelectedIndexChanged
        If ct5Textbox.Text = "combo" Then
            cv5bTextbox.Visible = True
        End If
        If ct5Textbox.Text = "text" Then
            cv5bTextbox.Visible = False
        End If
        If ct5Textbox.Text = "variable" Then
            cv5bTextbox.Visible = False
        End If
    End Sub

    Private Sub ct6Textbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ct6Textbox.SelectedIndexChanged
        If ct6Textbox.Text = "combo" Then
            cv6bTextbox.Visible = True
        End If
        If ct6Textbox.Text = "text" Then
            cv6bTextbox.Visible = False
        End If
        If ct6Textbox.Text = "variable" Then
            cv6bTextbox.Visible = False
        End If
    End Sub

    Private Sub ct7Textbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ct7Textbox.SelectedIndexChanged
        If ct7Textbox.Text = "combo" Then
            cv7bTextbox.Visible = True
        End If
        If ct7Textbox.Text = "text" Then
            cv7bTextbox.Visible = False
        End If
        If ct7Textbox.Text = "variable" Then
            cv7bTextbox.Visible = False
        End If
    End Sub


    Private Sub ct8Textbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ct8Textbox.SelectedIndexChanged
        If ct8Textbox.Text = "combo" Then
            cv8bTextbox.Visible = True
        End If
        If ct8Textbox.Text = "text" Then
            cv8bTextbox.Visible = False
        End If
        If ct8Textbox.Text = "variable" Then
            cv8bTextbox.Visible = False
        End If
    End Sub


    Private Sub ct9Textbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ct9Textbox.SelectedIndexChanged
        If ct9Textbox.Text = "combo" Then
            cv9bTextbox.Visible = True
        End If
        If ct9Textbox.Text = "text" Then
            cv9bTextbox.Visible = False
        End If
        If ct9Textbox.Text = "variable" Then
            cv9bTextbox.Visible = False
        End If

    End Sub

    'shows date or amount format boxes
    Private Sub cv1aTextbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cv1aTextbox.SelectedIndexChanged
        If DateList1.Contains(cv1aTextbox.Text) Then
            dtFormatButton1.Visible = True
        End If
        If cv1aTextbox.Text = "amount" Then
            amtFormatButton1.Visible = True
        End If
    End Sub
    Private Sub cv2aTextbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cv2aTextbox.SelectedIndexChanged
        If DateList1.Contains(cv2aTextbox.Text) Then
            dtFormatButton2.Visible = True
        End If
        If cv2aTextbox.Text = "amount" Then
            amtFormatButton2.Visible = True
        End If
    End Sub
    Private Sub cv3aTextbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cv3aTextbox.SelectedIndexChanged
        If DateList1.Contains(cv3aTextbox.Text) Then
            dtFormatButton3.Visible = True
        End If
        If cv3aTextbox.Text = "amount" Then
            amtFormatButton3.Visible = True
        End If
    End Sub
    Private Sub cv4aTextbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cv4aTextbox.SelectedIndexChanged
        If DateList1.Contains(cv4aTextbox.Text) Then
            dtFormatButton4.Visible = True
        End If
        If cv4aTextbox.Text = "amount" Then
            amtFormatButton4.Visible = True
        End If
    End Sub
    Private Sub cv5aTextbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cv5aTextbox.SelectedIndexChanged
        If DateList1.Contains(cv5aTextbox.Text) Then
            dtFormatButton5.Visible = True
        End If
        If cv5aTextbox.Text = "amount" Then
            amtFormatButton5.Visible = True
        End If
    End Sub
    Private Sub cv6aTextbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cv6aTextbox.SelectedIndexChanged
        If DateList1.Contains(cv6aTextbox.Text) Then
            dtFormatButton6.Visible = True
        End If
        If cv6aTextbox.Text = "amount" Then
            amtFormatButton6.Visible = True
        End If
    End Sub
    Private Sub cv7aTextbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cv7aTextbox.SelectedIndexChanged
        If DateList1.Contains(cv7aTextbox.Text) Then
            dtFormatButton7.Visible = True
        End If
        If cv7aTextbox.Text = "amount" Then
            amtFormatButton7.Visible = True
        End If
    End Sub
    Private Sub cv8aTextbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cv8aTextbox.SelectedIndexChanged
        If DateList1.Contains(cv8aTextbox.Text) Then
            dtFormatButton8.Visible = True
        End If
        If cv8aTextbox.Text = "amount" Then
            amtFormatButton8.Visible = True
        End If
    End Sub
    Private Sub cv9aTextbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cv9aTextbox.SelectedIndexChanged
        If DateList1.Contains(cv9aTextbox.Text) Then
            dtFormatButton9.Visible = True
        End If
        If cv9aTextbox.Text = "amount" Then
            amtFormatButton9.Visible = True
        End If
    End Sub
    Private Sub cv1bTextbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cv1bTextbox.SelectedIndexChanged
        If DateList1.Contains(cv1bTextbox.Text) Then
            dtFormatButton1.Visible = True
        End If
        If cv1bTextbox.Text = "amount" Then
            amtFormatButton1.Visible = True
        End If
    End Sub
    Private Sub cv2bTextbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cv2bTextbox.SelectedIndexChanged
        If DateList1.Contains(cv2bTextbox.Text) Then
            dtFormatButton2.Visible = True
        End If
        If cv2bTextbox.Text = "amount" Then
            amtFormatButton2.Visible = True
        End If
    End Sub
    Private Sub cv3bTextbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cv3bTextbox.SelectedIndexChanged
        If DateList1.Contains(cv3bTextbox.Text) Then
            dtFormatButton3.Visible = True
        End If
        If cv3bTextbox.Text = "amount" Then
            amtFormatButton3.Visible = True
        End If
    End Sub
    Private Sub cv4bTextbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cv4bTextbox.SelectedIndexChanged
        If DateList1.Contains(cv4bTextbox.Text) Then
            dtFormatButton4.Visible = True
        End If
        If cv4bTextbox.Text = "amount" Then
            amtFormatButton4.Visible = True
        End If
    End Sub
    Private Sub cv5bTextbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cv5bTextbox.SelectedIndexChanged
        If DateList1.Contains(cv5bTextbox.Text) Then
            dtFormatButton5.Visible = True
        End If
        If cv5bTextbox.Text = "amount" Then
            amtFormatButton5.Visible = True
        End If
    End Sub
    Private Sub cv6bTextbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cv6bTextbox.SelectedIndexChanged
        If DateList1.Contains(cv6bTextbox.Text) Then
            dtFormatButton6.Visible = True
        End If
        If cv6bTextbox.Text = "amount" Then
            amtFormatButton6.Visible = True
        End If
    End Sub
    Private Sub cv7bTextbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cv7bTextbox.SelectedIndexChanged
        If DateList1.Contains(cv7bTextbox.Text) Then
            dtFormatButton7.Visible = True
        End If
        If cv7bTextbox.Text = "amount" Then
            amtFormatButton7.Visible = True
        End If
    End Sub
    Private Sub cv8bTextbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cv8bTextbox.SelectedIndexChanged
        If DateList1.Contains(cv8bTextbox.Text) Then
            dtFormatButton8.Visible = True
        End If
        If cv8bTextbox.Text = "amount" Then
            amtFormatButton8.Visible = True
        End If
    End Sub
    Private Sub cv9bTextbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cv9bTextbox.SelectedIndexChanged
        If DateList1.Contains(cv9bTextbox.Text) Then
            dtFormatButton9.Visible = True
        End If
        If cv9bTextbox.Text = "amount" Then
            amtFormatButton9.Visible = True
        End If
    End Sub
End Class