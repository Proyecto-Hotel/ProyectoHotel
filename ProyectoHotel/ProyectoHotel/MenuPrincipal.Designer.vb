<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.PanelSubmenuMan = New System.Windows.Forms.Panel()
        Me.btnHorarios = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PanelSubmenuRes = New System.Windows.Forms.Panel()
        Me.btnExtra = New System.Windows.Forms.Button()
        Me.btnReservar = New System.Windows.Forms.Button()
        Me.btnFactura = New System.Windows.Forms.Button()
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.btnExtras = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtUsuarios = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Mantenimiento = New System.Windows.Forms.Button()
        Me.btnReservacion = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnEmpleados = New System.Windows.Forms.Button()
        Me.btnRestaurar = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnMaximizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.PanelMenu.SuspendLayout()
        Me.PanelSubmenuMan.SuspendLayout()
        Me.PanelSubmenuRes.SuspendLayout()
        Me.PanelBarraTitulo.SuspendLayout()
        Me.btnExtras.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.PanelSubmenuMan)
        Me.PanelMenu.Controls.Add(Me.PanelSubmenuRes)
        Me.PanelMenu.Controls.Add(Me.txtUsuarios)
        Me.PanelMenu.Controls.Add(Me.Button2)
        Me.PanelMenu.Controls.Add(Me.Mantenimiento)
        Me.PanelMenu.Controls.Add(Me.btnReservacion)
        Me.PanelMenu.Controls.Add(Me.btnClientes)
        Me.PanelMenu.Controls.Add(Me.Button1)
        Me.PanelMenu.Controls.Add(Me.btnEmpleados)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 32)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(176, 423)
        Me.PanelMenu.TabIndex = 1
        '
        'PanelSubmenuMan
        '
        Me.PanelSubmenuMan.Controls.Add(Me.btnHorarios)
        Me.PanelSubmenuMan.Controls.Add(Me.Button3)
        Me.PanelSubmenuMan.Location = New System.Drawing.Point(0, 247)
        Me.PanelSubmenuMan.Name = "PanelSubmenuMan"
        Me.PanelSubmenuMan.Size = New System.Drawing.Size(176, 50)
        Me.PanelSubmenuMan.TabIndex = 7
        '
        'btnHorarios
        '
        Me.btnHorarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnHorarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHorarios.FlatAppearance.BorderSize = 0
        Me.btnHorarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnHorarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHorarios.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHorarios.ForeColor = System.Drawing.Color.LightGray
        Me.btnHorarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHorarios.Location = New System.Drawing.Point(0, 25)
        Me.btnHorarios.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHorarios.Name = "btnHorarios"
        Me.btnHorarios.Size = New System.Drawing.Size(176, 25)
        Me.btnHorarios.TabIndex = 3
        Me.btnHorarios.Text = "Horarios"
        Me.btnHorarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHorarios.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.LightGray
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(0, 0)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(176, 25)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Tipo de Habitaciones"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PanelSubmenuRes
        '
        Me.PanelSubmenuRes.Controls.Add(Me.btnExtra)
        Me.PanelSubmenuRes.Controls.Add(Me.btnReservar)
        Me.PanelSubmenuRes.Controls.Add(Me.btnFactura)
        Me.PanelSubmenuRes.Location = New System.Drawing.Point(0, 32)
        Me.PanelSubmenuRes.Name = "PanelSubmenuRes"
        Me.PanelSubmenuRes.Size = New System.Drawing.Size(176, 76)
        Me.PanelSubmenuRes.TabIndex = 8
        '
        'btnExtra
        '
        Me.btnExtra.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExtra.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnExtra.FlatAppearance.BorderSize = 0
        Me.btnExtra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnExtra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnExtra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExtra.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExtra.ForeColor = System.Drawing.Color.LightGray
        Me.btnExtra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExtra.Location = New System.Drawing.Point(0, 50)
        Me.btnExtra.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExtra.Name = "btnExtra"
        Me.btnExtra.Size = New System.Drawing.Size(176, 25)
        Me.btnExtra.TabIndex = 4
        Me.btnExtra.Text = "Servicios Extras"
        Me.btnExtra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExtra.UseVisualStyleBackColor = False
        '
        'btnReservar
        '
        Me.btnReservar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnReservar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReservar.FlatAppearance.BorderSize = 0
        Me.btnReservar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnReservar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReservar.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservar.ForeColor = System.Drawing.Color.LightGray
        Me.btnReservar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReservar.Location = New System.Drawing.Point(0, 25)
        Me.btnReservar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReservar.Name = "btnReservar"
        Me.btnReservar.Size = New System.Drawing.Size(176, 25)
        Me.btnReservar.TabIndex = 2
        Me.btnReservar.Text = "Reservar"
        Me.btnReservar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReservar.UseVisualStyleBackColor = False
        '
        'btnFactura
        '
        Me.btnFactura.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnFactura.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFactura.FlatAppearance.BorderSize = 0
        Me.btnFactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFactura.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFactura.ForeColor = System.Drawing.Color.LightGray
        Me.btnFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFactura.Location = New System.Drawing.Point(0, 0)
        Me.btnFactura.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFactura.Name = "btnFactura"
        Me.btnFactura.Size = New System.Drawing.Size(176, 25)
        Me.btnFactura.TabIndex = 3
        Me.btnFactura.Text = "Factura"
        Me.btnFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFactura.UseVisualStyleBackColor = False
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.PanelBarraTitulo.Controls.Add(Me.btnRestaurar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnMinimizar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnMaximizar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnCerrar)
        Me.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(808, 32)
        Me.PanelBarraTitulo.TabIndex = 0
        '
        'btnExtras
        '
        Me.btnExtras.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnExtras.Controls.Add(Me.PictureBox1)
        Me.btnExtras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnExtras.Location = New System.Drawing.Point(176, 32)
        Me.btnExtras.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExtras.Name = "btnExtras"
        Me.btnExtras.Size = New System.Drawing.Size(632, 423)
        Me.btnExtras.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.ProyectoHotel.My.Resources.Resources.Logo_Hotel1
        Me.PictureBox1.Location = New System.Drawing.Point(235, 113)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(174, 154)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txtUsuarios
        '
        Me.txtUsuarios.FlatAppearance.BorderSize = 0
        Me.txtUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.txtUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtUsuarios.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuarios.ForeColor = System.Drawing.Color.LightGray
        Me.txtUsuarios.Image = Global.ProyectoHotel.My.Resources.Resources.Empleado_31
        Me.txtUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtUsuarios.Location = New System.Drawing.Point(0, 160)
        Me.txtUsuarios.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUsuarios.Name = "txtUsuarios"
        Me.txtUsuarios.Size = New System.Drawing.Size(176, 32)
        Me.txtUsuarios.TabIndex = 10
        Me.txtUsuarios.Text = "      Usuarios"
        Me.txtUsuarios.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.LightGray
        Me.Button2.Image = Global.ProyectoHotel.My.Resources.Resources.salir
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(0, 391)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(176, 32)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "        Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Mantenimiento
        '
        Me.Mantenimiento.FlatAppearance.BorderSize = 0
        Me.Mantenimiento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Mantenimiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Mantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Mantenimiento.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mantenimiento.ForeColor = System.Drawing.Color.LightGray
        Me.Mantenimiento.Image = Global.ProyectoHotel.My.Resources.Resources.Mantenimiento
        Me.Mantenimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Mantenimiento.Location = New System.Drawing.Point(0, 211)
        Me.Mantenimiento.Margin = New System.Windows.Forms.Padding(2)
        Me.Mantenimiento.Name = "Mantenimiento"
        Me.Mantenimiento.Size = New System.Drawing.Size(176, 32)
        Me.Mantenimiento.TabIndex = 4
        Me.Mantenimiento.Text = "           Mantenimiento"
        Me.Mantenimiento.UseVisualStyleBackColor = True
        '
        'btnReservacion
        '
        Me.btnReservacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReservacion.FlatAppearance.BorderSize = 0
        Me.btnReservacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnReservacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnReservacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReservacion.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservacion.ForeColor = System.Drawing.Color.LightGray
        Me.btnReservacion.Image = Global.ProyectoHotel.My.Resources.Resources.Reservaciones1
        Me.btnReservacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReservacion.Location = New System.Drawing.Point(0, 0)
        Me.btnReservacion.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReservacion.Name = "btnReservacion"
        Me.btnReservacion.Size = New System.Drawing.Size(176, 32)
        Me.btnReservacion.TabIndex = 2
        Me.btnReservacion.Text = "       Reservación"
        Me.btnReservacion.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.Color.LightGray
        Me.btnClientes.Image = Global.ProyectoHotel.My.Resources.Resources.Huesped2
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.Location = New System.Drawing.Point(3, 37)
        Me.btnClientes.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(176, 32)
        Me.btnClientes.TabIndex = 0
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.LightGray
        Me.Button1.Image = Global.ProyectoHotel.My.Resources.Resources.Habitacion_1
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(3, 73)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(176, 32)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "         Habitaciones"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnEmpleados
        '
        Me.btnEmpleados.FlatAppearance.BorderSize = 0
        Me.btnEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpleados.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpleados.ForeColor = System.Drawing.Color.LightGray
        Me.btnEmpleados.Image = Global.ProyectoHotel.My.Resources.Resources.Empleado_2
        Me.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmpleados.Location = New System.Drawing.Point(0, 113)
        Me.btnEmpleados.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEmpleados.Name = "btnEmpleados"
        Me.btnEmpleados.Size = New System.Drawing.Size(176, 32)
        Me.btnEmpleados.TabIndex = 1
        Me.btnEmpleados.Text = "      Empleados"
        Me.btnEmpleados.UseVisualStyleBackColor = True
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar.Image = CType(resources.GetObject("btnRestaurar.Image"), System.Drawing.Image)
        Me.btnRestaurar.Location = New System.Drawing.Point(763, 10)
        Me.btnRestaurar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(16, 16)
        Me.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnRestaurar.TabIndex = 2
        Me.btnRestaurar.TabStop = False
        Me.btnRestaurar.Visible = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(736, 10)
        Me.btnMinimizar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(16, 16)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnMinimizar.TabIndex = 0
        Me.btnMinimizar.TabStop = False
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximizar.Image = CType(resources.GetObject("btnMaximizar.Image"), System.Drawing.Image)
        Me.btnMaximizar.Location = New System.Drawing.Point(763, 10)
        Me.btnMaximizar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(16, 16)
        Me.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnMaximizar.TabIndex = 1
        Me.btnMaximizar.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(787, 10)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(16, 16)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.TabStop = False
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 455)
        Me.Controls.Add(Me.btnExtras)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelBarraTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MenuPrincipal"
        Me.Opacity = 0.9R
        Me.Text = "Form1"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelSubmenuMan.ResumeLayout(False)
        Me.PanelSubmenuRes.ResumeLayout(False)
        Me.PanelBarraTitulo.ResumeLayout(False)
        Me.PanelBarraTitulo.PerformLayout()
        Me.btnExtras.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnReservacion As Button
    Friend WithEvents btnEmpleados As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents PanelBarraTitulo As Panel
    Friend WithEvents btnRestaurar As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnMaximizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents Mantenimiento As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PanelSubmenuMan As Panel
    Friend WithEvents btnHorarios As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PanelSubmenuRes As Panel
    Friend WithEvents btnFactura As Button
    Friend WithEvents btnReservar As Button
    Friend WithEvents btnExtras As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnExtra As Button
    Friend WithEvents txtUsuarios As Button
End Class
