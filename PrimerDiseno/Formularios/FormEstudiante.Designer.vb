<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEstudiante
	Inherits System.Windows.Forms.Form

	'Form reemplaza a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelBuscar = New System.Windows.Forms.Panel()
        Me.txtEstudiante = New System.Windows.Forms.TextBox()
        Me.btnAgrEstudiante = New System.Windows.Forms.Button()
        Me.PanelResultados = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DvgEstudiante = New System.Windows.Forms.DataGridView()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModEstudiante = New System.Windows.Forms.Button()
        Me.PanelBuscar.SuspendLayout()
        Me.PanelResultados.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DvgEstudiante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelBuscar
        '
        Me.PanelBuscar.BackColor = System.Drawing.Color.Transparent
        Me.PanelBuscar.Controls.Add(Me.txtEstudiante)
        Me.PanelBuscar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBuscar.Location = New System.Drawing.Point(0, 0)
        Me.PanelBuscar.Name = "PanelBuscar"
        Me.PanelBuscar.Size = New System.Drawing.Size(972, 67)
        Me.PanelBuscar.TabIndex = 4
        '
        'txtEstudiante
        '
        Me.txtEstudiante.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstudiante.Location = New System.Drawing.Point(12, 38)
        Me.txtEstudiante.Name = "txtEstudiante"
        Me.txtEstudiante.Size = New System.Drawing.Size(806, 26)
        Me.txtEstudiante.TabIndex = 3
        '
        'btnAgrEstudiante
        '
        Me.btnAgrEstudiante.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgrEstudiante.Location = New System.Drawing.Point(824, 6)
        Me.btnAgrEstudiante.Name = "btnAgrEstudiante"
        Me.btnAgrEstudiante.Size = New System.Drawing.Size(141, 53)
        Me.btnAgrEstudiante.TabIndex = 6
        Me.btnAgrEstudiante.Text = "AGREGAR"
        Me.btnAgrEstudiante.UseVisualStyleBackColor = True
        '
        'PanelResultados
        '
        Me.PanelResultados.Controls.Add(Me.Panel1)
        Me.PanelResultados.Controls.Add(Me.btnEliminar)
        Me.PanelResultados.Controls.Add(Me.btnModEstudiante)
        Me.PanelResultados.Controls.Add(Me.btnAgrEstudiante)
        Me.PanelResultados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelResultados.Location = New System.Drawing.Point(0, 67)
        Me.PanelResultados.Name = "PanelResultados"
        Me.PanelResultados.Size = New System.Drawing.Size(972, 464)
        Me.PanelResultados.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.DvgEstudiante)
        Me.Panel1.Location = New System.Drawing.Point(12, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(806, 446)
        Me.Panel1.TabIndex = 9
        '
        'DvgEstudiante
        '
        Me.DvgEstudiante.AllowUserToAddRows = False
        Me.DvgEstudiante.AllowUserToDeleteRows = False
        Me.DvgEstudiante.AllowUserToResizeColumns = False
        Me.DvgEstudiante.AllowUserToResizeRows = False
        Me.DvgEstudiante.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DvgEstudiante.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DvgEstudiante.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DvgEstudiante.Location = New System.Drawing.Point(10, 10)
        Me.DvgEstudiante.Margin = New System.Windows.Forms.Padding(10)
        Me.DvgEstudiante.Name = "DvgEstudiante"
        Me.DvgEstudiante.RowHeadersVisible = False
        Me.DvgEstudiante.Size = New System.Drawing.Size(786, 426)
        Me.DvgEstudiante.TabIndex = 5
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
        'btnModEstudiante
        '
        Me.btnModEstudiante.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModEstudiante.Location = New System.Drawing.Point(824, 65)
        Me.btnModEstudiante.Name = "btnModEstudiante"
        Me.btnModEstudiante.Size = New System.Drawing.Size(141, 53)
        Me.btnModEstudiante.TabIndex = 7
        Me.btnModEstudiante.Text = "MODIFICAR"
        Me.btnModEstudiante.UseVisualStyleBackColor = True
        '
        'FormEstudiante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(972, 531)
        Me.Controls.Add(Me.PanelResultados)
        Me.Controls.Add(Me.PanelBuscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormEstudiante"
        Me.Text = "FormEstudiante"
        Me.PanelBuscar.ResumeLayout(False)
        Me.PanelBuscar.PerformLayout()
        Me.PanelResultados.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.DvgEstudiante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelBuscar As Panel
    Friend WithEvents txtEstudiante As TextBox
    Friend WithEvents PanelResultados As Panel
    Friend WithEvents DvgEstudiante As DataGridView
    Friend WithEvents btnAgrEstudiante As Button
    Friend WithEvents btnModEstudiante As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Panel1 As Panel
End Class
