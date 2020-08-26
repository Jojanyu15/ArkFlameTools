<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Visualizacion
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
        Me.regtable = New System.Windows.Forms.DataGridView()
        Me.label = New System.Windows.Forms.Label()
        Me.FECHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.regtable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'regtable
        '
        Me.regtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.regtable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FECHA, Me.NOMBRE})
        Me.regtable.Location = New System.Drawing.Point(54, 70)
        Me.regtable.Name = "regtable"
        Me.regtable.Size = New System.Drawing.Size(847, 261)
        Me.regtable.TabIndex = 0
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(51, 43)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(0, 16)
        Me.label.TabIndex = 1
        '
        'FECHA
        '
        Me.FECHA.HeaderText = "Fecha"
        Me.FECHA.Name = "FECHA"
        '
        'NOMBRE
        '
        Me.NOMBRE.HeaderText = "Nombre"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.Width = 2000
        '
        'Visualizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 391)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.regtable)
        Me.Name = "Visualizacion"
        Me.Text = "Visualizacion"
        CType(Me.regtable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents regtable As DataGridView
    Friend WithEvents label As Label
    Friend WithEvents FECHA As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As DataGridViewTextBoxColumn
End Class
