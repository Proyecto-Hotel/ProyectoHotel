Imports System.Data.SqlClient

Public Class Clientes
    Dim conexion As Conexion = New Conexion()
    Dim tabla As New DataTable

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtIdentidad.Text = "" Or txtNombre.Text = "" Or txtApellido.Text = "" Or txtTeléfono.Text = "" Or txtCorreo.Text = "" Or txtRTN.Text = "" Then
            MessageBox.Show("Debe llenar todas las casillas ", "Error")
            Exit Sub
        End If

        Dim Identidad, Nombre, Apellido, Correo, Rtn As String
        Dim telefono As Integer

        Identidad = txtIdentidad.Text
        Nombre = txtNombre.Text
        Apellido = txtApellido.Text
        telefono = Val(txtTeléfono.Text)
        Correo = txtCorreo.Text
        Rtn = txtRTN.Text

        Dim temporal As Boolean = conexion.IngresarHuesped(Identidad, Nombre, Apellido, telefono, Correo, Rtn)

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

    Private Sub Limpiar()
        txtIdentidad.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtTeléfono.Clear()
        txtCorreo.Clear()
        txtRTN.Clear()

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If txtIdentidad.Text = "" Or txtNombre.Text = "" Or txtApellido.Text = "" Or txtCorreo.Text = "" Or txtTeléfono.Text = "" Then
            MessageBox.Show("Debe llenar todas las casillas ", "Error")
            Exit Sub
        End If

        Dim Identidad, Nombre, Apellido, Correo, Rtn As String
        Dim telefono As Integer

        Identidad = txtIdentidad.Text
        Nombre = txtNombre.Text
        Apellido = txtApellido.Text
        telefono = txtTeléfono.Text
        Correo = txtCorreo.Text


        If txtRTN.Text = "" Then
            Rtn = "NULL"
            MsgBox(Rtn)
        Else
            Rtn = txtRTN.Text
        End If


        Dim temporal As Boolean = conexion.actualizarHuesped(Identidad,Nombre,Apellido,telefono,Correo,Rtn)

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

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtIdentidad.Text = "" Then
            MessageBox.Show("Debe Ingresar la Identidad del Huesped", "Error")
            Exit Sub
        End If

        Dim Identidad As String
        Identidad = txtIdentidad.Text

        Try
            Dim salir As String

            salir = MsgBox("¿Esta seguro que desea Eliminar el Cliente?", 36, "SALIR")
            If salir = 6 Then
                If conexion.EliminarHuesped(Identidad) Then
                    MsgBox("Usuario Eliminado")
                End If
            Else
                Exit Sub
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
                tabla = conexion.ListarHuesped()
                If tabla.Rows.Count <> 0 Then
                    dtgCliente.DataSource = tabla
                Else
                    dtgCliente.DataSource = Nothing
                End If
            Catch ex As Exception
                MsgBox("Error al Listar")
            End Try

        Else
            Try
                Dim Identidad As String

                Identidad = txtBuscar.Text

                tabla = conexion.consultarHuesped(Identidad)
                If tabla.Rows.Count <> 0 Then
                    dtgCliente.DataSource = tabla
                Else
                    dtgCliente.DataSource = Nothing
                End If
            Catch ex As Exception
                MsgBox("Error al consultar el Cliente")
            End Try
        End If
    End Sub
End Class