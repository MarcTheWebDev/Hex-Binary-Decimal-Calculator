Imports MathLogic
' Copyright (c) 2017 Applied Systems, Inc.
'
''' -----------------------------------------------------------------------------
''' Project	 : Calculator
''' Class	 : Calculator
''' -----------------------------------------------------------------------------
''' <summary>
'''   The code for the UI of the calculator that handles click events, input validation,  and calls on other
'''   methods to do math operations.
''' </summary>
''' <remarks>
''' </remarks>
''' <history>
''' 	[Marcus]	2/20/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

Public Class Calculator
    Private p_fUnacceptableCharWasInput As Boolean = False ' Boolean that flags if the user attempts to input anything besides 
    ' what would be acceptable for the current Numbering System
    Private p_sActiveOperator As String = String.Empty ' Represents the operator the user may (not) have clicked. Such as + - / or *
    Private p_dictNumberSystems As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer) 'A dictionary to relate the numbering system (string) and the
    ' Actual base (int)
    Private p_sFirstValue As String = "0" ' The first value entered before an operator is hit. 
    ' Established constants to represent the different states of the cboBox
    Private Const p_DECIMAL As String = "Decimal"
    Private Const p_BASE31 As String = "Base31"
    Private Const p_OCTAL As String = "Octal"
    Private Const p_BINARY As String = "Binary"
    Private Const p_HEXADECIMAL As String = "Hexadecimal"
    ''' <summary>
    ''' This sub just initializes some base values into things like the dictionary and combo box on form load
    ''' </summary>
    ''' <param name="sender">The sender of the event</param>
    ''' <param name="e">The event arguments</param>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cdCalcDisplay.txtNumberDisplay.ContextMenu = New ContextMenu ' Empties the context menu for the display to prevent pasting
            cboNumSystemSelect.Text = p_DECIMAL ' simply sets the default value of cbobox.
            ' Adds the associations between the combobox values and the bases so they can be easily passed to a function.
            p_dictNumberSystems.Add(p_BASE31, 31)
            p_dictNumberSystems.Add(p_OCTAL, 8)
            p_dictNumberSystems.Add(p_BINARY, 2)
            p_dictNumberSystems.Add(p_HEXADECIMAL, 16)
        Catch ex As Exception
            MessageBox.Show("There was an error loading the form. The experience may not be optimal", "Error: 10006", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    ''' <summary>
    ''' This sub ensures that when a number button is clicked that the number is copied to the display appropriately
    ''' and that the program does not attempt to cast or format values with commas that shouldn't be (like hex or binary)
    ''' </summary>
    ''' <param name="sender">The sender of the event</param>
    ''' <param name="e">The event arguments</param>
    Private Sub btnNumPad_Click(sender As Object, e As EventArgs) Handles btnNumPad1.Click,
        btnNumPad2.Click, btnNumPad3.Click, btnNumPad4.Click, btnNumPad5.Click, btnNumPad6.Click,
        btnNumPad7.Click, btnNumPad8.Click, btnNumPad9.Click, btnNumPad0.Click

        Try
            ' This if in particular checks to see if the numbering is even set to decimal before stepping further into checking
            ' whether things should be formatted


            'Sets the maximum characters for the numbering systems

            Select Case DirectCast(cboNumSystemSelect.SelectedItem, String)
                Case p_DECIMAL
                    If cdCalcDisplay.Screen.Text.Length >= 30 Then
                        MessageBox.Show("You have reached the max number of characters for this Number system")
                    Else
                        cdCalcDisplay.Screen.Text += DirectCast(sender, Control).Text
                        If cdCalcDisplay.Screen.Text.Length > 3 Then
                            'This If stops formatting if a . is present as to allow a 0 if someone is trying to type something like .000005
                            cdCalcDisplay.Screen.Text = String.Format("{0:#,#.#############################}",
                                                             Convert.ToDecimal(cdCalcDisplay.Screen.Text, System.Globalization.CultureInfo.InvariantCulture))
                        End If
                    End If
                Case p_BASE31
                    If cdCalcDisplay.Screen.Text.Length >= 19 Then
                        MessageBox.Show("You have reached the max number of characters for this Number system")
                    Else
                        cdCalcDisplay.Screen.Text += DirectCast(sender, Control).Text
                    End If
                Case p_OCTAL
                    If cdCalcDisplay.Screen.Text.Length >= 32 Then
                        MessageBox.Show("You have reached the max number of characters for this Number system")
                    Else
                        cdCalcDisplay.Screen.Text += DirectCast(sender, Control).Text
                    End If
                Case p_HEXADECIMAL
                    If cdCalcDisplay.Screen.Text.Length >= 24 Then
                        MessageBox.Show("You have reached the max number of characters for this Number system")
                    Else
                        cdCalcDisplay.Screen.Text += DirectCast(sender, Control).Text
                    End If
                Case Else
                    cdCalcDisplay.Screen.Text += DirectCast(sender, Control).Text
            End Select
        Catch ex As ArithmeticException
            MessageBox.Show(ex.Message, "Error: 10003", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cdCalcDisplay.Clear()
        Catch ex2 As Exception
            MessageBox.Show("There seems to have been an issue." & ex2.Message, "Error: 10004", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cdCalcDisplay.Clear()
        End Try
    End Sub
    ''' <summary>
    ''' On the cbo changing this sub re-enables all buttons and then disables ones that do not fit with the current numbering scheme.
    ''' It also sets the composite control's label to be equal to the system name
    ''' </summary>
    ''' <param name="sender">The sender of the event</param>
    ''' <param name="e">The event arguments</param>
    Private Sub cboNumSystemSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNumSystemSelect.SelectedIndexChanged
        Try
            cdCalcDisplay.Clear()
            cdCalcDisplay.NumberSystem = DirectCast(cboNumSystemSelect.SelectedItem, String)
            'Resetting buttons that would have been changed to be enabled
            btnNumPad2.Enabled = True
            btnNumPad3.Enabled = True
            btnNumPad4.Enabled = True
            btnNumPad5.Enabled = True
            btnNumPad6.Enabled = True
            btnNumPad7.Enabled = True
            btnNumPad8.Enabled = True
            btnNumPad9.Enabled = True
            btnDecimal.Enabled = True
            'Disabling the appropriate buttons based off of the numbering system
            Select Case DirectCast(cboNumSystemSelect.SelectedItem, String)
                Case p_OCTAL
                    btnNumPad8.Enabled = False
                    btnNumPad9.Enabled = False
                    btnDecimal.Enabled = False
                Case p_BINARY
                    btnNumPad2.Enabled = False
                    btnNumPad3.Enabled = False
                    btnNumPad4.Enabled = False
                    btnNumPad5.Enabled = False
                    btnNumPad6.Enabled = False
                    btnNumPad7.Enabled = False
                    btnNumPad8.Enabled = False
                    btnNumPad9.Enabled = False
                    btnDecimal.Enabled = False
                Case p_HEXADECIMAL, p_BASE31
                    btnDecimal.Enabled = False

            End Select
        Catch ex As Exception
            MessageBox.Show("There seems to have been an issue enabling the appropriate buttons", "Error: 10005", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    ''' <summary>
    ''' This sub handles calling the methods in the Math Logic class library to output the results to the screen one the = 
    ''' button is clicked based on the active operator and numbers entered
    ''' </summary>
    ''' <param name="sender">The sender of the event</param>
    ''' <param name="e">The event arguments</param>
    Private Sub btnNumPadEquals_Click(sender As Object, e As EventArgs) Handles btnNumPadEquals.Click

        Dim oLogic As CalculatorMathLogic = New CalculatorMathLogic ' Instatiation of the Math class to actually call things from

        Try

            Dim sSecondValue As String = cdCalcDisplay.Screen.Text ' Gets the second value from the screen
            Dim sCurrentSystem As String = DirectCast(cboNumSystemSelect.SelectedItem, String) ' Holds the current system to decide what methods to call later
            'This outermost select statement checks the chosen operator to narrow down the actions taken
            Select Case p_sActiveOperator
                Case "+"
                    'These selects determine the current system and calls the appropriate methods for the operator and number type
                    Select Case sCurrentSystem
                        Case p_DECIMAL
                            cdCalcDisplay.Screen.Text = String.Format("{0:#,#.#####}", oLogic.Addition(Decimal.Parse(p_sFirstValue), Decimal.Parse(sSecondValue)))
                        Case Else
                            Dim decFirstValueAsDecimal As Decimal = oLogic.ConvertToDecimal(p_sFirstValue, p_dictNumberSystems.Item(sCurrentSystem))
                            Dim decSecondValueAsDecimal As Decimal = oLogic.ConvertToDecimal(sSecondValue, p_dictNumberSystems.Item(sCurrentSystem))
                            cdCalcDisplay.Screen.Text = oLogic.ConvertFromDecimal(oLogic.Addition(decFirstValueAsDecimal, decSecondValueAsDecimal), p_dictNumberSystems.Item(sCurrentSystem))
                    End Select

          ' The rest of these cases work the exact same just with different methods being called
                Case "-"
                    Select Case sCurrentSystem
                        Case p_DECIMAL
                            cdCalcDisplay.Screen.Text = String.Format("{0:#,#.#####}", oLogic.Subtraction(Decimal.Parse(p_sFirstValue), Decimal.Parse(sSecondValue)))
                        Case Else
                            Dim decFirstValueAsDecimal As Decimal = oLogic.ConvertToDecimal(p_sFirstValue, p_dictNumberSystems.Item(sCurrentSystem))
                            Dim decSecondValueAsDecimal As Decimal = oLogic.ConvertToDecimal(sSecondValue, p_dictNumberSystems.Item(sCurrentSystem))
                            cdCalcDisplay.Screen.Text = oLogic.ConvertFromDecimal(oLogic.Subtraction(decFirstValueAsDecimal, decSecondValueAsDecimal), p_dictNumberSystems.Item(sCurrentSystem))
                    End Select

                Case "*"
                    Select Case sCurrentSystem
                        Case p_DECIMAL
                            cdCalcDisplay.Screen.Text = String.Format("{0:#,#.#####}", oLogic.Multiplication(Decimal.Parse(p_sFirstValue), Decimal.Parse(sSecondValue)))
                        Case Else
                            Dim decFirstValueAsDecimal As Decimal = oLogic.ConvertToDecimal(p_sFirstValue, p_dictNumberSystems.Item(sCurrentSystem))
                            Dim decSecondValueAsDecimal As Decimal = oLogic.ConvertToDecimal(sSecondValue, p_dictNumberSystems.Item(sCurrentSystem))
                            cdCalcDisplay.Screen.Text = oLogic.ConvertFromDecimal(oLogic.Multiplication(decFirstValueAsDecimal, decSecondValueAsDecimal), p_dictNumberSystems.Item(sCurrentSystem))
                    End Select

                Case "/"
                    Select Case sCurrentSystem
                        Case p_DECIMAL
                            cdCalcDisplay.Screen.Text = String.Format("{0:#,#.#####}", oLogic.Division(Decimal.Parse(p_sFirstValue), Decimal.Parse(sSecondValue)))
                        Case Else
                            Dim decFirstValueAsDecimal As Decimal = oLogic.ConvertToDecimal(p_sFirstValue, p_dictNumberSystems.Item(sCurrentSystem))
                            Dim decSecondValueAsDecimal As Decimal = oLogic.ConvertToDecimal(sSecondValue, p_dictNumberSystems.Item(sCurrentSystem))
                            cdCalcDisplay.Screen.Text = oLogic.ConvertFromDecimal(oLogic.Division(decFirstValueAsDecimal, decSecondValueAsDecimal), p_dictNumberSystems.Item(sCurrentSystem))
                    End Select
                Case Else
                    'If there is no operator and the calculator screen is empty it just shows 0. Otherwise it does nothing.
                    If cdCalcDisplay.Screen.Text = String.Empty Then
                        cdCalcDisplay.Screen.Text = "0"
                    End If
            End Select

            'Adds the number to the Current Value label that tracks progress
            If cdCalcDisplay.lblCurrentValues.Text <> String.Empty Then
                If cdCalcDisplay.lblCurrentValues.Text(cdCalcDisplay.lblCurrentValues.Text.Length - 1) <> "=" Then
                    cdCalcDisplay.lblCurrentValues.Text += " " & sSecondValue & " ="
                End If
            End If

        Catch ex As DivideByZeroException
            cdCalcDisplay.Clear()
            MessageBox.Show("You attempted to Divide by Zero, this cannot be done", "Error: 10002", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex1 As OverflowException
            MessageBox.Show("The value was either too big or too small to calculate", "Error: 10008", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex2 As ArithmeticException
            cdCalcDisplay.Clear()
            MessageBox.Show(ex2.Message, "Error: 10003", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex3 As Exception
            cdCalcDisplay.Clear()
            MessageBox.Show("There seems to have been an issue.", "Error: 10004", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Finally
            p_sActiveOperator = String.Empty

        End Try
    End Sub
    ''' <summary>
    ''' This method handles allowing or disallowing key input as it pertains to the current numbering system.
    ''' It sets the p_UnacceptableCharWasInput boolean to flag inapropriate input to be blocked in a later keyPress method
    ''' </summary>
    ''' <param name="sender">The sender of the event</param>
    ''' <param name="e">The event arguments</param>
    Private Sub cdCalcDisplay_KeyDown(sender As Object, e As KeyEventArgs) Handles cdCalcDisplay.KeyDown
        Try
            p_fUnacceptableCharWasInput = False ' Resets the flagging property as to not lock people out if one bad key is pressed
            ' This select checks against the selected numbering system to handle button presses appropriately 
            Select Case DirectCast(cboNumSystemSelect.SelectedItem, String)

                Case p_DECIMAL
                    'Allowing 0-9 (top keys) for Decimal, 0-9 (number pad), and the back key In that order
                    If cdCalcDisplay.Screen.SelectionStart = 0 AndAlso cdCalcDisplay.Screen.Text.Contains("-") Then
                        p_fUnacceptableCharWasInput = True
                    Else
                        If e.KeyCode < Keys.D0 OrElse e.KeyCode > Keys.D9 Then
                            If e.KeyCode < Keys.NumPad0 OrElse e.KeyCode > Keys.NumPad9 Then
                                If e.KeyCode <> Keys.Back Then
                                    p_fUnacceptableCharWasInput = True
                                End If
                            End If
                        End If
                    End If
        'Allowing 0-1 (top keys) for Binary, 0-1 (number pad), and the back key In that order
                Case p_BINARY
                    If e.KeyCode < Keys.NumPad0 OrElse e.KeyCode > Keys.NumPad1 Then
                        If e.KeyCode < Keys.D0 OrElse e.KeyCode > Keys.D1 Then
                            If e.KeyCode <> Keys.Back Then
                                p_fUnacceptableCharWasInput = True
                            End If
                        End If
                    End If
        'Allowing 0-7 (top keys) for Octal, 0-7 (number pad), and the back key In that order
                Case p_OCTAL
                    If e.KeyCode < Keys.D0 OrElse e.KeyCode > Keys.D7 Then
                        If e.KeyCode < Keys.NumPad0 OrElse e.KeyCode > Keys.NumPad7 Then
                            If e.KeyCode <> Keys.Back Then
                                p_fUnacceptableCharWasInput = True
                            End If
                        End If
                    End If
        'Allowing 0-9 (top keys) for Base31, 0-9 (number pad), B-Z excluding vowels, and the back key In that order
                Case p_BASE31
                    If e.KeyCode < Keys.D0 OrElse e.KeyCode > Keys.D9 Then
                        If e.KeyCode < Keys.NumPad0 OrElse e.KeyCode > Keys.NumPad9 Then
                            If e.KeyCode = Keys.E OrElse e.KeyCode = Keys.I OrElse e.KeyCode = Keys.O OrElse e.KeyCode = Keys.U Then
                                p_fUnacceptableCharWasInput = True
                            ElseIf e.KeyCode < Keys.B OrElse e.KeyCode > Keys.Z Then
                                If e.KeyCode <> Keys.Back Then
                                    p_fUnacceptableCharWasInput = True
                                End If
                            End If
                        End If
                    End If
        'Allowing 0-9 (top keys) for Hex, 0-9 (number pad), A-F and the back key In that order
                Case p_HEXADECIMAL
                    If e.KeyCode < Keys.D0 OrElse e.KeyCode > Keys.D9 Then
                        If e.KeyCode < Keys.NumPad0 OrElse e.KeyCode > Keys.NumPad9 Then
                            If e.KeyCode < Keys.A OrElse e.KeyCode > Keys.F Then
                                If e.KeyCode <> Keys.Back Then
                                    p_fUnacceptableCharWasInput = True
                                End If
                            End If
                        End If
                    End If

            End Select

        Catch ex As Exception
            MessageBox.Show("There was an error Verifying input. The experience may not be optimal", "Error: 10007", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    ''' <summary>
    ''' This sub handles rejecting key presses after a quick check to see if the flagged value was a . or a - and if that is appropriate for
    ''' the numbering system or if that symbol already exists in the number
    ''' </summary>
    ''' <param name="sender">The sender of the event</param>
    ''' <param name="e">The event arguments</param>
    Private Sub cdCalcDisplay_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cdCalcDisplay.KeyPress
        Try
            If DirectCast(cboNumSystemSelect.SelectedItem, String) = p_DECIMAL Then

                Dim iIndexOfMinus As Integer = cdCalcDisplay.Screen.Text.IndexOf("-") ' An integer to hold the index of any "-" entered to help ensure there is only one
                ' Statements that narrow down if the key pressed is a "." or "-" and only allows the
                ' "." to be added if there is no other "." present
                If cdCalcDisplay.Screen.Text.Length >= 30 AndAlso e.KeyChar <> Convert.ToChar(8) Then
                    MessageBox.Show("You have reached the max number of characters for this Number system")
                    e.Handled = True
                Else
                    If e.KeyChar <> "." AndAlso e.KeyChar <> "-" AndAlso p_fUnacceptableCharWasInput Then
                        e.Handled = True
                        Exit Sub
                    ElseIf e.KeyChar = "." AndAlso cdCalcDisplay.Screen.Text.Contains(".") Then
                        e.Handled = True
                        Exit Sub
                    End If
                    ' If Statements to only allow a minus if the string is empty or there is no other
                    ' minus inexistance
                    If e.KeyChar = "-" AndAlso cboNumSystemSelect.Text = p_DECIMAL Then
                        If iIndexOfMinus <> -1 OrElse cdCalcDisplay.Screen.SelectionStart <> 0 Then
                            e.Handled = True
                        Else
                        End If
                    End If
                End If
                'Sets the maximum characters for the numbering systems
            ElseIf DirectCast(cboNumSystemSelect.SelectedItem, String) = p_BASE31 OrElse DirectCast(cboNumSystemSelect.SelectedItem, String) = p_OCTAL OrElse
          DirectCast(cboNumSystemSelect.SelectedItem, String) = p_HEXADECIMAL Then
                Select Case DirectCast(cboNumSystemSelect.SelectedItem, String)
                    Case p_BASE31
                        If cdCalcDisplay.Screen.Text.Length >= 19 AndAlso e.KeyChar <> Convert.ToChar(8) Then
                            e.Handled = True
                            MessageBox.Show("You have reached the max number of characters for this Number system")
                        End If
                    Case p_OCTAL
                        If cdCalcDisplay.Screen.Text.Length >= 32 AndAlso e.KeyChar <> Convert.ToChar(8) Then
                            e.Handled = True
                            MessageBox.Show("You have reached the max number of characters for this Number system")
                        End If
                    Case Else
                        If cdCalcDisplay.Screen.Text.Length >= 24 AndAlso e.KeyChar <> Convert.ToChar(8) Then
                            e.Handled = True
                            MessageBox.Show("You have reached the max number of characters for this Number system")
                        End If
                End Select
                If p_fUnacceptableCharWasInput Then
                    e.Handled = True
                End If
            Else
                If p_fUnacceptableCharWasInput Then
                    e.Handled = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("There was an error Verifying input. The experience may not be optimal", "Error: 10007", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    ''' <summary>
    ''' This sub handles formatting the number to have commas if they are entered by keyboard rather than buttons
    ''' </summary>
    ''' <param name="sender">The sender of the event</param>
    ''' <param name="e">The event arguments</param>
    Private Sub cdCalcDisplay_KeyUp(sender As Object, e As KeyEventArgs) Handles cdCalcDisplay.KeyUp
        Try
            If DirectCast(cboNumSystemSelect.SelectedItem, String) = p_DECIMAL AndAlso cdCalcDisplay.Screen.Text.Length > 2 Then
                If Not cdCalcDisplay.Screen.Text.Contains(".") Then
                    cdCalcDisplay.Screen.Text = String.Format("{0:#,#.#############################}", Convert.ToDecimal(cdCalcDisplay.Screen.Text, System.Globalization.CultureInfo.InvariantCulture))
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("There seems to have been an issue. " & ex.Message, "Error: 10004", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cdCalcDisplay.Clear()
        End Try
    End Sub
    ''' <summary>
    ''' This sub handles whether clicking an operator changes the sActiveOperator variable based off of the state of the calculator
    ''' </summary>
    ''' <param name="sender">The sender of the event</param>
    ''' <param name="e">The event arguments</param>
    Private Sub btnNumPadOperators_Click(sender As Object, e As EventArgs) Handles btnNumPadPlus.Click, btnNumPadMultiply.Click,
         btnNumPadMinus.Click, btnNumPadDivide.Click
        Try
            'Either adds a - if the - button is clicked and the screen is empty or notifies the user if the calculator is empty
            ' and any other operator is clicked.
            If cdCalcDisplay.Screen.Text = String.Empty Then
                If DirectCast(sender, Control).Text = "-" AndAlso cdCalcDisplay.Screen.Text = String.Empty Then
                    cdCalcDisplay.Screen.Text = "-"
                Else
                    MessageBox.Show("Please enter valid input before attempting to perform an operation", "Error: 10001", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
                'If the screen is not blank it checks to see if there are any number on the screen or if it's just . and or -
            ElseIf cboNumSystemSelect.Text = p_DECIMAL AndAlso cdCalcDisplay.Screen.Text.Length > 3 OrElse Char.IsDigit(cdCalcDisplay.Screen.Text, 0) _
              OrElse Char.IsDigit(cdCalcDisplay.Screen.Text, cdCalcDisplay.Screen.Text.Length - 1) Then
                p_sActiveOperator = DirectCast(sender, Control).Text
                cdCalcDisplay.Value = cdCalcDisplay.Screen.Text & " " & p_sActiveOperator
                p_sFirstValue = cdCalcDisplay.Screen.Text
                cdCalcDisplay.Screen.Text = String.Empty
            ElseIf cboNumSystemSelect.Text <> p_DECIMAL Then
                p_sActiveOperator = DirectCast(sender, Control).Text
                cdCalcDisplay.Value = cdCalcDisplay.Screen.Text & " " & p_sActiveOperator
                p_sFirstValue = cdCalcDisplay.Screen.Text
                cdCalcDisplay.Screen.Text = String.Empty
            End If
        Catch ex As Exception
            MessageBox.Show("There seems to have been an issue. " & ex.Message, "Error: 10004", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    ''' <summary>
    ''' This sub Clears the current calculator data when the clear button is clicked
    ''' </summary>
    ''' <param name="sender">The sender of the event</param>
    ''' <param name="e">The event arguments</param>
    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        Try
            cdCalcDisplay.Clear()
        Catch ex As Exception
            MessageBox.Show("There seems to have been an issue. " & ex.Message, "Error: 10004", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    ''' <summary>
    ''' This sub handles adding a decimal if appropriate for the current value of the number and the numbering system
    ''' </summary>
    ''' <param name="sender">The sender of the event</param>
    ''' <param name="e">The event arguments</param>
    Private Sub btnDecimal_Click(sender As Object, e As EventArgs) Handles btnDecimal.Click
        Try
            If DirectCast(cboNumSystemSelect.SelectedItem, String) = p_DECIMAL Then
                If Not cdCalcDisplay.Screen.Text.Contains(".") Then
                    cdCalcDisplay.Screen.Text += "."
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("There seems to have been an issue. " & ex.Message, "Error: 10004", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
End Class
