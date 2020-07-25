Imports System.Da
Public Class Habitaciones
    Dim conexion As Conexion = New Conexion()
    Dim tabla As New DataTable


    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If TxtIdHabitacion.Text = "" Or txtPrecio.Text = "" Or txtPrecio.Text = "" Or cmbTipo.Text = "" Then
            MessageBox.Show("Debe llenar todas las casillas ", "Error")
            Exit Sub
        End If
        Dim IdHabitacion, Precio, TipoH As Integer

        IdHabitacion = Int(Val(TxtIdHabitacion.Text))
        Precio = Int(Val(txtPrecio.Text))
        TipoH = cmbTipo.SelectedIndex
        Dim temporal As Boolean = conexion.insertarHabitacion(IdHabitacion, 1, Precio)

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
#Region "Funciones"
    Private Sub Limpiar()
        TxtIdHabitacion.Clear()
        txtPrecio.Clear()
        cmbTipo.Text = ""
    End Sub

    Private Sub BtnListar_Click(sender As Object, e As EventArgs) Handles BtnListar.Click
        Try
            Dim tabla As DataTable
            tabla = conexion.ListarHabitaciones()
            If tabla.Rows.Count <> 0 Then
                DataHabitaciones.DataSource = tabla
            Else
                DataHabitaciones.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox("Error al consultar")
        End Try
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Dim Id, Precio, tipo As Integer
        Id = Int(Val(TxtIdHabitacion.Text))
        Precio = Int(txtPrecio.Text)
        tipo = cmbTipo.SelectedIndex

        Try
            If conexion.actualizarHabitaciones(Id, Precio, 2) Then
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

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            Dim tabla As DataTable
            Dim Id As Integer
            Id = Int(Val(TxtIdHabitacion.Text))
            tabla = conexion.ConsultarHabitaciones(Id)
            If tabla.Rows.Count <> 0 Then
                DataHabitaciones.DataSource = tabla
            Else
                DataHabitaciones.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox("Error al consultar")
        End Try
    End Sub
#End Region
End Class