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
        Me.antiTrimBox.Location = New System.Drawing.Point(346, 28)
        Me.antiTrimBox.Name = "antiTrimBox"
        Me.antiTrimBox.Size = New System.Drawing.Size(152, 17)
        Me.antiTrimBox.TabIndex = 2
        Me.antiTrimBox.Text = "Turn off character trimming"
        Me.antiTrimBox.UseVisualStyleBackColor = True
        '
        'miscFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 261)
        Me.Controls.Add(Me.antiTrimBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.trimStrAddTxtbox)
        Me.Name = "miscFrm"
        Me.Text = "Miscellaneous Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents trimStrAddTxtbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents antiTrimBox As CheckBox
End Class
