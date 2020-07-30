<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservación
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
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtFechaF = New System.Windows.Forms.TextBox()
        Me.txtFechai = New System.Windows.Forms.TextBox()
        Me.cbHabitacion = New System.Windows.Forms.ComboBox()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.cbCliente = New System.Windows.Forms.ComboBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
        Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
        Me.dtv = New System.Windows.Forms.DataGridView()
        CType(Me.dtv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtID.Enabled = False
        Me.txtID.ForeColor = System.Drawing.Color.LightGray
        Me.txtID.Location = New System.Drawing.Point(226, 133)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(137, 13)
        Me.txtID.TabIndex = 54
        Me.txtID.Text = "ID"
        Me.txtID.Visible = False
        '
        'btnEliminar
        '
        Me.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.ForeColor = System.Drawing.Color.LightGray
        Me.btnEliminar.Location = New System.Drawing.Point(250, 171)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(110, 23)
        Me.btnEliminar.TabIndex = 43
        Me.btnEliminar.Text = " Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.ForeColor = System.Drawing.Color.LightGray
        Me.BtnModificar.Location = New System.Drawing.Point(138, 171)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(106, 23)
        Me.BtnModificar.TabIndex = 42
        Me.BtnModificar.Text = " Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'btnInsertar
        '
        Me.btnInsertar.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod
        Me.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsertar.ForeColor = System.Drawing.Color.LightGray
        Me.btnInsertar.Location = New System.Drawing.Point(17, 171)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(115, 23)
        Me.btnInsertar.TabIndex = 41
        Me.btnInsertar.Text = " Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'txtNum
        '
        Me.txtNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.txtNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNum.ForeColor = System.Drawing.Color.LightGray
        Me.txtNum.Location = New System.Drawing.Point(226, 38)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(137, 13)
        Me.txtNum.TabIndex = 40
        Me.txtNum.Text = "Número de Tarjeta"
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCantidad.ForeColor = System.Drawing.Color.LightGray
        Me.txtCantidad.Location = New System.Drawing.Point(25, 133)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(183, 13)
        Me.txtCantidad.TabIndex = 39
        Me.txtCantidad.Text = "Cantidad Días"
        '
        'txtFechaF
        '
        Me.txtFechaF.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.txtFechaF.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFechaF.ForeColor = System.Drawing.Color.LightGray
        Me.txtFechaF.Location = New System.Drawing.Point(25, 101)
        Me.txtFechaF.Name = "txtFechaF"
        Me.txtFechaF.Size = New System.Drawing.Size(183, 13)
        Me.txtFechaF.TabIndex = 38
        Me.txtFechaF.Text = "Fecha Final"
        '
        'txtFechai
        '
        Me.txtFechai.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.txtFechai.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFechai.ForeColor = System.Drawing.Color.LightGray
        Me.txtFechai.Location = New System.Drawing.Point(25, 71)
        Me.txtFechai.Name = "txtFechai"
        Me.txtFechai.Size = New System.Drawing.Size(183, 13)
        Me.txtFechai.TabIndex = 37
        Me.txtFechai.Text = "Fecha Inicio"
        '
        'cbHabitacion
        '
        Me.cbHabitacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.cbHabitacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbHabitacion.FormattingEnabled = True
        Me.cbHabitacion.Location = New System.Drawing.Point(226, 98)
        Me.cbHabitacion.Name = "cbHabitacion"
        Me.cbHabitacion.Size = New System.Drawing.Size(137, 21)
        Me.cbHabitacion.TabIndex = 55
        '
        'cbEstado
        '
        Me.cbEstado.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.cbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Location = New System.Drawing.Point(226, 71)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(137, 21)
        Me.cbEstado.TabIndex = 56
        '
        'cbCliente
        '
        Me.cbCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.cbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbCliente.FormattingEnabled = True
        Me.cbCliente.Location = New System.Drawing.Point(25, 37)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Size = New System.Drawing.Size(183, 21)
        Me.cbCliente.TabIndex = 57
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.LightGray
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(25, 152)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(170, 1)
        Me.FlowLayoutPanel1.TabIndex = 58
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.LightGray
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(226, 57)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(135, 1)
        Me.FlowLayoutPanel2.TabIndex = 59
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.BackColor = System.Drawing.Color.LightGray
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(25, 118)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(170, 1)
        Me.FlowLayoutPanel3.TabIndex = 59
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.BackColor = System.Drawing.Color.LightGray
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(25, 90)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(170, 1)
        Me.FlowLayoutPanel4.TabIndex = 60
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.Location = New System.Drawing.Point(372, 18)
        Me.MonthCalendar2.MaxSelectionCount = 31
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.TabIndex = 61
        '
        'FlowLayoutPanel5
        '
        Me.FlowLayoutPanel5.BackColor = System.Drawing.Color.Goldenrod
        Me.FlowLayoutPanel5.Location = New System.Drawing.Point(0, 227)
        Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        Me.FlowLayoutPanel5.Size = New System.Drawing.Size(632, 1)
        Me.FlowLayoutPanel5.TabIndex = 62
        '
        'dtv
        '
        Me.dtv.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.dtv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dtv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtv.ColumnHeadersHeight = 30
        Me.dtv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtv.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtv.EnableHeadersVisualStyles = False
        Me.dtv.GridColor = System.Drawing.Color.Gray
        Me.dtv.Location = New System.Drawing.Point(0, 287)
        Me.dtv.Name = "dtv"
        Me.dtv.ReadOnly = True
        Me.dtv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(66, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtv.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtv.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.NullValue = Nothing
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.dtv.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dtv.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dtv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtv.Size = New System.Drawing.Size(632, 136)
        Me.dtv.TabIndex = 63
        '
        'Reservación
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(632, 423)
        Me.Controls.Add(Me.dtv)
        Me.Controls.Add(Me.FlowLayoutPanel5)
        Me.Controls.Add(Me.MonthCalendar2)
        Me.Controls.Add(Me.FlowLayoutPanel4)
        Me.Controls.Add(Me.FlowLayoutPanel3)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.cbCliente)
        Me.Controls.Add(Me.cbEstado)
        Me.Controls.Add(Me.cbHabitacion)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.btnInsertar)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtFechaF)
        Me.Controls.Add(Me.txtFechai)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Reservación"
        Me.Text = "Reservación"
        CType(Me.dtv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtID As TextBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents btnInsertar As Button
    Friend WithEvents txtNum As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtFechaF As TextBox
    Friend WithEvents txtFechai As TextBox
    Friend WithEvents cbHabitacion As ComboBox
    Friend WithEvents cbEstado As ComboBox
    Friend WithEvents cbCliente As ComboBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents MonthCalendar2 As MonthCalendar
    Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
    Friend WithEvents dtv As DataGridView
End Class
