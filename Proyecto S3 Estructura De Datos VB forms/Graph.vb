Public Class Graph
    Private adjacencyList As Dictionary(Of Integer, List(Of Integer))

    Public Sub New()
        adjacencyList = New Dictionary(Of Integer, List(Of Integer))()
    End Sub

    Public Sub AddVertex(vertex As Integer)
        adjacencyList(vertex) = New List(Of Integer)()
    End Sub

    Public Sub AddEdge(source As Integer, destination As Integer)
        adjacencyList(source).Add(destination)
        adjacencyList(destination).Add(source)
    End Sub

    Public Function GetGraphString() As String
        Dim result As String = ""
        For Each vertex In adjacencyList.Keys
            result &= vertex & ": "
            result &= String.Join(" ", adjacencyList(vertex))
            result &= vbCrLf
        Next
        Return result
    End Function
End Class
