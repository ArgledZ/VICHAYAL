<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormApoderado
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelBuscar = New System.Windows.Forms.Panel()
        Me.txtApoderado = New System.Windows.Forms.TextBox()
        Me.btnAgrApoderado = New System.Windows.Forms.Button()
        Me.PanelResultados = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DvgApoderado = New System.Windows.Forms.DataGridView()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModApoderado = New System.Windows.Forms.Button()
        Me.PanelBuscar.SuspendLayout()
        Me.PanelResultados.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DvgApoderado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelBuscar
        '
        Me.PanelBuscar.BackColor = System.Drawing.Color.Transparent
        Me.PanelBuscar.Controls.Add(Me.txtApoderado)
        Me.PanelBuscar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBuscar.Location = New System.Drawing.Point(0, 0)
        Me.PanelBuscar.Name = "PanelBuscar"
        Me.PanelBuscar.Size = New System.Drawing.Size(972, 67)
        Me.PanelBuscar.TabIndex = 4
        '
        'txtApoderado
        '
        Me.txtApoderado.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApoderado.Location = New System.Drawing.Point(12, 38)
        Me.txtApoderado.Name = "txtApoderado"
        Me.txtApoderado.Size = New System.Drawing.Size(806, 26)
        Me.txtApoderado.TabIndex = 3
        '
        'btnAgrApoderado
        '
        Me.btnAgrApoderado.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgrApoderado.Location = New System.Drawing.Point(824, 6)
        Me.btnAgrApoderado.Name = "btnAgrApoderado"
        Me.btnAgrApoderado.Size = New System.Drawing.Size(141, 53)
        Me.btnAgrApoderado.TabIndex = 6
        Me.btnAgrApoderado.Text = "AGREGAR"
        Me.btnAgrApoderado.UseVisualStyleBackColor = True
        '
        'PanelResultados
        '
        Me.PanelResultados.Controls.Add(Me.Panel1)
        Me.PanelResultados.Controls.Add(Me.btnEliminar)
        Me.PanelResultados.Controls.Add(Me.btnModApoderado)
        Me.PanelResultados.Controls.Add(Me.btnAgrApoderado)
        Me.PanelResultados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelResultados.Location = New System.Drawing.Point(0, 67)
        Me.PanelResultados.Name = "PanelResultados"
        Me.PanelResultados.Size = New System.Drawing.Size(972, 464)
        Me.PanelResultados.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.DvgApoderado)
        Me.Panel1.Location = New System.Drawing.Point(12, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(806, 446)
        Me.Panel1.TabIndex = 9
        '
        'DvgApoderado
        '
        Me.DvgApoderado.AllowUserToAddRows = False
        Me.DvgApoderado.AllowUserToDeleteRows = False
        Me.DvgApoderado.AllowUserToResizeColumns = False
        Me.DvgApoderado.AllowUserToResizeRows = False
        Me.DvgApoderado.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DvgApoderado.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DvgApoderado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DvgApoderado.Location = New System.Drawing.Point(10, 10)
        Me.DvgApoderado.Margin = New System.Windows.Forms.Padding(10)
        Me.DvgApoderado.Name = "DvgApoderado"
        Me.DvgApoderado.RowHeadersVisible = False
        Me.DvgApoderado.Size = New System.Drawing.Size(786, 426)
        Me.DvgApoderado.TabIndex = 5
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(824, 124)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(141, 53)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModApoderado
        '
        Me.btnModApoderado.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModApoderado.Location = New System.Drawing.Point(824, 65)
        Me.btnModApoderado.Name = "btnModApoderado"
        Me.btnModApoderado.Size = New System.Drawing.Size(141, 53)
        Me.btnModApoderado.TabIndex = 7
        Me.btnModApoderado.Text = "MODIFICAR"
        Me.btnModApoderado.UseVisualStyleBackColor = True
        '
        'FormApoderado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(972, 531)
        Me.Controls.Add(Me.PanelResultados)
        Me.Controls.Add(Me.PanelBuscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormApoderado"
        Me.Text = "FormApoderado"
        Me.PanelBuscar.ResumeLayout(False)
        Me.PanelBuscar.PerformLayout()
        Me.PanelResultados.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.DvgApoderado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelBuscar As Panel
    Friend WithEvents txtApoderado As TextBox
    Friend WithEvents PanelResultados As Panel
    Friend WithEvents DvgApoderado As DataGridView
    Friend WithEvents btnAgrApoderado As Button
    Friend WithEvents btnModApoderado As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Panel1 As Panel
End Class
