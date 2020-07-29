Public Class Habitaciones
    Dim conexion As Conexion = New Conexion()
    Dim tabla As New DataTable


    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs)
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

    Private Sub BtnListar_Click(sender As Object, e As EventArgs)
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

    Private Sub Habitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataHabitaciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataHabitaciones_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

    End Sub
#End Region
End Class