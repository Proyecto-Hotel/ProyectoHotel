Imports System.Data.SqlClient

Public Class Usuarios
    Dim conexion As Conexion = New Conexion()
    Dim tabla As New DataTable


    Private Sub Limpiar()
        txtUserName.Clear()
        TxtPassword.Clear()
        txtIdentidad.clear()
        cmbTipo.Text = ""
    End Sub

    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUserName.Focus()
        Dim strcomando As String
        strcomando = "Select * from TipoEmpleado"
        Dim adapter As SqlDataAdapter
        Dim data As DataSet
        adapter = New SqlDataAdapter(strcomando, conexion.conexion)
        data = New DataSet
        adapter.Fill(data)
        cmbTipo.DataSource = data.Tables(0)
        cmbTipo.DisplayMember = "Puesto"
        Limpiar()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If txtUserName.Text = "" Then
            MessageBox.Show("Debe Ingresar el Nombre del Usuario", "Error")
            Exit Sub
        End If

        Dim UserName As String
        UserName = txtUserName.Text
        Try
            Dim salir As String

            salir = MsgBox("¿Esta seguro que desea Eliminar el Usuario?", 36, "SALIR")
            If salir = 6 Then
                If conexion.EliminarUsuario(UserName) Then
                    MsgBox("Usuario Eliminado")
                End If
            Else
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtUserName.Text = "" Or txtUserName.Text = "" Or cmbTipo.Text = "" Or TxtPassword.Text = "" Or txtUserName.Text = "" Then
            MessageBox.Show("Debe llenar todas las casillas ", "Error")
            Exit Sub
        End If
        Dim UserName, Password, Identidad, TipoU As String

        UserName = txtUserName.Text
        Password = TxtPassword.Text
        Identidad = txtIdentidad.Text
        TipoU = cmbTipo.Text
        Dim temporal As Boolean = conexion.InsertarUsuario(UserName, Password, Identidad, TipoU)
        Try

            If temporal = True Then
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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If txtBuscar.Text = "" Then
            Try
                tabla = conexion.ListarUsuarios()
                If tabla.Rows.Count <> 0 Then
                    dtgEmpleado.DataSource = tabla
                Else
                    dtgEmpleado.DataSource = Nothing
                End If
            Catch ex As Exception
                MsgBox("Error al Listar")
            End Try
        Else

            Try
                Dim UserName As String

                UserName = txtBuscar.Text

                tabla = conexion.ConsultarUsuario(UserName)
                If tabla.Rows.Count <> 0 Then
                    dtgEmpleado.DataSource = tabla
                Else
                    dtgEmpleado.DataSource = Nothing
                End If
            Catch ex As Exception
                MsgBox("Error al consultar el Usuario")
            End Try
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim UserName, Password As String

        UserName = txtUserName.Text
        Password = TxtPassword.Text

        Try
            If conexion.actualizarUsuarios(UserName, Password) Then
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

    Private Sub Usuarios_Invalidated(sender As Object, e As InvalidateEventArgs) Handles Me.Invalidated

    End Sub
End Class