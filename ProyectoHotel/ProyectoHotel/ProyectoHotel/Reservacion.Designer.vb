<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservacion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.cbCliente = New System.Windows.Forms.ComboBox()
        Me.cbHabitacion = New System.Windows.Forms.ComboBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtv = New System.Windows.Forms.DataGridView()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtFechaF = New System.Windows.Forms.TextBox()
        Me.txtFechai = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbEstado
        '
        Me.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Items.AddRange(New Object() {"Reservado", "Disponible"})
        Me.cbEstado.Location = New System.Drawing.Point(214, 158)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(137, 21)
        Me.cbEstado.TabIndex = 28
        '
        'cbCliente
        '
        Me.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCliente.FormattingEnabled = True
        Me.cbCliente.Location = New System.Drawing.Point(13, 40)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Size = New System.Drawing.Size(183, 21)
        Me.cbCliente.TabIndex = 27
        '
        'cbHabitacion
        '
        Me.cbHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbHabitacion.FormattingEnabled = True
        Me.cbHabitacion.Location = New System.Drawing.Point(214, 101)
        Me.cbHabitacion.Name = "cbHabitacion"
        Me.cbHabitacion.Size = New System.Drawing.Size(137, 21)
        Me.cbHabitacion.TabIndex = 26
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(237, 265)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 25
        Me.btnEliminar.Text = " Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(125, 265)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 23)
        Me.BtnModificar.TabIndex = 24
        Me.BtnModificar.Text = " Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(13, 265)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(75, 23)
        Me.btnInsertar.TabIndex = 23
        Me.btnInsertar.Text = " Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(214, 42)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(137, 20)
        Me.txtNum.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtv)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 358)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(780, 241)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'dtv
        '
        Me.dtv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtv.Location = New System.Drawing.Point(3, 16)
        Me.dtv.Name = "dtv"
        Me.dtv.ReadOnly = True
        Me.dtv.Size = New System.Drawing.Size(774, 222)
        Me.dtv.TabIndex = 0
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.Location = New System.Drawing.Point(421, 17)
        Me.MonthCalendar2.MaxSelectionCount = 31
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.TabIndex = 20
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(13, 216)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(183, 20)
        Me.txtCantidad.TabIndex = 19
        '
        'txtFechaF
        '
        Me.txtFechaF.Location = New System.Drawing.Point(13, 160)
        Me.txtFechaF.Name = "txtFechaF"
        Me.txtFechaF.Size = New System.Drawing.Size(183, 20)
        Me.txtFechaF.TabIndex = 18
        '
        'txtFechai
        '
        Me.txtFechai.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFechai.Location = New System.Drawing.Point(13, 101)
        Me.txtFechai.Name = "txtFechai"
        Me.txtFechai.Size = New System.Drawing.Size(183, 20)
        Me.txtFechai.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = " Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(214, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = " Numero de Tarjeta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Fecha Inicio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(217, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = " Cuarto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = " Fecha Final"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(214, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Label6"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = " Cantidad Dias"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(214, 216)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(137, 20)
        Me.txtID.TabIndex = 36
        Me.txtID.Visible = False
        '
        'Reservacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 606)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbEstado)
        Me.Controls.Add(Me.cbCliente)
        Me.Controls.Add(Me.cbHabitacion)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.btnInsertar)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MonthCalendar2)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtFechaF)
        Me.Controls.Add(Me.txtFechai)
        Me.Name = "Reservacion"
        Me.Text = "Reservacion"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dtv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbEstado As ComboBox
    Friend WithEvents cbCliente As ComboBox
    Friend WithEvents cbHabitacion As ComboBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents btnInsertar As Button
    Friend WithEvents txtNum As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtv As DataGridView
    Friend WithEvents MonthCalendar2 As MonthCalendar
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtFechaF As TextBox
    Friend WithEvents txtFechai As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtID As TextBox
End Class
