<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPregrado
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
        Me.PanelResult = New System.Windows.Forms.Panel()
        Me.btnAgrCliente = New System.Windows.Forms.Button()
        Me.DGVListaClientes = New System.Windows.Forms.DataGridView()
        Me.lblMant = New System.Windows.Forms.Label()
        Me.PanelResult.SuspendLayout()
        CType(Me.DGVListaClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelResult
        '
        Me.PanelResult.Controls.Add(Me.btnAgrCliente)
        Me.PanelResult.Controls.Add(Me.DGVListaClientes)
        Me.PanelResult.Controls.Add(Me.lblMant)
        Me.PanelResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelResult.Location = New System.Drawing.Point(0, 0)
        Me.PanelResult.Name = "PanelResult"
        Me.PanelResult.Size = New System.Drawing.Size(800, 450)
        Me.PanelResult.TabIndex = 1
        '
        'btnAgrCliente
        '
        Me.btnAgrCliente.Location = New System.Drawing.Point(652, 66)
        Me.btnAgrCliente.Name = "btnAgrCliente"
        Me.btnAgrCliente.Size = New System.Drawing.Size(112, 23)
        Me.btnAgrCliente.TabIndex = 2
        Me.btnAgrCliente.Text = "Agregar Cliente"
        Me.btnAgrCliente.UseVisualStyleBackColor = True
        '
        'DGVListaClientes
        '
        Me.DGVListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVListaClientes.Location = New System.Drawing.Point(47, 53)
        Me.DGVListaClientes.Name = "DGVListaClientes"
        Me.DGVListaClientes.Size = New System.Drawing.Size(559, 385)
        Me.DGVListaClientes.TabIndex = 1
        '
        'lblMant
        '
        Me.lblMant.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMant.Location = New System.Drawing.Point(58, 9)
        Me.lblMant.Name = "lblMant"
        Me.lblMant.Size = New System.Drawing.Size(323, 55)
        Me.lblMant.TabIndex = 0
        Me.lblMant.Text = "Lista de clientes"
        Me.lblMant.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FormPregrado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelResult)
        Me.Name = "FormPregrado"
        Me.Text = "FormPregrado"
        Me.PanelResult.ResumeLayout(False)
        CType(Me.DGVListaClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelResult As Panel
	Friend WithEvents lblMant As Label
	Friend WithEvents DGVListaClientes As DataGridView
	Friend WithEvents btnAgrCliente As Button
End Class
