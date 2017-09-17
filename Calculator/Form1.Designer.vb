<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculator
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
    Me.cboNumSystemSelect = New System.Windows.Forms.ComboBox()
    Me.btnDecimal = New Global.Calculator.ButtonExtended()
    Me.btnNumPadDivide = New Global.Calculator.ButtonExtended()
    Me.btnNumPadMultiply = New Global.Calculator.ButtonExtended()
    Me.btnNumPadMinus = New Global.Calculator.ButtonExtended()
    Me.btnNumPadPlus = New Global.Calculator.ButtonExtended()
    Me.btnNumPad9 = New Global.Calculator.ButtonExtended()
    Me.btnNumPad6 = New Global.Calculator.ButtonExtended()
    Me.btnNumPad3 = New Global.Calculator.ButtonExtended()
    Me.btnClearAll = New Global.Calculator.ButtonExtended()
    Me.btnNumPadEquals = New Global.Calculator.ButtonExtended()
    Me.btnNumPad8 = New Global.Calculator.ButtonExtended()
    Me.btnNumPad5 = New Global.Calculator.ButtonExtended()
    Me.btnNumPad2 = New Global.Calculator.ButtonExtended()
    Me.btnNumPad0 = New Global.Calculator.ButtonExtended()
    Me.btnNumPad7 = New Global.Calculator.ButtonExtended()
    Me.btnNumPad4 = New Global.Calculator.ButtonExtended()
    Me.btnNumPad1 = New Global.Calculator.ButtonExtended()
    Me.cdCalcDisplay = New Global.Calculator.CalculatorDisplay()
    Me.SuspendLayout()
    '
    'cboNumSystemSelect
    '
    Me.cboNumSystemSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboNumSystemSelect.FormattingEnabled = True
    Me.cboNumSystemSelect.Items.AddRange(New Object() {"Decimal", "Hexadecimal", "Octal", "Base31", "Binary"})
    Me.cboNumSystemSelect.Location = New System.Drawing.Point(18, 128)
    Me.cboNumSystemSelect.Name = "cboNumSystemSelect"
    Me.cboNumSystemSelect.Size = New System.Drawing.Size(270, 21)
    Me.cboNumSystemSelect.TabIndex = 1
    '
    'btnDecimal
    '
    Me.btnDecimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
    Me.btnDecimal.ForeColor = System.Drawing.Color.Navy
    Me.btnDecimal.Location = New System.Drawing.Point(225, 440)
    Me.btnDecimal.Name = "btnDecimal"
    Me.btnDecimal.Size = New System.Drawing.Size(63, 62)
    Me.btnDecimal.TabIndex = 18
    Me.btnDecimal.Text = "."
    Me.btnDecimal.UseVisualStyleBackColor = True
    '
    'btnNumPadDivide
    '
    Me.btnNumPadDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
    Me.btnNumPadDivide.ForeColor = System.Drawing.Color.Navy
    Me.btnNumPadDivide.Location = New System.Drawing.Point(225, 372)
    Me.btnNumPadDivide.Name = "btnNumPadDivide"
    Me.btnNumPadDivide.Size = New System.Drawing.Size(63, 62)
    Me.btnNumPadDivide.TabIndex = 16
    Me.btnNumPadDivide.Text = "/"
    Me.btnNumPadDivide.UseVisualStyleBackColor = True
    '
    'btnNumPadMultiply
    '
    Me.btnNumPadMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
    Me.btnNumPadMultiply.ForeColor = System.Drawing.Color.Navy
    Me.btnNumPadMultiply.Location = New System.Drawing.Point(225, 304)
    Me.btnNumPadMultiply.Name = "btnNumPadMultiply"
    Me.btnNumPadMultiply.Size = New System.Drawing.Size(63, 62)
    Me.btnNumPadMultiply.TabIndex = 13
    Me.btnNumPadMultiply.Text = "*"
    Me.btnNumPadMultiply.UseVisualStyleBackColor = True
    '
    'btnNumPadMinus
    '
    Me.btnNumPadMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
    Me.btnNumPadMinus.ForeColor = System.Drawing.Color.Navy
    Me.btnNumPadMinus.Location = New System.Drawing.Point(225, 236)
    Me.btnNumPadMinus.Name = "btnNumPadMinus"
    Me.btnNumPadMinus.Size = New System.Drawing.Size(63, 62)
    Me.btnNumPadMinus.TabIndex = 9
    Me.btnNumPadMinus.Text = "-"
    Me.btnNumPadMinus.UseVisualStyleBackColor = True
    '
    'btnNumPadPlus
    '
    Me.btnNumPadPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
    Me.btnNumPadPlus.ForeColor = System.Drawing.Color.Navy
    Me.btnNumPadPlus.Location = New System.Drawing.Point(225, 168)
    Me.btnNumPadPlus.Name = "btnNumPadPlus"
    Me.btnNumPadPlus.Size = New System.Drawing.Size(63, 62)
    Me.btnNumPadPlus.TabIndex = 5
    Me.btnNumPadPlus.Text = "+"
    Me.btnNumPadPlus.UseVisualStyleBackColor = True
    '
    'btnNumPad9
    '
    Me.btnNumPad9.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
    Me.btnNumPad9.ForeColor = System.Drawing.Color.Navy
    Me.btnNumPad9.Location = New System.Drawing.Point(156, 304)
    Me.btnNumPad9.Name = "btnNumPad9"
    Me.btnNumPad9.Size = New System.Drawing.Size(63, 62)
    Me.btnNumPad9.TabIndex = 12
    Me.btnNumPad9.Text = "9"
    Me.btnNumPad9.UseVisualStyleBackColor = True
    '
    'btnNumPad6
    '
    Me.btnNumPad6.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
    Me.btnNumPad6.ForeColor = System.Drawing.Color.Navy
    Me.btnNumPad6.Location = New System.Drawing.Point(156, 236)
    Me.btnNumPad6.Name = "btnNumPad6"
    Me.btnNumPad6.Size = New System.Drawing.Size(63, 62)
    Me.btnNumPad6.TabIndex = 8
    Me.btnNumPad6.Text = "6"
    Me.btnNumPad6.UseVisualStyleBackColor = True
    '
    'btnNumPad3
    '
    Me.btnNumPad3.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
    Me.btnNumPad3.ForeColor = System.Drawing.Color.Navy
    Me.btnNumPad3.Location = New System.Drawing.Point(156, 168)
    Me.btnNumPad3.Name = "btnNumPad3"
    Me.btnNumPad3.Size = New System.Drawing.Size(63, 62)
    Me.btnNumPad3.TabIndex = 4
    Me.btnNumPad3.Text = "3"
    Me.btnNumPad3.UseVisualStyleBackColor = True
    '
    'btnClearAll
    '
    Me.btnClearAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
    Me.btnClearAll.ForeColor = System.Drawing.Color.Navy
    Me.btnClearAll.Location = New System.Drawing.Point(18, 440)
    Me.btnClearAll.Name = "btnClearAll"
    Me.btnClearAll.Size = New System.Drawing.Size(201, 62)
    Me.btnClearAll.TabIndex = 17
    Me.btnClearAll.Text = "Clear"
    Me.btnClearAll.UseVisualStyleBackColor = True
    '
    'btnNumPadEquals
    '
    Me.btnNumPadEquals.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
    Me.btnNumPadEquals.ForeColor = System.Drawing.Color.Navy
    Me.btnNumPadEquals.Location = New System.Drawing.Point(87, 372)
    Me.btnNumPadEquals.Name = "btnNumPadEquals"
    Me.btnNumPadEquals.Size = New System.Drawing.Size(132, 62)
    Me.btnNumPadEquals.TabIndex = 15
    Me.btnNumPadEquals.Text = "="
    Me.btnNumPadEquals.UseVisualStyleBackColor = True
    '
    'btnNumPad8
    '
    Me.btnNumPad8.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
    Me.btnNumPad8.ForeColor = System.Drawing.Color.Navy
    Me.btnNumPad8.Location = New System.Drawing.Point(87, 304)
    Me.btnNumPad8.Name = "btnNumPad8"
    Me.btnNumPad8.Size = New System.Drawing.Size(63, 62)
    Me.btnNumPad8.TabIndex = 11
    Me.btnNumPad8.Text = "8"
    Me.btnNumPad8.UseVisualStyleBackColor = True
    '
    'btnNumPad5
    '
    Me.btnNumPad5.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
    Me.btnNumPad5.ForeColor = System.Drawing.Color.Navy
    Me.btnNumPad5.Location = New System.Drawing.Point(87, 236)
    Me.btnNumPad5.Name = "btnNumPad5"
    Me.btnNumPad5.Size = New System.Drawing.Size(63, 62)
    Me.btnNumPad5.TabIndex = 7
    Me.btnNumPad5.Text = "5"
    Me.btnNumPad5.UseVisualStyleBackColor = True
    '
    'btnNumPad2
    '
    Me.btnNumPad2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
    Me.btnNumPad2.ForeColor = System.Drawing.Color.Navy
    Me.btnNumPad2.Location = New System.Drawing.Point(87, 168)
    Me.btnNumPad2.Name = "btnNumPad2"
    Me.btnNumPad2.Size = New System.Drawing.Size(63, 62)
    Me.btnNumPad2.TabIndex = 3
    Me.btnNumPad2.Text = "2"
    Me.btnNumPad2.UseVisualStyleBackColor = True
    '
    'btnNumPad0
    '
    Me.btnNumPad0.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
    Me.btnNumPad0.ForeColor = System.Drawing.Color.Navy
    Me.btnNumPad0.Location = New System.Drawing.Point(18, 372)
    Me.btnNumPad0.Name = "btnNumPad0"
    Me.btnNumPad0.Size = New System.Drawing.Size(63, 62)
    Me.btnNumPad0.TabIndex = 14
    Me.btnNumPad0.Text = "0"
    Me.btnNumPad0.UseVisualStyleBackColor = True
    '
    'btnNumPad7
    '
    Me.btnNumPad7.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
    Me.btnNumPad7.ForeColor = System.Drawing.Color.Navy
    Me.btnNumPad7.Location = New System.Drawing.Point(18, 304)
    Me.btnNumPad7.Name = "btnNumPad7"
    Me.btnNumPad7.Size = New System.Drawing.Size(63, 62)
    Me.btnNumPad7.TabIndex = 10
    Me.btnNumPad7.Text = "7"
    Me.btnNumPad7.UseVisualStyleBackColor = True
    '
    'btnNumPad4
    '
    Me.btnNumPad4.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
    Me.btnNumPad4.ForeColor = System.Drawing.Color.Navy
    Me.btnNumPad4.Location = New System.Drawing.Point(18, 236)
    Me.btnNumPad4.Name = "btnNumPad4"
    Me.btnNumPad4.Size = New System.Drawing.Size(63, 62)
    Me.btnNumPad4.TabIndex = 6
    Me.btnNumPad4.Text = "4"
    Me.btnNumPad4.UseVisualStyleBackColor = True
    '
    'btnNumPad1
    '
    Me.btnNumPad1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
    Me.btnNumPad1.ForeColor = System.Drawing.Color.Navy
    Me.btnNumPad1.Location = New System.Drawing.Point(18, 168)
    Me.btnNumPad1.Name = "btnNumPad1"
    Me.btnNumPad1.Size = New System.Drawing.Size(63, 62)
    Me.btnNumPad1.TabIndex = 2
    Me.btnNumPad1.Text = "1"
    Me.btnNumPad1.UseVisualStyleBackColor = True
    '
    'cdCalcDisplay
    '
    Me.cdCalcDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
    Me.cdCalcDisplay.Location = New System.Drawing.Point(3, 5)
    Me.cdCalcDisplay.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
    Me.cdCalcDisplay.Name = "cdCalcDisplay"
    Me.cdCalcDisplay.NumberSystem = ""
    Me.cdCalcDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.cdCalcDisplay.Size = New System.Drawing.Size(299, 113)
    Me.cdCalcDisplay.TabIndex = 0
    Me.cdCalcDisplay.Value = "0"
    '
    'Calculator
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(306, 513)
    Me.Controls.Add(Me.btnDecimal)
    Me.Controls.Add(Me.btnNumPadDivide)
    Me.Controls.Add(Me.btnNumPadMultiply)
    Me.Controls.Add(Me.btnNumPadMinus)
    Me.Controls.Add(Me.btnNumPadPlus)
    Me.Controls.Add(Me.btnNumPad9)
    Me.Controls.Add(Me.btnNumPad6)
    Me.Controls.Add(Me.btnNumPad3)
    Me.Controls.Add(Me.btnClearAll)
    Me.Controls.Add(Me.btnNumPadEquals)
    Me.Controls.Add(Me.btnNumPad8)
    Me.Controls.Add(Me.btnNumPad5)
    Me.Controls.Add(Me.btnNumPad2)
    Me.Controls.Add(Me.btnNumPad0)
    Me.Controls.Add(Me.btnNumPad7)
    Me.Controls.Add(Me.btnNumPad4)
    Me.Controls.Add(Me.btnNumPad1)
    Me.Controls.Add(Me.cboNumSystemSelect)
    Me.Controls.Add(Me.cdCalcDisplay)
    Me.MaximumSize = New System.Drawing.Size(322, 552)
    Me.MinimumSize = New System.Drawing.Size(322, 552)
    Me.Name = "Calculator"
    Me.Text = "Calculator"
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents cdCalcDisplay As CalculatorDisplay
  Friend WithEvents cboNumSystemSelect As ComboBox
  Friend WithEvents btnNumPad1 As ButtonExtended
  Friend WithEvents btnNumPad2 As ButtonExtended
  Friend WithEvents btnNumPad3 As ButtonExtended
  Friend WithEvents btnNumPadPlus As ButtonExtended
  Friend WithEvents btnNumPad4 As ButtonExtended
  Friend WithEvents btnNumPad5 As ButtonExtended
  Friend WithEvents btnNumPad6 As ButtonExtended
  Friend WithEvents btnNumPadMinus As ButtonExtended
  Friend WithEvents btnNumPad7 As ButtonExtended
  Friend WithEvents btnNumPad8 As ButtonExtended
  Friend WithEvents btnNumPad9 As ButtonExtended
  Friend WithEvents btnNumPadMultiply As ButtonExtended
  Friend WithEvents btnNumPad0 As ButtonExtended
  Friend WithEvents btnNumPadEquals As ButtonExtended
  Friend WithEvents btnNumPadDivide As ButtonExtended
  Friend WithEvents btnClearAll As ButtonExtended
  Friend WithEvents btnDecimal As ButtonExtended
End Class
