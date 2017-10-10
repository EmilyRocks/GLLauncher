Imports System.Xml

'collecting header items
Module HeaderItems
    Private headerFields1a As New List(Of String)
    Public Property getheaderFields1a As List(Of String)
        Get
            Return headerFields1a
        End Get
        Set(Val As List(Of String))
            headerFields1a.Add("")
        End Set
    End Property

    Private headerFields1bb As New List(Of String)
    Public Property GetheaderFields1bb As List(Of String)
        Get
            Return headerFields1bb
        End Get
        Set(Val As List(Of String))
            headerFields1bb.Add("")
        End Set
    End Property

    Private headerFields1c As New List(Of String)
    Public Property getheaderFields1c As List(Of String)
        Get
            Return headerFields1c
        End Get
        Set(Val As List(Of String))
            headerFields1c.Add("")
        End Set
    End Property

    Private headerFields1d As New List(Of String)
    Public Property getheaderFields1d As List(Of String)
        Get
            Return headerFields1d
        End Get
        Set(Val As List(Of String))
            headerFields1d.Add("")
        End Set
    End Property

    Private headerFields1e As New List(Of String)
    Public Property getheaderFields1e As List(Of String)
        Get
            Return headerFields1e
        End Get
        Set(Val As List(Of String))
            headerFields1e.Add("")
        End Set
    End Property

    Private headerFields1f As New List(Of String)
    Public Property getheaderFields1b As List(Of String)
        Get
            Return headerFields1f
        End Get
        Set(Val As List(Of String))
            headerFields1f.Add("")
        End Set
    End Property

    Private headerFields1g As New List(Of String)
    Public Property getheaderFields1g As List(Of String)
        Get
            Return headerFields1g
        End Get
        Set(Val As List(Of String))
            headerFields1g.Add("")
        End Set
    End Property

    Private headerFields1h As New List(Of String)
    Public Property getheaderFields1h As List(Of String)
        Get
            Return headerFields1h
        End Get
        Set(Val As List(Of String))
            headerFields1h.Add("")
        End Set
    End Property

    Private headerFields1i As New List(Of String)
    Public Property getheaderFields1i As List(Of String)
        Get
            Return headerFields1i
        End Get
        Set(Val As List(Of String))
            headerFields1i.Add("")
        End Set
    End Property

End Module

