Public Class StringCalculator
    Shared Function Calculate(numbers As String) As Integer
        numbers = HandleDelimiter(numbers)

        Dim numberArray As String() = numbers.Split(",")
        Dim total as Integer
        Dim negativeNumbers As New List(Of String)
        For Each s As String In numberArray
             If s.Trim().StartsWith("-") Then
                negativeNumbers.Add(s)
            End If
            

            Dim result As Integer
            If Integer.TryParse(s, result) Then
                If result > 1000 Then result = "0"
                total = total + result
            End If
        Next
        
        If negativeNumbers.Any() Then Throw New Exception(GetNegativeNumberString(negativeNumbers))
        Return total
        
    End Function

    Private Shared Function HandleDelimiter(numbers As String) As String

        If numbers.StartsWith("//") Then 
            Dim delimiter = ","
            Dim delimiterEnd = numbers.IndexOf("\n")
            delimiter = numbers.Substring(2, numbers.Length - delimiterEnd - 4)
            numbers = numbers.Substring(delimiterEnd + 2)
            numbers = numbers.Replace(delimiter, ",")
        End If
        numbers = numbers.Replace("\n",",")
        Return numbers
    End Function

    Private Shared Function GetNegativeNumberString(negativeNumbers As List(Of String)) As String

        Dim negativeNumbersString As String = string.Empty
        For Each negativeNumber As String in negativeNumbers
            If negativeNumbersString.Length > 0 Then negativeNumbersString += ", "
            negativeNumbersString += negativeNumber
        Next
        Return String.Format("Negatives not Allowed: {0}", negativeNumbersString)
    End Function
End Class
