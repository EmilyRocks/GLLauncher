Imports System
Imports System.Xml
Imports System.IO

Public Class transfersFrm

    Private Sub transfersFrm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim newFile As New XmlDocument
        Dim path As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\newFile.xml"
        newFile.Load(path)
        Dim transfers As XmlElement = newFile.SelectSingleNode(xpath:="//transfers")
        Dim accounts As XmlElement = newFile.SelectSingleNode(xpath:="//accounts")
        Dim agency As XmlElement = newFile.CreateElement("transfer")
        Dim tax As XmlElement = newFile.CreateElement("transfer")
        Dim modsc As XmlElement = newFile.CreateElement("account")
        Dim modsc2 As XmlElement = newFile.CreateElement("transfer")

        If noAgencyButton.Checked = True Then
            If agLetterButton.Checked = True Then
                agency.SetAttribute("symbol", "A")
                getTrimChars.Add("A")
            End If
            If agCharButton.Checked = True Then
                agency.SetAttribute("symbol", "&amp;")
                getTrimChars.Add("&amp;")
            End If
            agency.SetAttribute("method", "0")
            agency.SetAttribute("name", "agency")
            transfers.AppendChild(agency)
        End If

        If stdAgencyButton.Checked = True Then
            If agLetterButton.Checked = True Then
                agency.SetAttribute("symbol", "A")
                getTrimChars.Add("A")
            End If
            If agCharButton.Checked = True Then
                agency.SetAttribute("symbol", "&amp;")
                getTrimChars.Add("&amp;")
            End If
            agency.SetAttribute("method", "1")
            agency.SetAttribute("name", "agency")
            transfers.AppendChild(agency)
        End If

        If chkAgencyButton.Checked = True Then
            If agLetterButton.Checked = True Then
                agency.SetAttribute("symbol", "A")
                getTrimChars.Add("A")
            End If
            If agCharButton.Checked = True Then
                agency.SetAttribute("symbol", "&amp;")
                getTrimChars.Add("&amp;")
            End If
            agency.SetAttribute("method", "2")
            agency.SetAttribute("name", "agency")
            transfers.AppendChild(agency)
        End If

        If hybridAgencyButton.Checked = True Then
            If agLetterButton.Checked = True Then
                agency.SetAttribute("symbol", "A")
                getTrimChars.Add("A")
            End If
            If agCharButton.Checked = True Then
                agency.SetAttribute("symbol", "&amp;")
                getTrimChars.Add("&amp;")
            End If
            agency.SetAttribute("method", "3")
            agency.SetAttribute("name", "agency")
            transfers.AppendChild(agency)
        End If

        If agSingleButton.Checked = True Then
            If agLetterButton.Checked = True Then
                agency.SetAttribute("symbol", "A")
                getTrimChars.Add("A")
            End If
            If agCharButton.Checked = True Then
                agency.SetAttribute("symbol", "&amp;")
                getTrimChars.Add("&amp;")
            End If
            agency.SetAttribute("method", "4")
            agency.SetAttribute("name", "agency")
            transfers.AppendChild(agency)
        End If

        If noTaxButton.Checked = True Then
            If taxLetterButton.Checked = True Then
                tax.SetAttribute("symbol", "T")
                getTrimChars.Add("T")
            End If
            If taxCharButton.Checked = True Then
                tax.SetAttribute("symbol", "$")
                getTrimChars.Add("$")
            End If
            tax.SetAttribute("method", "0")
            tax.SetAttribute("name", "tax")
            transfers.AppendChild(tax)
        End If

        If stdTaxButton.Checked = True Then
            If taxLetterButton.Checked = True Then
                tax.SetAttribute("symbol", "T")
                getTrimChars.Add("T")
            End If
            If taxCharButton.Checked = True Then
                tax.SetAttribute("symbol", "$")
                getTrimChars.Add("$")
            End If
            tax.SetAttribute("method", "1")
            tax.SetAttribute("name", "tax")
            transfers.AppendChild(tax)
        End If


        If eeTaxButton.Checked = True Then
            If taxLetterButton.Checked = True Then
                tax.SetAttribute("symbol", "T")
                getTrimChars.Add("T")
            End If
            If taxCharButton.Checked = True Then
                tax.SetAttribute("symbol", "$")
                getTrimChars.Add("$")
            End If
            tax.SetAttribute("method", "2")
            tax.SetAttribute("name", "tax")
            transfers.AppendChild(tax)
        End If

        If erTaxButton.Checked = True Then
            If taxLetterButton.Checked = True Then
                tax.SetAttribute("symbol", "T")
                getTrimChars.Add("T")
            End If
            If taxCharButton.Checked = True Then
                tax.SetAttribute("symbol", "$")
                getTrimChars.Add("$")
            End If
            tax.SetAttribute("method", "3")
            tax.SetAttribute("name", "tax")
            transfers.AppendChild(tax)
        End If

        'add MODSC code
        If modscButton.BackColor = Color.Green Then
            modsc.SetAttribute("gl6", modsc6Box.Text)
            modsc.SetAttribute("gl5", modsc5Box.Text)
            modsc.SetAttribute("gl4", modsc4Box.Text)
            modsc.SetAttribute("gl3", modsc3Box.Text)
            modsc.SetAttribute("gl2", modsc2Box.Text)
            modsc.SetAttribute("gl1", modsc1Box.Text)
            modsc.SetAttribute("name", "MODSC")
            accounts.AppendChild(modsc)

            If taxLetterButton.Checked = True Then
                modsc2.SetAttribute("symbol", "T")
                getTrimChars.Add("T")
            End If
            If taxCharButton.Checked = True Then
                modsc2.SetAttribute("symbol", "$")
                getTrimChars.Add("$")
            End If
            modsc2.SetAttribute("include", "Y")
            modsc2.SetAttribute("name", "MODSC")
            transfers.AppendChild(modsc2)
        End If

        newFile.Save(path)
    End Sub

    Private Sub modscButton_Click(sender As Object, e As EventArgs) Handles modscButton.Click
        modscButton.BackColor = Color.Green
    End Sub
End Class