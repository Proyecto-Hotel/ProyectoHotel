Imports System.Data.SqlClient
Public Class Conexion
    Public conexion As SqlConnection = New SqlConnection("Data Source = CHANDIA;Initial Catalog=ProyectoHotel;Integrated Security=True")

    Public Sub Abrirconexion()
        Try
            conexion.Open()
        Catch ex As Exception
            MsgBox("Error al conectar")
        Finally
            conexion.Close()
        End Try

    End Sub
    Public Function InsertarTipoEmpleado(Puesto As String, Sueldo As Integer) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("InsertarTipoEmpleado", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Puesto", Puesto)
            cmd.Parameters.AddWithValue("@Sueldo", Sueldo)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function IngresarTipoHabitacion(Nombre As String, Capacidad As Integer) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("IngresarTipoHabitacion", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Nombre", Nombre)
            cmd.Parameters.AddWithValue("@Capacidad", Capacidad)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function IngresarHuesped(Identidad As String, Nombre As String, Apellido As String,
                                    Telefono As Integer, Correo As String, RTN As String) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("IngresarHuesped", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Identidad", Identidad)
            cmd.Parameters.AddWithValue("@Nombre", Nombre)
            cmd.Parameters.AddWithValue("@Apellido", Apellido)
            cmd.Parameters.AddWithValue("@Telefono", Telefono)
            cmd.Parameters.AddWithValue("@Correo", Correo)
            cmd.Parameters.AddWithValue("@RTN", RTN)


            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function InsertarHorarios(Horarios As String, Descripcion As String) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("InsertarHorarios", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Horarios", Horarios)
            cmd.Parameters.AddWithValue("@DEscripcion", Descripcion)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function insertarEmpleados(Identidad As String, Nombre As String, Apellido As String,
                                     Telefono As Integer, Correo As String, RTN As String, idTipoEmpleado As Integer, idHorario As Integer) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("insertarEmpleados", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Identidad", Identidad)
            cmd.Parameters.AddWithValue("@Nombre", Nombre)
            cmd.Parameters.AddWithValue("@Apellido", Apellido)
            cmd.Parameters.AddWithValue("@Telefono", Telefono)
            cmd.Parameters.AddWithValue("@Correo", Correo)
            cmd.Parameters.AddWithValue("@RTN", RTN)
            cmd.Parameters.AddWithValue("@idTipoEmpleado", idTipoEmpleado)
            cmd.Parameters.AddWithValue("@idHorario", idHorario)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function insertarHabitacion(idHabitacion As Integer, idTipoHabitacion As Integer, Precio As Integer) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("insertarHabitacion", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idHabitacion", idHabitacion)
            cmd.Parameters.AddWithValue("@idTipoHabitacion", idTipoHabitacion)
            cmd.Parameters.AddWithValue("@Precio", Precio)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function InsertarUsuario(userName As Integer, Psw As Integer, Identidad As Integer) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("InsertarUsuario", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@UserName", userName)
            cmd.Parameters.AddWithValue("@Psw", Psw)
            cmd.Parameters.AddWithValue("@Identidad", Identidad)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function actualizarEmpleados(Identidad As String, Nombre As String, Apellido As String,
                                        Telefono As Integer, Correo As String, RTN As String, idTipoEmpleado As Integer, idHorario As Integer) As Boolean

        Try
            conexion.Open()
            Dim cmd As New SqlCommand("actualizarEmpleados", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Identidad", Identidad)
            cmd.Parameters.AddWithValue("@Nombre", Nombre)
            cmd.Parameters.AddWithValue("@Apellido", Apellido)
            cmd.Parameters.AddWithValue("@Telefono", Telefono)
            cmd.Parameters.AddWithValue("@Correo", Correo)
            cmd.Parameters.AddWithValue("@RTN", RTN)
            cmd.Parameters.AddWithValue("@idTipoEmpleado", idTipoEmpleado)
            cmd.Parameters.AddWithValue("@idHorario", idHorario)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error al Actualizar Cliente")
            Return False
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function actualizarHabitaciones(idHabitacion As Integer, Precio As Integer, IdTipoHabitacion As String) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("actualizarHabitaciones", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idHabitacion", idHabitacion)
            cmd.Parameters.AddWithValue("@Precio", Precio)
            cmd.Parameters.AddWithValue("@IdTipoHabitacion", IdTipoHabitacion)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function actualizarHorarios(idHorarios As Integer, Horarios As String, Descripcion As String) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("actualizarHorarios", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idHorarios", idHorarios)
            cmd.Parameters.AddWithValue("@Horarios", Horarios)
            cmd.Parameters.AddWithValue("@DEscripcion", Descripcion)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function actualizarHuesped(Identidad As String, Nombre As String, Apellido As String,
                                    Telefono As Integer, Correo As String, RTN As String) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("actualizarHuesped", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Identidad", Identidad)
            cmd.Parameters.AddWithValue("@Nombre", Nombre)
            cmd.Parameters.AddWithValue("@Apellido", Apellido)
            cmd.Parameters.AddWithValue("@Telefono", Telefono)
            cmd.Parameters.AddWithValue("@Correo", Correo)
            cmd.Parameters.AddWithValue("@RTN", RTN)


            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function actualizarTipoEmpleado(IdTipoEmpleado As Integer, Puesto As String, Sueldo As Integer) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("actualizarTipoEmpleado", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@IdTipoEmpleado", IdTipoEmpleado)
            cmd.Parameters.AddWithValue("@Puesto", Puesto)
            cmd.Parameters.AddWithValue("@Sueldo", Sueldo)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function actualizarTipoHabitacion(IdTipoHabitaciones As Integer, Nombre As String, Capacidad As Integer) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("actualizarTipoHabitacion", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@IdTipoHabitaciones", IdTipoHabitaciones)
            cmd.Parameters.AddWithValue("@Nombre", Nombre)
            cmd.Parameters.AddWithValue("@Capacidad", Capacidad)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function actualizarUsuarios(userName As String, Psw As String, Identidad As Integer) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("actualizarUsuarios", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@UserName", userName)
            cmd.Parameters.AddWithValue("@Psw", Psw)
            cmd.Parameters.AddWithValue("@Identidad", Identidad)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function ListarHuesped()
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("ListarHuesped", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            If cmd.ExecuteNonQuery Then
                Dim Tabla As New DataTable
                Dim adaptador As New SqlDataAdapter(cmd)
                adaptador.Fill(Tabla)
                Return Tabla
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
            MsgBox("Error al Listar Huesped")
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function consultarHuesped(Identidad As String)
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("consultarHuesped", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Identidad", Identidad)

            If cmd.ExecuteNonQuery <> 0 Then
                Dim Tabla As New DataTable
                Dim adaptador As New SqlDataAdapter(cmd)
                adaptador.Fill(Tabla)
                Return Tabla
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
            MsgBox("Error al consultar Huesped")
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function ListarEmpleados()
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("ListarEmpleados", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            If cmd.ExecuteNonQuery Then
                Dim Tabla As New DataTable
                Dim adaptador As New SqlDataAdapter(cmd)
                adaptador.Fill(Tabla)
                Return Tabla
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
            MsgBox("Error al Listar Empleado")
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function ConsultarEmpleados(Identidad As String)

        Try
            conexion.Open()
            Dim cmd As New SqlCommand("ConsultarEmpleados", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Identidad", Identidad)

            If cmd.ExecuteNonQuery > 0 Then
                Dim Tabla As New DataTable
                Dim adaptador As New SqlDataAdapter(cmd)
                adaptador.Fill(Tabla)
                Return Tabla
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
            MsgBox("Error al COnsultar Empleado")
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function ListarHabitaciones()
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("ListarHabitaciones", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            If cmd.ExecuteNonQuery Then
                Dim Tabla As New DataTable
                Dim adaptador As New SqlDataAdapter(cmd)
                adaptador.Fill(Tabla)
                Return Tabla
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
            MsgBox("Error al Listar Habitaciones")
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function ConsultarHabitaciones(IdHabitacion As Integer)

        Try
            conexion.Open()
            Dim cmd As New SqlCommand("ConsultarHabitaciones", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@IdHabitacion", IdHabitacion)

            If cmd.ExecuteNonQuery <> 0 Then
                Dim Tabla As New DataTable
                Dim adaptador As New SqlDataAdapter(cmd)
                adaptador.Fill(Tabla)
                Dim x As Integer
                x = Tabla.Rows.Count
                Return Tabla
            Else
                Return -1
            End If
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
            MsgBox("Error al Consultar Habitación")
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function ConsultarTipoHabitaciones()
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("ConsultarTipoHabitaciones", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            If cmd.ExecuteNonQuery Then
                Dim Tabla As New DataTable
                Dim adaptador As New SqlDataAdapter(cmd)
                adaptador.Fill(Tabla)
                Return Tabla
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
            MsgBox("Error al Listar Tipo Habitaciones")
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function ConsultarTipoEmpleados()
        Try
            conexion.Open()
            Dim cmd As New SqlCommand(" ConsultarTipoEmpleados", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            If cmd.ExecuteNonQuery Then
                Dim Tabla As New DataTable
                Dim adaptador As New SqlDataAdapter(cmd)
                adaptador.Fill(Tabla)
                Return Tabla
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
            MsgBox("Error al Listar Tipo Empleados")
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function ListarUsuarios()
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("ListarUsuarios", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            If cmd.ExecuteNonQuery Then
                Dim Tabla As New DataTable
                Dim adaptador As New SqlDataAdapter(cmd)
                adaptador.Fill(Tabla)
                Return Tabla
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
            MsgBox("Error al Listar Usuarios")
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function ConsultarUsuario(UserName As String)

        Try
            conexion.Open()
            Dim cmd As New SqlCommand("ConsultarUsuario", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@UserName", UserName)

            If cmd.ExecuteNonQuery > 0 Then
                Dim Tabla As New DataTable
                Dim adaptador As New SqlDataAdapter(cmd)
                adaptador.Fill(Tabla)
                Return Tabla
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
            MsgBox("Error al COnsultar Usuario")
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function EliminarEmpleado(Identidad As String) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("EliminarEmpleado", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Identidad", Identidad)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error al eliminar Empleado")
            Return False
        Finally
            conexion.Close()
        End Try

    End Function
    Public Function EliminarHuesped(Identidad As String) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("EliminarHuesped", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Identidad", Identidad)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error al eliminar Huesped")
            Return False
        Finally
            conexion.Close()
        End Try

    End Function
    Public Function EliminarReservacion(IdReservacion As Integer) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("EliminarReservacion", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@IdReservacion", IdReservacion)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error al eliminar Reservación")
            Return False
        Finally
            conexion.Close()
        End Try

    End Function
    Public Function EliminarTipoEmpleado(id As Integer) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("EliminarTipoEmpleado", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id", id)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error al eliminar Tipo Empleado")
            Return False
        Finally
            conexion.Close()
        End Try

    End Function
    Public Function EliminarUsuario(UserName As String) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("EliminarUsuario", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@UserName", UserName)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error al eliminar Tipo Empleado")
            Return False
        Finally
            conexion.Close()
        End Try

    End Function

End Class
