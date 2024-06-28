Imports System.Threading

Public Class Form1

    Dim cts As CancellationTokenSource

    Private Sub Syop_Click(sender As Object, e As EventArgs) Handles Button_stop.Click
        cts.Cancel()
    End Sub


    Private Async Sub Start_Click(sender As Object, e As EventArgs) Handles start.Click

        cts = New CancellationTokenSource()
        Dim token = cts.Token

        Dim t As Task(Of Boolean) = Task.Run(Function() As Boolean
                                                 Return test1()
                                                 If token.IsCancellationRequested Then
                                                     token.ThrowIfCancellationRequested()
                                                 End If
                                             End Function, token)
        Console.WriteLine(" код 1!")


        'cts.Cancel()
        'cts.CancelAfter(1000)

        Try


            If Await t Then
                Console.WriteLine("t вернуло")
                cts.Cancel()
            End If

            Console.WriteLine(" код 2!")

        Catch ex As OperationCanceledException
            Console.WriteLine(" Прервал асинхронный поток!!!!")

        End Try

        Console.WriteLine("А здесь продолжение кода")
    End Sub


    Function test1() As Boolean

        For i = 0 To 5000000000
            'Console.WriteLine(i & " - Асинхронный поток")

            'If i = 5 Then
            '    cts.Cancel()
            'End If

            'Await Task.Delay(1000, ct)
        Next


        Return True

    End Function




End Class
