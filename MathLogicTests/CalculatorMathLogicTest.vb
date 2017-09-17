Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports MathLogic
' Copyright (c) 2017 Applied Systems, Inc.
'
''' -----------------------------------------------------------------------------
''' Project	 : MathLogicTests
''' Class	 : CalculatorMathLogicTest
''' -----------------------------------------------------------------------------
''' <summary>
'''   Tests the Math Logic class containing all of the math / base conversion logic for the calculator project
''' </summary>
''' <remarks>
''' </remarks>
''' <history>
''' 	[Marcus]	2/20/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<TestClass()> Public Class CalculatorMathLogicTest
  Private oLogic As CalculatorMathLogic = New CalculatorMathLogic
#Region "Addition Tests"
  ''' <summary>
  ''' This test adds two large negative  numbers to test the Addition method
  ''' </summary>
  <TestMethod()> Public Sub AdditionLargeNegativeTest()
    'Arrange
    Dim expected As Decimal = -1234567890000
    'Act
    Dim actual As Decimal = oLogic.Addition(-1220000000000, -14567890000)
    'Assert
    Assert.AreEqual(expected, actual)
  End Sub
  ''' <summary>
  ''' This test adds two small negative numbers to test the Addition method
  ''' </summary>
  <TestMethod()> Public Sub AdditionSmallNegativeTest()
    'Arrange
    Dim expected As Decimal = -8
    'Act
    Dim actual As Decimal = oLogic.Addition(-5, -3)
    'Assert
    Assert.AreEqual(expected, actual)
  End Sub
  ''' <summary>
  ''' This test adds two large positive numbers to test the Addition method
  ''' </summary>
  <TestMethod()> Public Sub AdditionLargePositiveTest()
    'Arrange
    Dim expected As Decimal = 9999999999
    'Act
    Dim actual As Decimal = oLogic.Addition(1101111111, 8898888888)
    'Assert
    Assert.AreEqual(expected, actual)
  End Sub
  ''' <summary>
  ''' This test adds two small positive numbers to test the Addition method
  ''' </summary>
  <TestMethod()> Public Sub AdditionSmallPositiveTest()
    'Arrange
    Dim expected As Decimal = 59
    'Act
    Dim actual As Decimal = oLogic.Addition(45, 14)
    'Assert
    Assert.AreEqual(expected, actual)
  End Sub
  ''' <summary>
  ''' This test adds zeros to test the Addition method
  ''' </summary>
  <TestMethod()> Public Sub AdditionZeroTest()
    'Arrange
    Dim expected As Decimal = 0
    'Act
    Dim actual As Decimal = oLogic.Addition(0, 0)
    'Assert
    Assert.AreEqual(expected, actual)
  End Sub
#End Region

