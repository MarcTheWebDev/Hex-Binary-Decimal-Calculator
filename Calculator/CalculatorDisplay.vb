' Copyright (c) 2017 Applied Systems, Inc.
'
''' -----------------------------------------------------------------------------
''' Project	 : Calculator
''' Class	 : CalculatorDisplay
''' -----------------------------------------------------------------------------
''' <summary>
'''   The class behind the Calculator Display composite control including
'''   methods to clear the display
''' </summary>
''' <remarks>
''' </remarks>
''' <history>
''' 	[Marcus]	2/20/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class CalculatorDisplay
  ''Exposing the label text that shows past input
  Public Property Value() As String
    Get
      Return lblCurrentValues.Text
    End Get
    Set(ByVal value As String)
      lblCurrentValues.Text = value
    End Set
  End Property
  ''Exposing the label text that shows the numbering system
  Public Property NumberSystem() As String
    Get
      Return lblNumberSystem.Text
    End Get
    Set(ByVal value As String)
      lblNumberSystem.Text = value
    End Set
  End Property
  '' Exposing the display text box to be changed
  Public Property Screen() As TextBox
    Get
      Return txtNumberDisplay
    End Get
    Set(ByVal value As TextBox)
      txtNumberDisplay = value
    End Set
  End Property
  ''' <summary>
  ''' This sub clears the data contained in the CalculatorDisplay composite control.
  ''' </summary>
  Public Sub Clear()
    txtNumberDisplay.Text = ""
    Value = ""
    txtNumberDisplay.Font = New Font("Microsoft Sans Serif", 38)
  End Sub
  ''' <summary>
  ''' This method changes the text size in accordance with the amount of characters on screen according
  ''' to how many characters are on screen
  ''' </summary>
  ''' <param name="sender"></param>
  ''' <param name="e"></param>
  Private Sub txtNumberDisplay_TextChanged(sender As Object, e As EventArgs) Handles txtNumberDisplay.TextChanged

    txtNumberDisplay.WordWrap = False

    If txtNumberDisplay.Text.Length > 30 Then
      txtNumberDisplay.Font = New Font("Microsoft Sans Serif", 11)
    ElseIf txtNumberDisplay.Text.Length > 21 AndAlso txtNumberDisplay.Text.Length < 30 Then
      txtNumberDisplay.Font = New Font("Microsoft Sans Serif", 13)
    ElseIf txtNumberDisplay.Text.Length > 18 AndAlso txtNumberDisplay.Text.Length < 21 Then
      txtNumberDisplay.Font = New Font("Microsoft Sans Serif", 15)
    ElseIf txtNumberDisplay.Text.Length > 10 AndAlso txtNumberDisplay.Text.Length < 18 Then
      txtNumberDisplay.Font = New Font("Microsoft Sans Serif", 22)
    End If
  End Sub
  ''' <summary>
  ''' This method just exposes the txtNumberDisplay.KeyDown method for outside use
  ''' </summary>
  ''' <param name="sender"></param>
  ''' <param name="e"></param>
  Private Sub txtNumberDisplay_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNumberDisplay.KeyDown
    Me.OnKeyDown(e)
  End Sub
  ''' <summary>
  ''' This method just exposes the txtNumberDisplay.KeyPress method for outside use
  ''' </summary>
  ''' <param name="sender"></param>
  ''' <param name="e"></param>
  Private Sub txtNumberDisplay_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumberDisplay.KeyPress
    Me.OnKeyPress(e)
  End Sub
  ''' <summary>
  ''' This method just exposes the txtNumberDisplay.KeyUp method for outside use
  ''' </summary>
  ''' <param name="sender"></param>
  ''' <param name="e"></param>
  Private Sub txtNumberDisplay_KeyUp(sender As Object, e As KeyEventArgs) Handles txtNumberDisplay.KeyUp
    Me.OnKeyUp(e)
    txtNumberDisplay.SelectionStart = txtNumberDisplay.Text.Length
  End Sub
End Class
