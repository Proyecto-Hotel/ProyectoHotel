Imports System.Data.SqlClient
Public Class Empleados
    Dim conexion As Conexion = New Conexion()
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If txtBuscar.Text = "" Then

            Try
                Dim tabla As DataTable
                tabla = Conexion.ListarHabitaciones()
                If tabla.Rows.Count <> 0 Then
                    DataHabitaciones.DataSource = tabla
                Else
                    DataHabitaciones.DataSource = Nothing
                End If
            Catch ex As Exception
                MsgBox("Error al consultar")
            End Try
        ElseIf IsNumeric(txtBuscar.Text) Then

            Try
                Dim UserName As String

                UserName = Int(Val(txtBuscar.Text))

                tabla = Conexion.ConsultarHabitaciones(UserName)
                If tabla.Rows.Count <> 0 Then
                    DataHabitaciones.DataSource = tabla
                Else
                    DataHabitaciones.DataSource = Nothing
                End If
            Catch ex As Exception
                MsgBox("Error al consultar el Usuario")
            End Try
        End If
    End Sub
End Class