#Region "Subtraction Tests"
  ''' <summary>
  ''' This test subtracts two large negative numbers to test the subtraction method
  ''' </summary>
  <TestMethod()> Public Sub SubtractionLargeNegativeTest()
    'Arrange
    Dim expected As Decimal = -1205432110000
    'Act
    Dim actual As Decimal = oLogic.Subtraction(-1220000000000, -14567890000)
    'Assert
    Assert.AreEqual(expected, actual)
  End Sub
  ''' <summary>
  ''' This test subtracts two small negative numbers to test the subtraction method
  ''' </summary>
  <TestMethod()> Public Sub SubtractionSmallNegativeTest()
    'Arrange
    Dim expected As Decimal = 2
    'Act
    Dim actual As Decimal = oLogic.Subtraction(-5, -7)
    'Assert
    Assert.AreEqual(expected, actual)
  End Sub
  ''' <summary>
  ''' This test subtracts two large positive numbers to test the subtraction method
  ''' </summary>
  <TestMethod()> Public Sub SubtractionLargePositiveTest()
    'Arrange
    Dim expected As Decimal = -4497777222
    'Act
    Dim actual As Decimal = oLogic.Subtraction(2201111333, 6698888555)
    'Assert
    Assert.AreEqual(expected, actual)
  End Sub
  ''' <summary>
  ''' This test subtracts two small positive numbers to test the subtraction method
  ''' </summary>
  <TestMethod()> Public Sub SubtractionSmallPositiveTest()
    'Arrange
    Dim expected As Decimal = 31
    'Act
    Dim actual As Decimal = oLogic.Subtraction(75, 44)
    'Assert
    Assert.AreEqual(expected, actual)
  End Sub
  ''' <summary>
  ''' This test subtracts two zeros to test the subtraction method
  ''' </summary>
  <TestMethod()> Public Sub SubtractionZeroTest()
    'Arrange
    Dim expected As Decimal = 0
    'Act
    Dim actual As Decimal = oLogic.Subtraction(0, 0)
    'Assert
    Assert.AreEqual(expected, actual)
  End Sub
#End Region
  '' Start HERE tomorrow
#Region "Division Tests"
  ''' <summary>
  ''' This test divides two large negative numbers to test the division method
  ''' </summary>
  <TestMethod()> Public Sub DivisionLargeNegativeTest()
    'Arrange
    Dim expected As Decimal = 2
    'Act
    Dim actual As Decimal = oLogic.Division(-1456700, -728350)
    'Assert
    Assert.AreEqual(expected, actual)
  End Sub
  ''' <summary>
  ''' This test divides two small negative numbers to test the division method
  ''' </summary>
  <TestMethod()> Public Sub DivisionSmallNegativeTest()
    'Arrange
    Dim expected As Decimal = 1.4
    'Act
    Dim actual As Decimal = oLogic.Division(-7, -5)
    'Assert
    Assert.AreEqual(expected, actual)
  End Sub
  ''' <summary>
  ''' This test divides two large positive numbers to test the division method
  ''' </summary>
  <TestMethod()> Public Sub DivisionLargePositiveTest()
    'Arrange
    Dim expected As Decimal = 500
    'Act
    Dim actual As Decimal = oLogic.Division(2201111330, 4402222.66)
    'Assert
    Assert.AreEqual(expected, actual)
  End Sub
  ''' <summary>
  ''' This test divides two small positive numbers to test the division method
  ''' </summary>
  <TestMethod()> Public Sub DivisionSmallPositiveTest()
    'Arrange
    Dim expected As Decimal = 15
    'Act
    Dim actual As Decimal = oLogic.Division(75, 5)
    'Assert
    Assert.AreEqual(expected, actual)
  End Sub
#End Region

#Region "Multiplication Tests"
  ''' <summary>
  ''' This test multiplies two large negative numbers to test the Multiplication method
  ''' </summary>
  <TestMethod()> Public Sub MultiplicationLargeNegativeTest()
    'Arrange
    Dim expected As Decimal = 1060987445000
    'Act
    Dim actual As Decimal = oLogic.Multiplication(-1456700, -728350)
    'Assert
    Assert.AreEqual(expected, actual)
  End Sub
  ''' <summary>
  ''' This test multiplies two small negative numbers to test the Multiplication method
  ''' </summary>
  <TestMethod()> Public Sub MultiplicationSmallNegativeTest()
    'Arrange
    Dim expected As Decimal = 35
    'Act
    Dim actual As Decimal = oLogic.Multiplication(-7, -5)
    'Assert
    Assert.AreEqual(expected, actual)
  End Sub
  ''' <summary>
  ''' This test multiplies two large positive numbers to test the Multiplication method
  ''' </summary>
  <TestMethod()> Public Sub MultiplicationLargePositiveTest()
    'Arrange
    Dim expected As Decimal = 660333399000000
    'Act
    Dim actual As Decimal = oLogic.Multiplication(2201111330, 300000)
    'Assert
    Assert.AreEqual(expected, actual)
  End Sub
  ''' <summary>
  ''' This test multiplies two small positive numbers to test the Multiplication method
  ''' </summary>
  <TestMethod()> Public Sub MultiplicationSmallPositiveTest()
    'Arrange
    Dim expected As Decimal = 375
    'Act
    Dim actual As Decimal = oLogic.Multiplication(75, 5)
    'Assert
    Assert.AreEqual(expected, actual)
  End Sub
#End Region
  ''' <summary>
  ''' This tests the ConverToDecimal method's ability to convert binary to decimal values by passing a 
  ''' list of varying values
  ''' </summary>
  <TestMethod()> Public Sub ConvertingBinaryToDecimalTest()
    'Arrange
    Dim lstListToConvert As New List(Of String)({"111100111100000000111111111011110100110",
                                              "01100011", "11", "0"})
    Dim lstExpected As New List(Of Decimal) From {523451234214, 99, 3, 0}
    Dim lstActual As List(Of Decimal) = New List(Of Decimal)
    'Act
    For index = 0 To lstListToConvert.Count - 1
      lstActual.Add(oLogic.ConvertToDecimal(lstListToConvert(index), 2))
    Next
    'Assert
    CollectionAssert.AreEqual(lstExpected, lstActual)
  End Sub
  ''' <summary>
  ''' This tests the ConverToDecimal method's ability to convert binary to Octal values by passing a 
  ''' list of varying values
  ''' </summary>
  <TestMethod()> Public Sub ConvertingOctalToDecimalTest()
    'Arrange
    Dim lstListToConvert As New List(Of String)({"7474007773646", "726746425", "143", "3", "0"})
    Dim lstExpected As New List(Of Decimal) From {523451234214, 123456789, 99, 3, 0}
    Dim lstActual As List(Of Decimal) = New List(Of Decimal)
    'Act
    For index = 0 To lstListToConvert.Count - 1
      lstActual.Add(oLogic.ConvertToDecimal(lstListToConvert(index), 8))
    Next
    'Assert
    CollectionAssert.AreEqual(lstExpected, lstActual)
  End Sub
  ''' <summary>
  ''' This tests the ConverToDecimal method's ability to convert binary to Base31 values by passing a 
  ''' list of varying values
  ''' </summary>
  <TestMethod()> Public Sub ConvertingBase31ToDecimalTest()
    'Arrange
    Dim lstListToConvert As New List(Of String)({"ZZZZZZZZZ", "BCDFGHJ", "36", "3", "0"})
    Dim lstExpected As New List(Of Decimal) From {26439622160670, 9201440941, 99, 3, 0}
    Dim lstActual As List(Of Decimal) = New List(Of Decimal)
    'Act
    For index = 0 To lstListToConvert.Count - 1
      lstActual.Add(oLogic.ConvertToDecimal(lstListToConvert(index), 31))
    Next
    'Assert
    CollectionAssert.AreEqual(lstExpected, lstActual)
  End Sub
  ''' <summary>
  ''' This tests the ConvertFromDecimal method's ability to convert decimal to binary values by passing a 
  ''' list of varying values
  ''' </summary>
  <TestMethod()> Public Sub ConvertingBinaryFromDecimalTest()
    'Arrange
    Dim lstListToConvert As New List(Of Decimal) From {523451234214, 99, 3, 0}
    Dim lstExpected As New List(Of String)({"111100111100000000111111111011110100110",
                                              "1100011", "11", "0"})
    Dim lstActual As List(Of String) = New List(Of String)
    'Act
    For index = 0 To lstListToConvert.Count - 1
      lstActual.Add(oLogic.ConvertFromDecimal(lstListToConvert(index), 2))
    Next
    'Assert
    CollectionAssert.AreEqual(lstExpected, lstActual)
  End Sub
  ''' <summary>
  ''' This tests the ConvertFromDecimal method's ability to convert decimal to Octal values by passing a 
  ''' list of varying values
  ''' </summary>
  <TestMethod()> Public Sub ConvertingOctalFromDecimalTest()
    'Arrange
    Dim lstListToConvert As New List(Of Decimal) From {523451234214, 123456789, 99, 3, 0, -56324131}
    Dim lstExpected As New List(Of String)({"7474007773646", "726746425", "143", "3", "0", "-326670043"})
    Dim lstActual As List(Of String) = New List(Of String)
    'Act
    For index = 0 To lstListToConvert.Count - 1
      lstActual.Add(oLogic.ConvertFromDecimal(lstListToConvert(index), 8))
    Next
    'Assert
    CollectionAssert.AreEqual(lstExpected, lstActual)
  End Sub
  ''' <summary>
  ''' This tests the ConvertFromDecimal method's ability to convert decimal to Base31 values by passing a 
  ''' list of varying values
  ''' </summary>
  <TestMethod()> Public Sub ConvertingBase31FromDecimalTest()
    'Arrange
    Dim lstListToConvert As New List(Of Decimal) From {26439622160670, 9201440941, 99, 3, 0, -313232}
    Dim lstExpected As New List(Of String)({"ZZZZZZZZZ", "BCDFGHJ", "36", "3", "0", "-BHY8"})
    Dim lstActual As List(Of String) = New List(Of String)
    'Act
    For index = 0 To lstListToConvert.Count - 1
      lstActual.Add(oLogic.ConvertFromDecimal(lstListToConvert(index), 31))
    Next
    'Assert
    CollectionAssert.AreEqual(lstExpected, lstActual)
  End Sub
End Class