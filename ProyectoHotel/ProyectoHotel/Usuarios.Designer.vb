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
        Me.PanelLogin = New System.Windows.Forms.Panel()
        Me.btnCrearUsuario = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPsw = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelCrearUsuario = New System.Windows.Forms.Panel()
        Me.txtTipoEmpleado = New System.Windows.Forms.MaskedTextBox()
        Me.txtIdentidad = New System.Windows.Forms.MaskedTextBox()
        Me.btnInsertarUsuario = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPsw2 = New System.Windows.Forms.TextBox()
        Me.Usuario = New System.Windows.Forms.Label()
        Me.txtUsuario2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PanelLogin.SuspendLayout()
        Me.PanelCrearUsuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelLogin
        '
        Me.PanelLogin.Controls.Add(Me.btnCrearUsuario)
        Me.PanelLogin.Controls.Add(Me.Label4)
        Me.PanelLogin.Controls.Add(Me.btnLogin)
        Me.PanelLogin.Controls.Add(Me.txtPsw)
        Me.PanelLogin.Controls.Add(Me.Label1)
        Me.PanelLogin.Controls.Add(Me.txtUsuario)
        Me.PanelLogin.Controls.Add(Me.Label2)
        Me.PanelLogin.Controls.Add(Me.Label3)
        Me.PanelLogin.Location = New System.Drawing.Point(12, 12)
        Me.PanelLogin.Name = "PanelLogin"
        Me.PanelLogin.Size = New System.Drawing.Size(336, 361)
        Me.PanelLogin.TabIndex = 7
        '
        'btnCrearUsuario
        '
        Me.btnCrearUsuario.Location = New System.Drawing.Point(128, 310)
        Me.btnCrearUsuario.Name = "btnCrearUsuario"
        Me.btnCrearUsuario.Size = New System.Drawing.Size(75, 37)
        Me.btnCrearUsuario.TabIndex = 7
        Me.btnCrearUsuario.Text = "Crear Usuario"
        Me.btnCrearUsuario.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(109, 282)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "No tienes un usuario?"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(128, 219)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Ingr&esar"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtPsw
        '
        Me.txtPsw.Location = New System.Drawing.Point(124, 168)
        Me.txtPsw.Name = "txtPsw"
        Me.txtPsw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPsw.Size = New System.Drawing.Size(100, 20)
        Me.txtPsw.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Perpetua Titling MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOGIN"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(124, 103)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contraseña"
        '
        'PanelCrearUsuario
        '
        Me.PanelCrearUsuario.Controls.Add(Me.txtTipoEmpleado)
        Me.PanelCrearUsuario.Controls.Add(Me.txtIdentidad)
        Me.PanelCrearUsuario.Controls.Add(Me.btnInsertarUsuario)
        Me.PanelCrearUsuario.Controls.Add(Me.Label8)
        Me.PanelCrearUsuario.Controls.Add(Me.Label9)
        Me.PanelCrearUsuario.Controls.Add(Me.Label7)
        Me.PanelCrearUsuario.Controls.Add(Me.txtPsw2)
        Me.PanelCrearUsuario.Controls.Add(Me.Usuario)
        Me.PanelCrearUsuario.Controls.Add(Me.txtUsuario2)
        Me.PanelCrearUsuario.Controls.Add(Me.Label5)
        Me.PanelCrearUsuario.Location = New System.Drawing.Point(10, 10)
        Me.PanelCrearUsuario.Name = "PanelCrearUsuario"
        Me.PanelCrearUsuario.Size = New System.Drawing.Size(330, 376)
        Me.PanelCrearUsuario.TabIndex = 8
        Me.PanelCrearUsuario.Visible = False
        '
        'txtTipoEmpleado
        '
        Me.txtTipoEmpleado.Location = New System.Drawing.Point(158, 283)
        Me.txtTipoEmpleado.Mask = "999"
        Me.txtTipoEmpleado.Name = "txtTipoEmpleado"
        Me.txtTipoEmpleado.Size = New System.Drawing.Size(31, 20)
        Me.txtTipoEmpleado.TabIndex = 16
        Me.txtTipoEmpleado.ValidatingType = GetType(Integer)
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Location = New System.Drawing.Point(128, 223)
        Me.txtIdentidad.Mask = "0000-0000-00000"
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(89, 20)
        Me.txtIdentidad.TabIndex = 15
        '
        'btnInsertarUsuario
        '
        Me.btnInsertarUsuario.Location = New System.Drawing.Point(136, 324)
        Me.btnInsertarUsuario.Name = "btnInsertarUsuario"
        Me.btnInsertarUsuario.Size = New System.Drawing.Size(75, 37)
        Me.btnInsertarUsuario.TabIndex = 8
        Me.btnInsertarUsuario.Text = "Crear Usuario"
        Me.btnInsertarUsuario.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(149, 207)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Identidad"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(119, 266)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Id Tipo de Empleado"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(142, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Contraseña"
        '
        'txtPsw2
        '
        Me.txtPsw2.Location = New System.Drawing.Point(121, 170)
        Me.txtPsw2.Name = "txtPsw2"
        Me.txtPsw2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPsw2.Size = New System.Drawing.Size(100, 20)
        Me.txtPsw2.TabIndex = 11
        '
        'Usuario
        '
        Me.Usuario.AutoSize = True
        Me.Usuario.Location = New System.Drawing.Point(152, 106)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(43, 13)
        Me.Usuario.TabIndex = 10
        Me.Usuario.Text = "Usuario"
        '
        'txtUsuario2
        '
        Me.txtUsuario2.Location = New System.Drawing.Point(121, 122)
        Me.txtUsuario2.Name = "txtUsuario2"
        Me.txtUsuario2.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario2.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Perpetua Titling MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(90, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(175, 76)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "  CREAR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "USUARIO"
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 408)
        Me.Controls.Add(Me.PanelLogin)
        Me.Controls.Add(Me.PanelCrearUsuario)
        Me.Name = "Usuarios"
        Me.Text = "Usuarios"
        Me.PanelLogin.ResumeLayout(False)
        Me.PanelLogin.PerformLayout()
        Me.PanelCrearUsuario.ResumeLayout(False)
        Me.PanelCrearUsuario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelLogin As Panel
    Friend WithEvents btnCrearUsuario As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPsw As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelCrearUsuario As Panel
    Friend WithEvents txtTipoEmpleado As MaskedTextBox
    Friend WithEvents txtIdentidad As MaskedTextBox
    Friend WithEvents btnInsertarUsuario As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPsw2 As TextBox
    Friend WithEvents Usuario As Label
    Friend WithEvents txtUsuario2 As TextBox
    Friend WithEvents Label5 As Label
End Class
