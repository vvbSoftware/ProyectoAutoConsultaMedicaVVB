﻿Imports System.Runtime.InteropServices

Public Class FrmPrincipalGerente

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbNombre.Text = FrmLogIn.gere._pNom
        fotoPerfil.Image = ObtenerImagen(FrmLogIn.gere._ci)

        'Me.lbTitulo.Text = Res.titulo_app
        'Me.btnIngresar.Text = Res.btn_ingresar
        'Me.btnIngresarMedico.Text = Res.btn_ingrMed
        'Me.btnModificar.Text = Res.btn_modificar
        'Me.BtnEliminar.Text = Res.btn_eliminar
        'Me.btnCerrar.Text = Res.btn_cerrarSesion
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("Seguro que desa salir?", "Advertencia",
         MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnSolicitudes.Click
        OpenChildForm(New FrmIngresarGerente, PanelChildForm)
    End Sub

    Private Sub btnIngresarMedico_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        OpenChildForm(New FrmMedicoGerente, PanelChildForm)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        OpenChildForm(New FrmModificarGerente, PanelChildForm)
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        OpenChildForm(New FrmEliminarGerente, PanelChildForm)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MessageBox.Show("Seguro que desa salir?", "Advertencia",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub fotoPerfil_Click(sender As Object, e As EventArgs) Handles fotoPerfil.Click
        GuardarImagen(FrmLogIn.gere._ci, ofdFoto, fotoPerfil)

    End Sub

#Region "Hover's"

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClose_MouseHover(sender As Object, e As EventArgs) Handles btnClose.MouseHover
        btnClose.BackColor = Color.FromArgb(48, 63, 105)
    End Sub

    Private Sub btnClose_MouseLeave(sender As Object, e As EventArgs) Handles btnClose.MouseLeave
        btnClose.BackColor = Color.FromArgb(26, 31, 55)
    End Sub

    Private Sub btnMinimize_MouseHover(sender As Object, e As EventArgs) Handles btnMinimize.MouseHover
        btnMinimize.BackColor = Color.FromArgb(48, 63, 105)

    End Sub

    Private Sub btnMinimize_MouseLeave(sender As Object, e As EventArgs) Handles btnMinimize.MouseLeave
        btnMinimize.BackColor = Color.FromArgb(26, 31, 55)
    End Sub

#End Region

#Region "poder mover el form"

    'DLLImport,Significa que el método declarado a
    'continuación no está en .NET, sino en un archivo DLL externo (nativo).
    'En este caso, se encuentra en el archivo User32.dll, que es un componente
    'estándar de Windows. El cual nos permite utilizar los eventos/método del sistema
    'operativo, en este caso capturar las señales del mouse.
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub titleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles TopPanel.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub topPanel_Paint(sender As Object, e As PaintEventArgs) Handles TopPanel.Paint

    End Sub

#End Region 'region de mover form

End Class