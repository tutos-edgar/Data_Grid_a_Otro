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
        Me.DG1 = New System.Windows.Forms.DataGridView()
        Me.DG2 = New System.Windows.Forms.DataGridView()
        Me.btnMover = New System.Windows.Forms.Button()
        Me.btnTransportar = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DG1
        '
        Me.DG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.DG1.Location = New System.Drawing.Point(45, 104)
        Me.DG1.Name = "DG1"
        Me.DG1.Size = New System.Drawing.Size(347, 278)
        Me.DG1.TabIndex = 0
        '
        'DG2
        '
        Me.DG2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DG2.Location = New System.Drawing.Point(398, 104)
        Me.DG2.Name = "DG2"
        Me.DG2.Size = New System.Drawing.Size(346, 278)
        Me.DG2.TabIndex = 1
        '
        'btnMover
        '
        Me.btnMover.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMover.Location = New System.Drawing.Point(273, 52)
        Me.btnMover.Name = "btnMover"
        Me.btnMover.Size = New System.Drawing.Size(112, 31)
        Me.btnMover.TabIndex = 2
        Me.btnMover.Text = "Mover"
        Me.btnMover.UseVisualStyleBackColor = True
        '
        'btnTransportar
        '
        Me.btnTransportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransportar.Location = New System.Drawing.Point(411, 52)
        Me.btnTransportar.Name = "btnTransportar"
        Me.btnTransportar.Size = New System.Drawing.Size(112, 31)
        Me.btnTransportar.TabIndex = 3
        Me.btnTransportar.Text = "Transportar"
        Me.btnTransportar.UseVisualStyleBackColor = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "NOMBRE"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 200
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "NOMBRE"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(546, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 31)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Abrir Formulario"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnTransportar)
        Me.Controls.Add(Me.btnMover)
        Me.Controls.Add(Me.DG2)
        Me.Controls.Add(Me.DG1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DG1 As DataGridView
    Friend WithEvents DG2 As DataGridView
    Friend WithEvents btnMover As Button
    Friend WithEvents btnTransportar As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
