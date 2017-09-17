' Copyright (c) 2017 Applied Systems, Inc.
'
''' -----------------------------------------------------------------------------
''' Project	 : Calculator
''' Class	 : ButtonExtended
''' -----------------------------------------------------------------------------
''' <summary>
'''   The class behind the ButtonExtended control including a color change in the Constructor
'''   and override for the ResetForeColor method
''' </summary>
''' <remarks>
''' </remarks>
''' <history>
''' 	[Marcus]	2/20/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class ButtonExtended
  Inherits Button
  ''' <summary>
  ''' This Sub overrides the Button constructor and changes the forecolor
  ''' </summary>
  Sub New()
    MyBase.New()
    ForeColor = Color.Navy
  End Sub
  ''' <summary>
  ''' This Sub overrides the ResetForeColor sub and changes the forecolor to reset to Navy
  ''' </summary>
  Public Overrides Sub ResetForeColor()
    Me.ForeColor = Color.Navy
  End Sub


End Class
