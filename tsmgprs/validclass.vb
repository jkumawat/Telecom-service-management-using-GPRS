
Imports System.Text.RegularExpressions
Public Class validclass
    Function alphaCheck(ByVal num As String) As Boolean
        If num.Length = 0 Then
            alphaCheck = False
        Else
            Dim mypattern As String = "^[a-zA-Z]+$"
            Dim numMatch As Match = Regex.Match(num, mypattern)
            If numMatch.Success Then
                alphaCheck = True
            Else
                alphaCheck = False
            End If
        End If

    End Function

    Function numCheck(ByVal num As String) As Boolean
        If num.Length = 0 Then
            numCheck = False
        Else
            Dim mypattern As String = "^[0-9]+$"
            Dim numMatch As Match = Regex.Match(num, mypattern)
            If numMatch.Success Then
                numCheck = True
            Else
                numCheck = False
            End If
        End If
    End Function

    Function alphaCheck2(ByVal num As String) As Boolean
        If num.Length = 0 Then
            alphaCheck2 = False
        Else
            Dim mypattern As String = "^[a-zA-Z]+$"
            Dim numMatch As Match = Regex.Match(num, mypattern)
            Dim mypattern2 As String = "^[a-zA-Z]+\s[a-zA-Z]+$"
            Dim numMatch2 As Match = Regex.Match(num, mypattern2)
            Dim mypattern3 As String = "^[a-zA-Z]+\s[a-zA-Z]+\s[a-zA-Z]+$"
            Dim numMatch3 As Match = Regex.Match(num, mypattern3)
            If numMatch.Success Or numMatch2.Success Or numMatch3.Success Then
                alphaCheck2 = True
            Else
                alphaCheck2 = False
            End If
        End If
    End Function
    Function emailcheck(ByVal num As String) As Boolean

        Dim mypattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim numMatch As Match = Regex.Match(num, mypattern)
        If numMatch.Success Then
            emailcheck = True
        Else
            emailcheck = False
        End If

    End Function

    Function spacecheck(ByVal num As String) As Boolean

        Dim mypattern As String = "%[/s]+$"
        Dim numMatch As Match = Regex.Match(num, mypattern)
        If numMatch.Success Then
            spacecheck = True
        Else
            spacecheck = False
        End If
    End Function
    Function alphanumCheck(ByVal num As String) As Boolean
        If num.Length = 0 Then
            alphanumCheck = False
        Else
            Dim mypattern As String = "^[a-zA-Z0-9]+$"
            Dim numMatch As Match = Regex.Match(num, mypattern)
            If numMatch.Success Then
                alphanumCheck = True
            Else
                alphanumCheck = False
            End If
        End If
    End Function
End Class
