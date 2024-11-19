Imports System.Threading
Imports Helper_excel_nano.Nano
Imports Helper_excel_nano.Excel
Imports Helper_excel_nano.Common

Module Module1

    Sub Main()
        test_nano()
    End Sub



    Sub test_nano()
        Dim app_cad As nanoCAD.Application = New nanoCAD.Application
        Dim this_drawing As nanoCAD.Document = app_cad.ActiveDocument
        Dim ss As nanoCAD.SelectionSet = Selection_Sets_add(this_drawing, "LINE")

        Dim line1 As OdaX.AcadLine = ss(0)
        Dim line2 As OdaX.AcadLine = ss(1)

        Dim point As Double() = line1.IntersectWith(line2, 1)

    End Sub

    ' точка пересечения с погрешностью
    Function IntersectWith_error()

    End Function









    Sub test_async()

        If test_async2.Wait(6000) Then
            Console.WriteLine("pass if")
        End If
        Console.WriteLine("end")
        Console.ReadLine()
    End Sub
    Async Function test_async2() As Task(Of Boolean)
        For i = 1 To 5
            Await Task.Delay(1000)
            Console.WriteLine(i)
        Next
        Return True
    End Function


End Module
