
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
        Console.WriteLine("Magic days since 1980 are:")
        For Each result In results
            Console.Write(result.ToString("d/M/y "))
        Next
        Console.WriteLine("A total of " & results.Count)
        Console.WriteLine("Press a key")
        Console.ReadKey()

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
        Console.WriteLine("Super-magic days since 1980 are:")
        For Each result In results
            Console.Write(result.DayOfWeek.ToString & " " & result.ToString("d/M/y") & " ")
        Next
        Console.WriteLine()
        Console.WriteLine("A total of " & results.Count)
        Console.WriteLine("Press a key")
        Console.ReadKey()

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
        Console.WriteLine("Supa-dupa-magic days since 1980 are:")
        For Each result In results
            Console.Write(result.DayOfWeek.ToString & " " & result.ToString("d/M/y") & " ")
        Next
        Console.WriteLine()
        Console.WriteLine("A total of " & results.Count)
        Console.WriteLine("Press a key")
        Console.ReadKey()

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
        Console.WriteLine("Ultimate magic days are:")
        For Each result In results
            Console.Write(result.DayOfWeek.ToString & " " & result.ToString("d/M/y") & " ")
        Next
        Console.WriteLine()
        Console.WriteLine("A total of " & results.Count)
        Console.WriteLine("Press a key")
        Console.ReadKey()

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
        Console.WriteLine("Almost ultimate magic days are:")
        For Each result In results
            Console.Write(result.DayOfWeek.ToString & " " & result.ToString("d/M/yyyy") & " ")
        Next
        Console.WriteLine()
        Console.WriteLine("A total of " & results.Count)
        Console.WriteLine("Press a key")
        Console.ReadKey()

    End Sub

End Module
