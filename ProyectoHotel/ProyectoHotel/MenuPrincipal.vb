Imports System.Runtime.InteropServices
Public Class MenuPrincipal

#Region "Funcionalidad Form"

    'RESIZE DEL FORMULARIO- CAMBIAR TAMAÑO'
    Dim cGrip As Integer = 10
    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                    >= (Me.ClientSize.Width - cGrip)) _
                    AndAlso (pos.Y _
                    >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    '----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL' 
    Dim sizeGripRectangle As Rectangle
    Dim tolerance As Integer = 15



    '---------------MOVER EL FORM
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Dim lx, ly As Integer
    Dim sw, sh As Integer



    Private Sub btnTrabajos_Click(sender As Object, e As EventArgs)
        'AbrirFormEnPanel(Of ArreglosUnidimencional)()
        btnClientes.BackColor = Color.FromArgb(12, 61, 92)
    End Sub

    Private Sub btnCerrar_Click_1(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub btnMaximizar_Click_1(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        lx = Me.Location.X
        ly = Me.Location.Y
        sw = Me.Size.Width
        sh = Me.Size.Height
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
    End Sub

    Private Sub btnRestaurar_Click_1(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)
        btnMaximizar.Visible = True
        btnRestaurar.Visible = False
    End Sub

    Private Sub btnMinimizar_Click_1(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub abrirFormulario(ByVal formHijo As Object)
        If btnExtras.Controls.Count > 0 Then
            Me.btnExtras.Controls.RemoveAt(0)
        End If
        Dim frm As Form = TryCast(formHijo, Form)
        frm.TopLevel = False
        frm.Dock = DockStyle.Fill
        Me.btnExtras.Controls.Add(frm)
        Me.btnExtras.Tag = frm
        frm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        abrirFormulario(New TipoHabitacion)
        hideSubmenu()
    End Sub

    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        abrirFormulario(New Empleados)
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        abrirFormulario(New Clientes)
    End Sub

    Private Sub btnExtra_Click(sender As Object, e As EventArgs) Handles btnExtra.Click
        abrirFormulario(New Extras)
        hideSubmenu()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        abrirFormulario(New Habitaciones)
    End Sub

    Private Sub btnHorarios_Click(sender As Object, e As EventArgs) Handles btnHorarios.Click
        abrirFormulario(New Horarios)
        hideSubmenu()
    End Sub

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubmenu()
    End Sub

    Private Sub PanelBarraTitulo_MouseMove_1(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnTareas_Click(sender As Object, e As EventArgs)
        'AbrirFormEnPanel(Of BolsaSolidaria)()
        btnEmpleados.BackColor = Color.FromArgb(12, 61, 92)
    End Sub

    Private Sub btnReservacion_Click(sender As Object, e As EventArgs) Handles btnReservacion.Click
        showSubmenu(PanelSubmenuRes)
    End Sub

    Private Sub Mantenimiento_Click(sender As Object, e As EventArgs)
        showSubmenu(PanelSubmenuMan)
    End Sub

#End Region

    Private Sub hideSubmenu()
        PanelSubmenuMan.Visible = False
        PanelSubmenuRes.Visible = False
    End Sub

    Private Sub showSubmenu(submenu As Panel)
        If submenu.Visible = False Then
            hideSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub Mantenimiento_Click_1(sender As Object, e As EventArgs) Handles Mantenimiento.Click
        showSubmenu(PanelSubmenuMan)
    End Sub

    Private Sub btnFactura_Click(sender As Object, e As EventArgs) Handles btnFactura.Click
        hideSubmenu()
    End Sub

    Private Sub btnReservar_Click(sender As Object, e As EventArgs) Handles btnReservar.Click
        hideSubmenu()
    End Sub

    Private Sub txtUsuarios_Click(sender As Object, e As EventArgs) Handles txtUsuarios.Click
        abrirFormulario(New Usuarios)
    End Sub



End Class
