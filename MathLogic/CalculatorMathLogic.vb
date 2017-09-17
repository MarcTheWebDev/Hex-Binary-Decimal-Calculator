' Copyright (c) 2017 Applied Systems, Inc.
'

''' -----------------------------------------------------------------------------
''' Project	 : MathLogic
''' Class	 : CalculatorMathLogic
''' -----------------------------------------------------------------------------
''' <summary>
'''   Holds the Math Logic for the calculator. This includes basic functions like addition and subtraction
'''   but it also handles converting from a given base to decimal (base 10) and vice versa
''' </summary>
''' <remarks>
''' </remarks>
''' <history>
''' 	[Marcus]	2/20/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class CalculatorMathLogic
  Private Enum Base31Value ' an enumeration to map the alpha characters of the Base31 system to the appropriate numeric values
    B = 10
    C
    D
    F
    G
    H
    J
    K
    L
    M
    N
    P
    Q
    R
    S
    T
    V
    W
    X
    Y
    Z
  End Enum

  Private Enum BaseHexadecimalValue ' an enumeration to map the alpha characters of the Base31 system to the appropriate numeric values
    A = 10
    B
    C
    D
    E
    F
  End Enum
  ''' <summary>
  ''' This function adds two numbers and returns the result
  ''' </summary>
  ''' <param name="decNum1">The first number to add</param>
  ''' <param name="decNum2">The second number to add</param>
  ''' <returns>decNum1 + decNum2</returns>
  Public Function Addition(decNum1 As Decimal, decNum2 As Decimal) As Decimal
    Return decNum1 + decNum2
  End Function
  ''' <summary>
  ''' This function subtracts two numbers and returns the result
  ''' </summary>
  ''' <param name="decNum1">The number to be subtracted from</param>
  ''' <param name="decNum2">The number to subtract</param>
  ''' <returns>decNum1 - decNum2</returns>
  Public Function Subtraction(decNum1 As Decimal, decNum2 As Decimal) As Decimal
    Return decNum1 - decNum2
  End Function
  ''' <summary>
  ''' This function divides two numbers and returns the result
  ''' </summary>
  ''' <param name="decNum1">The number to be divided</param>
  ''' <param name="decNum2">The number to be divided by</param>
  ''' <returns>decNum1 / decNum2</returns>
  Public Function Division(decNum1 As Decimal, decNum2 As Decimal) As Decimal
    Return decNum1 / decNum2
  End Function
  ''' <summary>
  ''' This function multiplies two numbers and returns the result
  ''' </summary>
  ''' <param name="decNum1">The first number to be multiply</param>
  ''' <param name="decNum2">The second number to be multiply</param>
  ''' <returns>decNum1 * decNum2</returns>
  Public Function Multiplication(decNum1 As Decimal, decNum2 As Decimal) As Decimal
    Return decNum1 * decNum2
  End Function
  ''' <summary>
  ''' This function converts a number in a base other than 10 to decimal (base 10)
  ''' </summary>
  ''' <param name="sNumToConvert">The number to be converted to Decimal in string form</param>
  ''' <param name="iBase">The current base system the first number is in</param>
  ''' <returns>The first number as a decimal (base 10)</returns>
  Public Function ConvertToDecimal(sNumToConvert As String, iBase As Integer) As Decimal

    Dim decResult As Decimal = 0
    Dim dCharAsNumber As Double = 0
    Dim fDecWasLessThan0 As Boolean = False ' Notes if the passed decimal was negative

    If sNumToConvert(0) = "-" Then
      fDecWasLessThan0 = True
      sNumToConvert = sNumToConvert.Substring(1)
    End If

    sNumToConvert = sNumToConvert.ToUpper()
    For index = 0 To sNumToConvert.Length - 1
      If iBase = 31 OrElse iBase = 16 Then
        For counter = 0 To sNumToConvert.Length - 1
          If Char.IsDigit(sNumToConvert(index)) Then
            dCharAsNumber = Char.GetNumericValue(sNumToConvert(index))
          Else
            If iBase = 31 Then
              dCharAsNumber = [Enum].Parse(GetType(Base31Value), sNumToConvert(index))
            ElseIf iBase = 16 Then
              dCharAsNumber = [Enum].Parse(GetType(BaseHexadecimalValue), sNumToConvert(index))
            End If
          End If
        Next
      Else
        dCharAsNumber = Char.GetNumericValue(sNumToConvert(index))
      End If

      If index = sNumToConvert.Length - 1 Then
        decResult += dCharAsNumber
      Else
        decResult = (decResult + dCharAsNumber) * iBase
      End If
    Next

    If fDecWasLessThan0 Then
      decResult = decResult - (decResult * 2)
    End If

    Return decResult
  End Function
  ''' <summary>
  ''' This function converts a number from Decimal (base 10) to any other base 
  ''' </summary>
  ''' <param name="decNumToConvert">This is the number to be converted</param>
  ''' <param name="iBase">This is the base that you would like to convert to</param>
  ''' <returns>The number entered (base 10) converted to the specified base</returns>
  Public Function ConvertFromDecimal(decNumToConvert As Decimal, iBase As Integer) As String

    Dim decQuotent As Decimal = decNumToConvert
    Dim iRemainder As Integer = 0
    Dim sConvertedValue As String = String.Empty
    Dim fDecWasLessThan0 As Boolean = False ' Notes if the passed decimal was negative

    If decNumToConvert = 0 Then
      Return "0"
      ' If the number was 0 it takes not by changing fDecWasLessThan0 so the - can be added later, and then converts the number to positive 
    ElseIf decNumToConvert < 0 Then
      fDecWasLessThan0 = True
      decQuotent = Math.Abs(decQuotent)
    End If

    While Not decQuotent = 0
      iRemainder = decQuotent Mod iBase
      decQuotent = Math.Floor((decQuotent / iBase))

      If iRemainder > 9 Then
        If iBase = 31 Then
          sConvertedValue = sConvertedValue & [Enum].GetName(GetType(Base31Value), iRemainder)
        ElseIf iBase = 16 Then
          sConvertedValue = sConvertedValue & [Enum].GetName(GetType(BaseHexadecimalValue), iRemainder)
        End If
      Else
          sConvertedValue = sConvertedValue & iRemainder
      End If
    End While

    Dim acConvertedValue As Char() = sConvertedValue.ToCharArray()
    Array.Reverse(acConvertedValue)
    sConvertedValue = New String(acConvertedValue)
    ' If the number was negative to begin with the negative is added back
    If fDecWasLessThan0 Then
      sConvertedValue = "-" & sConvertedValue
    End If
    Return sConvertedValue
  End Function
End Class
