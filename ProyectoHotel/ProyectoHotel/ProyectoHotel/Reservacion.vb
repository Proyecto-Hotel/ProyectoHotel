Imports System.Data.SqlClient

Public Class Reservacion
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
        'Try
        'If Me.ValidateChildren And txtCantidad.Text <> String.Empty And IsNumeric(txtCantidad.Text) = True And txtFechai.Text <> String.Empty And txtFechaF.Text <> String.Empty And txtID.Text <> String.Empty Then
        'Dim agregar As String = "insert into dbo.reservacion values('" + txtFechai.Text.ToString + "','" + txtFechaF.Text.ToString + "','" + txtCantidad.Text.ToString + "','" + cbEstado.Text.ToString + "','" + Habitacion.ToString + "','" + cliente.ToString + "')"
        'If (conexion.insert(agregar, txtID.Text, txtFechai.Text, Habitacion, txtFechaF.Text)) Then
        'MessageBox.Show("Datos agregados exitosamente")
        'llenar()
        'mpiar()

        '    Else
        '        MessageBox.Show("Ya esta reserverado ese cuarto a esa fecha")
        '    End If
        'Else
        'MessageBox.Show("Revise los datos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    conexion.conexion.Close()
        'End Try
        If txtCantidad.Text = "" Or txtFechaF.Text = "" Or txtNum.Text = "" Or cbCliente.Text = "" Or txtFechai.Text = "" Or cbEstado.Text = "" Or cbHabitacion.Text = "" Then
            MessageBox.Show("Debe llenar todas las casillas ", "Error")
            Exit Sub
        End If
        Dim IdReservacion, IdHabitacion, IdHuesped As Integer
        Dim NumTarjeta As String

        NumTarjeta = txtNum.Text
        Dim temporal As Boolean = conexion.InsertarReservacion(IdReservacion, IDate, FDate, Dates, NumTarjeta, IdHuesped, IdHabitacion)

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

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

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
End Class