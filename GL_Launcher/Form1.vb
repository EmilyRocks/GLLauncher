Imports System
Imports System.Xml
Imports System.IO

Public Class Cash
    Dim newFile As New XmlDocument()
    Dim path As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\newFile.xml"
    Private Sub Cash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'reminds people to select report type first so xml tree gets generated
        If IO.File.Exists(path) Then
            newFile.Load(path)
        Else
            MessageBox.Show("Go select a report type first")
            Me.Close()
        End If
    End Sub

    Private Sub Cash_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        If IO.File.Exists(path) Then
            newFile.Save(path)
        End If
    End Sub

    Private Sub Cash_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim newFile As New XmlDocument
        Dim path As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\newFile.xml"
        newFile.Load(path)
        Dim nsmgr As New XmlNamespaceManager(newFile.NameTable)
        nsmgr.AddNamespace("accounts", path)
        Dim xmlAcct As XmlElement = newFile.CreateElement("account")
        Dim xmlAcct2 As XmlElement = newFile.CreateElement("account")
        Dim xmlAcct3 As XmlElement = newFile.CreateElement("account")
        Dim accts As XmlElement = newFile.SelectSingleNode(xpath:="//accounts")
        Dim manAcct As XmlElement = newFile.SelectSingleNode(xpath:="//accounts")
        Dim netAcct As XmlElement = newFile.SelectSingleNode(xpath:="//accounts")
        Dim manSymbol As XmlElement = newFile.CreateElement("transfer")
        Dim netSymbol As XmlElement = newFile.CreateElement("transfer")
        Dim transfers As XmlElement = newFile.SelectSingleNode(xpath:="//transfers")

        'cash accounts

        If cGL6Textbox.Text <> "" Then
            xmlAcct.SetAttribute("gl6", cGL6Textbox.Text)
            accts.AppendChild(xmlAcct)
        End If
        If cGL5Textbox.Text <> "" Then
            xmlAcct.SetAttribute("gl5", cGL5Textbox.Text)
            accts.AppendChild(xmlAcct)
        End If
        If cGL4Textbox.Text <> "" Then
            xmlAcct.SetAttribute("gl4", cGL4Textbox.Text)
            accts.AppendChild(xmlAcct)
        End If
        If cGL3Textbox.Text <> "" Then
            xmlAcct.SetAttribute("gl3", cGL3Textbox.Text)
            accts.AppendChild(xmlAcct)
        End If
        If cGL2Textbox.Text <> "" Then
            xmlAcct.SetAttribute("gl2", cGL2Textbox.Text)
            accts.AppendChild(xmlAcct)
        End If
        If cGL1Textbox.Text <> "" Then
            xmlAcct.SetAttribute("name", "cash")
            xmlAcct.SetAttribute("gl1", cGL1Textbox.Text)
            accts.AppendChild(xmlAcct)
        End If

        ' Manual check accounts

        If mGL6Textbox.Text <> "" Then
            xmlAcct2.SetAttribute("gl6", mGL6textbox.Text)
            manAcct.AppendChild(xmlAcct2)
        End If
        If mGL5Textbox.Text <> "" Then
            xmlAcct2.SetAttribute("gl5", mGL5Textbox.Text)
            manAcct.AppendChild(xmlAcct2)
        End If
        If mGL4Textbox.Text <> "" Then
            xmlAcct2.SetAttribute("gl4", mGL4Textbox.Text)
            manAcct.AppendChild(xmlAcct2)
        End If
        If mGL3Textbox.Text <> "" Then
            xmlAcct2.SetAttribute("gl3", mGL3Textbox.Text)
            manAcct.AppendChild(xmlAcct2)
        End If
        If mGL2Textbox.Text <> "" Then
            xmlAcct2.SetAttribute("gl2", mGL2Textbox.Text)
            manAcct.AppendChild(xmlAcct2)
        End If
        If mGL1Textbox.Text <> "" Then
            xmlAcct2.SetAttribute("name", "manual")
            xmlAcct2.SetAttribute("gl1", mGL1Textbox.Text)
            manAcct.AppendChild(xmlAcct)
            If manLetterButton.Checked = True Then
                manSymbol.SetAttribute("name", "manual")
                manSymbol.SetAttribute("include", "Y")
                manSymbol.SetAttribute("symbol", "M")
                getTrimChars.Add("M")
            End If
            If manCharButton.Checked = True Then
                manSymbol.SetAttribute("name", "manual")
                manSymbol.SetAttribute("include", "Y")
                manSymbol.SetAttribute("symbol", "!")
                getTrimChars.Add("!")
            End If
            transfers.AppendChild(manSymbol)
        End If


        ' Net check accounts

        If nGL6Textbox.Text <> "" Then
            xmlAcct3.SetAttribute("gl6", nGL6Textbox.Text)
            netAcct.AppendChild(xmlAcct3)
        End If
        If nGL5Textbox.Text <> "" Then
            xmlAcct3.SetAttribute("gl5", nGL5Textbox.Text)
            netAcct.AppendChild(xmlAcct3)
        End If
        If nGL4Textbox.Text <> "" Then
            xmlAcct3.SetAttribute("gl4", nGL4Textbox.Text)
            netAcct.AppendChild(xmlAcct3)
        End If
        If nGL3Textbox.Text <> "" Then
            xmlAcct3.SetAttribute("gl3", nGL3Textbox.Text)
            netAcct.AppendChild(xmlAcct3)
        End If
        If nGL2Textbox.Text <> "" Then
            xmlAcct3.SetAttribute("gl2", nGL2Textbox.Text)
            netAcct.AppendChild(xmlAcct3)
        End If
        If nGL1Textbox.Text <> "" Then
            xmlAcct3.SetAttribute("name", "netChecks")
            xmlAcct3.SetAttribute("gl1", nGL1Textbox.Text)
            netAcct.AppendChild(xmlAcct3)
            If netLetterButton.Checked = True Then
                netSymbol.SetAttribute("name", "netChecks")
                netSymbol.SetAttribute("include", "Y")
                netSymbol.SetAttribute("symbol", "N")
                getTrimChars.Add("N")
            End If
            If netCharButton.Checked = True Then
                netSymbol.SetAttribute("name", "netChecks")
                netSymbol.SetAttribute("include", "Y")
                netSymbol.SetAttribute("symbol", ":")
                getTrimChars.Add(":")
            End If
            transfers.AppendChild(netSymbol)
        End If


        'turn on for sanity check during testing to see if trim list is pulling characters
        Dim testTrim As String
        testTrim = String.Join(",", getTrimChars)
        MessageBox.Show(text:=testTrim)

        newFile.Save(path)
        'this code works and adds a new tag at very bottom instead
        'Dim xmlAcct As XmlElement = newFile.CreateElement("account")
        'xmlAcct.SetAttribute("name", "cash")
        'newFile.DocumentElement.AppendChild(xmlAcct)
    End Sub

End Class


' "D:\My Visual Studio Projects\GL_Launcher\newFile.xml"
