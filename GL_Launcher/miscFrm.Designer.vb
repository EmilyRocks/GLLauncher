<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class miscFrm
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
        Me.trimStrAddTxtbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.antiTrimBox = New System.Windows.Forms.CheckBox()
        Me.crValTextbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.drValTextbox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.drcrNoneButton = New System.Windows.Forms.RadioButton()
        Me.drcr0button = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.trimLengthTextbox = New System.Windows.Forms.TextBox()
        Me.trimStartTextbox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'trimStrAddTxtbox
        '
        Me.trimStrAddTxtbox.Location = New System.Drawing.Point(179, 26)
        Me.trimStrAddTxtbox.Name = "trimStrAddTxtbox"
        Me.trimStrAddTxtbox.Size = New System.Drawing.Size(100, 20)
        Me.trimStrAddTxtbox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Additional Character Trimming:"
        '
        'antiTrimBox
        '
        Me.antiTrimBox.AutoSize = True
        Me.antiTrimBox.Location = New System.Drawing.Point(319, 28)
        Me.antiTrimBox.Name = "antiTrimBox"
        Me.antiTrimBox.Size = New System.Drawing.Size(152, 17)
        Me.antiTrimBox.TabIndex = 2
        Me.antiTrimBox.Text = "Turn off character trimming"
        Me.antiTrimBox.UseVisualStyleBackColor = True
        '
        'crValTextbox
        '
        Me.crValTextbox.Location = New System.Drawing.Point(107, 8)
        Me.crValTextbox.Name = "crValTextbox"
        Me.crValTextbox.Size = New System.Drawing.Size(60, 20)
        Me.crValTextbox.TabIndex = 3
        Me.crValTextbox.Text = "Credit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "CD Column Values:"
        '
        'drValTextbox
        '
        Me.drValTextbox.Location = New System.Drawing.Point(178, 8)
        Me.drValTextbox.Name = "drValTextbox"
        Me.drValTextbox.Size = New System.Drawing.Size(60, 20)
        Me.drValTextbox.TabIndex = 5
        Me.drValTextbox.Text = "Debit"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.drValTextbox)
        Me.Panel1.Controls.Add(Me.crValTextbox)
        Me.Panel1.Location = New System.Drawing.Point(24, 132)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(255, 37)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.drcrNoneButton)
        Me.Panel2.Controls.Add(Me.drcr0button)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(319, 132)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(255, 37)
        Me.Panel2.TabIndex = 7
        '
        'drcrNoneButton
        '
        Me.drcrNoneButton.AutoSize = True
        Me.drcrNoneButton.Location = New System.Drawing.Point(184, 10)
        Me.drcrNoneButton.Name = "drcrNoneButton"
        Me.drcrNoneButton.Size = New System.Drawing.Size(51, 17)
        Me.drcrNoneButton.TabIndex = 2
        Me.drcrNoneButton.Text = "None"
        Me.drcrNoneButton.UseVisualStyleBackColor = True
        '
        'drcr0button
        '
        Me.drcr0button.AutoSize = True
        Me.drcr0button.Checked = True
        Me.drcr0button.Location = New System.Drawing.Point(138, 10)
        Me.drcr0button.Name = "drcr0button"
        Me.drcr0button.Size = New System.Drawing.Size(31, 17)
        Me.drcr0button.TabIndex = 1
        Me.drcr0button.TabStop = True
        Me.drcr0button.Text = "0"
        Me.drcr0button.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "DR/CR Empty Field"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.trimLengthTextbox)
        Me.Panel3.Controls.Add(Me.trimStartTextbox)
        Me.Panel3.Location = New System.Drawing.Point(24, 64)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(255, 53)
        Me.Panel3.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(3, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 38)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Substring Option  for Account field:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'trimLengthTextbox
        '
        Me.trimLengthTextbox.Location = New System.Drawing.Point(178, 30)
        Me.trimLengthTextbox.Name = "trimLengthTextbox"
        Me.trimLengthTextbox.Size = New System.Drawing.Size(60, 20)
        Me.trimLengthTextbox.TabIndex = 5
        '
        'trimStartTextbox
        '
        Me.trimStartTextbox.Location = New System.Drawing.Point(107, 30)
        Me.trimStartTextbox.Name = "trimStartTextbox"
        Me.trimStartTextbox.Size = New System.Drawing.Size(60, 20)
        Me.trimStartTextbox.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(107, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Start"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(175, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Length"
        '
        'miscFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 261)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.antiTrimBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.trimStrAddTxtbox)
        Me.Name = "miscFrm"
        Me.Text = "Miscellaneous Options"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents trimStrAddTxtbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents antiTrimBox As CheckBox
    Friend WithEvents crValTextbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents drValTextbox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents drcrNoneButton As RadioButton
    Friend WithEvents drcr0button As RadioButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents trimLengthTextbox As TextBox
    Friend WithEvents trimStartTextbox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
