Imports System.Data.SqlClient

'Public Class Usuarios
'    Dim conexion As Conexion = New Conexion()
'    Dim tabla As New DataTable
'    Private Sub BtnListar_Click(sender As Object, e As EventArgs) Handles BtnListar.Click
'        Try
'            tabla = conexion.ListarUsuarios()
'            If tabla.Rows.Count <> 0 Then
'                dtgDatos.DataSource = tabla
'            Else
'                dtgDatos.DataSource = Nothing
'            End If
'        Catch ex As Exception
'            MsgBox("Error al Listar")
'        End Try
'    End Sub

'    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

'        If txtUserName.Text = "" Or txtUserName.Text = "" Or cmbTipo.Text = "" Or TxtPassword.Text = "" Or txtIdentidad.Text = "" Then
'            MessageBox.Show("Debe llenar todas las casillas ", "Error")
'            Exit Sub
'        End If
'        Dim UserName, Password, Identidad, TipoU As String

'        UserName = txtUserName.Text
'        Password = TxtPassword.Text
'        Identidad = txtIdentidad.Text
'        TipoU = cmbTipo.Text
'        Dim temporal As Boolean = conexion.InsertarUsuario(UserName, Password, Identidad, TipoU)

'        Try

'            If temporal Then
'                MsgBox("Ingresado correctamente")
'            Else
'                MsgBox("Error al Ingresar")
'            End If
'        Catch ex As Exception
'            MsgBox(ex.Message)
'        Finally
'            Limpiar()
'        End Try
'    End Sub
'    Private Sub Limpiar()
'        txtUserName.Clear()
'        TxtPassword.Clear()
'        cmbTipo.Text = ""
'    End Sub

'    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
'        Dim UserName, Password As String

'        UserName = txtUserName.Text
'        Password = TxtPassword.Text

'        Try
'            If conexion.actualizarUsuarios(UserName, Password) Then
'                MsgBox("Actualizado correctamente")
'            Else
'                MsgBox("Error al Actualizar")
'            End If
'            BtnEditar.Visible = False
'            BtnAgregar.Visible = True
'            LblCambiar.Visible = True
'            btnEliminar.Visible = True
'        Catch ex As Exception
'            MsgBox(ex.Message)
'        Finally
'            Limpiar()
'        End Try
'    End Sub

'    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
'        If txtUserName.Text = "" Or txtUserName.Text = "" Then
'            MessageBox.Show("Debe Ingresar el Nombre del Usuario", "Error")
'            Exit Sub
'        End If

'        Try
'            Dim UserName, Password As String
'            Dim TipoU As Integer

'            UserName = txtUserName.Text
'            Password = TxtPassword.Text

'            TipoU = cmbTipo.SelectedIndex
'            tabla = conexion.ConsultarUsuario(UserName)
'            If tabla.Rows.Count <> 0 Then
'                dtgDatos.DataSource = tabla
'            Else
'                dtgDatos.DataSource = Nothing
'            End If
'        Catch ex As Exception
'            MsgBox("Error al consultar el Usuario")
'        End Try
'    End Sub

'    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        txtIdentidad.Focus()
'        BtnEditar.Visible = False
'        btnCancelar.Visible = False
'        Dim strcomando As String
'        strcomando = "Select * from TipoEmpleado"
'        Dim adapter As SqlDataAdapter
'        Dim data As DataSet
'        adapter = New .SqlDataAdapter(strcomando, conexion.conexion)
'        data = New DataSet
'        adapter.Fill(data)
'        cmbTipo.DataSource = data.Tables(0)
'        cmbTipo.DisplayMember = "Puesto"
'    End Sub

'    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LblCambiar.LinkClicked
'        BtnEditar.Visible = True
'        LblCambiar.Visible = False
'        btnCancelar.Visible = True
'        btnEliminar.Visible = False
'        My.Forms.Usuarios.AcceptButton = BtnEditar

'    End Sub

'    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
'        BtnAgregar.Visible = True
'        btnCancelar.Visible = False
'        BtnEditar.Visible = False
'        LblCambiar.Visible = True
'        btnEliminar.Visible = True
'    End Sub

'    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
'        If txtUserName.Text = "" Then
'            MessageBox.Show("Debe Ingresar el Nombre del Usuario", "Error")
'            Exit Sub
'        End If

'        Dim UserName As String
'        UserName = txtUserName.Text
'        Try
'            Dim salir As String

'            salir = MsgBox("¿Esta seguro que desea Eliminar el Usuario?", 36, "SALIR")
'            If salir = 6 Then
'                If conexion.EliminarUsuario(UserName) Then
'                    MsgBox("Usuario Eliminado")
'                End If
'            Else
'                Exit Sub
'            End If

'        Catch ex As Exception
'            MsgBox(ex.Message)
'        End Try

'    End Sub

'End Class