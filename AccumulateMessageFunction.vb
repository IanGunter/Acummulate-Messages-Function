'Ian Gunter
'RCET 0265
'AccumulateMessageFunction
'Fall 2020
'https://github.com/IanGunter/Acummulate-Messages-Function.git
'Solution name should be PascalCase - TJR
'Remove extra blank lines - TJR

Option Strict On
Option Explicit On
Option Compare Text

'Remove extra blank lines - TJR


Module AccumulateMessageFunction

    Sub Main()
        Dim userInput As String
        Dim message As String
        Dim clear As Boolean

        Console.WriteLine("Type a phrase you want to save." & vbNewLine & "Type Call to see all saved phrases." & vbNewLine & "Type Clear to delete saved phrases.")

        Do
            userInput = Console.ReadLine()
            If userInput = "Call" Then
                'MsgBox pulls up a message box window with the users saved input presented.
                MsgBox(message)
            ElseIf userInput = "Clear" Then
                clear = True
            End If

            message = AccumulateMessage(userinput, Clear)


            clear = False
        Loop


        'Remove extra blank lines - TJR

    End Sub

    'Function Accumulate Message takes input from the user and stores it. When new input is produced by the user, the function adds the new input to a new line.
    Function AccumulateMessage(ByVal newMessage As String, ByVal clear As Boolean) As String
        Static userMessage As String

        'Clear used to delete all saved phrases.
        If clear = True Then
            userMessage = ""
        ElseIf newMessage = "call" Then
        Else
            userMessage &= newMessage & vbNewLine ' how would you prevent empty strings from adding a new line?? - TJR
        End If

        Return userMessage

    End Function

End Module
