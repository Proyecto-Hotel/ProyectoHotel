Imports System.Data.SqlClient
Public Class TipoHabitacion
    Dim conexion As Conexion = New Conexion()
    Dim tabla As New DataTable
    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        If txtNombre.Text = String.Empty Or txtCapacidad.Text = String.Empty Then
            MessageBox.Show("Debe llenar todas las casillas ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim Nombre As String
        Dim Capacidad As Integer

        Nombre = txtNombre.Text
        Capacidad = Int(Val(txtCapacidad.Text))

        Dim temporal As Boolean = conexion.IngresarTipoHabitacion(Nombre, Capacidad)
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
        txtNombre.Clear()
        txtCapacidad.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If txtNombre.Text = String.Empty Or txtCapacidad.Text = String.Empty Then
            MessageBox.Show("Seleccione un Tipo de Habitacion de la Tabla ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim Nombre As String
        Dim Capacidad As Integer

        Nombre = txtNombre.Text
        Capacidad = Int(Val(txtCapacidad.Text))

        Dim temporal As Boolean = conexion.actualizarTipoHabitacion(Variables.Id, Nombre, Capacidad)
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

        Try
            tabla = conexion.ConsultarTipoHabitaciones()
            If tabla.Rows.Count <> 0 Then
                dtgTipoHabitacion.DataSource = tabla
            Else
                dtgTipoHabitacion.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox("Error al Listar")
        End Try

    End Sub

    Private Sub dtgTipoHabitacion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgTipoHabitacion.CellContentClick
        Variables.Id = dtgTipoHabitacion.CurrentRow.Cells(0).Value.ToString
        txtNombre.Text = dtgTipoHabitacion.CurrentRow.Cells(1).Value.ToString
        txtCapacidad.Text = dtgTipoHabitacion.CurrentRow.Cells(2).Value.ToString
    End Sub
End Class