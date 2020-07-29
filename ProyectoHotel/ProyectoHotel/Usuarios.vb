Public Class Usuarios
    Dim conexion As Conexion = New Conexion()
    Dim tabla As New DataTable
    Private Sub BtnListar_Click(sender As Object, e As EventArgs) Handles BtnListar.Click
        Try
            tabla = conexion.ListarUsuarios()
            If tabla.Rows.Count <> 0 Then
                DataHabitaciones.DataSource = tabla
            Else
                DataHabitaciones.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox("Error al Listar")
        End Try
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        If txtUserName.Text = "" Or txtUserName.Text = "" Or cmbTipo.Text = "" Or TxtPassword.Text = "" Then
            MessageBox.Show("Debe llenar todas las casillas ", "Error")
            Exit Sub
        End If
        Dim UserName, Password As String
        Dim TipoU As Integer

        UserName = txtUserName.Text
        Password = TxtPassword.Text
        TipoU = cmbTipo.SelectedIndex
        Dim temporal As Boolean = conexion.insertarHabitacion(UserName, Password, TipoU)

        Try

            If temporal Then
                MsgBox("Ingresado correctamente")
            Else
                MsgBox("Error al Ingresar")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Limpiar()
        End Try
    End Sub
    Private Sub Limpiar()
        txtUserName.Clear()
        TxtPassword.Clear()
        cmbTipo.Text = ""
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Dim UserName, Password As String
        Dim TipoU As Integer

        UserName = txtUserName.Text
        Password = TxtPassword.Text
        TipoU = cmbTipo.SelectedIndex

        Try
            If conexion.actualizarUsuarios(UserName, Password, 2) Then
                MsgBox("Actualizado correctamente")
            Else
                MsgBox("Error al Actualizar")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Limpiar()
        End Try
    End Sub
End Class