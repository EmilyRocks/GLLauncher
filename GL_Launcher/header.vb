Imports System.Xml

'collecting header items
Module HeaderItems
    Private headerFields As New List(Of String)
    Public Property getheaderFields As List(Of String)
        Get
            Return headerFields
        End Get
        Set(Val As List(Of String))
            headerFields.Add("")
        End Set
    End Property
End Module

Public Class Header
    'column separater value
    Dim xslDelimiter As String = delimiter


    Private Sub dynamic1Button_CheckedChanged(sender As Object, e As EventArgs) Handles dynamic1Button.CheckedChanged
        If dynamic1Button.Checked = "True" Then
            hd1Textbox.Items.Add("beginDate")
            hd1Textbox.Items.Add("checkDate")
            hd1Textbox.Items.Add("coID")
            hd1Textbox.Items.Add("endDate")
            hd1Textbox.Items.Add("endofMonthDate")
            hd1Textbox.Items.Add("process")
            hd1Textbox.Items.Add("processDate")
            hd1Textbox.Items.Add("row")
            hd1Textbox.Items.Add("rowSource")
        End If

        If dynamic1Button.Checked = "False" Then
            hd1Textbox.Items.Clear()
        End If
    End Sub

    Private Sub dynamic2Button_CheckedChanged(sender As Object, e As EventArgs) Handles dynamic2Button.CheckedChanged
        If dynamic2Button.Checked = "True" Then
            hd2Textbox.Items.Add("beginDate")
            hd2Textbox.Items.Add("checkDate")
            hd2Textbox.Items.Add("coID")
            hd2Textbox.Items.Add("endDate")
            hd2Textbox.Items.Add("endofMonthDate")
            hd2Textbox.Items.Add("process")
            hd2Textbox.Items.Add("processDate")
            hd2Textbox.Items.Add("row")
            hd2Textbox.Items.Add("rowSource")
        End If

        If dynamic2Button.Checked = "False" Then
            hd2Textbox.Items.Clear()
        End If
    End Sub

    Private Sub dynamic3Button_CheckedChanged(sender As Object, e As EventArgs) Handles dynamic3Button.CheckedChanged
        If dynamic3Button.Checked = "True" Then
            hd3Textbox.Items.Add("beginDate")
            hd3Textbox.Items.Add("checkDate")
            hd3Textbox.Items.Add("coID")
            hd3Textbox.Items.Add("endDate")
            hd3Textbox.Items.Add("endofMonthDate")
            hd3Textbox.Items.Add("process")
            hd3Textbox.Items.Add("processDate")
            hd3Textbox.Items.Add("row")
            hd3Textbox.Items.Add("rowSource")
        End If

        If dynamic3Button.Checked = "False" Then
            hd3Textbox.Items.Clear()
        End If
    End Sub


    Private Sub dynamic4Button_CheckedChanged(sender As Object, e As EventArgs) Handles dynamic4Button.CheckedChanged
        If dynamic4Button.Checked = "True" Then
            hd4Textbox.Items.Add("beginDate")
            hd4Textbox.Items.Add("checkDate")
            hd4Textbox.Items.Add("coID")
            hd4Textbox.Items.Add("endDate")
            hd4Textbox.Items.Add("endofMonthDate")
            hd4Textbox.Items.Add("process")
            hd4Textbox.Items.Add("processDate")
            hd4Textbox.Items.Add("row")
            hd4Textbox.Items.Add("rowSource")
        End If

        If dynamic4Button.Checked = "False" Then
            hd4Textbox.Items.Clear()
        End If
    End Sub

    Private Sub dynamic5Button_CheckedChanged(sender As Object, e As EventArgs) Handles dynamic5Button.CheckedChanged
        If dynamic5Button.Checked = "True" Then
            hd5Textbox.Items.Add("beginDate")
            hd5Textbox.Items.Add("checkDate")
            hd5Textbox.Items.Add("coID")
            hd5Textbox.Items.Add("endDate")
            hd5Textbox.Items.Add("endofMonthDate")
            hd5Textbox.Items.Add("process")
            hd5Textbox.Items.Add("processDate")
            hd5Textbox.Items.Add("row")
            hd5Textbox.Items.Add("rowSource")
        End If

        If dynamic5Button.Checked = "False" Then
            hd5Textbox.Items.Clear()
        End If
    End Sub

    Private Sub dynamic6Button_CheckedChanged(sender As Object, e As EventArgs) Handles dynamic6Button.CheckedChanged
        If dynamic6Button.Checked = "True" Then
            hd6Textbox.Items.Add("beginDate")
            hd6Textbox.Items.Add("checkDate")
            hd6Textbox.Items.Add("coID")
            hd6Textbox.Items.Add("endDate")
            hd6Textbox.Items.Add("endofMonthDate")
            hd6Textbox.Items.Add("process")
            hd6Textbox.Items.Add("processDate")
            hd6Textbox.Items.Add("row")
            hd6Textbox.Items.Add("rowSource")
        End If

        If dynamic6Button.Checked = "False" Then
            hd6Textbox.Items.Clear()
        End If
    End Sub

    Private Sub dynamic7Button_CheckedChanged(sender As Object, e As EventArgs) Handles dynamic7Button.CheckedChanged
        If dynamic7Button.Checked = "True" Then
            hd7Textbox.Items.Add("beginDate")
            hd7Textbox.Items.Add("checkDate")
            hd7Textbox.Items.Add("coID")
            hd7Textbox.Items.Add("endDate")
            hd7Textbox.Items.Add("endofMonthDate")
            hd7Textbox.Items.Add("process")
            hd7Textbox.Items.Add("processDate")
            hd7Textbox.Items.Add("row")
            hd7Textbox.Items.Add("rowSource")
        End If

        If dynamic7Button.Checked = "False" Then
            hd7Textbox.Items.Clear()
        End If
    End Sub

    Private Sub dynamic8Button_CheckedChanged(sender As Object, e As EventArgs) Handles dynamic8Button.CheckedChanged
        If dynamic8Button.Checked = "True" Then
            hd8Textbox.Items.Add("beginDate")
            hd8Textbox.Items.Add("checkDate")
            hd8Textbox.Items.Add("coID")
            hd8Textbox.Items.Add("endDate")
            hd8Textbox.Items.Add("endofMonthDate")
            hd8Textbox.Items.Add("process")
            hd8Textbox.Items.Add("processDate")
            hd8Textbox.Items.Add("row")
            hd8Textbox.Items.Add("rowSource")
        End If

        If dynamic8Button.Checked = "False" Then
            hd8Textbox.Items.Clear()
        End If
    End Sub

    Private Sub dynamic9Button_CheckedChanged(sender As Object, e As EventArgs) Handles dynamic9Button.CheckedChanged
        If dynamic9Button.Checked = "True" Then
            hd9Textbox.Items.Add("beginDate")
            hd9Textbox.Items.Add("checkDate")
            hd9Textbox.Items.Add("coID")
            hd9Textbox.Items.Add("endDate")
            hd9Textbox.Items.Add("endofMonthDate")
            hd9Textbox.Items.Add("process")
            hd9Textbox.Items.Add("processDate")
            hd9Textbox.Items.Add("row")
            hd9Textbox.Items.Add("rowSource")
        End If

        If dynamic9Button.Checked = "False" Then
            hd9Textbox.Items.Clear()
        End If
    End Sub

    Private Sub Header_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        If delimiter = "Comma" Then xslDelimiter = ","
        If delimiter = "Decimal" Then xslDelimiter = "."
        If delimiter = "Tab" Then xslDelimiter = "&#9;"

        If hd1Textbox.Text <> "" Then
            getheaderFields.Add(hd1Textbox.Text)
        End If
        If hd2Textbox.Text <> "" Then
            getheaderFields.Add(hd2Textbox.Text)
        End If
        If hd3Textbox.Text <> "" Then
            getheaderFields.Add(hd3Textbox.Text)
        End If
        If hd4Textbox.Text <> "" Then
            getheaderFields.Add(hd4Textbox.Text)
        End If
        If hd5Textbox.Text <> "" Then
            getheaderFields.Add(hd5Textbox.Text)
        End If
        If hd6Textbox.Text <> "" Then
            getheaderFields.Add(hd6Textbox.Text)
        End If
        If hd7Textbox.Text <> "" Then
            getheaderFields.Add(hd7Textbox.Text)
        End If
        If hd8Textbox.Text <> "" Then
            getheaderFields.Add(hd8Textbox.Text)
        End If
        If hd9Textbox.Text <> "" Then
            getheaderFields.Add(hd9Textbox.Text)
        End If

        'After all header text, adds carriage return, line feed
        If getheaderFields IsNot Nothing AndAlso getheaderFields.Count <> 0 Then
            getheaderFields.Add("&#13;&#10;")
        End If

        'adds header information to xml document
        Dim newFile As New XmlDocument
        Dim path As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\newFile.xml"
        newFile.Load(path)
        Dim nsmgr As New XmlNamespaceManager(newFile.NameTable)
        Dim h1 As XmlElement = newFile.CreateElement("header")
        Dim rdl As XmlElement = newFile.SelectSingleNode(xpath:="//rdlReportFormat")
        Dim header1Content As String
        header1Content = String.Join(xslDelimiter, getheaderFields)

        h1.SetAttribute("text", header1Content)
        h1.SetAttribute("type", "text")
        h1.SetAttribute("position", "1")
        rdl.PrependChild(h1)

        'sanity check for header data
        'MessageBox.Show(text:=header1Content)

        newFile.Save(path)
    End Sub



End Class
