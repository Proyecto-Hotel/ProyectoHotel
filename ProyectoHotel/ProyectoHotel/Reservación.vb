Imports System.Data.SqlClient
Public Class Reservación
    Dim IDate, FDate As Date
    Dim conexion As New Conexion
    Dim Habitacion, cliente, Dates As Integer
    Private Sub Reservacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conexion.Open()
        llenar()
        dtv.DataSource = conexion.dv
        MonthCalendar2.CalendarDimensions = New Size(2, 2)
        cbEstado.SelectedIndex = 0
        Dim strcomando As String
        strcomando = "Select * from Reservacio"
        Dim adapter As SqlDataAdapter
        Dim data As DataSet
        adapter = New SqlDataAdapter(strcomando, conexion.conexion)
        data = New DataSet
        adapter.Fill(data)
        cbCliente.DataSource = data.Tables("dbo.Huesped")
        cbCliente.DisplayMember = "Nombre"

        cbHabitacion.DataSource = data.Tables("dbo.tipoHabitacion")
        cbHabitacion.DisplayMember = "Nombre"
    End Sub

    Private Sub dtv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtv.CellContentClick
        Dim dgv As DataGridViewRow = dtv.Rows(e.RowIndex)
        txtID.Text = dgv.Cells(0).Value.ToString()
        cbCliente.SelectedItem = dgv.Cells(1).Value.ToString()
        cbHabitacion.SelectedItem = dgv.Cells(2).Value.ToString()
        txtFechai.Text = dgv.Cells(3).Value.ToString()
        txtFechaF.Text = dgv.Cells(4).Value.ToString()
        txtCantidad.Text = dgv.Cells(5).Value.ToString
        cbEstado.SelectedItem = dgv.Cells(6).Value.ToString()
        txtNum.Text = dgv.Cells(7).Value.ToString()

    End Sub
    Public Sub llenar()
        conexion.Llenar("select r.IdReservacion as 'Codigo de Reservacion', c.Nombre as 'Nombre',th.Nombre as 'Habitacion',r.FechaI as 'Fecha de Inicio',r.FechaF as 'Fecha Final',r.CantidadDias as 'Dias',r.Estado as 'Esatdo', r.NumTarjeta as 'Numero de Tarjeta' from dbo.reservacion as r inner join dbo.Huesped as c on c.Identidad = r.IdHuesped inner join dbo.Habitaciones as h on r.IdHabitacion = h.IdHabitacion inner join dbo.tipoHabitaciones as th on th.IdTipoHabitaciones = h.IdTipoHabitacion", "dbo.Reservacion, dbo.Huesped, dbo.habitaciones, dbo.tipoHabitaciones")
        dtv.DataSource = conexion.ds.Tables("dbo.Reservacion, dbo.Huesped, dbo.habitaciones, dbo.tipoHabitaciones")
    End Sub
    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Habitacion = cbHabitacion.SelectedIndex + 1
        cliente = cbCliente.SelectedIndex + 1

        If txtCantidad.Text = "" Or txtFechaF.Text = "" Or txtNum.Text = "" Or cbCliente.Text = "" Or txtFechai.Text = "" Or cbEstado.Text = "" Or cbHabitacion.Text = "" Then
            MessageBox.Show("Debe llenar todas las casillas ", "Error")
            Exit Sub
        End If
        Dim IdReservacion As Integer
        Dim NumTarjeta As String
        IdReservacion = txtID.Text
        NumTarjeta = txtNum.Text
        Dim temporal As Boolean = conexion.InsertarReservacion(IdReservacion, IDate, FDate, Dates, NumTarjeta, cliente, Habitacion)

        Try

            If temporal Then
                MsgBox("Ingresado correctamente")
                llenar()
            Else
                MsgBox("Error al Ingresar")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            limpiar()
        End Try
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Habitacion = cbHabitacion.SelectedIndex + 1
        cliente = cbCliente.SelectedIndex + 1
        If txtCantidad.Text = "" Or txtFechaF.Text = "" Or txtNum.Text = "" Or cbCliente.Text = "" Or txtFechai.Text = "" Or cbEstado.Text = "" Or cbHabitacion.Text = "" Then
            MessageBox.Show("Debe llenar todas las casillas ", "Error")
            Exit Sub
        End If
        Dim IdReservacion As Integer
        Dim NumTarjeta As String
        IdReservacion = txtID.Text
        NumTarjeta = txtNum.Text

        Try
            If conexion.actualizarReservaciones(IdReservacion, IDate, FDate, Dates, NumTarjeta, cliente, Habitacion) Then
                MsgBox("Actualizado correctamente")
            Else
                MsgBox("Error al Actualizar")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            limpiar()
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtID.Text = "" Then
            MessageBox.Show("Debe Seleccionar el Id de Reservacion", "Error")
            Exit Sub
        End If

        Dim IdReservacion As String
        IdReservacion = txtID.Text
        Try
            Dim salir As String

            salir = MsgBox("¿Esta seguro que desea Eliminar la reservacion", 36, "SALIR")
            If salir = 6 Then
                If conexion.EliminarReservacion(IdReservacion) Then
                    MsgBox("Reservacion Eliminado")
                End If
            Else
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub limpiar()
        txtCantidad.Clear()
        txtFechaF.Clear()
        txtFechai.Clear()
        cbCliente.SelectedIndex = 0
        txtNum.Clear()
        cbEstado.SelectedIndex = 0
        cbHabitacion.SelectedIndex() = 0
    End Sub

    Private Sub cbHabitacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbHabitacion.SelectedIndexChanged

    End Sub

    Private Sub MonthCalendar2_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar2.DateChanged
        IDate = MonthCalendar2.SelectionStart
        FDate = MonthCalendar2.SelectionEnd
        txtFechai.Text = IDate
        txtFechaF.Text = FDate
        Dates = DateDiff(DateInterval.Day, IDate, FDate)
        txtCantidad.Text = Dates
    End Sub

