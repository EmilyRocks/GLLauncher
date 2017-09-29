<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transfersFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.erTaxButton = New System.Windows.Forms.RadioButton()
        Me.stdTaxButton = New System.Windows.Forms.RadioButton()
        Me.eeTaxButton = New System.Windows.Forms.RadioButton()
        Me.noTaxButton = New System.Windows.Forms.RadioButton()
        Me.taxCharButton = New System.Windows.Forms.RadioButton()
        Me.taxLetterButton = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.agSingleButton = New System.Windows.Forms.RadioButton()
        Me.hybridAgencyButton = New System.Windows.Forms.RadioButton()
        Me.stdAgencyButton = New System.Windows.Forms.RadioButton()
        Me.chkAgencyButton = New System.Windows.Forms.RadioButton()
        Me.noAgencyButton = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.agCharButton = New System.Windows.Forms.RadioButton()
        Me.agLetterButton = New System.Windows.Forms.RadioButton()
        Me.modscButton = New System.Windows.Forms.Button()
        Me.modsc6Box = New System.Windows.Forms.ComboBox()
        Me.modsc5Box = New System.Windows.Forms.ComboBox()
        Me.modsc4Box = New System.Windows.Forms.ComboBox()
        Me.modsc3Box = New System.Windows.Forms.ComboBox()
        Me.modsc2Box = New System.Windows.Forms.ComboBox()
        Me.modsc1Box = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(41, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tax Options"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.erTaxButton)
        Me.Panel1.Controls.Add(Me.stdTaxButton)
        Me.Panel1.Controls.Add(Me.eeTaxButton)
        Me.Panel1.Controls.Add(Me.noTaxButton)
        Me.Panel1.Location = New System.Drawing.Point(28, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(190, 134)
        Me.Panel1.TabIndex = 2
        '
        'erTaxButton
        '
        Me.erTaxButton.AutoSize = True
        Me.erTaxButton.Location = New System.Drawing.Point(16, 90)
        Me.erTaxButton.Name = "erTaxButton"
        Me.erTaxButton.Size = New System.Drawing.Size(160, 17)
        Me.erTaxButton.TabIndex = 3
        Me.erTaxButton.Text = "Employer Tax Transfers Only"
        Me.erTaxButton.UseVisualStyleBackColor = True
        '
        'stdTaxButton
        '
        Me.stdTaxButton.AutoSize = True
        Me.stdTaxButton.Location = New System.Drawing.Point(16, 38)
        Me.stdTaxButton.Name = "stdTaxButton"
        Me.stdTaxButton.Size = New System.Drawing.Size(136, 17)
        Me.stdTaxButton.TabIndex = 2
        Me.stdTaxButton.Text = "Standard Tax Transfers"
        Me.stdTaxButton.UseVisualStyleBackColor = True
        '
        'eeTaxButton
        '
        Me.eeTaxButton.AutoSize = True
        Me.eeTaxButton.Location = New System.Drawing.Point(16, 64)
        Me.eeTaxButton.Name = "eeTaxButton"
        Me.eeTaxButton.Size = New System.Drawing.Size(163, 17)
        Me.eeTaxButton.TabIndex = 1
        Me.eeTaxButton.Text = "Employee Tax Transfers Only"
        Me.eeTaxButton.UseVisualStyleBackColor = True
        '
        'noTaxButton
        '
        Me.noTaxButton.AutoSize = True
        Me.noTaxButton.Checked = True
        Me.noTaxButton.Location = New System.Drawing.Point(16, 12)
        Me.noTaxButton.Name = "noTaxButton"
        Me.noTaxButton.Size = New System.Drawing.Size(107, 17)
        Me.noTaxButton.TabIndex = 0
        Me.noTaxButton.TabStop = True
        Me.noTaxButton.Text = "No Tax Transfers"
        Me.noTaxButton.UseVisualStyleBackColor = True
        '
        'taxCharButton
        '
        Me.taxCharButton.AutoSize = True
        Me.taxCharButton.Location = New System.Drawing.Point(105, 15)
        Me.taxCharButton.Name = "taxCharButton"
        Me.taxCharButton.Size = New System.Drawing.Size(71, 17)
        Me.taxCharButton.TabIndex = 4
        Me.taxCharButton.Text = "Character"
        Me.taxCharButton.UseVisualStyleBackColor = True
        '
        'taxLetterButton
        '
        Me.taxLetterButton.AutoSize = True
        Me.taxLetterButton.Checked = True
        Me.taxLetterButton.Location = New System.Drawing.Point(16, 15)
        Me.taxLetterButton.Name = "taxLetterButton"
        Me.taxLetterButton.Size = New System.Drawing.Size(52, 17)
        Me.taxLetterButton.TabIndex = 5
        Me.taxLetterButton.TabStop = True
        Me.taxLetterButton.Text = "Letter"
        Me.taxLetterButton.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.agSingleButton)
        Me.Panel2.Controls.Add(Me.hybridAgencyButton)
        Me.Panel2.Controls.Add(Me.stdAgencyButton)
        Me.Panel2.Controls.Add(Me.chkAgencyButton)
        Me.Panel2.Controls.Add(Me.noAgencyButton)
        Me.Panel2.Location = New System.Drawing.Point(242, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(190, 134)
        Me.Panel2.TabIndex = 6
        '
        'agSingleButton
        '
        Me.agSingleButton.AutoSize = True
        Me.agSingleButton.Location = New System.Drawing.Point(16, 112)
        Me.agSingleButton.Name = "agSingleButton"
        Me.agSingleButton.Size = New System.Drawing.Size(91, 17)
        Me.agSingleButton.TabIndex = 4
        Me.agSingleButton.Text = "Single Liability"
        Me.agSingleButton.UseVisualStyleBackColor = True
        '
        'hybridAgencyButton
        '
        Me.hybridAgencyButton.AutoSize = True
        Me.hybridAgencyButton.Location = New System.Drawing.Point(16, 87)
        Me.hybridAgencyButton.Name = "hybridAgencyButton"
        Me.hybridAgencyButton.Size = New System.Drawing.Size(73, 17)
        Me.hybridAgencyButton.TabIndex = 3
        Me.hybridAgencyButton.Text = "Wolverine"
        Me.hybridAgencyButton.UseVisualStyleBackColor = True
        '
        'stdAgencyButton
        '
        Me.stdAgencyButton.AutoSize = True
        Me.stdAgencyButton.Location = New System.Drawing.Point(16, 37)
        Me.stdAgencyButton.Name = "stdAgencyButton"
        Me.stdAgencyButton.Size = New System.Drawing.Size(154, 17)
        Me.stdAgencyButton.TabIndex = 2
        Me.stdAgencyButton.Text = "Standard Agency Transfers"
        Me.stdAgencyButton.UseVisualStyleBackColor = True
        '
        'chkAgencyButton
        '
        Me.chkAgencyButton.AutoSize = True
        Me.chkAgencyButton.Location = New System.Drawing.Point(16, 62)
        Me.chkAgencyButton.Name = "chkAgencyButton"
        Me.chkAgencyButton.Size = New System.Drawing.Size(143, 17)
        Me.chkAgencyButton.TabIndex = 1
        Me.chkAgencyButton.Text = "Actual Agency Payments"
        Me.chkAgencyButton.UseVisualStyleBackColor = True
        '
        'noAgencyButton
        '
        Me.noAgencyButton.AutoSize = True
        Me.noAgencyButton.Checked = True
        Me.noAgencyButton.Location = New System.Drawing.Point(16, 12)
        Me.noAgencyButton.Name = "noAgencyButton"
        Me.noAgencyButton.Size = New System.Drawing.Size(125, 17)
        Me.noAgencyButton.TabIndex = 0
        Me.noAgencyButton.TabStop = True
        Me.noAgencyButton.Text = "No Agency Transfers"
        Me.noAgencyButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(255, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Agency Options"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.taxCharButton)
        Me.Panel3.Controls.Add(Me.taxLetterButton)
        Me.Panel3.Location = New System.Drawing.Point(28, 196)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(190, 46)
        Me.Panel3.TabIndex = 8
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.agCharButton)
        Me.Panel4.Controls.Add(Me.agLetterButton)
        Me.Panel4.Location = New System.Drawing.Point(242, 196)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(190, 46)
        Me.Panel4.TabIndex = 9
        '
        'agCharButton
        '
        Me.agCharButton.AutoSize = True
        Me.agCharButton.Location = New System.Drawing.Point(105, 15)
        Me.agCharButton.Name = "agCharButton"
        Me.agCharButton.Size = New System.Drawing.Size(71, 17)
        Me.agCharButton.TabIndex = 4
        Me.agCharButton.Text = "Character"
        Me.agCharButton.UseVisualStyleBackColor = True
        '
        'agLetterButton
        '
        Me.agLetterButton.AutoSize = True
        Me.agLetterButton.Checked = True
        Me.agLetterButton.Location = New System.Drawing.Point(16, 15)
        Me.agLetterButton.Name = "agLetterButton"
        Me.agLetterButton.Size = New System.Drawing.Size(52, 17)
        Me.agLetterButton.TabIndex = 5
        Me.agLetterButton.TabStop = True
        Me.agLetterButton.Text = "Letter"
        Me.agLetterButton.UseVisualStyleBackColor = True
        '
        'modscButton
        '
        Me.modscButton.AutoSize = True
        Me.modscButton.BackColor = System.Drawing.Color.LavenderBlush
        Me.modscButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.modscButton.Location = New System.Drawing.Point(28, 257)
        Me.modscButton.Name = "modscButton"
        Me.modscButton.Size = New System.Drawing.Size(60, 23)
        Me.modscButton.TabIndex = 22
        Me.modscButton.Text = "MODSC"
        Me.modscButton.UseVisualStyleBackColor = False
        '
        'modsc6Box
        '
        Me.modsc6Box.FormattingEnabled = True
        Me.modsc6Box.Location = New System.Drawing.Point(388, 258)
        Me.modsc6Box.Name = "modsc6Box"
        Me.modsc6Box.Size = New System.Drawing.Size(60, 21)
        Me.modsc6Box.Sorted = True
        Me.modsc6Box.TabIndex = 23
        '
        'modsc5Box
        '
        Me.modsc5Box.FormattingEnabled = True
        Me.modsc5Box.Location = New System.Drawing.Point(328, 258)
        Me.modsc5Box.Name = "modsc5Box"
        Me.modsc5Box.Size = New System.Drawing.Size(60, 21)
        Me.modsc5Box.Sorted = True
        Me.modsc5Box.TabIndex = 24
        '
        'modsc4Box
        '
        Me.modsc4Box.FormattingEnabled = True
        Me.modsc4Box.Location = New System.Drawing.Point(268, 258)
        Me.modsc4Box.Name = "modsc4Box"
        Me.modsc4Box.Size = New System.Drawing.Size(60, 21)
        Me.modsc4Box.Sorted = True
        Me.modsc4Box.TabIndex = 25
        '
        'modsc3Box
        '
        Me.modsc3Box.FormattingEnabled = True
        Me.modsc3Box.Location = New System.Drawing.Point(208, 258)
        Me.modsc3Box.Name = "modsc3Box"
        Me.modsc3Box.Size = New System.Drawing.Size(60, 21)
        Me.modsc3Box.Sorted = True
        Me.modsc3Box.TabIndex = 26
        '
        'modsc2Box
        '
        Me.modsc2Box.FormattingEnabled = True
        Me.modsc2Box.Location = New System.Drawing.Point(148, 258)
        Me.modsc2Box.Name = "modsc2Box"
        Me.modsc2Box.Size = New System.Drawing.Size(60, 21)
        Me.modsc2Box.Sorted = True
        Me.modsc2Box.TabIndex = 27
        '
        'modsc1Box
        '
        Me.modsc1Box.FormattingEnabled = True
        Me.modsc1Box.Location = New System.Drawing.Point(88, 258)
        Me.modsc1Box.Name = "modsc1Box"
        Me.modsc1Box.Size = New System.Drawing.Size(60, 21)
        Me.modsc1Box.Sorted = True
        Me.modsc1Box.TabIndex = 28
        '
        'transfersFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 301)
        Me.Controls.Add(Me.modsc1Box)
        Me.Controls.Add(Me.modsc2Box)
        Me.Controls.Add(Me.modsc3Box)
        Me.Controls.Add(Me.modsc4Box)
        Me.Controls.Add(Me.modsc5Box)
        Me.Controls.Add(Me.modsc6Box)
        Me.Controls.Add(Me.modscButton)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "transfersFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transfer Options"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents taxLetterButton As RadioButton
    Friend WithEvents taxCharButton As RadioButton
    Friend WithEvents erTaxButton As RadioButton
    Friend WithEvents stdTaxButton As RadioButton
    Friend WithEvents eeTaxButton As RadioButton
    Friend WithEvents noTaxButton As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents hybridAgencyButton As RadioButton
    Friend WithEvents stdAgencyButton As RadioButton
    Friend WithEvents chkAgencyButton As RadioButton
    Friend WithEvents noAgencyButton As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents agCharButton As RadioButton
    Friend WithEvents agLetterButton As RadioButton
    Friend WithEvents agSingleButton As RadioButton
    Friend WithEvents modscButton As Button
    Friend WithEvents modsc6Box As ComboBox
    Friend WithEvents modsc5Box As ComboBox
    Friend WithEvents modsc4Box As ComboBox
    Friend WithEvents modsc3Box As ComboBox
    Friend WithEvents modsc2Box As ComboBox
    Friend WithEvents modsc1Box As ComboBox
End Class
