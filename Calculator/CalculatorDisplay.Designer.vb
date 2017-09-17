<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculatorDisplay
  Inherits System.Windows.Forms.UserControl

  'UserControl overrides dispose to clean up the component list.
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
    Me.lblNumberSystem = New System.Windows.Forms.Label()
    Me.txtNumberDisplay = New System.Windows.Forms.TextBox()
    Me.lblCurrentValues = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'lblNumberSystem
    '
    Me.lblNumberSystem.Location = New System.Drawing.Point(-3, 0)
    Me.lblNumberSystem.Name = "lblNumberSystem"
    Me.lblNumberSystem.Size = New System.Drawing.Size(100, 23)
    Me.lblNumberSystem.TabIndex = 0
    '
    'txtNumberDisplay
    '
    Me.txtNumberDisplay.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtNumberDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!)
    Me.txtNumberDisplay.Location = New System.Drawing.Point(0, 26)
    Me.txtNumberDisplay.Multiline = True
    Me.txtNumberDisplay.Name = "txtNumberDisplay"
    Me.txtNumberDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.txtNumberDisplay.Size = New System.Drawing.Size(319, 69)
    Me.txtNumberDisplay.TabIndex = 1
    Me.txtNumberDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'lblCurrentValues
    '
    Me.lblCurrentValues.Location = New System.Drawing.Point(124, 0)
    Me.lblCurrentValues.Name = "lblCurrentValues"
    Me.lblCurrentValues.Size = New System.Drawing.Size(176, 23)
    Me.lblCurrentValues.TabIndex = 0
    Me.lblCurrentValues.TextAlign = System.Drawing.ContentAlignment.TopRight
    '
    'CalculatorDisplay
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.txtNumberDisplay)
    Me.Controls.Add(Me.lblCurrentValues)
    Me.Controls.Add(Me.lblNumberSystem)
    Me.Name = "CalculatorDisplay"
    Me.Size = New System.Drawing.Size(319, 108)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents lblNumberSystem As Label
  Friend WithEvents txtNumberDisplay As TextBox
  Friend WithEvents lblCurrentValues As Label
End Class
