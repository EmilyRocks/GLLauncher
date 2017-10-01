Option Explicit On
Option Infer Off
Option Strict On
' Project name: GL Launcher
' Project purpose: Inserts values easily and efficiently into an XML file for use with GL's standard report template.
' Created by: Emily King Thomas
' Date: 20.09.2017

Imports System.ComponentModel
Imports System.Xml
Imports System.IO
' Imports System.Text

Public Class Launcher

    Private Sub StartCash_Click(sender As Object, e As EventArgs) Handles StartCash.Click
        Dim oForm As Cash
        oForm = New Cash
        Cash.Show()
        oForm = Nothing
    End Sub

    Private Sub StartRptType_Click(sender As Object, e As EventArgs) Handles StartRptType.Click
        Dim oForm As Form2
        oForm = New Form2
        Form2.Show()
        oForm = Nothing
    End Sub

    Private Sub StartColumns_Click(sender As Object, e As EventArgs) Handles StartColumns.Click
        Dim oForm As ColumnsFrm
        oForm = New ColumnsFrm
        ColumnsFrm.Show()
        oForm = Nothing
    End Sub

    Private Sub Launcher_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub StartTransfers_Click(sender As Object, e As EventArgs) Handles StartTransfers.Click
        Dim oForm As transfersFrm
        oForm = New transfersFrm
        transfersFrm.Show()
        oForm = Nothing
    End Sub

    Private Sub StartMisc_Click(sender As Object, e As EventArgs) Handles StartMisc.Click
        Dim oForm As miscFrm
        oForm = New miscFrm
        miscFrm.Show()
        oForm = Nothing
    End Sub

    Private Sub LaunchGL_Click(sender As Object, e As EventArgs) Handles LaunchGL.Click
        Dim SaveFileDialog1 As New SaveFileDialog
        SaveFileDialog1.CreatePrompt = True
        SaveFileDialog1.OverwritePrompt = True
        SaveFileDialog1.FileName = "crpt_StdGL_"
        SaveFileDialog1.DefaultExt = "xml"
        SaveFileDialog1.Filter = "Xml files (*.xml)|*.xml|All files (*.*)|*.*"
        SaveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Dim result As DialogResult = SaveFileDialog1.ShowDialog()
        If (result = DialogResult.OK) Then
            Dim newfile As New XmlDocument
            newfile.Load(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\newFile.xml")
            newfile.Save(SaveFileDialog1.FileName)
        End If
    End Sub
End Class
