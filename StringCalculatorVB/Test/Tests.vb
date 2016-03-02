
Imports NUnit.Framework
Imports StringCalculatorVB

Public Class Tests

    <TestCase(2, "1,1")>
    <TestCase(3, "1,2")>
    <TestCase(0, "")>
    <TestCase(10, "0,1,2,3,4")>
    <TestCase(2, "1\n1")>
    <TestCase(5, "//Jim\n2Jim3")>
    <TestCase(1, "1001, 1")>
    <TestCase(2, "1002, 2")>
    <TestCase(2, "1765, 2")>
    Sub TestOnePlusOne(expectedResult As Integer, stringToSolve As String)
        Assert.AreEqual(expectedResult, StringCalculator.Calculate(stringToSolve))
        End Sub

    <Test()>
    Sub OneNegative()
        Assert.Throws(Of Exception)(Function()StringCalculator.Calculate("-1"), "Negatives not Allowed: -1")
    End Sub

    <Test()>
    Sub MultipleNegatives()
        Assert.Throws(Of Exception)(Function()StringCalculator.Calculate("-1, -2, -3"), "Negatives not Allowed: -1, -2, -3")
    End Sub

    <Test()>
    Sub MultipleNegatives2()
        Assert.Throws(Of Exception)(Function()StringCalculator.Calculate("1, -2, -3"), "Negatives not Allowed: -2, -3")
    End Sub
End Class
