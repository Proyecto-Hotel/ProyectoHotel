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
    Public Function agregarVenta(Puesto As String, Sueldo As Integer) As Boolean
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
            Dim cmd As New SqlCommand("IngresarTipoHabitacion", conexion)
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
    Public Function InsertarHorarios(idHabitacion As Integer, idTipoHabitacion As Integer, Precio As Integer) As Boolean
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
End Class
