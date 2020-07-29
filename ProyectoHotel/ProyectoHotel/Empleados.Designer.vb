<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empleados
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
        Me.txtIdentidad = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.BtnListar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.PanelDG = New System.Windows.Forms.Panel()
        Me.DataHabitaciones = New System.Windows.Forms.DataGridView()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtRTN = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PanelDG.SuspendLayout()
        CType(Me.DataHabitaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Location = New System.Drawing.Point(176, 68)
        Me.txtIdentidad.MaxLength = 15
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(121, 22)
        Me.txtIdentidad.TabIndex = 50
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(176, 99)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(121, 22)
        Me.txtNombre.TabIndex = 49
        '
        'BtnListar
        '
        Me.BtnListar.Location = New System.Drawing.Point(609, 93)
        Me.BtnListar.Name = "BtnListar"
        Me.BtnListar.Size = New System.Drawing.Size(104, 28)
        Me.BtnListar.TabIndex = 48
        Me.BtnListar.Text = "Listar"
        Me.BtnListar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Location = New System.Drawing.Point(609, 176)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(104, 28)
        Me.BtnEditar.TabIndex = 47
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(319, 68)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(104, 28)
        Me.BtnBuscar.TabIndex = 46
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'PanelDG
        '
        Me.PanelDG.Controls.Add(Me.DataHabitaciones)
        Me.PanelDG.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelDG.Location = New System.Drawing.Point(0, 327)
        Me.PanelDG.Name = "PanelDG"
        Me.PanelDG.Size = New System.Drawing.Size(779, 189)
        Me.PanelDG.TabIndex = 45
        '
        'DataHabitaciones
        '
        Me.DataHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataHabitaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataHabitaciones.Location = New System.Drawing.Point(0, 0)
        Me.DataHabitaciones.Name = "DataHabitaciones"
        Me.DataHabitaciones.RowHeadersWidth = 51
        Me.DataHabitaciones.RowTemplate.Height = 24
        Me.DataHabitaciones.Size = New System.Drawing.Size(779, 189)
        Me.DataHabitaciones.TabIndex = 11
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(609, 130)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(104, 28)
        Me.BtnAgregar.TabIndex = 44
        Me.BtnAgregar.Text = "Ingresar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'cmbTipo
        '
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Items.AddRange(New Object() {"Cajero", "Administrador"})
        Me.cmbTipo.Location = New System.Drawing.Point(176, 250)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(121, 24)
        Me.cmbTipo.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(63, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 17)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Identidad:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 17)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "RTN:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(63, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Telefono:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(63, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 17)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Email:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(63, 283)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 17)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Horario:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(63, 257)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 17)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Tipo Empleado:"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(176, 130)
        Me.txtApellido.MaxLength = 15
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(121, 22)
        Me.txtApellido.TabIndex = 57
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(176, 161)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(121, 22)
        Me.txtTelefono.TabIndex = 56
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(176, 189)
        Me.txtEmail.MaxLength = 15
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(121, 22)
        Me.txtEmail.TabIndex = 59
        '
        'txtRTN
        '
        Me.txtRTN.Location = New System.Drawing.Point(176, 220)
        Me.txtRTN.Name = "txtRTN"
        Me.txtRTN.Size = New System.Drawing.Size(121, 22)
        Me.txtRTN.TabIndex = 58
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Cajero", "Administrador"})
        Me.ComboBox1.Location = New System.Drawing.Point(176, 280)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 60
        '
        'Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 516)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtRTN)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtIdentidad)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.BtnListar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.PanelDG)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Empleados"
        Me.Text = "Empleados"
        Me.PanelDG.ResumeLayout(False)
        CType(Me.DataHabitaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIdentidad As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents BtnListar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents PanelDG As Panel
    Friend WithEvents DataHabitaciones As DataGridView
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents cmbTipo As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtRTN As TextBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
