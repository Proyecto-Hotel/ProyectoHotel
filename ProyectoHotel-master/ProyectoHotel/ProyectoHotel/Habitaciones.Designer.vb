﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Habitaciones
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
        Me.DataHabitaciones = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtIdHabitacion = New System.Windows.Forms.TextBox()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        CType(Me.DataHabitaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataHabitaciones
        '
        Me.DataHabitaciones.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.DataHabitaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataHabitaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataHabitaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataHabitaciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataHabitaciones.ColumnHeadersHeight = 30
        Me.DataHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataHabitaciones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataHabitaciones.EnableHeadersVisualStyles = False
        Me.DataHabitaciones.GridColor = System.Drawing.Color.Gray
        Me.DataHabitaciones.Location = New System.Drawing.Point(0, 282)
        Me.DataHabitaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.DataHabitaciones.Name = "DataHabitaciones"
        Me.DataHabitaciones.ReadOnly = True
        Me.DataHabitaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(66, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataHabitaciones.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataHabitaciones.RowHeadersVisible = False
        Me.DataHabitaciones.RowHeadersWidth = 51
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.NullValue = Nothing
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.DataHabitaciones.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataHabitaciones.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DataHabitaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataHabitaciones.Size = New System.Drawing.Size(855, 239)
        Me.DataHabitaciones.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Location = New System.Drawing.Point(81, 124)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(224, 1)
        Me.Panel1.TabIndex = 54
        '
        'txtPrecio
        '
        Me.txtPrecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrecio.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.ForeColor = System.Drawing.Color.LightGray
        Me.txtPrecio.Location = New System.Drawing.Point(81, 101)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(239, 25)
        Me.txtPrecio.TabIndex = 53
        Me.txtPrecio.Text = "Precio"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightGray
        Me.Panel3.Location = New System.Drawing.Point(81, 80)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(224, 1)
        Me.Panel3.TabIndex = 52
        '
        'TxtIdHabitacion
        '
        Me.TxtIdHabitacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.TxtIdHabitacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtIdHabitacion.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdHabitacion.ForeColor = System.Drawing.Color.LightGray
        Me.TxtIdHabitacion.Location = New System.Drawing.Point(81, 57)
        Me.TxtIdHabitacion.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIdHabitacion.MaxLength = 2
        Me.TxtIdHabitacion.Name = "TxtIdHabitacion"
        Me.TxtIdHabitacion.Size = New System.Drawing.Size(239, 25)
        Me.TxtIdHabitacion.TabIndex = 51
        Me.TxtIdHabitacion.Text = "Número de Habitación"
        '
        'cmbTipo
        '
        Me.cmbTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTipo.ForeColor = System.Drawing.Color.LightGray
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Location = New System.Drawing.Point(81, 143)
        Me.cmbTipo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(223, 24)
        Me.cmbTipo.TabIndex = 55
        Me.cmbTipo.Text = "Tipo"
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.ForeColor = System.Drawing.Color.LightGray
        Me.btnActualizar.Location = New System.Drawing.Point(417, 137)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(224, 30)
        Me.btnActualizar.TabIndex = 69
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.LightGray
        Me.btnGuardar.Location = New System.Drawing.Point(417, 75)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(224, 30)
        Me.btnGuardar.TabIndex = 68
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(41, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 23)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Habitaciones"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel10.Location = New System.Drawing.Point(0, 236)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(855, 1)
        Me.Panel10.TabIndex = 72
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProyectoHotel.My.Resources.Resources.Buscar
        Me.PictureBox1.Location = New System.Drawing.Point(319, 242)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 75
        Me.PictureBox1.TabStop = False
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.LightGray
        Me.Panel11.Location = New System.Drawing.Point(16, 268)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(333, 1)
        Me.Panel11.TabIndex = 74
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBuscar.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.ForeColor = System.Drawing.Color.LightGray
        Me.txtBuscar.Location = New System.Drawing.Point(16, 245)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(239, 25)
        Me.txtBuscar.TabIndex = 73
        Me.txtBuscar.Text = "Buscar"
        '
        'Habitaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(855, 521)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TxtIdHabitacion)
        Me.Controls.Add(Me.DataHabitaciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Habitaciones"
        Me.Text = "Habitaciones"
        CType(Me.DataHabitaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataHabitaciones As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TxtIdHabitacion As TextBox
    Friend WithEvents cmbTipo As ComboBox
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents txtBuscar As TextBox
End Class
