'Ian Gunter
'RCET 0265
'AccumulateMessageFunction
'Fall 2020
'



Option Strict On
Option Explicit On
Option Compare Text




Module AccumulateMessageFunction

    Sub Main()
        Dim userinput As String
        Dim callallInput As String
        Dim Clear As Boolean

        Console.WriteLine("Type a phrase you want to save.")

        Do
            userinput = Console.ReadLine()
            If userinput = "Call" Then
                MsgBox(callallInput)
            ElseIf userinput = "Clear" Then
                Clear = True
            End If

            callallInput = AccumulateMessage(userinput, Clear)


            Clear = False
        Loop




    End Sub


    Function AccumulateMessage(ByVal newMessage As String, ByVal clear As Boolean) As String
        Static userMessage As String

        If clear = True Then
            userMessage = ""
        ElseIf newMessage = "call" Then
        Else
            userMessage &= newMessage & vbNewLine
        End If

        Return userMessage

    End Function

End Module