#Region "Validaciones"
    Private Sub txtFechai_Enter(sender As Object, e As EventArgs) Handles txtFechai.Enter
        If (txtFechai.Text = "Fecha Inicio") Then
            txtFechai.Text = ""
        End If
    End Sub

    Private Sub txtFechai_Leave(sender As Object, e As EventArgs) Handles txtFechai.Leave
        If (txtFechai.Text = "") Then
            txtFechai.Text = "Fecha Inicio"
        End If
    End Sub

    Private Sub txtFechaF_TextChanged(sender As Object, e As EventArgs) Handles txtFechaF.TextChanged

    End Sub

    Private Sub txtFechaF_Enter(sender As Object, e As EventArgs) Handles txtFechaF.Enter
        If (txtFechaF.Text = "Fecha Final") Then
            txtFechaF.Text = ""
        End If
    End Sub

    Private Sub txtFechaF_Leave(sender As Object, e As EventArgs) Handles txtFechaF.Leave
        If (txtFechaF.Text = "") Then
            txtFechaF.Text = "Fecha Final"
        End If
    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged

    End Sub

    Private Sub txtCantidad_Enter(sender As Object, e As EventArgs) Handles txtCantidad.Enter
        If (txtCantidad.Text = "Cantidad Días") Then
            txtFechaF.Text = ""
        End If
    End Sub

    Private Sub txtCantidad_Leave(sender As Object, e As EventArgs) Handles txtCantidad.Leave
        If (txtFechaF.Text = "") Then
            txtFechaF.Text = "Cantidad Días"
        End If
    End Sub

    Private Sub txtNum_TextChanged(sender As Object, e As EventArgs) Handles txtNum.TextChanged

    End Sub

    Private Sub txtNum_Enter(sender As Object, e As EventArgs) Handles txtNum.Enter
        If (txtNum.Text = "Número de Tarjeta") Then
            txtNum.Text = ""
        End If
    End Sub

    Private Sub txtNum_Leave(sender As Object, e As EventArgs) Handles txtNum.Leave
        If (txtNum.Text = "") Then
            txtNum.Text = "Número de Tarjeta"
        End If
    End Sub
#End Region
End Class