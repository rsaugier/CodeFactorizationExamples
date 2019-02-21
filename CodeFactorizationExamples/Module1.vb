
Module Module1

    Sub Main()
        Dim results As New List(Of DateTime)
        For Each y In Enumerable.Range(1980, 40)
            For Each m In Enumerable.Range(1, 12)
                For Each d In Enumerable.Range(1, DateTime.DaysInMonth(y, m))
                    Dim day As New DateTime(y, m, d, 0, 0, 0)
                    If m = d Then
                        results.Add(day)
                    End If
                Next
            Next
        Next

        DisplayResults("Magic days since 1980 are:", results, DisplayMode.Simple)

        results.Clear()
        For Each y In Enumerable.Range(1980, 40)
            For Each m In Enumerable.Range(1, 12)
                For Each d In Enumerable.Range(1, DateTime.DaysInMonth(y, m))
                    Dim day As New DateTime(y, m, d, 0, 0, 0)
                    If m = d AndAlso day.DayOfWeek = d Then
                        results.Add(day)
                    End If
                Next
            Next
        Next

        DisplayResults("Super-magic days since 1980 are:", results, DisplayMode.WithDayOfWeek)

        results.Clear()
        For Each y In Enumerable.Range(1980, 40)
            For Each m In Enumerable.Range(1, 12)
                For Each d In Enumerable.Range(1, DateTime.DaysInMonth(y, m))
                    Dim day As New DateTime(y, m, d, 0, 0, 0)
                    If m = d AndAlso day.DayOfWeek = d AndAlso (y Mod 10) = d Then
                        results.Add(day)
                    End If
                Next
            Next
        Next

        DisplayResults("Supa-dupa-magic days since 1980 are:", results, DisplayMode.WithDayOfWeek)

        results.Clear()
        For Each y In Enumerable.Range(1, 9999)
            For Each m In Enumerable.Range(1, 12)
                For Each d In Enumerable.Range(1, DateTime.DaysInMonth(y, m))
                    If m = d AndAlso y = d Then
                        results.Add(New DateTime(y, m, d, 0, 0, 0))
                    End If
                Next
            Next
        Next

        DisplayResults("Ultimate magic days are:", results, DisplayMode.Simple)

        results.Clear()
        For Each y In Enumerable.Range(1, 9999)
            For Each m In Enumerable.Range(1, 12)
                For Each d In Enumerable.Range(1, DateTime.DaysInMonth(y, m))
                    Dim day As New DateTime(y, m, d, 0, 0, 0)
                    If m = d AndAlso (y Mod 100) = d AndAlso d = day.DayOfWeek Then
                        results.Add(day)
                    End If
                Next
            Next
        Next

        DisplayResults("Almost ultimate magic days are:", results, DisplayMode.WithDayOfWeek)

    End Sub

    Public Enum DisplayMode
        Simple
        WithDayOfWeek
    End Enum

    Private Sub DisplayResults(message As String, results As List(Of Date), display As DisplayMode)
        Console.WriteLine(message)
        For Each result In results
            Dim text As String
            If display = DisplayMode.WithDayOfWeek Then
                text = result.DayOfWeek.ToString & " " & result.ToString("d/M/yyyy ")
            Else
                text = result.ToString("d/M/yyyy ")
            End If
            Console.Write(text)
        Next
        Console.WriteLine("A total of " & results.Count)
        Console.WriteLine("Press a key")
        Console.ReadKey()
    End Sub
End Module
