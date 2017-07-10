Imports System.IO

Module Module1

    Sub Main()
        Dim FilePath = "D:/www.csv"
        Dim isExist As Boolean = IO.File.Exists(FilePath)
        If isExist Then
            Dim sr As StreamReader = New StreamReader(FilePath)
            Dim countLine As Integer = 2
            Dim headStr As String = sr.ReadLine()
            Dim line As String
            Dim sw As StreamWriter = New StreamWriter("D:/newcsv/TestFile.txt", True)
            sw.WriteLine(headStr)
            Do
                line = sr.ReadLine()
                If countLine Mod 5 = 0 Then
                    sw.Close()
                    sw = New StreamWriter("D:/newcsv/TestFile " & countLine & ".txt", True)
                    sw.WriteLine(headStr)
                    sw.WriteLine(line)
                Else
                    sw.WriteLine(line)
                End If
                countLine += 1
            Loop Until line Is Nothing
            sr.Close()
        End If
    End Sub

End Module
