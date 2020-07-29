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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.BtnListar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.PanelDG = New System.Windows.Forms.Panel()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdentidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtgDatos = New System.Windows.Forms.DataGridView()
        Me.LblCambiar = New System.Windows.Forms.LinkLabel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.PanelDG.SuspendLayout()
        CType(Me.dtgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(208, 14)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(121, 22)
        Me.txtUserName.TabIndex = 0
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(208, 57)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(121, 22)
        Me.TxtPassword.TabIndex = 1
        '
        'BtnListar
        '
        Me.BtnListar.Location = New System.Drawing.Point(609, 14)
        Me.BtnListar.Name = "BtnListar"
        Me.BtnListar.Size = New System.Drawing.Size(104, 28)
        Me.BtnListar.TabIndex = 5
        Me.BtnListar.Text = "Listar"
        Me.BtnListar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Location = New System.Drawing.Point(609, 51)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(104, 28)
        Me.BtnEditar.TabIndex = 6
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(353, 11)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(104, 28)
        Me.BtnBuscar.TabIndex = 7
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'PanelDG
        '
        Me.PanelDG.Controls.Add(Me.dtgDatos)
        Me.PanelDG.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelDG.Location = New System.Drawing.Point(0, 261)
        Me.PanelDG.Name = "PanelDG"
        Me.PanelDG.Size = New System.Drawing.Size(800, 189)
        Me.PanelDG.TabIndex = 34
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(609, 51)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(104, 28)
        Me.BtnAgregar.TabIndex = 4
        Me.BtnAgregar.Text = "Ingresar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'cmbTipo
        '
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Items.AddRange(New Object() {"Cajero", "Administrador"})
        Me.cmbTipo.Location = New System.Drawing.Point(208, 135)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(121, 24)
        Me.cmbTipo.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 142)
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
        'txtIdentidad
        '
        Me.txtIdentidad.Location = New System.Drawing.Point(208, 94)
        Me.txtIdentidad.MaxLength = 15
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(121, 22)
        Me.txtIdentidad.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 17)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Id Empleado:"
        '
        'dtgDatos
        '
        Me.dtgDatos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.dtgDatos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dtgDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgDatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgDatos.ColumnHeadersHeight = 35
        Me.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgDatos.EnableHeadersVisualStyles = False
        Me.dtgDatos.GridColor = System.Drawing.Color.Gray
        Me.dtgDatos.Location = New System.Drawing.Point(0, 0)
        Me.dtgDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgDatos.Name = "dtgDatos"
        Me.dtgDatos.ReadOnly = True
        Me.dtgDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(66, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgDatos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgDatos.RowHeadersVisible = False
        Me.dtgDatos.RowHeadersWidth = 51
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.NullValue = Nothing
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.dtgDatos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgDatos.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dtgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgDatos.Size = New System.Drawing.Size(800, 189)
        Me.dtgDatos.TabIndex = 2
        '
        'LblCambiar
        '
        Me.LblCambiar.AutoSize = True
        Me.LblCambiar.Location = New System.Drawing.Point(597, 153)
        Me.LblCambiar.Name = "LblCambiar"
        Me.LblCambiar.Size = New System.Drawing.Size(137, 17)
        Me.LblCambiar.TabIndex = 52
        Me.LblCambiar.TabStop = True
        Me.LblCambiar.Text = "Cambiar Contraseña"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(609, 122)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(104, 28)
        Me.btnCancelar.TabIndex = 53
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(609, 85)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(104, 28)
        Me.BtnEliminar.TabIndex = 54
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'Usuarios
        '
        Me.AcceptButton = Me.BtnAgregar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.LblCambiar)
        Me.Controls.Add(Me.txtIdentidad)
        Me.Controls.Add(Me.Label3)
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
        CType(Me.dtgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUserName As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents BtnListar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents PanelDG As Panel
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents cmbTipo As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdentidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtgDatos As DataGridView
    Friend WithEvents LblCambiar As LinkLabel
    Friend WithEvents btnCancelar As Button
    Friend WithEvents BtnEliminar As Button
End Class