Public Class Header
    Dim newFile As New XmlDocument
    Dim path As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\newFile.xml"

    Dim nsmgr As New XmlNamespaceManager(newFile.NameTable)




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
        newFile.Load(path)
        'adds header information to xml document
        Dim h1 As XmlElement = newFile.CreateElement("header")
        Dim h2 As XmlElement = newFile.CreateElement("header")
        Dim h3 As XmlElement = newFile.CreateElement("header")
        Dim h4 As XmlElement = newFile.CreateElement("header")
        Dim h5 As XmlElement = newFile.CreateElement("header")
        Dim h6 As XmlElement = newFile.CreateElement("header")
        Dim h7 As XmlElement = newFile.CreateElement("header")
        Dim h8 As XmlElement = newFile.CreateElement("header")
        Dim h9 As XmlElement = newFile.CreateElement("header")
        Dim lineReturn As XmlElement = newFile.CreateElement("header")
        Dim rdl As XmlElement = newFile.SelectSingleNode(xpath:="//rdlReportFormat")
        Dim header1Content As String
        Dim header2Content As String

        If delimiter = "Comma" Then xslDelimiter = ","
        If delimiter = "Decimal" Then xslDelimiter = "."
        If delimiter = "Tab" Then xslDelimiter = "&#9;"

        Dim headerPositionCount As Integer = 1
        'first position not dynamic, roll into first header row
        If hd1Textbox.Text <> "" AndAlso dynamic1Button.Checked = False Then
            getheaderFields1a.Add(hd1Textbox.Text)
            'first column only has text
            If hd2Textbox.Text = "" Then
                header1Content = String.Join(xslDelimiter, getheaderFields1a)
                h1.SetAttribute("text", header1Content)
                h1.SetAttribute("type", "text")
                h1.SetAttribute("position", "1")
                rdl.PrependChild(h1)
                headerPositionCount = headerPositionCount + 1
                'adds line feed
                lineReturn.SetAttribute("text", "&#13;&#10;")
                lineReturn.SetAttribute("type", "text")
                lineReturn.SetAttribute("position", headerPositionCount.ToString)
                rdl.InsertAfter(lineReturn, h1)
            End If
            'second column has data
            If hd2Textbox.Text <> "" AndAlso dynamic2Button.Checked = False Then
                getheaderFields1a.Add(hd2Textbox.Text)
                'second column and first column have text data, third and onward empty
                If hd3Textbox.Text = "" AndAlso headerPositionCount = 1 Then
                    header1Content = String.Join(xslDelimiter, getheaderFields1a)
                    h1.SetAttribute("text", header1Content)
                    h1.SetAttribute("type", "text")
                    h1.SetAttribute("position", "1")
                    rdl.PrependChild(h1)
                    headerPositionCount = headerPositionCount + 1
                    'adds line feed
                    lineReturn.SetAttribute("text", "&#13;&#10;")
                    lineReturn.SetAttribute("type", "text")
                    lineReturn.SetAttribute("position", headerPositionCount.ToString)
                    rdl.InsertAfter(lineReturn, h1)
                End If
                If hd3Textbox.Text <> "" AndAlso dynamic3Button.Checked = False Then
                    getheaderFields1a.Add(hd3Textbox.Text)
                    'first 3 columns are all text data, rest empty
                    If hd4Textbox.Text = "" AndAlso headerPositionCount = 1 Then
                        header1Content = String.Join(xslDelimiter, getheaderFields1a)
                        h1.SetAttribute("text", header1Content)
                        h1.SetAttribute("type", "text")
                        h1.SetAttribute("position", "1")
                        rdl.PrependChild(h1)
                        headerPositionCount = headerPositionCount + 1
                        'adds line feed
                        lineReturn.SetAttribute("text", "&#13;&#10;")
                        lineReturn.SetAttribute("type", "text")
                        lineReturn.SetAttribute("position", headerPositionCount.ToString)
                        rdl.InsertAfter(lineReturn, h1)
                    End If
                    '4th column has text
                    If hd4Textbox.Text <> "" AndAlso dynamic4Button.Checked = False Then
                        getheaderFields1a.Add(hd4Textbox.Text)
                        'first 4 columns have text only
                        If hd5Textbox.Text = "" AndAlso headerPositionCount = 1 Then
                            header1Content = String.Join(xslDelimiter, getheaderFields1a)
                            h1.SetAttribute("text", header1Content)
                            h1.SetAttribute("type", "text")
                            h1.SetAttribute("position", "1")
                            rdl.PrependChild(h1)
                            headerPositionCount = headerPositionCount + 1
                            'adds line feed
                            lineReturn.SetAttribute("text", "&#13;&#10;")
                            lineReturn.SetAttribute("type", "text")
                            lineReturn.SetAttribute("position", headerPositionCount.ToString)
                            rdl.InsertAfter(lineReturn, h1)
                        End If
                        '5th column has text
                        If hd5Textbox.Text <> "" AndAlso dynamic5Button.Checked = False Then
                            getheaderFields1a.Add(hd5Textbox.Text)
                            '5 columns have text only
                            If hd6Textbox.Text = "" AndAlso headerPositionCount = 1 Then
                                header1Content = String.Join(xslDelimiter, getheaderFields1a)
                                h1.SetAttribute("text", header1Content)
                                h1.SetAttribute("type", "text")
                                h1.SetAttribute("position", "1")
                                rdl.PrependChild(h1)
                                headerPositionCount = headerPositionCount + 1
                                'adds line feed
                                lineReturn.SetAttribute("text", "&#13;&#10;")
                                lineReturn.SetAttribute("type", "text")
                                lineReturn.SetAttribute("position", headerPositionCount.ToString)
                                rdl.InsertAfter(lineReturn, h1)
                            End If
                            '6th column has text
                            If hd6Textbox.Text <> "" AndAlso dynamic6Button.Checked = False Then
                                getheaderFields1a.Add(hd6Textbox.Text)
                                '6 columns have text only
                                If hd7Textbox.Text = "" AndAlso headerPositionCount = 1 Then
                                    header1Content = String.Join(xslDelimiter, getheaderFields1a)
                                    h1.SetAttribute("text", header1Content)
                                    h1.SetAttribute("type", "text")
                                    h1.SetAttribute("position", "1")
                                    rdl.PrependChild(h1)
                                    headerPositionCount = headerPositionCount + 1
                                    'adds line feed
                                    lineReturn.SetAttribute("text", "&#13;&#10;")
                                    lineReturn.SetAttribute("type", "text")
                                    lineReturn.SetAttribute("position", headerPositionCount.ToString)
                                    rdl.InsertAfter(lineReturn, h1)
                                End If

                                If hd7Textbox.Text <> "" AndAlso dynamic7Button.Checked = False Then
                                    getheaderFields1a.Add(hd7Textbox.Text)
                                    '7 columns have text only
                                    If hd8Textbox.Text = "" AndAlso headerPositionCount = 1 Then
                                        header1Content = String.Join(xslDelimiter, getheaderFields1a)
                                        h1.SetAttribute("text", header1Content)
                                        h1.SetAttribute("type", "text")
                                        h1.SetAttribute("position", "1")
                                        rdl.PrependChild(h1)
                                        headerPositionCount = headerPositionCount + 1
                                        'adds line feed
                                        lineReturn.SetAttribute("text", "&#13;&#10;")
                                        lineReturn.SetAttribute("type", "text")
                                        lineReturn.SetAttribute("position", headerPositionCount.ToString)
                                        rdl.InsertAfter(lineReturn, h1)
                                    End If
                                    'go this way if column 9 has data
                                    If hd8Textbox.Text <> "" AndAlso dynamic8Button.Checked = False AndAlso hd9Textbox.Text <> "" Then
                                            getheaderFields1a.Add(hd8Textbox.Text)
                                            'all 9 column headers are text
                                            If hd9Textbox.Text <> "" AndAlso dynamic9Button.Checked = False Then
                                                getheaderFields1a.Add(hd9Textbox.Text)
                                                'does not need this delimiter added to the end until more columns are available
                                                'getheaderFields1a.Add(xslDelimiter)
                                                header1Content = String.Join(xslDelimiter, getheaderFields1a)
                                                h1.SetAttribute("text", header1Content)
                                                h1.SetAttribute("type", "text")
                                                h1.SetAttribute("position", "1")
                                                rdl.PrependChild(h1)
                                                headerPositionCount = headerPositionCount + 1
                                                'adds line feed
                                                lineReturn.SetAttribute("text", "&#13;&#10;")
                                                lineReturn.SetAttribute("type", "text")
                                                lineReturn.SetAttribute("position", headerPositionCount.ToString)
                                                rdl.InsertAfter(lineReturn, h1)
                                            End If
                                            '8 column headers are text, column 9 is variable
                                            If hd9Textbox.Text <> "" AndAlso dynamic9Button.Checked = True Then
                                                'writes the text columns before the value in column 9
                                                'forces a delimiter at the end of the values
                                                getheaderFields1a.Add("")
                                                'takes all the header fields and turns them into a nice long string with delimiter included
                                                header1Content = String.Join(xslDelimiter, getheaderFields1a)
                                                'drops header info into the attribute
                                                h1.SetAttribute("text", header1Content)
                                                'drops text into type
                                                h1.SetAttribute("type", "text")
                                                'assigns the position - Good luck my fellow GL programmers, if you are reading this, sorry the code is such a mess!
                                                h1.SetAttribute("position", "1")
                                                'puts the line in the xml file
                                                rdl.PrependChild(h1)
                                                'moves the position upwards 1
                                                headerPositionCount = headerPositionCount + 1
                                                'writes dynamic column 9 to xml
                                                h2.SetAttribute("value", hd9Textbox.Text)
                                                h2.SetAttribute("type", "variable")
                                                h2.SetAttribute("position", headerPositionCount.ToString)
                                                rdl.InsertAfter(h2, h1)
                                                'moves the position upwards 1
                                                headerPositionCount = headerPositionCount + 1
                                                'adds line feed
                                                lineReturn.SetAttribute("text", "&#13;&#10;")
                                                lineReturn.SetAttribute("type", "text")
                                                lineReturn.SetAttribute("position", headerPositionCount.ToString)
                                                rdl.InsertAfter(lineReturn, h2)
                                            End If

                                        End If
                                        'if 8 columns had a text header and column 9 is empty
                                        If hd8Textbox.Text <> "" AndAlso dynamic8Button.Checked = False AndAlso hd9Textbox.Text = "" Then
                                            getheaderFields1a.Add(hd8Textbox.Text)
                                            header1Content = String.Join(xslDelimiter, getheaderFields1a)
                                            h1.SetAttribute("text", header1Content)
                                            h1.SetAttribute("type", "text")
                                            h1.SetAttribute("position", "1")
                                            rdl.PrependChild(h1)
                                            headerPositionCount = headerPositionCount + 1
                                            lineReturn.SetAttribute("text", "&#13;&#10;")
                                            lineReturn.SetAttribute("type", "text")
                                            lineReturn.SetAttribute("position", headerPositionCount.ToString)
                                            rdl.InsertAfter(lineReturn, h1)
                                        End If
                                        'if 7 columns had text header and column 8 is dynamic and column 9 empty
                                        If hd8Textbox.Text <> "" AndAlso dynamic8Button.Checked = True AndAlso hd9Textbox.Text = "" Then
                                            getheaderFields1a.Add("")
                                            header1Content = String.Join(xslDelimiter, getheaderFields1a)
                                            h1.SetAttribute("text", header1Content)
                                            h1.SetAttribute("type", "text")
                                            h1.SetAttribute("position", "1")
                                            rdl.PrependChild(h1)

                                            headerPositionCount = headerPositionCount + 1

                                            h2.SetAttribute("value", hd8Textbox.Text)
                                            h2.SetAttribute("type", "variable")
                                            h2.SetAttribute("position", headerPositionCount.ToString)
                                            rdl.InsertAfter(h2, h1)

                                            headerPositionCount = headerPositionCount + 1

                                            lineReturn.SetAttribute("text", "&#13;&#10;")
                                            lineReturn.SetAttribute("type", "text")
                                            lineReturn.SetAttribute("position", headerPositionCount.ToString)
                                            rdl.InsertAfter(lineReturn, h2)

                                        End If
                                        'if 7 columns had text header and column 8 is dynamic and column 9 exists
                                        If hd8Textbox.Text <> "" AndAlso dynamic8Button.Checked = True AndAlso hd9Textbox.Text <> "" Then
                                            getheaderFields1a.Add("")
                                            header1Content = String.Join(xslDelimiter, getheaderFields1a)
                                            h1.SetAttribute("text", header1Content)
                                            h1.SetAttribute("type", "text")
                                            h1.SetAttribute("position", "1")
                                            rdl.PrependChild(h1)

                                            headerPositionCount = headerPositionCount + 1

                                            h2.SetAttribute("value", hd8Textbox.Text)
                                            h2.SetAttribute("type", "variable")
                                            h2.SetAttribute("position", headerPositionCount.ToString)
                                            rdl.InsertAfter(h2, h1)

                                            headerPositionCount = headerPositionCount + 1

                                            'column 9 as text
                                            If dynamic9Button.Checked = False Then
                                                GetheaderFields1bb.Add("")
                                                GetheaderFields1bb.Add(hd9Textbox.Text)
                                                header2Content = String.Join(xslDelimiter, GetheaderFields1bb)
                                                h3.SetAttribute("text", header2Content)
                                                h3.SetAttribute("type", "text")
                                                h3.SetAttribute("position", headerPositionCount.ToString)
                                                rdl.InsertAfter(h3, h2)

                                                headerPositionCount = headerPositionCount + 1

                                                lineReturn.SetAttribute("text", "&#13;&#10;")
                                                lineReturn.SetAttribute("type", "text")
                                                lineReturn.SetAttribute("position", headerPositionCount.ToString)
                                                rdl.InsertAfter(lineReturn, h3)
                                            End If
                                            'column 9 as variable
                                            If dynamic9Button.Checked = True Then
                                                h3.SetAttribute("value", xslDelimiter)
                                                h3.SetAttribute("type", "text")
                                                h3.SetAttribute("position", headerPositionCount.ToString)
                                                rdl.InsertAfter(h3, h2)

                                                headerPositionCount = headerPositionCount + 1

                                                h4.SetAttribute("value", hd9Textbox.Text)
                                                h4.SetAttribute("type", "variable")
                                                h4.SetAttribute("position", headerPositionCount.ToString)
                                                rdl.InsertAfter(h4, h3)

                                                headerPositionCount = headerPositionCount + 1

                                                lineReturn.SetAttribute("text", "&#13;&#10;")
                                                lineReturn.SetAttribute("type", "text")
                                                lineReturn.SetAttribute("position", headerPositionCount.ToString)
                                                rdl.InsertAfter(lineReturn, h4)
                                            End If



                                        End If

                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If

        'first position dynamic
        If hd1Textbox.Text <> "" AndAlso dynamic1Button.Checked = True Then
            h1.SetAttribute("value", hd1Textbox.Text)
            h1.SetAttribute("type", "variable")
            h1.SetAttribute("position", "1")
            rdl.PrependChild(h1)
            headerPositionCount = headerPositionCount + 1
        End If



        'After all header text, adds carriage Return, line feed
        'If headerPositionCount > 1 Then
        '    lineReturn.SetAttribute("text", "&#13;&#10;")
        '    lineReturn.SetAttribute("type", "text")
        '    lineReturn.SetAttribute("position", headerPositionCount.ToString)
        '    rdl.PrependChild(lineReturn)
        'End If



        'sanity check for header data
        'MessageBox.Show(text:=header1Content)

        newFile.Save(path)
    End Sub



End Class
