<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Habitaciones
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.TxtIdHabitacion = New System.Windows.Forms.MaskedTextBox()
        Me.txtPrecio = New System.Windows.Forms.MaskedTextBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.DataHabitaciones = New System.Windows.Forms.DataGridView()
        Me.PanelDG = New System.Windows.Forms.Panel()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnListar = New System.Windows.Forms.Button()
        CType(Me.DataHabitaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDG.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Precio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numero de Habitación:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tipo Habitación:"
        '
        'cmbTipo
        '
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Location = New System.Drawing.Point(208, 133)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(121, 24)
        Me.cmbTipo.TabIndex = 7
        '
        'TxtIdHabitacion
        '
        Me.TxtIdHabitacion.Location = New System.Drawing.Point(209, 54)
        Me.TxtIdHabitacion.Mask = "99"
        Me.TxtIdHabitacion.Name = "TxtIdHabitacion"
        Me.TxtIdHabitacion.Size = New System.Drawing.Size(54, 22)
        Me.TxtIdHabitacion.TabIndex = 8
        Me.TxtIdHabitacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtIdHabitacion.ValidatingType = GetType(Integer)
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(209, 92)
        Me.txtPrecio.Mask = "99999"
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(34, 22)
        Me.txtPrecio.TabIndex = 9
        Me.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPrecio.ValidatingType = GetType(Integer)
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(609, 86)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(104, 28)
        Me.BtnAgregar.TabIndex = 10
        Me.BtnAgregar.Text = "Ingresar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'DataHabitaciones
        '
        Me.DataHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataHabitaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataHabitaciones.Location = New System.Drawing.Point(0, 0)
        Me.DataHabitaciones.Name = "DataHabitaciones"
        Me.DataHabitaciones.RowHeadersWidth = 51
        Me.DataHabitaciones.RowTemplate.Height = 24
        Me.DataHabitaciones.Size = New System.Drawing.Size(801, 189)
        Me.DataHabitaciones.TabIndex = 11
        '
        'PanelDG
        '
        Me.PanelDG.Controls.Add(Me.DataHabitaciones)
        Me.PanelDG.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelDG.Location = New System.Drawing.Point(0, 285)
        Me.PanelDG.Name = "PanelDG"
        Me.PanelDG.Size = New System.Drawing.Size(801, 189)
        Me.PanelDG.TabIndex = 12
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(284, 49)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(104, 28)
        Me.BtnBuscar.TabIndex = 13
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Location = New System.Drawing.Point(609, 132)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(104, 28)
        Me.BtnEditar.TabIndex = 14
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnListar
        '
        Me.BtnListar.Location = New System.Drawing.Point(609, 49)
        Me.BtnListar.Name = "BtnListar"
        Me.BtnListar.Size = New System.Drawing.Size(104, 28)
        Me.BtnListar.TabIndex = 15
        Me.BtnListar.Text = "Listar"
        Me.BtnListar.UseVisualStyleBackColor = True
        '
        'Habitaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 474)
        Me.Controls.Add(Me.BtnListar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.PanelDG)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.TxtIdHabitacion)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Habitaciones"
        Me.Text = "Habitaciones"
        CType(Me.DataHabitaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDG.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbTipo As ComboBox
    Friend WithEvents TxtIdHabitacion As MaskedTextBox
    Friend WithEvents txtPrecio As MaskedTextBox
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents DataHabitaciones As DataGridView
    Friend WithEvents PanelDG As Panel
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnListar As Button
End Class
