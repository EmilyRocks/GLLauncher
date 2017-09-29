<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Delimit
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
        Me.delimitTextbox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'delimitTextbox
        '
        Me.delimitTextbox.FormattingEnabled = True
        Me.delimitTextbox.Items.AddRange(New Object() {"Comma", "Decimal", "Tab"})
        Me.delimitTextbox.Location = New System.Drawing.Point(63, 11)
        Me.delimitTextbox.Name = "delimitTextbox"
        Me.delimitTextbox.Size = New System.Drawing.Size(132, 21)
        Me.delimitTextbox.Sorted = True
        Me.delimitTextbox.TabIndex = 2
        '
        'Delimit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 42)
        Me.Controls.Add(Me.delimitTextbox)
        Me.Name = "Delimit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choose Delimiter"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents delimitTextbox As ComboBox
End Class
