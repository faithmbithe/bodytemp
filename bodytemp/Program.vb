Imports System

Module Program
    Sub Main(args As String())
        Dim temp(6, 3) As Integer
        Dim i, j As Integer

        For i = LBound(temp, 1) To UBound(temp, 1)
            For j = LBound(temp, 2) To UBound(temp, 2)
                Console.WriteLine("Enter the body temperature reading for patient: " & (i + 1) & " in internal :" & (j + 1))
                temp(i, j) = CDbl(Console.ReadLine)

            Next
        Next
        'For i = LBound(temp, 1) To UBound(temp, 1)
        'For j = LBound(temp, 2) To UBound(temp, 2)
        ' Console.Write(temp(i, j) & vbTab)
        ' Next
        'Console.WriteLine()
        'Next
    End Sub
End Module
