<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Launcher
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.StartRptType = New System.Windows.Forms.Button()
        Me.StartCash = New System.Windows.Forms.Button()
        Me.StartColumns = New System.Windows.Forms.Button()
        Me.StartHeader = New System.Windows.Forms.Button()
        Me.StartFooter = New System.Windows.Forms.Button()
        Me.StartPDF = New System.Windows.Forms.Button()
        Me.StartMisc = New System.Windows.Forms.Button()
        Me.LaunchGL = New System.Windows.Forms.Button()
        Me.StartTransfers = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'StartRptType
        '
        Me.StartRptType.AutoSize = True
        Me.StartRptType.BackColor = System.Drawing.Color.LavenderBlush
        Me.StartRptType.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.StartRptType.Location = New System.Drawing.Point(109, 24)
        Me.StartRptType.Name = "StartRptType"
        Me.StartRptType.Size = New System.Drawing.Size(80, 23)
        Me.StartRptType.TabIndex = 0
        Me.StartRptType.Text = "Report Type"
        Me.StartRptType.UseVisualStyleBackColor = False
        '
        'StartCash
        '
        Me.StartCash.AutoSize = True
        Me.StartCash.BackColor = System.Drawing.Color.LavenderBlush
        Me.StartCash.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.StartCash.Location = New System.Drawing.Point(109, 62)
        Me.StartCash.Name = "StartCash"
        Me.StartCash.Size = New System.Drawing.Size(80, 23)
        Me.StartCash.TabIndex = 1
        Me.StartCash.Text = "Cash Options"
        Me.StartCash.UseVisualStyleBackColor = False
        '
        'StartColumns
        '
        Me.StartColumns.AutoSize = True
        Me.StartColumns.BackColor = System.Drawing.Color.LavenderBlush
        Me.StartColumns.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.StartColumns.Location = New System.Drawing.Point(109, 100)
        Me.StartColumns.Name = "StartColumns"
        Me.StartColumns.Size = New System.Drawing.Size(80, 23)
        Me.StartColumns.TabIndex = 2
        Me.StartColumns.Text = "Columns"
        Me.StartColumns.UseVisualStyleBackColor = False
        '
        'StartHeader
        '
        Me.StartHeader.AutoSize = True
        Me.StartHeader.BackColor = System.Drawing.Color.LavenderBlush
        Me.StartHeader.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.StartHeader.Location = New System.Drawing.Point(109, 176)
        Me.StartHeader.Name = "StartHeader"
        Me.StartHeader.Size = New System.Drawing.Size(80, 23)
        Me.StartHeader.TabIndex = 3
        Me.StartHeader.Text = "Header"
        Me.StartHeader.UseVisualStyleBackColor = False
        '
        'StartFooter
        '
        Me.StartFooter.AutoSize = True
        Me.StartFooter.BackColor = System.Drawing.Color.LavenderBlush
        Me.StartFooter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.StartFooter.Location = New System.Drawing.Point(109, 214)
        Me.StartFooter.Name = "StartFooter"
        Me.StartFooter.Size = New System.Drawing.Size(80, 23)
        Me.StartFooter.TabIndex = 4
        Me.StartFooter.Text = "Footer"
        Me.StartFooter.UseVisualStyleBackColor = False
        '
        'StartPDF
        '
        Me.StartPDF.AutoSize = True
        Me.StartPDF.BackColor = System.Drawing.Color.LavenderBlush
        Me.StartPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.StartPDF.Location = New System.Drawing.Point(109, 252)
        Me.StartPDF.Name = "StartPDF"
        Me.StartPDF.Size = New System.Drawing.Size(80, 23)
        Me.StartPDF.TabIndex = 5
        Me.StartPDF.Text = "PDF"
        Me.StartPDF.UseVisualStyleBackColor = False
        '
        'StartMisc
        '
        Me.StartMisc.AutoSize = True
        Me.StartMisc.BackColor = System.Drawing.Color.LavenderBlush
        Me.StartMisc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.StartMisc.Location = New System.Drawing.Point(109, 290)
        Me.StartMisc.Name = "StartMisc"
        Me.StartMisc.Size = New System.Drawing.Size(80, 23)
        Me.StartMisc.TabIndex = 6
        Me.StartMisc.Text = "Misc"
        Me.StartMisc.UseVisualStyleBackColor = False
        '
        'LaunchGL
        '
        Me.LaunchGL.AutoSize = True
        Me.LaunchGL.BackColor = System.Drawing.Color.LavenderBlush
        Me.LaunchGL.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LaunchGL.Location = New System.Drawing.Point(109, 328)
        Me.LaunchGL.Name = "LaunchGL"
        Me.LaunchGL.Size = New System.Drawing.Size(80, 23)
        Me.LaunchGL.TabIndex = 7
        Me.LaunchGL.Text = "Create"
        Me.LaunchGL.UseVisualStyleBackColor = False
        '
        'StartTransfers
        '
        Me.StartTransfers.AutoSize = True
        Me.StartTransfers.BackColor = System.Drawing.Color.LavenderBlush
        Me.StartTransfers.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.StartTransfers.Location = New System.Drawing.Point(109, 138)
        Me.StartTransfers.Name = "StartTransfers"
        Me.StartTransfers.Size = New System.Drawing.Size(80, 23)
        Me.StartTransfers.TabIndex = 8
        Me.StartTransfers.Text = "Transfers"
        Me.StartTransfers.UseVisualStyleBackColor = False
        '
        'Launcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 376)
        Me.Controls.Add(Me.StartTransfers)
        Me.Controls.Add(Me.LaunchGL)
        Me.Controls.Add(Me.StartMisc)
        Me.Controls.Add(Me.StartPDF)
        Me.Controls.Add(Me.StartFooter)
        Me.Controls.Add(Me.StartHeader)
        Me.Controls.Add(Me.StartColumns)
        Me.Controls.Add(Me.StartCash)
        Me.Controls.Add(Me.StartRptType)
        Me.Name = "Launcher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GL Report Launcher"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StartRptType As Button
    Friend WithEvents StartCash As Button
    Friend WithEvents StartColumns As Button
    Friend WithEvents StartHeader As Button
    Friend WithEvents StartFooter As Button
    Friend WithEvents StartPDF As Button
    Friend WithEvents StartMisc As Button
    Friend WithEvents LaunchGL As Button
    Friend WithEvents StartTransfers As Button
End Class
