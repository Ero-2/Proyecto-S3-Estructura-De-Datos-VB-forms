Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView

Public Class Form1
    Private linkedList As LinkedList(Of Integer)
    Private stack As Stack(Of Integer)
    Private queue As Queue(Of Integer)
    Private rootNode As TreeNode
    Private graph As Graph

    Public Sub New()
        InitializeComponent()
        InitializeDataStructures()
    End Sub

    Private Sub InitializeDataStructures()
        ' Lista Enlazada
        linkedList = New LinkedList(Of Integer)()
        linkedList.AddLast(1)
        linkedList.AddLast(2)
        linkedList.AddLast(3)

        ' Pila
        stack = New Stack(Of Integer)()
        stack.Push(1)
        stack.Push(2)
        stack.Push(3)

        ' Cola
        queue = New Queue(Of Integer)()
        queue.Enqueue(1)
        queue.Enqueue(2)
        queue.Enqueue(3)

        ' Árbol Binario
        rootNode = New TreeNode(1)
        rootNode.Left = New TreeNode(2)
        rootNode.Right = New TreeNode(3)

        ' Grafo No Dirigido
        graph = New Graph()
        graph.AddVertex(1)
        graph.AddVertex(2)
        graph.AddVertex(3)

        graph.AddEdge(1, 2)
        graph.AddEdge(2, 3)
    End Sub

    Private Sub DisplayData()
        ' Mostrar en la interfaz gráfica
        linkedListLabel.Text = "Linked List: " & String.Join(" -> ", linkedList)
        stackLabel.Text = "Stack: " & String.Join(" -> ", stack)
        queueLabel.Text = "Queue: " & String.Join(" -> ", queue)

        ' Árbol Binario (Inorder Traversal)
        treeLabel.Text = "Binary Tree (Inorder Traversal): "
        InorderTraversal(rootNode)

        ' Grafo No Dirigido
        graphLabel.Text = "Graph Representation:" & vbCrLf & graph.GetGraphString()
    End Sub

    Private Sub InorderTraversal(node As TreeNode)
        If node IsNot Nothing Then
            InorderTraversal(node.Left)
            treeLabel.Text &= node.Value & " "
            InorderTraversal(node.Right)
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayData()
    End Sub



End Class

