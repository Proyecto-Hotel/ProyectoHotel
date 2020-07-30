Imports System.Data.SqlClient

Public Class Habitaciones
    Dim conexion As Conexion = New Conexion()
    Dim tabla As New DataTable

#Region "Funciones"
    Private Sub Limpiar()
        TxtIdHabitacion.Clear()
        txtPrecio.Clear()
        cmbTipo.Text = ""
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If TxtIdHabitacion.Text = "" Or txtPrecio.Text = "" Or txtPrecio.Text = "" Or cmbTipo.Text = "" Then
            MessageBox.Show("Debe llenar todas las casillas ", "Error")
            Exit Sub
        End If
        Dim IdHabitacion, Precio As Integer
        Dim TipoH As String
        IdHabitacion = Int(Val(TxtIdHabitacion.Text))
        Precio = Int(Val(txtPrecio.Text))
        TipoH = cmbTipo.Text
        Dim temporal As Boolean = conexion.insertarHabitacion(IdHabitacion, TipoH, Precio)

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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If txtBuscar.Text = "" Then

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
        ElseIf IsNumeric(txtBuscar.Text) Then

            Try
                Dim UserName As String

                UserName = Int(Val(txtBuscar.Text))

                tabla = conexion.ConsultarHabitaciones(UserName)
                If tabla.Rows.Count <> 0 Then
                    DataHabitaciones.DataSource = tabla
                Else
                    DataHabitaciones.DataSource = Nothing
                End If
            Catch ex As Exception
                MsgBox("Error al consultar el Usuario")
            End Try
        Else
            MessageBox.Show("El codigo de la Habitacion tiene que ser Numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim Precio, ID As Integer
        Dim Tipo As String
        Precio = Int(Val(txtPrecio.Text))
        Tipo = cmbTipo.Text
        ID = Int(Val(TxtIdHabitacion.Text))
        Try
            If conexion.actualizarHabitaciones(ID, Precio, Tipo) Then
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

    Private Sub Habitaciones_Load(sender As Object, e As EventArgs) Handles Me.Load
        TxtIdHabitacion.Focus()
        Dim strcomando As String
        strcomando = "select * from tipoHabitaciones"
        Dim adapter As SqlDataAdapter
        Dim data As DataSet
        adapter = New SqlDataAdapter(strcomando, conexion.conexion)
        data = New DataSet
        adapter.Fill(data)
        cmbTipo.DataSource = data.Tables(0)
        cmbTipo.DisplayMember = "Nombre"
        Limpiar()
    End Sub

#End Region
End Class