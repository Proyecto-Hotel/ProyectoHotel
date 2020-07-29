<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
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
        Me.PanelDG.SuspendLayout()
        CType(Me.DataHabitaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(208, 14)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(121, 22)
        Me.txtUserName.TabIndex = 39
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(208, 57)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(121, 22)
        Me.TxtPassword.TabIndex = 38
        '
        'BtnListar
        '
        Me.BtnListar.Location = New System.Drawing.Point(609, 14)
        Me.BtnListar.Name = "BtnListar"
        Me.BtnListar.Size = New System.Drawing.Size(104, 28)
        Me.BtnListar.TabIndex = 37
        Me.BtnListar.Text = "Listar"
        Me.BtnListar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Location = New System.Drawing.Point(609, 97)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(104, 28)
        Me.BtnEditar.TabIndex = 36
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(353, 11)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(104, 28)
        Me.BtnBuscar.TabIndex = 35
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'PanelDG
        '
        Me.PanelDG.Controls.Add(Me.DataHabitaciones)
        Me.PanelDG.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelDG.Location = New System.Drawing.Point(0, 261)
        Me.PanelDG.Name = "PanelDG"
        Me.PanelDG.Size = New System.Drawing.Size(800, 189)
        Me.PanelDG.TabIndex = 34
        '
        'DataHabitaciones
        '
        Me.DataHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataHabitaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataHabitaciones.Location = New System.Drawing.Point(0, 0)
        Me.DataHabitaciones.Name = "DataHabitaciones"
        Me.DataHabitaciones.RowHeadersWidth = 51
        Me.DataHabitaciones.RowTemplate.Height = 24
        Me.DataHabitaciones.Size = New System.Drawing.Size(800, 189)
        Me.DataHabitaciones.TabIndex = 11
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(609, 51)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(104, 28)
        Me.BtnAgregar.TabIndex = 33
        Me.BtnAgregar.Text = "Ingresar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'cmbTipo
        '
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Items.AddRange(New Object() {"Cajero", "Administrador"})
        Me.cmbTipo.Location = New System.Drawing.Point(208, 98)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(121, 24)
        Me.cmbTipo.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 17)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Tipo de Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "UserName:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Contraseña"
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.BtnListar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.PanelDG)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Usuarios"
        Me.Text = "Usuarios"
        Me.PanelDG.ResumeLayout(False)
        CType(Me.DataHabitaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUserName As TextBox
    Friend WithEvents TxtPassword As TextBox
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
End Class
