Public Class LoginUsuario
    Dim conexion As New Conexion()

    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Abrirconexion()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        IngresarMenu()
    End Sub

    Private Sub IngresarMenu()
        Dim userName, Psw As String

        userName = txtUsuario.Text
        Psw = txtPsw.Text

        Try
            If conexion.ValidarUsuario(userName, Psw) Then
                MsgBox("Ha ingresado correctamente")
                MenuPrincipal.Show()
                Me.Hide()
            Else
                MsgBox("Usuario/Contraseña invalido")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub btnCrearUsuario_Click(sender As Object, e As EventArgs) Handles btnCrearUsuario.Click
        PanelCrearUsuario.Visible = True
        PanelLogin.Visible = False
    End Sub

    Private Sub btnInsertarUsuario_Click(sender As Object, e As EventArgs) Handles btnInsertarUsuario.Click
        IngresarUsuario()
        conexion.conexion.Close()
        PanelCrearUsuario.Visible = False
        PanelLogin.Visible = True
        MsgBox(txtIdentidad.Text)
    End Sub

    Private Sub IngresarUsuario()
        Dim userName, Psw, Identidad As String
        Dim TipoEmpleado As Integer

        userName = txtUsuario2.Text
        Psw = txtPsw2.Text
        Identidad = txtIdentidad.Text
        TipoEmpleado = Val(txtTipoEmpleado.Text)

        Try
            If conexion.InsertarUsuario(userName, Psw, Identidad, TipoEmpleado) Then
                MessageBox.Show("Usuario Registrado Exitosamente", "REGISTRADO!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al Registrarse, Verifique los Datos Ingresados", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexion.conexion.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class