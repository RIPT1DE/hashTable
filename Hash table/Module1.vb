Module Module1
    Class myHashTable
        Structure dataRecord
            Dim data As String
            Dim id As Integer
        End Structure


        Dim table(20) As dataRecord

        Function genHash(ByVal i As Integer)
            Return i Mod 21
        End Function

        Function insert(ByVal r As dataRecord)
            Dim insertionIndex = genHash(r.id)
            Dim repeated As Boolean = False
            Do Until table(insertionIndex).id = 0
                If insertionIndex = table.Length - 1 Then
                    If repeated = True Then
                        Return False
                    End If
                    insertionIndex = 0
                    repeated = True
                Else
                    insertionIndex += 1
                End If
            Loop
            table(insertionIndex) = r
            Return True
        End Function

        Function search(ByVal id As Integer)
            Dim index = id
            Dim repeated = False
            Do Until table(index).id = id
                If index = table.Length - 1 Then
                    If repeated = True Then
                        Return False
                    End If
                    repeated = True
                    index = 0
                Else
                    index += 1
                End If
            Loop
            Return table(index)
        End Function

        Function insert(ByVal name As String, ByVal id As Integer)
            Dim record As dataRecord
            record.data = name
            record.id = id
            Return insert(record)
        End Function

        Sub printTable()
            For i = 0 To table.Length - 1
                Console.WriteLine(i & " " & table(i).data & " " & table(i).id)
            Next
        End Sub
    End Class


    Sub Main()
        Dim hTable As New myHashTable
        hTable.insert("Talha", 100)
        hTable.insert("B", 209)
        hTable.insert("C", 200)
        hTable.insert("D", 500)
        hTable.insert("C", 502)
        hTable.printTable()
        Console.ReadLine()

    End Sub

End Module
