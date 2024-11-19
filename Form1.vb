Imports System.Threading

Public Class Form1

    Dim cts As CancellationTokenSource

    Private Sub Syop_Click(sender As Object, e As EventArgs) Handles Button_stop.Click
        cts.Cancel()
    End Sub





    Private Async Sub Start_Click2(sender As Object, e As EventArgs) Handles start.Click


        Dim test_async = Async Sub() Await Task.Delay(10000)

        Dim p = PrintAsync()

        Console.WriteLine("Конец")

        Await p



    End Sub


    Async Function PrintAsync() As Task

        Console.WriteLine("Начало PrintAsync")
        Await Task.Run(Sub()
                           Thread.Sleep(10000)
                       End Sub
            )
        Console.WriteLine("Конец PrintAsync")

    End Function


    Private Async Sub Start_Click(sender As Object, e As EventArgs)

        cts = New CancellationTokenSource()
        Dim token = cts.Token

        Dim t As Task(Of Boolean) = Task.Run(Function() As Boolean
                                                 Return test1(token)
                                             End Function)

        Console.WriteLine(" код 1!")

        'cts.Cancel()
        cts.CancelAfter(3000)

        Try
            If Await t Then
                Console.WriteLine("t вернуло")
            End If

            Console.WriteLine(" код 2!")

        Catch ex As OperationCanceledException
            Console.WriteLine(" Прервал асинхронный поток!!!!")

        End Try

        Console.WriteLine("А здесь продолжение кода")
    End Sub


    Function test1(Token As CancellationToken) As Boolean

        For i = 0 To 10

            'If Token.IsCancellationRequested Then
            '    Token.ThrowIfCancellationRequested()
            'End If

            Thread.Sleep(1000)
            Console.WriteLine(i)

        Next

        Return True

    End Function

End Class
