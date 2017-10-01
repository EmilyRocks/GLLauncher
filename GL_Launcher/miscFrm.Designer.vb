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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.Panel1.Location = New System.Drawing.Point(24, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(255, 37)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RadioButton2)
        Me.Panel2.Controls.Add(Me.RadioButton1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(319, 79)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(255, 37)
        Me.Panel2.TabIndex = 7
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
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(138, 10)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "0"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(184, 10)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(51, 17)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.Text = "None"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'miscFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 261)
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
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
End Class
