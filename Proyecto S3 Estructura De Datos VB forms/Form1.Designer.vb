<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.graphLabel = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.treeLabel = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.queueLabel = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.stackLabel = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.linkedListLabel = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'graphLabel
        '
        Me.graphLabel.AutoSize = True
        Me.graphLabel.Location = New System.Drawing.Point(425, 303)
        Me.graphLabel.Name = "graphLabel"
        Me.graphLabel.Size = New System.Drawing.Size(0, 13)
        Me.graphLabel.TabIndex = 19
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(280, 304)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(47, 13)
        Me.label5.TabIndex = 18
        Me.label5.Text = "GRAFO:"
        '
        'treeLabel
        '
        Me.treeLabel.AutoSize = True
        Me.treeLabel.Location = New System.Drawing.Point(425, 252)
        Me.treeLabel.Name = "treeLabel"
        Me.treeLabel.Size = New System.Drawing.Size(0, 13)
        Me.treeLabel.TabIndex = 17
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(280, 253)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(46, 13)
        Me.label4.TabIndex = 16
        Me.label4.Text = "ARBOL:"
        '
        'queueLabel
        '
        Me.queueLabel.AutoSize = True
        Me.queueLabel.Location = New System.Drawing.Point(425, 202)
        Me.queueLabel.Name = "queueLabel"
        Me.queueLabel.Size = New System.Drawing.Size(0, 13)
        Me.queueLabel.TabIndex = 15
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(277, 203)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(38, 13)
        Me.label3.TabIndex = 14
        Me.label3.Text = "COLA:"
        '
        'stackLabel
        '
        Me.stackLabel.AutoSize = True
        Me.stackLabel.Location = New System.Drawing.Point(422, 156)
        Me.stackLabel.Name = "stackLabel"
        Me.stackLabel.Size = New System.Drawing.Size(0, 13)
        Me.stackLabel.TabIndex = 13
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(279, 156)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(33, 13)
        Me.label2.TabIndex = 12
        Me.label2.Text = "PILA:"
        '
        'linkedListLabel
        '
        Me.linkedListLabel.AutoSize = True
        Me.linkedListLabel.Location = New System.Drawing.Point(422, 104)
        Me.linkedListLabel.Name = "linkedListLabel"
        Me.linkedListLabel.Size = New System.Drawing.Size(0, 13)
        Me.linkedListLabel.TabIndex = 11
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(279, 104)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(97, 13)
        Me.label1.TabIndex = 10
        Me.label1.Text = "LISTA ENLAZADA"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.graphLabel)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.treeLabel)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.queueLabel)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.stackLabel)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.linkedListLabel)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents graphLabel As Label
    Private WithEvents label5 As Label
    Private WithEvents treeLabel As Label
    Private WithEvents label4 As Label
    Private WithEvents queueLabel As Label
    Private WithEvents label3 As Label
    Private WithEvents stackLabel As Label
    Private WithEvents label2 As Label
    Private WithEvents linkedListLabel As Label
    Private WithEvents label1 As Label
End Class
